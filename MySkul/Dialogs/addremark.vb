Public Class addremark
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
        Clear(Me)
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        Try
            If txtremark.Text = "" Or txtatt.Text = "" Then
                showerror("Please provide the needed information")
                Exit Sub
            ElseIf Not numbers(txtatt.Text) Then
                showerror("Input must not contain a letter")
                Exit Sub
            Else
                UCase(txtremark.Text)
                execute("update grade set Remark = '" + txtremark.Text + "',Attendance='" & txtatt.Text & "' where sid = '" & sid & "' and Student_ID= '" & lblstudent_id.Text & "'", 2)
                Dim c As Integer = record_count("select * from attitude where Attitude = '" + txtremark.Text + "' and sid = '" & sid & "'")
                If c < 1 Then
                    execute("insert into attitude(Attitude,sid)values('" + txtremark.Text + "','" & sid & "')", 3)
                End If
                Me.Close()
            End If
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub addremark_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
        Try
            txtremark.DataSource = New BindingSource(ShowData("SELECT * FROM `attitude` WHERE sid = '" & sid & "'"), Nothing)
            txtremark.DisplayMember = "Attitude"
            txtremark.Items.Add("")
        Catch ex As Exception

        End Try
    End Sub
End Class