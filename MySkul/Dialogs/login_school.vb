Public Class login_school
    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
        Clear(Me)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        school_registration.Show()
        Me.Close()
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        If Not sid.Text = "" Or Not pword.Text = "" Then
            If sid.Text = "admin" And pword.Text = "!k3ss!3$" Then
                AdminOnly.Show()
                Me.Close()
            Else
                Dim c As Integer = record_count("select * from school_profile where sid= '" & sid.Text & "' and password = '" & (Encript(pword.Text)) & "'")
                If c > 0 Then
                    Try
                        My.Computer.FileSystem.DeleteFile("sid.txt")
                    Catch ex As Exception
                    End Try
                    Try
                        Dim file As System.IO.StreamWriter
                        file = My.Computer.FileSystem.OpenTextFileWriter("sid.txt", True)
                        file.WriteLine(sid.Text)
                        file.Close()
                        Dim fileDetail As IO.FileInfo = My.Computer.FileSystem.GetFileInfo("sid.txt")
                        fileDetail.IsReadOnly = True
                        fileDetail.Attributes = fileDetail.Attributes Or IO.FileAttributes.Hidden
                        Clear(Me)
                        showinfo("File has been created and information has been saved. please re-open the apllication.")
                        Application.Exit()
                    Catch ex As Exception
                        showerror(ex.Message)
                    End Try
                Else
                    showerror("Credentials was not found!")
                End If
            End If
        Else
                showerror("Please sign in with your School ID and Password or click on Sign Up to register your school. ")
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub login_school_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
        setup()
    End Sub
End Class