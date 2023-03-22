Public Class addmarks
    Dim ex As Double = 0
    Dim mid As Double = 0
    Dim exam As Double = 0
    Dim assessment As Double
    Dim assessment_percentage As Double
    Dim examsp As Double
    Dim exams_percentage As Double
    Dim d_grade As String
    Dim ed As Integer = 0

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub


    Private Sub addmarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
        ecadd.Enabled = False
        madd.Enabled = False
        eadd.Enabled = False
        cadd.Enabled = False
        cmdedit.Enabled = False
        Try
            If ul = "6" Then
                txtsubject.DataSource = New BindingSource(ShowData("select * from subject_allocation where Staff_ID = '" & staffid & "' and sid = '" & sid & "' group by Subject"), Nothing)
                txtsubject.DisplayMember = "Subject"
                txtsubject.Items.Add("")

                txtssearch.DataSource = New BindingSource(ShowData("select * from subject_allocation where Staff_ID = '" & staffid & "' and sid= '" & sid & "' group by Subject"), Nothing)
                txtssearch.DisplayMember = "Subject"
                txtssearch.Items.Add("")
            Else
                txtsubject.DataSource = New BindingSource(ShowData("select * from subject_allocation where  sid = '" & sid & "' group by Subject"), Nothing)
                txtsubject.DisplayMember = "Subject"
                txtsubject.Items.Add("")

                txtssearch.DataSource = New BindingSource(ShowData("select * from subject_allocation where  sid= '" & sid & "' group by Subject"), Nothing)
                txtssearch.DisplayMember = "Subject"
                txtssearch.Items.Add("")

            End If
            txtacademic.DataSource = New BindingSource(ShowData("select * from academic_year   where sid ='" & sid & "' group by academic order by academic  DESC"), Nothing)
            txtacademic.DisplayMember = "academic"
            txtacademic.Items.Add("")

            txtnsearch.DataSource = New BindingSource(ShowData("select * from marks where sid = '" & sid & "' group by Name"), Nothing)
            txtnsearch.DisplayMember = "Name"
            txtnsearch.Items.Add("")

        Catch ex As Exception
            showerror(ex.Message)
        End Try
        tb = New DataTable
        tb = ShowData("select * from d_grade where status = '1' and sid = '" & sid & "'")
        If tb.Rows.Count > 0 Then
            d_grade = tb.Rows(0)(0).ToString
            assessment = tb.Rows(0)(1).ToString
            assessment_percentage = tb.Rows(0)(2).ToString
            examsp = tb.Rows(0)(3).ToString
            exams_percentage = tb.Rows(0)(4).ToString
        Else
            Home.Button3.PerformClick()
            showerror("Please go to 'Assessment' and input the overall marks total and its corresponding percentage!")
        End If
        RadButton1.Visible = False
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub txtmsname_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles txtmsname.SelectedIndexChanged
        Txtstid.Text = getValue("select student_id from student where fullname = '" + txtmsname.Text + "' and status = 'Active' and sid ='" & sid & "'")
        If Txtstid.Text = "" Then
            ecadd.Enabled = False
            madd.Enabled = False
            eadd.Enabled = False
            cadd.Enabled = False
        Else
            ecadd.Enabled = True
            madd.Enabled = True
            eadd.Enabled = True
            cadd.Enabled = True
        End If
    End Sub

    Private Sub txtsubject_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles txtsubject.SelectedIndexChanged
        If ed = 0 Then
            Try
                If ul = "6" Then
                    txtmclass.DataSource = New BindingSource(ShowData("select * from subject_allocation where Subject ='" + txtsubject.Text + "'and Staff_ID='" & staffid & "' and sid ='" & sid & "'"), Nothing)
                    txtmclass.DisplayMember = "Allocation"
                    txtmclass.Items.Add("")
                Else
                    txtmclass.DataSource = New BindingSource(ShowData("select * from subject_allocation where Subject ='" + txtsubject.Text + "'and  sid ='" & sid & "'"), Nothing)
                    txtmclass.DisplayMember = "Allocation"
                    txtmclass.Items.Add("")

                End If
            Catch ex As Exception
                showerror(ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtsubject_TextChanged(sender As Object, e As EventArgs) Handles txtsubject.TextChanged
        If ed = 0 Then
            Try
                If ul = "6" Then
                    txtmclass.DataSource = New BindingSource(ShowData("select * from subject_allocation where Subject ='" + txtsubject.Text + "'and Staff_ID='" & staffid & "' and sid ='" & sid & "'"), Nothing)
                    txtmclass.DisplayMember = "Allocation"
                    txtmclass.Items.Add("")
                Else
                    txtmclass.DataSource = New BindingSource(ShowData("select * from subject_allocation where Subject ='" + txtsubject.Text + "'and  sid ='" & sid & "'"), Nothing)
                    txtmclass.DisplayMember = "Allocation"
                    txtmclass.Items.Add("")
                End If
            Catch ex As Exception
                showerror(ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtmclass_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles txtmclass.SelectedIndexChanged
        If ed = 0 Then
            Try
                txtmsname.Text = ""
                txtmsname.DataSource = New BindingSource(ShowData("select * from student where class='" + txtmclass.Text + "' and status='Active'  and sid ='" & sid & "' and  student_id  not in (select Student_ID from marks where Subject = '" + txtsubject.Text + "' and academic='" & academic_year & "' and term='" & term & "' and sid = '" & sid & "') order by fullname DESC"), Nothing)
                txtmsname.DisplayMember = "fullname"
                txtmsname.Items.Add("")
            Catch ex As Exception
                showerror(ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtmclass_TextChanged(sender As Object, e As EventArgs) Handles txtmclass.TextChanged
        If ed = 0 Then
            Try
                txtmsname.Text = ""
                txtmsname.DataSource = New BindingSource(ShowData("select * from student where class='" + txtmclass.Text + "' and status='Active' and sid = '" & sid & "' and  student_id  not in (select Student_ID from marks where Subject = '" + txtsubject.Text + "' and academic='" & academic_year & "' and term='" & term & "' and sid = '" & sid & "') order by fullname DESC"), Nothing)
                txtmsname.DisplayMember = "fullname"
                txtmsname.Items.Add("")
            Catch ex As Exception
                showerror(ex.Message)
            End Try
        End If
    End Sub

    Private Sub cadd_Click(sender As Object, e As EventArgs) Handles cadd.Click
        Try
            If txtectotal.Text = 0 Or txtetotal.Text = 0 Then
                showerror("Please enter the various marks acquired by the student and select the term")
                Exit Sub
            ElseIf txtsubject.Text = "" Or txtmsname.Text = "" Or Txtstid.Text = "" Then
                showerror("Please select the student and subject to enter the marks")
                Exit Sub
            Else
                Me.Cursor = Cursors.WaitCursor
                Dim ex_percent As Integer = 0
                Dim exams_percent As Integer = 0
                Dim got As Double = 0
                Dim total As Integer = 0
                Dim tb2 As New DataTable
                got = Val(txtectotal.Text) + Val(txtmtotal.Text)
                ex_percent = (got / assessment) * assessment_percentage
                exams_percent = (exam / examsp) * exams_percentage
                total = ex_percent + exams_percent
                tb2 = ShowData("select * from grading where lower_limit <= '" & total & "' and upper_limit >= '" & total & "' and sid= '" & sid & "'")
                If ed = 0 Then
                    execute("INSERT INTO `marks`( `Student_ID`, `Name`, `Subject`, `Class_Score`, `Exams_Score`, `Total`, `Remark`, `Academic`, `Term`,`d_grade`,`Class`,`sid`,`Grading`) VALUES ('" & Txtstid.Text & "','" & txtmsname.Text & "','" & txtsubject.Text & "','" & ex_percent & "','" & exams_percent & "','" & total & "','" & tb2.Rows(0)("remark").ToString & "','" & academic_year & "','" & term & "','" & d_grade & "','" + txtmclass.Text + "','" & sid & "','" & tb2.Rows(0)("letter_grade").ToString & "')", 3)
                    lblresult.Text = "Name: " & txtmsname.Text & vbCrLf & "Subject: " & txtsubject.Text & vbCrLf & "Class Assessment: " & ex_percent & "%" & vbCrLf & "Exams: " & exams_percent & "%" & vbCrLf & "Total: " & total & "%" & vbCrLf & "Remark: " & tb2.Rows(0)("remark").ToString & vbCrLf & "Grading: " & tb2.Rows(0)("letter_grade").ToString
                    ex = 0
                    mid = 0
                    exam = 0
                    txtmcount.Text = 0
                    txtmtotal.Text = 0
                    txteccount.Text = 0
                    txtectotal.Text = 0
                    txtmcount.Text = 0
                    txtecount.Text = 0
                    txtetotal.Text = 0
                    Dim c As Integer = record_count("select * from grade where Student_Name='" + txtmsname.Text + "' and Academic='" & academic_year & "' and Term='" & term & "' and Class ='" + txtmclass.Text + "' and sid = '" & sid & "'")
                    If c < 1 Then
                        execute("insert into grade(Student_ID,Student_Name,Academic,Term,Class,sid) values ('" & Txtstid.Text & "','" & txtmsname.Text & "','" & academic_year & "','" & term & "','" + txtmclass.Text + "','" & sid & "')", 3)
                    End If
                    Try
                        txtmsname.Text = ""
                        txtmsname.DataSource = New BindingSource(ShowData("select * from student where class='" + txtmclass.Text + "' and status='Active' and sid = '" & sid & "' and student_id not in (select Student_ID from marks where Subject = '" + txtsubject.Text + "' and academic='" & academic_year & "' and term='" & term & "' and sid = '" & sid & "')"), Nothing)
                        txtmsname.DisplayMember = "fullname"
                    Catch ex As Exception
                        showerror(ex.Message)
                    End Try
                Else
                    execute("update marks set Class_Score='" & ex_percent & "', Exams_Score='" & exams_percent & "', Total='" & total & "',Remark='" & tb2.Rows(0)("remark").ToString & "',Grading= '" & tb2.Rows(0)("letter_grade").ToString & "' where ID = '" & Txtstid.Text & "' and sid ='" & sid & "'", 1)
                    RadButton1.PerformClick()
                End If
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            showerror(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ecadd_Click(sender As Object, e As EventArgs) Handles ecadd.Click
        If txtecmarks.Text = "" Then
            showerror("Please enter the marks of the student!")
            Exit Sub
        Else
            ex = ex + txtecmarks.Text
            txteccount.Text = txteccount.Text + 1
            txtectotal.Text = ex
            txtecmarks.Clear()
            ErrorProvider1.Clear()
            txtecmarks.Focus()
        End If
    End Sub

    Private Sub txtecmarks_TextChanged(sender As Object, e As EventArgs) Handles txtecmarks.TextChanged
        If Not IsNumeric(txtecmarks.Text) Then
            ErrorProvider1.SetError(txtecmarks, "Please input must be numbers only!")
            txtecmarks.Clear()
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtecmarks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtecmarks.KeyPress
        If e.KeyChar = Chr(13) Then
            ecadd.PerformClick()
            txtecmarks.Focus()
        End If
    End Sub

    Private Sub txtmmarks_TextChanged(sender As Object, e As EventArgs) Handles txtmmarks.TextChanged
        If Not IsNumeric(txtmmarks.Text) Then
            ErrorProvider1.SetError(txtmmarks, "Please input must be numbers only!")
            txtmmarks.Clear()
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtmmarks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmmarks.KeyPress
        If e.KeyChar = Chr(13) Then
            madd.PerformClick()
            txtmmarks.Focus()
        End If
    End Sub

    Private Sub madd_Click(sender As Object, e As EventArgs) Handles madd.Click
        If txtmmarks.Text = "" Then
            showerror("Please enter the marks of the student!")
            Exit Sub
        Else
            mid = mid + txtmmarks.Text
            txtmcount.Text = txtmcount.Text + 1
            txtmtotal.Text = mid
            txtmmarks.Clear()
            ErrorProvider1.Clear()
            txtmmarks.Focus()
        End If
    End Sub

    Private Sub ecclear_Click(sender As Object, e As EventArgs) Handles ecclear.Click
        txteccount.Text = 0
        txtectotal.Text = 0
        ex = 0
    End Sub

    Private Sub mclear_Click(sender As Object, e As EventArgs) Handles mclear.Click
        txtmcount.Text = 0
        txtmtotal.Text = 0
        mid = 0
    End Sub

    Private Sub eadd_Click(sender As Object, e As EventArgs) Handles eadd.Click
        If txtemark.Text = "" Then
            showerror("Please enter the marks of the student!")
            Exit Sub
        Else
            exam = exam + txtemark.Text
            txtecount.Text = txtecount.Text + 1
            txtetotal.Text = exam
            txtemark.Clear()
            ErrorProvider1.Clear()
            txtemark.Focus()
        End If
    End Sub

    Private Sub eclear_Click(sender As Object, e As EventArgs) Handles eclear.Click
        txtecount.Text = 0
        txtetotal.Text = 0
        exam = 0
    End Sub

    Private Sub txtemark_TextChanged(sender As Object, e As EventArgs) Handles txtemark.TextChanged
        If Not IsNumeric(txtemark.Text) Then
            ErrorProvider1.SetError(txtemark, "Please enter the marks of the student!")
            txtemark.Clear()
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtemark_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtemark.KeyPress
        If e.KeyChar = Chr(13) Then
            eadd.PerformClick()
            txtemark.Focus()
        End If
    End Sub

    Private Sub txtmsname_TextChanged(sender As Object, e As EventArgs) Handles txtmsname.TextChanged
        Txtstid.Text = getValue("select student_id from student where fullname = '" + txtmsname.Text + "' and status = 'Active' and sid ='" & sid & "'")
        If Txtstid.Text = "" Then
            ecadd.Enabled = False
            madd.Enabled = False
            eadd.Enabled = False
            cadd.Enabled = False
        Else
            ecadd.Enabled = True
            madd.Enabled = True
            eadd.Enabled = True
            cadd.Enabled = True
        End If
    End Sub

    Private Sub cmdsearch_Click(sender As Object, e As EventArgs) Handles cmdsearch.Click
        If txtnsearch.Text = "" Or txtssearch.Text = "" Or txtacademic.Text = "" Or txtterm.Text = "" Then
            showerror("Please fill in all the empty!")
            Exit Sub
        Else
            tb = New DataTable
            tb = ShowData("select * from marks where Name='" + txtnsearch.Text + "' and Subject='" + txtssearch.Text + "' and Academic='" & txtacademic.Text & "' and Term = '" + txtterm.Text + "' and sid= '" & sid & "'")
            If tb.Rows.Count > 0 Then
                lblresult.Text = "Name: " & tb.Rows(0)(2).ToString & vbCrLf & "Subject: " & tb.Rows(0)(3).ToString & vbCrLf & "Class Assessment: " & tb.Rows(0)(4).ToString & "%" & vbCrLf & "Exams: " & tb.Rows(0)(5).ToString & "%" & vbCrLf & "Total: " & tb.Rows(0)(6).ToString & "%" & vbCrLf & "Remark: " & tb.Rows(0)(7).ToString & vbCrLf & "Grading: " & tb.Rows(0)("Grading").ToString
                cmdedit.Enabled = True
            Else
                showerror("No record Found!")
            End If
        End If
    End Sub

    Private Sub cmdclear_Click(sender As Object, e As EventArgs)
        txtnsearch.Text = ""
        txtssearch.Text = ""
        txtacademic.Text = ""
        txtterm.Text = ""
    End Sub

    Private Sub cmddelete_Click(sender As Object, e As EventArgs) Handles cmddelete.Click
        Dialog1.Label1.Text = "Are you sure you want to delete a record with Student Name: " + txtnsearch.Text
        Dialog1.ShowDialog()
        If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
            querryString = "delete from marks  where Name = '" + txtnsearch.Text + "' and subject ='" + txtssearch.Text + "' and academic= '" + txtacademic.Text + "' and term = '" + txtterm.Text + "' and sid ='" & sid & "'"
            execute(querryString, 2)
            Try
                txtmsname.Text = ""
                txtmsname.DataSource = New BindingSource(ShowData("select * from student where class='" + txtmclass.Text + "' and status='Active' and sid ='" & sid & "' and student_id not in (select Student_ID from marks where Subject = '" + txtsubject.Text + "' and academic='" & academic_year & "' and term='" & term & "' and sid = '" & sid & "')"), Nothing)
                txtmsname.DisplayMember = "fullname"
            Catch ex As Exception
                showerror(ex.Message)
            End Try
        End If
    End Sub

    Private Sub cmdedit_Click(sender As Object, e As EventArgs) Handles cmdedit.Click
        Try
            tb3 = New DataTable
            tb3 = ShowData("select * from marks where Name='" + txtnsearch.Text + "' and Subject='" + txtssearch.Text + "' and Academic='" & txtacademic.Text & "' and Term = '" + txtterm.Text + "' and sid ='" & sid & "'")
            tb2 = New DataTable

            tb2 = ShowData("select * from d_grade where id = '" & tb3.Rows(0)("d_grade").ToString & "' and sid ='" & sid & "'")
            If tb2.Rows.Count > 0 Then
                d_grade = tb2.Rows(0)(0).ToString
                assessment = tb2.Rows(0)(1).ToString
                assessment_percentage = tb2.Rows(0)(2).ToString
                examsp = tb2.Rows(0)(3).ToString
                exams_percentage = tb2.Rows(0)(4).ToString
                ed = 1
                txtacademic.Enabled = False
                txtterm.Enabled = False
                txtsubject.Text = tb3.Rows(0)(3).ToString
                txtmclass.Text = tb3.Rows(0)(11).ToString
                txtmsname.Text = txtnsearch.Text
                Txtstid.Text = tb3.Rows(0)(0).ToString
                txtsubject.ReadOnly = True
                txtmsname.ReadOnly = True
                txtmclass.ReadOnly = True
                RadButton1.Visible = True
            Else
                showerror("This assesment can not modified because the gradepoint used to calculate it was not found in the record. This may be resulted by deletion of the record.")
            End If
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        txtacademic.Enabled = True
        txtterm.Enabled = True
        txtsubject.ReadOnly = False
        txtmsname.ReadOnly = False
        txtmclass.ReadOnly = False
        txtnsearch.Text = ""
        txtssearch.Text = ""
        txtacademic.Text = ""
        txtterm.Text = ""
        Txtstid.Text = ""
        ed = 0
        Try
            If ul = "6" Then
                txtmclass.DataSource = New BindingSource(ShowData("select * from subject_allocation where Subject ='" + txtsubject.Text + "'and Staff_ID='" & staffid & "' and sid ='" & sid & "'"), Nothing)
                txtmclass.DisplayMember = "Allocation"
            Else
                txtmclass.DataSource = New BindingSource(ShowData("select * from subject_allocation where Subject ='" + txtsubject.Text + "'and sid ='" & sid & "'"), Nothing)
                txtmclass.DisplayMember = "Allocation"
            End If
        Catch ex As Exception
            showerror(ex.Message)
        End Try
        tb = New DataTable
        tb = ShowData("select * from d_grade where status = '1' and sid ='" & sid & "'")
        If tb.Rows.Count > 0 Then
            d_grade = tb.Rows(0)(0).ToString
            assessment = tb.Rows(0)(1).ToString
            assessment_percentage = tb.Rows(0)(2).ToString
            examsp = tb.Rows(0)(3).ToString
            exams_percentage = tb.Rows(0)(4).ToString
        Else
            Home.Button3.PerformClick()
            showerror("Please go to 'Assessment' and input the overall marks total and its corresponding percentage!")
        End If
        RadButton1.Visible = False
    End Sub

    Private Sub addmarks_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Cursor = Cursors.Default
    End Sub
End Class