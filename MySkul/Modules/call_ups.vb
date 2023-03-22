Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Module call_ups

#Region "Call ups declaration"
    Dim info As String
    Dim day As Integer
    Public academic_year As String
    Public term As String
    Dim mm As New Integer
    Public sid As String
    Public ul, tclass, staffid, staff_name As String
#End Region

#Region "clear all textbox"
    Public Sub Clear(c As Control)
        Dim currentTextBox As TextBox
        For Each ctrl As Control In c.Controls
            If TypeOf ctrl Is TextBox Then
                currentTextBox = CType(ctrl, TextBox)
                currentTextBox.Clear()
            End If
            If ctrl.HasChildren Then
                Clear(ctrl)
            End If
        Next
    End Sub
#End Region

#Region "Day of the week"
    Function dayofweek()
        Dim dw As String = ""
        Dim num As Integer
        num = Now.Date.DayOfWeek
        If num = 1 Then
            dw = "Monday"
        ElseIf num = 2 Then
            dw = "Tuesday"
        ElseIf num = 3 Then
            dw = "Wednesday"
        ElseIf num = 4 Then
            dw = "Thurday"
        ElseIf num = 5 Then
            dw = "Friday"
        End If
        Return dw
    End Function
#End Region

#Region "get the beginning of the month date"
    Public Function frmdate()
        day = "1"
        Return Now.Date.Year & "-" & Now.Date.Month & "-" & day
    End Function
#End Region

#Region "get the end of the month date"
    Public Function todate()
        Dim m As New Integer
        m = Now.Date.Month
        If m = "1" Then
            day = "31"
        ElseIf m = "3" Then
            day = "31"
        ElseIf m = "5" Then
            day = "31"
        ElseIf m = "7" Then
            day = "31"
        ElseIf m = "8" Then
            day = "31"
        ElseIf m = "10" Then
            day = "31"
        ElseIf m = "12" Then
            day = "31"
        ElseIf m = "6" Then
            day = "30"
        ElseIf m = "4" Then
            day = "30"
        ElseIf m = "9" Then
            day = "30"
        ElseIf m = "11" Then
            day = "30"
        ElseIf m = "2" Then
            day = "28"
        End If
        Return Now.Date.Year & "-" & Now.Date.Month & "-" & day
    End Function
#End Region

#Region "total days in a month"
    Public Function TotalDays()
        Dim dy As Integer
        Dim m As New Integer
        m = Now.Date.Month - 1
        If m = 0 Then
            dy = 31
        ElseIf m = 12 Then
            dy = 31
        ElseIf m = 3 Then
            dy = 31
        ElseIf m = 5 Then
            dy = 31
        ElseIf m = 7 Then
            dy = 31
        ElseIf m = 8 Then
            dy = 31
        ElseIf m = 10 Then
            dy = 31
        ElseIf m = 6 Then
            dy = 30
        ElseIf m = 4 Then
            dy = 30
        ElseIf m = 9 Then
            dy = 30
        ElseIf m = 11 Then
            dy = 30
        ElseIf m = 2 Then
            dy = 28
        End If
        Return dy
    End Function
#End Region

#Region "get the beginning of last month date"
    Public Function LastMontFrmDate()
        day = "1"
        Dim m, y As New Integer
        m = Now.Date.Month - 1
        y = Now.Date.Year

        If m = 0 Then
            m = 12
            y = y - 1
        End If
        Return y & "-" & m & "-" & day
    End Function
#End Region

#Region "get the end of last month date"
    Public Function LastMonthEndDate()
        Dim m, y As New Integer
        m = Now.Date.Month - 1
        y = Now.Date.Year

        If m = 0 Then
            m = 12
            y = y - 1
        End If
        If m = "1" Then
            day = "31"
        ElseIf m = "3" Then
            day = "31"
        ElseIf m = "5" Then
            day = "31"
        ElseIf m = "7" Then
            day = "31"
        ElseIf m = "8" Then
            day = "31"
        ElseIf m = "10" Then
            day = "31"
        ElseIf m = "12" Then
            day = "31"
        ElseIf m = "6" Then
            day = "30"
        ElseIf m = "4" Then
            day = "30"
        ElseIf m = "9" Then
            day = "30"
        ElseIf m = "11" Then
            day = "30"
        ElseIf m = "2" Then
            day = "28"
        End If
        Return y & "-" & m & "-" & day
    End Function
#End Region

#Region "Save data"
    Public Sub execute(ByVal query As String, ByVal a As Integer)
        Try

            con = New MySqlConnection(cs)
            con.Open()
            cmd = New MySqlCommand(query, con)
            cmd.ExecuteNonQuery()
            con.Close()
            If a = 0 Then
                info = "All Information was saved successfully"
                feedback.sinfo.Text = info
                feedback.ShowDialog()
            ElseIf a = 1 Then
                info = "All Information was updated successfully"
                feedback.sinfo.Text = info
                feedback.ShowDialog()
            ElseIf a = 2 Then
                info = "All Information was deleted successfully"
                feedback.sinfo.Text = info
                feedback.ShowDialog()
            End If
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
#End Region

#Region "display data"
    Public Function ShowData(ByVal query As String)
        Try
            con = New MySqlConnection(cs)
            cmd = New MySqlCommand(query, con)
            adp = New MySqlDataAdapter(cmd)
            tb = New DataTable
            adp.Fill(tb)
            Return tb
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
#End Region

#Region "show error message"
    Public Sub showerror(ByVal s As String)

        ErrorFeed.einfo.Text = "There was an error: " & s
        ErrorFeed.ShowDialog()

    End Sub
#End Region

#Region "show info message"
    Public Sub showinfo(ByVal s As String)
        feedback.sinfo.Text = s
        feedback.ShowDialog()
    End Sub
#End Region

#Region "check internet connection"
    Public Sub check()

        Try

            Using client = New System.Net.WebClient()
                Using stream = client.OpenRead("http://google.com")
                    dbconfig.result.ForeColor = Color.Green
                    dbconfig.result.Text = "Connected."
                End Using
            End Using
        Catch ex As Exception
            dbconfig.result.ForeColor = Color.Red
            dbconfig.result.Text = "Not Connected."
        End Try

    End Sub
#End Region

#Region "check for numbers or letters only"
    Public Function numbers(ByVal i As String) As Boolean
        Try
            Convert.ToInt64(i)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function letters(input As String) As Boolean
        Return Regex.IsMatch(input, "[0-9]")
    End Function
#End Region

#Region "Search Filter"
    Public Function filterdata(Valuetosearch As String, ByVal q As String)
        Try
            con = New MySqlConnection(cs)
            Dim search As String = q & " LIKE '%" & Valuetosearch & "%'"
            Dim cmd As New MySqlCommand(search, con)
            Dim da As New MySqlDataAdapter(cmd)
            Dim table As New DataTable
            da.Fill(table)
            Return table
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

#End Region

#Region "Count records in the table"
    Public Function record_count(ByVal a As String)
        Try
            con = New MySqlConnection(cs)
            cmd = New MySqlCommand(a, con)
            adp = New MySqlDataAdapter(cmd)
            tb = New DataTable
            adp.Fill(tb)
            Return tb.Rows.Count
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
#End Region

#Region "get a string from a database table"
    Public Function getValue(ByVal query As String)
        Try
            con = New MySqlConnection(cs)
            con.Open()
            cmd = New MySqlCommand(query, con)
            Return cmd.ExecuteScalar
            con.Close()
        Catch ex As Exception
            Return "Null"
        End Try
    End Function
#End Region

#Region "get a number from a database table"
    Public Function getnumber(ByVal query As String)
        Try
            con = New MySqlConnection(cs)
            con.Open()
            cmd = New MySqlCommand(query, con)
            Return CDbl(cmd.ExecuteScalar)
            con.Close()
        Catch ex As Exception
            con.Close()
            Return 0
        End Try
    End Function
#End Region

#Region "set academic-year and term"
    Public Sub SetAcademic()
        Try
            con = New MySqlConnection(cs)
            con.Open()
            cmd = New MySqlCommand("select * from academic_year where next_term <= '" & Now.Date.ToString("yyyy-MM-dd") & "' and status='1' and sid = '" & sid & "'", con)
            adp = New MySqlDataAdapter(cmd)
            tb = New DataTable
            adp.Fill(tb)
            If tb.Rows.Count > 0 Then
                cmd2 = New MySqlCommand("update academic_year set status='0' where id='" + tb.Rows(0)(0).ToString + "' and sid = '" & sid & "'", con)
                cmd2.ExecuteNonQuery()
            End If
            cmd3 = New MySqlCommand("select * from academic_year where term_starts <= '" & Now.Date.ToString("yyyy-MM-dd") & "' and term_ends > '" & Now.Date.ToString("yyyy-MM-dd") & "' and status='0' and sid ='" & sid & "'", con)
            adp2 = New MySqlDataAdapter(cmd3)
            tb2 = New DataTable
            adp2.Fill(tb2)
            If tb2.Rows.Count > 0 Then
                cmd4 = New MySqlCommand("update academic_year set status='1' where id='" + tb2.Rows(0)(0).ToString + "' and sid = '" & sid & "'", con)
                cmd4.ExecuteNonQuery()
            End If
            cmd5 = New MySqlCommand("select * from academic_year where status ='1' and sid = '" & sid & "'", con)
            adp3 = New MySqlDataAdapter(cmd5)
            tb3 = New DataTable
            adp3.Fill(tb3)
            If tb3.Rows.Count > 0 Then
                academic_year = tb3.Rows(0)(1).ToString
                term = tb3.Rows(0)(2).ToString
            End If
            con.Close()
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
#End Region

#Region "validate email"
    Public Function validateEmail(emailAddress) As Boolean
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "Calculate days present"
    Public Sub present()
        Try
            Dim d As Date = Date.Now
            Dim month As DateTime = d.AddMonths(-1).ToString("yyy-MM-dd")
            Dim sl As Decimal = 0
            con = New MySqlConnection(cs)
            con.Open()
            cmd = New MySqlCommand("SELECT * FROM staff LEFT JOIN salary on staff.staff_id = salary.staff_id where staff.sid = '" & sid & "'", con)
            adp = New MySqlDataAdapter(cmd)
            tb = New DataTable
            adp.Fill(tb)
            For i As Integer = 0 To tb.Rows.Count - 1 Step +1
                'cmd2 = New MySqlCommand("select * from attendance where Staff_ID= '" + tb.Rows(i)("Staff_ID").ToString + "' and Date(Date) between ('" & month & "' and '" & LastMonthEndDate() & "') and sid = '" & sid & "'", con)
                'cmd4 = New MySqlCommand("select sum(Hours) from attendance where Staff_ID= '" + tb.Rows(i)("Staff_ID").ToString + "' and Date(Date) between ('" & month & "' and '" & LastMonthEndDate() & "') and sid = '" & sid & "'", con)
                cmd2 = New MySqlCommand("select * from attendance where Staff_ID= '" + tb.Rows(i)("Staff_ID").ToString + "' and DAYOFMONTH(Date) = '" & mm & "' and sid = '" & sid & "'", con)
                cmd4 = New MySqlCommand("select sum(Hours) from attendance where Staff_ID= '" + tb.Rows(i)("Staff_ID").ToString + "' and DAYOFMONTH(Date) = '" & mm & "' and sid = '" & sid & "'", con)
                Dim hr As Integer = cmd4.ExecuteScalar
                adp2 = New MySqlDataAdapter(cmd2)
                tb2 = New DataTable
                adp2.Fill(tb2)
                Dim h As Integer = 0
                Dim p As Integer = 0
                Dim cut As Decimal = 0
                Dim df As Integer = 0
                Dim s As Decimal = 0
                Dim wk As Integer = 0
                Dim total_LeaveDays As Integer = 0
                h = tb.Rows(0)("hours").ToString
                If tb.Rows(0)("Start_Date").ToString = "" Or tb.Rows(0)("End_Date").ToString = "" Then
                    wk = h * Weekdays()
                    sl = tb.Rows(0)("salary").ToString
                    df = wk - hr
                    cut = sl / wk
                    s = sl - (cut * df)
                Else
                    Dim leaveStart As Date = tb.Rows(0)("Start_Date")
                    Dim leaveend As Date = tb.Rows(0)("End_Date")
                    If leaveStart.Month <= mm And academic_year = tb.Rows(0)("academic").ToString And leaveend.Month <= Now.Date.Month - 1 Then
                        Dim wkend As Integer = 0
                        If leaveStart.Month = mm And leaveend.Month = mm Then
                            wkend = Weekends(leaveStart, leaveend)
                            total_LeaveDays = (Val((leaveend - leaveStart).ToString("dd")) + 1) - wkend
                            hr = hr + (h * total_LeaveDays)
                        ElseIf leaveStart.Month = mm And Not leaveend.Month = mm Then
                            Dim EndLastDate As Date = LastMonthEndDate()
                            wkend = Weekends(leaveStart, EndLastDate)
                            total_LeaveDays = (Val((leaveend - leaveStart).ToString("dd")) + 1) - wkend
                            hr = hr + (h * total_LeaveDays)
                        Else
                            wkend = Weekends(LastMontFrmDate, LastMonthEndDate)
                            Dim StartLastDate As Date = LastMontFrmDate()
                            Dim EndLastDate As Date = LastMonthEndDate()
                            total_LeaveDays = (Val(((EndLastDate - StartLastDate).ToString("dd") + 1)) - wkend)
                            hr = h * total_LeaveDays
                        End If
                        wk = h * Weekdays()
                        sl = tb.Rows(0)("salary").ToString
                        df = wk - hr
                        cut = sl / wk
                        s = sl - (cut * df)
                    End If
                End If
                execute("update payroll set Days_Present='" & p & "',Total_Leave_Days='" & total_LeaveDays & "',Total_Hours='" & wk & "',Hours_Present='" & hr & "',Working_Days='" & Weekdays() & "',Payment='" & s & "' where Staff_ID = '" + tb.Rows(i)("Staff_ID").ToString + "' and Academic ='" & academic_year & "' and Month='" & mm & "' and sid = '" & sid & "' and NOT manual = 1", 3)
            Next i
            con.Close()
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
#End Region

#Region "monthly attendance"
    Public Sub monthatt()
        Dim ac As Integer = record_count("select * from academic_year where status= '1' and sid = '" & sid & "'")
        If ac > 0 Then
            mm = Now.Date.Month
            'If mm = 0 Then
            '    mm = 12
            'End If
            Try
                'Dim first As Integer
                'first = Now.Date.Day
                'If first = 1 Or first = 5 Or first = 8 Then
                Dim lm As Integer = 0
                    lm = Now.Date.Month - 1
                    Dim tb6 As New DataTable
                    tb6 = ShowData("select * from staff where sid = '" & sid & "'")
                    For i As Integer = 0 To tb6.Rows.Count - 1
                        Dim num As Integer = record_count("select * from payroll where Staff_ID = '" & tb6.Rows(i)("staff_id").ToString & "' and Academic='" & academic_year & "' and Month= '" & mm & "' and sid = '" & sid & "'")
                        If num < 1 Then
                            Dim salary As Double = getnumber("select salary from salary where staff_id = '" & tb6.Rows(i)("staff_id").ToString & "' and sid = '" & sid & "'")
                            execute("insert into payroll(Staff_ID,Name,initial_Salary,Academic,Month,sid) values ('" + tb6.Rows(i)("staff_id").ToString + "','" + tb6.Rows(i)("fullname").ToString + "','" & salary & "','" & academic_year & "','" & mm & "','" & sid & "') ", 3)
                        End If
                    Next
                    present()
                '   End If
            Catch ex As Exception
                showerror(ex.Message)
            End Try
        End If
    End Sub

#End Region

#Region "calculate working days"
    Public Function Weekdays()
        Dim d As Date = Date.Now
        Dim startDate As Date = startmonth()
        Dim endDate As Date = finaldate()
        Dim numWeekdays As Integer
        Dim totalDays As Integer
        Dim WeekendDays As Integer
        Dim mm As Integer = Now.Date.Month - 1
        numWeekdays = 0
        WeekendDays = 0
        totalDays = DateDiff(DateInterval.Day, startDate, endDate) + 1
        For i As Integer = 1 To totalDays
            If DatePart(DateInterval.Weekday, startDate) = 1 Then
                WeekendDays = WeekendDays + 1
            End If
            If DatePart(DateInterval.Weekday, startDate) = 7 Then
                WeekendDays = WeekendDays + 1
            End If
            startDate = DateAdd("d", 1, startDate)
        Next
        numWeekdays = totalDays - WeekendDays
        'deducting public holidays
        If mm = 0 Then
            numWeekdays = numWeekdays - 3
        ElseIf mm = 1 Then
            numWeekdays = numWeekdays - 2
        ElseIf mm = 3 Then
            numWeekdays = numWeekdays - 1
        ElseIf mm = 4 Then
            numWeekdays = numWeekdays - 2
        ElseIf mm = 5 Then
            numWeekdays = numWeekdays - 3
        ElseIf mm = 7 Then
            numWeekdays = numWeekdays - 2
        ElseIf mm = 8 Then
            numWeekdays = numWeekdays - 1
        ElseIf mm = 9 Then
            numWeekdays = numWeekdays - 1
        End If
        Return numWeekdays
    End Function
#End Region

#Region "calculate number of weeKends"
    Public Function Weekends(ByVal st As Date, ByVal et As Date)
        Dim d As Date = Date.Now
        Dim month As DateTime = st
        Dim startDate As Date = month
        Dim endDate As Date = et
        Dim numWeekdays As Integer
        Dim totalDays As Integer
        Dim WeekendDays As Integer
        Dim mm As Integer = Now.Date.Month - 1
        numWeekdays = 0
        WeekendDays = 0
        totalDays = DateDiff(DateInterval.Day, startDate, endDate) + 1
        For i As Integer = 1 To totalDays
            If DatePart(DateInterval.Weekday, startDate) = 1 Then
                WeekendDays = WeekendDays + 1
            End If
            If DatePart(DateInterval.Weekday, startDate) = 7 Then
                WeekendDays = WeekendDays + 1
            End If
            startDate = DateAdd("d", 1, startDate)
        Next
        numWeekdays = WeekendDays
        'adding public holidays
        If mm = 0 Then
            numWeekdays = numWeekdays + 3
        ElseIf mm = 1 Then
            numWeekdays = numWeekdays + 2
        ElseIf mm = 3 Then
            numWeekdays = numWeekdays + 1
        ElseIf mm = 4 Then
            numWeekdays = numWeekdays + 2
        ElseIf mm = 5 Then
            numWeekdays = numWeekdays + 3
        ElseIf mm = 7 Then
            numWeekdays = numWeekdays + 2
        ElseIf mm = 8 Then
            numWeekdays = numWeekdays + 1
        ElseIf mm = 9 Then
            numWeekdays = numWeekdays + 1
        End If
        Return numWeekdays
    End Function
#End Region

#Region "final todate"
    Public Function finaldate()
        Dim tdd As Date
        mm = Now.Date.Month - 1
        Dim y As Integer = Now.Date.Year
        If mm = 0 Then
            mm = 12
            y = y - 1
        End If
        tdd = mm & "/" & TotalDays() & "/" & y
        Return tdd
    End Function
#End Region

#Region "to get start month date"
    Public Function startmonth()
        Dim mm As New Integer

        Dim tdd As Date
        mm = Now.Date.Month - 1
        Dim y As Integer = Now.Date.Year
        If mm = 0 Then
            mm = 12
            y = y - 1
        End If
        tdd = mm & "/" & 1 & "/" & y
        Return tdd
    End Function
#End Region

#Region "income calculation"
    Public Sub calculate_income()
        If Now.Date.Day = 1 Or Now.Date.Day = 3 Then
            Dim m, y As Integer
            m = (Now.Date.Month - 1)
            If m = 0 Then
                m = 12
                y = Now.Date.Year - 1
            End If
            Try
                Dim cc As Integer = record_count("select * from cheques where Date between '" & LastMontFrmDate() & "' and ' " & LastMonthEndDate() & "'and sid = '" & sid & "'")
                If cc > 0 Then
                    Dim id As String = "CHQ" & y & m
                    Dim row As Integer = record_count("select * from income where Income_ID = '" & id & "' and sid = '" & sid & "'")
                    Dim csum As Double = getnumber("select sum(Amount) from cheques where type = 'Credit' and Cheque_Date between '" & LastMontFrmDate() & "' and ' " & LastMonthEndDate() & "' and sid = '" & sid & "'")
                    con = New MySqlConnection(cs)
                    con.Open()
                    If row < 1 Then
                        cmd = New MySqlCommand("insert into income(`Income_ID`, `Name`, `Type`, `Amount`, `Academic`, `Term`, `Description`, `Paid_by`,sid) values ('" & id & "','Cheques','Credited','" & csum & "','" & academic_year & "','" & term & "','Cheques receieved by the school','Unknown','" & sid & "')", con)
                        cmd.ExecuteNonQuery()
                        showinfo("This month credited cheques have been calculated And saved!")
                    Else
                        cmd = New MySqlCommand("Update `income` Set `Name`='Cheques',`Type`='Credited,`Amount`='" & csum & "',`Academic`='" & academic_year & "',`Term`='" & term & "',`Description`='Cheques receieved by the school',`Paid_by`='Unknown' WHERE `Income_ID`='" & id & "' and sid = '" & sid & "'", con)
                        cmd.ExecuteNonQuery()
                        showinfo("This month's credited cheques have been calculated and updated!")
                    End If
                    con.Close()
                End If
            Catch ex As Exception
                con.Close()
                showerror(ex.Message)
            End Try
        End If
    End Sub
#End Region

#Region "calculate expenses"
    Public Sub calculate_expenses()
        If Now.Date.Day = 1 Or Now.Date.Day = 3 Then

            Try
                Dim cc As Integer = record_count("select * from cheques where Date between '" & frmdate() & "' and ' " & todate() & "' and sid = '" & sid & "'")
                If cc > 0 Then
                    Dim months As Integer = Now.Date.Month - 1
                    Dim id As String = "CHQ" & Now.Date.Year & Now.Date.Month
                    Dim id2 As String = "SLR" & Now.Date.Year & Now.Date.Month
                    Dim row As Integer = record_count("select * from expenses where Expenses_ID = '" & id & "' and sid= '" & sid & "'")
                    Dim row2 As Integer = record_count("select * from expenses where Expenses_ID = '" & id2 & "' and sid = '" & sid & "'")
                    Dim csum As Double = getnumber("select sum(Amount) from cheques where Type = 'Debit' and Cheque_Date between '" & frmdate() & "' and ' " & todate() & "' and sid = '" & sid & "'")
                    Dim salary As Double = getnumber("select sum(Payment) from payroll where month ='" & months & "' and sid = '" & sid & "'")
                    Dim total As String = "Debit Cheques"
                    If row < 1 Then
                        execute("INSERT INTO `expenses`(`Expenses_ID`,`Record`, `Academic`, `Term`,Total,sid) VALUES ('" + id + "','" & total & "','" + academic_year + "','" + term + "','" & csum & "','" & sid & "') ", 3)
                    Else
                        execute("UPDATE `expenses` SET Total='" & csum & "' WHERE Expenses_ID='" & id & "' and sid = '" & sid & "'", 3)
                    End If
                    If row2 < 1 Then
                        execute("INSERT INTO `expenses`(`Expenses_ID`,`Record`, `Academic`, `Term`,Total,sid) VALUES ('" + id2 + "','Salary Total','" + academic_year + "','" + term + "','" & salary & "','" & sid & "')", 3)
                    Else
                        execute("UPDATE `expenses` SET Total='" & salary & "' WHERE Expenses_ID='" & id & "' and sid = '" & sid & "'", 3)
                    End If
                End If
            Catch ex As Exception
                showerror(ex.Message)
            End Try
        End If
    End Sub
#End Region

#Region "User Function Limit"
    Public Sub user_limit(ByVal user_name As String)
        Dim tb As New DataTable
        tb = ShowData("select * from users where sid= '" & sid & "' and Username ='" & user_name & "'")
        staffid = tb.Rows(0)(0).ToString
        staff_name = tb.Rows(0)(1).ToString
        ul = tb.Rows(0)(4).ToString
        Home.Show()
        tclass = ""
        Home.user.Text = tb.Rows(0)(2).ToString
        tclass = getValue("select classes from staff where staff_id ='" & staffid & "' and sid ='" & sid & "' and classes is not NULL")
        If tb.Rows(0)(7).ToString = "0" Then
            Dim rs As New reset_account
            rs.ShowDialog()
        End If
    End Sub
#End Region

End Module
