<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddUser
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAddAdmin = New CloudToolkitN6.CloudDesktopButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAdminUser = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReenterPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.btnAddAdmin)
        Me.Panel1.Location = New System.Drawing.Point(0, 137)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(373, 41)
        Me.Panel1.TabIndex = 0
        '
        'btnAddAdmin
        '
        Me.btnAddAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddAdmin.AnimationSpeed = 5
        Me.btnAddAdmin.BackColor = System.Drawing.Color.Transparent
        Me.btnAddAdmin.BackgroundOpacity = 100
        Me.btnAddAdmin.BackgroundOpacity_MouseDown = 170
        Me.btnAddAdmin.BorderColor = System.Drawing.Color.White
        Me.btnAddAdmin.BorderOpacity = 170
        Me.btnAddAdmin.BorderWidth = 1
        Me.btnAddAdmin.ControlText = "Add as admin"
        Me.btnAddAdmin.CornerRadius = 12
        Me.btnAddAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddAdmin.DrawBlackTextBackground = True
        Me.btnAddAdmin.Enabled = False
        Me.btnAddAdmin.FillColor = System.Drawing.Color.White
        Me.btnAddAdmin.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAdmin.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddAdmin.Icon = Nothing
        Me.btnAddAdmin.Location = New System.Drawing.Point(109, 5)
        Me.btnAddAdmin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddAdmin.Name = "btnAddAdmin"
        Me.btnAddAdmin.Size = New System.Drawing.Size(146, 31)
        Me.btnAddAdmin.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Admin Name"
        '
        'txtAdminUser
        '
        Me.txtAdminUser.Location = New System.Drawing.Point(156, 20)
        Me.txtAdminUser.Name = "txtAdminUser"
        Me.txtAdminUser.Size = New System.Drawing.Size(193, 20)
        Me.txtAdminUser.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(156, 50)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(195, 20)
        Me.txtPassword.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'txtReenterPassword
        '
        Me.txtReenterPassword.Location = New System.Drawing.Point(156, 78)
        Me.txtReenterPassword.Name = "txtReenterPassword"
        Me.txtReenterPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtReenterPassword.Size = New System.Drawing.Size(195, 20)
        Me.txtReenterPassword.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Re-enter Password"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.ForeColor = System.Drawing.Color.DarkRed
        Me.lblPassword.Location = New System.Drawing.Point(164, 110)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(0, 13)
        Me.lblPassword.TabIndex = 7
        '
        'frmAddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 178)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtReenterPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAdminUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "frmAddUser"
        Me.Text = "Admin User"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAdminUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtReenterPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAddAdmin As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents lblPassword As System.Windows.Forms.Label
End Class
