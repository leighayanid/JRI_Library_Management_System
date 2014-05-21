Public Class frmReturnBook
    Dim _studentDataTable As DataTable
    Dim _bookDataTable As DataTable
    Dim dateChecker As Integer

    Private Sub frmReturnBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
        txtStudNumber.Focus()

    End Sub

    Private Sub Reload()
        LoadDBStudent()
        LoadDBBook()
        ClearTextBoxes()
    End Sub

    Private Sub LoadDBStudent()
        Dim query As String = "SELECT * FROM tblStudent"
        Me._studentDataTable = DatabaseFunctions.GetDataTable(query)

        'kapag zero ung count return lang 
        If Me._studentDataTable.Rows.Count = 0 Then
            Return
        End If

        DataGridViewInfo.Rows.Clear()

        For Each dtRow In Me._studentDataTable.Rows
            DataGridViewInfo.Rows.Add()
            DataGridViewInfo.Rows(DataGridViewInfo.RowCount - 1).Cells("colStudentID").Value = dtRow("StudentID").ToString()
            DataGridViewInfo.Rows(DataGridViewInfo.RowCount - 1).Cells("colStudFName").Value = dtRow("FName").ToString()
            DataGridViewInfo.Rows(DataGridViewInfo.RowCount - 1).Cells("colStudLName").Value = dtRow("LName").ToString()
            DataGridViewInfo.Rows(DataGridViewInfo.RowCount - 1).Cells("colStudMName").Value = dtRow("MName").ToString()
            DataGridViewInfo.Rows(DataGridViewInfo.RowCount - 1).Cells("colBorrowedBook").Value = dtRow("BorrowBook").ToString()
            DataGridViewInfo.Rows(DataGridViewInfo.RowCount - 1).Cells("colDateOfBorrowed").Value = dtRow("DateOfBorrow").ToString()
            DataGridViewInfo.Rows(DataGridViewInfo.RowCount - 1).Cells("colDateOfReturned").Value = dtRow("DateOfReturn").ToString()
            DataGridViewInfo.Rows(DataGridViewInfo.RowCount - 1).Cells("colPenalty").Value = dtRow("Penalty").ToString()
            DataGridViewInfo.Rows(DataGridViewInfo.RowCount - 1).Cells("colPayment").Value = dtRow("Payment").ToString()
            DataGridViewInfo.Rows(DataGridViewInfo.RowCount - 1).Cells("colChange").Value = dtRow("Change").ToString()

        Next

        DataGridViewInfo.ClearSelection()
    End Sub

    Private Sub LoadDBBook()
        Dim query As String = "SELECT * FROM tblBook"
        Me._bookDataTable = DatabaseFunctions.GetDataTable(query)

        'kapag zero ung count return lang 
        If Me._bookDataTable.Rows.Count = 0 Then
            Return
        End If

        DataGridViewInfo1.Rows.Clear()

        For Each dtRow In Me._bookDataTable.Rows
            DataGridViewInfo1.Rows.Add()
            DataGridViewInfo1.Rows(DataGridViewInfo1.RowCount - 1).Cells("colBookID").Value = dtRow("BookNumber").ToString()
            DataGridViewInfo1.Rows(DataGridViewInfo1.RowCount - 1).Cells("colBookTitle").Value = dtRow("BookTitle").ToString()
            DataGridViewInfo1.Rows(DataGridViewInfo1.RowCount - 1).Cells("colNumberOfCopies").Value = dtRow("NumberOfCopies").ToString()
            DataGridViewInfo1.Rows(DataGridViewInfo1.RowCount - 1).Cells("colCopiesAvailable").Value = dtRow("CopiesAvailable").ToString()
        Next

        DataGridViewInfo1.ClearSelection()
    End Sub

    Private Sub ClearTextBoxes()
        txtBookNumber.Clear()
        txtBookReturn.Clear()
        txtStudNumber.Clear()
        txtPayment.Clear()
        txtAmountCharge.Clear()
        txtChange.Clear()

    End Sub

    Private Sub txtStudNumber_TextChanged(sender As Object, e As EventArgs) Handles txtStudNumber.TextChanged
       
        lblGuide.Text = "Hit enter after typing in student number"
        If lblGuide.Text = "" Then
            lblGuide.Text = ""
        End If

    End Sub

    Private Sub txtBookNumber_TextChanged(sender As Object, e As EventArgs) Handles txtBookNumber.TextChanged
        lblGuide.Text = "Hit enter after typing in book #"
        If lblGuide.Text = "" Then
            lblGuide.Text = ""
        End If
    End Sub

    Private Sub txtStudNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStudNumber.KeyDown
        If e.KeyData = Keys.Enter Then
            SearchStudByID(txtStudNumber.Text)
        Else
            MessageBox.Show("No records found for stud # " & txtStudNumber.Text, "Jose Rizal Institute Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub txtBookNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBookNumber.KeyDown
        If e.KeyData = Keys.Enter Then
            SearchBookByNumber(txtBookNumber.Text)
        Else
            MessageBox.Show("No records found for book # " & txtBookNumber.Text, "Jose Rizal Institute Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub SearchStudByID(ByVal id As String)
        DataGridViewInfo.ClearSelection()

        Dim dgvRow As DataGridViewRow = (From row As DataGridViewRow In DataGridViewInfo.Rows Where row.Cells("colStudentID").Value.ToString().ToUpper().Contains(id.ToUpper()) Select row).FirstOrDefault()

        If Not DataGridViewInfo Is Nothing Then
            dgvRow.Selected = True
            DataGridViewInfo.FirstDisplayedScrollingRowIndex = dgvRow.Index
            DataGridViewInfo.PerformLayout()

            lblGuide.Text = ""
            DataGridViewInfo.Enabled = True
            DataGridViewInfo.BackgroundColor = Color.White
            txtBookNumber.Enabled = True
            txtBookNumber.Focus()
        End If
    End Sub

    Private Sub SearchBookByNumber(ByVal num As String)
        DataGridViewInfo1.ClearSelection()

        Dim dgvRow As DataGridViewRow = (From row As DataGridViewRow In DataGridViewInfo1.Rows Where row.Cells("colBookID").Value.ToString().ToUpper().Contains(num.ToUpper()) Select row).FirstOrDefault()

        If Not DataGridViewInfo1 Is Nothing Then
            dgvRow.Selected = True
            DataGridViewInfo1.FirstDisplayedScrollingRowIndex = dgvRow.Index
            DataGridViewInfo1.PerformLayout()

            lblGuide.Text = ""
            txtBookReturn.Enabled = True

            txtBookReturn.Text = DataGridViewInfo1.SelectedRows(0).Cells("colBookTitle").Value.ToString()
            txtBorrowDate.Text = DataGridViewInfo.SelectedRows(0).Cells("colDateOfBorrowed").Value.ToString()
        End If
        ComputePenalty()
    End Sub

    Private Sub ComputePenalty()
        dateBorrow = txtBorrowDate.Text.ToString
        dateReturn = txtReturnDate.Text.ToString
        difference = dateReturn.Subtract(dateBorrow)

        valueHolder = FormatNumber(difference.Days, 0)
        'compute for charges or penalty kapag lumagpas ng due date of returning book
        penalty = (valueHolder - 5) * 30

        If penalty <= 0 Then
            penalty = 0.0
            txtAmountCharge.Text = penalty.ToString("0.00")
            GroupBox2.Enabled = False
        ElseIf penalty > 0 Then
            txtAmountCharge.Text = penalty.ToString("0.00")
        End If

        txtAmountCharge.Text = penalty.ToString
        dateChecker = penalty
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DataGridViewInfo.BackgroundColor = Color.Gray
        DataGridViewInfo1.BackgroundColor = Color.Gray
        ClearTextBoxes()

        txtBookNumber.Enabled = False
        txtBookReturn.Enabled = False
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Try
            ReturnBook()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReturnBook()
        Dim dr As DialogResult

        If dateChecker > 2 Then

            dr = MessageBox.Show("Return book?", "Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dr = Windows.Forms.DialogResult.Yes Then
                query = String.Empty
                query = " UPDATE tblStudent SET DateOfReturn = '" & txtReturnDate.Value & "',Penalty = '" & txtAmountCharge.Text & "', Payment = '" & txtPayment.Text & "',Change = '" & txtChange.Text & "'  WHERE StudentID = " & Integer.Parse(txtStudNumber.Text)
                DatabaseFunctions.ExecuteQuery(query)
                MessageBox.Show("Book return successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            query = " UPDATE tblStudent SET DateOfReturn = '" & txtReturnDate.Value & "', Penalty = '" & txtAmountCharge.Text & "' WHERE StudentID = " & Integer.Parse(txtStudNumber.Text)
            DatabaseFunctions.ExecuteQuery(query)
            MessageBox.Show("Book return successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If txtAmountCharge.Text > 0 Then
            ComputeChange()
        End If

        Reload()

    End Sub

    Private Sub ComputeChange()
        Dim amtPay As Double
        Dim change As Double
        amtPay = Convert.ToDouble(txtPayment.Text)

        'compute for change
        change = amtPay - txtAmountCharge.Text.ToString
        txtChange.Text = change.ToString
    End Sub

End Class