Imports System.Drawing.Imaging
Imports System.IO
Imports AForge.Video
Imports AForge.Video.DirectShow

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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Show Add Employee Menu everytime the app starts
        panelPayroll.Visible = False
        Me.WindowState = FormWindowState.Maximized
        ofd = New OpenFileDialog()
        'Select the entire row when clicking on any cell
        dgvAddEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAddEmployee.RowHeadersVisible = False
        panelPayroll.Visible = False
        imagesPath = "C:\Users\andre\source\repos\nominaApp - Copy\nominaApp\bin\Debug\imagesPath"
        ' Get File Path where Data is Saved
        Dim filePath As String = "datos.csv"
        ' Verify if the file exists.
        If File.Exists(filePath) Then
            'Create StreamReader to Read the file.
            Using reader As New StreamReader(filePath)
                'Read the first line to get the column headers.
                Dim line As String = reader.ReadLine()
                If Not String.IsNullOrEmpty(line) Then
                    Dim headers As String() = line.Split(","c)

                    For Each header As String In headers
                        ' Add columns to datagridview.
                        dgvAddEmployee.Columns.Add(header, header)
                    Next
                End If
                'Read the rest of the lines that contain the rows data.
                line = reader.ReadLine()
                While (line) IsNot Nothing
                    Dim values As String() = line.Split(","c)
                    'Create a new row adding the cells data.
                    Dim row As New DataGridViewRow()
                    For Each value As String In values
                        row.Cells.Add(New DataGridViewTextBoxCell() With {.Value = value})
                    Next
                    'Add the row to the DataGridView.
                    dgvAddEmployee.Rows.Add(row)
                    line = reader.ReadLine()
                End While

                reader.Close()
            End Using
        End If
        'Read counter value from txt file if the file exists.
        If File.Exists(counterFilePath) Then
            Dim counterString As String = File.ReadAllText(counterFilePath)
            Dim counterValue As Integer
            'Convert string to int value
            If Integer.TryParse(counterString, counterValue) Then
                'Asign value to variable.
                imageCounter = counterValue
            End If
        End If
        LoadDevices()
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseWebCam()
        ' Get the file path where data is saved.
        Dim filePath As String = "datos.csv"

        Using writer As New StreamWriter(filePath)
            ' Write headers on the first line.
            For i As Integer = 0 To dgvAddEmployee.Columns.Count - 1
                writer.Write(dgvAddEmployee.Columns(i).HeaderText)
                If i < dgvAddEmployee.Columns.Count - 1 Then
                    writer.Write(",")
                End If
            Next
            writer.WriteLine()

            ' Write the content of each row on a different line per row.
            For Each row As DataGridViewRow In dgvAddEmployee.Rows
                For i As Integer = 0 To dgvAddEmployee.Columns.Count - 1
                    If Not row.IsNewRow Then
                        writer.Write(row.Cells(i).Value.ToString())
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
    Private Sub btnStartCam_Click(sender As Object, e As EventArgs) Handles btnStartCam.Click
        CloseWebCam()
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
    ''' Take a photo by saving the image from the PictureBox.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnTakePhoto_Click(sender As Object, e As EventArgs) Handles btnTakePhoto.Click
        If myWebCam IsNot Nothing AndAlso myWebCam.IsRunning Then
            ' Stop the Video Input Device.
            CloseWebCam()
            ' Assign a new name to the photo.
            Dim fileName As String = String.Format("imagen{0}.jpg", imageCounter)
            ' Save the image from the PictureBox.
            pbxEmployee.Image.Save(Path.Combine(imagesPath, fileName), ImageFormat.Jpeg)
            ' Increment the counter to ensure the next photo has a different name.
            imageCounter += 1
            ' Save the imageCounter value in a text document.
            File.WriteAllText(counterFilePath, imageCounter.ToString())
            photoPath = Path.Combine(imagesPath, fileName)
            pbxEmployee.Image = Image.FromFile(photoPath)
        End If
    End Sub
#End Region

#Region "Buttons"
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
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        ' Set the filter to show image files only
        ofd.Filter = "Image Files (*.png)|*.png|Image Files (*.jpg)|*.jpg"
        ' Show the OpenFileDialog and check if the user selected a file
        If ofd.ShowDialog() = DialogResult.Cancel Then
            MessageBox.Show("An Image is required to add a new Employee.", "Image required", MessageBoxButtons.OK)
            Return
        End If
        ' Load the selected image into the PictureBox
        pbxEmployee.Image = Image.FromFile(ofd.FileName)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            ' Create a new instance of the Employee class using the constructor
            Dim employee As New Employee(txtName.Text, numericSalary.Value, checkedDepartment.Text, ofd.FileName, photoPath, dgvAddEmployee, txtName, numericSalary, checkedDepartment, pbxEmployee, ofd)
        Catch
            MessageBox.Show("Unable to add Employee")
        End Try
    End Sub
    ''' <summary>
    ''' Calculate Payroll
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Create a new instance of the Employee class
        Dim emp As New Employee()

        ' Set the employee's properties with the values from the corresponding controls
        emp.Name = txtNamePayroll.Text
        emp.Salary = numericSalaryPayroll.Value
        emp.Department = lblDepartmentPayroll.Text

        ' Calculate the bonus for the employee
        emp.CalcularBono()

        ' Calculate the total payroll amount
        Dim Total As Decimal = numericHours.Value * numericSalaryPayroll.Value
        Total += numericRestDay.Value * 2 * numericSalaryPayroll.Value
        Total += numericHoliday.Value * 2 * numericSalaryPayroll.Value

        ' Calculate the bonus amount and update the bonus numeric up-down control
        Dim bonusTotal As Decimal = emp.Bono * numericHours.Value
        numericBonus.Value = bonusTotal

        ' Add the bonus amount to the total payroll
        Total += bonusTotal

        ' Calculate the perceptions (total earnings)
        numericPerceptions.Value = Total

        ' Calculate the deductions
        Total -= emp.Salary * numericAbsence.Value
        Total -= numericDiscount.Value
        Dim deductions As Decimal = (numericAbsence.Value * emp.Salary) + numericDiscount.Value
        numericDeductions.Value = deductions

        ' Calculate the final pay amount
        numericPay.Value = Total
    End Sub
#End Region

#Region "CheckedDepartment Control SelectionMode = 1 only"
    ''' <summary>
    ''' Select only 1 item in checkedDepartment Control.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub checkedDepartment_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles checkedDepartment.ItemCheck
        ' If the user is selecting a new item, deselect any other item
        If e.NewValue = CheckState.Checked Then
            For i As Integer = 0 To checkedDepartment.Items.Count - 1
                If i <> e.Index AndAlso checkedDepartment.GetItemChecked(i) Then
                    checkedDepartment.SetItemChecked(i, False)
                End If
            Next
        End If
    End Sub
#End Region

#Region "dgvAddEmployee"
    ''' <summary>
    ''' Show Employee's Info on Controls when clicking a DataGridView Row
    ''' </summary>
    ''' <param name="sender">DataGridView</param>
    ''' <param name="e">DataGridViewCellEventArgs</param>
    Private Sub dgvAddEmployee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAddEmployee.CellClick
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                ' Get Image Path
                Dim imagePath As String = dgvAddEmployee.Rows(e.RowIndex).Cells(3).Value.ToString()
                ' Show the image in both picture boxes
                pbxEmployee.Image = Image.FromFile(imagePath)
                pbxPayroll.Image = Image.FromFile(imagePath)
                ' Show Employee's Name in both textboxes
                txtName.Text = dgvAddEmployee.Rows(e.RowIndex).Cells(0).Value.ToString()
                txtNamePayroll.Text = dgvAddEmployee.Rows(e.RowIndex).Cells(0).Value.ToString()
                ' Show Employee's Salary per Hour in both Numeric Controls
                numericSalary.Value = Convert.ToDecimal(dgvAddEmployee.Rows(e.RowIndex).Cells(2).Value)
                numericSalaryPayroll.Value = Convert.ToDecimal(dgvAddEmployee.Rows(e.RowIndex).Cells(2).Value)
                lblDepartmentPayroll.Text = dgvAddEmployee.Rows(e.RowIndex).Cells(1).Value.ToString()
                numericHours.Value = 0
                numericRestDay.Value = 0
                numericHoliday.Value = 0
                numericBonus.Value = 0
                numericPerceptions.Value = 0
                numericAbsence.Value = 0
                numericDiscount.Value = 0
                numericDeductions.Value = 0
                numericPay.Value = 0
            Else
                txtNamePayroll.Text = String.Empty
                numericSalaryPayroll.Value = 0
                pbxPayroll.Image = Nothing
                lblDepartmentPayroll.Text = String.Empty
                numericHours.Value = 0
                numericRestDay.Value = 0
                numericHoliday.Value = 0
                numericBonus.Value = 0
                numericPerceptions.Value = 0
                numericAbsence.Value = 0
                numericDiscount.Value = 0
                numericDeductions.Value = 0
                numericPay.Value = 0
                Return
            End If
        Catch ex As Exception
            txtName.Text = String.Empty
            numericSalary.Value = 0
            For i As Integer = 0 To Me.checkedDepartment.Items.Count - 1
                Me.checkedDepartment.SetItemChecked(i, False)
            Next
            Me.checkedDepartment.ClearSelected()
            pbxEmployee.Image = Nothing
            txtNamePayroll.Text = String.Empty
            numericSalaryPayroll.Value = 0
            lblDepartmentPayroll.Text = String.Empty
            pbxPayroll.Image = Nothing
            MessageBox.Show("Unable to show Employee's Info")
        End Try
    End Sub
    ''' <summary>
    ''' Delete DataGridView Row
    ''' </summary>
    ''' <param name="sender">DataGridView</param>
    ''' <param name="e">DataGridViewCellEventArgs</param>
    Private Sub dgvAddEmployee_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAddEmployee.CellDoubleClick
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                ' Get Image Path
                Dim imagePath As String = dgvAddEmployee.Rows(e.RowIndex).Cells(3).Value.ToString()
                ' Show the image in both picture boxes
                pbxEmployee.Image = Image.FromFile(imagePath)
                pbxPayroll.Image = Image.FromFile(imagePath)
                ' Show Employee's Name in both textboxes
                txtName.Text = dgvAddEmployee.Rows(e.RowIndex).Cells(0).Value.ToString()
                txtNamePayroll.Text = dgvAddEmployee.Rows(e.RowIndex).Cells(0).Value.ToString()
                ' Show Employee's Salary per Hour in both Numeric Controls
                numericSalary.Value = Convert.ToDecimal(dgvAddEmployee.Rows(e.RowIndex).Cells(2).Value)
                numericSalaryPayroll.Value = Convert.ToDecimal(dgvAddEmployee.Rows(e.RowIndex).Cells(2).Value)
                lblDepartmentPayroll.Text = dgvAddEmployee.Rows(e.RowIndex).Cells(1).Value.ToString()
                numericHours.Value = 0
                numericRestDay.Value = 0
                numericHoliday.Value = 0
                numericBonus.Value = 0
                numericPerceptions.Value = 0
                numericAbsence.Value = 0
                numericDiscount.Value = 0
                numericDeductions.Value = 0
                numericPay.Value = 0
            Else
                txtNamePayroll.Text = String.Empty
                numericSalaryPayroll.Value = 0
                pbxPayroll.Image = Nothing
                lblDepartmentPayroll.Text = String.Empty
                numericHours.Value = 0
                numericRestDay.Value = 0
                numericHoliday.Value = 0
                numericBonus.Value = 0
                numericPerceptions.Value = 0
                numericAbsence.Value = 0
                numericDiscount.Value = 0
                numericDeductions.Value = 0
                numericPay.Value = 0
                Return
            End If
        Catch ex As Exception
            txtName.Text = String.Empty
            numericSalary.Value = 0
            For i As Integer = 0 To Me.checkedDepartment.Items.Count - 1
                Me.checkedDepartment.SetItemChecked(i, False)
            Next
            Me.checkedDepartment.ClearSelected()
            pbxEmployee.Image = Nothing
            txtNamePayroll.Text = String.Empty
            numericSalaryPayroll.Value = 0
            lblDepartmentPayroll.Text = String.Empty
            pbxPayroll.Image = Nothing
            MessageBox.Show("Unable to show Employee's Info")
        End Try
    End Sub

    Private Sub dgvAddEmployee_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvAddEmployee.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim dr As DialogResult = MessageBox.Show("Would you like to delete this row?", "Delete Row", MessageBoxButtons.YesNo)

            Select Case dr
                Case DialogResult.Yes
                    Try
                        ' Get selected Row.
                        Dim selectedRow As DataGridViewRow = dgvAddEmployee.SelectedRows(0)
                        ' Remove the selected Row.
                        dgvAddEmployee.Rows.Remove(selectedRow)
                        ' Clear controls.
                        txtName.Text = String.Empty
                        txtNamePayroll.Text = String.Empty
                        numericSalary.Value = 0
                        numericSalaryPayroll.Value = 0

                        For i As Integer = 0 To Me.checkedDepartment.Items.Count - 1
                            Me.checkedDepartment.SetItemChecked(i, False)
                        Next

                        lblDepartmentPayroll.Text = String.Empty
                        pbxEmployee.Image = Nothing
                        pbxPayroll.Image = Nothing
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                Case DialogResult.No
                    ' Do nothing
            End Select
        End If
    End Sub
#End Region

End Class
