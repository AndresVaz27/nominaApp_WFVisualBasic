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
        Me.panelPayroll = New System.Windows.Forms.Panel()
        Me.panelAddEmployee = New System.Windows.Forms.Panel()
        Me.lblFace3 = New System.Windows.Forms.Label()
        Me.lblFace1 = New System.Windows.Forms.Label()
        Me.comboBox2 = New System.Windows.Forms.ComboBox()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnTakePhoto = New System.Windows.Forms.Button()
        Me.btnStartCam = New System.Windows.Forms.Button()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.numericSalary = New System.Windows.Forms.NumericUpDown()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblFace2 = New System.Windows.Forms.Label()
        Me.lblFace4 = New System.Windows.Forms.Label()
        Me.pbxEmployee = New System.Windows.Forms.PictureBox()
        Me.lblSalaryPayrollValue = New System.Windows.Forms.Label()
        Me.lblBonusValue = New System.Windows.Forms.Label()
        Me.lblTotalDeductionsValue = New System.Windows.Forms.Label()
        Me.lblTotalPerceptionsValue = New System.Windows.Forms.Label()
        Me.lblDepartmentPayroll = New System.Windows.Forms.Label()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.lblDeductions = New System.Windows.Forms.Label()
        Me.numericDiscount = New System.Windows.Forms.NumericUpDown()
        Me.btnDiscount = New System.Windows.Forms.Label()
        Me.numericAbsence = New System.Windows.Forms.NumericUpDown()
        Me.lblAbsence = New System.Windows.Forms.Label()
        Me.lblPerceptions = New System.Windows.Forms.Label()
        Me.numericHoliday = New System.Windows.Forms.NumericUpDown()
        Me.numericRestDay = New System.Windows.Forms.NumericUpDown()
        Me.numericHours = New System.Windows.Forms.NumericUpDown()
        Me.lblBonus = New System.Windows.Forms.Label()
        Me.lblHoliday = New System.Windows.Forms.Label()
        Me.lblRestDay = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.pbxPayroll = New System.Windows.Forms.PictureBox()
        Me.lblSalaryPayroll = New System.Windows.Forms.Label()
        Me.lblNamePayroll = New System.Windows.Forms.Label()
        Me.txtNamePayroll = New System.Windows.Forms.TextBox()
        Me.btnIndividualReceipt = New System.Windows.Forms.Button()
        Me.btnPDFPayroll = New System.Windows.Forms.Button()
        Me.lblNumeroEnLetras = New System.Windows.Forms.Label()
        Me.lblPayValue = New System.Windows.Forms.Label()
        Me.lblPay = New System.Windows.Forms.Label()
        CType(Me.dgvAddEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPayroll.SuspendLayout()
        Me.panelAddEmployee.SuspendLayout()
        CType(Me.numericSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericAbsence, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericHoliday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericRestDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericHours, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgvAddEmployee.RowHeadersVisible = False
        Me.dgvAddEmployee.RowHeadersWidth = 51
        Me.dgvAddEmployee.RowTemplate.Height = 24
        Me.dgvAddEmployee.Size = New System.Drawing.Size(1508, 405)
        Me.dgvAddEmployee.TabIndex = 2
        '
        'panelPayroll
        '
        Me.panelPayroll.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.panelPayroll.Controls.Add(Me.lblSalaryPayrollValue)
        Me.panelPayroll.Controls.Add(Me.lblBonusValue)
        Me.panelPayroll.Controls.Add(Me.lblTotalDeductionsValue)
        Me.panelPayroll.Controls.Add(Me.lblTotalPerceptionsValue)
        Me.panelPayroll.Controls.Add(Me.lblDepartmentPayroll)
        Me.panelPayroll.Controls.Add(Me.btnModify)
        Me.panelPayroll.Controls.Add(Me.lblDeductions)
        Me.panelPayroll.Controls.Add(Me.numericDiscount)
        Me.panelPayroll.Controls.Add(Me.btnDiscount)
        Me.panelPayroll.Controls.Add(Me.numericAbsence)
        Me.panelPayroll.Controls.Add(Me.lblAbsence)
        Me.panelPayroll.Controls.Add(Me.lblPerceptions)
        Me.panelPayroll.Controls.Add(Me.numericHoliday)
        Me.panelPayroll.Controls.Add(Me.numericRestDay)
        Me.panelPayroll.Controls.Add(Me.numericHours)
        Me.panelPayroll.Controls.Add(Me.lblBonus)
        Me.panelPayroll.Controls.Add(Me.lblHoliday)
        Me.panelPayroll.Controls.Add(Me.lblRestDay)
        Me.panelPayroll.Controls.Add(Me.lblHours)
        Me.panelPayroll.Controls.Add(Me.pbxPayroll)
        Me.panelPayroll.Controls.Add(Me.lblSalaryPayroll)
        Me.panelPayroll.Controls.Add(Me.lblNamePayroll)
        Me.panelPayroll.Controls.Add(Me.txtNamePayroll)
        Me.panelPayroll.Location = New System.Drawing.Point(147, 12)
        Me.panelPayroll.Name = "panelPayroll"
        Me.panelPayroll.Size = New System.Drawing.Size(1240, 371)
        Me.panelPayroll.TabIndex = 15
        '
        'panelAddEmployee
        '
        Me.panelAddEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.panelAddEmployee.Controls.Add(Me.lblFace3)
        Me.panelAddEmployee.Controls.Add(Me.lblFace1)
        Me.panelAddEmployee.Controls.Add(Me.comboBox2)
        Me.panelAddEmployee.Controls.Add(Me.comboBox1)
        Me.panelAddEmployee.Controls.Add(Me.btnTakePhoto)
        Me.panelAddEmployee.Controls.Add(Me.btnStartCam)
        Me.panelAddEmployee.Controls.Add(Me.lblDepartment)
        Me.panelAddEmployee.Controls.Add(Me.lblSalary)
        Me.panelAddEmployee.Controls.Add(Me.numericSalary)
        Me.panelAddEmployee.Controls.Add(Me.lblName)
        Me.panelAddEmployee.Controls.Add(Me.btnAdd)
        Me.panelAddEmployee.Controls.Add(Me.txtName)
        Me.panelAddEmployee.Controls.Add(Me.btnBrowse)
        Me.panelAddEmployee.Controls.Add(Me.lblFace2)
        Me.panelAddEmployee.Controls.Add(Me.lblFace4)
        Me.panelAddEmployee.Controls.Add(Me.pbxEmployee)
        Me.panelAddEmployee.Location = New System.Drawing.Point(146, 12)
        Me.panelAddEmployee.Name = "panelAddEmployee"
        Me.panelAddEmployee.Size = New System.Drawing.Size(1234, 365)
        Me.panelAddEmployee.TabIndex = 16
        '
        'lblFace3
        '
        Me.lblFace3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFace3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFace3.Location = New System.Drawing.Point(612, 183)
        Me.lblFace3.Name = "lblFace3"
        Me.lblFace3.Size = New System.Drawing.Size(222, 77)
        Me.lblFace3.TabIndex = 12
        Me.lblFace3.Text = "Center your face in here."
        Me.lblFace3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblFace3.Visible = False
        '
        'lblFace1
        '
        Me.lblFace1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFace1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFace1.Location = New System.Drawing.Point(612, 60)
        Me.lblFace1.Name = "lblFace1"
        Me.lblFace1.Size = New System.Drawing.Size(222, 53)
        Me.lblFace1.TabIndex = 11
        Me.lblFace1.Text = "Center your face in here."
        Me.lblFace1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblFace1.Visible = False
        '
        'comboBox2
        '
        Me.comboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBox2.FormattingEnabled = True
        Me.comboBox2.Location = New System.Drawing.Point(61, 198)
        Me.comboBox2.Name = "comboBox2"
        Me.comboBox2.Size = New System.Drawing.Size(273, 33)
        Me.comboBox2.TabIndex = 3
        '
        'comboBox1
        '
        Me.comboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(914, 45)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(300, 33)
        Me.comboBox1.TabIndex = 4
        '
        'btnTakePhoto
        '
        Me.btnTakePhoto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnTakePhoto.Location = New System.Drawing.Point(1019, 145)
        Me.btnTakePhoto.Name = "btnTakePhoto"
        Me.btnTakePhoto.Size = New System.Drawing.Size(101, 46)
        Me.btnTakePhoto.TabIndex = 6
        Me.btnTakePhoto.Text = "Take Photo"
        Me.btnTakePhoto.UseVisualStyleBackColor = True
        '
        'btnStartCam
        '
        Me.btnStartCam.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnStartCam.Location = New System.Drawing.Point(1019, 84)
        Me.btnStartCam.Name = "btnStartCam"
        Me.btnStartCam.Size = New System.Drawing.Size(101, 46)
        Me.btnStartCam.TabIndex = 5
        Me.btnStartCam.Text = "Start Cam"
        Me.btnStartCam.UseVisualStyleBackColor = True
        '
        'lblDepartment
        '
        Me.lblDepartment.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(56, 162)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(138, 29)
        Me.lblDepartment.TabIndex = 10
        Me.lblDepartment.Text = "Department"
        '
        'lblSalary
        '
        Me.lblSalary.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalary.Location = New System.Drawing.Point(56, 96)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(180, 29)
        Me.lblSalary.TabIndex = 5
        Me.lblSalary.Text = "Salary per Hour"
        '
        'numericSalary
        '
        Me.numericSalary.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.numericSalary.BackColor = System.Drawing.SystemColors.Window
        Me.numericSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericSalary.Location = New System.Drawing.Point(61, 126)
        Me.numericSalary.Maximum = New Decimal(New Integer() {1661992959, 1808227885, 5, 0})
        Me.numericSalary.Name = "numericSalary"
        Me.numericSalary.Size = New System.Drawing.Size(273, 30)
        Me.numericSalary.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(56, 28)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(78, 29)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAdd.Location = New System.Drawing.Point(395, 116)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(128, 91)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(61, 60)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(273, 30)
        Me.txtName.TabIndex = 1
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBrowse.Location = New System.Drawing.Point(676, 281)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(101, 46)
        Me.btnBrowse.TabIndex = 8
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lblFace2
        '
        Me.lblFace2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFace2.BackColor = System.Drawing.Color.Transparent
        Me.lblFace2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFace2.Location = New System.Drawing.Point(778, 113)
        Me.lblFace2.Name = "lblFace2"
        Me.lblFace2.Size = New System.Drawing.Size(57, 142)
        Me.lblFace2.TabIndex = 13
        Me.lblFace2.Visible = False
        '
        'lblFace4
        '
        Me.lblFace4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFace4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFace4.Location = New System.Drawing.Point(610, 113)
        Me.lblFace4.Name = "lblFace4"
        Me.lblFace4.Size = New System.Drawing.Size(53, 142)
        Me.lblFace4.TabIndex = 14
        Me.lblFace4.Visible = False
        '
        'pbxEmployee
        '
        Me.pbxEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbxEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxEmployee.Location = New System.Drawing.Point(607, 45)
        Me.pbxEmployee.Name = "pbxEmployee"
        Me.pbxEmployee.Size = New System.Drawing.Size(230, 220)
        Me.pbxEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxEmployee.TabIndex = 7
        Me.pbxEmployee.TabStop = False
        '
        'lblSalaryPayrollValue
        '
        Me.lblSalaryPayrollValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalaryPayrollValue.Location = New System.Drawing.Point(6, 197)
        Me.lblSalaryPayrollValue.Name = "lblSalaryPayrollValue"
        Me.lblSalaryPayrollValue.Size = New System.Drawing.Size(162, 29)
        Me.lblSalaryPayrollValue.TabIndex = 29
        '
        'lblBonusValue
        '
        Me.lblBonusValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBonusValue.Location = New System.Drawing.Point(437, 263)
        Me.lblBonusValue.Name = "lblBonusValue"
        Me.lblBonusValue.Size = New System.Drawing.Size(209, 29)
        Me.lblBonusValue.TabIndex = 28
        Me.lblBonusValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblBonusValue.Visible = False
        '
        'lblTotalDeductionsValue
        '
        Me.lblTotalDeductionsValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDeductionsValue.Location = New System.Drawing.Point(1043, 312)
        Me.lblTotalDeductionsValue.Name = "lblTotalDeductionsValue"
        Me.lblTotalDeductionsValue.Size = New System.Drawing.Size(121, 29)
        Me.lblTotalDeductionsValue.TabIndex = 27
        '
        'lblTotalPerceptionsValue
        '
        Me.lblTotalPerceptionsValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPerceptionsValue.Location = New System.Drawing.Point(672, 312)
        Me.lblTotalPerceptionsValue.Name = "lblTotalPerceptionsValue"
        Me.lblTotalPerceptionsValue.Size = New System.Drawing.Size(95, 29)
        Me.lblTotalPerceptionsValue.TabIndex = 26
        '
        'lblDepartmentPayroll
        '
        Me.lblDepartmentPayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartmentPayroll.Location = New System.Drawing.Point(220, 263)
        Me.lblDepartmentPayroll.Name = "lblDepartmentPayroll"
        Me.lblDepartmentPayroll.Size = New System.Drawing.Size(180, 29)
        Me.lblDepartmentPayroll.TabIndex = 25
        Me.lblDepartmentPayroll.Text = "Department"
        Me.lblDepartmentPayroll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(1142, 129)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(92, 67)
        Me.btnModify.TabIndex = 12
        Me.btnModify.Text = "Modify Employee"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'lblDeductions
        '
        Me.lblDeductions.AutoSize = True
        Me.lblDeductions.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeductions.Location = New System.Drawing.Point(824, 312)
        Me.lblDeductions.Name = "lblDeductions"
        Me.lblDeductions.Size = New System.Drawing.Size(221, 29)
        Me.lblDeductions.TabIndex = 21
        Me.lblDeductions.Text = "Total Deductions = "
        Me.lblDeductions.Visible = False
        '
        'numericDiscount
        '
        Me.numericDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericDiscount.Location = New System.Drawing.Point(825, 196)
        Me.numericDiscount.Maximum = New Decimal(New Integer() {1661992959, 1808227885, 5, 0})
        Me.numericDiscount.Name = "numericDiscount"
        Me.numericDiscount.Size = New System.Drawing.Size(204, 30)
        Me.numericDiscount.TabIndex = 20
        '
        'btnDiscount
        '
        Me.btnDiscount.AutoSize = True
        Me.btnDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiscount.Location = New System.Drawing.Point(824, 164)
        Me.btnDiscount.Name = "btnDiscount"
        Me.btnDiscount.Size = New System.Drawing.Size(278, 29)
        Me.btnDiscount.TabIndex = 19
        Me.btnDiscount.Text = "Other Discounts (Money)"
        '
        'numericAbsence
        '
        Me.numericAbsence.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericAbsence.Location = New System.Drawing.Point(829, 122)
        Me.numericAbsence.Maximum = New Decimal(New Integer() {1661992959, 1808227885, 5, 0})
        Me.numericAbsence.Name = "numericAbsence"
        Me.numericAbsence.Size = New System.Drawing.Size(204, 30)
        Me.numericAbsence.TabIndex = 18
        '
        'lblAbsence
        '
        Me.lblAbsence.AutoSize = True
        Me.lblAbsence.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbsence.Location = New System.Drawing.Point(824, 87)
        Me.lblAbsence.Name = "lblAbsence"
        Me.lblAbsence.Size = New System.Drawing.Size(193, 29)
        Me.lblAbsence.TabIndex = 17
        Me.lblAbsence.Text = "Absence (Hours)"
        '
        'lblPerceptions
        '
        Me.lblPerceptions.AutoSize = True
        Me.lblPerceptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerceptions.Location = New System.Drawing.Point(437, 312)
        Me.lblPerceptions.Name = "lblPerceptions"
        Me.lblPerceptions.Size = New System.Drawing.Size(229, 29)
        Me.lblPerceptions.TabIndex = 15
        Me.lblPerceptions.Text = "Total Perceptions = "
        Me.lblPerceptions.Visible = False
        '
        'numericHoliday
        '
        Me.numericHoliday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericHoliday.Location = New System.Drawing.Point(442, 201)
        Me.numericHoliday.Maximum = New Decimal(New Integer() {1661992959, 1808227885, 5, 0})
        Me.numericHoliday.Name = "numericHoliday"
        Me.numericHoliday.Size = New System.Drawing.Size(204, 30)
        Me.numericHoliday.TabIndex = 13
        '
        'numericRestDay
        '
        Me.numericRestDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericRestDay.Location = New System.Drawing.Point(442, 122)
        Me.numericRestDay.Maximum = New Decimal(New Integer() {1661992959, 1808227885, 5, 0})
        Me.numericRestDay.Name = "numericRestDay"
        Me.numericRestDay.Size = New System.Drawing.Size(204, 30)
        Me.numericRestDay.TabIndex = 12
        '
        'numericHours
        '
        Me.numericHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericHours.Location = New System.Drawing.Point(442, 49)
        Me.numericHours.Maximum = New Decimal(New Integer() {1661992959, 1808227885, 5, 0})
        Me.numericHours.Name = "numericHours"
        Me.numericHours.Size = New System.Drawing.Size(204, 30)
        Me.numericHours.TabIndex = 11
        '
        'lblBonus
        '
        Me.lblBonus.AutoSize = True
        Me.lblBonus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBonus.Location = New System.Drawing.Point(437, 234)
        Me.lblBonus.Name = "lblBonus"
        Me.lblBonus.Size = New System.Drawing.Size(330, 29)
        Me.lblBonus.TabIndex = 10
        Me.lblBonus.Text = "Bonus (% From HourWorked)"
        Me.lblBonus.Visible = False
        '
        'lblHoliday
        '
        Me.lblHoliday.AutoSize = True
        Me.lblHoliday.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoliday.Location = New System.Drawing.Point(437, 164)
        Me.lblHoliday.Name = "lblHoliday"
        Me.lblHoliday.Size = New System.Drawing.Size(270, 29)
        Me.lblHoliday.TabIndex = 9
        Me.lblHoliday.Text = "Holiday Worked (Hours)"
        '
        'lblRestDay
        '
        Me.lblRestDay.AutoSize = True
        Me.lblRestDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRestDay.Location = New System.Drawing.Point(437, 87)
        Me.lblRestDay.Name = "lblRestDay"
        Me.lblRestDay.Size = New System.Drawing.Size(285, 29)
        Me.lblRestDay.TabIndex = 8
        Me.lblRestDay.Text = "Rest Day Worked (Hours)"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.Location = New System.Drawing.Point(437, 17)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(167, 29)
        Me.lblHours.TabIndex = 6
        Me.lblHours.Text = "Hours Worked"
        '
        'pbxPayroll
        '
        Me.pbxPayroll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxPayroll.Location = New System.Drawing.Point(192, 38)
        Me.pbxPayroll.Name = "pbxPayroll"
        Me.pbxPayroll.Size = New System.Drawing.Size(230, 220)
        Me.pbxPayroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxPayroll.TabIndex = 4
        Me.pbxPayroll.TabStop = False
        '
        'lblSalaryPayroll
        '
        Me.lblSalaryPayroll.AutoSize = True
        Me.lblSalaryPayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalaryPayroll.Location = New System.Drawing.Point(6, 165)
        Me.lblSalaryPayroll.Name = "lblSalaryPayroll"
        Me.lblSalaryPayroll.Size = New System.Drawing.Size(180, 29)
        Me.lblSalaryPayroll.TabIndex = 2
        Me.lblSalaryPayroll.Text = "Salary per Hour"
        '
        'lblNamePayroll
        '
        Me.lblNamePayroll.AutoSize = True
        Me.lblNamePayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamePayroll.Location = New System.Drawing.Point(6, 87)
        Me.lblNamePayroll.Name = "lblNamePayroll"
        Me.lblNamePayroll.Size = New System.Drawing.Size(78, 29)
        Me.lblNamePayroll.TabIndex = 1
        Me.lblNamePayroll.Text = "Name"
        '
        'txtNamePayroll
        '
        Me.txtNamePayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamePayroll.Location = New System.Drawing.Point(11, 122)
        Me.txtNamePayroll.Name = "txtNamePayroll"
        Me.txtNamePayroll.ReadOnly = True
        Me.txtNamePayroll.Size = New System.Drawing.Size(157, 30)
        Me.txtNamePayroll.TabIndex = 0
        '
        'btnIndividualReceipt
        '
        Me.btnIndividualReceipt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnIndividualReceipt.Location = New System.Drawing.Point(12, 801)
        Me.btnIndividualReceipt.Name = "btnIndividualReceipt"
        Me.btnIndividualReceipt.Size = New System.Drawing.Size(148, 40)
        Me.btnIndividualReceipt.TabIndex = 35
        Me.btnIndividualReceipt.Text = "Individual Receipt"
        Me.btnIndividualReceipt.UseVisualStyleBackColor = True
        '
        'btnPDFPayroll
        '
        Me.btnPDFPayroll.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPDFPayroll.Location = New System.Drawing.Point(166, 801)
        Me.btnPDFPayroll.Name = "btnPDFPayroll"
        Me.btnPDFPayroll.Size = New System.Drawing.Size(148, 40)
        Me.btnPDFPayroll.TabIndex = 36
        Me.btnPDFPayroll.Text = "Total Payroll PDF"
        Me.btnPDFPayroll.UseVisualStyleBackColor = True
        '
        'lblNumeroEnLetras
        '
        Me.lblNumeroEnLetras.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblNumeroEnLetras.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroEnLetras.ForeColor = System.Drawing.Color.Red
        Me.lblNumeroEnLetras.Location = New System.Drawing.Point(761, 798)
        Me.lblNumeroEnLetras.Name = "lblNumeroEnLetras"
        Me.lblNumeroEnLetras.Size = New System.Drawing.Size(725, 29)
        Me.lblNumeroEnLetras.TabIndex = 34
        Me.lblNumeroEnLetras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPayValue
        '
        Me.lblPayValue.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblPayValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayValue.ForeColor = System.Drawing.Color.Red
        Me.lblPayValue.Location = New System.Drawing.Point(618, 798)
        Me.lblPayValue.Name = "lblPayValue"
        Me.lblPayValue.Size = New System.Drawing.Size(137, 29)
        Me.lblPayValue.TabIndex = 33
        Me.lblPayValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPay
        '
        Me.lblPay.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblPay.AutoSize = True
        Me.lblPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPay.ForeColor = System.Drawing.Color.Red
        Me.lblPay.Location = New System.Drawing.Point(539, 798)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(73, 29)
        Me.lblPay.TabIndex = 32
        Me.lblPay.Text = "Pay ="
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1532, 853)
        Me.Controls.Add(Me.btnIndividualReceipt)
        Me.Controls.Add(Me.btnPDFPayroll)
        Me.Controls.Add(Me.lblNumeroEnLetras)
        Me.Controls.Add(Me.lblPayValue)
        Me.Controls.Add(Me.lblPay)
        Me.Controls.Add(Me.dgvAddEmployee)
        Me.Controls.Add(Me.btnAddEmployee)
        Me.Controls.Add(Me.btnPayrollMenu)
        Me.Controls.Add(Me.panelPayroll)
        Me.Controls.Add(Me.panelAddEmployee)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvAddEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPayroll.ResumeLayout(False)
        Me.panelPayroll.PerformLayout()
        Me.panelAddEmployee.ResumeLayout(False)
        Me.panelAddEmployee.PerformLayout()
        CType(Me.numericSalary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericAbsence, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericHoliday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericRestDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPayrollMenu As Button
    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents dgvAddEmployee As DataGridView
    Private WithEvents panelPayroll As Panel
    Private WithEvents panelAddEmployee As Panel
    Private WithEvents lblFace3 As Label
    Private WithEvents lblFace1 As Label
    Private WithEvents comboBox2 As ComboBox
    Private WithEvents comboBox1 As ComboBox
    Private WithEvents btnTakePhoto As Button
    Private WithEvents btnStartCam As Button
    Private WithEvents lblDepartment As Label
    Private WithEvents lblSalary As Label
    Public WithEvents numericSalary As NumericUpDown
    Private WithEvents lblName As Label
    Private WithEvents btnAdd As Button
    Public WithEvents txtName As TextBox
    Private WithEvents btnBrowse As Button
    Private WithEvents lblFace2 As Label
    Private WithEvents lblFace4 As Label
    Public WithEvents pbxEmployee As PictureBox
    Private WithEvents lblSalaryPayrollValue As Label
    Private WithEvents lblBonusValue As Label
    Private WithEvents lblTotalDeductionsValue As Label
    Private WithEvents lblTotalPerceptionsValue As Label
    Private WithEvents lblDepartmentPayroll As Label
    Private WithEvents btnModify As Button
    Private WithEvents lblDeductions As Label
    Private WithEvents numericDiscount As NumericUpDown
    Private WithEvents btnDiscount As Label
    Private WithEvents numericAbsence As NumericUpDown
    Private WithEvents lblAbsence As Label
    Private WithEvents lblPerceptions As Label
    Private WithEvents numericHoliday As NumericUpDown
    Private WithEvents numericRestDay As NumericUpDown
    Private WithEvents numericHours As NumericUpDown
    Private WithEvents lblBonus As Label
    Private WithEvents lblHoliday As Label
    Private WithEvents lblRestDay As Label
    Private WithEvents lblHours As Label
    Private WithEvents pbxPayroll As PictureBox
    Private WithEvents lblSalaryPayroll As Label
    Private WithEvents lblNamePayroll As Label
    Private WithEvents txtNamePayroll As TextBox
    Private WithEvents btnIndividualReceipt As Button
    Private WithEvents btnPDFPayroll As Button
    Private WithEvents lblNumeroEnLetras As Label
    Private WithEvents lblPayValue As Label
    Private WithEvents lblPay As Label
End Class
