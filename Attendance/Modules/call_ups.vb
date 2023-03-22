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
            dy = "31"
        ElseIf m = "1" Then
            dy = "31"
        ElseIf m = "3" Then
            dy = "31"
        ElseIf m = "5" Then
            dy = "31"
        ElseIf m = "7" Then
            dy = "31"
        ElseIf m = "8" Then
            dy = "31"
        ElseIf m = "10" Then
            dy = "31"
        ElseIf m = "6" Then
            dy = "30"
        ElseIf m = "4" Then
            dy = "30"
        ElseIf m = "9" Then
            dy = "30"
        ElseIf m = "11" Then
            dy = "30"
        ElseIf m = "2" Then
            dy = "28"
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





#Region "calculate working days"
    Public Function Weekdays()
        Dim d As Date = Date.Now
        Dim month As DateTime = d.AddMonths(-1)
        Dim startDate As Date = month
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





End Module
