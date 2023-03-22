Imports MySql.Data.MySqlClient
Public Class dcheques
    Dim cheque_search As String = "select  * from deletedcheques where sid = '" & sid & "' and  CONCAT(Cheque_ID,Name,Account_No,Type,Amount,Cheque_Date,Deleted_by)"
    Sub cheque_bindgrid()
        querryString = "SELECT * FROM `deletedcheques` where sid='" & sid & "' order by Date DESC"
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
            Me.chequegrid.Columns("Deleted_by").Width = 150
            For i As Integer = 0 To Me.chequegrid.ColumnCount - 1
                Me.chequegrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub


    Private Sub dcheques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
        cheque_bindgrid()
    End Sub


    Private Sub RadButton6_Click_1(sender As Object, e As EventArgs) Handles RadButton6.Click
        If txtcid.Text = "" Then
            showerror("Please click on the record you want to restore before you click on restore!")
            Exit Sub
        Else
            execute("INSERT INTO `cheques`(`Cheque_ID`, `Name`, `Account_No`, `Amount`, `Type`, `Cheque_Date`,sid) VALUES ('" + txtcid.Text + "','" + chequegrid.CurrentRow.Cells(1).Value.ToString + "','" + chequegrid.CurrentRow.Cells(2).Value.ToString + "','" + chequegrid.CurrentRow.Cells(3).Value.ToString + "','" + chequegrid.CurrentRow.Cells(4).Value.ToString + "','" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "','" & sid & "')", 3)
            querryString = "delete from deletedcheques where Cheque_ID = '" + txtcid.Text + "' and sid ='" & sid & "'"
            execute(querryString, 3)
            showinfo("Record has been restored successfully")
            Clear(Me)
            cheque_bindgrid()
        End If
    End Sub

    Private Sub chequegrid_Click_1(sender As Object, e As EventArgs) Handles chequegrid.Click
        Try
            txtcid.Text = chequegrid.CurrentRow.Cells(0).Value.ToString
            DateTimePicker1.Text = chequegrid.CurrentRow.Cells(5).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LinkLabel4_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        cheque_bindgrid()
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub RadTextBox4_TextChanged_1(sender As Object, e As EventArgs) Handles RadTextBox4.TextChanged
        chequegrid = filterdata(RadTextBox4.Text, cheque_search)
    End Sub
End Class