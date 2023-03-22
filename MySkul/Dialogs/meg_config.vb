Public Class meg_config
    Private Sub cadd_Click(sender As Object, e As EventArgs) Handles cadd.Click
        If txtapi.Text = "" Or txturl.Text = "" Or txtmh.Text = "" Then
            showerror("Please provide the needed information")
        Else
            execute("delete from message_config where sid='" & sid & "'", 3)
            execute("INSERT INTO `message_config`(`sid`, `api_key`, `message_url`, `sender`) VALUES ('" & sid & "','" + txtapi.Text + "','" + txturl.Text + "','" + txtmh.Text + "')", 0)
        End If
    End Sub

    Private Sub cclear_Click(sender As Object, e As EventArgs) Handles cclear.Click
        Clear(Me)
    End Sub

    Private Sub cdelete_Click(sender As Object, e As EventArgs) Handles cdelete.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub meg_config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
        Label3.Text = ""
    End Sub
End Class