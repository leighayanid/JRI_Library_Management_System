Public Class frmAddBook

    Dim _bookDataTable As DataTable

    Private Sub frmAddBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub Reload()
        LoadDatabase()
        txtBookNumber.Text = (Integer.Parse(GenerateAutoID()) + 1).ToString
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

    Private Function GenerateAutoID()
        Return Me._bookDataTable.Rows(Me._bookDataTable.Rows.Count - 1)("BookNumber").ToString
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Save()
    End Sub

    Private Sub Save()
        Dim query = String.Empty
        query = " INSERT INTO tblBook(BookTitle,Author,Manufacturer,Copyright,Copies,CopiesAvailable)"
        query &= " VALUES ('" & txtBookTitle.Text & "','" & txtAuthor.Text & "','" & txtManufacturer.Text & "', '" & txtCopyright.Text & "','" & txtNumberOfCopies.Text & "','" & txtNumberOfCopies.Text & "')"
        DatabaseFunctions.ExecuteQuery(query)
        MessageBox.Show("Record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Clear()
        Reload()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
    End Sub
End Class