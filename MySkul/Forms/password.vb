Public Class password

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clear(Me)
        Timer1.Start()
    End Sub
    Private Function cf3()
        Dim loc As Integer
        With Screen.PrimaryScreen.WorkingArea
            Me.Left = (.Width - Me.Width) / 2
            loc = Me.Left
            Return loc
        End With
    End Function


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        login.Left += 10
        If (login.Left >= (200 + cf3())) Then
            Timer1.Stop()
            Me.TopMost = False
            login.TopMost = True
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        login.Left -= 10
        If (login.Left <= cf3()) Then
            Timer2.Stop()
        End If
    End Sub

    Private Sub password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        login.Show()
        txtq.ReadOnly = True
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles txtuname.Click
        txtuname.Clear()
        PictureBox5.Visible = True
        PictureBox1.Visible = False
        PictureBox3.Visible = True
        PictureBox6.Visible = False
        txta.ForeColor = Color.WhiteSmoke
        Panel4.BackColor = Color.WhiteSmoke
        txtuname.ForeColor = Color.FromArgb(78, 184, 207)
        Panel2.BackColor = Color.FromArgb(78, 184, 207)
    End Sub

    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles txtq.Click
        txtq.Clear()

    End Sub

    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles txta.Click
        txta.Clear()
        txta.PasswordChar = "*"
        PictureBox6.Visible = True
        PictureBox3.Visible = False
        PictureBox1.Visible = True
        PictureBox5.Visible = False
        txtuname.ForeColor = Color.WhiteSmoke
        Panel2.BackColor = Color.WhiteSmoke
        txta.ForeColor = Color.FromArgb(78, 184, 207)
        Panel4.BackColor = Color.FromArgb(78, 184, 207)
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles txtp.Click
        txtp.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtuname.Text = "" And Button2.Text = "CHECK" Then
            showerror("Please enter your username!")
            Exit Sub
        ElseIf Button2.Text = "CHECK" Then
            txtq.Text = getValue("select question from users where sid = '" & sid & "' and Username = '" + txtuname.Text + "'")
            Button3.Visible = True
            Button2.Visible = False
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pword As String
        pword = getValue("select password from users where sid = '" & sid & "' and Username = '" + txtuname.Text + "' and answer='" & txta.Text & "'")
        If Not pword = "" Then
            txtp.Text = Decrypt(pword)
            Button3.Visible = False
            Button2.Visible = True
        ElseIf txta.Text = "ANSWER" Then
            Me.TopMost = False
            showerror("Enter the answer to the question in the answer textbox")
        Else
            Me.TopMost = False
            showerror("Wrong answer entry. No record was found!")
        End If
    End Sub
End Class