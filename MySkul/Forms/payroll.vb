Imports MySql.Data.MySqlClient
Public Class payroll
    Dim report As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Dim sc As New DataTable
    Dim fpath As String
    Dim hpath As String

    Sub payroll_bindgrid()
        querryString = "SELECT  `Staff_ID`, `Name`, `Working_Days`, `Days_Present`, `Total_Hours`, `Hours_Present`, `Initial_Salary`, `Payment`, `Month`, `Total_Leave_Days`, `Academic`, `Date` FROM `payroll` where sid ='" & sid & "' order by Date DESC"
        payrollgrid.DataSource = ShowData(querryString)
        Try
            Me.payrollgrid.AutoSize = False
            Me.payrollgrid.BestFitColumns()

            Me.payrollgrid.Columns("Staff_ID").Width = 100
            Me.payrollgrid.Columns("Name").Width = 250
            Me.payrollgrid.Columns("Working_Days").Width = 120
            Me.payrollgrid.Columns("Days_Present").Width = 120
            Me.payrollgrid.Columns("Date").Width = 200
            Me.payrollgrid.Columns("Total_Hours").Width = 120
            Me.payrollgrid.Columns("Initial_Salary").Width = 120
            Me.payrollgrid.Columns("Payment").Width = 120
            Me.payrollgrid.Columns("Month").Width = 80
            Me.payrollgrid.Columns("Academic").Width = 100
            Me.payrollgrid.Columns("Total_Leave_Days").Width = 120
            For i As Integer = 0 To Me.payrollgrid.ColumnCount - 1
                Me.payrollgrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
    Sub attendance_bindgrid()
        querryString = "SELECT  `Staff_ID`, `Name`, `In_Time`, `Out_Time`, `Hours`, `Date` FROM `attendance` where sid='" & sid & "' order by Date DESC"
        attgrid.DataSource = ShowData(querryString)
        Try
            Me.attgrid.AutoSize = False
            Me.attgrid.BestFitColumns()

            Me.attgrid.Columns("Staff_ID").Width = 100
            Me.attgrid.Columns("Name").Width = 350
            Me.attgrid.Columns("In_time").Width = 100
            Me.attgrid.Columns("Out_Time").Width = 100
            Me.attgrid.Columns("Date").Width = 200
            Me.attgrid.Columns("Hours").Width = 100
            For i As Integer = 0 To Me.attgrid.ColumnCount - 1
                Me.attgrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
    Private Sub payroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        payroll_bindgrid()
        attendance_bindgrid()
        adate.Value = Now.Date
        Try
            txtpname.DataSource = New BindingSource(ShowData("select fullname from staff where sid = '" & sid & "'"), Nothing)
            txtpname.DisplayMember = "fullname"
            txtpname.Items.Add(" ")

            txtaname.DataSource = New BindingSource(ShowData("select fullname from staff where sid = '" & sid & "'"), Nothing)
            txtaname.DisplayMember = "fullname"
            txtaname.Items.Add(" ")

            srstaff.DataSource = New BindingSource(ShowData("select fullname from staff where sid = '" & sid & "'"), Nothing)
            srstaff.DisplayMember = "fullname"
            srstaff.Items.Add(" ")

            txtacademic.DataSource = New BindingSource(ShowData("select * from academic_year where sid = '" & sid & "' group by academic"), Nothing)
            txtacademic.DisplayMember = "academic"

            sraca.DataSource = New BindingSource(ShowData("select * from academic_year where sid = '" & sid & "' group by academic"), Nothing)
            sraca.DisplayMember = "academic"


            sc = ShowData("select * from school_profile where sid = '" & sid & "'")
            fpath = Application.StartupPath & "Images\School Profile\" & sc.Rows(0)("sign_finance").ToString
            hpath = Application.StartupPath & "Images\School Profile\" & sc.Rows(0)("sign_head").ToString
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub cmdasearch_Click(sender As Object, e As EventArgs) Handles cmdasearch.Click
        If txtaname.Text = "" Then
            showerror("Please select a staff name you want to search")
            Exit Sub
        Else
            attgrid.DataSource = ShowData("select  `Staff_ID`, `Name`, `In_Time`, `Out_Time`, `Hours`, `Date` from attendance where Name ='" + txtaname.Text + "' and Date(Date) = '" + adate.Value.ToString("yyyy-MM-dd") + "' and sid = '" & sid & "'")
            If attgrid.Rows.Count > 0 Then
                intime.Text = "In time : " & attgrid.Rows(0).Cells(2).Value.ToString
                outtime.Text = "Out time : " & attgrid.Rows(0).Cells(3).Value.ToString
                hours.Text = "Hours " & attgrid.Rows(0).Cells(4).Value.ToString
            End If
        End If
    End Sub

    Private Sub arefresh_Click(sender As Object, e As EventArgs) Handles arefresh.Click
        attendance_bindgrid()
    End Sub

    Private Sub prefesh_Click(sender As Object, e As EventArgs) Handles prefesh.Click
        payroll_bindgrid()
    End Sub

    Private Sub cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        If txtpname.Text = "" Or txtacademic.Text = "" Or txtpmonth.Text = "" Then
            showerror("Please select the required information!")
            Exit Sub
        Else
            payrollgrid.DataSource = ShowData("select  `Staff_ID`, `Name`, `Working_Days`, `Days_Present`, `Total_Hours`, `Hours_Present`, `Initial_Salary`, `Payment`, `Month`, `Total_Leave_Days`, `Academic`, `Date` from payroll where Name='" + txtpname.Text + "' and Month='" + txtpmonth.Text + "' and Academic='" + txtacademic.Text + "' and sid = '" & sid & "'")
            If payrollgrid.Rows.Count > 0 Then
                wd.Text = "Working Days : " & payrollgrid.Rows(0).Cells(2).Value.ToString
                dp.Text = "Days Present : " & payrollgrid.Rows(0).Cells(3).Value.ToString & " + " & payrollgrid.Rows(0).Cells(9).Value.ToString & " leave days"
                sl.Text = "Salary : " & payrollgrid.Rows(0).Cells(7).Value.ToString
            End If
        End If
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Dim attend As New addAttendance
        attend.ShowDialog()
    End Sub

    Private Sub RadGroupBox7_Click(sender As Object, e As EventArgs) Handles RadGroupBox7.Click

    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
        If srstaff.Text = "" Or srmonth.Text = "" Or sraca.Text = "" Then
            showerror("Please select the required information")
            Exit Sub
        Else
            Try
                Me.Cursor = Cursors.WaitCursor
                Dim head As String
                Dim prf As New DataTable
                prf = ShowData("SELECT  `Staff_ID`, `Name`, `Working_Days`, `Days_Present`, `Total_Hours`, `Hours_Present`, `Initial_Salary`, `Payment`, `Month`, `Total_Leave_Days`, `Academic` FROM `payroll` WHERE  sid= '" & sid & "' and Academic = '" & sraca.Text & "' and Month = '" & srmonth.Text & "' and Name = '" & srstaff.Text & "'")
                head = UCase("payment slip of month: " & srmonth.Text & ", " & sraca.Text & " academic year")
                If prf.Rows.Count > 0 Then
                    report = New payment
                    report.SetDataSource(prf)
                    report.SetParameterValue("sname", sc.Rows(0)("name").ToString)
                    report.SetParameterValue("location", sc.Rows(0)("address").ToString)
                    report.SetParameterValue("contact", sc.Rows(0)("phone").ToString)
                    report.SetParameterValue("fsign", fpath)
                    report.SetParameterValue("hsign", hpath)
                    report.SetParameterValue("head", head)
                    crpay.ReportSource = report
                Else
                    showinfo("No record was found!")
                End If
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                showerror(ex.Message)
            End Try
        End If
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        Me.Cursor = Cursors.WaitCursor
        Dim docprint As System.Drawing.Printing.PrintDocument
        docprint = New System.Drawing.Printing.PrintDocument
        Dim dfp As String = docprint.PrinterSettings.PrinterName
        report.PrintOptions.PrinterName = dfp
        report.PrintToPrinter(1, False, 0, 0)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles RadButton4.Click
        If bm.Text = "" Or ba.Text = "" Then
            showerror("Please select the required information")
            Exit Sub
        Else
            Try
                Me.Cursor = Cursors.WaitCursor
                Dim head As String
                Dim prf As New DataTable
                prf = ShowData("SELECT  `Staff_ID`, `Name`, `Working_Days`, `Days_Present`, `Total_Hours`, `Hours_Present`, `Initial_Salary`, `Payment`, `Month`, `Total_Leave_Days`, `Academic` FROM `payroll` WHERE  sid= '" & sid & "' and Academic = '" & sraca.Text & "' and Month = '" & srmonth.Text & "' and Name = '" & srstaff.Text & "'")
                head = UCase("payment slip of month: " & srmonth.Text & ", " & sraca.Text & " academic year")
                If prf.Rows.Count > 0 Then
                    For i As Integer = 0 To prf.Rows.Count - 1
                        report = New payment
                        report.SetDataSource(prf)
                        report.SetParameterValue("sname", sc.Rows(0)("name").ToString)
                        report.SetParameterValue("location", sc.Rows(0)("address").ToString)
                        report.SetParameterValue("contact", sc.Rows(0)("phone").ToString)
                        report.SetParameterValue("fsign", fpath)
                        report.SetParameterValue("hsign", hpath)
                        report.SetParameterValue("head", head)
                        Dim docprint As System.Drawing.Printing.PrintDocument
                        docprint = New System.Drawing.Printing.PrintDocument
                        Dim dfp As String = docprint.PrinterSettings.PrinterName
                        report.PrintOptions.PrinterName = dfp
                        report.PrintToPrinter(1, False, 0, 0)
                    Next
                Else
                    showinfo("No record was found!")
                End If
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                showerror(ex.Message)
            End Try
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        attendance_bindgrid()
    End Sub
End Class