Imports MySql.Data.MySqlClient
Public Class addincome

    Private Sub cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        Dialog1.Label1.Text = "Payment of : " + txtamount.Text + " in name of :" + txtstname.Text + "." & vbCrLf & vbCrLf & "Do you want to proceed?"
        Dialog1.ShowDialog()
        If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
            Try
                txtinid.Text = "DES-" & academic_year & "-" & Now.Date.Month & "-" & term & "-" & DateTime.Now.Second & Now.Date.Day
                If cmdadd.Text = "Print" Then
                    'print only
                Else
                    If txtstname.Text = "" Or txtamount.Text = "" Or txtpaid.Text = "" Or txttype.Text = "" Or txtinid.Text = "" Then
                        showerror("Please do not leave any field empty!")
                        Exit Sub
                    ElseIf txtstname.Text = "None" And txtdes.Text = "" Then
                        showerror("Please provide the description of the income!")
                        Exit Sub
                    Else
                        Me.Cursor = Cursors.WaitCursor
                        execute("INSERT INTO `income`(`Income_ID`,`Student_ID`, `Name`, `Type`, `Amount`, `Academic`, `Term`, `Description`, `Paid_by`,`sid`) VALUES ('" + txtinid.Text + "','" & lblstid.Text & "','" + txtstname.Text + "','" + txttype.Text + "','" + txtamount.Text + "','" + academic_year + "','" + term + "','" + txtdes.Text + "','" + txtpaid.Text + "','" & sid & "')", 0)
                        tb4 = New DataTable

                        tb4 = ShowData("select * from student_debt where Student_ID='" & txtstudent_id.Text & "' and Academic='" & academic_year & "' and Term='" & term & "' and Previous_Debt >= '" & txtamount.Text & "' and sid='" & sid & "'")
                        If tb4.Rows.Count > 0 Then
                            Dim debt As Double = Val(tb4.Rows(0)(7).ToString)
                            Dim sub_total As Double = Val(tb4.Rows(0)(9).ToString)
                            Dim new_debt As Double = debt - Val(txtamount.Text)
                            Dim total_debt As Double = sub_total - Val(txtamount.Text)
                            execute("Update student_debt set Previous_Debt='" & new_debt & "',Total_Debt='" & total_debt & "' where Student_ID='" & txtstudent_id.Text & "' and Academic='" & academic_year & "' and Term='" & term & "' and sid='" & sid & "'", 3)
                        Else
                            Dim debt As Double = getValue("select Total_Debt from student_debt where Student_ID='" & txtstudent_id.Text & "' and Academic='" & academic_year & "' and Term='" & term & "' and sid = '" & sid & "' ")
                            Dim new_debt As Double = debt - Val(txtamount.Text)
                            execute("Update student_debt set  Current_Debt='" & new_debt & "',Total_Debt='" & new_debt & "' where Student_ID='" & txtstudent_id.Text & "' and Academic='" & academic_year & "' and Term='" & term & "' and sid = '" & sid & "'", 3)
                        End If
                        execute("update income set recorded = '1' where Income_ID ='" & txtinid.Text & "'and sid='" & sid & "'", 3)
                        debt.Visible = False
                        If radioprint.IsChecked = True Then
                            'save and print
                        End If
                        Me.Cursor = Cursors.Default
                    End If
                End If
                ErrorProvider1.Clear()
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                ErrorProvider1.Clear()
                showerror(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        txtinid.Text = ""
        ErrorProvider1.Clear()
        cmdadd.Text = "Save"
    End Sub

    Private Sub cmddelete_Click(sender As Object, e As EventArgs) Handles cmddelete.Click
        Dialog1.Label1.Text = "Are you sure you want to delete a record of Income number: " + txtinid.Text
        Dialog1.ShowDialog()
        If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
            execute("INSERT INTO `deletedincome`(`Income_ID`, `Name`, `Type`, `Amount`, `Academic`, `Term`, `Description`, `Paid_by`,`Deleted_by`,`sid`) VALUES ('" + txtinid.Text + "','" + txtstname.Text + "','" + txttype.Text + "','" + txtamount.Text + "','" + academic_year + "','" + term + "','" + txtdes.Text + "','" + txtpaid.Text + "','" + Home.user.Text + "','" & sid & "')", 3)
            tb = New DataTable
            tb = ShowData("select * from student_debt where sid = '" & sid & "' and Fullname = '" & txtstname.Text & "' and Academic = '" & academic_year & "' and term = '" & term & "'")
            If tb.Rows.Count > 0 Then
                Dim debt As Double = getnumber("select Total_Debt from student_debt where sid = '" & sid & "' and Fullname = '" & txtstname.Text & "' and Academic = '" & academic_year & "' and term = '" & term & "' ")
                Dim new_debt As Double = debt + txtamount.Text
                execute("update student_debt set Total_Debt = '" & new_debt & "' where Fullname= '" & txtstname.Text & "'and Academic='" & academic_year & "' and Term = '" & term & "' and sid ='" & sid & "'", 3)
            Else
                Dim old_term As Integer = getnumber("select term from academic_year where  id = (select (max(id)-1) from academic_year where sid = '" & sid & "')")
                Dim old_academic As String = getValue("select academic from academic_year where  id = (select (max(id)-1) from academic_year sid='" & sid & "') ")
                Dim debt As Double = getnumber("select Total_Debt from student_debt where sid = '" & sid & "' and Fullname = '" & txtstname.Text & "' and Academic = '" & old_academic & "' and term = '" & old_term & "' ")
                Dim new_debt As Double = debt + txtamount.Text
                execute("update student_debt set Total_Debt = '" & new_debt & "' where Fullname= '" & txtstname.Text & "'and Academic='" & old_academic & "' and Term = '" & old_term & "' and sid='" & sid & "'", 3)
            End If
            execute("delete from income where Income_ID = '" + txtinid.Text + "' and sid = '" & sid & "'", 2)
            Clear(Me)
            ErrorProvider1.Clear()
            cmdadd.Text = "Save"
        End If
    End Sub

    Private Sub cmdclear_Click(sender As Object, e As EventArgs) Handles cmdclear.Click
        Clear(Me)
    End Sub

    Private Sub txtamount_TextChanged(sender As Object, e As EventArgs) Handles txtamount.TextChanged
        If Not IsNumeric(txtamount.Text) Then
            ErrorProvider1.SetError(txtamount, "Please enter only number!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub addincome_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label19.Text = AppName
        If txtinid.Text = "" Then
            Try
                txtstname.DataSource = New BindingSource(ShowData("select * from student where status='Active' and sid='" & sid & "'"), Nothing)
                txtstname.DisplayMember = "fullname"
                txtstname.Items.Add("None")

                txttype.DataSource = New BindingSource(ShowData("select * from charges group by name and sid = '" & sid & "'"), Nothing)
                txttype.DisplayMember = "name"
                txttype.Items.Add("Fees")
                debt.Visible = False
                txtstname.Items.Add("")
                debt.Text = ""
            Catch ex As Exception
                showerror(ex.Message)
            End Try
        Else
            Try
                cmdadd.Text = "Print"
                Dim c As Integer = record_count("select class from student where fullname ='" + txtstname.Text + "' and sid = '" & sid & "'")
                If c > 0 Then
                    debt.Visible = True
                    Me.Cursor = Cursors.WaitCursor
                    con = New MySqlConnection(cs)
                    cmd2 = New MySqlCommand("select * from student where fullname ='" + txtstname.Text + "' and sid ='" & sid & "'", con)
                    adp2 = New MySqlDataAdapter(cmd2)
                    tb3 = New DataTable
                    adp2.Fill(tb3)
                    Dim clas As Char = tb3.Rows(0)(9).ToString
                    Dim fee As Double = getnumber("select fees from class where class_no = '" & clas & "' and sid ='" & sid & "'")
                    cmd = New MySqlCommand("select * from charges where Date(date) BETWEEN (select Date(date) from charges where year ='" + tb3.Rows(0)(16).ToString + "' and term='" + tb3.Rows(0)(17).ToString + "'group by year) and '" + Now.Date.ToString("yyyy-MM-dd") + "' and sid = '" & sid & "'", con)
                    adp = New MySqlDataAdapter(cmd)
                    tb2 = New DataTable
                    adp.Fill(tb2)
                    Dim classes As String
                    For i As Integer = 0 To tb2.Rows.Count - 1
                        classes = tb2.Rows(i)(5).ToString.Trim
                        If classes.Contains(",") Then
                            Dim parts As String() = classes.Split(",")
                            If parts.Contains(clas) Then
                                fee = fee + Val(tb2.Rows(i)(2).ToString)
                            End If
                        ElseIf classes.Contains("All") Then
                            fee = fee + Val(tb2.Rows(i)(2).ToString)
                        End If
                    Next
                    Dim paid = getnumber("select sum(Amount) from income where Name = '" + txtstname.Text + "' and sid = '" & sid & "'")
                    debt.Text = "Total debt  ¢ " & (Val(fee) - Val(paid))

                    Me.Cursor = Cursors.Default
                Else
                    debt.Visible = False
                End If
            Catch ex As Exception
                showerror(ex.Message)
            End Try
            txtinid.Text = "DES-" & academic_year & "-" & Now.Date.Month & "-" & term & "-" & DateTime.Now.Second
        End If
    End Sub

    Private Sub txtstname_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles txtstname.SelectedIndexChanged
        Try
            Dim c As Integer = record_count("select class from student where fullname ='" + txtstname.Text + "' and sid = '" & sid & "'")
            If c > 0 Then
                debt.Visible = True
                Me.Cursor = Cursors.WaitCursor
                con = New MySqlConnection(cs)
                cmd2 = New MySqlCommand("select * from student where fullname ='" + txtstname.Text + "' and sid = '" & sid & "'", con)
                adp2 = New MySqlDataAdapter(cmd2)
                tb3 = New DataTable
                adp2.Fill(tb3)
                txtstudent_id.Text = tb3.Rows(0)(0).ToString
                lblstid.Text = tb3.Rows(0)("student_id").ToString
                Dim clas As Char = tb3.Rows(0)(9).ToString
                Dim fee As Double = getnumber("select fees from class where class_no = '" & clas & "'")
                cmd = New MySqlCommand("select * from charges where Date(date) BETWEEN (select Date(date) from charges where year ='" + tb3.Rows(0)(16).ToString + "' and term='" + tb3.Rows(0)(17).ToString + "'group by year) and '" + Now.Date.ToString("yyyy-MM-dd") + "'", con)
                adp = New MySqlDataAdapter(cmd)
                tb2 = New DataTable
                adp.Fill(tb2)
                Dim classes As String
                For i As Integer = 0 To tb2.Rows.Count - 1
                    classes = tb2.Rows(i)(5).ToString.Trim
                    If classes.Contains(",") Then
                        Dim parts As String() = classes.Split(",")
                        If parts.Contains(clas) Then
                            fee = fee + Val(tb2.Rows(i)(2).ToString)
                        End If
                    ElseIf classes.Contains("All") Then
                        fee = fee + Val(tb2.Rows(i)(2).ToString)
                    End If
                Next
                Dim paid = getnumber("select Total_Debt from student_Debt where Student_ID = '" + txtstudent_id.Text + "' and Academic='" & academic_year & "' and Term='" & term & "' and sid='" & sid & "'")
                debt.Text = "Total debt  ¢ " & Val(paid)
                Me.Cursor = Cursors.Default
            Else
                debt.Visible = False
            End If
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub


End Class