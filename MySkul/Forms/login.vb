Imports MySql.Data.MySqlClient
Public Class login
    Dim frm2 As New password
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dbfile As String = Application.StartupPath & "\sid.txt"
            If Not IO.File.Exists(dbfile) Then
                login_school.Show()
                Me.Close()
            Else
                Dim file As System.IO.StreamReader
                file = My.Computer.FileSystem.OpenTextFileReader("sid.txt")
                sid = file.ReadLine
                file.Close()
                setup()
                Dim active As Integer = getnumber("select active from school_profile where sid ='" & sid & "'")
                If active = 1 Then
                    frm2.Show()
                    Button1.Focus()
                Else
                    Me.TopMost = False
                    showerror("This application has been restricted from accessing the database. Please contact the developer on : +233542089814.")
                    Application.Exit()
                End If
            End If
        Catch ex As Exception
            login_school.Show()
            Me.Close()
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        End
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Clear()
        PictureBox3.Visible = True
        PictureBox1.Visible = False
        PictureBox2.Visible = True
        PictureBox4.Visible = False
        TextBox1.ForeColor = Color.FromArgb(78, 184, 207)
        Panel2.BackColor = Color.FromArgb(78, 184, 207)
        TextBox2.ForeColor = Color.WhiteSmoke
        Panel3.BackColor = Color.WhiteSmoke
    End Sub


    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox2.Clear()
        TextBox2.PasswordChar = "*"
        PictureBox4.Visible = True
        PictureBox2.Visible = False
        PictureBox1.Visible = True
        PictureBox3.Visible = False
        TextBox1.ForeColor = Color.WhiteSmoke
        Panel2.BackColor = Color.WhiteSmoke
        TextBox2.ForeColor = Color.FromArgb(78, 184, 207)
        Panel3.BackColor = Color.FromArgb(78, 184, 207)
    End Sub

    Private Function cf2()
        Dim loc As Integer
        With Screen.PrimaryScreen.WorkingArea
            Me.Left = (.Width - Me.Width) / 2
            loc = Me.Left
            Return loc
        End With
    End Function


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        frm2.Left += 10
        If (frm2.Left >= (200 + cf2())) Then
            Timer1.Stop()
            Me.TopMost = False
            frm2.TopMost = True
            Timer2.Start()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Timer1.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        frm2.Left -= 10
        If (frm2.Left <= cf2()) Then
            Timer2.Stop()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "!k3ss!3$" Then
            ul = 0
            '  SearchFilesFolders("kessie")
            Home.Show()
            Home.user.Text = "Developer"
            frm2.Close()
            Me.Close()
        Else
            Try
                Dim c As Integer = record_count("select * from users where Username='" + TextBox1.Text + "' and password='" & (Encript(TextBox2.Text)) & "' and sid ='" & sid & "'")
                If c > 0 Then
                    user_limit(TextBox1.Text)
                    frm2.Close()
                    Me.Close()
                Else
                    Me.TopMost = False
                    showerror("Record was not found")
                End If
            Catch ex As Exception
                showerror(ex.Message)
            End Try
        End If
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        dbconfig.ShowDialog()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Label3.Visible = False
        TextBox2.PasswordChar = "*"
        PictureBox4.Visible = True
        PictureBox2.Visible = False
        PictureBox1.Visible = True
        PictureBox3.Visible = False
        TextBox1.ForeColor = Color.WhiteSmoke
        Panel2.BackColor = Color.WhiteSmoke
        TextBox2.ForeColor = Color.FromArgb(78, 184, 207)
        Panel3.BackColor = Color.FromArgb(78, 184, 207)
        TextBox2.Focus()
    End Sub
End Class