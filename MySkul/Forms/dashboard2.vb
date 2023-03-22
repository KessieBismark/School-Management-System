Public Class dashboard2
    Private listFlDay As New List(Of FlowLayoutPanel)
    Private listsibject As New List(Of FlowLayoutPanel)
    Private currentDate As DateTime = DateTime.Today
    Private Sub dashboard2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        studentcount.Text = record_count("select * from student where sid = '" & sid & "'")
        classcount.Text = record_count("select * from subclass where sid ='" & sid & "'")
        staffcount.Text = record_count("select * from staff where sid ='" & sid & "'")
        Panel5.Location = New Point(put_center(), 5)
        '  Panel4.Location = New Point(put_center(), 4)
        GenerateDayPanel(42)
        DisplayCurrentDate()
        Dim cc As Integer
        Dim ta As New DataTable
        Try
            ta = ShowData("select academic,term from academic_year where status= '1' and  sid = '" & sid & "' ")
            cc = record_count("select count(`Student_ID`) as 'Total_count', SUM(`Total`) as 'Total_sum',Subject as 'Subject' from marks where  sid ='" & sid & "' and Academic = '" & ta.Rows(0)("academic").ToString & "' and term='" & ta.Rows(0)("term").ToString & "' GROUP by Subject")
            If cc > 0 Then
                GenerateSubjectPanel()
                AddLabelSubject()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Function put_center()
        Dim screen_width As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim each_width = screen_width / 2.5
        Dim dwidth As Integer
        dwidth = each_width
        Return dwidth
    End Function



    Private Sub AddAppointmentToFlDay(ByVal startDayAtFlNumber As Integer)
        Dim stdate As Date = Now.Date.Year & "-" & Now.Date.Month & "-" & 1
        Dim edate As Date = stdate.AddMonths(1).AddDays(-1)
        Dim startDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Dim endDate As DateTime = startDate.AddMonths(1).AddDays(-1)
        tb = New DataTable
        tb = ShowData($"SELECT * FROM `events` WHERE (start BETWEEN '" & startDate.ToString("yyyy-MM-dd") & "' And '" & endDate.ToString("yyyy-MM-dd") & "') And sid='" & sid & "' and academic = '" & academic_year & "' and term='" & term & "'")

        For Each row As DataRow In tb.Rows
            Dim appDay As DateTime = DateTime.Parse(row("start"))
            Dim link As New LinkLabel
            link.Tag = row("id")
            link.Name = $"link{row("id")}"
            link.Text = row("ename")
            AddHandler link.Click, AddressOf ShowAppointmentDetail
            listFlDay((appDay.Day - 1) + (startDayAtFlNumber - 1)).Controls.Add(link)
        Next
    End Sub

    Private Function GetFirstDayOfWeekOfCurrentDate() As Integer
        Dim firstDayOfMonth As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfMonth.DayOfWeek + 1
    End Function

    Private Function GetTotalDaysOfCurrentDate() As Integer
        Dim firstDayOfCurrentDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfCurrentDate.AddMonths(1).AddDays(-1).Day
    End Function

    Private Sub DisplayCurrentDate()
        lblMonthAndYear.Text = currentDate.ToString("MMMM, yyyy")
        Dim firstDayAtFlNumber As Integer = GetFirstDayOfWeekOfCurrentDate()
        Dim totalDay As Integer = GetTotalDaysOfCurrentDate()
        AddLabelDayToFlDay(firstDayAtFlNumber, totalDay)
        AddAppointmentToFlDay(firstDayAtFlNumber)
    End Sub

    Private Sub PrevMonth()
        currentDate = currentDate.AddMonths(-1)
        DisplayCurrentDate()
    End Sub

    Private Sub NextMonth()
        currentDate = currentDate.AddMonths(1)
        DisplayCurrentDate()
    End Sub

    Private Sub Today()
        currentDate = DateTime.Today
        DisplayCurrentDate()
    End Sub
    Private Sub AddLabelDayToFlDay(ByVal startDayAtFlNumber As Integer, ByVal totalDaysInMonth As Integer)
        For Each fl As FlowLayoutPanel In listFlDay
            fl.Controls.Clear()
            fl.Tag = 0
            fl.BackColor = Color.White
        Next

        For i As Integer = 1 To totalDaysInMonth
            Dim lbl As New Label
            lbl.Name = $"lblDay{i}"
            lbl.AutoSize = False
            lbl.TextAlign = ContentAlignment.MiddleRight
            lbl.Size = New Size(103, 29)
            lbl.Text = i
            lbl.Font = New Font("Microsoft Sans Serif", 12)
            listFlDay((i - 1) + (startDayAtFlNumber - 1)).Tag = i
            listFlDay((i - 1) + (startDayAtFlNumber - 1)).Controls.Add(lbl)

            If New Date(currentDate.Year, currentDate.Month, i) = Date.Today Then
                listFlDay((i - 1) + (startDayAtFlNumber - 1)).BackColor = Color.Aqua
            End If

        Next
    End Sub

    Private Sub ShowAppointmentDetail(sender As Object, e As EventArgs)
        Dim appID As Integer = CType(sender, LinkLabel).Tag
        tb2 = New DataTable
        tb2 = ShowData("SELECT * FROM `events` WHERE id = '" & appID & "' and sid = '" & sid & "'")
        If tb2.Rows.Count > 0 Then
            Dim row As DataRow = tb2.Rows(0)
            With eventss
                .lbleventn.Text = row("ename")
                .lblste.Text = row("start")
                .lblede.Text = row("end")
                .lblce.Text = row("comment")
                .ShowDialog()
            End With
            DisplayCurrentDate()
        End If
    End Sub

    Private Sub GenerateDayPanel(ByVal totalDays As Integer)
        flDays.Controls.Clear()
        listFlDay.Clear()

        For i As Integer = 1 To totalDays
            Dim fl As New FlowLayoutPanel
            fl.Name = $"flDay{i}"
            fl.Size = New Size(113, 78)
            fl.BackColor = Color.White
            fl.BorderStyle = BorderStyle.FixedSingle
            fl.Cursor = Cursors.Hand
            fl.AutoScroll = True
            flDays.AutoScroll = True
            flDays.Controls.Add(fl)
            listFlDay.Add(fl)
        Next
    End Sub
    Private Sub btnPrevMonth_Click(sender As Object, e As EventArgs) Handles btnPrevMonth.Click
        PrevMonth()
    End Sub

    Private Sub btnNextMonth_Click(sender As Object, e As EventArgs) Handles btnNextMonth.Click
        NextMonth()
    End Sub

    Private Sub btnToday_Click(sender As Object, e As EventArgs) Handles btnToday.Click
        Today()
    End Sub


    Private Sub GenerateSubjectPanel()
        sflp.Controls.Clear()
        listsibject.Clear()
        tb = New DataTable
        tb = ShowData("select count(`Student_ID`) as 'Total_count', SUM(`Total`) as 'Total_sum',Subject as 'Subject' from marks GROUP by Subject")
        For i As Integer = 0 To tb.Rows.Count - 1
            Dim flp As New FlowLayoutPanel
            flp.Size = New Size(391, 159)
            flp.BackColor = Color.White
            flp.BorderStyle = BorderStyle.FixedSingle
            flp.Cursor = Cursors.Hand
            flp.AutoScroll = True
            sflp.AutoScroll = True
            sflp.Controls.Add(flp)
            listsibject.Add(flp)
        Next
    End Sub
    Private Sub AddLabelSubject()

        Try
            Dim ttb = New DataTable
            Dim ta As New DataTable
            ta = ShowData("select academic,term from academic_year where  status = '1' and sid = '" & sid & "' ")
            ttb = ShowData("select count(`Student_ID`) as 'Total_count', SUM(`Total`) as 'Total_sum',Subject as 'Subject' from marks where  sid ='" & sid & "' and Academic = '" & ta.Rows(0)("academic").ToString & "' and term='" & ta.Rows(0)("term").ToString & "' GROUP by Subject")
            For Each flp As FlowLayoutPanel In listsibject
                flp.Controls.Clear()
                flp.Tag = 0
                flp.BackColor = Color.White
            Next
            Dim total_count, total_sum, average As Double
            tb3 = New DataTable
            tb2 = New DataTable
            tb2 = ShowData("select count(`Student_ID`) as 'Total_count', SUM(`Total`) as 'Total_sum',Subject as 'Subject' from marks where Student_ID != all (select student_id from student where gender='Female' and sid= '" & sid & "') and sid ='" & sid & "' and Academic = '" & ta.Rows(0)("academic").ToString & "' and term='" & ta.Rows(0)("term").ToString & "' GROUP by Subject")
            tb3 = ShowData("select count(`Student_ID`) as 'Total_count', SUM(`Total`) as 'Total_sum',Subject as 'Subject' from marks where Student_ID= any(select student_id from student where gender='Female' and sid='" & sid & "')  and sid ='" & sid & "' and Academic = '" & ta.Rows(0)("academic").ToString & "' and term='" & ta.Rows(0)("term").ToString & "' GROUP by Subject")
            Dim total_marks As Integer
            For i As Integer = 0 To ttb.Rows.Count - 1
                Dim lbl As New Label
                Dim lbl2 As New Label
                'calculations
                total_marks = Val(ttb.Rows(i)("Total_count").ToString) * 100
                total_count = Val(ttb.Rows(i)("Total_count").ToString)
                total_sum = Val(ttb.Rows(i)("Total_sum").ToString)
                average = total_sum / total_count
                lbl.AutoSize = False
                lbl.TextAlign = ContentAlignment.TopCenter
                lbl.Size = New Size(379, 38)
                lbl.Text = "Subject Name : " & ttb.Rows(i)("Subject").ToString
                lbl.Font = New Font("Microsoft Sans Serif", 14)
                lbl.Font = New Font(lbl.Font, FontStyle.Bold)
                lbl.ForeColor = Color.Black

                lbl2.TextAlign = ContentAlignment.TopLeft
                lbl2.AutoSize = True
                lbl2.Size = New Size(378, 110)
                Dim fm As String = ""
                'for males
                For s As Integer = 0 To tb2.Rows.Count - 1
                    If tb2.Rows(s)("Subject").ToString = ttb.Rows(i)("Subject").ToString Then
                        Dim fmm As Double = Val(tb2.Rows(s)("Total_sum").ToString) / tb2.Rows(2)("Total_count").ToString
                        fm = "Average marks of Males :" & Math.Round(fmm, 2) & "%"
                    End If
                Next
                'for females
                For j As Integer = 0 To tb3.Rows.Count - 1
                    If tb3.Rows(j)("Subject").ToString = ttb.Rows(i)("Subject").ToString Then
                        Dim fmm As Double = Val(tb3.Rows(j)("Total_sum").ToString) / tb3.Rows(j)("Total_count").ToString
                        fm = fm & vbCrLf & "Average marks of Females :" & Math.Round(fmm, 2) & "%"
                    End If
                Next

                lbl2.Text = "Total Number of 'marks' record count :" & total_count & vbCrLf & "Total marks obtained by students :" & total_sum & vbCrLf & "Total marks :" & total_marks & vbCrLf & "Average marks : " & Math.Round(average, 2) & "%" & vbCrLf & fm
                lbl2.Font = New Font("Microsoft Sans Serif", 10)
                lbl2.ForeColor = Color.Black
                listsibject(i).Controls.Add(lbl)
                listsibject(i).Controls.Add(lbl2)
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try

    End Sub


End Class