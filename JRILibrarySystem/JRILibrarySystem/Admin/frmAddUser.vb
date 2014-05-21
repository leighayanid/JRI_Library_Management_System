Public Class frmAddUser
    Dim query = String.Empty
    Dim _adminDataTable As DataTable

    Private Sub btnAddAdmin_Click(sender As Object, e As EventArgs) Handles btnAddAdmin.Click
        CheckInput()
        AddAdmin()
    End Sub

    Private Sub AddAdmin()
        Dim query = String.Empty
        query = " INSERT INTO tblUser(UserName,Password)"
        query &= " VALUES ('" & txtAdminUser.Text & "','" & txtReenterPassword.Text & "')"
        DatabaseFunctions.ExecuteQuery(query)
        MessageBox.Show("New admin user added in the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub CheckInput()
       
    End Sub

    Private Sub txtReenterPassword_TextChanged(sender As Object, e As EventArgs) Handles txtReenterPassword.TextChanged
        If txtReenterPassword.Text.Equals(txtPassword.Text) Then
            lblPassword.Text = "Password match!"
            btnAddAdmin.Enabled = True
        Else
            lblPassword.Text = "Password did not match"
        End If
    End Sub
End Class