Imports MySql.Data.MySqlClient

Public Class addAttendance
    Dim mm As New Integer

    Private Sub addAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
        mm = Now.Date.Month
        Try
            txtstaff.DataSource = New BindingSource(ShowData("select * from staff where sid = '" & sid & "'"), Nothing)
            txtstaff.DisplayMember = "fullname"
            txtstaff.Items.Add("")
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub txtstaff_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles txtstaff.SelectedIndexChanged
        txtstaff_id.Text = getValue("select staff_id from staff where sid='" & sid & "' and fullname= '" & txtstaff.Text & "'")
    End Sub

    Private Sub cadd_Click(sender As Object, e As EventArgs) Handles cadd.Click
        If txtstaff.Text = "" Or txtdays.Text = "" Then
            showerror("Please provide the required information")
            Exit Sub
        ElseIf Not IsNumeric(txtdays.Text) Then
            showerror("Input must be numbers only")
            Exit Sub
        Else
            Try

                'If mm = 0 Then
                '    mm = 12
                'End If
                Dim psl As New DataTable
                Dim num As Integer = record_count("select * from payroll where Staff_ID = '" & txtstaff_id.Text & "' and Academic='" & academic_year & "' and Month= '" & mm & "' and sid = '" & sid & "'")
                psl = ShowData("select * from salary where Staff_ID = '" & txtstaff_id.Text & "' and sid = '" & sid & "'")
                If psl.Rows.Count > 0 Then
                    If num < 1 Then
                        execute("insert into payroll(Staff_ID,Name,initial_Salary,Academic,Month,sid) values ('" + txtstaff_id.Text + "','" + txtstaff.Text + "','" & psl.Rows(0)("salary").ToString & "','" & academic_year & "','" & mm & "','" & sid & "') ", 3)
                    End If
                    Dim h As Integer = Val(psl.Rows(0)("hours").ToString)
                    Dim t_hours As Integer
                    t_hours = Val(txtdays.Text) * h
                    Dim atcount As Integer = record_count("Select * from attendance where Staff_ID = '" & txtstaff_id.Text & "' and sid='" & sid & "' and  DAYOFMONTH(Date) = '" & mm & "'")
                    If atcount > 0 Then
                        Dialog1.Label1.Text = "Are you sure you want modify the attendance of : " & txtstaff.Text
                        Dialog1.ShowDialog()
                        If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                            execute("update attendance set Hours = '" & t_hours & "' where sid ='" & sid & "' and Staff_ID = '" & txtstaff_id.Text & "' and  DAYOFMONTH(Date) = '" & mm & "'", 3)
                            Manual_present(txtdays.Text, txtstaff_id.Text)
                            showinfo("Data was successfuly updated")
                        Else
                            Exit Sub
                        End If
                    Else
                        execute("INSERT INTO `attendance`( `Staff_ID`, `Name`, `In_Time`, `Out_Time`, `Hours`, `Date`, `sid`) VALUES ('" & txtstaff_id.Text & "','" & txtstaff.Text & "','0','0','" & t_hours & "','" & Now.Date.ToString("yyyy-MM-dd") & "','" & sid & "')", 0)
                        Manual_present(txtdays.Text, txtstaff_id.Text)
                        showinfo("Data was successfuly saved")
                    End If
                Else
                    showinfo("Salary record is empty. Please go 'Transaction--> Salary' to input data!")
                End If
            Catch ex As Exception
                showerror(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Manual_present(ByVal days As Integer, ByVal staffid As String)
        Try
            Dim d As Date = Date.Now
            Dim month As DateTime = d.AddMonths(-1).ToString("yyy-MM-dd")
            Dim sl As Decimal = 0
            con = New MySqlConnection(cs)
            con.Open()
            cmd = New MySqlCommand("SELECT * FROM staff LEFT JOIN salary on staff.staff_id = salary.staff_id where staff.sid = '" & sid & "' and staff.staff_id ='" & staffid & "'", con)
            adp = New MySqlDataAdapter(cmd)
            tb = New DataTable
            adp.Fill(tb)
            cmd2 = New MySqlCommand("select * from attendance where Staff_ID= '" + tb.Rows(0)("Staff_ID").ToString + "' and DAYOFMONTH(Date) = '" & mm & "' and sid = '" & sid & "'", con)
            cmd4 = New MySqlCommand("select sum(Hours) from attendance where Staff_ID= '" + tb.Rows(0)("Staff_ID").ToString + "' and DAYOFMONTH(Date) = '" & mm & "' and sid = '" & sid & "'", con)
            Dim hr As Integer = cmd4.ExecuteScalar
            adp2 = New MySqlDataAdapter(cmd2)
            tb2 = New DataTable
            adp2.Fill(tb2)
            Dim h As Integer = 0
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
            execute("update payroll set Days_Present='" & days & "',Total_Leave_Days='" & total_LeaveDays & "',Total_Hours='" & wk & "',Hours_Present='" & hr & "',Working_Days='" & Weekdays() & "',Payment='" & s & "',manual = '1' where Staff_ID = '" + tb.Rows(0)(0).ToString + "' and Academic ='" & academic_year & "' and Month='" & mm & "' and sid = '" & sid & "'", 3)
            con.Close()
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
    Private Sub cclear_Click(sender As Object, e As EventArgs) Handles cclear.Click
        Clear(Me)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub txtstaff_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtstaff.SelectedValueChanged
        txtstaff_id.Text = getValue("select staff_id from staff where sid='" & sid & "' and fullname= '" & txtstaff.Text & "'")
    End Sub
End Class