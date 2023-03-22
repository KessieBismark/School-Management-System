Imports MySql.Data.MySqlClient
Public Class edditallocation
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        If txtallo.Text = "" Then
            showerror("Please do not leave any field empty!")
            Exit Sub
        Else
            execute("update subject_allocation set Allocation = '" + txtallo.Text + "' where Staff_ID='" + txtalloid.Text + "' and sid ='" & sid & "'", 1)
            Clear(Me)
            txtallo.Text = ""
        End If
    End Sub

    Private Sub edditallocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
    End Sub
End Class