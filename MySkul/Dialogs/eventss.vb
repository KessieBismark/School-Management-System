Public Class eventss
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub eventss_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
    End Sub
End Class