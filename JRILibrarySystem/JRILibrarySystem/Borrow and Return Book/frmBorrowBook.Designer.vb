<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrowBook
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBorrowBook))
        Me.DataGridViewInfo1 = New System.Windows.Forms.DataGridView()
        Me.colBookNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBookTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNumberOfCopies = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCopiesAvailable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudLName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudFName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancel = New CloudToolkitN6.Windows.Vista.CloudStartMenuButton()
        Me.btnOK = New CloudToolkitN6.Windows.Vista.CloudStartMenuButton()
        Me.DataGridViewInfo = New System.Windows.Forms.DataGridView()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBookNumber = New System.Windows.Forms.TextBox()
        Me.lblGuide = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtBorrowDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStudNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBookBorrow = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridViewInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewInfo1
        '
        Me.DataGridViewInfo1.AllowUserToAddRows = False
        Me.DataGridViewInfo1.AllowUserToDeleteRows = False
        Me.DataGridViewInfo1.AllowUserToResizeColumns = False
        Me.DataGridViewInfo1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewInfo1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewInfo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewInfo1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewInfo1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewInfo1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewInfo1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewInfo1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBookNumber, Me.colBookTitle, Me.colNumberOfCopies, Me.colCopiesAvailable})
        Me.DataGridViewInfo1.Location = New System.Drawing.Point(375, 192)
        Me.DataGridViewInfo1.Name = "DataGridViewInfo1"
        Me.DataGridViewInfo1.ReadOnly = True
        Me.DataGridViewInfo1.RowHeadersVisible = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewInfo1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewInfo1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewInfo1.Size = New System.Drawing.Size(488, 211)
        Me.DataGridViewInfo1.TabIndex = 85
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
        'colNumberOfCopies
        '
        Me.colNumberOfCopies.HeaderText = "Number of copies of Book"
        Me.colNumberOfCopies.Name = "colNumberOfCopies"
        Me.colNumberOfCopies.ReadOnly = True
        Me.colNumberOfCopies.Width = 145
        '
        'colCopiesAvailable
        '
        Me.colCopiesAvailable.HeaderText = "Available Copy of Book"
        Me.colCopiesAvailable.Name = "colCopiesAvailable"
        Me.colCopiesAvailable.ReadOnly = True
        Me.colCopiesAvailable.Width = 127
        '
        'colStudLName
        '
        Me.colStudLName.HeaderText = "Last Name"
        Me.colStudLName.Name = "colStudLName"
        Me.colStudLName.ReadOnly = True
        Me.colStudLName.Width = 96
        '
        'colStudFName
        '
        Me.colStudFName.HeaderText = "First Name"
        Me.colStudFName.Name = "colStudFName"
        Me.colStudFName.ReadOnly = True
        Me.colStudFName.Width = 98
        '
        'colStudentID
        '
        Me.colStudentID.HeaderText = "Student ID Number"
        Me.colStudentID.Name = "colStudentID"
        Me.colStudentID.ReadOnly = True
        Me.colStudentID.Width = 152
        '
        'btnCancel
        '
        Me.btnCancel.AnimationOpacityChange = 0.1R
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.ButtonText = "Cancel"
        Me.btnCancel.ClickedColors_1 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCancel.ClickedColors_2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnCancel.ClickedColors_3 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnCancel.ClickedColors_4 = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnCancel.ControlOpacity = 255
        Me.btnCancel.CornerRadius = 8
        Me.btnCancel.DrawHoverOverIcon = False
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.GlowColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnCancel.Icon = Nothing
        Me.btnCancel.IsAnimated = True
        Me.btnCancel.Location = New System.Drawing.Point(211, 317)
        Me.btnCancel.MaximumGlowOpacity = 0.8R
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.NormalColors_1 = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnCancel.NormalColors_2 = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnCancel.NormalColors_3 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnCancel.NormalColors_4 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnCancel.Size = New System.Drawing.Size(159, 67)
        Me.btnCancel.StartMenuIndex = 0
        Me.btnCancel.TabIndex = 83
        Me.btnCancel.TextCentered = True
        Me.btnCancel.TextDistanceFromBorder = 5
        Me.btnCancel.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.TextOverIcon
        '
        'btnOK
        '
        Me.btnOK.AnimationOpacityChange = 0.1R
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.ButtonText = "Borrow"
        Me.btnOK.ClickedColors_1 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnOK.ClickedColors_2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnOK.ClickedColors_3 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnOK.ClickedColors_4 = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnOK.ControlOpacity = 255
        Me.btnOK.CornerRadius = 8
        Me.btnOK.DrawHoverOverIcon = False
        Me.btnOK.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.GlowColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnOK.Icon = Nothing
        Me.btnOK.IsAnimated = True
        Me.btnOK.Location = New System.Drawing.Point(14, 317)
        Me.btnOK.MaximumGlowOpacity = 0.8R
        Me.btnOK.Name = "btnOK"
        Me.btnOK.NormalColors_1 = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnOK.NormalColors_2 = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnOK.NormalColors_3 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnOK.NormalColors_4 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnOK.Size = New System.Drawing.Size(159, 67)
        Me.btnOK.StartMenuIndex = 0
        Me.btnOK.TabIndex = 82
        Me.btnOK.TextCentered = True
        Me.btnOK.TextDistanceFromBorder = 5
        Me.btnOK.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.TextOverIcon
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
        Me.DataGridViewInfo.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridViewInfo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewInfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colStudentID, Me.colStudFName, Me.colStudLName})
        Me.DataGridViewInfo.Location = New System.Drawing.Point(376, 12)
        Me.DataGridViewInfo.Name = "DataGridViewInfo"
        Me.DataGridViewInfo.ReadOnly = True
        Me.DataGridViewInfo.RowHeadersVisible = False
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewInfo.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewInfo.Size = New System.Drawing.Size(349, 172)
        Me.DataGridViewInfo.TabIndex = 84
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.Location = New System.Drawing.Point(29, 82)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(141, 16)
        Me.lbl6.TabIndex = 74
        Me.lbl6.Text = "Enter book id number :"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(746, 66)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = resources.GetString("Label5.Text")
        '
        'txtBookNumber
        '
        Me.txtBookNumber.Enabled = False
        Me.txtBookNumber.Location = New System.Drawing.Point(188, 82)
        Me.txtBookNumber.Name = "txtBookNumber"
        Me.txtBookNumber.Size = New System.Drawing.Size(133, 22)
        Me.txtBookNumber.TabIndex = 75
        '
        'lblGuide
        '
        Me.lblGuide.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuide.Location = New System.Drawing.Point(107, 59)
        Me.lblGuide.Name = "lblGuide"
        Me.lblGuide.Size = New System.Drawing.Size(212, 16)
        Me.lblGuide.TabIndex = 73
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(1, 410)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(895, 75)
        Me.Panel2.TabIndex = 79
        '
        'txtBorrowDate
        '
        Me.txtBorrowDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrowDate.Location = New System.Drawing.Point(32, 182)
        Me.txtBorrowDate.Name = "txtBorrowDate"
        Me.txtBorrowDate.Size = New System.Drawing.Size(290, 22)
        Me.txtBorrowDate.TabIndex = 72
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 16)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Enter student number :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Borrow Date :"
        '
        'txtStudNumber
        '
        Me.txtStudNumber.Location = New System.Drawing.Point(188, 30)
        Me.txtStudNumber.Name = "txtStudNumber"
        Me.txtStudNumber.Size = New System.Drawing.Size(133, 22)
        Me.txtStudNumber.TabIndex = 67
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Name of book :"
        '
        'txtBookBorrow
        '
        Me.txtBookBorrow.Enabled = False
        Me.txtBookBorrow.Location = New System.Drawing.Point(32, 131)
        Me.txtBookBorrow.Name = "txtBookBorrow"
        Me.txtBookBorrow.Size = New System.Drawing.Size(290, 22)
        Me.txtBookBorrow.TabIndex = 69
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl6)
        Me.GroupBox1.Controls.Add(Me.txtBookNumber)
        Me.GroupBox1.Controls.Add(Me.lblGuide)
        Me.GroupBox1.Controls.Add(Me.txtBorrowDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtStudNumber)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtBookBorrow)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 228)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Only registered student can borrow books"
        '
        'frmBorrowBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 486)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.DataGridViewInfo1)
        Me.Controls.Add(Me.DataGridViewInfo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Name = "frmBorrowBook"
        Me.Text = "Borrow Book"
        CType(Me.DataGridViewInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents DataGridViewInfo1 As System.Windows.Forms.DataGridView
    Friend WithEvents colStudLName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStudFName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStudentID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCancel As CloudToolkitN6.Windows.Vista.CloudStartMenuButton
    Friend WithEvents btnOK As CloudToolkitN6.Windows.Vista.CloudStartMenuButton
    Private WithEvents DataGridViewInfo As System.Windows.Forms.DataGridView
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBookNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblGuide As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtBorrowDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtStudNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBookBorrow As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents colBookNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBookTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNumberOfCopies As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCopiesAvailable As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
