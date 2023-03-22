Imports MySql.Data.MySqlClient
Imports System.IO
Public Class adstudent

    Private Sub cmddelete_Click(sender As Object, e As EventArgs) Handles cmddelete.Click
        If txtid.Text = "" Then
            showerror("Please select a record to delete")
            Exit Sub
        Else
            Dialog1.Label1.Text = "Are you sure you want to delete a record with Student ID: " + txtid.Text
            Dialog1.ShowDialog()
            If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                querryString = "delete from student where student_id = '" + txtid.Text + "' and sid ='" & sid & "'"
                execute(querryString, 2)
                Clear(Me)
                up = 0
            End If
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub txtfirstname_TextChanged(sender As Object, e As EventArgs) Handles txtfirstname.TextChanged
        If IsNumeric(txtfirstname.Text) Then
            ErrorProvider1.SetError(txtfirstname, "Please enter only letters!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtmiddle_TextChanged(sender As Object, e As EventArgs) Handles txtmiddle.TextChanged
        If IsNumeric(txtmiddle.Text) Then
            ErrorProvider1.SetError(txtmiddle, "Please enter only letters!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtln_TextChanged(sender As Object, e As EventArgs) Handles txtln.TextChanged
        If IsNumeric(txtln.Text) Then
            ErrorProvider1.SetError(txtln, "Please enter only letters!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtfn_TextChanged(sender As Object, e As EventArgs) Handles txtfn.TextChanged
        If IsNumeric(txtfn.Text) Then
            ErrorProvider1.SetError(txtfn, "Please enter only letters!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtfc_TextChanged(sender As Object, e As EventArgs) Handles txtfc.TextChanged
        If Not IsNumeric(txtfc.Text) Then
            ErrorProvider1.SetError(txtfc, "Please enter only number!.")
        ElseIf txtfc.TextLength < 10 Then
            ErrorProvider1.SetError(txtfc, "Contact number must be 10 digits!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtmc_TextChanged(sender As Object, e As EventArgs) Handles txtmc.TextChanged
        If Not IsNumeric(txtmc.Text) Then
            ErrorProvider1.SetError(txtmc, "Please enter only number!.")
        ElseIf txtmc.TextLength < 10 Then
            ErrorProvider1.SetError(txtmc, "Contact number must be 10 digits!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtmn_TextChanged(sender As Object, e As EventArgs) Handles txtmn.TextChanged
        If IsNumeric(txtmn.Text) Then
            ErrorProvider1.SetError(txtmn, "Please enter only letters!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub adstudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
        ' Label19.Font = ffont
        If txtstnum.Text = "" Then
            txtadm.Text = Now.Date
            dob.Text = Now.Date
        End If
        cmddelete.Enabled = False
        If lblclass.Text = "None" Then
            lblclass.Visible = False
            lblage.Visible = False
            lblacademic.Visible = False
            lblterm.Visible = False
            admi.Visible = False
        End If
        Try
            If Not txtstnum.Text = "" Then

                Dim stfpath2 As String = Application.StartupPath & "Images\Students"


                con = New MySqlConnection(cs)
                        cmd = New MySqlCommand("select image from student where student_id = '" + txtstnum.Text + "' and sid ='" & sid & "' and  image is not null", con)
                        adp = New MySqlDataAdapter(cmd)
                        tb = New DataTable
                        adp.Fill(tb)
                If tb.Rows.Count > 0 Then
                    Dim fname As String = tb.Rows(0)(0).ToString
                    Dim spath As String
                    spath = stfpath2 & "\" & fname
                    If Directory.Exists(spath) Then
                        Dim cb1 = File.ReadAllBytes(spath)

                        Dim memlogo As New MemoryStream(cb1)

                        PictureBox1.Image = Image.FromStream(memlogo)
                    End If
                End If



                'con = New MySqlConnection(cs)
                'cmd = New MySqlCommand("select image from student where student_id = '" + txtstnum.Text + "' and sid ='" & sid & "' and not null", con)
                'adp = New MySqlDataAdapter(cmd)
                'tb = New DataTable
                'adp.Fill(tb)
                'If tb.Rows.Count > 0 Then
                '    Dim bytes As [Byte]() = tb.Rows(0)(0)
                '    Dim ms As New MemoryStream(bytes)
                '    PictureBox1.Image = Image.FromStream(ms)
                'End If
                cmddelete.Enabled = True

            End If
        Catch ex As Exception
            showerror(ex.Message)
        End Try

        Try
            Dim file As System.IO.StreamReader
            file = My.Computer.FileSystem.OpenTextFileReader("countries.txt")
            While Not file.EndOfStream
                txtn.Items.Add(file.ReadLine)
            End While
            file.Close()
        Catch ex As Exception
            showerror(ex.Message)
        End Try
        Try
            txtclass.DataSource = New BindingSource(ShowData("select * from class where sid ='" & sid & "'"), Nothing)
            txtclass.DisplayMember = "class_no"
        Catch ex As Exception
            showerror(ex.Message)
        End Try

        If txtclass.Items.Count < 1 Then
            showerror("Please go to academics -> class and subclass to add class and a sub-class before you can register a student")
        End If
        Dim age = Now.Date.Year - dob.Value.Year
        lblage.Text = "Age : " & age
        up = 0
        If ul = "4" Or ul = "6" Then
            cmdadd.Enabled = False
            cmddelete.Enabled = False
        End If
    End Sub

    Private Sub cmdbrowse_Click(sender As Object, e As EventArgs) Handles cmdbrowse.Click
        Try
            With OpenFileDialog1
                .Filter = ("images|*.png;*.bmg;*.jpg;")
                .FilterIndex = 4
            End With
            'clear the filename
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                If PictureBox1.Image.Width > 500 Or PictureBox1.Image.Height > 600 Then
                    showerror(" Picture size must be not more than  width:500 and  height:600")
                    Exit Sub
                Else
                    PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
                End If
            End If
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub cmdclear_Click(sender As Object, e As EventArgs) Handles cmdclear.Click
        up = 0
        Clear(Me)
        cmddelete.Enabled = False
    End Sub

    Private Sub cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        If txtfirstname.Text = "" Or txtln.Text = "" Or txtsclass.Text = "" Or txtgender.Text = "" Then
            showerror("Student number, firstname, lastname, Gender and class cannot be empty")
            Exit Sub
        ElseIf Not numbers(txtfc.Text) And Not txtfc.Text = "" Or Not numbers(txtmc.Text) And Not txtmc.Text = "" Then
            showerror("Input must not contain letters")
            Exit Sub
        ElseIf letters(txtfirstname.Text) Or letters(txtmiddle.Text) Or letters(txtln.Text) Or letters(txtfn.Text) Or letters(txtmn.Text) Then
            showerror("Firstname, Middle name, Lastname, Father's name and Mother's name must not contain figures")
            Exit Sub
        ElseIf Not txtfc.Text = "" And txtfc.TextLength < 10 Or Not txtmc.Text = "" And txtmc.TextLength < 10 Then
            showerror("Contact number must be 10 digits!.")
            Exit Sub
        ElseIf txtstatus.Text = "" Then
            showerror("Student status can not be empty!.")
            Exit Sub
        Else
            txtfirstname.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtfirstname.Text)
            txtmiddle.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtmiddle.Text)
            txtfn.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtfn.Text)
            txtmn.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtmn.Text)
            txtln.Text = UCase(txtln.Text)
            Dim fullname As String
            fullname = UCase(txtln.Text) + "," + txtfirstname.Text + " " + txtmiddle.Text
            '.......image..............
            Dim mfpath As String = Application.StartupPath & "Images"
            Dim stfpath As String = Application.StartupPath & "Images\Students"
            Dim a As Image
            Dim fname As String = txtstnum.Text & ".jpg"
            Dim pathstring As String = System.IO.Path.Combine(stfpath, fname)

            If Directory.Exists(mfpath) Then
                If Not Directory.Exists(stfpath) Then
                    Directory.CreateDirectory(stfpath)
                End If
            Else
                Directory.CreateDirectory(mfpath)
                Directory.CreateDirectory(stfpath)
            End If
            If txtid.Text = "" Then
                Try
                    con = New MySqlConnection(cs)
                    con.Open()
                    cmd2 = New MySqlCommand("select * from student where student_id ='" + txtstnum.Text + "' and fullname ='" + fullname + "' and sid ='" & sid & "'", con)
                    adp = New MySqlDataAdapter(cmd2)
                    tb = New DataTable
                    adp.Fill(tb)
                    If tb.Rows.Count < 1 Then
                        Dim FileSize As UInt32
                        Dim MS As New MemoryStream
                        Dim mstream As New System.IO.MemoryStream()
                        PictureBox1.Image.Save(mstream, Imaging.ImageFormat.Jpeg)
                        Dim arrImage() As Byte = mstream.GetBuffer()
                        FileSize = mstream.Length
                        mstream.Close()
                        If FileSize > 100000 Then
                            showerror("Image size must not exceed 100 kb")
                            Exit Sub
                        Else
                            a = PictureBox1.Image
                        End If
                        cmd = New MySqlCommand("INSERT INTO `student`(`student_id`, `fullname`, `gender`, `dob`, `father_name`, `mother_name`, `father_contact`, `mother_contact`, `address`, `class`, `nationality`, `disability`, `religion`, `image`, `admission_date`,`status`,academic,term,sid) VALUES ('" + txtstnum.Text + "','" & fullname & "','" + txtgender.Text + "','" + dob.Value.ToString("yyyy-MM-dd") + "','" + txtfn.Text + "','" + txtmn.Text + "','" + txtfc.Text + "','" + txtmc.Text + "','" + txtaddress.Text + "','" + txtsclass.Text + "','" + txtn.Text + "','" + txtd.Text + "','" + txtrg.Text + "',@image,'" + txtadm.Value.ToString("yyyy-MM-dd") + "','" + txtstatus.Text + "','" + academic_year + "','" + term + "','" & sid & "')", con)
                        cmd.Parameters.AddWithValue("@image", fname)
                        cmd.ExecuteNonQuery()
                        cmd.Parameters.Clear()
                        If IO.File.Exists(pathstring) Then
                            IO.File.Delete(pathstring)
                            a.Save(pathstring)
                        Else
                            a.Save(pathstring)
                        End If
                        con.Close()
                        If Not txtfn.Text = "" And Not txtfc.Text = "" Then
                            execute("INSERT INTO `parents_account`(`student_id`, `parent`, `password`,`sid`) VALUES ('" & txtstnum.Text & "','" & txtfn.Text & "','" & txtfc.Text & "','" & sid & "')", 3)
                        End If
                        If Not txtmn.Text = "" And Not txtmc.Text = "" Then
                            execute("INSERT INTO `parents_account`(`student_id`, `parent`, `password`,`sid`) VALUES ('" & txtstnum.Text & "','" & txtmn.Text & "','" & txtmc.Text & "','" & sid & "')", 3)
                        End If
                        Clear(Me)
                        up = 0
                        showinfo("Student record has been saved!")
                    Else
                        Dialog1.Label1.Text = "Record with Id: " + txtstnum.Text + " and name: " & fullname & " is already in the system. Do you want update it?"
                        Dialog1.ShowDialog()
                        If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                            Dim FileSize As UInt32
                            Dim MS As New MemoryStream
                            Dim mstream As New System.IO.MemoryStream()
                            PictureBox1.Image.Save(mstream, Imaging.ImageFormat.Jpeg)
                            Dim arrImage() As Byte = mstream.GetBuffer()
                            FileSize = mstream.Length
                            mstream.Close()
                            If FileSize > 100000 Then
                                showerror("Image size must not exceed 100 kb")
                                Exit Sub
                            Else
                                a = PictureBox1.Image
                            End If
                            cmd = New MySqlCommand("UPDATE `student` SET `gender`='" + txtgender.Text + "',`dob`='" + dob.Value.ToString("yyyy-MM-dd") + "',`father_name`='" + txtfn.Text + "',`mother_name`='" + txtmn.Text + "',`father_contact`='" + txtfc.Text + "',`mother_contact`='" + txtmc.Text + "',`address`='" + txtaddress.Text + "',`class`='" + txtsclass.Text + "',`nationality`='" + txtn.Text + "',`disability`='" + txtd.Text + "',`religion`='" + txtrg.Text + "',`image`=@image,`admission_date`='" + txtadm.Value.ToString("yyyy-MM-dd") + "',status='" + txtstatus.Text + "' WHERE student_id = '" + txtstnum.Text + "' and `fullname`='" & fullname & "' and sid = '" & sid & "'", con)
                            cmd.Parameters.AddWithValue("@image", fname)
                            cmd.ExecuteNonQuery()
                            cmd.Parameters.Clear()
                            con.Close()
                            If IO.File.Exists(pathstring) Then
                                IO.File.Delete(pathstring)
                                a.Save(pathstring)
                            Else
                                a.Save(pathstring)
                            End If
                            If Not txtfn.Text = "" And Not txtfc.Text = "" Then
                                execute("UPDATE  `parents_account` set  `parent`='" & txtfn.Text & "', `password`='" & txtfc.Text & "' where sid ='" & sid & "' and `student_id`='" & txtstnum.Text & "' ", 3)
                            End If
                            If Not txtmn.Text = "" And Not txtmc.Text = "" Then
                                execute("UPDATE  `parents_account` set  `parent`='" & txtmn.Text & "', `password`='" & txtmc.Text & "' where sid ='" & sid & "' and `student_id`='" & txtstnum.Text & "' ", 3)
                            End If
                            Clear(Me)
                            up = 0
                            showinfo("Student record has been updated!")
                        End If
                    End If
                    PictureBox1.Image = My.Resources.student
                Catch ex As Exception
                    showerror(ex.Message)
                End Try
            Else
                Try
                    Dim FileSize As UInt32
                    Dim MS As New MemoryStream
                    Dim mstream As New System.IO.MemoryStream()
                    PictureBox1.Image.Save(mstream, Imaging.ImageFormat.Jpeg)
                    Dim arrImage() As Byte = mstream.GetBuffer()
                    FileSize = mstream.Length
                    mstream.Close()
                    If FileSize > 100000 Then
                        showerror("Image size must not exceed 100 kb")
                        Exit Sub
                    Else
                        a = PictureBox1.Image
                    End If
                    con = New MySqlConnection(cs)
                    con.Open()
                    cmd = New MySqlCommand("UPDATE `student` SET `fullname`='" & fullname & "',`gender`='" + txtgender.Text + "',`dob`='" + dob.Value.ToString("yyyy-MM-dd") + "',`father_name`='" + txtfn.Text + "',`mother_name`='" + txtmn.Text + "',`father_contact`='" + txtfc.Text + "',`mother_contact`='" + txtmc.Text + "',`address`='" + txtaddress.Text + "',`class`='" + txtsclass.Text + "',`nationality`='" + txtn.Text + "',`disability`='" + txtd.Text + "',`religion`='" + txtrg.Text + "',`image`=@image,`admission_date`='" + txtadm.Value.ToString("yyyy-MM-dd") + "',status='" + txtstatus.Text + "' WHERE student_id = '" + txtid.Text + "' and sid ='" & sid & "'", con)
                    cmd.Parameters.AddWithValue("@image", fname)
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                    con.Close()
                    If IO.File.Exists(pathstring) Then
                        IO.File.Delete(pathstring)
                        a.Save(pathstring)
                    Else
                        a.Save(pathstring)
                    End If
                    showinfo("Student record has been updated!")
                    Clear(Me)
                    up = 0
                Catch ex As Exception
                    showerror(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub txtclass_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles txtclass.SelectedIndexChanged
        If up = 0 Then
            Try
                Me.Cursor = Cursors.WaitCursor
                txtsclass.Items.Clear()
                con = New MySqlConnection(cs)
                cmd = New MySqlCommand("select s_class, max_students from subclass where class = '" + txtclass.Text + "'  and sid ='" & sid & "' group by s_class ", con)
                adp = New MySqlDataAdapter(cmd)
                tb2 = New DataTable
                adp.Fill(tb2)
                If tb2.Rows.Count > 0 Then
                    For i As Integer = 0 To tb2.Rows.Count - 1
                        Dim max = tb2.Rows(i)(1).ToString
                        Dim c As Integer = record_count("select * from student where class = '" + tb2.Rows(i)(0).ToString + "' and status='Active' and sid ='" & sid & "'")
                        If max > c Then
                            txtsclass.Items.Add(tb2.Rows(i)(0).ToString)
                        End If
                    Next
                End If
                Me.Cursor = Cursors.Default
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub txtclass_TextChanged(sender As Object, e As EventArgs) Handles txtclass.TextChanged
        If up = 0 Then
            Try
                Me.Cursor = Cursors.WaitCursor
                txtsclass.Items.Clear()
                con = New MySqlConnection(cs)
                cmd = New MySqlCommand("select s_class, max_students from subclass where class = '" + txtclass.Text + "' and sid ='" & sid & "' group by s_class", con)
                adp = New MySqlDataAdapter(cmd)
                tb2 = New DataTable
                adp.Fill(tb2)
                If tb2.Rows.Count > 0 Then
                    For i As Integer = 0 To tb2.Rows.Count - 1
                        Dim max = tb2.Rows(i)(1).ToString
                        Dim c As Integer = record_count("select * from student where class = '" + tb2.Rows(i)(0).ToString + "' and sid ='" & sid & "'")
                        If max > c Then
                            txtsclass.Items.Add(tb2.Rows(i)(0).ToString)
                        End If
                    Next
                End If
                Me.Cursor = Cursors.Default
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub dob_ValueChanged(sender As Object, e As EventArgs) Handles dob.ValueChanged
        Dim age = Now.Date.Year - dob.Value.Year
        lblage.Text = "Age : " & age
        lblage.Visible = True
    End Sub
End Class