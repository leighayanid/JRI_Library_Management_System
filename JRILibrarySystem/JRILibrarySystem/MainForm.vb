Imports System.Data.OleDb
Imports System.Object

Public Class MainForm
    Dim connection As New System.Data.OleDb.OleDbConnection
    Dim strConnectionString As String

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectToDataBase()
    End Sub

    Private Sub ConnectToDataBase()
        strConnectionString = "PROVIDER = Microsoft.Jet.Oledb.4.0;Data Source = JRILibrarySystem.mdb"
        connection.ConnectionString = strConnectionString
        connection.Open()
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub StudentRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentRecordToolStripMenuItem.Click
        Try
            frmModifyStuden.MdiParent = Me
            frmModifyStuden.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BookRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookRecordToolStripMenuItem.Click
        Try
            frmAddBook.MdiParent = Me
            frmAddBook.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub StudentRecordToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StudentRecordToolStripMenuItem1.Click
        frmModifyStudents.MdiParent = Me
        frmModifyStudents.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Login()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Login()
        Dim OleDBC As New OleDbCommand
        Dim OleDBDR As OleDbDataReader

        With OleDBC
            .Connection = connection
            .CommandText = "SELECT * FROM tblUser " & "WHERE UserName = '" & tboxAdmin.Text & "'AND " & "Password = '" & tboxPassword.Text & "'"
        End With

        OleDBDR = OleDBC.ExecuteReader()
        OleDBDR.Read()

        If OleDBDR.HasRows Then
            MenuStrip1.Enabled = True
            ToolStrip1.Enabled = True
            CloudGroup1.IsOpen = False
            CloudGroup1.HeaderText = "                  Admin " & tboxAdmin.Text
            lbMessage.Text = ""
            Clear()
            btnLogin.Enabled = False
        Else
            lbMessage.Text = "Invalid Login! Check username and password!"
            Clear()
        End If

        btnLogout.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Logout()
    End Sub

    Private Sub Logout()
        CloudGroup1.HeaderText = "                  Login Here"
        CloudGroup1.IsOpen = False
        btnLogout.Enabled = False
        btnLogin.Enabled = True
        MenuStrip1.Enabled = False
        ToolStrip1.Enabled = False
    End Sub

    Private Sub Clear()
        tboxAdmin.Clear()
        tboxPassword.Clear()
    End Sub

    Private Sub AddNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewToolStripMenuItem.Click
        Try
            frmAddUser.MdiParent = Me
            frmAddUser.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Application.Exit()
    End Sub

    Private Sub BookRecordToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BookRecordToolStripMenuItem1.Click
        frmModifyBook.MdiParent = Me
        frmModifyBook.Show()
    End Sub

    Private Sub BorrowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowToolStripMenuItem.Click
        frmBorrowBook.MdiParent = Me
        frmBorrowBook.Show()
    End Sub
End Class