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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboDepartment = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtExtension = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtEmployeeNumber = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboDepartment)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtExtension)
        Me.GroupBox1.Controls.Add(Me.txtTelephone)
        Me.GroupBox1.Controls.Add(Me.txtEmployeeNumber)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.txtMiddleName)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 325)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Employee Data"
        '
        'cboDepartment
        '
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Items.AddRange(New Object() {"Administration", "Network Staff", "System Analyst", "Developer", "SME"})
        Me.cboDepartment.Location = New System.Drawing.Point(180, 168)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(121, 24)
        Me.cboDepartment.TabIndex = 15
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(180, 275)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(121, 22)
        Me.txtEmail.TabIndex = 14
        '
        'txtExtension
        '
        Me.txtExtension.Location = New System.Drawing.Point(180, 240)
        Me.txtExtension.Name = "txtExtension"
        Me.txtExtension.Size = New System.Drawing.Size(121, 22)
        Me.txtExtension.TabIndex = 13
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(180, 205)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(121, 22)
        Me.txtTelephone.TabIndex = 12
        '
        'txtEmployeeNumber
        '
        Me.txtEmployeeNumber.Location = New System.Drawing.Point(180, 133)
        Me.txtEmployeeNumber.Name = "txtEmployeeNumber"
        Me.txtEmployeeNumber.Size = New System.Drawing.Size(121, 22)
        Me.txtEmployeeNumber.TabIndex = 11
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(180, 98)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(121, 22)
        Me.txtLastName.TabIndex = 10
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(180, 63)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(121, 22)
        Me.txtMiddleName.TabIndex = 9
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(180, 28)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(121, 22)
        Me.txtFirstName.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(49, 276)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "E-mail Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(79, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Extension:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(72, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Telephone:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Department:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Employee Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Middle Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(30, 368)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 51)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save Record"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(148, 368)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(112, 51)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(266, 368)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 51)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 450)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Employee Data"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboDepartment As ComboBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtExtension As TextBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents txtEmployeeNumber As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
