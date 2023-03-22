Imports System.IO
Public Class dbconfig
    Private Sub dbconfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
        Try
            Using client = New System.Net.WebClient()
                Using stream = client.OpenRead("http://google.com")
                    result.ForeColor = Color.Green
                    result.Text = "Connected to the internet."
                End Using
            End Using
        Catch ex As Exception
            result.ForeColor = Color.Red
            result.Text = "No internet connection."
        End Try
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub
    Private Sub save_Click_1(sender As Object, e As EventArgs) Handles save.Click
        Try
            My.Computer.FileSystem.DeleteFile("OnlineDB.txt")
        Catch ex As Exception
        End Try
        If sname.Text = "" Or uname.Text = "" Or dbname.Text = "" Then
            showerror("Please fill in the empty spaces!")
            Exit Sub
        Else
            Try
                Dim file As System.IO.StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter("OnlineDB.txt", True)
                file.WriteLine(Encript(sname.Text))
                file.WriteLine(Encript(dbname.Text))
                file.WriteLine(Encript(uname.Text))
                If pword.Text = "" Then
                    file.WriteLine(pword.Text)
                Else
                    file.WriteLine(Encript(pword.Text))
                End If
                file.Close()
                Clear(Me)
                showinfo("File has been created and information has been saved. Please re-open the apllication.")
                End
            Catch ex As Exception
                showerror(ex.Message)
            End Try
        End If
    End Sub
    Private Sub read_Click_1(sender As Object, e As EventArgs) Handles read.Click
        Try
            Dim file As System.IO.StreamReader
            file = My.Computer.FileSystem.OpenTextFileReader("OnlineDB.txt")
            sname.Text = file.ReadLine
            dbname.Text = file.ReadLine
            uname.Text = file.ReadLine
            pword.Text = file.ReadLine
            file.Close()
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
    Private Sub RadButton2_Click_1(sender As Object, e As EventArgs) Handles RadButton2.Click
        Me.Cursor = Cursors.WaitCursor
        check()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub RadButton1_Click_1(sender As Object, e As EventArgs) Handles RadButton1.Click
        Try
            setup()
            Me.Cursor = Cursors.WaitCursor
            con = New MySql.Data.MySqlClient.MySqlConnection(cs)
            con.Open()
            showinfo("Database was connected successfully")
            con.Close()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            showerror(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
End Class