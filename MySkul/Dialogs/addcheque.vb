Imports MySql.Data.MySqlClient
Public Class addcheque
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub txtcamount_TextChanged(sender As Object, e As EventArgs) Handles txtcamount.TextChanged
        If Not IsNumeric(txtcamount.Text) Then
            ErrorProvider1.SetError(txtcamount, "Please enter only number!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        Try
            txtcid.Text = academic_year & "-" & term & "-" & DateTime.Now.Second
            If txtcname.Text = "" Or txtcamount.Text = "" Or txtctype.Text = "" Then
                showerror("Please provide information for the empty spaces")
                Exit Sub
            ElseIf RadDateTimePicker1.Value < Now.Date Then
                showerror("Please set the cheque date to the date on the cheque")
                Exit Sub
            Else
                Try
                    txtcname.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtcname.Text)
                    execute("INSERT INTO `cheques`(`Cheque_ID`, `Name`, `Account_No`, `Amount`, `Type`, `Cheque_Date`,`sid`) VALUES ('" + txtcid.Text + "','" + txtcname.Text + "','" + txtaccount.Text + "','" + txtcamount.Text + "','" + txtctype.Text + "','" + RadDateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" & sid & "')", 0)
                    Clear(Me)
                    txtcid.Text = ""
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

    Private Sub addcheque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
        If Not txtcid.Text = "" Then
            Try
                txtcid.Text = academic_year & "-" & term & "-" & DateTime.Now.Second
            Catch ex As Exception
                showerror(ex.Message)
            End Try
        End If
    End Sub

    Private Sub cmdclear_Click(sender As Object, e As EventArgs) Handles cmdclear.Click
        Clear(Me)
        txtcid.Text = ""
        cmdadd.Enabled = True
        ErrorProvider1.Clear()
    End Sub

    Private Sub cdelete_Click(sender As Object, e As EventArgs) Handles cdelete.Click
        If txtcid.Text = "" Then
            showerror("Please select a record to delete")
            Exit Sub
        Else
            Dialog1.Label1.Text = "Are you sure you want to delete a record with Cheque ID: " + txtcid.Text
            Dialog1.ShowDialog()
            If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                execute("INSERT INTO `deletedcheques`(`Cheque_ID`, `Name`, `Account_No`, `Amount`, `Type`, `Cheque_Date`,`Deleted_by`,`sid`) VALUES ('" + txtcid.Text + "','" + txtcname.Text + "','" + txtaccount.Text + "','" + txtcamount.Text + "','" + txtctype.Text + "','" + RadDateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" & Home.user.Text & "','" & sid & "')", 5)
                querryString = "delete from cheques where Cheque_ID = '" + txtcid.Text + "' and sid = '" & sid & "'"
                execute(querryString, 2)
                Clear(Me)
                txtcid.Text = ""
                cmdadd.Enabled = True
                ErrorProvider1.Clear()
            End If
        End If
    End Sub

    Private Sub txtaccount_TextChanged(sender As Object, e As EventArgs) Handles txtaccount.TextChanged
        If Not IsNumeric(txtaccount.Text) Then
            ErrorProvider1.SetError(txtaccount, "Please enter only number!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub
End Class