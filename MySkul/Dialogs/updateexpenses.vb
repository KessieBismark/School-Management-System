
Public Class updateexpenses
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        If txterecord.Text = "" Or txteid.Text = "" Then
            showerror("Please do not leave any field empty!")
            Exit Sub
        Else
            txterecord.Text = txterecord.Text & ","
            execute("UPDATE `expenses` SET `Record`='" + txterecord.Text + "' WHERE Expenses_ID = '" + txteid.Text + "' and sid = '" & sid & "'", 1)
            txterecord.Text = ""
            txteid.Text = ""
        End If
    End Sub

    Private Sub updateexpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
        If Not txteid.Text = "" And txterecord.Text = "" Then
            txterecord.Text = getValue("select Record from expenses where Expenses_ID = '" + txteid.Text + "' and sid='" & sid & "'")
        End If
    End Sub
End Class