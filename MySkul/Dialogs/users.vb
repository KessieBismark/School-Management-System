Public Class users
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub cdelete_Click(sender As Object, e As EventArgs) Handles cdelete.Click
        Me.Close()
    End Sub

    Private Sub users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
        txtname.DataSource = New BindingSource(ShowData("select * from staff where sid='" & sid & "'"), Nothing)
        txtname.DisplayMember = "fullname"
        txtname.Items.Add("")
        txtpword.Enabled = False
        txtcpword.Enabled = False
        txtfl.Enabled = False
        cadd.Enabled = False
    End Sub

    Private Sub txtname_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles txtname.SelectedIndexChanged
        txtstaffid.Text = getValue("select staff_id from staff where fullname='" & txtname.Text & "' and sid = '" & sid & "'")
        If Not txtstaffid.Text = "" Then
            txtpword.Enabled = True
            txtcpword.Enabled = True
            txtfl.Enabled = True
            cadd.Enabled = True
        End If
    End Sub

    Private Sub cclear_Click(sender As Object, e As EventArgs) Handles cclear.Click
        Clear(Me)
    End Sub

    Private Sub cadd_Click(sender As Object, e As EventArgs) Handles cadd.Click
        If txtpword.Text = "" Or txtcpword.Text = "" Or txtfl.Text = "" Or txtuname.Text = "" Then
            showerror("Please do not leave any field empty!")
            Exit Sub
        ElseIf Not txtcpword.Text = txtpword.Text Then
            showerror("Password provided do not match!")
            Exit Sub
        Else
            Dim role As Integer
            If txtfl.Text = "Administrator" Or txtfl.Text = "Head Mastor/Mistress" Then
                role = 1
            ElseIf txtfl.Text = "Head of Academics" Then
                role = 2
            ElseIf txtfl.Text = "Assistant Academics" Then
                role = 3
            ElseIf txtfl.Text = "Head of Finance" Then
                role = 4
            ElseIf txtfl.Text = "Teacher" Then
                role = 6
            End If
            Try
                execute("INSERT INTO `users`(`Staff_ID`,Name, `Username`, `password`, `pass`, `sid`) VALUES ('" + txtstaffid.Text + "','" + txtname.Text + "','" + txtuname.Text + "','" & (Encript(txtpword.Text)) & "','" & role & "','" & sid & "')", 0)
            Catch ex As Exception
                    showerror(ex.Message)
                End Try
            End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim vu As New view_users
        vu.ShowDialog()
    End Sub
End Class