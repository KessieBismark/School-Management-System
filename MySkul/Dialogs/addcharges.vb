Public Class addcharges
    Private Sub cadd_Click_1(sender As Object, e As EventArgs) Handles cadd.Click
        Try
            txtcid.Text = academic_year & "-" & term & "-" & DateTime.Now.Second
            If txtcname.Text = "" Or txtcamount.Text = "" Or txtcclist.Text = "" Then
                showerror("Please provide information for the empty spaces")
                Exit Sub
            Else
                Try
                    txtcname.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtcname.Text)
                    Dim c As Integer = record_count("select * from charges where name ='" + academic_year + "' and term ='" + term + "' and sid = '" & sid & "'")
                    If c < 1 Then
                        execute("INSERT INTO `charges`(`charge_id`, `name`, `amount`, `term`, `year`, `class`,`sid`) VALUES ('" + txtcid.Text + "','" + txtcname.Text + "','" + txtcamount.Text + "','" + term + "','" + academic_year + "','" + txtcclist.Text + "','" & sid & "')", 0)
                        Clear(Me)
                    Else
                        showerror("Record with name " & txtcname.Text & " already exist in the database!")
                    End If
                Catch ex As Exception
                    showerror(ex.Message)
                End Try

            End If
            ErrorProvider1.Clear()
        Catch ex As Exception
            ErrorProvider1.Clear()
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub cclear_Click(sender As Object, e As EventArgs) Handles cclear.Click
        Clear(Me)
        ErrorProvider1.Clear()
        Try
            txtcclass.DataSource = New BindingSource(ShowData("select * from class where sid ='" & sid & "' "), Nothing)
            txtcclass.DisplayMember = "class_no"
            txtcclass.Items.Add("All")
        Catch ex As Exception
            showerror(ex.Message)
        End Try
        txtcid.Text = ""
        txtcclist.Clear()
    End Sub

    Private Sub cdelete_Click(sender As Object, e As EventArgs) Handles cdelete.Click
        If txtcid.Text = "" Then
            showerror("Please select a record to delete")
            Exit Sub
        Else
            Dialog1.Label1.Text = "Are you sure you want to delete a record with Student ID: " + txtcid.Text
            Dialog1.ShowDialog()
            If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                querryString = "delete from charges where charge_id = '" + txtcid.Text + "' and sid = '" & sid & "'"
                execute(querryString, 2)
                Clear(Me)
                ErrorProvider1.Clear()
            End If
        End If
    End Sub

    Private Sub txtcamount_TextChanged(sender As Object, e As EventArgs) Handles txtcamount.TextChanged
        If Not IsNumeric(txtcamount.Text) Then
            ErrorProvider1.SetError(txtcamount, "Please enter only number!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtcname_TextChanged(sender As Object, e As EventArgs) Handles txtcname.TextChanged
        If IsNumeric(txtcname.Text) Then
            ErrorProvider1.SetError(txtcname, "Please enter only letters!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtcclass_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles txtcclass.SelectedIndexChanged
        If Not txtcclass.Text = "All" Then
            If txtcclist.Text = "All" Then
                txtcclist.Clear()
            End If
            txtcclist.Text = txtcclass.Text & "," & txtcclist.Text
        Else
            txtcclist.Text = ""
            txtcclist.Text = "All"
        End If
    End Sub


    Private Sub addcharges_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
        If txtcid.Text = "" Then
            Try
                txtcclass.DataSource = New BindingSource(ShowData("select * from class where sid = '" & sid & "'"), Nothing)
                txtcclass.DisplayMember = "class_no"
                txtcclass.Items.Add("All")
                txtcclass.Items.Add("")
            Catch ex As Exception
                showerror(ex.Message)
            End Try
            txtcclist.Clear()
            If txtcname.Text = "" Then
                txtcid.Text = academic_year & "-" & term & "-" & DateTime.Now.Second
            End If
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub
End Class