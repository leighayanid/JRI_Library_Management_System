Public Class frmModifyStudents

    Dim _studentDataTable As DataTable

    Private Sub frmAddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub Reload()
        LoadDatabase()
        FillListID()
        Clear()
    End Sub

    Private Sub LoadDatabase()
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
            DataGridViewInfo.Rows(DataGridViewInfo.RowCount - 1).Cells("colStudMName").Value = dtRow("MName").ToString()
            DataGridViewInfo.Rows(DataGridViewInfo.RowCount - 1).Cells("colStudLName").Value = dtRow("LName").ToString()
            DataGridViewInfo.Rows(DataGridViewInfo.RowCount - 1).Cells("colGender").Value = dtRow("Gender").ToString()
            DataGridViewInfo.Rows(DataGridViewInfo.RowCount - 1).Cells("colAddress").Value = dtRow("Address").ToString()
            DataGridViewInfo.Rows(DataGridViewInfo.RowCount - 1).Cells("colYear").Value = dtRow("Year_").ToString()
            DataGridViewInfo.Rows(DataGridViewInfo.RowCount - 1).Cells("colSection").Value = dtRow("Section").ToString()
            DataGridViewInfo.Rows(DataGridViewInfo.RowCount - 1).Cells("colContactNumber").Value = dtRow("ContactNumber").ToString()

        Next

        DataGridViewInfo.ClearSelection()
    End Sub

    Private Sub FillListID()
        If ListBoxStudents.DataSource Is Nothing Then
            ListBoxStudents.Items.Clear()
        End If

        ListBoxStudents.DataSource = Utilities.GetStudentID()
        ListBoxStudents.DisplayMember = "StudentID"
        ListBoxStudents.ValueMember = "StudentID"
    End Sub

    Private Sub Clear()
        txtStudFName.Clear()
        txtMiddleName.Clear()
        txtAddress.Clear()
        txtSection.Clear()
        txtStudLName.Clear()
        cmbYear.Text = ""
        txtContact.Clear()
        cmbGender.Text = ""
    End Sub

    Private Sub CloudDesktopButton1_Click(sender As Object, e As EventArgs) Handles CloudDesktopButton1.Click
        Me.Hide()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        UpdateData()
    End Sub

    Private Sub UpdateData()
        Try
            query = String.Empty
            query = "UPDATE tblStudent SET FName = '" & txtStudFName.Text & "', LName = '" & txtStudLName.Text & "', MName = '" & txtMiddleName.Text & "' , Address = '" & txtAddress.Text & "' , Gender = '" & cmbGender.Text & "' , Year_ = '" & cmbYear.Text & "', Section = '" & txtSection.Text & "', ContactNumber = '" & txtContact.Text & "' WHERE StudentID = " & Integer.Parse(txtStudentID.Text)
            DatabaseFunctions.ExecuteQuery(query)
            MessageBox.Show("Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clear()
            Reload()

        Catch ex As FormatException

        End Try

    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        Try
            SearchStudentID(txtSearch.Text)
            txtSearch.Clear()
        Catch ex As Exception
            MessageBox.Show("No record found for book " & txtSearch.Text, "Jose Rizal Institute Library System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub SearchStudentID(ByVal id As String)
        DataGridViewInfo.ClearSelection()
        ListBoxStudents.ClearSelected()

        Dim dgvRow As DataGridViewRow = (From row As DataGridViewRow In DataGridViewInfo.Rows Where row.Cells("colStudentID").Value.ToString().ToUpper().Contains(id.ToUpper()) Select row).FirstOrDefault()

        If Not DataGridViewInfo Is Nothing Then
            dgvRow.Selected = True
            DataGridViewInfo.FirstDisplayedScrollingRowIndex = dgvRow.Index
            DataGridViewInfo.PerformLayout()

        End If

        Dim index = ListBoxStudents.FindString(id)
        ListBoxStudents.SetSelected(index, True)
        ShowStudents()
        btnSave.Enabled = True
    End Sub

    Private Sub ShowStudents()

        txtStudentID.Text = DataGridViewInfo.SelectedRows(0).Cells("colStudentID").Value.ToString()
        txtStudFName.Text = DataGridViewInfo.SelectedRows(0).Cells("colStudFName").Value.ToString()
        txtStudLName.Text = DataGridViewInfo.SelectedRows(0).Cells("colStudLName").Value.ToString()
        txtMiddleName.Text = DataGridViewInfo.SelectedRows(0).Cells("colStudMName").Value.ToString()
        txtAddress.Text = DataGridViewInfo.SelectedRows(0).Cells("colAddress").Value.ToString()
        cmbGender.Text = DataGridViewInfo.SelectedRows(0).Cells("colGender").Value.ToString()
        txtContact.Text = DataGridViewInfo.SelectedRows(0).Cells("colContactNumber").Value.ToString()
        cmbYear.Text = DataGridViewInfo.SelectedRows(0).Cells("colYear").Value.ToString()
        txtSection.Text = DataGridViewInfo.SelectedRows(0).Cells("colSection").Value.ToString()

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

            Dim studID = Integer.Parse(DataGridViewInfo.SelectedRows(0).Cells("colStudentID").Value.ToString())
            Dim query = "DELETE FROM tblStudent WHERE StudentID = " & studID

            DatabaseFunctions.ExecuteQuery(query)
            MessageBox.Show("Data Deleted Successfully.", "Jose Rizal Institute Library System", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
        Reload()
    End Sub

End Class