Imports MySql.Data.MySqlClient
Imports System.IO
Public Class school_registration
    Dim mfpath As String = Application.StartupPath & "Images"
    Dim stfpath As String = Application.StartupPath & "Images\School Profile"
    Dim afn, aa, ah, af As Image

    Private Sub cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        Me.Cursor = Cursors.WaitCursor
        If txtsid.Text = "" Or sname.Text = "" Or box.Text = "" Or tel.Text = "" Or email.Text = "" Or pword.Text = "" Or cpword.Text = "" Then
            Me.Cursor = Cursors.Default
            showerror("School ID, School name, Post address, Telephone and Email cannot be empty")
            Exit Sub
        ElseIf Not pword.Text = cpword.Text Then
            Me.Cursor = Cursors.Default
            showerror("Password do not match!")
            Exit Sub

        ElseIf apic.Image.Width > 400 Or apic.Image.Height > 200 Then
            Me.Cursor = Cursors.Default
            showerror("Academic signature size must be not more than width and height of 400 x 200")
            Exit Sub
        ElseIf hpic.Image.Width > 400 Or hpic.Image.Height > 200 Then
            Me.Cursor = Cursors.Default
            showerror("Head signature size must be not more than width and height of 400 x 200")
            Exit Sub
        ElseIf fpic.Image.Width > 400 Or fpic.Image.Height > 200 Then
            Me.Cursor = Cursors.Default
            showerror("Finance signature size must be not more than width and height of 400 x 200")
            Exit Sub
        Else
            Try
                sname.Text = UCase(sname.Text)
                loc.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(loc.Text)

                Dim FileSize1, FileSize4, FileSize3, FileSize2 As UInt32
                Dim MS1, ms2, ms3, ms4 As New MemoryStream
                Dim mstream1, mstream2, mstream3, mstream4 As New System.IO.MemoryStream()

                logopic.Image.Save(mstream1, Imaging.ImageFormat.Jpeg)
                apic.Image.Save(mstream2, Imaging.ImageFormat.Jpeg)
                hpic.Image.Save(mstream3, Imaging.ImageFormat.Jpeg)
                fpic.Image.Save(mstream4, Imaging.ImageFormat.Jpeg)

                Dim arrImage1() As Byte = mstream1.GetBuffer()
                Dim arrImage2() As Byte = mstream2.GetBuffer()
                Dim arrImage3() As Byte = mstream3.GetBuffer()
                Dim arrImage4() As Byte = mstream4.GetBuffer()

                FileSize1 = mstream1.Length
                FileSize2 = mstream2.Length
                FileSize3 = mstream3.Length
                FileSize4 = mstream4.Length

                mstream1.Close()
                mstream2.Close()
                mstream3.Close()
                mstream4.Close()

                Dim fname As String = txtsid.Text & "_logo.jpg"
                Dim academicpic As String = txtsid.Text & "_academic.jpg"
                Dim head As String = txtsid.Text & "_head.jpg"
                Dim finance As String = txtsid.Text & "_finance.jpg"
                Dim fnamestring As String = System.IO.Path.Combine(stfpath, fname)
                Dim academicstring As String = System.IO.Path.Combine(stfpath, academicpic)
                Dim headstring As String = System.IO.Path.Combine(stfpath, head)
                Dim financestring As String = System.IO.Path.Combine(stfpath, finance)

                If Directory.Exists(mfpath) Then
                    If Not Directory.Exists(stfpath) Then
                        Directory.CreateDirectory(stfpath)
                    End If
                Else
                    Directory.CreateDirectory(mfpath)
                    Directory.CreateDirectory(stfpath)
                End If

                If FileSize1 > 100000 Or FileSize2 > 100000 Or FileSize3 > 100000 Or FileSize3 > 100000 Or FileSize4 > 100000 Then
                    Me.Cursor = Cursors.Default
                    showerror("Image size must not exceed 100 kb")
                    Exit Sub
                Else
                    afn = logopic.Image
                    aa = apic.Image
                    ah = hpic.Image
                    af = fpic.Image
                End If
                con = New MySqlConnection(cs)
                con.Open()
                If Not TextBox1.Text = "" Then
                    cmd = New MySqlCommand("UPDATE `school_profile` SET `name`='" & sname.Text & "',`password`='" & password.Text & "',`address`='" & box.Text & "',`phone`='" & tel.Text & "',`momo`='" & momo.Text & "',`town`='" & loc.Text & "',`email`='" & email.Text & "',`logo`= @logo,`sign_academic`= @apic,`sign_head`= @hpic,`sign_finance`= @fpic,`website`='" & web.Text & "' WHERE sid='" & TextBox1.Text & "'", con)

                    cmd.Parameters.AddWithValue("@logo", fname)
                    cmd.Parameters.AddWithValue("@apic", academicpic)
                    cmd.Parameters.AddWithValue("@hpic", head)
                    cmd.Parameters.AddWithValue("@fpic", finance)

                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                Else
                    cmd = New MySqlCommand("INSERT INTO `school_profile`(`sid`, `name`, `address`, `phone`, `momo`, `town`, `email`, `logo`, `sign_academic`, `sign_head`, `sign_finance`, `website`,`password`) VALUES ('" & txtsid.Text & "','" & sname.Text & "','" & box.Text & "','" & tel.Text & "','" & momo.Text & "','" & loc.Text & "','" & email.Text & "',@logo,@apic,@hpic,@fpic,'" & web.Text & "','" & (Encript(pword.Text)) & "')", con)

                    cmd.Parameters.AddWithValue("@logo", fname)
                    cmd.Parameters.AddWithValue("@apic", academicpic)
                    cmd.Parameters.AddWithValue("@hpic", head)
                    cmd.Parameters.AddWithValue("@fpic", finance)

                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                End If
                If IO.File.Exists(fnamestring) Or IO.File.Exists(academicstring) Or IO.File.Exists(headstring) Or IO.File.Exists(financestring) Then
                    IO.File.Delete(fnamestring)
                    IO.File.Delete(academicstring)
                    IO.File.Delete(headstring)
                    IO.File.Delete(financestring)

                    afn.Save(fnamestring)
                    ah.Save(headstring)
                    aa.Save(academicstring)
                    af.Save(financestring)
                Else
                    afn.Save(fnamestring)
                    ah.Save(headstring)
                    aa.Save(academicstring)
                    af.Save(financestring)
                End If
                con.Close()
                showinfo("School registration was successfull!")
                If TextBox1.Text = "" Then
                    login.Show()
                End If
                Me.Close()
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                showerror(ex.Message)
            End Try
            Me.Cursor = Cursors.Default
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdclear_Click(sender As Object, e As EventArgs) Handles cmdclear.Click
        Clear(Me)
    End Sub

    Private Sub cmdlogo_Click(sender As Object, e As EventArgs) Handles cmdlogo.Click
        Try
            With OpenFileDialog1
                .Filter = ("images|*.png;*.bmg;*.jpg;")
                .FilterIndex = 4
            End With
            'clear the filename
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                logopic.Image = Image.FromFile(OpenFileDialog1.FileName)
                If logopic.Image.Width > 500 Or logopic.Image.Height > 600 Then
                    Me.Cursor = Cursors.Default
                    showerror("Picture size must be not more than 500 x 600")
                    cmdlogo.BackColor = Color.Red
                Else
                    cmdlogo.BackColor = Color.Green
                End If
            End If
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub cmdasig_Click(sender As Object, e As EventArgs) Handles cmdasig.Click
        Try
            With OpenFileDialog1
                .Filter = ("images|*.png;*.bmg;*.jpg;")
                .FilterIndex = 4
            End With
            'clear the filename
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                apic.Image = Image.FromFile(OpenFileDialog1.FileName)
                If apic.Image.Width > 400 Or apic.Image.Height > 200 Then
                    showerror("Academic signature size must be not more than width and height of 400 x 200")
                    cmdasig.BackColor = Color.Red
                Else
                    cmdasig.BackColor = Color.Green
                End If
            End If
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub cmdhsig_Click(sender As Object, e As EventArgs) Handles cmdhsig.Click
        Try
            With OpenFileDialog1
                .Filter = ("images|*.png;*.bmg;*.jpg;")
                .FilterIndex = 4
            End With
            'clear the filename
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                hpic.Image = Image.FromFile(OpenFileDialog1.FileName)
                If hpic.Image.Width > 400 Or hpic.Image.Height > 200 Then
                    showerror("Head signature size must be not more than width and height of 400 x 200")
                    cmdhsig.BackColor = Color.Red
                Else
                    cmdhsig.BackColor = Color.Green
                End If
            End If
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
    Private Sub cmdfsig_Click(sender As Object, e As EventArgs) Handles cmdfsig.Click
        Try
            With OpenFileDialog1
                .Filter = ("images|*.png;*.bmg;*.jpg;")
                .FilterIndex = 4
            End With
            'clear the filename
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                fpic.Image = Image.FromFile(OpenFileDialog1.FileName)
                If fpic.Image.Width > 400 Or fpic.Image.Height > 200 Then
                    showerror("Finance signature size must be not more than width and height of 400 x 200")
                    cmdfsig.BackColor = Color.Red
                Else
                    cmdfsig.BackColor = Color.Green
                End If
            End If
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
    Private Sub cdelete_Click(sender As Object, e As EventArgs) Handles cdelete.Click
        Application.Exit()
    End Sub

    Private Sub school_registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
        setup()
        Try
            If Not TextBox1.Text = "" Then
                Dim sp As New DataTable
                sp = ShowData("select * from school_profile where  sid ='" & TextBox1.Text & "'")
                If sp.Rows.Count > 0 Then
                    txtsid.Text = sp.Rows(0)("sid").ToString
                    sname.Text = sp.Rows(0)("name").ToString
                    tel.Text = sp.Rows(0)("phone").ToString
                    box.Text = sp.Rows(0)("address").ToString
                    web.Text = sp.Rows(0)("website").ToString
                    email.Text = sp.Rows(0)("email").ToString
                    momo.Text = sp.Rows(0)("momo").ToString
                    loc.Text = sp.Rows(0)("town").ToString

                    Dim logopath, apicpath, hpicpath, fpicpath As String
                    logopath = stfpath & "\" & sp.Rows(0)("logo").ToString
                    apicpath = stfpath & "\" & sp.Rows(0)("sign_academic").ToString
                    hpicpath = stfpath & "\" & sp.Rows(0)("sign_head").ToString
                    fpicpath = stfpath & "\" & sp.Rows(0)("sign_finance").ToString

                    Dim cb1 = File.ReadAllBytes(logopath)
                    Dim cb2 = File.ReadAllBytes(apicpath)
                    Dim cb3 = File.ReadAllBytes(hpicpath)
                    Dim cb4 = File.ReadAllBytes(fpicpath)

                    Dim memlogo As New MemoryStream(cb1)
                    Dim memapic As New MemoryStream(cb2)
                    Dim memhpic As New MemoryStream(cb3)
                    Dim memfpic As New MemoryStream(cb4)

                    logopic.Image = Image.FromStream(memlogo)
                    cmdlogo.BackColor = Color.Green
                    apic.Image = Image.FromStream(memapic)
                    cmdasig.BackColor = Color.Green
                    hpic.Image = Image.FromStream(memhpic)
                    cmdhsig.BackColor = Color.Green
                    fpic.Image = Image.FromStream(memfpic)
                    cmdfsig.BackColor = Color.Green
                End If
            End If
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub
End Class