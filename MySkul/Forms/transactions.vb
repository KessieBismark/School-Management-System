Imports MySql.Data.MySqlClient
Public Class transactions
    Dim income_search As String = "select  `Income_ID`, `Name`, `Type`, `Amount`, `Academic`, `Term`, `Description`, `Paid_by`, `Date` from income where sid = '" & sid & "' and  CONCAT(Income_ID,Name,Type,Academic,Term,Paid_by,Date)"
    Dim expenses_search As String = "select  * from expenses where sid = '" & sid & "' and CONCAT(Expenses_ID,Record,Academic,Term,Date)"
    Dim cheque_search As String = "select  * from cheques where sid = '" & sid & "' and  CONCAT(Cheque_ID,Name,Account_No,Type,Amount,Cheque_Date)"
    Dim salary_search As String = "Select staff_id as Staff_ID,salary as Salary,hours as Working_Hours,onleave as On_Leave,leave_type as Leave_Type,Start_Date as Start_Date,End_Date as End_Date,date as Date FROM `salary` where sid ='" & sid & "' and CONCAT(staff_id,salary)"
    Dim charge_search As String = "select charge_id as Charge_ID,name as Charge_Name, amount as Amount, term as Term,year as Year,class as Classes,date as Date from charges where sid = '" & sid & "' and CONCAT(charge_id,name,term,year,date)"
    Sub charge_bindgrid()
        querryString = "select charge_id as Charge_ID,name as Charge_Name, amount as Amount, term as Term,year as Year,class as Classes,date as Date from charges where sid = '" & sid & "' order by date DESC"
        chargegrid.DataSource = ShowData(querryString)
        Try
            Me.chargegrid.BestFitColumns()
            Me.chargegrid.Columns("Charge_ID").Width = 200
            Me.chargegrid.Columns("Charge_Name").Width = 250
            Me.chargegrid.Columns("Amount").Width = 100
            Me.chargegrid.Columns("Term").Width = 50
            Me.chargegrid.Columns("Year").Width = 100
            Me.chargegrid.Columns("Classes").Width = 100
            Me.chargegrid.Columns("Date").Width = 200
            For i As Integer = 0 To Me.chargegrid.ColumnCount - 1
                Me.chargegrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
    Sub expenses_bindgrid()
        querryString = "SELECT `Expenses_ID` as Expenses_ID, `Date` as Date, `Record` as Record, `Academic` as Academic, `Term` as Term, `Total` as Total  FROM `expenses` where sid = '" & sid & "' order by Date DESC"
        expensgrid.DataSource = ShowData(querryString)
        Try
            Me.expensgrid.AutoSize = False
            Me.expensgrid.BestFitColumns()
            Me.expensgrid.Columns("Expenses_ID").Width = 200
            Me.expensgrid.Columns("Date").Width = 250
            Me.expensgrid.Columns("Record").Width = 800
            Me.expensgrid.Columns("Academic").Width = 150
            Me.expensgrid.Columns("Term").Width = 100
            Me.expensgrid.Columns("Total").Width = 100
            For i As Integer = 0 To Me.expensgrid.ColumnCount - 1
                Me.expensgrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
    Sub cheque_bindgrid()
        querryString = "SELECT `Cheque_ID` as Cheque_ID, `Name` as Name, `Account_No` as Account_No, `Amount` as Amount, `Type` as Type, `Cheque_Date` as Cheque_Date, `Date` as Date FROM `cheques` where sid = '" & sid & "' order by Date DESC"
        chequegrid.DataSource = ShowData(querryString)
        Try
            Me.chequegrid.AutoSize = False
            Me.chequegrid.BestFitColumns()
            Me.chequegrid.Columns("Cheque_ID").Width = 200
            Me.chequegrid.Columns("Date").Width = 150
            Me.chequegrid.Columns("Name").Width = 250
            Me.chequegrid.Columns("Account_No").Width = 200
            Me.chequegrid.Columns("Amount").Width = 150
            Me.chequegrid.Columns("Type").Width = 100
            Me.chequegrid.Columns("Cheque_Date").Width = 150
            For i As Integer = 0 To Me.chequegrid.ColumnCount - 1
                Me.chequegrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
    Sub profit_bindgrid()

        querryString = "SELECT Profit_ID as Profit_ID,Academic as Academic,Term as Term,Income as Income,Expenses as Expenses,Profit as Profit,Date as Date FROM `profit` where sid = '" & sid & "' order by Date DESC"
        profitgrid.DataSource = ShowData(querryString)
        Try
            Me.profitgrid.AutoSize = False
            Me.profitgrid.BestFitColumns()
            Me.profitgrid.Columns("Profit_ID").Width = 200
            Me.profitgrid.Columns("Academic").Width = 150
            Me.profitgrid.Columns("Term").Width = 100
            Me.profitgrid.Columns("Income").Width = 150
            Me.profitgrid.Columns("Expenses").Width = 150
            Me.profitgrid.Columns("Profit").Width = 150
            Me.profitgrid.Columns("Date").Width = 230
            For i As Integer = 0 To Me.profitgrid.ColumnCount - 1
                Me.profitgrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
    Sub income_bindgrid()
        querryString = "SELECT `Income_ID`, `Name`, `Type`, `Amount`, `Academic`, `Term`, `Description`, `Paid_by`, `Date` FROM `income` where sid = '" & sid & "' order by Date DESC"
        incomegrid.DataSource = ShowData(querryString)
        Try
            Me.incomegrid.BestFitColumns()
            Me.incomegrid.Columns("Income_ID").Width = 200
            Me.incomegrid.Columns("Name").Width = 350
            Me.incomegrid.Columns("Type").Width = 200
            Me.incomegrid.Columns("Amount").Width = 100
            Me.incomegrid.Columns("Academic").Width = 150
            Me.incomegrid.Columns("Term").Width = 80
            Me.incomegrid.Columns("Description").Width = 300
            Me.incomegrid.Columns("Paid_by").Width = 200
            Me.incomegrid.Columns("Date").Width = 200
            For i As Integer = 0 To Me.incomegrid.ColumnCount - 1
                Me.incomegrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
    Sub salary_bindgrid()
        querryString = "SELECT staff_id as Staff_ID,salary as Salary,hours as Working_Hours,onleave as On_Leave,leave_type as Leave_Type,Start_Date,End_Date,date as Date FROM `salary` where sid = '" & sid & "' order by date DESC"
        salarygrid.DataSource = ShowData(querryString)
        Try
            Me.salarygrid.AutoSize = False
            Me.salarygrid.BestFitColumns()
            Me.salarygrid.Columns("Staff_ID").Width = 100
            Me.salarygrid.Columns("Salary").Width = 100
            Me.salarygrid.Columns("On_Leave").Width = 80
            Me.salarygrid.Columns("Leave_Type").Width = 200
            Me.salarygrid.Columns("Working_Hours").Width = 150
            Me.salarygrid.Columns("Start_Date").Width = 150
            Me.salarygrid.Columns("End_Date").Width = 150
            Me.salarygrid.Columns("Date").Width = 200
            For i As Integer = 0 To Me.salarygrid.ColumnCount - 1
                Me.salarygrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
    Private Sub transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cfrom.Value = Now.Date
            cto.Value = Now.Date
            vfrom.Value = Now.Date
            vto.Value = Now.Date
            txtdstudent.DataSource = New BindingSource(ShowData("select * from student where sid = '" & sid & "' order by class ASC"), Nothing)
            txtdstudent.DisplayMember = "fullname"
            txtdstudent.Items.Add("")

            'charges-------------
            charge_bindgrid()
            '-------------------

            'income ------------
            income_bindgrid()
            calculate_income()
            '-------------------------

            'expenses-----------------

            expenses_bindgrid()
            calculate_expenses()
            ' ------------------------ 

            'profit------------------
            profit_bindgrid()
            '------------------------
            'cheques------------------
            cheque_bindgrid()
            '-------------------------
            'salary------------------

            salary_bindgrid()
            '------------------------

            'debt--------------------
            insert_debt()
            update_debt()
            '------------------------
            cmddelete.Visible = False
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            showerror(ex.Message)
        End Try
    End Sub
    Private Sub cclear_Click(sender As Object, e As EventArgs)
        Clear(Me)
    End Sub
    Private Sub chargegrid_Click(sender As Object, e As EventArgs) Handles chargegrid.Click
        Try
            txtcid.Text = chargegrid.CurrentRow.Cells(0).Value.ToString
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        Dim ac As Integer = record_count("select * from academic_year where status= '1' and sid = '" & sid & "'")
        If ac < 1 Then
            showerror("Please go to academic year and register before you can make input here")
            Home.Button3.PerformClick()
        Else
            Me.Cursor = Cursors.WaitCursor
            Dim income As New addincome
            income.ShowDialog()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub incomegrid_DoubleClick(sender As Object, e As EventArgs) Handles incomegrid.DoubleClick
        Try
            addincome.txtinid.Text = incomegrid.CurrentRow.Cells(0).Value.ToString
            addincome.txtstname.Text = incomegrid.CurrentRow.Cells(1).Value.ToString
            addincome.txttype.Text = incomegrid.CurrentRow.Cells(2).Value.ToString
            addincome.txtamount.Text = incomegrid.CurrentRow.Cells(3).Value.ToString
            addincome.txtpaid.Text = incomegrid.CurrentRow.Cells(7).Value.ToString
            addincome.txtdes.Text = incomegrid.CurrentRow.Cells(6).Value.ToString
            addincome.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub incomegrid_Click(sender As Object, e As EventArgs) Handles incomegrid.Click
        Try
            incomeid.Text = incomegrid.CurrentRow.Cells(0).Value.ToString
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmddelete_Click(sender As Object, e As EventArgs) Handles cmddelete.Click
        If incomeid.Text = "" Then
            showerror("Please select the row or record to delete!")
            Exit Sub
        Else
            Dialog1.Label1.Text = "Are you sure you want to delete a record of Income number: " + incomeid.Text
            Dialog1.ShowDialog()
            If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                execute("INSERT INTO `deletedincome`(`Income_ID`, `Name`, `Type`, `Amount`, `Academic`, `Term`, `Description`, `Paid_by`,`Deleted_by`,sid) VALUES ('" + incomegrid.CurrentRow.Cells(0).Value.ToString + "','" + incomegrid.CurrentRow.Cells(1).Value.ToString + "','" + incomegrid.CurrentRow.Cells(2).Value.ToString + "','" + incomegrid.CurrentRow.Cells(3).Value.ToString + "','" + incomegrid.CurrentRow.Cells(4).Value.ToString + "','" + incomegrid.CurrentRow.Cells(5).Value.ToString + "','" + incomegrid.CurrentRow.Cells(6).Value.ToString + "','" + incomegrid.CurrentRow.Cells(7).Value.ToString + "','" + Home.user.Text + "','" & sid & "')", 0)
                execute("delete from income where Income_ID = '" + incomeid.Text + "' and sid = '" & sid & "'", 2)
                Clear(Me)
                income_bindgrid()
                ErrorProvider1.Clear()
            End If
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        income_bindgrid()
    End Sub
    Private Sub RadButton9_Click(sender As Object, e As EventArgs) Handles others.Click
        Try
            Dim cc As Integer = record_count("select * from cheques where Date between '" & frmdate() & "' and ' " & todate() & "' and sid = '" & sid & "'")
            If cc > 0 Then
                Dim id As String = "CHQ" & Now.Date.Year & Now.Date.Month
                Dim row As Integer = record_count("select * from income where Income_ID = '" & id & "' and sid = '" & sid & "'")
                Dim csum As Double = getnumber("select sum(Amount) from cheques where Type = 'Credit' and Cheque_Date between '" & frmdate() & "' and ' " & todate() & "' and sid = '" & sid & "'")
                con = New MySqlConnection(cs)
                con.Open()
                If row < 1 Then
                    cmd = New MySqlCommand("insert into income(`Income_ID`, `Name`, `Type`, `Amount`, `Academic`, `Term`, `Description`, `Paid_by`,sid) values ('" & id & "','Cheques','Credited','" & csum & "','" & academic_year & "','" & term & "','Cheques receieved by the school','Unknown','" & sid & "')", con)
                    cmd.ExecuteNonQuery()
                    showinfo("This month credited cheques have been calculated And saved!")
                Else
                    cmd = New MySqlCommand("Update `income` Set `Name`='Cheques',`Type`='Credited',`Amount`='" & csum & "',`Academic`='" & academic_year & "',`Term`='" & term & "',`Description`='Cheques receieved by the school',`Paid_by`='Unknown' WHERE `Income_ID`='" & id & "' and sid = '" & sid & "'", con)
                    cmd.ExecuteNonQuery()
                    showinfo("This month's credited cheques have been calculated and updated!")
                End If
                con.Close()
            End If
        Catch ex As Exception
            con.Close()
            showerror(ex.Message)
        End Try
    End Sub
    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try
            incomegrid.DataSource = filterdata(txtsearch.Text, income_search)
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub RadButton10_Click(sender As Object, e As EventArgs) Handles RadButton10.Click
        If txtcid.Text = "" Then
            showerror("Please select a record to delete")
            Exit Sub
        Else
            Dialog1.Label1.Text = "Are you sure you want to delete a record with Charges ID: " + txtcid.Text
            Dialog1.ShowDialog()
            If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                querryString = "delete from charges where charge_id = '" + txtcid.Text + "' and sid = '" & sid & "'"
                execute(querryString, 2)
                Clear(Me)
                ErrorProvider1.Clear()
                charge_bindgrid()
            End If
        End If
    End Sub
    Private Sub RadTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RadTextBox1.TextChanged
        Try
            chargegrid.DataSource = filterdata(RadTextBox1.Text, charge_search)
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
    Private Sub chargegrid_DoubleClick(sender As Object, e As EventArgs) Handles chargegrid.DoubleClick
        Try
            addcharges.txtcid.Text = chargegrid.CurrentRow.Cells(0).Value.ToString
            addcharges.txtcname.Text = chargegrid.CurrentRow.Cells(1).Value.ToString
            addcharges.txtcamount.Text = chargegrid.CurrentRow.Cells(2).Value.ToString
            addcharges.txtcclist.Text = chargegrid.CurrentRow.Cells(5).Value.ToString
            addcharges.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        charge_bindgrid()
    End Sub
    Private Sub RadButton11_Click(sender As Object, e As EventArgs) Handles RadButton11.Click
        Dim charges As New addcharges
        charges.ShowDialog()
    End Sub
    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        Dim ac As Integer = record_count("select * from academic_year where status= '1' and sid = '" & sid & "'")
        If ac < 1 Then
            showerror("Please go to academic year and register before you can make input here")
            Home.Button3.PerformClick()
        Else
            Dim expenses As New addexpenses
            expenses.ShowDialog()
        End If
    End Sub
    Private Sub expensgrid_Click(sender As Object, e As EventArgs) Handles expensgrid.Click
        Try
            updateexpenses.txteid.Text = expensgrid.CurrentRow.Cells(0).Value.ToString
        Catch ex As Exception
        End Try
    End Sub
    Private Sub expensgrid_DoubleClick(sender As Object, e As EventArgs) Handles expensgrid.DoubleClick
        Try
            Dim upda As New updateexpenses
            upda.txteid.Text = expensgrid.CurrentRow.Cells(0).Value.ToString
            upda.txterecord.Text = expensgrid.CurrentRow.Cells(2).Value.ToString
            upda.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub RadTextBox2_TextChanged(sender As Object, e As EventArgs) Handles RadTextBox2.TextChanged
        Try
            expensgrid.DataSource = filterdata(RadTextBox2.Text, expenses_search)
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        calculate_expenses()
        expenses_bindgrid()
    End Sub
    Sub calculate_expenses()
        Try
            Dim r As Integer = record_count("select * from expenses where Date(Date) between '" & LastMontFrmDate() & "' and '" & LastMonthEndDate() & "' and sid = '" & sid & "'")
            If r > 0 Then
                con = New MySqlConnection(cs)
                cmd = New MySqlCommand("select * from expenses where Date(Date) between '" & LastMontFrmDate() & "' and '" & LastMonthEndDate() & "' and sid = '" & sid & "'", con)
                adp = New MySqlDataAdapter(cmd)
                tb = New DataTable
                adp.Fill(tb)
                For j As Integer = 0 To tb.Rows.Count - 1
                    Dim record As String = tb.Rows(j)(2).ToString.Trim
                    Dim id As String = tb.Rows(j)(0).ToString.Trim
                    Dim expense As String() = record.Split(",")
                    Dim amt As Double = 0
                    For i As Integer = 0 To expense.Count - 1
                        Dim v As String() = expense(i).Split("-")
                        If expense(i) = "" Then
                        Else
                            If IsNumeric(Val(v(1))) Then
                                amt = amt + Val(v(1))
                            End If
                        End If
                    Next
                    con.Open()
                    cmd2 = New MySqlCommand("UPDATE `expenses` SET `Total`='" & amt & "' WHERE Expenses_ID = '" & id & "' and sid = '" & sid & "'", con)
                    cmd2.ExecuteNonQuery()
                    con.Close()
                Next
            End If
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles cmdcalculate.Click
        Dim ac As Integer = record_count("select * from academic_year where status= '1' and sid = '" & sid & "'")
        If ac < 1 Then
            showerror("Please go to academic year and register before you can make input here")
            Home.Button3.PerformClick()
        Else
            Try
                calculate_expenses()
                Dim income_total As Double = getnumber("select sum(Amount) from income where Date(Date) between '" & cfrom.Value.ToString("yyyy-MM-dd") & "' and '" & cto.Value.ToString("yyyy-MM-dd") & "' and sid = '" & sid & "'")
                Dim expenses_total As Double = getnumber("select sum(Total) from expenses where Date(Date) between '" & cfrom.Value.ToString("yyyy-MM-dd") & "' and '" & cto.Value.ToString("yyyy-MM-dd") & "' and sid = '" & sid & "'")
                Dim nid As String = "NP" & academic_year & "-" & term
                Dim np As Double
                np = income_total - expenses_total
                Dim c As Integer = record_count("SELECT * FROM `profit` WHERE Profit_ID='" & nid & "' and sid = '" & sid & "'")
                If c < 1 Then
                    execute("INSERT INTO `profit`(`Profit_ID`, `Academic`, `Term`, `Income`, `Expenses`, `Profit`,sid) VALUES ('" & nid & "','" & academic_year & "','" & term & "','" & income_total & "','" & expenses_total & "','" & np & "','" & sid & "')", 0)
                Else
                    execute("UPDATE `profit` SET `Income`='" & income_total & "',`Expenses`='" & expenses_total & "',`Profit`='" & np & "' WHERE  Profit_ID='" & nid & "' and sid = '" & sid & "'", 1)
                End If
                profit_bindgrid()
            Catch ex As Exception
                showerror(ex.Message)
            End Try
        End If
    End Sub
    Private Sub RadButton6_Click(sender As Object, e As EventArgs) Handles RadButton6.Click
        Dim ac As Integer = record_count("select * from academic_year where status= '1' and sid = '" & sid & "'")
        If ac < 1 Then
            showerror("Please go to academic year and register before you can make input here")
            Home.Button3.PerformClick()
        Else
            Dim ch As New addcheque
            ch.ShowDialog()
        End If
    End Sub
    Private Sub chequegrid_DoubleClick(sender As Object, e As EventArgs)
        Try
            addcheque.txtcid.Text = chequegrid.CurrentRow.Cells(0).Value.ToString
            addcheque.txtcname.Text = chequegrid.CurrentRow.Cells(1).Value.ToString
            addcheque.txtcamount.Text = chequegrid.CurrentRow.Cells(3).Value.ToString
            addcheque.txtaccount.Text = chequegrid.CurrentRow.Cells(2).Value.ToString
            addcheque.txtctype.Text = chequegrid.CurrentRow.Cells(4).Value.ToString
            addcheque.RadDateTimePicker1.Text = chequegrid.CurrentRow.Cells(5).Value.ToString
            addcheque.cmdadd.Enabled = False
            addcheque.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub RadTextBox4_TextChanged(sender As Object, e As EventArgs) Handles RadTextBox4.TextChanged
        chequegrid.DataSource = filterdata(RadTextBox4.Text, cheque_search)
    End Sub
    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        cheque_bindgrid()
    End Sub
    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        dcheques.ShowDialog()
    End Sub
    Private Sub RadButton4_Click_1(sender As Object, e As EventArgs) Handles RadButton4.Click
        dincome.ShowDialog()
    End Sub
    Private Sub RadButton9_Click_1(sender As Object, e As EventArgs) Handles RadButton9.Click
        Try
            Dim cc As Integer = record_count("select * from cheques where Date between '" & frmdate() & "' and ' " & todate() & "' and sid = '" & sid & "'")
            If cc > 0 Then
                Dim id As String = "CHQ" & Now.Date.Year & Now.Date.Month
                Dim id2 As String = "SLR" & Now.Date.Year & Now.Date.Month
                Dim row As Integer = record_count("select * from expenses where Expenses_ID = '" & id & "' and sid = '" & sid & "'")
                Dim row2 As Integer = record_count("select * from expenses where Expenses_ID = '" & id2 & "' and sid = '" & sid & "'")
                Dim csum As Double = getnumber("select sum(Amount) from cheques where Type = 'Debit' and Cheque_Date between '" & frmdate() & "' and ' " & todate() & "' and sid = '" & sid & "'")
                Dim salary As Double = getnumber("select sum(salary) from salary")
                Dim total As String = "Debit Cheques"
                If row < 1 Then
                    execute("INSERT INTO `expenses`(`Expenses_ID`,`Record`, `Academic`, `Term`,Total,sid) VALUES ('" + id + "','" & total & "','" + academic_year + "','" + term + "','" & csum & "','" & sid & "') ", 3)
                    showinfo("This month's debit cheques have been calculated And saved!")
                Else
                    execute("UPDATE `expenses` SET Total='" & csum & "' WHERE Expenses_ID='" & id & "' and sid = '" & sid & "'", 3)
                    showinfo("This month's debit cheques have been calculated and updated!")
                End If
                If row2 < 1 Then
                    execute("INSERT INTO `expenses`(`Expenses_ID`,`Record`, `Academic`, `Term`,Total,sid) VALUES ('" + id2 + "','Salary Total','" + academic_year + "','" + term + "','" & salary & "','" & sid & "')", 3)
                Else
                    execute("UPDATE `expenses` SET Total='" & salary & "' WHERE Expenses_ID='" & id & "' and sid = '" & sid & "'", 3)
                End If
                expenses_bindgrid()
            End If
        Catch ex As Exception
            con.Close()
            showerror(ex.Message)
        End Try
    End Sub
    Private Sub RadButton7_Click(sender As Object, e As EventArgs) Handles RadButton7.Click
        Dim leave As New addleave
        leave.ShowDialog()
    End Sub
    Private Sub addsalary_Click(sender As Object, e As EventArgs) Handles addsalary.Click
        Dim salary As New addsalaries
        salary.ShowDialog()
    End Sub
    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        salary_bindgrid()
    End Sub
    Private Sub salarysearch_TextChanged(sender As Object, e As EventArgs) Handles salarysearch.TextChanged
        salarygrid.DataSource = filterdata(salarysearch.Text, salary_search)
    End Sub


    Private Sub LinkLabel6_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        insert_debt()
        update_debt()
    End Sub

    Private Sub update_debt()
        Try
            Me.Cursor = Cursors.WaitCursor
            'calaculate debt of new entry 
            Dim sc As String
            Dim sp As String()
            Dim clas As String
            tb2 = New DataTable
            tb4 = New DataTable
            tb2 = ShowData("Select * from charges where year ='" & academic_year & "' and term='" & term & "' and calculated='0' and sid ='" & sid & "'")
            tb4 = ShowData("select * from student where status = 'Active' and sid = '" & sid & "' and student_id not in (select Student_ID from student_debt where new = '1' and sid = '" & sid & "')")
            If tb2.Rows.Count > 0 Then
                tb3 = New DataTable
                For i As Integer = 0 To tb4.Rows.Count - 1
                    sc = tb4.Rows(i)(9).ToString
                    sp = sc.Split(" ")
                    clas = sp(0)
                    Dim fee As Double = 0
                    Dim classes As String
                    For j As Integer = 0 To tb2.Rows.Count - 1
                        classes = tb2.Rows(j)(5).ToString.TrimEnd(",")
                        If classes.Contains(",") Then
                            Dim parts As String() = classes.Split(",")
                            If parts.Contains(clas) Then
                                fee = fee + Val(tb2.Rows(j)(2).ToString)
                            End If
                        ElseIf classes.Contains("All") Then
                            fee = fee + Val(tb2.Rows(j)(2).ToString)
                        End If
                    Next
                    'calculate amount paid by student
                    Dim tdebt = getnumber("select Total_Debt from student_debt where Student_ID = '" + tb4.Rows(i)(0).ToString + "' and Academic='" & academic_year & "' and Term='" & term & "' and sid = '" & sid & "'")
                    'calculate total debt of student
                    Dim debt As Double
                    debt = (Val(fee) + Val(tdebt))
                    execute("update student_debt set Total_Debt = '" & debt & "' where Student_ID= '" & tb4.Rows(i)("Student_ID").ToString & "' and Academic= '" & academic_year & "' and Term='" & term & "' and sid = '" & sid & "'", 3)
                Next
                For l As Integer = 0 To tb2.Rows.Count - 1
                    execute("update charges set calculated = '1' where charge_id = '" & tb2.Rows(l)(0).ToString & "' and calculated ='0' and sid = '" & sid & "'", 3)
                Next
                tb6 = New DataTable
                tb6 = ShowData("select * from student_debt where new='1' and Academic= '" & academic_year & "' and Term='" & term & "'and sid = '" & sid & "' ")
                For t As Integer = 0 To tb6.Rows.Count - 1
                    execute("update student_debt set new = '0' where id = '" & tb6.Rows(t)(0).ToString & "' and sid = '" & sid & "'", 3)
                Next
            End If
            debtgrid.DataSource = ShowData("select  `Student_ID`, `Fullname`, `Gender`, `Class`, `Academic`, `Term`, `Previous_Debt`, `Current_Debt`, `Total_Debt` from student_debt where Academic='" & academic_year & "' and Term='" & term & "' and sid = '" & sid & "' order by Class")
            For i As Integer = 0 To Me.debtgrid.ColumnCount - 1
                Me.debtgrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            showerror(ex.Message)
        End Try
    End Sub
    Private Sub insert_debt()
        Try
            Me.Cursor = Cursors.WaitCursor
            'calaculate debt of new entry 
            Dim sc As String
            Dim sp As String()
            Dim clas As String
            tb4 = New DataTable
            Dim cc As Integer = record_count("select * from charges where calculated = '0' and year = '" & academic_year & "' and term= '" & term & "' and sid = '" & sid & "'")
            Dim std As Integer = record_count("select * from student_debt where Academic = '" & academic_year & "' and Term= '" & term & "' and sid = '" & sid & "'")
            tb4 = ShowData("select * from student where status = 'Active' and student_id not in (select Student_ID from student_debt where Academic = '" & academic_year & "' and Term= '" & term & "' and sid = '" & sid & "' )")
            If tb4.Rows.Count > 0 Then
                tb2 = New DataTable
                tb3 = New DataTable
                Dim old_term As Integer = getnumber("select term from academic_year where  id = (select (max(id)-1) from academic_year where sid = '" & sid & "') and sid = '" & sid & "'")
                Dim old_academic As String = getValue("select academic from academic_year where  id = (select (max(id)-1) from academic_year where sid = '" & sid & "') and sid = '" & sid & "' ")
                tb2 = ShowData("Select * from charges where year ='" & academic_year & "' and term='" & term & "' and sid = '" & sid & "'")
                For i As Integer = 0 To tb4.Rows.Count - 1
                    sc = tb4.Rows(i)(9).ToString
                    sp = sc.Split(" ")
                    clas = sp(0)
                    Dim fee As Double = getnumber("select fees from class where class_no = '" & clas & "' and sid ='" & sid & "'")
                    Dim classes As String
                    If tb2.Rows.Count > 0 Then
                        For j As Integer = 0 To tb2.Rows.Count - 1
                            classes = tb2.Rows(j)(5).ToString.TrimEnd(",")
                            If classes.Contains(",") Then
                                Dim parts As String() = classes.Split(",")
                                If parts.Contains(clas) Then
                                    fee = fee + Val(tb2.Rows(j)(2).ToString)
                                End If
                            ElseIf classes.Contains("All") Then
                                fee = fee + Val(tb2.Rows(j)(2).ToString)
                            End If
                        Next
                    End If
                    'calculate amount paid by student
                    Dim paid = getnumber("select sum(Amount) from income where Name = '" + tb4.Rows(i)(1).ToString + "' and Academic='" & academic_year & "' and Term='" & term & "' and recorded = '0' and sid = '" & sid & "'")
                    tb3.Clear()
                    tb3 = ShowData("select * from income where Name = '" + tb4.Rows(i)(1).ToString + "' and sid = '" & sid & "'")
                    If tb3.Rows.Count > 0 Then
                        For k As Integer = 0 To tb3.Rows.Count - 1
                            execute("update income set recorded = '1' where Income_ID ='" & tb3.Rows(k)(0).ToString & "'and Academic='" & academic_year & "' and Term='" & term & "' and sid = '" & sid & "'", 3)
                        Next
                    End If

                    'calculate total debt of student
                    Dim debt As Double
                    debt = (Val(fee) - Val(paid))

                    Dim new_debt = getnumber("select Current_Debt from student_debt where Student_ID= '" & tb4.Rows(i)(0).ToString & "' and Academic= '" & old_academic & "' and Term='" & old_term & "' and sid = '" & sid & "'")
                    Dim old_debt = getnumber("select Previous_Debt from student_debt where Student_ID= '" & tb4.Rows(i)(0).ToString & "' and Academic= '" & old_academic & "' and Term='" & old_term & "' and sid = '" & sid & "'")
                    Dim arrears = Val(old_debt) + Val(new_debt)
                    Dim total = arrears + debt
                    execute("insert into student_debt(Student_ID,Fullname,Gender,Class,Academic,Term,Current_Debt,Total_Debt,sid) values ('" & tb4.Rows(i)(0).ToString & "','" & tb4.Rows(i)(1).ToString & "','" & tb4.Rows(i)(2).ToString & "','" & tb4.Rows(i)(9).ToString & "','" & academic_year & "','" & Val(term) & "','" & Val(debt) & "','" & Val(total) & "','" & sid & "')", 3)
                    execute("update student_debt set Previous_Debt = '" & arrears & "' where Student_ID= '" & tb4.Rows(i)(0).ToString & "' and Academic= '" & academic_year & "' and Term='" & term & "' and sid = '" & sid & "'", 3)
                    If std > 0 And cc > 0 Then
                        execute("update student_debt set new = '1' where Student_ID= '" & tb4.Rows(i)(0).ToString & "' and Academic= '" & academic_year & "' and Term='" & term & "' and sid = '" & sid & "'", 3)
                    End If
                Next
                If std < 1 Then
                    For l As Integer = 0 To tb2.Rows.Count - 1
                        execute("update charges set calculated = '1' where charge_id = '" & tb2.Rows(l)(0).ToString & "' and calculated ='0' and sid = '" & sid & "'", 3)
                    Next
                End If
                execute("delete from student_Debt where Academic= '" & old_academic & "' and Term='" & old_term & "' and sid = '" & sid & "'", 3)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub salarygrid_Click(sender As Object, e As EventArgs) Handles salarygrid.Click
        Try
            addleave.txtcid.Text = salarygrid.CurrentRow.Cells(0).Value.ToString
            addleave.txtleave.Text = salarygrid.CurrentRow.Cells(4).Value.ToString
            addleave.leavestart.Text = salarygrid.CurrentRow.Cells(6).Value.ToString
            addleave.leaveend.Text = salarygrid.CurrentRow.Cells(7).Value.ToString
            addleave.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub salarygrid_DoubleClick(sender As Object, e As EventArgs) Handles salarygrid.DoubleClick
        Try
            addsalaries.Txtid.Text = salarygrid.CurrentRow.Cells(0).Value.ToString
            addsalaries.txtamount.Text = salarygrid.CurrentRow.Cells(1).Value.ToString
            addsalaries.txthours.Text = salarygrid.CurrentRow.Cells(2).Value.ToString
            addsalaries.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub gsave_Click(sender As Object, e As EventArgs) Handles gsave.Click
        If txtdstudent.Text = "" Then
            showerror("Please select a student!")
            Exit Sub
        Else
            debtgrid.DataSource = ShowData("SELECT  `Student_ID`, `Fullname`, `Gender`, `Class`, `Academic`, `Term`, `Previous_Debt`, `Current_Debt`, `Total_Debt` FROM `student_debt` WHERE sid='" & sid & "' and Fullname = '" & txtdstudent.Text & "'")
        End If
    End Sub
End Class