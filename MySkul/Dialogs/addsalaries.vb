Public Class addsalaries
    Dim staffid As String = ""
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub addsalaries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
        If Txtid.Text = "" Then
            Try
                txtstaff.DataSource = New BindingSource(ShowData("SELECT * FROM `staff` WHERE sid = '" & sid & "' and staff_id NOT IN (SELECT staff_id from salary where sid = '" & sid & "')"), Nothing)
                txtstaff.DisplayMember = "fullname"
            Catch ex As Exception
                showerror(ex.Message)
            End Try
        Else
            txtstaff.Text = getValue("select fullname from staff where staff_id='" + Txtid.Text + "' and sid = '" & sid & "'")
        End If
    End Sub

    Private Sub cadd_Click(sender As Object, e As EventArgs) Handles cadd.Click
        If txtstaff.Text = "" Or txtamount.Text = "" Or txthours.Text = "" Then
            showerror("Please do not leave any field empty!")
            Exit Sub
        ElseIf Not IsNumeric(txtamount.Text) Then
            showerror("Salary input must be numbers only")
            Exit Sub
        Else
            If Txtid.Text = "" Then
                execute("insert into salary (staff_id,salary,hours,sid) values ('" + staffid + "','" + txtamount.Text + "','" + txthours.Text + "','" & sid & "')", 0)
                cclear.PerformClick()
            Else
                execute("update salary set  salary ='" + txtamount.Text + "',hours= '" + txthours.Text + "' where staff_id = '" + Txtid.Text + "' and sid= '" & sid & "'", 1)
                cclear.PerformClick()
            End If
        End If
    End Sub

    Private Sub cclear_Click(sender As Object, e As EventArgs) Handles cclear.Click
        Clear(Me)
        Try
            txtstaff.DataSource = New BindingSource(ShowData("SELECT * FROM `staff` WHERE sid = '" & sid & "' and staff_id NOT IN (SELECT staff_id from salary where sid = '" & sid & "')"), Nothing)
            txtstaff.DisplayMember = "fullname"
        Catch ex As Exception
            showerror(ex.Message)
        End Try
        cdelete.Enabled = False
        ErrorProvider1.Clear()
    End Sub

    Private Sub cdelete_Click(sender As Object, e As EventArgs) Handles cdelete.Click
        Dialog1.Label1.Text = "Are you sure you want to delete a record with Salary ID: " + Txtid.Text
        Dialog1.ShowDialog()
        If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
            querryString = "delete from salary where staff_id = '" + Txtid.Text + "' and sid = '" & sid & "'"
            execute(querryString, 2)
            cclear.PerformClick()
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtamount_TextChanged(sender As Object, e As EventArgs) Handles txtamount.TextChanged
        If Not IsNumeric(txtamount.Text) Then
            ErrorProvider1.SetError(txtamount, "Please enter only numbers!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtstaff_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles txtstaff.SelectedIndexChanged
        staffid = getValue("select staff_id from staff where fullname='" + txtstaff.Text + "' and sid ='" & sid & "'")
    End Sub

    Private Sub txtstaff_TextChanged(sender As Object, e As EventArgs) Handles txtstaff.TextChanged
        staffid = getValue("select staff_id from staff where fullname='" + txtstaff.Text + "' and sid ='" & sid & "'")
    End Sub
End Class