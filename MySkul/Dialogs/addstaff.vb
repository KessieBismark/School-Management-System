Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text
Imports DPFP.Capture
Imports DPFP
Public Class addstaff
    Implements DPFP.Capture.EventHandler

    Private captura As DPFP.Capture.Capture
    Private enroller As DPFP.Processing.Enrollment
    Private Delegate Sub delegator(ByVal text As String)
    Private Delegate Sub delegatorcontrol()
    Private template As DPFP.Template
    Dim mfpath As String = Application.StartupPath & "Images"
    Dim stfpath As String = Application.StartupPath & "Images\Staff"
    Private Sub per(ByVal text1 As String)
        If (bioinfo.InvokeRequired) Then
            Dim deleg As New delegator(AddressOf per)
            Me.Invoke(deleg, New Object() {text1})
        Else
            bioinfo.Text = text1
        End If
    End Sub
    Protected Overridable Sub init()
        Try
            captura = New Capture()
            If Not captura Is Nothing Then
                captura.EventHandler = Me
                enroller = New DPFP.Processing.Enrollment()
                Dim text As New StringBuilder
                text.AppendFormat("Register your finger for {0} number of instance", enroller.FeaturesNeeded)
                bioinfo.Text = text.ToString
            Else
                showerror("No finger print was captured!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'Private Sub modifycontrol()
    '    If (btnsave.InvokeRequired Or btnupdate.InvokeRequired) Then
    '        Dim deleg As New delegatorcontrol(AddressOf modifycontrol)
    '        Me.Invoke(deleg, New Object() {})
    '    ElseIf txtid.Text = "" Then
    '        btnsave.Enabled = True
    '    ElseIf Not txtid.Text = "" Then
    '        btnupdate.Enabled = True
    '    End If
    'End Sub
    Protected Sub startcapture()
        If Not captura Is Nothing Then
            Try
                captura.StartCapture()
            Catch ex As Exception
                showerror(ex.Message)
            End Try
        End If
    End Sub

    Protected Sub stopcapture()
        If Not captura Is Nothing Then
            Try
                captura.StopCapture()
            Catch ex As Exception
                showerror(ex.Message)
            End Try
        End If
    End Sub

    Protected Function convertsample(ByVal sample As DPFP.Sample) As Bitmap
        Dim converter As New DPFP.Capture.SampleConversion()
        Dim pic As Bitmap = Nothing
        converter.ConvertToPicture(sample, pic)
        Return pic
    End Function
    Private Sub fingerprint(ByVal bmg)
        PictureBox2.Image = bmg
    End Sub
    Protected Function getchar(ByVal Sample As DPFP.Sample, ByVal Purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
        Dim extractor As New DPFP.Processing.FeatureExtraction()
        Dim digital As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
        Dim xtics As New DPFP.FeatureSet()
        extractor.CreateFeatureSet(Sample, Purpose, digital, xtics)

        If (digital = DPFP.Capture.CaptureFeedback.Good) Then
            Return xtics
        Else
            Return Nothing
        End If
    End Function

    Protected Sub Process(ByVal sample As DPFP.Sample)
        Try
            Dim xtics As DPFP.FeatureSet = getchar(sample, DPFP.Processing.DataPurpose.Enrollment)
            If (Not xtics Is Nothing) Then
                Try
                    enroller.AddFeatures(xtics)
                Finally
                    Dim text As New StringBuilder
                    text.AppendFormat("Register your finger for {0} number of instance", enroller.FeaturesNeeded)
                    per(text.ToString())
                    Select Case enroller.TemplateStatus
                        Case DPFP.Processing.Enrollment.Status.Ready
                            template = enroller.Template
                            stopcapture()
                        Case DPFP.Processing.Enrollment.Status.Failed
                            enroller.Clear()
                            stopcapture()
                            startcapture()
                    End Select
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        txtsid.ReadOnly = False
    End Sub

    Private Sub txtfirstname_TextChanged(sender As Object, e As EventArgs) Handles txtfirstname.TextChanged
        If IsNumeric(txtfirstname.Text) Then
            ErrorProvider1.SetError(txtfirstname, "Please enter only letters!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub cmdbrowse_Click(sender As Object, e As EventArgs) Handles cmdbrowse.Click
        Try
            With OpenFileDialog1
                .Filter = ("images|*.png;*.bmg;*.jpg;*.gif;*.ico;")
                .FilterIndex = 4
            End With
            'clear the filename
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                If PictureBox1.Image.Width > 500 Or PictureBox1.Image.Height > 600 Then
                    showerror("Please picture size must be not more than 500 x 600")
                    Exit Sub
                Else
                    PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
                End If
            End If
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        If txtfirstname.Text = "" Or txtln.Text = "" Or txtgender.Text = "" Or txtnk.Text = "" Or txtkc.Text = "" Or txtss.Text = "" Or txtsid.Text = "" Or txtq.Text = "" Or txtfon.Text = "" Then
            showerror("Staff ID, firstname, lastname, Gender, staff status, next of kin's information, qualification, phone number and class con not be empty")
            Exit Sub
        ElseIf Not numbers(txtkc.Text) Or txtfon.Text = "" Or Not numbers(txtacno.Text) And Not txtacno.Text = "" Then
            showerror("Number Inputs must not contain letters")
            Exit Sub
        ElseIf letters(txtfirstname.Text) Or letters(txtmiddle.Text) Or letters(txtln.Text) Or letters(txtnk.Text) Or letters(txtq.Text) Then
            showerror("Firstname, Middle name, Lastname, Father's name and Mother's name must not contain figures")
            Exit Sub
        ElseIf Not txtkc.Text = "" < 10 Or txtfon.TextLength < 10 Then
            showerror("Contact number must be 10 digits!.")
            Exit Sub
        ElseIf txtss.Text = "" Then
            showerror("Staff status must be selected.")
            Exit Sub
        ElseIf Not txtemail.Text = "" And validateEmail(txtemail.Text) = False Then
            showerror("Please type in the correct email else leave the place blank!")
            Exit Sub

        ElseIf txtsclass.Text = "" And txtss.Text = "Teaching Staff" Then
            showerror("Staff ID, firstname, lastname, Gender, staff status, next of kin's information, qualification, phone number and class con not be empty")
            Exit Sub
        Else
            txtfirstname.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtfirstname.Text)
            txtmiddle.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtmiddle.Text)
            txtq.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtq.Text)
            txtnk.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtnk.Text)
            txtln.Text = UCase(txtln.Text)
            Dim fullname As String
            fullname = UCase(txtln.Text) + "," + txtfirstname.Text + " " + txtmiddle.Text
            Dim a As Image
            Dim fname As String = txtsid.Text & ".jpg"
            Dim pathstring As String = System.IO.Path.Combine(stfpath, fname)

            If Directory.Exists(mfpath) Then
                If Not Directory.Exists(stfpath) Then
                    Directory.CreateDirectory(stfpath)
                End If
            Else
                Directory.CreateDirectory(mfpath)
                Directory.CreateDirectory(stfpath)
            End If
            If bioinfo.Text = "Register your finger for 4 number of instance" Then
                If txtid.Text = "" Then
                    Try
                        con = New MySqlConnection(cs)
                        cmd2 = New MySqlCommand("select * from staff where staff_id ='" + txtsid.Text + "' and fullname ='" + fullname + "' and sid ='" & sid & "'", con)
                        adp = New MySqlDataAdapter(cmd2)
                        tb = New DataTable
                        adp.Fill(tb)
                        con.Open()
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
                            cmd = New MySqlCommand("INSERT INTO `staff`(`staff_id`, `fullname`, `dob`, `gender`, `phone`, `address`, `nextkin`, `kinphone`, `email`, `classes`, `hired_date`, `qualification`, `accountname`, `employment_type`, `accountno`, `branch`, `image`,`sid`) VALUES ('" + txtsid.Text + "','" & fullname & "','" + dob.Value.ToString("yyyy-MM-dd") + "','" + txtgender.Text + "','" + txtfon.Text + "','" + txtaddress.Text + "','" + txtnk.Text + "','" + txtkc.Text + "','" + txtemail.Text + "','" + txtsclass.Text + "','" + txthd.Value.ToString("yyyy-MM-dd") + "','" + txtq.Text + "','" + txtacname.Text + "','" + txtss.Text + "','" + txtacno.Text + "','" + txtbranch.Text + "',@image,'" & sid & "')", con)
                            cmd.Parameters.AddWithValue("@image", fname)
                            cmd.ExecuteNonQuery()
                            cmd.Parameters.Clear()

                            If txtss.Text = "Teaching Staff" Then
                                execute("INSERT INTO `users`(`Staff_ID`, `Name`, `Username`, `password`, `pass`, `sid`) VALUES ('" + txtsid.Text + "','" & fullname & "','" + txtln.Text + "','" & (Encript(txtsid.Text)) & "','6','" & sid & "')", 3)
                            End If
                            If IO.File.Exists(pathstring) Then
                                IO.File.Delete(pathstring)
                                a.Save(pathstring)
                            Else
                                a.Save(pathstring)
                            End If
                            con.Close()
                            showinfo("Staff record has been saved!")
                            Clear(Me)
                            up = 0
                            txtsid.ReadOnly = False
                        Else
                            Dialog1.Label1.Text = "Record with Staff Id: " + txtsid.Text + " and name: " & fullname & " is already in the system. Do you want update it?"
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
                                End If

                                cmd = New MySqlCommand("UPDATE `staff` SET `dob`='" + dob.Value.ToString("yyyy-MM-dd") + "',`gender`='" + txtgender.Text + "',`phone`='" + txtfon.Text + "',`address`='" + txtaddress.Text + "',`nextkin`='" + txtnk.Text + "',`kinphone`='" + txtkc.Text + "',`email`='" + txtemail.Text + "',`classes`='" + txtsclass.Text + "',`hired_date`='" + txthd.Value.ToString("yyyy-MM-dd") + "',`qualification`='" + txtq.Text + "',`accountname`='" + txtacname.Text + "',`employment_type`='" + txtss.Text + "',`accountno`='" + txtacno.Text + "',`branch`='" + txtbranch.Text + "',`image`=@image WHERE  staff_id = '" + txtsid.Text + "' and `fullname`='" & fullname & "' and sid = '" & sid & "'", con)
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
                                showinfo("Staff record has been updated!")
                                Clear(Me)
                                up = 0
                                txtsid.ReadOnly = False
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception
                        con.Close()
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
                        con = New MySqlConnection(cs)
                        con.Open()
                        If FileSize > 100000 Then
                            showerror("Image size must not exceed 100 kb")
                            Exit Sub
                        End If
                        cmd = New MySqlCommand("UPDATE `staff` SET `fullname`='" & fullname & "',`dob`='" + dob.Value.ToString("yyyy-MM-dd") + "',`gender`='" + txtgender.Text + "',`phone`='" + txtfon.Text + "',`address`='" + txtaddress.Text + "',`nextkin`='" + txtnk.Text + "',`kinphone`='" + txtkc.Text + "',`email`='" + txtemail.Text + "',`classes`='" + txtsclass.Text + "',`hired_date`='" + txthd.Value.ToString("yyyy-MM-dd") + "',`qualification`='" + txtq.Text + "',`accountname`='" + txtacname.Text + "',`employment_type`='" + txtss.Text + "',`accountno`='" + txtacno.Text + "',`branch`='" + txtbranch.Text + "',`image`=@image WHERE  staff_id = '" + txtsid.Text + "' and sid ='" & sid & "'", con)
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
                        showinfo("Staff record has been updated!")
                        Clear(Me)
                        up = 0
                        txtsid.ReadOnly = False
                    Catch ex As Exception
                        showerror(ex.Message)
                    End Try
                End If
            Else
                Dim fp As New MemoryStream(template.Bytes)
                If txtid.Text = "" Then
                    Try
                        con = New MySqlConnection(cs)
                        cmd2 = New MySqlCommand("select * from staff where staff_id ='" + txtsid.Text + "' and fullname ='" + fullname + "' and sid ='" & sid & "'", con)
                        adp = New MySqlDataAdapter(cmd2)
                        tb = New DataTable
                        adp.Fill(tb)
                        con.Open()
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
                            End If
                            cmd = New MySqlCommand("INSERT INTO `staff`(`staff_id`, `fullname`, `dob`,`gender`, `phone`, `address`, `nextkin`, `kinphone`, `email`, `classes`, `hired_date`, `qualification`, `accountname`, `employment_type`, `accountno`, `branch`, `image`, `fingerprint`,`sid`) VALUES ('" + txtsid.Text + "','" & fullname & "','" + dob.Value.ToString("yyyy-MM-dd") + "','" + txtgender.Text + "','" + txtfon.Text + "','" + txtaddress.Text + "','" + txtnk.Text + "','" + txtkc.Text + "','" + txtemail.Text + "','" + txtsclass.Text + "','" + txthd.Value.ToString("yyyy-MM-dd") + "','" + txtq.Text + "','" + txtacname.Text + "','" + txtss.Text + "','" + txtacno.Text + "','" + txtbranch.Text + "',@image,@finger,'" & sid & "')", con)
                            cmd.Parameters.AddWithValue("@image", fname)
                            cmd.Parameters.AddWithValue("@finger", fp.ToArray())
                            cmd.ExecuteNonQuery()
                            cmd.Parameters.Clear()
                            If IO.File.Exists(pathstring) Then
                                IO.File.Delete(pathstring)
                                a.Save(pathstring)
                            Else
                                a.Save(pathstring)
                            End If
                            con.Close()
                            enroller.Clear()
                            stopcapture()
                            startcapture()
                            showinfo("Staff record has been saved!")
                            Clear(Me)
                            up = 0
                            txtsid.ReadOnly = False
                        Else
                            Dialog1.Label1.Text = "Record with Staff Id: " + txtsid.Text + " and name: " & fullname & " is already in the system. Do you want update it?"
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
                                End If
                                cmd = New MySqlCommand("UPDATE `staff` SET `dob`='" + dob.Value.ToString("yyyy-MM-dd") + "',`gender`='" + txtgender.Text + "',`phone`='" + txtfon.Text + "',`address`='" + txtaddress.Text + "',`nextkin`='" + txtnk.Text + "',`kinphone`='" + txtkc.Text + "',`email`='" + txtemail.Text + "',`classes`='" + txtsclass.Text + "',`hired_date`='" + txthd.Value.ToString("yyyy-MM-dd") + "',`qualification`='" + txtq.Text + "',`accountname`='" + txtacname.Text + "',`employment_type`='" + txtss.Text + "',`accountno`='" + txtacno.Text + "',`branch`='" + txtbranch.Text + "',`image`=@image,`fingerprint`=@finger WHERE  staff_id = '" + txtsid.Text + "' and `fullname`='" & fullname & "' and sid = '" & sid & "'", con)
                                cmd.Parameters.AddWithValue("@image", fname)
                                cmd.Parameters.AddWithValue("@finger", fp.ToArray())
                                cmd.ExecuteNonQuery()
                                cmd.Parameters.Clear()
                                If IO.File.Exists(pathstring) Then
                                    IO.File.Delete(pathstring)
                                    a.Save(pathstring)
                                Else
                                    a.Save(pathstring)
                                End If
                                enroller.Clear()
                                stopcapture()
                                startcapture()
                                con.Close()
                                showinfo("Staff record has been updated!")
                                Clear(Me)
                                up = 0
                                txtsid.ReadOnly = False
                                PictureBox2.Image = My.Resources.Fingerprint_Scan_96px
                            End If
                        End If
                    Catch ex As Exception
                        con.Close()
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
                        con = New MySqlConnection(cs)
                        con.Open()
                        If FileSize > 100000 Then
                            showerror("Image size must not exceed 100 kb")
                            Exit Sub
                        End If
                        cmd = New MySqlCommand("UPDATE `staff` SET `fullname`='" & fullname & "',`dob`='" + dob.Value.ToString("yyyy-MM-dd") + "',`gender`='" + txtgender.Text + "',`phone`='" + txtfon.Text + "',`address`='" + txtaddress.Text + "',`nextkin`='" + txtnk.Text + "',`kinphone`='" + txtkc.Text + "',`email`='" + txtemail.Text + "',`classes`='" + txtsclass.Text + "',`hired_date`='" + txthd.Value.ToString("yyyy-MM-dd") + "',`qualification`='" + txtq.Text + "',`accountname`='" + txtacname.Text + "',`employment_type`='" + txtss.Text + "',`accountno`='" + txtacno.Text + "',`branch`='" + txtbranch.Text + "',`image`=@image,`fingerprint`=@finger WHERE  staff_id = '" + txtsid.Text + "' and sid ='" & sid & "'", con)
                        cmd.Parameters.AddWithValue("@image", fname)
                        cmd.Parameters.AddWithValue("@finger", fp.ToArray())
                        cmd.ExecuteNonQuery()
                        cmd.Parameters.Clear()
                        If IO.File.Exists(pathstring) Then
                            IO.File.Delete(pathstring)
                            a.Save(pathstring)
                        Else
                            a.Save(pathstring)
                        End If
                        con.Close()
                        enroller.Clear()
                        stopcapture()
                        startcapture()
                        showinfo("Staff record has been updated!")
                        Clear(Me)
                        up = 0
                        PictureBox2.Image = My.Resources.Fingerprint_Scan_96px
                        txtsid.ReadOnly = False
                    Catch ex As Exception
                        con.Close()
                        showerror(ex.Message)
                    End Try
                End If
            End If
        End If
        PictureBox1.Image = My.Resources.student
        con.Close()
    End Sub

    Private Sub cmddelete_Click(sender As Object, e As EventArgs) Handles cmddelete.Click
        If txtsid.Text = "" Then
            showerror("Please select a record to delete")
            Exit Sub
        Else
            Dialog1.Label1.Text = "Are you sure you want to delete a record with Staff ID: " + txtsid.Text
            Dialog1.ShowDialog()
            If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                querryString = "delete from staff where staff_id = '" + txtsid.Text + "' and sid ='" & sid & "'"
                execute(querryString, 2)
                Clear(Me)
                up = 0
                txtsid.ReadOnly = False
            End If
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

    Private Sub txtfon_TextChanged(sender As Object, e As EventArgs) Handles txtfon.TextChanged
        If Not IsNumeric(txtfon.Text) Then
            ErrorProvider1.SetError(txtfon, "Please enter only numbers!.")
        ElseIf txtfon.TextLength < 10 Then
            ErrorProvider1.SetError(txtfon, "Contact number must be 10 digits!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtkc_TextChanged(sender As Object, e As EventArgs) Handles txtkc.TextChanged
        If Not IsNumeric(txtkc.Text) Then
            ErrorProvider1.SetError(txtkc, "Please enter only number!.")
        ElseIf txtkc.TextLength < 10 Then
            ErrorProvider1.SetError(txtkc, "Contact number must be 10 digits!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtacno_TextChanged(sender As Object, e As EventArgs) Handles txtacno.TextChanged
        If Not IsNumeric(txtacno.Text) Then
            ErrorProvider1.SetError(txtacno, "Please enter only number!.")
        ElseIf txtacno.TextLength < 10 Then
            ErrorProvider1.SetError(txtacno, "Contact number must be 10 digits!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub addstaff_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label19.Text = AppName
        Try
            If txtss.Text = "Non Teaching Staff" Then
            Else
                txtclass.DataSource = New BindingSource(ShowData("select * from class where sid = '" & sid & "'"), Nothing)
                txtclass.DisplayMember = "class_no"
            End If

        Catch ex As Exception
            showerror(ex.Message)
        End Try

        init()
        startcapture()
        If Not txtsid.Text = "" Then
            txtsid.ReadOnly = True
        Else
            txthd.Text = Now.Date
            dob.Text = Now.Date
        End If
        Try
            If Not txtsid.Text = "" Then
                con = New MySqlConnection(cs)
                cmd = New MySqlCommand("select image from staff where staff_id = '" + txtsid.Text + "' and sid ='" & sid & "' and image is not null", con)
                adp = New MySqlDataAdapter(cmd)
                tb = New DataTable
                adp.Fill(tb)
                If tb.Rows.Count > 0 Then
                    Dim fname As String = tb.Rows(0)(0).ToString

                    Dim spath As String
                    spath = stfpath & "\" & fname
                    If Directory.Exists(spath) Then
                        Dim cb1 = File.ReadAllBytes(spath)

                        Dim memlogo As New MemoryStream(cb1)

                        PictureBox1.Image = Image.FromStream(memlogo)
                    End If
                End If
                    cmddelete.Enabled = True
            End If
        Catch ex As Exception
            showerror(ex.Message)
        End Try

        If txtss.Text = "Non Teaching Staff" Then
            txtclass.Text = "None"
            txtsclass.Text = 0
            txtclass.ReadOnly = True
            txtsclass.ReadOnly = True
            txtsclass.Enabled = False
            txtclass.Enabled = False
        Else
            txtclass.ReadOnly = False
            txtsclass.ReadOnly = False
            txtsclass.Enabled = True
            txtclass.Enabled = True
        End If
        up = 0
        Dim age = Now.Date.Year - dob.Value.Year
        lblage.Text = "Age : " & age
    End Sub

    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete
        fingerprint(convertsample(Sample))
        Process(Sample)
    End Sub

    Private Sub addstaff_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        stopcapture()
    End Sub

    Private Sub txtss_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles txtss.SelectedIndexChanged
        If txtss.Text = "Non Teaching Staff" Then
            txtclass.Text = "None"
            txtclass.ReadOnly = True
            txtsclass.ReadOnly = True
            txtsclass.Enabled = False
            txtclass.Enabled = False
        Else
            txtclass.ReadOnly = False
            txtsclass.ReadOnly = False
            txtsclass.Enabled = True
            txtclass.Enabled = True
            txtclass.DataSource = New BindingSource(ShowData("select * from class"), Nothing)
            txtclass.DisplayMember = "class_no"
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub txtclass_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles txtclass.SelectedIndexChanged
        If up = 0 Then
            Try
                Me.Cursor = Cursors.WaitCursor
                txtsclass.Items.Clear()
                con = New MySqlConnection(cs)
                cmd = New MySqlCommand("select s_class from subclass where class = '" + txtclass.Text + "'  and sid ='" & sid & "' group by s_class", con)
                adp = New MySqlDataAdapter(cmd)
                tb2 = New DataTable
                adp.Fill(tb2)
                If tb2.Rows.Count > 0 Then
                    For i As Integer = 0 To tb2.Rows.Count - 1
                        Dim c As Integer = record_count("select * from staff where classes = '" + tb2.Rows(i)(0).ToString + "' and sid ='" & sid & "'")
                        If c < 1 Then
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
                cmd = New MySqlCommand("select s_class from subclass where class = '" + txtclass.Text + "' and sid ='" & sid & "'  group by s_class", con)
                adp = New MySqlDataAdapter(cmd)
                tb2 = New DataTable
                adp.Fill(tb2)
                If tb2.Rows.Count > 0 Then
                    For i As Integer = 0 To tb2.Rows.Count - 1
                        Dim c As Integer = record_count("select * from staff where classes = '" + tb2.Rows(i)(0).ToString + "' and sid ='" & sid & "'")
                        If c < 1 Then
                            txtsclass.Items.Add(tb2.Rows(i)(0).ToString)
                        End If
                    Next
                End If
                Me.Cursor = Cursors.Default
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub cmdclear_Click(sender As Object, e As EventArgs) Handles cmdclear.Click
        Clear(Me)
        up = 0
    End Sub

    Private Sub dob_ValueChanged(sender As Object, e As EventArgs) Handles dob.ValueChanged
        Dim age = Now.Date.Year - dob.Value.Year
        lblage.Text = "Age : " & age
        lblage.Visible = True
    End Sub

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone
    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch
    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect
    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect
    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality
    End Sub
End Class