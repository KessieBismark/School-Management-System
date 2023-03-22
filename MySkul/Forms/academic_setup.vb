Imports MySql.Data.MySqlClient
Public Class classroom
    Dim Tot_rows As Integer
    Dim PROgres_count As Integer
    Dim sasearch As String = "SELECT  `Staff_ID`, `Subject`, `Allocation`, `sid` FROM `subject_allocation` WHERE  sid = '" & sid & "' and CONCAT(Staff_ID,Subject,Allocation)"
    Dim actexams As String = "SELECT `id` as ID, `examid` as Exams_ID, `subject` as Subject, `class` as Class, `start` as Start, `end` as End, `term`as Term, `academic`as Academic, `date` as Date FROM `exams` WHERE sid = '" & sid & "' and CONCAT(examid,subject,start,end,term,academic,date)"
    Dim actevent As String = "SELECT `id` as ID, `eventid` as Event_ID, `term` as Term, `academic` as Academic, `start` as Start, `end` as End, `ename` as Event_Name, `comment` as Comment FROM `events` WHERE sid = '" & sid & "' and CONCAT( `eventid`, `term`, `academic`, `start`, `end`, `ename`, `comment`)"
    Dim all0_search As String = "select subject_allocation.Staff_ID as Staff_ID,staff.fullname as Staff_Name,subject_allocation.Subject as Subject,subject_allocation.Allocation as Allocation from subject_allocation inner join staff where subject_allocation.sid='" & sid & "' and staff.sid='" & sid & "'and subject_allocation.Staff_ID = staff.staff_id  and CONCAT(subject_allocation.Staff_ID,subject_allocation.Subject,subject_allocation.Allocation,staff.fullname)"
    Private Sub RadButton1_Click(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Dim sb As New updateexpenses
        sb.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Dim cl As New addincome
        cl.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

#Region "diplay records in grid view"
    Sub subject_bindgrid()
        querryString = "select subject_id as Subject_ID, subject_name as Subject_Name,abbreviation as Short_Name from subject_table where sid = '" & sid & "'"
        subjectgrid.DataSource = ShowData(querryString)

        Try
            Me.subjectgrid.BestFitColumns()
            Me.subjectgrid.Columns("Subject_ID").Width = 100
            Me.subjectgrid.Columns("Subject_Name").Width = 400
            Me.subjectgrid.Columns("Short_Name").Width = 100
            For i As Integer = 0 To Me.subjectgrid.ColumnCount - 1
                Me.subjectgrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Sub grade_bindgrid()
        querryString = "select grade_id as Grade_ID, lower_limit as Lower_Limit,upper_limit as Upper_Limit,letter_grade as Letter_Grade,remark as Remark from grading  where sid = '" & sid & "' order by upper_limit DESC"
        gradegrid.DataSource = ShowData(querryString)

        Try
            Me.gradegrid.BestFitColumns()
            For i As Integer = 0 To Me.gradegrid.ColumnCount - 1
                Me.gradegrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
    Sub class_bindgrid()
        querryString = "select class_no as Class_Number, class_name as Class_Name,fees as Fee from class where sid= '" & sid & "'order by class_no ASC"
        classgrid.DataSource = ShowData(querryString)

        Try
            Me.classgrid.BestFitColumns()
            Me.classgrid.Columns("Class_Number").Width = 150
            Me.classgrid.Columns("Class_Name").Width = 400
            Me.classgrid.Columns("Fee").Width = 100
            For i As Integer = 0 To Me.classgrid.ColumnCount - 1
                Me.classgrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
    Sub attitude_bindgrid()
        querryString = "select Attitude as Attitude from attitude where sid ='" & sid & "'"
        attgrid1.DataSource = ShowData(querryString)
        Try
            Me.attgrid1.BestFitColumns()
            Me.attgrid1.Columns("Attitude").Width = 600
            For i As Integer = 0 To Me.attgrid1.ColumnCount - 1
                Me.attgrid1.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
    Sub allo_bindgrid()
        querryString = "select subject_allocation.Staff_ID as Staff_ID,staff.fullname as Staff_Name,subject_allocation.Subject as Subject,subject_allocation.Allocation as Allocation from subject_allocation inner join staff where subject_allocation.sid='" & sid & "' and staff.sid='" & sid & "'and subject_allocation.Staff_ID = staff.staff_id  order by subject_allocation.Allocation ASC "
        allogrid.DataSource = ShowData(querryString)
        Try
            Me.allogrid.BestFitColumns()
            Me.allogrid.Columns("Staff_ID").Width = 80
            Me.allogrid.Columns("Staff_Name").Width = 200
            Me.allogrid.Columns("Subject").Width = 200
            Me.allogrid.Columns("Allocation").Width = 100
            For i As Integer = 0 To Me.allogrid.ColumnCount - 1
                Me.allogrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
    Sub dgrade_bindgrid()
        querryString = "select id as ID, assessment as Assessment, assessment_p as Assessment_Percentage,exams as Exams,exams_p as Exams_Percentage,cut_off as Cut_Off_Point,status as Status from d_grade where sid ='" & sid & "' order by status"
        dgrid.DataSource = ShowData(querryString)
        Try
            Me.dgrid.BestFitColumns()
            For i As Integer = 0 To Me.dgrid.ColumnCount - 1
                Me.dgrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
    Sub subclass_bindgrid()
        querryString = "select  s_class as Sub_Class, class as Class,max_students as Max_Students from subclass where sid = '" & sid & "' group by Sub_Class"
        subclassgrid.DataSource = ShowData(querryString)
        Try
            Me.subclassgrid.BestFitColumns()
            Me.subclassgrid.Columns("Sub_class").Width = 100
            Me.subclassgrid.Columns("Class").Width = 100
            Me.subclassgrid.Columns("Max_Students").Width = 100
            For i As Integer = 0 To Me.subclassgrid.ColumnCount - 1
                Me.subclassgrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Sub academic_bindgrid()
        querryString = "select  academic as Year, term as Term,term_starts as Term_Start,term_ends as Term_End,next_term as Next_Term,days as Duration from academic_year where sid = '" & sid & "' order by Year"
        academicgrid.DataSource = ShowData(querryString)
        Try
            Me.academicgrid.BestFitColumns()
            Me.academicgrid.Columns("Year").Width = 120
            Me.academicgrid.Columns("Term").Width = 50
            Me.academicgrid.Columns("Term_Start").Width = 150
            Me.academicgrid.Columns("Term_End").Width = 150
            Me.academicgrid.Columns("Next_Term").Width = 150
            Me.academicgrid.Columns("Duration").Width = 100
            For i As Integer = 0 To Me.academicgrid.ColumnCount - 1
                Me.academicgrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Sub exams_bindgrid()
        querryString = "select examid as Exam_ID, subject as Subject,class as Class,start as Start_time,end as End_time,term as Term,academic as Academic,date As Date from exams where sid ='" & sid & "'"
        examsview.DataSource = ShowData(querryString)
        Try
            Me.examsview.BestFitColumns()
            Me.examsview.Columns("Exam_ID").Width = 100
            Me.examsview.Columns("Subject").Width = 300
            Me.examsview.Columns("Class").Width = 50
            Me.examsview.Columns("Start_time").Width = 100
            Me.examsview.Columns("End_time").Width = 100
            Me.examsview.Columns("Term").Width = 100
            Me.examsview.Columns("Academic").Width = 100
            Me.examsview.Columns("Date").Width = 100
            For i As Integer = 0 To Me.examsview.ColumnCount - 1
                Me.examsview.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Sub event_bindgrid()
        querryString = "select eventid as Event_ID, ename as Event_Name,comment as Comment,start as Start_date,end as End_date,term as Term,academic as Academic from events where sid = '" & sid & "'"
        eventview.DataSource = ShowData(querryString)
        Try
            Me.eventview.BestFitColumns()
            Me.eventview.Columns("Event_ID").Width = 100
            Me.eventview.Columns("Event_Name").Width = 200
            Me.eventview.Columns("Comment").Width = 400
            Me.eventview.Columns("Start_date").Width = 100
            Me.eventview.Columns("End_date").Width = 100
            Me.eventview.Columns("Term").Width = 50
            Me.eventview.Columns("Academic").Width = 100
            For i As Integer = 0 To Me.eventview.ColumnCount - 1
                Me.eventview.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
#End Region
    Private Sub classroom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        subject_bindgrid()
        class_bindgrid()
        subclass_bindgrid()
        academic_bindgrid()
        exams_bindgrid()
        event_bindgrid()
        gdelete.Enabled = False
        grade_bindgrid()
        deleteatt.Enabled = False
        dgrade_bindgrid()
        attitude_bindgrid()
        allo_bindgrid()
        txttstart.Text = Now.Date
        txttend.Text = Now.Date
        txtnterm.Text = Now.Date
        cmdactivate.Enabled = False
        txtclass.DataSource = New BindingSource(ShowData("select * from class where sid='" & sid & "'"), Nothing)
        txtclass.DisplayMember = "class_no"
        txtclass.Items.Add("")

        txtcp.DataSource = New BindingSource(ShowData("select * from subclass where sid='" & sid & "' order by s_class ASC"), Nothing)
        txtcp.DisplayMember = "s_class"
        txtcp.Items.Add("")

        If ul = "3" Then
            TabPage4.Enabled = False
            TabPage8.Enabled = False
        End If
    End Sub

    Private Sub cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        If txtss.Text = "" Or txtsn.Text = "" Or txtsid.Text = "" Then
            showerror("Please do not leave any field empty!")
            Exit Sub
        Else
            txtsn.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtsn.Text)
            txtss.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtss.Text)
            Dim c As Integer = record_count("select * from subject_table where subject_id = '" + txtsid.Text + "' or subject_name='" + txtsn.Text + "' or abbreviation='" + txtss.Text + "' and sid ='" & sid & "'")
            If c > 0 Then
                showerror("Record already exist in the database!")
                Exit Sub
            Else
                querryString = "insert into subject_table(subject_id,subject_name,abbreviation,sid) values('" + txtsid.Text + "','" + txtsn.Text + "','" + txtss.Text + "','" & sid & "') "
                execute(querryString, 0)
                Clear(Me)
                subject_bindgrid()
            End If
        End If
    End Sub

    Private Sub cmdclear_Click(sender As Object, e As EventArgs) Handles cmdclear.Click
        Clear(Me)
    End Sub

    Private Sub cmddelete_Click(sender As Object, e As EventArgs) Handles cmddelete.Click
        If txtsubjectid.Text = "" Then
            showerror("No record selected. Please select the record you want to delete")
        Else
            Dialog1.Label1.Text = "Are you sure you want to delete a record with Subject ID: " + txtsubjectid.Text
            Dialog1.ShowDialog()
            If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                execute("delete from subject_table where subject_id = '" + txtsubjectid.Text + "' and sid ='" & sid & "'", 2)
                subject_bindgrid()
                Clear(Me)
            End If
        End If
    End Sub

    Private Sub RadGridView2_Click(sender As Object, e As EventArgs) Handles subjectgrid.Click
        Try
            txtsubjectid.Text = subjectgrid.CurrentRow.Cells(0).Value.ToString
            txtsid.Text = subjectgrid.CurrentRow.Cells(0).Value.ToString
            txtsn.Text = subjectgrid.CurrentRow.Cells(1).Value.ToString
            txtss.Text = subjectgrid.CurrentRow.Cells(2).Value.ToString
        Catch ex As Exception
        End Try
    End Sub



    Private Sub RadButton1_Click_1(sender As Object, e As EventArgs) Handles cclear.Click
        Clear(Me)
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles cdelete.Click
        If Txtclassid.Text = "" Then
            showerror("No record selected. Please select the record you want to delete")
        Else
            Dialog1.Label1.Text = "Are you sure you want to delete a record of class number: " + Txtclassid.Text
            Dialog1.ShowDialog()
            If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                execute("delete from class where class_no = '" + Txtclassid.Text + "' and sid ='" & sid & "'", 2)
                class_bindgrid()
                Clear(Me)
            End If
        End If
    End Sub

    Private Sub csave_Click(sender As Object, e As EventArgs) Handles csave.Click
        If classno.Text = "" Or fee.Text = "" Or classname.Text = "" Then
            showerror("Please do not leave any field empty!")
            Exit Sub
        Else
            classname.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(classname.Text)
            Dim c As Integer = record_count("select * from class where class_no = '" + classno.Text + "' and sid = '" & sid & "'")
            If c > 0 Then
                If Txtclassid.Text = "" And Not classno.Text = "" Then
                    Dialog1.Label1.Text = "Class " + classno.Text + " record exist do you want to update it"
                ElseIf Not Txtclassid.Text = "" Then
                    Dialog1.Label1.Text = "Are you sure you want to update a record of class number: " + Txtclassid.Text
                End If
                Dialog1.ShowDialog()
                If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                    execute("update class set fees='" + fee.Text + "',class_name='" + classname.Text + "' where class_no='" + classno.Text + "' and sid = '" & sid & "'", 1)
                    Clear(Me)
                    class_bindgrid()
                    Exit Sub
                End If
            Else
                querryString = "insert into class(class_no,class_name,fees,sid) values('" + classno.Text + "','" + classname.Text + "','" + fee.Text + "','" & sid & "') "
                execute(querryString, 0)
                Clear(Me)
                class_bindgrid()
            End If
        End If
        Try
            txtclass.DataSource = New BindingSource(ShowData("select * from class where sid ='" & sid & "'order by class_no ASC"), Nothing)
            txtclass.DisplayMember = "class_no"
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub scadd_Click(sender As Object, e As EventArgs) Handles scadd.Click
        If txtclass.Text = "" Or txtsclass.Text = "" Or txtmstudents.Text = "" Then
            showerror("Please do not leave any field empty!")
            Exit Sub
        ElseIf Not numbers(txtmstudents.Text) Then
            showerror("Maximum students per a class must be a number")
            Exit Sub
            'ElseIf letters(txtsclass.Text) Then
            '    showerror("Sub class must be a letter only!")
            '    Exit Sub
        Else
            txtsclass.Text = txtclass.Text.Trim & " " & Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtsclass.Text.Trim)
            Dim c As Integer = record_count("select * from subclass where s_class = '" + txtsclass.Text + "' and sid ='" & sid & "'")
            If c > 0 Then
                If txtsalloid.Text = "" And Not txtsclass.Text = "" Then
                    Dialog1.Label1.Text = "Sub-class " + txtsclass.Text + " record exist do you want to update it"
                ElseIf Not txtsalloid.Text = "" Then
                    Dialog1.Label1.Text = "Are you sure you want to update a record of Sub-class number: " + txtsalloid.Text
                End If
                Dialog1.ShowDialog()
                If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                    execute("update subclass set s_class='" + txtsclass.Text + "',class='" + txtclass.Text + "',max_students='" + txtmstudents.Text + "' where id='" + txtsalloid.Text + "' and sid= '" & sid & "'", 1)
                    Clear(Me)
                    subclass_bindgrid()
                    Exit Sub
                End If
            Else
                querryString = "insert into subclass(s_class,class,max_students,sid) values('" + txtsclass.Text + "','" + txtclass.Text + "','" + txtmstudents.Text + "','" & sid & "') "
                execute(querryString, 0)
                Clear(Me)
                subclass_bindgrid()
            End If
        End If
        ErrorProvider1.Clear()
    End Sub

    Private Sub sclear_Click(sender As Object, e As EventArgs) Handles sclear.Click
        Clear(Me)
    End Sub

    Private Sub scdelete_Click(sender As Object, e As EventArgs) Handles scdelete.Click
        If txtsalloid.Text = "" Then
            showerror("No record selected. Please select the record you want to delete")
        Else
            Dialog1.Label1.Text = "Are you sure you want to delete a record of sub-class number: " + txtsalloid.Text
            Dialog1.ShowDialog()
            If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                execute("delete from subclass where id = '" + txtsalloid.Text + "' and sid ='" & sid & "'", 2)
                subclass_bindgrid()
                Clear(Me)
            End If
        End If
        ErrorProvider1.Clear()
    End Sub

    Private Sub aadd_Click(sender As Object, e As EventArgs) Handles aadd.Click
        If txtyear.Text = "" Or txtterm.Text = "" Or txttstart.Text = "" Or txtnterm.Text = "" Or txttstart.Text = "" Or txtdu.Text = "" Then
            showerror("Please do not leave any field empty!")
            Exit Sub
        ElseIf txtnterm.Value <= txttend.Value Then
            showerror("Next term date can not be late to Term end date!")
            Exit Sub
        ElseIf txttend.Value <= txttstart.Value Then
            showerror("Term start date can not be late to Term end date!!")
            Exit Sub
        ElseIf txttend.Value < Now.Date Or txtnterm.Value < Now.Date Then
            showerror("Please check term end and next term date it can not be late to today's date!")
            Exit Sub
        ElseIf Not numbers(txtdu.text) Then
            showerror("Input must not contain a letter!")
        Else
            Dim id As Integer = getnumber("select max(id) from academic_year")
            id = id + 1
            Dim c As Integer = record_count("select * from academic_year where academic = '" + txtyear.Text + "' and term = '" + txtterm.Text + "' and sid ='" & sid & "'")
            If c > 0 Then
                If txtdgid.Text = "" And Not txtyear.Text = "" Then
                    Dialog1.Label1.Text = "Academic year " + txtyear.Text + " with term " & txtterm.Text & " record exist do you want to update it"
                ElseIf Not txtdgid.Text = "" Then
                    Dialog1.Label1.Text = "Are you sure you want to update a record of academic of id : " + txtdgid.Text
                End If
                Dialog1.ShowDialog()
                If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                    execute("update academic_year set term_starts='" + txttstart.Value.ToString("yyy-MM-dd") + "',term_ends='" + txttend.Value.ToString("yyy-MM-dd") + "',next_term = '" + txtnterm.Value.ToString("yyy-MM-dd") + "',days='" & txtdu.Text & "' where academic='" + txtyear.Text + "' and term = '" + txtterm.Text + "' and sid = '" & sid & "'", 1)
                    Clear(Me)
                    ErrorProvider1.Clear()
                    academic_bindgrid()
                    Exit Sub
                End If
            Else
                querryString = "insert into academic_year(id,academic,term,term_starts,term_ends,next_term,days,sid) values('" & id & "','" + txtyear.Text + "','" + txtterm.Text + "','" + txttstart.Value.ToString("yyyy-MM-dd") + "','" + txttend.Value.ToString("yyyy-MM-dd") + "','" + txtnterm.Value.ToString("yyyy-MM-dd") + "','" & txtdu.Text & "','" & sid & "') "
                execute(querryString, 0)
                Clear(Me)
                ErrorProvider1.Clear()
                academic_bindgrid()
            End If
        End If
        SetAcademic()
    End Sub

    Private Sub aclear_Click(sender As Object, e As EventArgs) Handles aclear.Click
        Clear(Me)
        ErrorProvider1.Clear()
    End Sub

    Private Sub adelete_Click(sender As Object, e As EventArgs) Handles adelete.Click
        If txtdgid.Text = "" Then
            showerror("No record selected. Please select the record you want to delete")
        Else
            Dialog1.Label1.Text = "Are you sure you want to delete a record of class number: " + txtdgid.Text
            Dialog1.ShowDialog()
            If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                execute("delete from academic_year where class_no = '" + txtdgid.Text + "' and sid ='" & sid & "'", 2)
                academic_bindgrid()
                Clear(Me)
            End If
        End If
    End Sub

    Private Sub classgrid_Click(sender As Object, e As EventArgs) Handles classgrid.Click
        Try
            classno.Text = classgrid.CurrentRow.Cells(0).Value.ToString
            fee.Text = classgrid.CurrentRow.Cells(2).Value.ToString
            classname.Text = classgrid.CurrentRow.Cells(1).Value.ToString
            Txtclassid.Text = classgrid.CurrentRow.Cells(0).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub subclassgrid_Click(sender As Object, e As EventArgs) Handles subclassgrid.Click
        Try
            txtsalloid.Text = subclassgrid.CurrentRow.Cells(0).Value.ToString
            txtsclass.Text = subclassgrid.CurrentRow.Cells(1).Value.ToString
            txtclass.Text = subclassgrid.CurrentRow.Cells(2).Value.ToString
            txtmstudents.Text = subclassgrid.CurrentRow.Cells(3).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtmstudents_TextChanged(sender As Object, e As EventArgs) Handles txtmstudents.TextChanged
        If Not IsNumeric(txtmstudents.Text) Then
            ErrorProvider1.SetError(txtmstudents, "Please enter only numbers!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtsclass_TextChanged(sender As Object, e As EventArgs) Handles txtsclass.TextChanged
        If IsNumeric(txtsclass.Text) Then
            ErrorProvider1.SetError(txtsclass, "Please enter only letters!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtyear_TextChanged(sender As Object, e As EventArgs) Handles txtyear.TextChanged
        If Not letters(txtyear.Text) Then
            ErrorProvider1.SetError(txtyear, "Please enter only letters!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub academicgrid_Click(sender As Object, e As EventArgs) Handles academicgrid.Click
        Try
            txtdgid.Text = academicgrid.CurrentRow.Cells(0).Value.ToString
            txtyear.Text = academicgrid.CurrentRow.Cells(1).Value.ToString
            txtterm.Text = academicgrid.CurrentRow.Cells(2).Value.ToString
            txttstart.Text = academicgrid.CurrentRow.Cells(3).Value.ToString
            txttend.Text = academicgrid.CurrentRow.Cells(4).Value.ToString
            txtnterm.Text = academicgrid.CurrentRow.Cells(5).Value.ToString
            txtdu.Text = academicgrid.CurrentRow.Cells(6).Value.ToString
        Catch ex As Exception
        End Try
    End Sub


    Private Sub addexams_Click(sender As Object, e As EventArgs) Handles addexams.Click
        Dim ac As Integer = record_count("select * from academic_year where status= '1' and sid = '" & sid & "'")
        If ac < 1 Then
            showerror("Please go to academic year and register before you can make input here")
            Home.Button3.PerformClick()
        Else
            Me.Cursor = Cursors.WaitCursor
            Dim exams As New etimetable
            exams.ShowDialog()
            Me.Cursor = Cursors.Default
        End If
    End Sub


    Private Sub addevent_Click(sender As Object, e As EventArgs) Handles addevent.Click
        Dim ac As Integer = record_count("select * from academic_year where status= '1' and sid ='" & sid & "'")
        If ac < 1 Then
            showerror("Please go to academic year and register before you can make input here")
            Home.Button3.PerformClick()
        Else
            Me.Cursor = Cursors.WaitCursor
            Dim events As New eventsact
            events.ShowDialog()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub examsview_DoubleClick(sender As Object, e As EventArgs) Handles examsview.DoubleClick
        Try
            etimetable.eid.Text = examsview.CurrentRow.Cells(0).Value.ToString
            etimetable.txtsubject.Text = examsview.CurrentRow.Cells(1).Value.ToString
            etimetable.txtclass.Text = examsview.CurrentRow.Cells(2).Value.ToString
            etimetable.txtst.Text = examsview.CurrentRow.Cells(3).Value.ToString
            etimetable.txtet.Text = examsview.CurrentRow.Cells(4).Value.ToString
            etimetable.txtdate.Text = examsview.CurrentRow.Cells(6).Value.ToString
            etimetable.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub eventview_DoubleClick(sender As Object, e As EventArgs) Handles eventview.DoubleClick
        Try
            eventsact.txteid.Text = eventview.CurrentRow.Cells(0).Value.ToString
            eventsact.txteventname.Text = eventview.CurrentRow.Cells(1).Value.ToString
            eventsact.txtcom.Text = eventview.CurrentRow.Cells(2).Value.ToString
            eventsact.txtst.Text = eventview.CurrentRow.Cells(3).Value.ToString
            eventsact.txtet.Text = eventview.CurrentRow.Cells(4).Value.ToString
            eventsact.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        event_bindgrid()
        exams_bindgrid()
    End Sub

    Private Sub txtup_TextChanged(sender As Object, e As EventArgs) Handles txtup.TextChanged
        If Not IsNumeric(txtup.Text) Then
            ErrorProvider1.SetError(txtup, "Please enter only numbers!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtll_TextChanged(sender As Object, e As EventArgs) Handles txtll.TextChanged
        If Not IsNumeric(txtll.Text) Then
            ErrorProvider1.SetError(txtll, "Please enter only numbers!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub gsave_Click(sender As Object, e As EventArgs) Handles gsave.Click
        If txtup.Text = "" Or txtll.Text = "" Or txtlg.Text = "" Or txtr.Text = "" Then
            showerror("Please do not leave any field empty!")
            Exit Sub
        ElseIf Not numbers(txtup.Text) Or Not numbers(txtll.Text) Then
            showerror("Upper limit and lower limit grades must be numbers only!")
            Exit Sub
        ElseIf letters(txtr.Text) Then
            showerror("Please remoark input must be numbers only")
            Exit Sub
        Else
            Dim id As String = txtup.Text & txtll.Text
            Dim c As Integer = record_count("select * from grading where grade_id ='" & id & "' and sid ='" & sid & "'")
            txtr.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtr.Text)
            If c > 0 Then
                Dialog1.Label1.Text = "Record already exist in the database. Do you want to update it!"
                Dialog1.ShowDialog()
                If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                    execute("UPDATE `grading` SET `lower_limit`='" + txtll.Text + "',`upper_limit`='" + txtup.Text + "',`letter_grade`='" + txtlg.Text + "',`remark`='" + txtr.Text + "' WHERE grade_id ='" & id & "' and sid ='" & sid & "'", 1)
                    Clear(Me)
                    ErrorProvider1.Clear()
                End If
            Else
                execute("insert into grading(grade_id,lower_limit,upper_limit,letter_grade,remark,sid) values ('" & id & "','" + txtll.Text + "','" + txtup.Text + "','" + txtlg.Text + "','" + txtr.Text + "','" & sid & "')", 0)
                Clear(Me)
                ErrorProvider1.Clear()
            End If
        End If
        ErrorProvider1.Clear()
        grade_bindgrid()
        gdelete.Enabled = False
    End Sub

    Private Sub gradegrid_Click(sender As Object, e As EventArgs) Handles gradegrid.Click
        Try
            txtdgid.Text = gradegrid.CurrentRow.Cells(0).Value.ToString
            txtll.Text = gradegrid.CurrentRow.Cells(1).Value.ToString
            txtup.Text = gradegrid.CurrentRow.Cells(2).Value.ToString
            txtlg.Text = gradegrid.CurrentRow.Cells(3).Value.ToString
            txtr.Text = gradegrid.CurrentRow.Cells(4).Value.ToString
            If Not txtdgid.Text = "" Then
                gdelete.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub gdelete_Click(sender As Object, e As EventArgs) Handles gdelete.Click
        Dialog1.Label1.Text = "Are you sure you want to delete this record!"
        Dialog1.ShowDialog()
        If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
            execute("delete from grading WHERE grade_id ='" & txtdgid.Text & "' and sid ='" & sid & "'", 1)
            Clear(Me)
            ErrorProvider1.Clear()
            grade_bindgrid()
            gdelete.Enabled = False
        End If
    End Sub

    Private Sub gclear_Click(sender As Object, e As EventArgs) Handles gclear.Click
        Clear(Me)
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtasses_TextChanged(sender As Object, e As EventArgs) Handles txtasses.TextChanged
        If Not IsNumeric(txtasses.Text) Then
            ErrorProvider1.SetError(txtasses, "Please enter only numbers!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtassesp_TextChanged(sender As Object, e As EventArgs) Handles txtassesp.TextChanged
        If Not IsNumeric(txtassesp.Text) Then
            ErrorProvider1.SetError(txtassesp, "Please enter only numbers!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtexams_TextChanged(sender As Object, e As EventArgs) Handles txtexams.TextChanged
        If Not IsNumeric(txtexams.Text) Then
            ErrorProvider1.SetError(txtexams, "Please enter only numbers!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtexamsp_TextChanged(sender As Object, e As EventArgs) Handles txtexamsp.TextChanged
        If Not IsNumeric(txtexamsp.Text) Then
            ErrorProvider1.SetError(txtexamsp, "Please enter only numbers!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub RadButton3_Click_1(sender As Object, e As EventArgs) Handles RadButton3.Click
        Dim ac As Integer = record_count("select * from academic_year where status= '1' and sid ='" & sid & "'")
        If ac < 1 Then
            showerror("Please go to academic year and register before you can make input here")
            Home.Button3.PerformClick()
        Else
            If txtexams.Text = "" Or txtexamsp.Text = "" Or txtasses.Text = "" Or txtassesp.Text = "" Or cot.Text = "" Then
                showerror("Please do not leave any field empty!")
                Exit Sub
            ElseIf Not numbers(txtasses.Text) Or Not numbers(txtassesp.Text) Or Not numbers(txtexamsp.Text) Or Not numbers(txtexams.Text) Then
                showerror("All inputs must be numbers only!")
                Exit Sub
            Else
                Dim id As String = academic_year & "-" & term
                Dim c As Integer = record_count("select * from d_grade where id = '" & id & "' and sid ='" & sid & "'")
                If c > 0 Then
                    Dialog1.Label1.Text = "Record already exist in the database. Do you want to update it!"
                    Dialog1.ShowDialog()
                    If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                        execute("UPDATE `d_grade` SET `assessment`='" + txtasses.Text + "',`assessment_p`='" + txtassesp.Text + "',`exams`='" + txtexams.Text + "',`exams_p`='" + txtexamsp.Text + "',cut_off='" + cot.Text + "' WHERE id ='" & id & "' and sid = '" & sid & "'", 1)
                        Clear(Me)
                        ErrorProvider1.Clear()
                    End If
                Else
                    Dim id2 As String = getValue("select id from d_grade where status = '1' and sid ='" & sid & "'")
                    execute("update d_grade set status ='0' where id = '" & id2 & "'", 3)
                    execute("INSERT INTO `d_grade`(`id`, `assessment`, `assessment_p`, `exams`, `exams_p`,cut_off,sid) VALUES ('" & id & "','" + txtasses.Text + "','" + txtassesp.Text + "','" + txtexams.Text + "','" + txtexamsp.Text + "','" + cot.Text + "','" & sid & "')", 0)
                    Clear(Me)
                    ErrorProvider1.Clear()
                End If
            End If
            dgrade_bindgrid()
            cmdactivate.Enabled = False
        End If
    End Sub

    Private Sub RadButton2_Click_1(sender As Object, e As EventArgs) Handles cmdactivate.Click
        Try
            Dim id As String = getValue("select id from d_grade where status = '1' and sid = '" & sid & "'")
            execute("update d_grade set status ='0' where id = '" & id & "' and sid ='" & sid & "'", 3)
            execute("update d_grade set status ='1' where id = '" & txtdgid.Text & "' and sid ='" & sid & "'", 3)
            showinfo("Record with ID " & txtdgid.Text & " has been activated")
            cmdactivate.Enabled = False
            dgrade_bindgrid()
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub RadButton1_Click_2(sender As Object, e As EventArgs) Handles RadButton1.Click
        Clear(Me)
        ErrorProvider1.Clear()
        cmdactivate.Enabled = False
    End Sub

    Private Sub dgrid_Click(sender As Object, e As EventArgs) Handles dgrid.Click
        Try
            txtdgid.Text = dgrid.CurrentRow.Cells(0).Value.ToString
            txtasses.Text = dgrid.CurrentRow.Cells(1).Value.ToString
            txtassesp.Text = dgrid.CurrentRow.Cells(2).Value.ToString
            txtexams.Text = dgrid.CurrentRow.Cells(3).Value.ToString
            txtexamsp.Text = dgrid.CurrentRow.Cells(4).Value.ToString
            If Not txtdgid.Text = "" Then
                cmdactivate.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub



    Private Sub RadButton8_Click(sender As Object, e As EventArgs) Handles RadButton8.Click
        Dim ac As Integer = record_count("select * from staff where sid = '" & sid & "'")
        If ac < 1 Then
            showerror("Please go to Staff and register Workers before you can make input here")
            Home.Button10.PerformClick()
        Else
            Dim alo As New addsub_allocation
            alo.ShowDialog()
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        allo_bindgrid()
    End Sub

    Private Sub allogrid_DoubleClick(sender As Object, e As EventArgs) Handles allogrid.DoubleClick
        Try
            Dim allo As New addsub_allocation
            allo.txtcid.Text = allogrid.CurrentRow.Cells(1).Value.ToString
            allo.txtsubject.Text = allogrid.CurrentRow.Cells(2).Value.ToString
            allo.txtcclass.Text = allogrid.CurrentRow.Cells(3).Value.ToString
            allo.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub allogrid_Click(sender As Object, e As EventArgs) Handles allogrid.Click
        Try
            txtsalloid.Text = allogrid.CurrentRow.Cells(0).Value.ToString
        Catch ex As Exception
        End Try
    End Sub
    Private Sub RadButton2_Click_2(sender As Object, e As EventArgs) Handles RadButton2.Click
        If txtsalloid.Text = "" Then
            showerror("Please select a record to delete")
            Exit Sub
        Else
            Dialog1.Label1.Text = "Are you sure you want to delete this selected record"
            Dialog1.ShowDialog()
            If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                querryString = "delete from subject_allocation where ID = '" + txtsalloid.Text + "' and sid = '" & sid & "'"
                execute(querryString, 2)
                ErrorProvider1.Clear()
                allo_bindgrid()
            End If
        End If
    End Sub


    Private Sub cot_TextChanged(sender As Object, e As EventArgs) Handles cot.TextChanged
        If Not IsNumeric(cot.Text) Then
            ErrorProvider1.SetError(cot, "Please enter only numbers!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub RadButton6_Click(sender As Object, e As EventArgs) Handles RadButton6.Click
        If txtattitude1.Text = "" Then
            showerror("Please do not leave any field empty!")
            Exit Sub
        ElseIf txtattitude1.TextLength > 60 Then
            showerror("Entry must not be more than 50 characters!")
            Exit Sub
        ElseIf letters(txtattitude1.Text) Then
            showerror("Attitude input must not contain a number!")
            Exit Sub
        Else
            execute("insert into attitude(attitude,sid) values('" + UCase(txtattitude1.Text) + "','" & sid & "')", 0)
            attitude_bindgrid()
            Clear(Me)
            ErrorProvider1.Clear()
            RadButton5.Enabled = False
        End If
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles RadButton4.Click
        Clear(Me)
        RadButton5.Enabled = False
        ErrorProvider1.Clear()
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        Dialog1.Label1.Text = "Are you sure you want to delete this record!"
        Dialog1.ShowDialog()
        If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
            execute("delete from attitude WHERE ID ='" & tatt.Text & "' and sid ='" & sid & "'", 1)
            Clear(Me)
            ErrorProvider1.Clear()
            attitude_bindgrid()
            RadButton5.Enabled = False
        End If
    End Sub

    Private Sub attgrid1_Click(sender As Object, e As EventArgs) Handles attgrid1.Click
        Try
            tatt.Text = attgrid1.CurrentRow.Cells(0).Value.ToString
            txtattitude1.Text = attgrid1.CurrentRow.Cells(1).Value.ToString
            If Not tatt.Text = "" Then
                RadButton5.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtipsearch_Click(sender As Object, e As EventArgs) Handles cmdipsearch.Click
        Try
            Dim c As Integer = record_count("select * from academic_year where term = '3' and status = '1' and sid = '" & sid & "' ")
            If c > 0 Then
                If Not txtips.Text = "" Then
                    Dim stname As String = getValue("select fullname from student where student_id = '" + txtips.Text + "' and sid = '" & sid & "'")
                    Dim tb As New DataTable
                    tb = ShowData("select * from grade where Student_Name = '" & stname & "' and sid ='" & sid & "' and Academic ='" & academic_year & "' and Term='" & term & "'")
                    If Not tb.Rows.Count < 1 Then
                        ipview.Text = "Overall Marks : " & tb.Rows(0)(3).ToString & vbCrLf & "Overall Position : " & tb.Rows(0)(4).ToString
                        cmdip.Enabled = True
                    Else
                        showerror("Grades for the Third term has been accumulated yet!")
                    End If
                Else
                    showerror("Please enter the student id")
                End If
            Else
                showerror("Sorry this can be done only when its's promotion term!")
            End If
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub cmdip_Click(sender As Object, e As EventArgs) Handles cmdip.Click
        Try
            Dim sclass As String = getValue("select class from student where student_id = '" & txtips.Text & "' and sid='" & sid & "'")
            If Not sclass = "" Then
                Dim opt As String = ""
                Dim classNo, nclass As String
                sclass = sclass.ToString.TrimEnd(" ")
                Dim parts As String() = sclass.Split(" ")
                classNo = Val(parts(0)) + 1
                For q As Integer = 1 To parts.Count
                    opt = opt & " " & parts(q)
                Next
                nclass = classNo & " " & opt
                execute("update student set class = '" & nclass & "',previous_class = '" & sclass & "' where student_id = '" & txtips.Text & "' and sid='" & sid & "'", 1)
            Else
                showerror("No record was found with this student id :" & txtips.Text)
            End If
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub cmdcp_Click(sender As Object, e As EventArgs) Handles cmdcp.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim c As Integer = record_count("select * from academic_year where term = '3' and status = '1' and sid = '" & sid & "' ")
            If c > 0 Then
                Dim sclass As String = txtcp.Text.TrimEnd(" ")
                Dim classNo, nclass, promote As String
                Dim s As Integer
                Dim opt As String = ""
                Dim parts As String() = sclass.Split(" ")
                classNo = Val(parts(0)) + 1
                For q As Integer = 1 To parts.Count
                    opt = opt & " " & parts(q)
                Next
                nclass = classNo & " " & opt

                promote = academic_year & "-" & term
                Dim tb As New DataTable
                tb = ShowData("select * from grade where Academic='" & academic_year & "' and term='" & term & "' and sid='" & sid & "' and Class= '" + txtcp.Text + "'")
                If Not tb.Rows.Count < 1 Then
                    pstatus.Visible = True
                    ProgressBar1.Visible = True
                    Tot_rows = tb.Rows.Count
                    Dim cut_off As Integer = getnumber("select cut_off from d_grade where status = '1' and sid='" & sid & "'")
                    For i As Integer = 0 To tb.Rows.Count - 1
                        s = s + 1
                        If cut_off <= Val(tb.Rows(i)(3).ToString) Then
                            execute("update student set class='" & nclass & "',previous_class = '" & sclass & "', promoted = '" & promote & "' where student_id ='" & tb.Rows(i)(1).ToString & "' and sid='" & sid & "'", 3)
                        Else
                            execute("update student set promoted = '" & promote & "', previous_class='" & sclass & "' where student_id='" & tb.Rows(i)(1).ToString & "' and sid ='" & sid & "' ", 3)
                        End If
                        pstatus.Text = s.ToString & "Student(s) promoted out of " & Tot_rows.ToString
                        PROgres_count = CInt((i / Tot_rows) * 100)
                        ProgressBar1.Value = PROgres_count
                    Next
                    pstatus.ForeColor = Color.Green
                    pstatus.Text = "All class " & txtcp.Text & " promotion has been completed successfully"
                    ProgressBar1.Value = 100
                    ProgressBar1.Visible = False
                Else
                    Me.Cursor = Cursors.Default
                    showerror("Grades for the Third term has been accumulated yet!")
                End If
            Else
                Me.Cursor = Cursors.Default
                showerror("Sorry this can be done only when its's promotion term!")
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub txtcp_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles txtcp.SelectedIndexChanged
        If Not txtcp.Text = "" Then
            cmdcp.Enabled = True
        Else
            cmdcp.Enabled = False
        End If
    End Sub

    Private Sub RadButton11_Click(sender As Object, e As EventArgs) Handles RadButton11.Click
        RadGridView2.DataSource = ShowData("select student.student_id as Student_ID, student.fullname as Fullname,student.gender as Gender, grade.Overall_Marks as Total_marks,grade.Overall_Position as Position from student inner join grade on student.student_id = grade.Student_ID where  student.class = student.previous_class ")
        Try
            Me.RadGridView2.BestFitColumns()
            Me.RadGridView2.Columns("Student_ID").Width = 50
            Me.RadGridView2.Columns("Fullname").Width = 200
            Me.RadGridView2.Columns("Gender").Width = 80
            Me.RadGridView2.Columns("Total_marks").Width = 120
            Me.RadGridView2.Columns("Position").Width = 100
            For i As Integer = 0 To Me.RadGridView2.ColumnCount - 1
                Me.RadGridView2.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub RadButton12_Click(sender As Object, e As EventArgs) Handles RadButton12.Click
        RadGridView2.DataSource = ShowData("select student.student_id as Student_ID, student.fullname as Fullname,student.gender as Gender, grade.Overall_Marks as Total_marks,grade.Overall_Position as Position from student inner join grade on student.student_id = grade.Student_ID where  student.class != student.previous_class ")
        Try
            Me.RadGridView2.BestFitColumns()
            Me.RadGridView2.Columns("Student_ID").Width = 50
            Me.RadGridView2.Columns("Fullname").Width = 200
            Me.RadGridView2.Columns("Gender").Width = 80
            Me.RadGridView2.Columns("Total_marks").Width = 120
            Me.RadGridView2.Columns("Position").Width = 100
            For i As Integer = 0 To Me.RadGridView2.ColumnCount - 1
                Me.RadGridView2.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub cmdgp_Click(sender As Object, e As EventArgs) Handles cmdgp.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim c As Integer = record_count("select * from academic_year where term = '3' and status = '1' and sid = '" & sid & "' ")
            If c > 0 Then
                Dim promote As String
                Dim s As Integer
                Dim sclass As String
                Dim tb As New DataTable
                promote = academic_year & "-" & term
                tb = ShowData("select * from grade where Academic='" & academic_year & "' and term='" & term & "' and sid='" & sid & "'")
                If Not tb.Rows.Count < 1 Then
                    pstatus.Visible = True
                    ProgressBar1.Visible = True
                    Tot_rows = tb.Rows.Count
                    Dim cut_off As Integer = getnumber("select cut_off from d_grade where status = '1' and sid='" & sid & "'")
                    For i As Integer = 0 To tb.Rows.Count - 1
                        Dim classNo, nclass As String
                        sclass = tb.Rows(i)(7).ToString.TrimEnd(" ")

                        Dim opt As String = ""

                        Dim parts As String() = sclass.Split(" ")
                        classno = Val(parts(0)) + 1
                        For q As Integer = 1 To parts.Count
                            opt = opt & " " & parts(q)
                        Next
                        nclass = classNo & " " & opt
                        s = s + 1
                        If cut_off <= Val(tb.Rows(i)(3).ToString) Then
                            execute("update student set class='" & nclass & "',previous_class = '" & sclass & "', promoted = '" & promote & "' where student_id ='" & tb.Rows(i)(1).ToString & "' and sid='" & sid & "'", 3)
                        Else
                            execute("update student set promoted = '" & promote & "', previous_class='" & sclass & "' where student_id='" & tb.Rows(i)(1).ToString & "' and sid ='" & sid & "' ", 3)
                        End If
                        pstatus.Text = s.ToString & "Student(s) promoted out of " & Tot_rows.ToString
                        PROgres_count = CInt((i / Tot_rows) * 100)
                        ProgressBar1.Value = PROgres_count
                    Next
                    pstatus.ForeColor = Color.Green
                    pstatus.Text = "All class " & txtcp.Text & " promotion has been completed successfully"
                    ProgressBar1.Value = 100
                    ProgressBar1.Visible = False
                Else
        Me.Cursor = Cursors.Default
        showerror("Grades for the Third term has been accumulated yet!")
        End If
        Else
        Me.Cursor = Cursors.Default
        showerror("Sorry this can be done only when its's promotion term!")
        End If
        Me.Cursor = Cursors.Default
        Catch ex As Exception
        Me.Cursor = Cursors.Default
        showerror(ex.Message)
        End Try
    End Sub


    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        eventview.DataSource = filterdata(txtsearch.Text, actevent)
        examsview.DataSource = filterdata(txtsearch.Text, actexams)
    End Sub

    Private Sub txtstnum_TextChanged(sender As Object, e As EventArgs) Handles txtstnum.TextChanged
        allogrid.DataSource = filterdata(txtstnum.Text, all0_search)

    End Sub
End Class