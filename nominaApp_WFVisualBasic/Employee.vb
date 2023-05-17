Friend Class Employee
    Inherits Person
    Implements IBono

    Private form_ As Form1 = New Form1()
    Private bono_ As Decimal
    Private DataGridView_ As DataGridView
    Private NameTextBox_ As TextBox
    Private SalaryNumericUpDown_ As NumericUpDown
    Private DepartmentCheckedListBox_ As CheckedListBox
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

    Public Function CalcularBono() As Decimal Implements IBono.CalcularBono
        porcentajeBono_ = 0

        Select Case department
            Case "Sales"
                porcentajeBono_ = 0.2D
                Exit Select
            Case "Manager"
                porcentajeBono_ = 0.15D
                Exit Select
            Case "Assistant Manager"
                porcentajeBono_ = 0.1D
                Exit Select
        End Select

        Return Bono = salary * porcentajeBono_
    End Function

    Public Sub New(ByVal name As String, ByVal salary As Decimal, ByVal department As String, ByVal imagePath As String, ByVal photoPath As String, ByVal dataGridView As DataGridView, ByVal nameTextBox As TextBox, ByVal salaryNumericUpDown As NumericUpDown, ByVal departmentCheckedListBox As CheckedListBox, ByVal employeePictureBox As PictureBox, ByVal openFileDialog As OpenFileDialog)
        If name = "" Then
            MessageBox.Show("Name Required.")
            Return
        End If
        If department = "" Then
            MessageBox.Show("Deparment Required.")
            Return
        End If
        If imagePath = "" AndAlso photoPath Is Nothing Then
            MessageBox.Show("Image Required.")
            Return
        End If
        Me.Name = name
        Me.salary = salary
        Me.department = department
        If imagePath = String.Empty Then
            Me.ImagePath = photoPath
        Else
            Me.ImagePath = imagePath
        End If
        Me.DataGridView_ = dataGridView
        Me.NameTextBox_ = nameTextBox
        Me.SalaryNumericUpDown_ = salaryNumericUpDown
        Me.DepartmentCheckedListBox_ = departmentCheckedListBox
        Me.EmployeePictureBox_ = employeePictureBox
        Me.OpenFileDialog_ = openFileDialog

        ' Agregar Row a la DataGridView con la info del empleado.
        Me.DataGridView_.Rows.Add(Me.Name, Me.department, Me.salary, Me.ImagePath)
        ' Display a success message
        MessageBox.Show(ToString())
        ' Clear Controls
        Me.NameTextBox_.Clear()
        Me.OpenFileDialog_.FileName = String.Empty
        Me.SalaryNumericUpDown_.Value = 0
        Me.EmployeePictureBox_.Image = Nothing
        For i As Integer = 0 To Me.DepartmentCheckedListBox_.Items.Count - 1
            Me.DepartmentCheckedListBox_.SetItemChecked(i, False)
        Next
        Me.DepartmentCheckedListBox_.ClearSelected()
    End Sub

    Public Sub New()
        ' Sin declarar nada.
    End Sub

    'Finalize()
    '{
    '    MessageBox.Show("Ocuppied Memory Released!.");
    '}
End Class
