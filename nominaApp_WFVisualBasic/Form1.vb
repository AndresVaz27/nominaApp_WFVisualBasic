Imports System.Drawing.Imaging
Imports System.Globalization
Imports System.IO
Imports System.Net.Mail
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class Form1
    Public ofd As OpenFileDialog
    Public imagesPath As String
    Public devicesExist As Boolean
    Public myDevices As FilterInfoCollection
    Public myWebCam As VideoCaptureDevice
    Private imageCounter As Integer = 0
    Private counterFilePath As String = "counter.txt"
    Public photoPath As String

#Region "Form1"
    ''' <summary>
    ''' Closes active WebCam and saves DataGridView data when the program is closing.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseWebCam()
        SaveDGVAddEmployee()
    End Sub
    ''' <summary>
    ''' Loads several objects and data when the program opens.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ofd = New OpenFileDialog()
        ' Select the entire row when clicking on any cell
        dgvAddEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAddEmployee.RowHeadersVisible = False
        ' Show Add Employee Menu everytime the app starts
        panelPayroll.Visible = False
        imagesPath = "C:\Users\andre\source\repos\nominaApp_WFVisualBasic\nominaApp_WFVisualBasic\bin\Debug\imagesPath"
        LoadDGVRecibos()
        GetImageCounter()
        LoadDepartments()
        LoadDevices()
        TotalPay()
        EliminarFilasVacias(dgvAddEmployee)
    End Sub

    ''' <summary>
    ''' Reads data contained in departamentos.txt to fill ComboBox2.
    ''' </summary>
    Public Sub LoadDepartments()
        ' Add every existing Department in ComboBox2.
        Dim departamentos As String = "departamentos.txt"
        If File.Exists(departamentos) Then
            Using reader As New StreamReader(departamentos)
                Dim line As String = reader.ReadLine()
                While line IsNot Nothing
                    Dim values As String() = line.Split(","c)
                    comboBox2.Items.Add(values(0))
                    line = reader.ReadLine()
                End While
            End Using
        End If
        comboBox2.Text = ComboBox2.Items(0).ToString()
    End Sub

    ''' <summary>
    ''' Reads doc that contains Image Counter for new image file generator.
    ''' </summary>
    Public Sub GetImageCounter()
        ' Read counter value from txt file if the file exists.
        If File.Exists(counterFilePath) Then
            Dim counterString As String = File.ReadAllText(counterFilePath)
            Dim counterValue As Integer

            ' Convert string to int value.
            If Integer.TryParse(counterString, counterValue) Then
                ' Assign value to variable.
                imageCounter = counterValue
            End If
        End If
    End Sub

    ''' <summary>
    ''' Reads data containded in datosDGVRecibos.csv to fill DataGridView.
    ''' </summary>
    Public Sub LoadDGVRecibos()
        ' Obtener la ruta del archivo donde se guardaron los datos
        Dim filePath As String = "datosDGVRecibos.csv"

        ' Comprobar si el archivo existe
        If File.Exists(filePath) Then
            ' Crear un StreamReader para leer el archivo
            Using reader As New StreamReader(filePath)
                ' Leer la primera línea que contiene los nombres de las columnas (si el archivo no está vacío)
                Dim line As String = reader.ReadLine()
                If Not String.IsNullOrEmpty(line) Then
                    Dim headers As String() = line.Split(","c)

                    ' Agregar las columnas al DataGridView
                    For Each header As String In headers
                        dgvAddEmployee.Columns.Add(header, header)
                    Next
                End If

                ' Leer las líneas restantes que contienen los datos de las filas
                While (InlineAssignHelper(line, reader.ReadLine())) IsNot Nothing
                    Dim values As String() = line.Split(","c)

                    ' Crear una nueva fila y agregar los valores de las celdas
                    Dim row As New DataGridViewRow()
                    For Each value As String In values
                        row.Cells.Add(New DataGridViewTextBoxCell With {.Value = value})
                    Next

                    ' Agregar la fila al DataGridView
                    dgvAddEmployee.Rows.Add(row)
                End While
                reader.Close()
            End Using
        End If
    End Sub

    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function

    ''' <summary>
    ''' Saves DataGridView's data.
    ''' </summary>
    Public Sub SaveDGVAddEmployee()
        Dim filePath As String = "datosDGVRecibos.csv"

        ' Crear un StreamWriter para escribir en el archivo CSV
        Using writer As New StreamWriter(filePath)
            ' Escribir los nombres de las columnas en la primera línea
            For i As Integer = 0 To dgvAddEmployee.Columns.Count - 1
                writer.Write(dgvAddEmployee.Columns(i).HeaderText)
                If i < dgvAddEmployee.Columns.Count - 1 Then
                    writer.Write(",")
                End If
            Next
            writer.WriteLine()

            ' Escribir el contenido de cada fila en líneas separadas
            For Each row As DataGridViewRow In dgvAddEmployee.Rows
                For i As Integer = 0 To dgvAddEmployee.Columns.Count - 1
                    If Not row.IsNewRow Then
                        writer.Write(row.Cells(i).Value)
                    End If

                    If i < dgvAddEmployee.Columns.Count - 1 Then
                        writer.Write(",")
                    End If
                Next
                writer.WriteLine()
            Next

            writer.Close()
        End Using
    End Sub

#End Region

#Region "Buttons"

    ''' <summary>
    ''' Creates PDF file with Individual Selected Employee's receipt.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnIndividualReceipt_Click_1(sender As Object, e As EventArgs) Handles btnIndividualReceipt.Click
        ' Verifica si se ha seleccionado una fila en el DataGridView
        If dgvAddEmployee.SelectedRows.Count > 0 Then
            ' Obtiene la fila seleccionada
            Dim row As DataGridViewRow = dgvAddEmployee.SelectedRows(0)

            ' Crea un documento PDF
            Dim doc As New Document()

            Try
                ' Abre un cuadro de diálogo Guardar archivo para especificar la ubicación del archivo PDF
                Dim saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "Archivos PDF|*.pdf"
                saveFileDialog.Title = "Guardar como PDF"
                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    ' Crea un escritor de PDF
                    Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(saveFileDialog.FileName, FileMode.Create))
                    doc.Open()

                    ' Agrega los datos de la fila seleccionada al documento PDF
                    For i As Integer = 0 To row.Cells.Count - 1
                        doc.Add(New Paragraph(dgvAddEmployee.Columns(i).HeaderText & ": " & row.Cells(i).Value.ToString()))
                    Next

                    ' Cierra el documento PDF
                    doc.Close()

                    MessageBox.Show("PDF creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Error al crear el PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Por favor, seleccione una fila en el DataGridView.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ''' <summary>
    ''' Creates a PDF File containing every Payroll detail.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPDFPayroll_Click_1(sender As Object, e As EventArgs) Handles btnPDFPayroll.Click
        ' Verifica si hay filas en el DataGridView
        If dgvAddEmployee.Rows.Count > 0 Then
            ' Abre un cuadro de diálogo Guardar archivo para especificar la ubicación del archivo PDF
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Archivos PDF|*.pdf"
            saveFileDialog.Title = "Guardar como PDF"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                ' Crea un documento PDF
                Dim doc As New Document()

                Try
                    ' Crea un escritor de PDF
                    Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(saveFileDialog.FileName, FileMode.Create))
                    doc.Open()

                    Dim currentRow As Integer = 0
                    Dim totalRows As Integer = dgvAddEmployee.Rows.Count

                    ' Imprime las filas en el documento PDF
                    While currentRow <= totalRows - 2
                        Dim row As DataGridViewRow = dgvAddEmployee.Rows(currentRow)

                        ' Agrega los datos de la fila al documento PDF
                        For j As Integer = 0 To row.Cells.Count - 1
                            Dim cellValue As Object = row.Cells(j).Value
                            Dim cellText As String = If(cellValue IsNot Nothing, cellValue.ToString(), String.Empty)
                            doc.Add(New Paragraph(dgvAddEmployee.Columns(j).HeaderText & ": " & cellText))
                        Next

                        doc.Add(New Paragraph("-----------------"))
                        currentRow += 1
                    End While

                    ' Imprime el total al final
                    Dim totalText As String = "Total = " & lblPayValue.Text & " " & lblNumeroEnLetras.Text
                    doc.Add(New Paragraph(totalText))

                    ' Cierra el documento PDF
                    doc.Close()

                    ' Crea un mensaje de correo electrónico
                    Dim mailMessage As New MailMessage()
                    mailMessage.From = New MailAddress("andresvazquezo1@hotmail.com")
                    mailMessage.To.Add("andresvazquezo1@hotmail.com")
                    mailMessage.Subject = "Payroll PDF"
                    mailMessage.Body = "You will find the Payroll.pdf file attached in this mail."

                    ' Adjunta el archivo PDF al mensaje de correo electrónico
                    Dim attachment As New Attachment(saveFileDialog.FileName)
                    mailMessage.Attachments.Add(attachment)

                    ' Configura el cliente SMTP y envía el correo electrónico
                    Dim smtpClient As New SmtpClient("smtp-mail.outlook.com", 587)
                    smtpClient.EnableSsl = True
                    smtpClient.Credentials = New System.Net.NetworkCredential("andresvazquezo1@hotmail.com", "acereros27")
                    smtpClient.Send(mailMessage)

                    MessageBox.Show("Correo electrónico enviado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error al crear el PDF o enviar el correo electrónico: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("No hay filas en el DataGridView para imprimir.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ''' <summary>
    ''' Show Payroll Menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPayrollMenu_Click(sender As Object, e As EventArgs) Handles btnPayrollMenu.Click
        panelAddEmployee.Visible = False
        panelPayroll.Visible = True
    End Sub

    ''' <summary>
    ''' Show Add Employee Menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        panelAddEmployee.Visible = True
        panelPayroll.Visible = False
    End Sub

    ''' <summary>
    ''' Browse files using an OpenFileDialog to find an Image for the New Employee
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnBrowse_Click_1(sender As Object, e As EventArgs) Handles btnBrowse.Click
        ' Filter that shows Image files only
        ofd.Filter = "Image Files (*.png, *.jpg)|*.png;*.jpg"
        If ofd.ShowDialog() = DialogResult.Cancel Then
            MessageBox.Show("An Image is required to add a new Employee.", "Image required", MessageBoxButtons.OK)
            Return
        End If
        pbxEmployee.Image = System.Drawing.Image.FromFile(ofd.FileName)
    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim employee As New Employee(txtName.Text, numericSalary.Value, comboBox2.Text, ofd.FileName, photoPath, dgvAddEmployee, txtName, numericSalary, comboBox2, pbxEmployee, ofd)
        photoPath = Nothing
        TotalPay()
    End Sub

    ''' <summary>
    ''' Calculate Payroll
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        If txtNamePayroll.Text = "" Then
            MessageBox.Show("Please double click on a row that contains Employee's Information before modifying.", "No Employee Selected.")
            Return
        End If

        Dim dr As DialogResult = MessageBox.Show("Do you want to modify this employee?", "Modify Employee?", MessageBoxButtons.YesNo)
        Select Case dr
            Case DialogResult.Yes
                Dim emp As New Employee()
                emp.Name = txtNamePayroll.Text
                emp.Salary = Convert.ToDecimal(lblSalaryPayrollValue.Text)
                emp.Department = lblDepartmentPayroll.Text
                emp.CalcularBono(emp.Department)

                Dim Total As Decimal = numericHours.Value * Convert.ToDecimal(lblSalaryPayrollValue.Text)
                Dim bonoTotal As Decimal = emp.Bono * Total
                Total += bonoTotal
                Total += (numericRestDay.Value * 2) * Convert.ToDecimal(lblSalaryPayrollValue.Text)
                Total += (numericHoliday.Value * 2) * Convert.ToDecimal(lblSalaryPayrollValue.Text)

                lblBonusValue.Text = bonoTotal.ToString()
                lblBonusValue.Visible = True
                lblBonus.Visible = True
                lblTotalPerceptionsValue.Text = Total.ToString()
                lblTotalPerceptionsValue.Visible = True
                lblPerceptions.Visible = True

                Total -= emp.Salary * numericAbsence.Value
                Total -= numericDiscount.Value
                Dim deductions As Decimal = (numericAbsence.Value * emp.Salary) + numericDiscount.Value
                lblTotalDeductionsValue.Text = deductions.ToString()
                lblTotalDeductionsValue.Visible = True
                lblDeductions.Visible = True

                If dgvAddEmployee.SelectedRows.Count > 0 Then
                    Dim selectedRow As DataGridViewRow = dgvAddEmployee.SelectedRows(0)

                    ' Update the values of the selected row
                    selectedRow.Cells(0).Value = txtNamePayroll.Text
                    selectedRow.Cells(1).Value = lblDepartmentPayroll.Text
                    selectedRow.Cells(2).Value = lblSalaryPayrollValue.Text
                    selectedRow.Cells(3).Value = selectedRow.Cells(3).Value.ToString()
                    selectedRow.Cells(4).Value = Total
                    selectedRow.Cells(5).Value = numericHours.Value.ToString()
                    selectedRow.Cells(6).Value = numericRestDay.Value.ToString()
                    selectedRow.Cells(7).Value = numericHoliday.Value.ToString()
                    selectedRow.Cells(8).Value = lblBonusValue.Text
                    selectedRow.Cells(9).Value = lblTotalPerceptionsValue.Text
                    selectedRow.Cells(10).Value = numericAbsence.Value.ToString()
                    selectedRow.Cells(11).Value = numericDiscount.Value.ToString()
                    selectedRow.Cells(12).Value = lblTotalDeductionsValue.Text

                    ' Refresh the DataGridView display
                    dgvAddEmployee.Refresh()
                End If

                TotalPay()
                Return
            Case DialogResult.No
                Return
        End Select
    End Sub

#End Region

#Region "dgvAddEmployee"

    ''' <summary>
    ''' Delete empty rows when the program opens method.
    ''' </summary>
    ''' <param name="dataGridView"></param>
    Private Sub EliminarFilasVacias(dataGridView As DataGridView)
        For i As Integer = dataGridView.Rows.Count - 1 To 0 Step -1
            Dim row As DataGridViewRow = dataGridView.Rows(i)
            If row.Cells(0).Value Is Nothing OrElse String.IsNullOrWhiteSpace(row.Cells(0).Value.ToString()) Then
                Try
                    dataGridView.Rows.Remove(row)
                Catch ex As Exception
                    Continue For
                End Try
            End If
        Next
    End Sub

    ''' <summary>
    ''' Cleans controls when a selected DataGridView's row changes.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvAddEmployee_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAddEmployee.SelectionChanged
        txtNamePayroll.Text = String.Empty
        lblSalaryPayrollValue.Text = ""
        pbxPayroll.Image = Nothing
        lblDepartmentPayroll.Text = String.Empty
        numericHours.Value = 0
        numericRestDay.Value = 0
        numericHoliday.Value = 0
        lblBonusValue.Text = String.Empty
        lblTotalPerceptionsValue.Text = String.Empty
        numericAbsence.Value = 0
        numericDiscount.Value = 0
        lblTotalDeductionsValue.Text = String.Empty
        txtName.Text = String.Empty
        numericSalary.Value = 0
        pbxEmployee.Image = Nothing
        txtNamePayroll.Text = String.Empty
        lblSalaryPayrollValue.Text = ""
        lblDepartmentPayroll.Text = String.Empty
        pbxPayroll.Image = Nothing
        lblBonusValue.Visible = False
        lblBonus.Visible = False
        lblTotalPerceptionsValue.Visible = False
        lblTotalDeductionsValue.Visible = False
    End Sub

    ''' <summary>
    ''' Convert number toText method.
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    Private Function toText(ByVal value As Double) As String
        Dim Num2Text As String = ""
        value = Math.Truncate(value)

        If value = 0 Then
            Num2Text = "CERO"
        ElseIf value = 1 Then
            Num2Text = "UNO"
        ElseIf value = 2 Then
            Num2Text = "DOS"
        ElseIf value = 3 Then
            Num2Text = "TRES"
        ElseIf value = 4 Then
            Num2Text = "CUATRO"
        ElseIf value = 5 Then
            Num2Text = "CINCO"
        ElseIf value = 6 Then
            Num2Text = "SEIS"
        ElseIf value = 7 Then
            Num2Text = "SIETE"
        ElseIf value = 8 Then
            Num2Text = "OCHO"
        ElseIf value = 9 Then
            Num2Text = "NUEVE"
        ElseIf value = 10 Then
            Num2Text = "DIEZ"
        ElseIf value = 11 Then
            Num2Text = "ONCE"
        ElseIf value = 12 Then
            Num2Text = "DOCE"
        ElseIf value = 13 Then
            Num2Text = "TRECE"
        ElseIf value = 14 Then
            Num2Text = "CATORCE"
        ElseIf value = 15 Then
            Num2Text = "QUINCE"
        ElseIf value < 20 Then
            Num2Text = "DIECI" & toText(value - 10)
        ElseIf value = 20 Then
            Num2Text = "VEINTE"
        ElseIf value < 30 Then
            Num2Text = "VEINTI" & toText(value - 20)
        ElseIf value = 30 Then
            Num2Text = "TREINTA"
        ElseIf value = 40 Then
            Num2Text = "CUARENTA"
        ElseIf value = 50 Then
            Num2Text = "CINCUENTA"
        ElseIf value = 60 Then
            Num2Text = "SESENTA"
        ElseIf value = 70 Then
            Num2Text = "SETENTA"
        ElseIf value = 80 Then
            Num2Text = "OCHENTA"
        ElseIf value = 90 Then
            Num2Text = "NOVENTA"
        ElseIf value < 100 Then
            Num2Text = toText(Math.Truncate(value / 10) * 10) & " Y " & toText(value Mod 10)
        ElseIf value = 100 Then
            Num2Text = "CIEN"
        ElseIf value < 200 Then
            Num2Text = "CIENTO " & toText(value - 100)
        ElseIf (value = 200) OrElse (value = 300) OrElse (value = 400) OrElse (value = 600) OrElse (value = 800) Then
            Num2Text = toText(Math.Truncate(value / 100)) & "CIENTOS"
        ElseIf value = 500 Then
            Num2Text = "QUINIENTOS"
        ElseIf value = 700 Then
            Num2Text = "SETECIENTOS"
        ElseIf value = 900 Then
            Num2Text = "NOVECIENTOS"
        ElseIf value < 1000 Then
            Num2Text = toText(Math.Truncate(value / 100) * 100) & " " & toText(value Mod 100)
        ElseIf value = 1000 Then
            Num2Text = "MIL"
        ElseIf value < 2000 Then
            Num2Text = "MIL " & toText(value Mod 1000)
        ElseIf value < 1000000 Then
            Num2Text = toText(Math.Truncate(value / 1000)) & " MIL"
            If (value Mod 1000) > 0 Then
                Num2Text = Num2Text & " " & toText(value Mod 1000)
            End If
        ElseIf value = 1000000 Then
            Num2Text = "UN MILLON"
        ElseIf value < 2000000 Then
            Num2Text = "UN MILLON " & toText(value Mod 1000000)
        ElseIf value < 1000000000000 Then
            Num2Text = toText(Math.Truncate(value / 1000000)) & " MILLONES "
            If (value - Math.Truncate(value / 1000000) * 1000000) > 0 Then
                Num2Text = Num2Text & " " & toText(value - Math.Truncate(value / 1000000) * 1000000)
            End If
        ElseIf value = 1000000000000 Then
            Num2Text = "UN BILLON"
        ElseIf value < 2000000000000 Then
            Num2Text = "UN BILLON " & toText(value - Math.Truncate(value / 1000000000000) * 1000000000000)
        Else
            Num2Text = toText(Math.Truncate(value / 1000000000000)) & " BILLONES"
            If (value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0 Then
                Num2Text = Num2Text & " " & toText(value - Math.Truncate(value / 1000000000000) * 1000000000000)
            End If
        End If

        Return Num2Text
    End Function

    ''' <summary>
    ''' Calls TotalPay method everytime a row from the DataGridView is deleted.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvAddEmployee_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvAddEmployee.RowsRemoved
        TotalPay()
    End Sub

    ''' <summary>
    ''' Calculates total Payroll showing quantity in numbers and letters calling toText Method.
    ''' </summary>
    Private Sub TotalPay()
        Dim cultureInfo As New CultureInfo("es-MX")
        Dim celda As Decimal
        Dim suma As Decimal = 0

        For Each row As DataGridViewRow In dgvAddEmployee.Rows

            If row.Cells(4).Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(row.Cells(4).Value.ToString()) Then
                celda = Convert.ToDecimal(row.Cells(4).Value)
                suma += celda
            End If
        Next

        lblPayValue.Text = suma.ToString("C", cultureInfo)
        lblNumeroEnLetras.Text = toText(Convert.ToDouble(suma)) & " PESOS."
    End Sub

    ''' <summary>
    ''' Show Employee's Info on Controls when clicking a DataGridView Row
    ''' </summary>
    ''' <param name="sender">DataGridView</param>
    ''' <param name="e">DataGridViewCellEventArgs</param>
    Private Sub dgvAddEmployee_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAddEmployee.CellDoubleClick
        Try
            ' Obtener la ruta de la imagen
            Dim rutaImagen As String = dgvAddEmployee.Rows(e.RowIndex).Cells(3).Value.ToString()
            ' Mostrar la imagen en ambos PictureBox
            pbxEmployee.Image = System.Drawing.Image.FromFile(rutaImagen)
            pbxPayroll.Image = System.Drawing.Image.FromFile(rutaImagen)
            ' Mostrar el nombre del empleado en ambos TextBox
            txtName.Text = dgvAddEmployee.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtNamePayroll.Text = dgvAddEmployee.Rows(e.RowIndex).Cells(0).Value.ToString()
            ' Mostrar el salario por hora del empleado en ambos controles numéricos
            numericSalary.Value = Convert.ToDecimal(dgvAddEmployee.Rows(e.RowIndex).Cells(2).Value)
            lblSalaryPayrollValue.Text = dgvAddEmployee.Rows(e.RowIndex).Cells(2).Value.ToString()
            lblDepartmentPayroll.Text = dgvAddEmployee.Rows(e.RowIndex).Cells(1).Value.ToString()
            numericHours.Value = 0
            numericRestDay.Value = 0
            numericHoliday.Value = 0
            lblBonusValue.Text = String.Empty
            lblTotalPerceptionsValue.Text = String.Empty
            numericAbsence.Value = 0
            numericDiscount.Value = 0
            lblTotalDeductionsValue.Text = String.Empty
        Catch ex As Exception
            dgvAddEmployee_SelectionChanged(sender, e)
            MessageBox.Show("Unable to show Employee's Info")
        End Try
    End Sub

    ''' <summary>
    ''' Delete Employee from the DataGridView using Suprimir | Delete Key.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvAddEmployee_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvAddEmployee.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim dr As DialogResult = MessageBox.Show("Would you like to delete this row?", "Delete Row", MessageBoxButtons.YesNo)
            Select Case dr
                Case DialogResult.Yes
                    Try
                        ' Obtener la fila seleccionada.
                        Dim selectedRow As DataGridViewRow = dgvAddEmployee.SelectedRows(0)
                        ' Eliminar la fila seleccionada.
                        dgvAddEmployee.Rows.Remove(selectedRow)
                        ' Limpiar los controles.
                        txtName.Text = String.Empty
                        txtNamePayroll.Text = String.Empty
                        numericSalary.Value = 0
                        lblSalaryPayrollValue.Text = ""
                        ' Descomenta el siguiente bloque si deseas desmarcar todos los elementos en checkedDepartment.
                        'For i As Integer = 0 To Me.checkedDepartment.Items.Count - 1
                        '    Me.checkedDepartment.SetItemChecked(i, False)
                        'Next
                        lblDepartmentPayroll.Text = String.Empty
                        pbxEmployee.Image = Nothing
                        pbxPayroll.Image = Nothing
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                Case DialogResult.No
                    ' No hacer nada.
            End Select
        End If
    End Sub

#End Region

#Region "Video Input Devices"

    ''' <summary>
    ''' Load Video Input Devices to show in ComboBox1.
    ''' </summary>
    Public Sub LoadDevices()
        ' Collection of Video Input Devices.
        myDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If myDevices.Count > 0 Then
            devicesExist = True
            For i As Integer = 0 To myDevices.Count - 1
                ' Add each item from the collection (myDevices) to ComboBox1.
                comboBox1.Items.Add(myDevices(i).Name.ToString())
            Next i
            ' Show default device in ComboBox1.
            comboBox1.Text = myDevices(0).Name.ToString()
        Else
            devicesExist = False
        End If
    End Sub

    ''' <summary>
    ''' Start Recording using VideoInputDevice selected in comboBox1.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnStartCam_Click_1(sender As Object, e As EventArgs) Handles btnStartCam.Click
        CloseWebCam()
        lblFace1.Visible = True
        lblFace3.Visible = True
        lblFace2.Visible = True
        lblFace4.Visible = True
        Dim i As Integer = comboBox1.SelectedIndex
        ' Convert device name from collection to the right format (monikerString).
        Dim deviceName As String = myDevices(i).MonikerString
        ' Instance Video Input Device object.
        myWebCam = New VideoCaptureDevice(deviceName)
        ' Everytime there's a new frame taken, call the "Recording Method" to show the Image.
        AddHandler myWebCam.NewFrame, AddressOf Recording
        ' Start using the Device.
        myWebCam.Start()
    End Sub

    ''' <summary>
    ''' Clone the new frame taken and send it to the PictureBox.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="eventArgs"></param>
    Public Sub Recording(sender As Object, eventArgs As NewFrameEventArgs)
        ' Clone the new frame.
        Dim image As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        ' Show the copy of the frame in the PictureBox.
        pbxEmployee.Image = image
    End Sub

    ''' <summary>
    ''' Stop using the Video Input Device (MyWebCam).
    ''' </summary>
    Public Sub CloseWebCam()
        If myWebCam IsNot Nothing AndAlso myWebCam.IsRunning Then
            myWebCam.SignalToStop()
            myWebCam = Nothing
        End If
    End Sub

    ''' <summary>
    ''' Take Photo cropping and saving the image from the picturebox.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnTakePhoto_Click_1(sender As Object, e As EventArgs) Handles btnTakePhoto.Click
        If myWebCam IsNot Nothing AndAlso myWebCam.IsRunning Then
            ' Detener el dispositivo de entrada de video.
            CloseWebCam()

            ' Capturar la imagen desde el PictureBox.
            Dim capturedImage As System.Drawing.Image = pbxEmployee.Image

            ' Calcular las dimensiones deseadas para la foto recortada.
            Dim desiredWidth As Integer = 500 ' Establece el ancho deseado aquí
            Dim desiredHeight As Integer = 500 ' Establece el alto deseado aquí

            ' Calcular el punto de inicio para el recorte.
            Dim x As Integer = (capturedImage.Width - desiredWidth) \ 2
            Dim y As Integer = (capturedImage.Height - desiredHeight) \ 2

            ' Crear un nuevo Bitmap para la foto recortada.
            Dim croppedImage As New Bitmap(desiredWidth, desiredHeight)

            ' Crear un objeto Graphics a partir del Bitmap croppedImage.
            Using graphics As Graphics = Graphics.FromImage(croppedImage)
                ' Establecer el modo de interpolación en alta calidad para un mejor redimensionamiento.
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic

                ' Dibujar la porción recortada de capturedImage en croppedImage.
                graphics.DrawImage(capturedImage, 0, 0, New System.Drawing.Rectangle(x, y, desiredWidth, desiredHeight), GraphicsUnit.Pixel)
            End Using

            ' Generar un nombre de archivo único para la foto recortada.
            Dim fileName As String = String.Format("imagen{0}.jpg", imageCounter)

            ' Guardar croppedImage en la ruta especificada.
            Dim croppedImagePath As String = Path.Combine(imagesPath, fileName)
            croppedImage.Save(croppedImagePath, ImageFormat.Jpeg)

            ' Incrementar la variable imageCounter y guardar el valor actualizado en un archivo de texto.
            imageCounter += 1
            File.WriteAllText(counterFilePath, imageCounter.ToString())

            ' Actualizar la variable photoPath con la ruta de la foto recortada.
            photoPath = croppedImagePath

            ' Cargar la foto recortada en el PictureBox pbxEmployee.
            pbxEmployee.Image = System.Drawing.Image.FromFile(photoPath)
            lblFace1.Visible = False
            lblFace2.Visible = False
            lblFace3.Visible = False
            lblFace4.Visible = False
        End If
    End Sub

#End Region

End Class
