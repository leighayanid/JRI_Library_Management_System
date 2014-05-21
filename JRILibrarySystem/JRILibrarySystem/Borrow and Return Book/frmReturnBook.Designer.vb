<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturnBook
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
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBorrowDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblPaymentGuide = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.txtAmountCharge = New System.Windows.Forms.TextBox()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.txtBookNumber = New System.Windows.Forms.TextBox()
        Me.lblGuide = New System.Windows.Forms.Label()
        Me.btnCancel = New CloudToolkitN6.Windows.Vista.CloudStartMenuButton()
        Me.btnReturn = New CloudToolkitN6.Windows.Vista.CloudStartMenuButton()
        Me.txtReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStudNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBookReturn = New System.Windows.Forms.TextBox()
        Me.DataGridViewInfo1 = New System.Windows.Forms.DataGridView()
        Me.colBookID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBookTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNumberOfCopies = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCopiesAvailable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewInfo = New System.Windows.Forms.DataGridView()
        Me.colStudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudFName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudMName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudLName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBorrowedBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateOfBorrowed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateOfReturned = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPenalty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPayment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colChange = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBorrowDate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtAmountCharge)
        Me.GroupBox1.Controls.Add(Me.lbl6)
        Me.GroupBox1.Controls.Add(Me.txtBookNumber)
        Me.GroupBox1.Controls.Add(Me.lblGuide)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnReturn)
        Me.GroupBox1.Controls.Add(Me.txtReturnDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtStudNumber)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtBookReturn)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 534)
        Me.GroupBox1.TabIndex = 85
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Please fill up all textboxes with proper information"
        '
        'txtBorrowDate
        '
        Me.txtBorrowDate.Location = New System.Drawing.Point(150, 206)
        Me.txtBorrowDate.Name = "txtBorrowDate"
        Me.txtBorrowDate.Size = New System.Drawing.Size(185, 22)
        Me.txtBorrowDate.TabIndex = 85
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Borrow date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 292)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 16)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Amount of charge :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblPaymentGuide)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtPayment)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtChange)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 332)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 131)
        Me.GroupBox2.TabIndex = 79
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payment (if there is a penalty/charge)"
        '
        'lblPaymentGuide
        '
        Me.lblPaymentGuide.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentGuide.Location = New System.Drawing.Point(117, 75)
        Me.lblPaymentGuide.Name = "lblPaymentGuide"
        Me.lblPaymentGuide.Size = New System.Drawing.Size(212, 16)
        Me.lblPaymentGuide.TabIndex = 76
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(66, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 16)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Payment  (in peso)"
        '
        'txtPayment
        '
        Me.txtPayment.Location = New System.Drawing.Point(196, 42)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(133, 22)
        Me.txtPayment.TabIndex = 75
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(120, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 16)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "Change"
        '
        'txtChange
        '
        Me.txtChange.Location = New System.Drawing.Point(195, 98)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(134, 22)
        Me.txtChange.TabIndex = 69
        '
        'txtAmountCharge
        '
        Me.txtAmountCharge.Location = New System.Drawing.Point(179, 291)
        Me.txtAmountCharge.Name = "txtAmountCharge"
        Me.txtAmountCharge.Size = New System.Drawing.Size(155, 22)
        Me.txtAmountCharge.TabIndex = 67
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.Location = New System.Drawing.Point(83, 108)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(93, 16)
        Me.lbl6.TabIndex = 74
        Me.lbl6.Text = "Enter book id :"
        '
        'txtBookNumber
        '
        Me.txtBookNumber.Enabled = False
        Me.txtBookNumber.Location = New System.Drawing.Point(201, 107)
        Me.txtBookNumber.Name = "txtBookNumber"
        Me.txtBookNumber.Size = New System.Drawing.Size(133, 22)
        Me.txtBookNumber.TabIndex = 75
        '
        'lblGuide
        '
        Me.lblGuide.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuide.Location = New System.Drawing.Point(147, 84)
        Me.lblGuide.Name = "lblGuide"
        Me.lblGuide.Size = New System.Drawing.Size(212, 16)
        Me.lblGuide.TabIndex = 73
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
        Me.btnCancel.Location = New System.Drawing.Point(201, 489)
        Me.btnCancel.MaximumGlowOpacity = 0.8R
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.NormalColors_1 = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnCancel.NormalColors_2 = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnCancel.NormalColors_3 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnCancel.NormalColors_4 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnCancel.Size = New System.Drawing.Size(144, 29)
        Me.btnCancel.StartMenuIndex = 0
        Me.btnCancel.TabIndex = 80
        Me.btnCancel.TextCentered = True
        Me.btnCancel.TextDistanceFromBorder = 5
        Me.btnCancel.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.TextOverIcon
        '
        'btnReturn
        '
        Me.btnReturn.AnimationOpacityChange = 0.1R
        Me.btnReturn.BackColor = System.Drawing.Color.Transparent
        Me.btnReturn.ButtonText = "Return"
        Me.btnReturn.ClickedColors_1 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnReturn.ClickedColors_2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnReturn.ClickedColors_3 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnReturn.ClickedColors_4 = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnReturn.ControlOpacity = 255
        Me.btnReturn.CornerRadius = 8
        Me.btnReturn.DrawHoverOverIcon = False
        Me.btnReturn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.White
        Me.btnReturn.GlowColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnReturn.Icon = Nothing
        Me.btnReturn.IsAnimated = True
        Me.btnReturn.Location = New System.Drawing.Point(30, 489)
        Me.btnReturn.MaximumGlowOpacity = 0.8R
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.NormalColors_1 = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnReturn.NormalColors_2 = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnReturn.NormalColors_3 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnReturn.NormalColors_4 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnReturn.Size = New System.Drawing.Size(151, 29)
        Me.btnReturn.StartMenuIndex = 0
        Me.btnReturn.TabIndex = 79
        Me.btnReturn.TextCentered = True
        Me.btnReturn.TextDistanceFromBorder = 5
        Me.btnReturn.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.TextOverIcon
        '
        'txtReturnDate
        '
        Me.txtReturnDate.Location = New System.Drawing.Point(150, 250)
        Me.txtReturnDate.Name = "txtReturnDate"
        Me.txtReturnDate.Size = New System.Drawing.Size(184, 22)
        Me.txtReturnDate.TabIndex = 72
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 16)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Enter student number :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Return date"
        '
        'txtStudNumber
        '
        Me.txtStudNumber.Location = New System.Drawing.Point(201, 55)
        Me.txtStudNumber.Name = "txtStudNumber"
        Me.txtStudNumber.Size = New System.Drawing.Size(133, 22)
        Me.txtStudNumber.TabIndex = 67
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Name of book :"
        '
        'txtBookReturn
        '
        Me.txtBookReturn.Enabled = False
        Me.txtBookReturn.Location = New System.Drawing.Point(45, 166)
        Me.txtBookReturn.Name = "txtBookReturn"
        Me.txtBookReturn.Size = New System.Drawing.Size(290, 22)
        Me.txtBookReturn.TabIndex = 69
        '
        'DataGridViewInfo1
        '
        Me.DataGridViewInfo1.AllowUserToAddRows = False
        Me.DataGridViewInfo1.AllowUserToDeleteRows = False
        Me.DataGridViewInfo1.AllowUserToResizeColumns = False
        Me.DataGridViewInfo1.AllowUserToResizeRows = False
        DataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewInfo1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle37
        Me.DataGridViewInfo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewInfo1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewInfo1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle38.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewInfo1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle38
        Me.DataGridViewInfo1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewInfo1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBookID, Me.colBookTitle, Me.colNumberOfCopies, Me.colCopiesAvailable})
        Me.DataGridViewInfo1.Location = New System.Drawing.Point(408, 376)
        Me.DataGridViewInfo1.Name = "DataGridViewInfo1"
        Me.DataGridViewInfo1.ReadOnly = True
        Me.DataGridViewInfo1.RowHeadersVisible = False
        DataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewInfo1.RowsDefaultCellStyle = DataGridViewCellStyle39
        Me.DataGridViewInfo1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewInfo1.Size = New System.Drawing.Size(489, 198)
        Me.DataGridViewInfo1.TabIndex = 87
        '
        'colBookID
        '
        Me.colBookID.HeaderText = "Book Number"
        Me.colBookID.Name = "colBookID"
        Me.colBookID.ReadOnly = True
        Me.colBookID.Width = 118
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
        'DataGridViewInfo
        '
        Me.DataGridViewInfo.AllowUserToAddRows = False
        Me.DataGridViewInfo.AllowUserToDeleteRows = False
        Me.DataGridViewInfo.AllowUserToResizeColumns = False
        Me.DataGridViewInfo.AllowUserToResizeRows = False
        DataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewInfo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle40
        Me.DataGridViewInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewInfo.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle41.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewInfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle41
        Me.DataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colStudentID, Me.colStudFName, Me.colStudMName, Me.colStudLName, Me.colBorrowedBook, Me.colDateOfBorrowed, Me.colDateOfReturned, Me.colPenalty, Me.colPayment, Me.colChange})
        Me.DataGridViewInfo.Location = New System.Drawing.Point(407, 10)
        Me.DataGridViewInfo.Name = "DataGridViewInfo"
        Me.DataGridViewInfo.ReadOnly = True
        Me.DataGridViewInfo.RowHeadersVisible = False
        DataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewInfo.RowsDefaultCellStyle = DataGridViewCellStyle42
        Me.DataGridViewInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewInfo.Size = New System.Drawing.Size(526, 347)
        Me.DataGridViewInfo.TabIndex = 86
        '
        'colStudentID
        '
        Me.colStudentID.HeaderText = "Student ID Number"
        Me.colStudentID.Name = "colStudentID"
        Me.colStudentID.ReadOnly = True
        Me.colStudentID.Width = 152
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
        'colBorrowedBook
        '
        Me.colBorrowedBook.HeaderText = "Borrowed Book"
        Me.colBorrowedBook.Name = "colBorrowedBook"
        Me.colBorrowedBook.ReadOnly = True
        Me.colBorrowedBook.Width = 129
        '
        'colDateOfBorrowed
        '
        Me.colDateOfBorrowed.HeaderText = "Date of Borrowing Book"
        Me.colDateOfBorrowed.Name = "colDateOfBorrowed"
        Me.colDateOfBorrowed.ReadOnly = True
        Me.colDateOfBorrowed.Width = 150
        '
        'colDateOfReturned
        '
        Me.colDateOfReturned.HeaderText = "Date of Returning Book"
        Me.colDateOfReturned.Name = "colDateOfReturned"
        Me.colDateOfReturned.ReadOnly = True
        Me.colDateOfReturned.Width = 146
        '
        'colPenalty
        '
        Me.colPenalty.HeaderText = "Penalty / Charges"
        Me.colPenalty.Name = "colPenalty"
        Me.colPenalty.ReadOnly = True
        Me.colPenalty.Width = 141
        '
        'colPayment
        '
        Me.colPayment.HeaderText = "Payment"
        Me.colPayment.Name = "colPayment"
        Me.colPayment.ReadOnly = True
        Me.colPayment.Width = 95
        '
        'colChange
        '
        Me.colChange.HeaderText = "Change"
        Me.colChange.Name = "colChange"
        Me.colChange.ReadOnly = True
        Me.colChange.Width = 84
        '
        'frmReturnBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 589)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridViewInfo1)
        Me.Controls.Add(Me.DataGridViewInfo)
        Me.DoubleBuffered = True
        Me.Name = "frmReturnBook"
        Me.Text = "frReturnBook"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridViewInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBorrowDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPaymentGuide As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPayment As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents txtAmountCharge As System.Windows.Forms.TextBox
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents txtBookNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblGuide As System.Windows.Forms.Label
    Friend WithEvents btnCancel As CloudToolkitN6.Windows.Vista.CloudStartMenuButton
    Friend WithEvents btnReturn As CloudToolkitN6.Windows.Vista.CloudStartMenuButton
    Friend WithEvents txtReturnDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtStudNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBookReturn As System.Windows.Forms.TextBox
    Private WithEvents DataGridViewInfo1 As System.Windows.Forms.DataGridView
    Friend WithEvents colBookID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBookTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNumberOfCopies As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCopiesAvailable As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents DataGridViewInfo As System.Windows.Forms.DataGridView
    Friend WithEvents colStudentID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStudFName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStudMName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStudLName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBorrowedBook As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateOfBorrowed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateOfReturned As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPenalty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPayment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colChange As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
