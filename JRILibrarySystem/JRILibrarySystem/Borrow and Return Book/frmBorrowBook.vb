Public Class frmBorrowBook

    Dim _studentDataTable As DataTable
    Dim _bookDataTable As DataTable

    Private Sub frmBorrowBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub Reload()
        LoadDBStudent()
        LoadDBBook()

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

        Next

        DataGridViewInfo.ClearSelection()
    End Sub

    Private Sub LoadDBBook()
        query = "SELECT * FROM tblBook"
        Me._bookDataTable = DatabaseFunctions.GetDataTable(query)

        'kapag zero ung count return lang 
        If Me._bookDataTable.Rows.Count = 0 Then
            Return
        End If

        DataGridViewInfo1.Rows.Clear()

        For Each dtRow In Me._bookDataTable.Rows
            DataGridViewInfo1.Rows.Add()
            DataGridViewInfo1.Rows(DataGridViewInfo1.RowCount - 1).Cells("colBookNumber").Value = dtRow("BookNumber").ToString()
            DataGridViewInfo1.Rows(DataGridViewInfo1.RowCount - 1).Cells("colBookTitle").Value = dtRow("BookTitle").ToString()
            DataGridViewInfo1.Rows(DataGridViewInfo1.RowCount - 1).Cells("colNumberOfCopies").Value = dtRow("Copies").ToString()
            DataGridViewInfo1.Rows(DataGridViewInfo1.RowCount - 1).Cells("colCopiesAvailable").Value = dtRow("CopiesAvailable").ToString()

        Next

        DataGridViewInfo1.ClearSelection()
    End Sub

    Private Sub txtStudNumber_TextChanged(sender As Object, e As EventArgs) Handles txtStudNumber.TextChanged
        lblGuide.Text = "Hit enter after typing in student number"
        If txtStudNumber.Text = "" Then
            lblGuide.Text = ""
        End If
    End Sub

    Private Sub txtStudNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStudNumber.KeyDown
        Try
            If e.KeyData = Keys.Enter Then
                SearchByID(txtStudNumber.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("No records found for student number " & txtStudNumber.Text,"Jose Rizal Institure Library System",MessageBoxButtons.OK,MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub txtBookNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBookNumber.KeyDown
        Try
            If e.KeyData = Keys.Enter Then
                SearchByBookID(txtBookNumber.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("No records found for book number " & txtBookNumber.Text, "Jose Rizal Institure Library System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub SearchByID(ByVal id As String)
        DataGridViewInfo.ClearSelection()

        Dim dgvRow As DataGridViewRow = (From row As DataGridViewRow In DataGridViewInfo.Rows Where row.Cells("colStudentID").Value.ToString().ToUpper().Contains(id.ToUpper()) Select row).FirstOrDefault()

        If Not DataGridViewInfo Is Nothing Then
            dgvRow.Selected = True
            DataGridViewInfo.FirstDisplayedScrollingRowIndex = dgvRow.Index
            DataGridViewInfo.PerformLayout()

            txtBorrowDate.Enabled = True
            lblGuide.Text = ""
            DataGridViewInfo.Enabled = True
            DataGridViewInfo.BackgroundColor = Color.White
            txtBookNumber.Enabled = True
            txtBookNumber.Focus()
        End If

    End Sub

    Private Sub SearchByBookID(ByVal num As String)
        DataGridViewInfo1.ClearSelection()

        Dim dgvRow As DataGridViewRow = (From row As DataGridViewRow In DataGridViewInfo1.Rows Where row.Cells("colBookNumber").Value.ToString().ToUpper().Contains(num.ToUpper()) Select row).FirstOrDefault()

        If Not DataGridViewInfo1 Is Nothing Then
            dgvRow.Selected = True
            DataGridViewInfo1.FirstDisplayedScrollingRowIndex = dgvRow.Index
            DataGridViewInfo1.PerformLayout()

            lblGuide.Text = ""
            txtBookBorrow.Enabled = True
            DataGridViewInfo1.BackgroundColor = Color.White

            txtBookBorrow.Text = DataGridViewInfo1.SelectedRows(0).Cells("colBookTitle").Value.ToString()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        DataGridViewInfo.Enabled = False
        DataGridViewInfo1.Enabled = False
        DataGridViewInfo.BackgroundColor = Color.Gray
        DataGridViewInfo1.BackgroundColor = Color.Gray
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Dim query = String.Empty
        query = " UPDATE tblStudent SET BorrowBook = '" & txtBookBorrow.Text & "', DateOfBorrow = '" & txtBorrowDate.Value & "'  WHERE StudentID = " & Integer.Parse(txtStudNumber.Text)
        DatabaseFunctions.ExecuteQuery(query)
        MessageBox.Show("Book has been borrowed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim query1 = String.Empty
        query1 = " UPDATE tblBook SET CopiesAvailable = '" & Integer.Parse(DataGridViewInfo1.SelectedRows(0).Cells("colCopiesAvailable").Value - 1).ToString() & "' WHERE BookNumber = " & Integer.Parse(txtBookNumber.Text)
        DatabaseFunctions.ExecuteQuery(query1)

        Clear()
        Reload()
    End Sub

    Private Sub Clear()
        txtBookBorrow.Clear()
        txtBookNumber.Clear()
        txtStudNumber.Clear()
    End Sub

End Class