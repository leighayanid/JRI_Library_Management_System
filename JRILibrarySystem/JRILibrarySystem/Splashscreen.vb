Public Class Splashscreen

    Private Sub Splashscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            ProgressBar1.Value += 20
            If ProgressBar1.Value = 100 Then
                Me.Hide()
                MainForm.Show()
            End If
        Catch ex As ArgumentOutOfRangeException

        End Try
       
    End Sub
End Class
