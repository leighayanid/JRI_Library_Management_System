<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModifyStudents
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSection = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtStudLName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStudFName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewInfo = New System.Windows.Forms.DataGridView()
        Me.colStudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudFName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudMName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudLName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colYear = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSection = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colContactNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDelete = New CloudToolkitN6.CloudDesktopButton()
        Me.CloudDesktopButton1 = New CloudToolkitN6.CloudDesktopButton()
        Me.btnClear = New CloudToolkitN6.CloudDesktopButton()
        Me.btnSave = New CloudToolkitN6.CloudDesktopButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ListBoxStudents = New System.Windows.Forms.ListBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbYear)
        Me.GroupBox1.Controls.Add(Me.txtMiddleName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtContact)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbGender)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtSection)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtStudLName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtStudFName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtStudentID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(17, 232)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(691, 174)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fill student record"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(127, 116)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(196, 20)
        Me.txtMiddleName.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Student Middle Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(375, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Year "
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(479, 144)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(193, 20)
        Me.txtContact.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(375, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Contact Number"
        '
        'cmbGender
        '
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(479, 112)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(121, 21)
        Me.cmbGender.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(375, 114)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Gender"
        '
        'txtSection
        '
        Me.txtSection.Location = New System.Drawing.Point(479, 85)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(193, 20)
        Me.txtSection.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(375, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Section"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(127, 145)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(196, 20)
        Me.txtAddress.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Home Address"
        '
        'txtStudLName
        '
        Me.txtStudLName.Location = New System.Drawing.Point(127, 90)
        Me.txtStudLName.Name = "txtStudLName"
        Me.txtStudLName.Size = New System.Drawing.Size(196, 20)
        Me.txtStudLName.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Student Last Name"
        '
        'txtStudFName
        '
        Me.txtStudFName.Location = New System.Drawing.Point(127, 60)
        Me.txtStudFName.Name = "txtStudFName"
        Me.txtStudFName.Size = New System.Drawing.Size(193, 20)
        Me.txtStudFName.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Student First Name"
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(82, 28)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.ReadOnly = True
        Me.txtStudentID.Size = New System.Drawing.Size(100, 20)
        Me.txtStudentID.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Student ID"
        '
        'DataGridViewInfo
        '
        Me.DataGridViewInfo.AllowUserToAddRows = False
        Me.DataGridViewInfo.AllowUserToDeleteRows = False
        Me.DataGridViewInfo.AllowUserToResizeColumns = False
        Me.DataGridViewInfo.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewInfo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewInfo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewInfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colStudentID, Me.colStudFName, Me.colStudMName, Me.colStudLName, Me.colGender, Me.colAddress, Me.colYear, Me.colSection, Me.colContactNumber})
        Me.DataGridViewInfo.Location = New System.Drawing.Point(241, 1)
        Me.DataGridViewInfo.Name = "DataGridViewInfo"
        Me.DataGridViewInfo.ReadOnly = True
        Me.DataGridViewInfo.RowHeadersVisible = False
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewInfo.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewInfo.Size = New System.Drawing.Size(487, 223)
        Me.DataGridViewInfo.TabIndex = 64
        '
        'colStudentID
        '
        Me.colStudentID.HeaderText = "Student ID"
        Me.colStudentID.Name = "colStudentID"
        Me.colStudentID.ReadOnly = True
        Me.colStudentID.Width = 98
        '
        'colStudFName
        '
        Me.colStudFName.HeaderText = "First Name"
        Me.colStudFName.Name = "colStudFName"
        Me.colStudFName.ReadOnly = True
        Me.colStudFName.Width = 98
        '
        'colStudMName
        '
        Me.colStudMName.HeaderText = "Middle Name"
        Me.colStudMName.Name = "colStudMName"
        Me.colStudMName.ReadOnly = True
        Me.colStudMName.Width = 115
        '
        'colStudLName
        '
        Me.colStudLName.HeaderText = "Last Name"
        Me.colStudLName.Name = "colStudLName"
        Me.colStudLName.ReadOnly = True
        Me.colStudLName.Width = 96
        '
        'colGender
        '
        Me.colGender.HeaderText = "Gender"
        Me.colGender.Name = "colGender"
        Me.colGender.ReadOnly = True
        Me.colGender.Width = 84
        '
        'colAddress
        '
        Me.colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colAddress.HeaderText = "Address"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.ReadOnly = True
        Me.colAddress.Width = 88
        '
        'colYear
        '
        Me.colYear.HeaderText = "Year"
        Me.colYear.Name = "colYear"
        Me.colYear.ReadOnly = True
        Me.colYear.Width = 63
        '
        'colSection
        '
        Me.colSection.HeaderText = "Section"
        Me.colSection.Name = "colSection"
        Me.colSection.ReadOnly = True
        Me.colSection.Width = 84
        '
        'colContactNumber
        '
        Me.colContactNumber.HeaderText = "Contact Number"
        Me.colContactNumber.Name = "colContactNumber"
        Me.colContactNumber.ReadOnly = True
        Me.colContactNumber.Width = 134
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Brown
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.CloudDesktopButton1)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Location = New System.Drawing.Point(0, 412)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(728, 84)
        Me.Panel1.TabIndex = 85
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.AnimationSpeed = 5
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.BackgroundOpacity = 100
        Me.btnDelete.BackgroundOpacity_MouseDown = 170
        Me.btnDelete.BorderColor = System.Drawing.Color.White
        Me.btnDelete.BorderOpacity = 170
        Me.btnDelete.BorderWidth = 1
        Me.btnDelete.ControlText = "Delete"
        Me.btnDelete.CornerRadius = 12
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.DrawBlackTextBackground = True
        Me.btnDelete.FillColor = System.Drawing.Color.DimGray
        Me.btnDelete.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Icon = Global.JRILibrarySystem.My.Resources.Resources.Actions_user_group_delete_icon
        Me.btnDelete.Location = New System.Drawing.Point(370, 0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(102, 78)
        Me.btnDelete.TabIndex = 3
        '
        'CloudDesktopButton1
        '
        Me.CloudDesktopButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CloudDesktopButton1.AnimationSpeed = 5
        Me.CloudDesktopButton1.BackColor = System.Drawing.Color.Transparent
        Me.CloudDesktopButton1.BackgroundOpacity = 100
        Me.CloudDesktopButton1.BackgroundOpacity_MouseDown = 170
        Me.CloudDesktopButton1.BorderColor = System.Drawing.Color.White
        Me.CloudDesktopButton1.BorderOpacity = 170
        Me.CloudDesktopButton1.BorderWidth = 1
        Me.CloudDesktopButton1.ControlText = "Close"
        Me.CloudDesktopButton1.CornerRadius = 12
        Me.CloudDesktopButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloudDesktopButton1.DrawBlackTextBackground = True
        Me.CloudDesktopButton1.FillColor = System.Drawing.Color.White
        Me.CloudDesktopButton1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloudDesktopButton1.ForeColor = System.Drawing.Color.White
        Me.CloudDesktopButton1.Icon = Global.JRILibrarySystem.My.Resources.Resources.Close_2_icon
        Me.CloudDesktopButton1.Location = New System.Drawing.Point(484, 3)
        Me.CloudDesktopButton1.Name = "CloudDesktopButton1"
        Me.CloudDesktopButton1.Size = New System.Drawing.Size(102, 74)
        Me.CloudDesktopButton1.TabIndex = 0
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.AnimationSpeed = 5
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BackgroundOpacity = 100
        Me.btnClear.BackgroundOpacity_MouseDown = 170
        Me.btnClear.BorderColor = System.Drawing.Color.White
        Me.btnClear.BorderOpacity = 170
        Me.btnClear.BorderWidth = 1
        Me.btnClear.ControlText = "Clear"
        Me.btnClear.CornerRadius = 12
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.DrawBlackTextBackground = True
        Me.btnClear.FillColor = System.Drawing.Color.White
        Me.btnClear.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Icon = Global.JRILibrarySystem.My.Resources.Resources.Recycle_Empty_icon
        Me.btnClear.Location = New System.Drawing.Point(256, 6)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(102, 74)
        Me.btnClear.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.AnimationSpeed = 5
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BackgroundOpacity = 100
        Me.btnSave.BackgroundOpacity_MouseDown = 170
        Me.btnSave.BorderColor = System.Drawing.Color.White
        Me.btnSave.BorderOpacity = 170
        Me.btnSave.BorderWidth = 1
        Me.btnSave.ControlText = "Update"
        Me.btnSave.CornerRadius = 12
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.DrawBlackTextBackground = True
        Me.btnSave.Enabled = False
        Me.btnSave.FillColor = System.Drawing.Color.White
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Icon = Global.JRILibrarySystem.My.Resources.Resources.Setting_3
        Me.btnSave.Location = New System.Drawing.Point(142, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(102, 79)
        Me.btnSave.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 13)
        Me.Label10.TabIndex = 88
        Me.Label10.Text = "Search by student id"
        '
        'ListBoxStudents
        '
        Me.ListBoxStudents.FormattingEnabled = True
        Me.ListBoxStudents.Location = New System.Drawing.Point(12, 51)
        Me.ListBoxStudents.Name = "ListBoxStudents"
        Me.ListBoxStudents.Size = New System.Drawing.Size(210, 173)
        Me.ListBoxStudents.TabIndex = 87
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 23)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(210, 20)
        Me.txtSearch.TabIndex = 86
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"First", "Second", "Third", "Fourth", "Fifth"})
        Me.cmbYear.Location = New System.Drawing.Point(479, 54)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(121, 21)
        Me.cmbYear.TabIndex = 8
        '
        'frmModifyStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 497)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ListBoxStudents)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridViewInfo)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "frmModifyStudents"
        Me.Text = "Modify Student Record"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtStudLName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtStudFName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtStudentID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents DataGridViewInfo As System.Windows.Forms.DataGridView
    Friend WithEvents btnSave As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents btnClear As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CloudDesktopButton1 As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents colStudentID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStudFName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStudMName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStudLName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colYear As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSection As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colContactNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ListBoxStudents As System.Windows.Forms.ListBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
End Class
