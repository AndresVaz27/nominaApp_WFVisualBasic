Imports System.IO
Friend Class Employee
    Inherits Person
    Implements IBono

    Private form_ As Form1 = New Form1()
    Private bono_ As Decimal
    Private DataGridView_ As DataGridView
    Private NameTextBox_ As TextBox
    Private SalaryNumericUpDown_ As NumericUpDown
    Private ComboBox_ As ComboBox
    Private EmployeePictureBox_ As PictureBox
    Private OpenFileDialog_ As OpenFileDialog
    Public porcentajeBono_ As Decimal

    Public Overrides Function ToString() As String
        Return "Employee added succesfully."
    End Function

    Public Property Bono As Decimal
        Get
            Return bono_
        End Get
        Set(ByVal value As Decimal)
            bono_ = value
        End Set
    End Property

    Private salary_ As Decimal

    Public Property Salary As Decimal
        Get
            Return salary_
        End Get
        Set(ByVal value As Decimal)
            salary_ = value
        End Set
    End Property

    Private department_ As String

    Public Property Department As String
        Get
            Return department_
        End Get
        Set(ByVal value As String)
            department_ = value
        End Set
    End Property

    Public Function CalcularBono(departamento As String) As Decimal Implements IBono.CalcularBono
        Dim lineas As String() = File.ReadAllLines("departamentos.txt") ' Read every line from the file
        For Each linea As String In lineas
            Dim datos As String() = linea.Split(","c) ' Divide la línea en los datos separados por comas
            If datos(0).Trim() = departamento Then
                Dim porcentaje As Decimal = Decimal.Parse(datos(1).Trim())
                Bono = porcentaje
                Return Bono
            End If
        Next

        Return 0 ' Devuelve 0 si no se encuentra el departamento
    End Function

    Public Sub New(ByVal name As String, ByVal salary As Decimal, ByVal department As String, ByVal imagePath As String, ByVal photoPath As String, ByVal dataGridView As DataGridView, ByVal nameTextBox As TextBox, ByVal salaryNumericUpDown As NumericUpDown, ByVal comboBox As ComboBox, ByVal employeePictureBox As PictureBox, ByVal openFileDialog As OpenFileDialog)
        If name = "" Then
            MessageBox.Show("Name Required.")
            Return
        End If
        If salary = 0 Then
            MessageBox.Show("Salary must not be '0'.")
            Return
        End If
        If department = "" Then
            MessageBox.Show("Department Required.")
            Return
        End If
        If imagePath = "" AndAlso photoPath Is Nothing Then
            MessageBox.Show("Image Required.")
            Return
        End If
        Me.Name = name
        Me.Salary = salary
        Me.Department = department
        If imagePath = String.Empty Then
            Me.ImagePath = photoPath
        Else
            Me.ImagePath = imagePath
        End If
        Me.DataGridView_ = dataGridView
        Me.NameTextBox_ = nameTextBox
        Me.SalaryNumericUpDown_ = salaryNumericUpDown
        Me.ComboBox_ = comboBox
        Me.EmployeePictureBox_ = employeePictureBox
        Me.OpenFileDialog_ = openFileDialog
        Dim salaryXhours As Decimal = salary * 40
        Dim bono As Decimal = salaryXhours * CalcularBono(Me.Department)
        Dim pay As Decimal = salaryXhours + bono

        ' Agregar Row a la DataGridView con la info del empleado.
        Me.DataGridView_.Rows.Add(Me.Name, Me.Department, Me.Salary, Me.ImagePath, pay, 40, 0, 0, bono, pay, 0, 0, 0)
        MessageBox.Show(ToString())
        ' Clear Controls
        Me.NameTextBox_.Clear()
        Me.OpenFileDialog_.FileName = String.Empty
        Me.SalaryNumericUpDown_.Value = 0
        Me.EmployeePictureBox_.Image = Nothing
    End Sub
    Public Sub New()
        CalcularBono(Department)
    End Sub

    'Finalize()
    '{
    '    MessageBox.Show("Ocuppied Memory Released!.");
    '}
End Class
