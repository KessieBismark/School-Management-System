Imports System.Net
Imports System.Web
Imports System.Collections.Specialized
Imports System.IO
Imports System.Text
Public Class messages
    Dim tb2, tb3 As New DataTable
    Dim mapi, murl, msender As String

    Private Sub txtby_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles txtby.SelectedIndexChanged
        If txtby.Text = "Class" Then
            txtst.DataSource = New BindingSource(ShowData("select * from subclass where sid= '" & sid & "'"), Nothing)
            txtst.DisplayMember = "s_class"
            txtst.Items.Add("")
            txtmeg.Enabled = True
            bsend.Enabled = True
            txts2.Visible = False
            txtst.Visible = True
            txtst.Enabled = True
        ElseIf txtby.Text = "Staff" Then
            txts2.Enabled = True
            txtst.Visible = False
            txts2.Visible = True

            txtmeg.Enabled = True
            bsend.Enabled = True
        ElseIf txtby.Text = "All Parents" Or txtby.Text = "All Staff" Then
            txtst.Enabled = False
            txts2.Enabled = False
            txtmeg.Enabled = True
            bsend.Enabled = True

        End If
    End Sub

    Private Sub bsend_Click(sender As Object, e As EventArgs) Handles bsend.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim tb As New DataTable
            If txtby.Text = "Class" And Not txtst.Text = "" Then
                'class message
                tb = ShowData("select * from student where class= '" + txtst.Text + "' and sid ='" & sid & "'")
                Dim number As Integer
                For i As Integer = 0 To tb.Rows.Count - 1
                    If tb.Rows(i)(6).ToString = "" And tb.Rows(i)(7).ToString = "" Then
                    ElseIf tb.Rows(i)(6).ToString = "" And Not tb.Rows(i)(7).ToString = "" Then
                        number = Val(tb.Rows(i)(7).ToString)
                        contact.Text = "+233" & number & ","
                    ElseIf Not tb.Rows(i)(6).ToString = "" Then
                        number = Val(tb.Rows(i)(6).ToString)
                        contact.Text = "+233" & number & ","
                    End If
                Next
                contact.Text = contact.Text.TrimEnd(",")


                Dim apikey = mapi
                Dim message = txtmeg.Text
                Dim numbers = contact.Text
                Dim strGet As String
                Dim sendeer = msender
                Dim url As String = murl

                strGet = url + "apikey=" + apikey _
                + "&numbers=" + numbers _
                + "&message=" + WebUtility.HtmlEncode(message) _
                + "&sender=" + sendeer

                Dim webClient As New System.Net.WebClient
                Dim result As String = webClient.DownloadString(strGet)
                contact.Text = ""
                Me.Cursor = Cursors.Default
                showinfo("message has been sent to " & tb.Rows.Count & " parents")

            ElseIf txtby.Text = "Staff" And Not txtst.Text = "" Then
                'staff message
                tb = ShowData("select * from staff where employment_type = '" + txtst.Text + "' and sid ='" & sid & "'")
                Dim number As Integer
                For i As Integer = 0 To tb.Rows.Count - 1
                    number = Val(tb.Rows(i)(4).ToString)
                    contact.Text = "+233" & number & ","
                Next
                contact.Text = contact.Text.TrimEnd(",")

                Dim apikey = mapi
                Dim message = txtmeg.Text
                Dim numbers = contact.Text
                Dim strGet As String
                Dim sendeer = msender
                Dim url As String = murl

                strGet = url + "apikey=" + apikey _
                + "&numbers=" + numbers _
                + "&message=" + WebUtility.HtmlEncode(message) _
                + "&sender=" + sendeer

                Dim webClient As New System.Net.WebClient
                Dim result As String = webClient.DownloadString(strGet)
                contact.Text = ""
                Me.Cursor = Cursors.Default
                showinfo("message has been sent to " & tb.Rows.Count & " " & txtst.Text)

            ElseIf txtby.Text = "All Parents" Then
                'parents message
                tb = ShowData("select * from student where  sid ='" & sid & "'")
                Dim number As Integer
                For i As Integer = 0 To tb.Rows.Count - 1
                    If tb.Rows(i)(6).ToString = "" And tb.Rows(i)(7).ToString = "" Then
                    ElseIf tb.Rows(i)(6).ToString = "" And Not tb.Rows(i)(7).ToString = "" Then
                        number = Val(tb.Rows(i)(7).ToString)
                        contact.Text = "+233" & number & ","
                    ElseIf Not tb.Rows(i)(6).ToString = "" Then
                        number = Val(tb.Rows(i)(6).ToString)
                        contact.Text = "+233" & number & ","
                    End If
                Next
                contact.Text = contact.Text.TrimEnd(",")


                Dim apikey = mapi
                Dim message = txtmeg.Text
                Dim numbers = contact.Text
                Dim strGet As String
                Dim sendeer = msender
                Dim url As String = murl

                strGet = url + "apikey=" + apikey _
                + "&numbers=" + numbers _
                + "&message=" + WebUtility.HtmlEncode(message) _
                + "&sender=" + sendeer

                Dim webClient As New System.Net.WebClient
                Dim result As String = webClient.DownloadString(strGet)
                contact.Text = ""
                Me.Cursor = Cursors.Default
                showinfo("message has been sent to " & tb.Rows.Count & " parents")
            ElseIf txtby.Text = "All Staff" Then
                'all staff message
                tb = ShowData("select * from staff where sid ='" & sid & "'")
                Dim number As Integer
                For i As Integer = 0 To tb.Rows.Count - 1
                    number = Val(tb.Rows(i)(6).ToString)
                    contact.Text = "+233" & number & ","
                Next
                contact.Text = contact.Text.TrimEnd(",")


                Dim apikey = mapi
                Dim message = txtmeg.Text
                Dim numbers = contact.Text
                Dim strGet As String
                Dim sendeer = msender
                Dim url As String = murl

                strGet = url + "apikey=" + apikey _
                + "&numbers=" + numbers _
                + "&message=" + WebUtility.HtmlEncode(message) _
                + "&sender=" + sendeer

                Dim webClient As New System.Net.WebClient
                Dim result As String = webClient.DownloadString(strGet)
                contact.Text = ""
                Me.Cursor = Cursors.Default
                showinfo("message has been sent to " & tb.Rows.Count & " parents")
            Else
                Me.Cursor = Cursors.Default
                showerror("Please select all the required information needed")
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        meg_config.showdialog()
    End Sub

    Private Sub txteby_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles txteby.SelectedIndexChanged
        If txteby.Text = "Class" Then
            txtclass.Enabled = True
            txtclass.DataSource = New BindingSource(ShowData("select * from subclass where sid= '" & sid & "'"), Nothing)
            txtclass.DisplayMember = "s_class"
            txtclass.Items.Add("")
        Else
            txtclass.Enabled = False
        End If
    End Sub

    Private Sub esend_Click(sender As Object, e As EventArgs) Handles esend.Click

        Try
                Me.Cursor = Cursors.WaitCursor
                Dim c As Integer = record_count("select * From grade where Academic = '" & academic_year & "' and Term = '" & term & "' and sid ='" & sid & "'")
                If c > 0 Then
                    If txteby.Text = "Class" And Not txtclass.Text = "" Then
                        'class message

                        tb = ShowData("select * from student where class= '" + txtst.Text + "' and sid ='" & sid & "'")
                        Dim number As Integer
                        Dim meg As String
                        For i As Integer = 0 To tb.Rows.Count - 1
                            If tb.Rows(i)(6).ToString = "" And tb.Rows(i)(7).ToString = "" Then
                            ElseIf tb.Rows(i)(6).ToString = "" And Not tb.Rows(i)(7).ToString = "" Then
                                number = Val(tb.Rows(i)(7).ToString)
                                contact.Text = "+233" & number
                            ElseIf Not tb.Rows(i)(6).ToString = "" Then
                                number = Val(tb.Rows(i)(6).ToString)
                                contact.Text = "+233" & number
                            End If
                            tb3 = ShowData("select * from grade where student_id = '" & tb.Rows(0)(0).ToString & "' and sid = '" & sid & "' and Academic = '" & academic_year & "' and Term='" & term & "'")
                            If tb3.Rows.Count > 0 Then
                            If Not term = 3 Then
                                meg = academic_year & ", Term:" & term & " result of " & tb3.Rows(0)(2).ToString & vbCrLf &
                                    "Position=" & tb3.Rows(0)(4).ToString & vbCrLf &
                                    "Marks=" & tb3.Rows(0)(3).ToString & vbCrLf &
                                    "Remark=" & tb3.Rows(0)(8).ToString
                            Else
                                If tb.Rows(i)(9).ToString = tb.Rows(i)(19).ToString Then
                                    meg = academic_year & ", Term:" & term & " result of " & tb3.Rows(0)(2).ToString & vbCrLf &
                                        "Position=" & tb3.Rows(0)(4).ToString & vbCrLf &
                                        "Marks=" & tb3.Rows(0)(3).ToString & vbCrLf &
                                        "Remark=" & tb3.Rows(0)(8).ToString & vbCrLf &
                                        "Repeated to class " & tb.Rows(i)(9).ToString
                                Else
                                    meg = academic_year & ", Term:" & term & " result of " & tb3.Rows(0)(2).ToString & vbCrLf &
                                        "Position=" & tb3.Rows(0)(4).ToString & vbCrLf &
                                        "Marks=" & tb3.Rows(0)(3).ToString & vbCrLf &
                                        "Remark=" & tb3.Rows(0)(8).ToString & vbCrLf &
                                        "Promoted to class " & tb.Rows(i)(9).ToString
                                End If
                                End If
                                Dim apikey = mapi
                                Dim message = meg
                                Dim numbers = contact.Text
                                Dim strGet As String
                                Dim sendeer = msender
                                Dim url As String = murl

                                strGet = url + "apikey=" + apikey _
                            + "&numbers=" + numbers _
                            + "&message=" + WebUtility.HtmlEncode(message) _
                            + "&sender=" + sendeer

                                Dim webClient As New System.Net.WebClient
                                Dim result As String = webClient.DownloadString(strGet)
                                contact.Text = ""
                            End If

                        Next
                        Me.Cursor = Cursors.Default
                        showinfo("message has been sent to " & tb.Rows.Count & " parents")

                    ElseIf txteby.Text = "All" Then

                        tb = ShowData("select * from student where sid ='" & sid & "'")
                        Dim number As Integer
                        Dim meg As String
                        For i As Integer = 0 To tb.Rows.Count - 1
                            If tb.Rows(i)(6).ToString = "" And tb.Rows(i)(7).ToString = "" Then
                            ElseIf tb.Rows(i)(6).ToString = "" And Not tb.Rows(i)(7).ToString = "" Then
                                number = Val(tb.Rows(i)(7).ToString)
                                contact.Text = "+233" & number
                            ElseIf Not tb.Rows(i)(6).ToString = "" Then
                                number = Val(tb.Rows(i)(6).ToString)
                                contact.Text = "+233" & number
                            End If
                            tb3 = ShowData("select * from grade where student_id = '" & tb.Rows(0)(0).ToString & "' and sid = '" & sid & "' and Academic = '" & academic_year & "' and Term='" & term & "'")
                            If tb3.Rows.Count > 0 Then
                                If Not term = 3 Then
                                meg = academic_year & ", Term:" & term & " result of " & tb3.Rows(0)(2).ToString & vbCrLf &
                                    "Position=" & tb3.Rows(0)(4).ToString & vbCrLf &
                                    "Marks=" & tb3.Rows(0)(3).ToString & vbCrLf &
                                    "Remark=" & tb3.Rows(0)(8).ToString
                            Else
                                    If tb.Rows(i)(9).ToString = tb.Rows(i)(19).ToString Then
                                    meg = academic_year & ", Term:" & term & " result of " & tb3.Rows(0)(2).ToString & vbCrLf &
                                        "Position=" & tb3.Rows(0)(4).ToString & vbCrLf &
                                        "Marks=" & tb3.Rows(0)(3).ToString & vbCrLf &
                                        "Remark=" & tb3.Rows(0)(8).ToString & vbCrLf &
                                        "Repeated to class " & tb.Rows(i)(9).ToString
                                Else
                                    meg = academic_year & ", Term:" & term & " result of " & tb3.Rows(0)(2).ToString & vbCrLf &
                                        "Position=" & tb3.Rows(0)(4).ToString & vbCrLf &
                                        "Marks=" & tb3.Rows(0)(3).ToString & vbCrLf &
                                        "Remark=" & tb3.Rows(0)(8).ToString & vbCrLf &
                                        "Promoted to class " & tb.Rows(i)(9).ToString
                                End If
                                End If
                                Dim apikey = mapi
                                Dim message = meg
                                Dim numbers = contact.Text
                                Dim strGet As String
                                Dim sendeer = msender
                                Dim url As String = murl

                                strGet = url + "apikey=" + apikey _
                            + "&numbers=" + numbers _
                            + "&message=" + WebUtility.HtmlEncode(message) _
                            + "&sender=" + sendeer

                                Dim webClient As New System.Net.WebClient
                                Dim result As String = webClient.DownloadString(strGet)
                                contact.Text = ""
                            End If

                        Next
                        Me.Cursor = Cursors.Default
                        showinfo("message has been sent to " & tb.Rows.Count & " parents")
                    End If
                Else
                    Me.Cursor = Cursors.Default
                    showerror("Please go to Marks and input all the exams result and go to Academics -> Promtion to promote the students if it's term 3 before you can send exams messages.")
                End If
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                showerror(ex.Message)
            End Try

    End Sub

    Private Sub messages_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tb2 = ShowData("select * from message_config where sid = '" & sid & "'")
        If tb2.Rows.Count > 0 Then
            mapi = tb2.Rows(0)(1).ToString
            murl = tb2.Rows(0)(2).ToString
            sender = tb2.Rows(0)(3).ToString
        End If
        If ul = "2" Or ul = "3" Or ul = "0" Or ul = "1" Then
            esend.Enabled = True
        Else
            esend.Enabled = False
        End If
        If ul = "1" Or ul = "0" Then
            RadButton1.Enabled = True
        Else
            RadButton1.Enabled = False
        End If
    End Sub
End Class