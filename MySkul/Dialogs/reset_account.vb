Public Class reset_account
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub cclear_Click(sender As Object, e As EventArgs) Handles cclear.Click
        Clear(Me)
    End Sub

    Private Sub cdelete_Click(sender As Object, e As EventArgs) Handles cdelete.Click
        Me.Close()
    End Sub

    Private Sub cadd_Click(sender As Object, e As EventArgs) Handles cadd.Click
        If txtnp.Text = "" Or txtrp.Text = "" Or txtsq.Text = "" Or txta.Text = "" Then
            showerror("Please do not leave any field empty!")
            Exit Sub
        ElseIf Not txtrp.Text = txtnp.Text Then
            showerror("Password provided do not match!")
            Exit Sub
        Else
            Try
                execute("update users set password = '" & (Encript(txtnp.Text)) & "',question='" + txtsq.Text + "',answer='" & (Encript(txta.Text)) & "',reset='1' where Staff_ID='" + txtstaffid.Text + "' and sid='" & sid & "'", 1)
                Me.Close()
            Catch ex As Exception
                showerror(ex.Message)
            End Try
        End If
    End Sub

    Private Sub reset_account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
        txtstaffid.Text = staffid
    End Sub
End Class