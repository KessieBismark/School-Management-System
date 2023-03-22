Public Class AdminOnly
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub AdminOnly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
        If Not ul = 0 Then
            Application.Exit()
        Else
            txtscid.DataSource = New BindingSource(ShowData("select * from school_profile"), Nothing)
            txtscid.DisplayMember = "sid"
            txtscid.Items.Add("")
        End If
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        sid = txtscid.Text
        Home.Show()
        Home.user.Text = "Developer"
        Me.Close()
    End Sub

    Private Sub txtscid_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles txtscid.SelectedIndexChanged

    End Sub
End Class