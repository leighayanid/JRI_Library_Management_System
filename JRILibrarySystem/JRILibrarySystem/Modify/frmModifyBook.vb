Public Class frmModifyBook

    Dim _bookDataTable As DataTable

    Private Sub frmAddBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub Reload()
        LoadDatabase()
        FillBookList()
        Clear()
    End Sub

    Private Sub LoadDatabase()
        query = "SELECT * FROM tblBook"
        Me._bookDataTable = DatabaseFunctions.GetDataTable(query)

        'kapag zero ung count return lang 
        If Me._bookDataTable.Rows.Count = 0 Then
            Return
        End If

        DataGridViewInfo.Rows.Clear()

        For Each dtRow In Me._bookDataTable.Rows
            DataGridViewInfo.Rows.Add()
            DataGridViewInfo.Rows(DataGridViewInfo.RowCount - 1).Cells("colBookNumber").Value = dtRow("BookNumber").ToString()
            DataGridViewInfo.Rows(DataGridViewInfo.RowCount - 1).Cells("colBookTitle").Value = dtRow("BookTitle").ToString()
            DataGridViewInfo.Rows(DataGridViewInfo.RowCount - 1).Cells("colAuthor").Value = dtRow("Author").ToString()
            DataGridViewInfo.Rows(DataGridViewInfo.RowCount - 1).Cells("colManufacturer").Value = dtRow("Manufacturer").ToString()
            DataGridViewInfo.Rows(DataGridViewInfo.RowCount - 1).Cells("colCopyright").Value = dtRow("Copyright").ToString()
            DataGridViewInfo.Rows(DataGridViewInfo.RowCount - 1).Cells("colNumberOfCopies").Value = dtRow("Copies").ToString()
            DataGridViewInfo.Rows(DataGridViewInfo.RowCount - 1).Cells("colCopiesAvailable").Value = dtRow("CopiesAvailable").ToString()

        Next

        DataGridViewInfo.ClearSelection()
    End Sub

    Private Sub Clear()
        txtAuthor.Clear()
        txtBookTitle.Clear()
        txtCopyright.Clear()
        txtManufacturer.Clear()
        txtNumberOfCopies.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        UpdateDatabase()
    End Sub

    Private Sub UpdateDatabase()
        Try
            query = String.Empty
            query = " UPDATE tblBook SET BookTitle = '" & txtBookTitle.Text & "', Author = '" & txtAuthor.Text & "' ,  Copyright= '" & txtCopyright.Text & "', Manufacturer = '" & txtManufacturer.Text & "', Copies = '" & txtNumberOfCopies.Text & "',CopiesAvailable = '" & txtNumberOfCopies.Text & "' WHERE BookNumber = " & Integer.Parse(txtBookNumber.Text)
            DatabaseFunctions.ExecuteQuery(query)
            MessageBox.Show("Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clear()
            Reload()
        Catch ex As FormatException

        End Try
       
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
    End Sub

    Private Sub FillBookList()
        If ListBoxBooks.DataSource Is Nothing Then
            ListBoxBooks.Items.Clear()
        End If

        ListBoxBooks.DataSource = Utilities.GetBookTitle()
        ListBoxBooks.DisplayMember = "BookTitle"
        ListBoxBooks.ValueMember = "BookTitle"
    End Sub

    Private Sub CloudDesktopButton1_Click(sender As Object, e As EventArgs) Handles CloudDesktopButton1.Click
        Me.Hide()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteData()
    End Sub

    Private Sub DeleteData()
        Dim dr As DialogResult
        If DataGridViewInfo.SelectedRows.Count = 0 Then
            MessageBox.Show("You must select record from grid to delete.", "Jose Rizal Institute Library System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        dr = MessageBox.Show("Do you really want to delete the record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dr = Windows.Forms.DialogResult.Yes Then

            Dim bookNumber = Integer.Parse(DataGridViewInfo.SelectedRows(0).Cells("colBookNumber").Value.ToString())
            Dim query = "DELETE FROM tblBook WHERE BookNumber = " & bookNumber

            DatabaseFunctions.ExecuteQuery(query)
            MessageBox.Show("Data Deleted Successfully.", "Jose Rizal Institute Library System", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        Reload()

    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        Try
            If e.KeyData = Keys.Enter Then
                SearchBookByTitle(txtSearch.Text)
                txtSearch.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("No records found for " & txtSearch.Text, "Jose Rizal Institute Library System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub SearchBookByTitle(ByVal bookNum As String)
        DataGridViewInfo.ClearSelection()
        ListBoxBooks.ClearSelected()

        Dim dgvRow As DataGridViewRow = (From row As DataGridViewRow In DataGridViewInfo.Rows Where row.Cells("colBookTitle").Value.ToString().ToUpper().Contains(bookNum.ToUpper()) Select row).FirstOrDefault()

        If Not DataGridViewInfo Is Nothing Then
            dgvRow.Selected = True
            DataGridViewInfo.FirstDisplayedScrollingRowIndex = dgvRow.Index
            DataGridViewInfo.PerformLayout()

        End If

        Dim index = ListBoxBooks.FindString(bookNum)
        ListBoxBooks.SetSelected(index, True)
        ShowStudent()
    End Sub

    Private Sub ShowStudent()

        txtBookNumber.Text = DataGridViewInfo.SelectedRows(0).Cells("colBookNumber").Value.ToString()
        txtBookTitle.Text = DataGridViewInfo.SelectedRows(0).Cells("colBookTitle").Value.ToString()
        txtAuthor.Text = DataGridViewInfo.SelectedRows(0).Cells("colAuthor").Value.ToString()
        txtCopyright.Text = DataGridViewInfo.SelectedRows(0).Cells("colCopyright").Value.ToString()
        txtManufacturer.Text = DataGridViewInfo.SelectedRows(0).Cells("colManufacturer").Value.ToString()
        txtNumberOfCopies.Text = DataGridViewInfo.SelectedRows(0).Cells("colNumberOfCopies").Value.ToString()

    End Sub

End Class