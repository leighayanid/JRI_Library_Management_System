<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModifyBook
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtManufacturer = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumberOfCopies = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDelete = New CloudToolkitN6.CloudDesktopButton()
        Me.CloudDesktopButton1 = New CloudToolkitN6.CloudDesktopButton()
        Me.btnClear = New CloudToolkitN6.CloudDesktopButton()
        Me.btnSave = New CloudToolkitN6.CloudDesktopButton()
        Me.txtCopyright = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBookTitle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridViewInfo = New System.Windows.Forms.DataGridView()
        Me.colBookNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBookTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAuthor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colManufacturer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCopyright = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNumberOfCopies = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCopiesAvailable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBookNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ListBoxBooks = New System.Windows.Forms.ListBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtManufacturer
        '
        Me.txtManufacturer.Location = New System.Drawing.Point(127, 116)
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.Size = New System.Drawing.Size(196, 20)
        Me.txtManufacturer.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Manufacturer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(375, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Number of Copies"
        '
        'txtNumberOfCopies
        '
        Me.txtNumberOfCopies.Location = New System.Drawing.Point(479, 59)
        Me.txtNumberOfCopies.Name = "txtNumberOfCopies"
        Me.txtNumberOfCopies.Size = New System.Drawing.Size(193, 20)
        Me.txtNumberOfCopies.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Brown
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.CloudDesktopButton1)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Location = New System.Drawing.Point(0, 401)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(728, 84)
        Me.Panel1.TabIndex = 88
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
        Me.btnDelete.Location = New System.Drawing.Point(385, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(102, 78)
        Me.btnDelete.TabIndex = 86
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
        Me.CloudDesktopButton1.Location = New System.Drawing.Point(535, 4)
        Me.CloudDesktopButton1.Name = "CloudDesktopButton1"
        Me.CloudDesktopButton1.Size = New System.Drawing.Size(102, 74)
        Me.CloudDesktopButton1.TabIndex = 85
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
        Me.btnClear.Location = New System.Drawing.Point(230, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(102, 74)
        Me.btnClear.TabIndex = 83
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
        Me.btnSave.FillColor = System.Drawing.Color.White
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Icon = Global.JRILibrarySystem.My.Resources.Resources.Setting_3
        Me.btnSave.Location = New System.Drawing.Point(91, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(102, 74)
        Me.btnSave.TabIndex = 84
        '
        'txtCopyright
        '
        Me.txtCopyright.Location = New System.Drawing.Point(479, 93)
        Me.txtCopyright.Name = "txtCopyright"
        Me.txtCopyright.Size = New System.Drawing.Size(193, 20)
        Me.txtCopyright.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(380, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Copyright"
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(127, 88)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(196, 20)
        Me.txtAuthor.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Author"
        '
        'txtBookTitle
        '
        Me.txtBookTitle.Location = New System.Drawing.Point(127, 60)
        Me.txtBookTitle.Name = "txtBookTitle"
        Me.txtBookTitle.Size = New System.Drawing.Size(196, 20)
        Me.txtBookTitle.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Book Title"
        '
        'DataGridViewInfo
        '
        Me.DataGridViewInfo.AllowUserToAddRows = False
        Me.DataGridViewInfo.AllowUserToDeleteRows = False
        Me.DataGridViewInfo.AllowUserToResizeColumns = False
        Me.DataGridViewInfo.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewInfo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewInfo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewInfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBookNumber, Me.colBookTitle, Me.colAuthor, Me.colManufacturer, Me.colCopyright, Me.colNumberOfCopies, Me.colCopiesAvailable})
        Me.DataGridViewInfo.Location = New System.Drawing.Point(239, 2)
        Me.DataGridViewInfo.Name = "DataGridViewInfo"
        Me.DataGridViewInfo.ReadOnly = True
        Me.DataGridViewInfo.RowHeadersVisible = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewInfo.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewInfo.Size = New System.Drawing.Size(491, 225)
        Me.DataGridViewInfo.TabIndex = 87
        '
        'colBookNumber
        '
        Me.colBookNumber.HeaderText = "Book Number"
        Me.colBookNumber.Name = "colBookNumber"
        Me.colBookNumber.ReadOnly = True
        Me.colBookNumber.Width = 118
        '
        'colBookTitle
        '
        Me.colBookTitle.HeaderText = "Book Title"
        Me.colBookTitle.Name = "colBookTitle"
        Me.colBookTitle.ReadOnly = True
        Me.colBookTitle.Width = 95
        '
        'colAuthor
        '
        Me.colAuthor.HeaderText = "Author"
        Me.colAuthor.Name = "colAuthor"
        Me.colAuthor.ReadOnly = True
        Me.colAuthor.Width = 83
        '
        'colManufacturer
        '
        Me.colManufacturer.HeaderText = "Manufacturer"
        Me.colManufacturer.Name = "colManufacturer"
        Me.colManufacturer.ReadOnly = True
        Me.colManufacturer.Width = 129
        '
        'colCopyright
        '
        Me.colCopyright.HeaderText = "Copyright"
        Me.colCopyright.Name = "colCopyright"
        Me.colCopyright.ReadOnly = True
        Me.colCopyright.Width = 101
        '
        'colNumberOfCopies
        '
        Me.colNumberOfCopies.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colNumberOfCopies.HeaderText = "Number of Copies"
        Me.colNumberOfCopies.Name = "colNumberOfCopies"
        Me.colNumberOfCopies.ReadOnly = True
        Me.colNumberOfCopies.Width = 103
        '
        'colCopiesAvailable
        '
        Me.colCopiesAvailable.HeaderText = "Copies Available"
        Me.colCopiesAvailable.Name = "colCopiesAvailable"
        Me.colCopiesAvailable.ReadOnly = True
        Me.colCopiesAvailable.Width = 132
        '
        'txtBookNumber
        '
        Me.txtBookNumber.Location = New System.Drawing.Point(100, 26)
        Me.txtBookNumber.Name = "txtBookNumber"
        Me.txtBookNumber.ReadOnly = True
        Me.txtBookNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtBookNumber.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Book Number"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtManufacturer)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNumberOfCopies)
        Me.GroupBox1.Controls.Add(Me.txtCopyright)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtAuthor)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtBookTitle)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtBookNumber)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(17, 235)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(691, 156)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fill book record"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 13)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Search by book title"
        '
        'ListBoxBooks
        '
        Me.ListBoxBooks.FormattingEnabled = True
        Me.ListBoxBooks.Location = New System.Drawing.Point(12, 54)
        Me.ListBoxBooks.Name = "ListBoxBooks"
        Me.ListBoxBooks.Size = New System.Drawing.Size(210, 173)
        Me.ListBoxBooks.TabIndex = 90
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 26)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(210, 20)
        Me.txtSearch.TabIndex = 89
        Me.ToolTip1.SetToolTip(Me.txtSearch, "Hit enter after typing in  the book title")
        '
        'frmModifyBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 485)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ListBoxBooks)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridViewInfo)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "frmModifyBook"
        Me.Text = "Modify Book Record"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridViewInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtManufacturer As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumberOfCopies As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CloudDesktopButton1 As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents btnSave As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents txtCopyright As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBookTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents DataGridViewInfo As System.Windows.Forms.DataGridView
    Friend WithEvents txtBookNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents colBookNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBookTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAuthor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colManufacturer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCopyright As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNumberOfCopies As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCopiesAvailable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ListBoxBooks As System.Windows.Forms.ListBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
