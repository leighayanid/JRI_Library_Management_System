Public Class Utilities

    Public Shared Function GetStudentID()

        Dim query As String = "SELECT StudentID FROM tblStudent ORDER BY StudentID"
        Dim studentDataTable As DataTable = DatabaseFunctions.GetDataTable(query)

        If studentDataTable.Rows.Count = 0 Then
            Return Nothing
        End If

        Return studentDataTable

    End Function

    Public Shared Function GetBookTitle()

        Dim query As String = "SELECT BookNumber, BookTitle FROM tblBook ORDER BY BookNumber"
        Dim bookDataTable As DataTable = DatabaseFunctions.GetDataTable(query)

        If bookDataTable.Rows.Count = 0 Then
            Return Nothing
        End If

        Return bookDataTable

    End Function

End Class
