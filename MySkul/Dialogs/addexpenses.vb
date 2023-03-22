Imports MySql.Data.MySqlClient
Public Class addexpenses
    Private Sub cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        Try
            txteid.Text = "EXP" & academic_year & "-" & term
            If txtename.Text = "" Or txteamount.Text = "" Then
                showerror("Please do not leave any field empty!")
                Exit Sub
            ElseIf Not numbers(txteamount.Text) Then
                showerror("Amount must be numbers only!")
                Exit Sub
            Else
                txtename.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtename.Text)
                con = New MySqlConnection(cs)
                cmd = New MySqlCommand("select * from expenses where Expenses_ID = '" + txteid.Text + "' and sid= '" & sid & "'", con)
                adp = New MySqlDataAdapter(cmd)
                tb2 = New DataTable
                adp.Fill(tb2)

                If tb2.Rows.Count > 0 Then
                    Txtrecord.Text = tb2.Rows(0)(2).ToString
                    Txtrecord.Text = Txtrecord.Text & " " & txtename.Text & "-" & txteamount.Text & ","
                    execute("UPDATE `expenses` SET `Record`='" + Txtrecord.Text + "' WHERE Expenses_ID = '" + txteid.Text + "' and sid= '" & sid & "'", 1)
                    txteamount.Text = ""
                    txtename.Text = ""
                    Txtrecord.Clear()
                Else
                    Txtrecord.Text = " " & txtename.Text & "-" & txteamount.Text & ","
                    querryString = "INSERT INTO `expenses`(`Expenses_ID`,`Record`, `Academic`, `Term`,`sid`) VALUES ('" + txteid.Text + "','" + Txtrecord.Text + "','" + academic_year + "','" + term + "','" & sid & "') "
                    execute(querryString, 0)
                    txteamount.Text = ""
                    txtename.Text = ""
                    Txtrecord.Clear()
                End If
            End If
            ErrorProvider1.Clear()
        Catch ex As Exception
            ErrorProvider1.Clear()
            showerror(ex.Message)
        End Try
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub
    Private Sub addsclass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
        txteid.Text = "EXP" & academic_year & "-" & term
    End Sub
    Private Sub cmdclear_Click(sender As Object, e As EventArgs) Handles cmdclear.Click
        txteamount.Text = ""
        txtename.Text = ""
        txteid.Text = ""
        Txtrecord.Clear()
    End Sub

    Private Sub txtmstudents_TextChanged(sender As Object, e As EventArgs) Handles txteamount.TextChanged
        If Not IsNumeric(txteamount.Text) Then
            ErrorProvider1.SetError(txteamount, "Please enter only numbers!.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub
End Class