Imports System.IO

Public Class configuration
    Dim rowcount As Integer = 0
    Dim count As Integer = 0
    Dim ts As New DataTable
    Dim school_name As String
    Dim report As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Private Sub configuration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ul = "2" Or ul = "3" Then
            TabPage2.Enabled = False
            TabPage4.Enabled = False
            TabPage5.Enabled = False
            TabPage7.Enabled = False
            TabPage8.Enabled = False
        ElseIf ul = "4" Or ul = "5" Then
            TabPage1.Enabled = False
            TabPage3.Enabled = False
        End If
        Try
            txtpgclass.DataSource = New BindingSource(ShowData("select * from subclass where sid = '" & sid & "' order by s_class ASC"), Nothing)
            txtpgclass.DisplayMember = "s_class"
            txtpgclass.Items.Add("")

            rstclass.DataSource = New BindingSource(ShowData("select * from subclass where sid = '" & sid & "' order by s_class ASC"), Nothing)
            rstclass.DisplayMember = "s_class"
            rstclass.Items.Add("")


            stdclass.DataSource = New BindingSource(ShowData("select * from subclass where sid = '" & sid & "' order by s_class ASC"), Nothing)
            stdclass.DisplayMember = "s_class"
            stdclass.Items.Add("All")
            stdclass.Items.Add("")


            txtpgacademic.DataSource = New BindingSource(ShowData("select * from academic_year  where sid = '" & sid & "' group by academic order by academic DESC"), Nothing)
            txtpgacademic.DisplayMember = "academic"
            txtpgacademic.Items.Add("")

            pacademic.DataSource = New BindingSource(ShowData("select * from academic_year  where sid = '" & sid & "' group by academic order by academic DESC"), Nothing)
            pacademic.DisplayMember = "academic"
            pacademic.Items.Add("")

            rpacademic.DataSource = New BindingSource(ShowData("select * from academic_year  where sid = '" & sid & "' group by academic order by academic DESC"), Nothing)
            rpacademic.DisplayMember = "academic"
            rpacademic.Items.Add("")

            rcacademic.DataSource = New BindingSource(ShowData("select * from academic_year  where sid = '" & sid & "' group by academic order by academic DESC"), Nothing)
            rcacademic.DisplayMember = "academic"
            rcacademic.Items.Add("")

            riacademic.DataSource = New BindingSource(ShowData("select * from academic_year  where sid = '" & sid & "' group by academic order by academic DESC"), Nothing)
            riacademic.DisplayMember = "academic"
            riacademic.Items.Add("")

            school_name = getValue("select name from school_profile where sid = '" & sid & "'")
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub



    Private Sub RadRadioButton4_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles RadRadioButton4.ToggleStateChanged
        '  RadRadioButton4.IsChecked = True
        If RadRadioButton4.IsChecked = True Then
            RadRadioButton3.IsChecked = False
            psid.Enabled = True
            pma.Enabled = False
            RadGroupBox2.Enabled = True
        End If
    End Sub

    Private Sub RadRadioButton3_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles RadRadioButton3.ToggleStateChanged
        ' RadRadioButton3.IsChecked = True
        If RadRadioButton3.IsChecked = True Then
            RadRadioButton4.IsChecked = False

            psid.Enabled = False
            pma.Enabled = True
            RadGroupBox2.Enabled = True
        End If
    End Sub

    Private Sub preport_Click(sender As Object, e As EventArgs) Handles preport.Click
        Try
            If RadRadioButton4.IsChecked = True And pstaff.Text = "" Then
                showerror("Please provide the Staff ID")
            ElseIf RadRadioButton3.IsChecked = True And (pmonth.Text = "" Or pacademic.Text = "") Then
                showerror("Please select the month and academic!")
            Else
                Dim ps As New DataTable

                If RadRadioButton4.IsChecked = True Then
                    ps = ShowData("SELECT  `Staff_ID`, `Name`, `Working_Days`, `Days_Present`, `Total_Hours`, `Hours_Present`, `Initial_Salary`, `Payment`, `Month`, `Total_Leave_Days`, `Academic`, `Date` FROM `payroll` WHERE Staff_ID ='" & pstaff.Text & "' and sid= '" & sid & "'")
                Else
                    ps = ShowData("SELECT  `Staff_ID`, `Name`, `Working_Days`, `Days_Present`, `Total_Hours`, `Hours_Present`, `Initial_Salary`, `Payment`, `Month`, `Total_Leave_Days`, `Academic`, `Date` FROM `payroll` WHERE Month ='" & pmonth.Text & "' and Academic = '" & pacademic.Text & "' and sid= '" & sid & "'")
                End If
                If ps.Rows.Count > 0 Then
                    Me.Cursor = Cursors.WaitCursor
                    report = New payrollReport
                    report.SetDataSource(ps)
                    report.SetParameterValue("sname", school_name)
                    payrollViewer.ReportSource = report
                    Me.Cursor = Cursors.Default
                Else
                    showinfo("No record was found!")
                End If
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub RadButton9_Click(sender As Object, e As EventArgs) Handles RadButton9.Click
        Try
            If txtpgacademic.Text = "" Or txtpgclass.Text = "" Or txtpgterm.Text = "" Then
                showerror("Please select the required information!")
            Else
                rowcount = 0
                count = 0
                ts = ShowData("SELECT  `Student_ID`, Name FROM `marks` where  Academic  ='" & txtpgacademic.Text & "' and Class='" & txtpgclass.Text & "' and Term='" & txtpgterm.Text & "' and sid = '" & sid & "' group by Student_ID ASC")
                If ts.Rows.Count > 0 Then
                    rowcount = ts.Rows.Count
                    Generate_Report(txtpgacademic.Text, txtpgclass.Text, ts.Rows(count)(0).ToString, txtpgterm.Text, ts.Rows(count)(1).ToString)
                    gAction.Enabled = True
                Else
                    gAction.Enabled = False
                    showinfo("No record was found!")
                End If
            End If
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub cmdnext_Click(sender As Object, e As EventArgs) Handles cmdnext.Click
        Try
            If txtpgacademic.Text = "" Or txtpgclass.Text = "" Or txtpgterm.Text = "" Then
                showerror("Please select the required information!")
            Else

                count = count + 1
                If rowcount > 0 Then
                    If count <= rowcount Then
                        Generate_Report(txtpgacademic.Text, txtpgclass.Text, ts.Rows(count)(0).ToString, txtpgterm.Text, ts.Rows(count)(1).ToString)
                    Else
                        count = rowcount
                        showinfo("End of list!")
                    End If
                End If
                End If
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub Generate_Report(ByVal tacademic As String, ByVal tclass As String, ByVal stid As String, ByVal tterm As Integer, ByVal studentname As String)
        Try
            Me.Cursor = Cursors.WaitCursor
            tb2 = New DataTable
            tb3 = New DataTable
            tb4 = New DataTable
            tb5 = New DataTable
            tb6 = New DataTable
            Dim tbb, tbbs As New DataTable
            Dim pm As String
            Dim dg As String = ""
            Dim avg As Double

            report = New report
            tbb = ShowData("SELECT  `Subject`, `Class_Score`, `Exams_Score`, `Total`,`Position`,`Grading`,`Remark`as Remarks FROM `marks` where Student_ID='" & stid & "' and  Academic  ='" & tacademic & "' and Class='" & tclass & "' and Term='" & tterm & "' and sid = '" & sid & "' order by Student_ID ASC")
            If tbb.Rows.Count < 1 Then
                showerror("No data was found")
                Exit Sub
            End If
            '  Dim Fmreport As New terminalViewer
            tb5 = ShowData("select * from grading where sid='" & sid & "' order by lower_limit DESC")
            tb6 = ShowData("select * from school_profile where sid='" & sid & "'")
            report.SetDataSource(tbb)

            Dim classno As Integer = record_count("select * from marks where sid='" & sid & "' and Academic='" & tacademic & "' and Term = '" & tterm & "' and Class='" & tclass & "' group by Student_ID")
            tb2 = ShowData("select * from academic_year where academic ='" & tacademic & "' and term ='" & tterm & "' and sid = '" & sid & "'")
            tb3 = ShowData("select * from grade where `Student_ID`= '" & stid & "' and Academic='" & tacademic & "' and Term='" & tterm & "' and sid = '" & sid & "' and Class='" & tclass & "'")
            Dim logopath, signpath As String
            logopath = Application.StartupPath & "Images\School Profile\" & tb6.Rows(0)("logo").ToString
            signpath = Application.StartupPath & "Images\School Profile\" & tb6.Rows(0)("sign_head").ToString

            For i As Integer = 0 To tb5.Rows.Count - 1 Step 1
                dg = dg & tb5.Rows(i)("lower_limit").ToString & "%-" & tb5.Rows(i)("upper_limit").ToString & "%     " & tb5.Rows(i)("letter_grade").ToString & "    " & tb5.Rows(i)("remark").ToString & "               "
            Next
            If term = 3 Then
                tb4 = ShowData("select * from student where student_id = '" & tb3.Rows(0)("Student_ID").ToString & "' and sid = '" & sid & "'")
                If tb4.Rows(0)("class").ToString = tb4.Rows(0)("previous_class").ToString Then
                    pm = "REPEATED TO: " & tb4.Rows(0)("class").ToString
                Else
                    pm = "PROMOTED TO: " & tb4.Rows(0)("class").ToString
                End If
            Else
                pm = "PROMOTED TO: "
            End If
            Dim ndate As Date = tb2.Rows(0)("next_term").ToString

            avg = Math.Round(Val(tb3.Rows(0)("Overall_Marks").ToString / tbb.Rows.Count), 1)
            report.SetParameterValue("school_name", tb6.Rows(0)("name").ToString)
            report.SetParameterValue("location", tb6.Rows(0)("town").ToString)
            report.SetParameterValue("contact", tb6.Rows(0)("phone").ToString)
            report.SetParameterValue("student_name", studentname)
            report.SetParameterValue("class", tclass)
            report.SetParameterValue("term", tterm)
            report.SetParameterValue("student_no", tb3.Rows(0)("Student_ID").ToString)
            report.SetParameterValue("average", avg)
            report.SetParameterValue("promoted", pm)
            report.SetParameterValue("school_logo", logopath)
            report.SetParameterValue("sign", signpath)
            report.SetParameterValue("academic", tacademic)
            report.SetParameterValue("nterm", ndate.ToString("D"))
            report.SetParameterValue("class_no", classno)
            report.SetParameterValue("position", tb3.Rows(0)("Overall_Position").ToString)
            report.SetParameterValue("dgrade", dg)
            report.SetParameterValue("attitude", tb3.Rows(0)("Remark").ToString)
            report.SetParameterValue("attendance", tb3.Rows(0)("Attendance").ToString)
            report.SetParameterValue("tattendance", tb2.Rows(0)("days").ToString)

            terminalViewer.ReportSource = report

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub cmdback_Click(sender As Object, e As EventArgs) Handles cmdback.Click
        Try
            If txtpgacademic.Text = "" Or txtpgclass.Text = "" Or txtpgterm.Text = "" Then
                showerror("Please select the required information!")
                Exit Sub
            Else
                count = count - 1
                If rowcount > 0 Then
                    If count > -1 Then
                        Generate_Report(txtpgacademic.Text, txtpgclass.Text, ts.Rows(count)(0).ToString, txtpgterm.Text, ts.Rows(count)(1).ToString)
                    Else
                        count = 0
                        showinfo("End of list!")
                    End If
                End If
            End If
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub cmdpall_Click(sender As Object, e As EventArgs) Handles cmdpall.Click
        If txtpgacademic.Text = "" Or txtpgclass.Text = "" Or txtpgterm.Text = "" Then
            showerror("Please do not leave any field empty!")
            Exit Sub
        Else
            Me.Cursor = Cursors.WaitCursor

            tb2 = New DataTable
            tb3 = New DataTable
            tb = New DataTable
            tb4 = New DataTable
            tb5 = New DataTable
            tb6 = New DataTable
            Dim tbb, tbbs As New DataTable
            Dim pm As String
            Dim avg As Double

            report = New report
            tbbs = ShowData("SELECT  `Student_ID`, Name FROM `marks` where  Academic  ='" & txtpgacademic.Text & "' and Class='" & txtpgclass.Text & "' and Term='" & txtpgterm.Text & "' and sid = '" & sid & "' group by Student_ID ASC")

            If tbbs.Rows.Count > 0 Then
                For k As Integer = 0 To tbbs.Rows.Count - 1
                    Dim dg As String = ""
                    tbb = ShowData("SELECT  `Subject`, `Class_Score`, `Exams_Score`, `Total`,`Position`,`Grading`,`Remark`as Remarks FROM `marks` where Student_ID='" & tbbs.Rows(k)("Student_ID").ToString & "' and  Academic  ='" & txtpgacademic.Text & "' and Class='" & txtpgclass.Text & "' and Term='" & txtpgterm.Text & "' and sid = '" & sid & "' order by Student_ID ASC")
                    If tbb.Rows.Count < 1 Then
                        showerror("No data was found")
                        Exit For
                    End If
                    For q As Integer = 0 To tbb.Rows.Count - 1
                        report.SetDataSource(tbb)
                    Next
                    '  Dim Fmreport As New terminalViewer
                    tb5 = ShowData("select * from grading where sid='" & sid & "' order by lower_limit DESC")
                    tb6 = ShowData("select * from school_profile where sid='" & sid & "'")


                    Dim classno As Integer = record_count("select * from marks where sid='" & sid & "' and Academic='" & txtpgacademic.Text & "' and Term = '" & txtpgterm.Text & "' and Class='" & txtpgclass.Text & "' group by Student_ID")
                    tb2 = ShowData("select * from academic_year where academic ='" & txtpgacademic.Text & "' and term ='" & txtpgterm.Text & "' and sid = '" & sid & "'")
                    tb3 = ShowData("select * from grade where `Student_ID`= '" & tbbs.Rows(k)("Student_ID").ToString & "' and Academic='" & txtpgacademic.Text & "' and Term='" & txtpgterm.Text & "' and sid = '" & sid & "' and Class='" & txtpgclass.Text & "'")
                    Dim logopath, signpath As String
                    logopath = Application.StartupPath & "Images\School Profile\" & tb6.Rows(0)("logo").ToString
                    signpath = Application.StartupPath & "Images\School Profile\" & tb6.Rows(0)("sign_head").ToString

                    For i As Integer = 0 To tb5.Rows.Count - 1 Step 1
                        dg = dg & tb5.Rows(i)("lower_limit").ToString & "%-" & tb5.Rows(i)("upper_limit").ToString & "%     " & tb5.Rows(i)("letter_grade").ToString & "    " & tb5.Rows(i)("remark").ToString & "               "
                    Next
                    If term = 3 Then
                        tb4 = ShowData("select * from student where student_id = '" & tb3.Rows(0)("Student_ID").ToString & "' and sid = '" & sid & "'")
                        If tb4.Rows(0)("class").ToString = tb4.Rows(0)("previous_class").ToString Then
                            pm = "REPEATED TO: " & tb4.Rows(0)("class").ToString
                        Else
                            pm = "PROMOTED TO: " & tb4.Rows(0)("class").ToString
                        End If
                    Else
                        pm = "PROMOTED TO: "
                    End If
                    Dim ndate As Date = tb2.Rows(0)("next_term").ToString

                    avg = Math.Round(Val(tb3.Rows(0)("Overall_Marks").ToString / tbb.Rows.Count), 1)
                    report.SetParameterValue("school_name", tb6.Rows(0)("name").ToString)
                    report.SetParameterValue("location", tb6.Rows(0)("town").ToString)
                    report.SetParameterValue("contact", tb6.Rows(0)("phone").ToString)
                    report.SetParameterValue("student_name", tbbs.Rows(k)("Name").ToString)
                    report.SetParameterValue("class", txtpgclass.Text)
                    report.SetParameterValue("term", txtpgterm.Text)
                    report.SetParameterValue("student_no", tb3.Rows(0)("Student_ID").ToString)
                    report.SetParameterValue("average", avg)
                    report.SetParameterValue("promoted", pm)
                    report.SetParameterValue("school_logo", logopath)
                    report.SetParameterValue("sign", signpath)
                    report.SetParameterValue("academic", txtpgacademic.Text)
                    report.SetParameterValue("nterm", ndate.ToString("D"))
                    report.SetParameterValue("class_no", classno)
                    report.SetParameterValue("position", tb3.Rows(0)("Overall_Position").ToString)
                    report.SetParameterValue("dgrade", dg)
                    report.SetParameterValue("attitude", tb3.Rows(0)("Remark").ToString)
                    report.SetParameterValue("attendance", tb3.Rows(0)("Attendance").ToString)
                    report.SetParameterValue("tattendance", tb2.Rows(0)("days").ToString)
                    Dim docprint As System.Drawing.Printing.PrintDocument
                    docprint = New System.Drawing.Printing.PrintDocument
                    Dim dfp As String = docprint.PrinterSettings.PrinterName
                    report.PrintOptions.PrinterName = dfp
                    report.PrintToPrinter(1, False, 0, 0)
                Next
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub RadButton10_Click(sender As Object, e As EventArgs) Handles RadButton10.Click
        Me.Cursor = Cursors.WaitCursor
        Dim docprint As System.Drawing.Printing.PrintDocument
        docprint = New System.Drawing.Printing.PrintDocument
        Dim dfp As String = docprint.PrinterSettings.PrinterName
        report.PrintOptions.PrinterName = dfp
        report.PrintToPrinter(1, False, 0, 0)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub rstudent_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles rstudent.SelectedIndexChanged
        If rstudent.Text = "Class" Then
            rstl.Visible = True
            rstclass.Visible = True
        Else
            rstl.Visible = False
            rstclass.Visible = False
        End If
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If rstudent.Text = "Class" And rstclass.Text = "" Then
                Me.Cursor = Cursors.Default
                showerror("Please select the required information!")
                Exit Sub
            Else
                Dim str As New DataTable
                Dim head As String
                If rstudent.Text = "Class" Then
                    str = ShowData("SELECT `student_id`, `fullname`, `gender`, `dob`, `father_name` as father, `mother_name` as mother, `father_contact` as fcontact, `mother_contact` as mcontact, `class` from student WHERE class='" & rstclass.Text & "' and sid= '" & sid & "'")
                    head = UCase("student records of class " & rstclass.Text)
                ElseIf rstudent.Text = "Male" Then
                    str = ShowData("SELECT `student_id`, `fullname`, `gender`, `dob`,  `father_name` as father, `mother_name` as mother, `father_contact` as fcontact, `mother_contact` as mcontact, `class` from student WHERE gender='Male' and sid= '" & sid & "'")
                    head = UCase("male students record")
                ElseIf rstudent.Text = "Female" Then
                    str = ShowData("SELECT `student_id`, `fullname`, `gender`, `dob`,  `father_name` as father, `mother_name` as mother, `father_contact` as fcontact, `mother_contact` as mcontact, `class` from student WHERE gender='Female' and sid= '" & sid & "'")
                    head = UCase("female students record")
                Else
                    str = ShowData("SELECT `student_id`, `fullname`, `gender`, `dob`,  `father_name` as father, `mother_name` as mother, `father_contact` as fcontact, `mother_contact` as mcontact, `class` from student WHERE  class = previous_class and sid= '" & sid & "'")
                    head = UCase("record of repeated students")
                End If
                If str.Rows.Count > 0 Then
                    report = New allstudent_Report
                    report.SetDataSource(str)
                    report.SetParameterValue("sname", school_name)
                    report.SetParameterValue("head", head)
                    studentViewer.ReportSource = report
                Else
                    showinfo("No data was found!")
                End If
            End If
                Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
        showerror(ex.Message)
        End Try
    End Sub

    Private Sub RadButton6_Click(sender As Object, e As EventArgs) Handles RadButton6.Click
        Try
            If stdclass.Text = "" Then
                showerror("Please select the required information!")
                Exit Sub
            Else
                Me.Cursor = Cursors.WaitCursor
                Dim head As String
                Dim stdebt As New DataTable
                If stdclass.Text = "All" Then
                    head = UCase("list of students arrears")
                    stdebt = ShowData("SELECT  `Student_ID`, `Fullname`,`Class`, `Academic`, `Term`, `Previous_Debt`, `Current_Debt`, `Total_Debt` FROM `student_debt` WHERE sid = '" & sid & "'")
                Else
                    head = UCase("list of class " & stdclass.Text & " students arrears")
                    stdebt = ShowData("SELECT  `Student_ID`, `Fullname`,`Class`, `Academic`, `Term`, `Previous_Debt`, `Current_Debt`, `Total_Debt` FROM `student_debt` WHERE Class = '" & stdclass.Text & "' and sid = '" & sid & "' ")
                End If
                If stdebt.Rows.Count > 0 Then
                    report = New debtReport
                    report.SetDataSource(stdebt)
                    report.SetParameterValue("sname", school_name)
                    report.SetParameterValue("head", head)
                    studentDebtViewer.ReportSource = report
                Else
                    showinfo("No record was found!")
                End If
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub RadButton12_Click(sender As Object, e As EventArgs) Handles RadButton12.Click
        Try
            If rpterm.Text = "" Or rpacademic.Text = "" Then
                showerror("Please select the required information!")
                Exit Sub
            Else
                Me.Cursor = Cursors.WaitCursor
                Dim head As String
                Dim prf As New DataTable
                If rpterm.Text = "All" Then
                    prf = ShowData("SELECT `Profit_ID` as profitid, `Academic` as academic, `Term` as term, `Income` as income, `Expenses` as expenses, `Profit` as profit, `Date` as date  FROM `profit` WHERE sid= '" & sid & "' and Academic = '" & rpacademic.Text & "'")
                    head = UCase(rpacademic.Text & " Profit records")
                Else
                    prf = ShowData("SELECT `Profit_ID` as profitid, `Academic` as academic, `Term` as term, `Income` as income, `Expenses` as expenses, `Profit` as profit, `Date` as date  FROM `profit` WHERE sid= '" & sid & "' and Academic = '" & rpacademic.Text & "' and Term = '" & rpterm.Text & "'")
                    head = UCase(rpacademic.Text & " term " & rpterm.Text & " Profit records")
                End If
                If prf.Rows.Count > 0 Then
                    report = New profitReport
                    report.SetDataSource(prf)
                    report.SetParameterValue("sname", school_name)
                    report.SetParameterValue("head", head)
                    profitViewer.ReportSource = report
                Else
                    showinfo("No record was found!")
                End If
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Try
            If rcterm.Text = "" Or rcacademic.Text = "" Then
                showerror("Please select the required information!")
                Exit Sub
            Else
                Me.Cursor = Cursors.WaitCursor
                Dim chg As New DataTable
                Dim head As String
                chg = ShowData("SELECT `charge_id` as chargeid, `name`, `amount`, `term`, `year`, `class`, `date` FROM `charges` WHERE year = '" & rcacademic.Text & "' and term = '" & rcterm.Text & "' and sid ='" & sid & "'")
                head = UCase(rcacademic.Text & " term " & rcterm.Text & "  charges")
                If chg.Rows.Count > 0 Then
                    report = New chargeReport
                    report.SetDataSource(chg)
                    report.SetParameterValue("sname", school_name)
                    report.SetParameterValue("head", head)
                    chargesViewer.ReportSource = report
                Else
                    showinfo("No record was found!")
                End If
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
        Try
            If riterm.Text = "" Or riacademic.Text = "" Then
                showerror("Please select the required information!")
                Exit Sub
            Else
                Me.Cursor = Cursors.WaitCursor
                Dim head As String
                Dim prf As New DataTable
                If riterm.Text = "All" Then
                    prf = ShowData("SELECT `Income_ID` as incomeid, `Student_ID` as studentid, `Name` as name, `Type` as type, `Amount` as amount, `Academic` as academic, `Term` as term,  `Paid_by` as paidby, `Date` as date FROM `income` WHERE  sid= '" & sid & "' and Academic = '" & riacademic.Text & "'")
                    head = UCase(riacademic.Text & " income records")
                Else
                    prf = ShowData("SELECT `Income_ID` as incomeid, `Student_ID` as studentid, `Name` as name, `Type` as type, `Amount` as amount, `Academic` as academic, `Term` as term,  `Paid_by` as paidby, `Date` as date FROM `income` WHERE  sid= '" & sid & "' and Academic = '" & riacademic.Text & "' and Term = '" & riterm.Text & "'")
                    head = UCase(riacademic.Text & " term " & riterm.Text & " income records")
                End If
                If prf.Rows.Count > 0 Then
                    report = New incomeReport
                    report.SetDataSource(prf)
                    report.SetParameterValue("sname", school_name)
                    report.SetParameterValue("head", head)
                    incomeViewer.ReportSource = report
                Else
                    showinfo("No record was found!")
                End If
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            showerror(ex.Message)
        End Try
    End Sub
End Class