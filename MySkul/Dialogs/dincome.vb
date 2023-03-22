Public Class dincome
    Dim income_search As String = "select  `Income_ID`, `Name`, `Type`, `Amount`, `Academic`, `Term`, `Description`, `Paid_by`, `date`, `Deleted_by` from deletedincome where sid ='" & sid & "' and   CONCAT(Income_ID,Name,Type,Academic,Term,Paid_by,Date,Deleted_by)"

    Private Sub RadButton6_Click(sender As Object, e As EventArgs) Handles RadButton6.Click

        If txtcid.Text = "" Then
            showerror("Please click on the record you want to restore before you click on restore!")
            Exit Sub
        Else
            execute("INSERT INTO `income`(`Income_ID`, `Name`, `Type`, `Amount`, `Academic`, `Term`, `Description`, `Paid_by`,sid) VALUES ('" + txtcid.Text + "','" + incomegrid.CurrentRow.Cells(1).Value.ToString + "','" + incomegrid.CurrentRow.Cells(2).Value.ToString + "','" + incomegrid.CurrentRow.Cells(3).Value.ToString + "','" + incomegrid.CurrentRow.Cells(4).Value.ToString + "','" + incomegrid.CurrentRow.Cells(5).Value.ToString + "','" + incomegrid.CurrentRow.Cells(6).Value.ToString + "','" + incomegrid.CurrentRow.Cells(7).Value.ToString + "','" & sid & "')", 3)
            querryString = "delete from deletedincome where Income_ID = '" + txtcid.Text + "' and sid ='" & sid & "'"
            execute(querryString, 3)
            showinfo("Record has been restored successfully")
            Clear(Me)
            income_bindgrid()
        End If
    End Sub
    Sub income_bindgrid()
        querryString = "SELECT `Income_ID`, `Name`, `Type`, `Amount`, `Academic`, `Term`, `Description`, `Paid_by`, `date`, `Deleted_by` FROM `deletedincome` where sid ='" & sid & "' order by Date DESC"
        incomegrid.DataSource = ShowData(querryString)
        Try
            'Me.incomegrid.AutoSize = False
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
            Me.incomegrid.Columns("Deleted_by").Width = 150
            For i As Integer = 0 To Me.incomegrid.ColumnCount - 1
                Me.incomegrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub RadTextBox4_TextChanged(sender As Object, e As EventArgs) Handles RadTextBox4.TextChanged
        incomegrid = filterdata(RadTextBox4.Text, income_search)
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        income_bindgrid()
    End Sub

    Private Sub dincome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
        income_bindgrid()
    End Sub

    Private Sub incomegrid_Click(sender As Object, e As EventArgs) Handles incomegrid.Click
        Try
            txtcid.Text = incomegrid.CurrentRow.Cells(0).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub
End Class