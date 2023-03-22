Public Class dashboard
    Private listFlDay As New List(Of FlowLayoutPanel)
    Private currentDate As DateTime = DateTime.Today
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        studentcount.Text = record_count("select * from student where sid ='" & sid & "'")
        classcount.Text = record_count("select * from subclass where sid ='" & sid & "'")
        staffcount.Text = record_count("select * from staff where sid ='" & sid & "'")
        GenerateDayPanel(42)
        DisplayCurrentDate()

    End Sub

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
            lbl.Size = New Size(100, 19)
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
            fl.Size = New Size(113, 48)
            fl.BackColor = Color.White
            fl.BorderStyle = BorderStyle.FixedSingle
            fl.Cursor = Cursors.Hand
            fl.AutoScroll = True
            flDays.AutoScroll = True
            flDays.Controls.Add(fl)
            listFlDay.Add(fl)
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        dbconfig.ShowDialog()
    End Sub

    Private Sub btnNextMonth_Click(sender As Object, e As EventArgs) Handles btnNextMonth.Click
        NextMonth()
    End Sub

    Private Sub btnPrevMonth_Click_1(sender As Object, e As EventArgs) Handles btnPrevMonth.Click
        PrevMonth()
    End Sub

    Private Sub btnToday_Click(sender As Object, e As EventArgs) Handles btnToday.Click
        Today()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class