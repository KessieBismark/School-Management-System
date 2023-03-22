Imports MySql.Data.MySqlClient
Public Class staff
    Dim search As String = "select staff_id as Staff_ID, fullname as Fullname,gender as Gender,phone as Phone,dob as Date_Of_Birth,nextkin as Next_Of_Kin,kinphone as Kin_Phone,email as Email,hired_date as Hired_Date,qualification as Qualification,classes as Class,accountname as Account_name,accountno as Account_No,branch as Branch,employment_type as Staff_Status,address as Address from staff where sid = '" & sid & "' and CONCAT(staff_id,fullname,gender,phone,classes,accountname,employment_type,nextkin,qualification,address)"
    Private Sub cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        Dim adds As New addstaff
        adds.ShowDialog()
    End Sub
    Private Sub ntgrid_Click(sender As Object, e As EventArgs) Handles ntgrid.Click
        Try
            txtntid.Text = ntgrid.CurrentRow.Cells(0).Value.ToString
            txttid.Text = ""
        Catch ex As Exception
        End Try
    End Sub
    Sub t_bindgrid()
        querryString = "select staff_id as Staff_ID, fullname as Fullname,gender as Gender,phone as Phone,dob as Date_Of_Birth,nextkin as Next_Of_Kin,kinphone as Kin_Phone,email as Email,hired_date as Hired_Date,qualification as Qualification,classes as Class,accountname as Account_name,accountno as Account_No,branch as Branch,employment_type as Staff_Status,address as Address from staff where employment_type = 'Teaching Staff' and sid = '" & sid & "'"
        tgrid.DataSource = ShowData(querryString)
        Try
            Me.tgrid.Columns("Staff_ID").Width = 80
            Me.tgrid.Columns("Fullname").Width = 300
            Me.tgrid.Columns("Gender").Width = 100
            Me.tgrid.Columns("Phone").Width = 100
            Me.tgrid.Columns("Date_Of_Birth").Width = 150
            Me.tgrid.Columns("Next_Of_Kin").Width = 300
            Me.tgrid.Columns("Kin_Phone").Width = 100
            Me.tgrid.Columns("Email").Width = 100
            Me.tgrid.Columns("Hired_Date").Width = 100
            Me.tgrid.Columns("Qualification").Width = 100
            Me.tgrid.Columns("Class").Width = 80
            Me.tgrid.Columns("Account_name").Width = 100
            Me.tgrid.Columns("Account_No").Width = 100
            Me.tgrid.Columns("Branch").Width = 100
            Me.tgrid.Columns("Staff_Status").Width = 150
            Me.tgrid.Columns("Address").Width = 300

            For i As Integer = 0 To Me.tgrid.ColumnCount - 1
                Me.tgrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
    Sub nt_bindgrid()
        querryString = "select staff_id as Staff_ID, fullname as Fullname,gender as Gender,phone as Phone,dob as Date_Of_Birth,nextkin as Next_Of_Kin,kinphone as Kin_Phone,email as Email,hired_date as Hired_Date,qualification as Qualification,classes as Class,accountname as Account_name,accountno as Account_No,branch as Branch,employment_type as Staff_Status,address as Address from staff where employment_type = 'Non Teaching Staff' and sid = '" & sid & "'"
        ntgrid.DataSource = ShowData(querryString)
        Try
            Me.ntgrid.Columns("Staff_ID").Width = 80
            Me.ntgrid.Columns("Fullname").Width = 300
            Me.ntgrid.Columns("Gender").Width = 100
            Me.ntgrid.Columns("Phone").Width = 100
            Me.ntgrid.Columns("Date_Of_Birth").Width = 100
            Me.ntgrid.Columns("Next_Of_Kin").Width = 300
            Me.ntgrid.Columns("Kin_Phone").Width = 100
            Me.ntgrid.Columns("Email").Width = 100
            Me.ntgrid.Columns("Hired_Date").Width = 100
            Me.ntgrid.Columns("Qualification").Width = 100
            Me.ntgrid.Columns("Class").Width = 80
            Me.ntgrid.Columns("Account_name").Width = 100
            Me.ntgrid.Columns("Account_No").Width = 100
            Me.ntgrid.Columns("Branch").Width = 100
            Me.ntgrid.Columns("Staff_Status").Width = 150
            Me.ntgrid.Columns("Address").Width = 300
            For i As Integer = 0 To Me.ntgrid.ColumnCount - 1
                Me.ntgrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
    Private Sub cmddelete_Click(sender As Object, e As EventArgs) Handles cmddelete.Click
        If txttid.Text = "" And txttid.Text = "" Then

            showerror("There was an error: Please select a record to delete")
            Exit Sub
        ElseIf Not txttid.Text = "" Then
            Dialog1.Label1.Text = "Are you sure you want to delete a record with Staff ID: " + txttid.Text
            Dialog1.ShowDialog()
            If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                querryString = "delete from staff where staff_id = '" + txttid.Text + "' and sid ='" & sid & "'"
                execute(querryString, 2)
                t_bindgrid()
            End If
        ElseIf Not txttid.Text = "" Then
            Dialog1.Label1.Text = "Are you sure you want to delete a record with Staff ID: " + txttid.Text
            Dialog1.ShowDialog()
            If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                querryString = "delete from staff where staff_id = '" + txttid.Text + "' and sid = '" & sid & "'"
                execute(querryString, 2)
                nt_bindgrid()
            End If
        End If
    End Sub
    Private Sub staff_Load(sender As Object, e As EventArgs) Handles Me.Load
        t_bindgrid()
        nt_bindgrid()
    End Sub
    Private Sub ntgrid_DoubleClick(sender As Object, e As EventArgs) Handles ntgrid.DoubleClick
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim staff As New addstaff
            Dim Fullname As String = ntgrid.CurrentRow.Cells(1).Value.ToString.Trim
            If Fullname.Contains(",") Then
                Dim parts As String() = Fullname.Split(",")
                Dim other As String
                other = parts(1)
                staff.txtln.Text = parts(0)
                If other.Contains(" ") Then
                    Dim part2 As String() = other.Split(" ")
                    If part2.Count = 2 Then
                        staff.txtfirstname.Text = part2(0)
                        staff.txtmiddle.Text = part2(1)
                    ElseIf part2.Count = 3 Then
                        staff.txtfirstname.Text = part2(0)
                        staff.txtmiddle.Text = part2(1) & " " & part2(2)
                    End If
                Else
                    staff.txtfirstname.Text = other
                End If
            End If
            staff.txtsid.Text = ntgrid.CurrentRow.Cells(0).Value.ToString
            staff.txtid.Text = ntgrid.CurrentRow.Cells(0).Value.ToString
            staff.txtgender.Text = ntgrid.CurrentRow.Cells(2).Value.ToString
            staff.dob.Text = ntgrid.CurrentRow.Cells(4).Value.ToString
            staff.dob.Value = ntgrid.CurrentRow.Cells(4).Value.ToString
            staff.txtfon.Text = ntgrid.CurrentRow.Cells(3).Value.ToString
            staff.txtnk.Text = ntgrid.CurrentRow.Cells(5).Value.ToString
            staff.txtkc.Text = ntgrid.CurrentRow.Cells(6).Value.ToString
            staff.txtemail.Text = ntgrid.CurrentRow.Cells(7).Value.ToString
            staff.txthd.Text = ntgrid.CurrentRow.Cells(8).Value.ToString
            staff.txtq.Text = ntgrid.CurrentRow.Cells(9).Value.ToString
            staff.txtclass.Text = ntgrid.CurrentRow.Cells(10).Value.ToString
            staff.txtacname.Text = ntgrid.CurrentRow.Cells(11).Value.ToString
            staff.txtaddress.Text = ntgrid.CurrentRow.Cells(15).Value.ToString
            staff.txtacno.Text = ntgrid.CurrentRow.Cells(12).Value.ToString
            staff.txtbranch.Text = ntgrid.CurrentRow.Cells(13).Value.ToString
            staff.txtss.Text = ntgrid.CurrentRow.Cells(14).Value.ToString
            up = 1
            staff.ShowDialog()
        Catch ex As Exception
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub tgrid_DoubleClick_1(sender As Object, e As EventArgs) Handles tgrid.DoubleClick
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim staff As New addstaff
            Dim Fullname As String = tgrid.CurrentRow.Cells(1).Value.ToString.Trim
            If Fullname.Contains(",") Then
                Dim parts As String() = Fullname.Split(",")
                Dim other As String
                other = parts(1)
                staff.txtln.Text = parts(0)
                If other.Contains(" ") Then
                    Dim part2 As String() = other.Split(" ")
                    If part2.Count = 2 Then
                        staff.txtfirstname.Text = part2(0)
                        staff.txtmiddle.Text = part2(1)
                    ElseIf part2.Count = 3 Then
                        staff.txtfirstname.Text = part2(0)
                        staff.txtmiddle.Text = part2(1) & " " & part2(2)
                    End If
                Else
                    staff.txtfirstname.Text = other
                End If
            End If
            staff.txtsid.Text = tgrid.CurrentRow.Cells(0).Value.ToString
            staff.txtid.Text = tgrid.CurrentRow.Cells(0).Value.ToString
            staff.txtgender.Text = tgrid.CurrentRow.Cells(2).Value.ToString
            staff.dob.Text = tgrid.CurrentRow.Cells(4).Value.ToString
            staff.dob.Value = tgrid.CurrentRow.Cells(4).Value.ToString
            staff.txtfon.Text = tgrid.CurrentRow.Cells(3).Value.ToString
            staff.txtnk.Text = tgrid.CurrentRow.Cells(5).Value.ToString
            staff.txtkc.Text = tgrid.CurrentRow.Cells(6).Value.ToString
            staff.txtemail.Text = tgrid.CurrentRow.Cells(7).Value.ToString
            staff.txthd.Text = tgrid.CurrentRow.Cells(8).Value.ToString
            staff.txtq.Text = tgrid.CurrentRow.Cells(9).Value.ToString
            staff.txtsclass.Text = tgrid.CurrentRow.Cells(10).Value.ToString
            staff.txtacname.Text = tgrid.CurrentRow.Cells(11).Value.ToString
            staff.txtaddress.Text = tgrid.CurrentRow.Cells(15).Value.ToString
            staff.txtacno.Text = tgrid.CurrentRow.Cells(12).Value.ToString
            staff.txtbranch.Text = tgrid.CurrentRow.Cells(13).Value.ToString
            staff.txtss.Text = tgrid.CurrentRow.Cells(14).Value.ToString
            up = 1
            staff.ShowDialog()
        Catch ex As Exception
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub RadTextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        tgrid.DataSource = filterdata(txtsearch.Text, search)
        ntgrid.DataSource = filterdata(txtsearch.Text, search)
        If txtsearch.Text = "" Then
            t_bindgrid()
            nt_bindgrid()
        End If
    End Sub
    Private Sub tgrid_Click_1(sender As Object, e As EventArgs) Handles tgrid.Click
        Try
            txttid.Text = tgrid.CurrentRow.Cells(0).Value.ToString
            txtntid.Text = ""
        Catch ex As Exception
        End Try
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        t_bindgrid()
        nt_bindgrid()
    End Sub
End Class