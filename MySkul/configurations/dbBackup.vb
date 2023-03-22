Imports System.IO
Public Class dbBackup
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub cclear_Click(sender As Object, e As EventArgs) Handles cclear.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim file As System.IO.StreamReader
            Dim userid, password, database, server As String
            file = My.Computer.FileSystem.OpenTextFileReader("OnlineDB.txt")
            server = Decrypt(file.ReadLine)
            database = Decrypt(file.ReadLine)
            userid = Decrypt(file.ReadLine)
            password = file.ReadLine
            If password = "" Then
            Else
                password = Decrypt(password)
            End If
            file.Close()

            SaveFileDialog1.Filter = "SQL Dump File (*.sql)|*.sql|All Files (*.*)|*.*"
            SaveFileDialog1.FileName = "Database Backup " & DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") & ".sql"
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                Dim dbname As String = SaveFileDialog1.FileName
                Dim BackupProcess As New Process
                BackupProcess.StartInfo.FileName = "cmd.exe"
                BackupProcess.StartInfo.UseShellExecute = False
                Dim xamppath As String = "C:\xamp\mysql\bin\"
                If Directory.Exists(xamppath) Then
                    BackupProcess.StartInfo.WorkingDirectory = xamppath
                Else
                    BackupProcess.StartInfo.WorkingDirectory = "C:\wamp64\bin\mysql\mysql5.7.28\bin"
                End If
                BackupProcess.StartInfo.RedirectStandardInput = True
                BackupProcess.StartInfo.RedirectStandardOutput = True
                BackupProcess.Start()

                Dim BackupStream As StreamWriter = BackupProcess.StandardInput
                Dim myStreamReader As StreamReader = BackupProcess.StandardOutput
                BackupStream.WriteLine("mysqldump --user=" & userid & " --password=" & password & " -h " & server & " " & database & " > """ + dbname + """")
                BackupStream.Close()
                BackupProcess.WaitForExit()
                con.Close()
                showinfo("Database backup was successful")
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub cadd_Click(sender As Object, e As EventArgs) Handles cadd.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim file As System.IO.StreamReader
            Dim userid, password, database, server As String
            file = My.Computer.FileSystem.OpenTextFileReader("OnlineDB.txt")
            server = Decrypt(file.ReadLine)
            database = Decrypt(file.ReadLine)
            userid = Decrypt(file.ReadLine)
            password = file.ReadLine
            If password = "" Then
            Else
                password = Decrypt(password)
            End If
            file.Close()

            OpenFileDialog1.Filter = "SQL Dump File (*.sql)|*.sql|All Files (*.*)|*.*"
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                Dim dbname As String = OpenFileDialog1.FileName
                Dim BackupProcess As New Process
                BackupProcess.StartInfo.FileName = "cmd.exe"
                BackupProcess.StartInfo.UseShellExecute = False
                Dim xamppath As String = "C:\xamp\mysql\bin\"
                If Directory.Exists(xamppath) Then
                    BackupProcess.StartInfo.WorkingDirectory = xamppath
                Else
                    BackupProcess.StartInfo.WorkingDirectory = "C:\wamp64\bin\mysql\mysql5.7.28\bin"
                End If
                BackupProcess.StartInfo.RedirectStandardInput = True
                BackupProcess.StartInfo.RedirectStandardOutput = True
                BackupProcess.Start()

                Dim BackupStream As StreamWriter = BackupProcess.StandardInput
                Dim myStreamReader As StreamReader = BackupProcess.StandardOutput
                BackupStream.WriteLine("mysqldump --user=" & userid & " --password=" & password & " -h " & server & " " & database & " < """ + dbname + """")
                BackupStream.Close()
                BackupProcess.WaitForExit()
                con.Close()
                showinfo("Database restore was successful")
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub dbBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName

    End Sub
End Class