Public Class addleave
    Dim staffid As String = ""
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub cmdclear_Click(sender As Object, e As EventArgs) Handles cmdclear.Click
        Clear(Me)
        Try
            txtstaff.DataSource = New BindingSource(ShowData("SELECT * FROM `salary` left JOIN staff on salary.staff_id= staff.staff_id WHERE salary.onleave= '0' and sid='" & sid & "'"), Nothing)
            txtstaff.DisplayMember = "fullname"
        Catch ex As Exception
            showerror(ex.Message)
        End Try
        cdelete.Enabled = False
        ErrorProvider1.Clear()
    End Sub

    Private Sub addleave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
        If txtcid.Text = "" Then
            Try
                txtstaff.DataSource = New BindingSource(ShowData("SELECT * FROM `salary` left JOIN staff on salary.staff_id= staff.staff_id WHERE salary.onleave= '0' and staff.sid='" & sid & "'"), Nothing)
                txtstaff.DisplayMember = "fullname"
                cdelete.Enabled = False
            Catch ex As Exception
                showerror(ex.Message)
            End Try
        Else
            txtstaff.Text = getValue("select fullname from staff where staff_id='" + txtcid.Text + "' and sid= '" & sid & "'")

        End If
        If Not txtleave.Text = "" Then
            cdelete.Enabled = True
        End If
    End Sub

    Private Sub cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        If txtstaff.Text = "" Or txtleave.Text = "" Or leavestart.Text > leaveend.Text Or leavestart.Value < Now.Date Then
            showerror("Please do not leave any field empty!")
            Exit Sub
        Else
            execute("update salary set  leave_type ='" + txtleave.Text + "',Start_Date= '" + leavestart.Value.ToString("yyyy-MM-dd") + "',End_Date= '" + leaveend.Value.ToString("yyyy-MM-dd") + "',onleave='1' where staff_id = '" + txtcid.Text + "' and sid= '" & sid & "'", 1)
            cmdclear.PerformClick()
        End If
    End Sub

    Private Sub cdelete_Click(sender As Object, e As EventArgs) Handles cdelete.Click
        Dialog1.Label1.Text = "Are you sure you want to deactivate the leave on a record with Salary ID: " + txtcid.Text
        Dialog1.ShowDialog()
        If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
            querryString = "update salary set onleave = '0' where staff_id = '" + txtcid.Text + "' and sid = '" & sid & "'"
            execute(querryString, 2)
            cmdclear.PerformClick()
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtstaff_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles txtstaff.SelectedIndexChanged
        staffid = getValue("select staff_id from staff where fullname='" + txtstaff.Text + "' and sid='" & sid & "'")
        txtcid.Text = staffid
    End Sub
End Class