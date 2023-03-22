Public Class view_users
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub
    Sub bindgrid()
        Try
            querryString = "SELECT `Staff_ID`as Staff_ID,Name as Fullname, `Username` as Username FROM `users` WHERE sid = '" & sid & "'"
            viewgrid.DataSource = ShowData(querryString)
            Me.viewgrid.BestFitColumns()
            Me.viewgrid.Columns("Staff_ID").Width = 50
            Me.viewgrid.Columns("Fullname").Width = 200
            Me.viewgrid.Columns("Username").Width = 100
            For i As Integer = 0 To Me.viewgrid.ColumnCount - 1
                Me.viewgrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
    Private Sub view_users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
        cdelete.Enabled = False
        bindgrid()
    End Sub


    Private Sub viewgrid_Click(sender As Object, e As EventArgs) Handles viewgrid.Click
        Try
            Dim vsf, vfn As String
            If Not viewgrid.CurrentRow.Cells(0).Value.ToString = "Admin" Then
                vsf = viewgrid.CurrentRow.Cells(0).Value.ToString
                vfn = viewgrid.CurrentRow.Cells(1).Value.ToString
                Label2.Text = vsf
                Label3.Text = vfn
                If Not vsf = "" And Not vfn = "" Then
                    cdelete.Enabled = True
                End If
            Else
                Label2.Text = ""
                Label3.Text = ""
                cdelete.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cdelete_Click(sender As Object, e As EventArgs) Handles cdelete.Click
        Dialog1.Label1.Text = "Are you sure you want to delete a user called : " + Label3.Text
        Dialog1.ShowDialog()
        If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
            querryString = "delete from users where Staff_ID = '" + Label2.Text + "' and sid = '" & sid & "'"
            execute(querryString, 2)
            cdelete.Enabled = False
            bindgrid()
        End If
    End Sub
End Class