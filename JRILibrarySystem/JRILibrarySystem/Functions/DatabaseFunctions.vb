Imports System.Data.Odbc
Imports System

Public Class DatabaseFunctions

    Shared connection As OdbcConnection

    Public Shared Sub CreateConnection()
        connection = New OdbcConnection
        connection.ConnectionString = "Dsn=JRILibrarySystem"
        connection.Open()
    End Sub

    Private Shared Sub CheckedConnection()
        If connection Is Nothing OrElse connection.State = ConnectionState.Closed Then
            CreateConnection()
        End If
    End Sub

    Public Shared Function GetDataReader(ByVal SQL As String) As OdbcDataReader
        CheckedConnection()
        Dim cmd As New OdbcCommand(SQL, connection)
        Dim dr As OdbcDataReader
        dr = cmd.ExecuteReader
        Return dr
    End Function

    Public Shared Function GetDataTable(ByVal SQL As String) As DataTable
        CheckedConnection()
        Dim cmd As New OdbcCommand(SQL, connection)
        Dim table As New DataTable
        Dim da As New OdbcDataAdapter(cmd)
        da.Fill(table)
        Return table
    End Function

    Public Shared Sub ExecuteQuery(ByVal SQL As String)
        CheckedConnection()
        Dim cmd As New OdbcCommand(SQL, connection)
        cmd.ExecuteNonQuery()
    End Sub

End Class
