<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnPayrollMenu = New System.Windows.Forms.Button()
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        Me.dgvAddEmployee = New System.Windows.Forms.DataGridView()
        Me.panelAddEmployee = New System.Windows.Forms.Panel()
        Me.btnTakePhoto = New System.Windows.Forms.Button()
        Me.btnStartCam = New System.Windows.Forms.Button()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.pbxEmployee = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.checkedDepartment = New System.Windows.Forms.CheckedListBox()
        Me.numericSalary = New System.Windows.Forms.NumericUpDown()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.panelPayroll = New System.Windows.Forms.Panel()
        Me.lblDepartmentPayroll = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblPay = New System.Windows.Forms.Label()
        Me.numericPay = New System.Windows.Forms.NumericUpDown()
        Me.numericDeductions = New System.Windows.Forms.NumericUpDown()
        Me.lblDeductions = New System.Windows.Forms.Label()
        Me.numericDiscount = New System.Windows.Forms.NumericUpDown()
        Me.btnDiscount = New System.Windows.Forms.Label()
        Me.numericAbsence = New System.Windows.Forms.NumericUpDown()
        Me.lblAbsence = New System.Windows.Forms.Label()
        Me.numericPerceptions = New System.Windows.Forms.NumericUpDown()
        Me.lblPerceptions = New System.Windows.Forms.Label()
        Me.numericBonus = New System.Windows.Forms.NumericUpDown()
        Me.numericHoliday = New System.Windows.Forms.NumericUpDown()
        Me.numericRestDay = New System.Windows.Forms.NumericUpDown()
        Me.numericHours = New System.Windows.Forms.NumericUpDown()
        Me.lblBonus = New System.Windows.Forms.Label()
        Me.lblHoliday = New System.Windows.Forms.Label()
        Me.lblRestDay = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.numericSalaryPayroll = New System.Windows.Forms.NumericUpDown()
        Me.pbxPayroll = New System.Windows.Forms.PictureBox()
        Me.lblSalaryPayroll = New System.Windows.Forms.Label()
        Me.lblNamePayroll = New System.Windows.Forms.Label()
        Me.txtNamePayroll = New System.Windows.Forms.TextBox()
        CType(Me.dgvAddEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelAddEmployee.SuspendLayout()
        CType(Me.pbxEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPayroll.SuspendLayout()
        CType(Me.numericPay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericDeductions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericAbsence, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericPerceptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericBonus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericHoliday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericRestDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericSalaryPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPayrollMenu
        '
        Me.btnPayrollMenu.Location = New System.Drawing.Point(12, 12)
        Me.btnPayrollMenu.Name = "btnPayrollMenu"
        Me.btnPayrollMenu.Size = New System.Drawing.Size(128, 91)
        Me.btnPayrollMenu.TabIndex = 0
        Me.btnPayrollMenu.Text = "Payroll Menu"
        Me.btnPayrollMenu.UseVisualStyleBackColor = True
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddEmployee.Location = New System.Drawing.Point(1392, 12)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(128, 91)
        Me.btnAddEmployee.TabIndex = 1
        Me.btnAddEmployee.Text = "Add Employee"
        Me.btnAddEmployee.UseVisualStyleBackColor = True
        '
        'dgvAddEmployee
        '
        Me.dgvAddEmployee.AllowUserToDeleteRows = False
        Me.dgvAddEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgvAddEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAddEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAddEmployee.Location = New System.Drawing.Point(12, 384)
        Me.dgvAddEmployee.Name = "dgvAddEmployee"
        Me.dgvAddEmployee.RowHeadersWidth = 51
        Me.dgvAddEmployee.RowTemplate.Height = 24
        Me.dgvAddEmployee.Size = New System.Drawing.Size(1508, 457)
        Me.dgvAddEmployee.TabIndex = 2
        '
        'panelAddEmployee
        '
        Me.panelAddEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.panelAddEmployee.Controls.Add(Me.btnTakePhoto)
        Me.panelAddEmployee.Controls.Add(Me.btnStartCam)
        Me.panelAddEmployee.Controls.Add(Me.comboBox1)
        Me.panelAddEmployee.Controls.Add(Me.btnBrowse)
        Me.panelAddEmployee.Controls.Add(Me.pbxEmployee)
        Me.panelAddEmployee.Controls.Add(Me.btnAdd)
        Me.panelAddEmployee.Controls.Add(Me.checkedDepartment)
        Me.panelAddEmployee.Controls.Add(Me.numericSalary)
        Me.panelAddEmployee.Controls.Add(Me.lblSalary)
        Me.panelAddEmployee.Controls.Add(Me.lblDepartment)
        Me.panelAddEmployee.Controls.Add(Me.txtName)
        Me.panelAddEmployee.Controls.Add(Me.lblName)
        Me.panelAddEmployee.Location = New System.Drawing.Point(147, 13)
        Me.panelAddEmployee.Name = "panelAddEmployee"
        Me.panelAddEmployee.Size = New System.Drawing.Size(1239, 365)
        Me.panelAddEmployee.TabIndex = 3
        '
        'btnTakePhoto
        '
        Me.btnTakePhoto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnTakePhoto.Location = New System.Drawing.Point(1016, 201)
        Me.btnTakePhoto.Name = "btnTakePhoto"
        Me.btnTakePhoto.Size = New System.Drawing.Size(101, 46)
        Me.btnTakePhoto.TabIndex = 18
        Me.btnTakePhoto.Text = "Take Photo"
        Me.btnTakePhoto.UseVisualStyleBackColor = True
        '
        'btnStartCam
        '
        Me.btnStartCam.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnStartCam.Location = New System.Drawing.Point(1016, 127)
        Me.btnStartCam.Name = "btnStartCam"
        Me.btnStartCam.Size = New System.Drawing.Size(101, 46)
        Me.btnStartCam.TabIndex = 17
        Me.btnStartCam.Text = "Start Cam"
        Me.btnStartCam.UseVisualStyleBackColor = True
        '
        'comboBox1
        '
        Me.comboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(917, 67)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(300, 33)
        Me.comboBox1.TabIndex = 16
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBrowse.Location = New System.Drawing.Point(709, 253)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(101, 46)
        Me.btnBrowse.TabIndex = 7
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'pbxEmployee
        '
        Me.pbxEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxEmployee.Location = New System.Drawing.Point(609, 67)
        Me.pbxEmployee.Name = "pbxEmployee"
        Me.pbxEmployee.Size = New System.Drawing.Size(302, 180)
        Me.pbxEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxEmployee.TabIndex = 6
        Me.pbxEmployee.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(414, 115)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(128, 91)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'checkedDepartment
        '
        Me.checkedDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkedDepartment.FormattingEnabled = True
        Me.checkedDepartment.Items.AddRange(New Object() {"Sales", "Manger", "Assistant Manager"})
        Me.checkedDepartment.Location = New System.Drawing.Point(76, 228)
        Me.checkedDepartment.Name = "checkedDepartment"
        Me.checkedDepartment.Size = New System.Drawing.Size(273, 104)
        Me.checkedDepartment.TabIndex = 5
        '
        'numericSalary
        '
        Me.numericSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericSalary.Location = New System.Drawing.Point(76, 143)
        Me.numericSalary.Name = "numericSalary"
        Me.numericSalary.Size = New System.Drawing.Size(273, 30)
        Me.numericSalary.TabIndex = 4
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalary.Location = New System.Drawing.Point(71, 110)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(192, 29)
        Me.lblSalary.TabIndex = 3
        Me.lblSalary.Text = "Salary (per hour)"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(71, 195)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(138, 29)
        Me.lblDepartment.TabIndex = 2
        Me.lblDepartment.Text = "Department"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(76, 67)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(273, 30)
        Me.txtName.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(71, 34)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(78, 29)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'panelPayroll
        '
        Me.panelPayroll.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.panelPayroll.Controls.Add(Me.lblDepartmentPayroll)
        Me.panelPayroll.Controls.Add(Me.btnCalculate)
        Me.panelPayroll.Controls.Add(Me.lblPay)
        Me.panelPayroll.Controls.Add(Me.numericPay)
        Me.panelPayroll.Controls.Add(Me.numericDeductions)
        Me.panelPayroll.Controls.Add(Me.lblDeductions)
        Me.panelPayroll.Controls.Add(Me.numericDiscount)
        Me.panelPayroll.Controls.Add(Me.btnDiscount)
        Me.panelPayroll.Controls.Add(Me.numericAbsence)
        Me.panelPayroll.Controls.Add(Me.lblAbsence)
        Me.panelPayroll.Controls.Add(Me.numericPerceptions)
        Me.panelPayroll.Controls.Add(Me.lblPerceptions)
        Me.panelPayroll.Controls.Add(Me.numericBonus)
        Me.panelPayroll.Controls.Add(Me.numericHoliday)
        Me.panelPayroll.Controls.Add(Me.numericRestDay)
        Me.panelPayroll.Controls.Add(Me.numericHours)
        Me.panelPayroll.Controls.Add(Me.lblBonus)
        Me.panelPayroll.Controls.Add(Me.lblHoliday)
        Me.panelPayroll.Controls.Add(Me.lblRestDay)
        Me.panelPayroll.Controls.Add(Me.lblHours)
        Me.panelPayroll.Controls.Add(Me.numericSalaryPayroll)
        Me.panelPayroll.Controls.Add(Me.pbxPayroll)
        Me.panelPayroll.Controls.Add(Me.lblSalaryPayroll)
        Me.panelPayroll.Controls.Add(Me.lblNamePayroll)
        Me.panelPayroll.Controls.Add(Me.txtNamePayroll)
        Me.panelPayroll.Location = New System.Drawing.Point(147, 12)
        Me.panelPayroll.Name = "panelPayroll"
        Me.panelPayroll.Size = New System.Drawing.Size(1240, 371)
        Me.panelPayroll.TabIndex = 12
        '
        'lblDepartmentPayroll
        '
        Me.lblDepartmentPayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartmentPayroll.Location = New System.Drawing.Point(29, 295)
        Me.lblDepartmentPayroll.Name = "lblDepartmentPayroll"
        Me.lblDepartmentPayroll.Size = New System.Drawing.Size(180, 29)
        Me.lblDepartmentPayroll.TabIndex = 25
        Me.lblDepartmentPayroll.Text = "Department"
        Me.lblDepartmentPayroll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(889, 252)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(156, 43)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate Payroll"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblPay
        '
        Me.lblPay.AutoSize = True
        Me.lblPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPay.ForeColor = System.Drawing.Color.Red
        Me.lblPay.Location = New System.Drawing.Point(824, 310)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(73, 29)
        Me.lblPay.TabIndex = 24
        Me.lblPay.Text = "Pay ="
        '
        'numericPay
        '
        Me.numericPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericPay.ForeColor = System.Drawing.Color.Red
        Me.numericPay.Location = New System.Drawing.Point(903, 310)
        Me.numericPay.Maximum = New Decimal(New Integer() {1661992959, 1808227885, 5, 0})
        Me.numericPay.Name = "numericPay"
        Me.numericPay.ReadOnly = True
        Me.numericPay.Size = New System.Drawing.Size(204, 30)
        Me.numericPay.TabIndex = 23
        '
        'numericDeductions
        '
        Me.numericDeductions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericDeductions.Location = New System.Drawing.Point(1036, 181)
        Me.numericDeductions.Maximum = New Decimal(New Integer() {1661992959, 1808227885, 5, 0})
        Me.numericDeductions.Name = "numericDeductions"
        Me.numericDeductions.ReadOnly = True
        Me.numericDeductions.Size = New System.Drawing.Size(204, 30)
        Me.numericDeductions.TabIndex = 22
        '
        'lblDeductions
        '
        Me.lblDeductions.AutoSize = True
        Me.lblDeductions.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeductions.Location = New System.Drawing.Point(824, 182)
        Me.lblDeductions.Name = "lblDeductions"
        Me.lblDeductions.Size = New System.Drawing.Size(221, 29)
        Me.lblDeductions.TabIndex = 21
        Me.lblDeductions.Text = "Total Deductions = "
        '
        'numericDiscount
        '
        Me.numericDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericDiscount.Location = New System.Drawing.Point(829, 128)
        Me.numericDiscount.Maximum = New Decimal(New Integer() {1661992959, 1808227885, 5, 0})
        Me.numericDiscount.Name = "numericDiscount"
        Me.numericDiscount.Size = New System.Drawing.Size(204, 30)
        Me.numericDiscount.TabIndex = 20
        '
        'btnDiscount
        '
        Me.btnDiscount.AutoSize = True
        Me.btnDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiscount.Location = New System.Drawing.Point(824, 96)
        Me.btnDiscount.Name = "btnDiscount"
        Me.btnDiscount.Size = New System.Drawing.Size(278, 29)
        Me.btnDiscount.TabIndex = 19
        Me.btnDiscount.Text = "Other Discounts (Money)"
        '
        'numericAbsence
        '
        Me.numericAbsence.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericAbsence.Location = New System.Drawing.Point(829, 46)
        Me.numericAbsence.Maximum = New Decimal(New Integer() {1661992959, 1808227885, 5, 0})
        Me.numericAbsence.Name = "numericAbsence"
        Me.numericAbsence.Size = New System.Drawing.Size(204, 30)
        Me.numericAbsence.TabIndex = 18
        '
        'lblAbsence
        '
        Me.lblAbsence.AutoSize = True
        Me.lblAbsence.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbsence.Location = New System.Drawing.Point(824, 14)
        Me.lblAbsence.Name = "lblAbsence"
        Me.lblAbsence.Size = New System.Drawing.Size(193, 29)
        Me.lblAbsence.TabIndex = 17
        Me.lblAbsence.Text = "Absence (Hours)"
        '
        'numericPerceptions
        '
        Me.numericPerceptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericPerceptions.Location = New System.Drawing.Point(499, 311)
        Me.numericPerceptions.Maximum = New Decimal(New Integer() {1661992959, 1808227885, 5, 0})
        Me.numericPerceptions.Name = "numericPerceptions"
        Me.numericPerceptions.ReadOnly = True
        Me.numericPerceptions.Size = New System.Drawing.Size(204, 30)
        Me.numericPerceptions.TabIndex = 16
        '
        'lblPerceptions
        '
        Me.lblPerceptions.AutoSize = True
        Me.lblPerceptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerceptions.Location = New System.Drawing.Point(275, 312)
        Me.lblPerceptions.Name = "lblPerceptions"
        Me.lblPerceptions.Size = New System.Drawing.Size(229, 29)
        Me.lblPerceptions.TabIndex = 15
        Me.lblPerceptions.Text = "Total Perceptions = "
        '
        'numericBonus
        '
        Me.numericBonus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericBonus.Location = New System.Drawing.Point(280, 265)
        Me.numericBonus.Maximum = New Decimal(New Integer() {1661992959, 1808227885, 5, 0})
        Me.numericBonus.Name = "numericBonus"
        Me.numericBonus.ReadOnly = True
        Me.numericBonus.Size = New System.Drawing.Size(204, 30)
        Me.numericBonus.TabIndex = 14
        '
        'numericHoliday
        '
        Me.numericHoliday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericHoliday.Location = New System.Drawing.Point(280, 196)
        Me.numericHoliday.Maximum = New Decimal(New Integer() {1661992959, 1808227885, 5, 0})
        Me.numericHoliday.Name = "numericHoliday"
        Me.numericHoliday.Size = New System.Drawing.Size(204, 30)
        Me.numericHoliday.TabIndex = 13
        '
        'numericRestDay
        '
        Me.numericRestDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericRestDay.Location = New System.Drawing.Point(280, 122)
        Me.numericRestDay.Maximum = New Decimal(New Integer() {1661992959, 1808227885, 5, 0})
        Me.numericRestDay.Name = "numericRestDay"
        Me.numericRestDay.Size = New System.Drawing.Size(204, 30)
        Me.numericRestDay.TabIndex = 12
        '
        'numericHours
        '
        Me.numericHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericHours.Location = New System.Drawing.Point(280, 46)
        Me.numericHours.Maximum = New Decimal(New Integer() {1661992959, 1808227885, 5, 0})
        Me.numericHours.Name = "numericHours"
        Me.numericHours.Size = New System.Drawing.Size(204, 30)
        Me.numericHours.TabIndex = 11
        '
        'lblBonus
        '
        Me.lblBonus.AutoSize = True
        Me.lblBonus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBonus.Location = New System.Drawing.Point(275, 233)
        Me.lblBonus.Name = "lblBonus"
        Me.lblBonus.Size = New System.Drawing.Size(330, 29)
        Me.lblBonus.TabIndex = 10
        Me.lblBonus.Text = "Bonus (% From HourWorked)"
        '
        'lblHoliday
        '
        Me.lblHoliday.AutoSize = True
        Me.lblHoliday.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoliday.Location = New System.Drawing.Point(275, 164)
        Me.lblHoliday.Name = "lblHoliday"
        Me.lblHoliday.Size = New System.Drawing.Size(270, 29)
        Me.lblHoliday.TabIndex = 9
        Me.lblHoliday.Text = "Holiday Worked (Hours)"
        '
        'lblRestDay
        '
        Me.lblRestDay.AutoSize = True
        Me.lblRestDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRestDay.Location = New System.Drawing.Point(275, 87)
        Me.lblRestDay.Name = "lblRestDay"
        Me.lblRestDay.Size = New System.Drawing.Size(285, 29)
        Me.lblRestDay.TabIndex = 8
        Me.lblRestDay.Text = "Rest Day Worked (Hours)"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.Location = New System.Drawing.Point(275, 14)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(167, 29)
        Me.lblHours.TabIndex = 6
        Me.lblHours.Text = "Hours Worked"
        '
        'numericSalaryPayroll
        '
        Me.numericSalaryPayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericSalaryPayroll.Location = New System.Drawing.Point(22, 128)
        Me.numericSalaryPayroll.Maximum = New Decimal(New Integer() {1661992959, 1808227885, 5, 0})
        Me.numericSalaryPayroll.Name = "numericSalaryPayroll"
        Me.numericSalaryPayroll.ReadOnly = True
        Me.numericSalaryPayroll.Size = New System.Drawing.Size(204, 30)
        Me.numericSalaryPayroll.TabIndex = 5
        '
        'pbxPayroll
        '
        Me.pbxPayroll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxPayroll.Location = New System.Drawing.Point(22, 165)
        Me.pbxPayroll.Name = "pbxPayroll"
        Me.pbxPayroll.Size = New System.Drawing.Size(204, 127)
        Me.pbxPayroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxPayroll.TabIndex = 4
        Me.pbxPayroll.TabStop = False
        '
        'lblSalaryPayroll
        '
        Me.lblSalaryPayroll.AutoSize = True
        Me.lblSalaryPayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalaryPayroll.Location = New System.Drawing.Point(17, 96)
        Me.lblSalaryPayroll.Name = "lblSalaryPayroll"
        Me.lblSalaryPayroll.Size = New System.Drawing.Size(180, 29)
        Me.lblSalaryPayroll.TabIndex = 2
        Me.lblSalaryPayroll.Text = "Salary per Hour"
        '
        'lblNamePayroll
        '
        Me.lblNamePayroll.AutoSize = True
        Me.lblNamePayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamePayroll.Location = New System.Drawing.Point(17, 25)
        Me.lblNamePayroll.Name = "lblNamePayroll"
        Me.lblNamePayroll.Size = New System.Drawing.Size(78, 29)
        Me.lblNamePayroll.TabIndex = 1
        Me.lblNamePayroll.Text = "Name"
        '
        'txtNamePayroll
        '
        Me.txtNamePayroll.Location = New System.Drawing.Point(22, 59)
        Me.txtNamePayroll.Name = "txtNamePayroll"
        Me.txtNamePayroll.ReadOnly = True
        Me.txtNamePayroll.Size = New System.Drawing.Size(204, 22)
        Me.txtNamePayroll.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1532, 853)
        Me.Controls.Add(Me.dgvAddEmployee)
        Me.Controls.Add(Me.btnAddEmployee)
        Me.Controls.Add(Me.btnPayrollMenu)
        Me.Controls.Add(Me.panelAddEmployee)
        Me.Controls.Add(Me.panelPayroll)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvAddEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelAddEmployee.ResumeLayout(False)
        Me.panelAddEmployee.PerformLayout()
        CType(Me.pbxEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericSalary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPayroll.ResumeLayout(False)
        Me.panelPayroll.PerformLayout()
        CType(Me.numericPay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericDeductions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericAbsence, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericPerceptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericBonus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericHoliday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericRestDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericSalaryPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPayrollMenu As Button
    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents dgvAddEmployee As DataGridView
    Friend WithEvents panelAddEmployee As Panel
    Friend WithEvents checkedDepartment As CheckedListBox
    Friend WithEvents numericSalary As NumericUpDown
    Friend WithEvents lblSalary As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents btnAdd As Button
    Private WithEvents comboBox1 As ComboBox
    Private WithEvents btnBrowse As Button
    Friend WithEvents pbxEmployee As PictureBox
    Private WithEvents btnTakePhoto As Button
    Private WithEvents btnStartCam As Button
    Private WithEvents panelPayroll As Panel
    Private WithEvents lblDepartmentPayroll As Label
    Private WithEvents btnCalculate As Button
    Private WithEvents lblPay As Label
    Private WithEvents numericPay As NumericUpDown
    Private WithEvents numericDeductions As NumericUpDown
    Private WithEvents lblDeductions As Label
    Private WithEvents numericDiscount As NumericUpDown
    Private WithEvents btnDiscount As Label
    Private WithEvents numericAbsence As NumericUpDown
    Private WithEvents lblAbsence As Label
    Private WithEvents numericPerceptions As NumericUpDown
    Private WithEvents lblPerceptions As Label
    Public WithEvents numericBonus As NumericUpDown
    Private WithEvents numericHoliday As NumericUpDown
    Private WithEvents numericRestDay As NumericUpDown
    Private WithEvents numericHours As NumericUpDown
    Private WithEvents lblBonus As Label
    Private WithEvents lblHoliday As Label
    Private WithEvents lblRestDay As Label
    Private WithEvents lblHours As Label
    Private WithEvents numericSalaryPayroll As NumericUpDown
    Private WithEvents pbxPayroll As PictureBox
    Private WithEvents lblSalaryPayroll As Label
    Private WithEvents lblNamePayroll As Label
    Private WithEvents txtNamePayroll As TextBox
End Class
