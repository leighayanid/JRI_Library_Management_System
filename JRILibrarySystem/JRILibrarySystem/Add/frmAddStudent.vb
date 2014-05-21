Public Class frmModifyStuden
    Dim query = String.Empty
    Dim _studentDataTable As DataTable


    Private Sub frmAddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub Reload()
        LoadDatabase()
        txtStudentID.Text = (Integer.Parse(GenerateAutoID()) + 1).ToString
        FillListID()
        Clear()
    End Sub

    Private Function GenerateAutoID()
        Return Me._studentDataTable.Rows(Me._studentDataTable.Rows.Count - 1)("StudentID").ToString
    End Function

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
        Save()
    End Sub

    Private Sub Save()
        Dim query = String.Empty
        query = " INSERT INTO tblStudent(FName,LName,MName,Gender,Address,Year_,Section,ContactNumber)"
        query &= " VALUES ('" & txtStudFName.Text & "','" & txtStudLName.Text & "','" & txtMiddleName.Text & "', '" & cmbGender.Text & "','" & txtAddress.Text & "','" & cmbYear.Text & "', '" & txtSection.Text & "','" & txtContact.Text & "')"
        DatabaseFunctions.ExecuteQuery(query)
        MessageBox.Show("Record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Clear()
        Reload()
    End Sub

End Class