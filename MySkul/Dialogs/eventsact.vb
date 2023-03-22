Imports MySql.Data.MySqlClient
Public Class eventsact
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        txteid.Text = academic_year & "-" & term
        If txteventname.Text = "" Or txtst.Value = Now.Date Or txtet.Value <= Now.Date Then
            showerror("Please do not leave any field empty and select the correct date!")
            Exit Sub
        Else

            Dim c As Integer = record_count("select * from events where eventid = '" + txteid.Text + "' and term='" + term + "' and ename= '" + txteventname.Text + "' and academic='" + academic_year + "' and sid='" & sid & "'")
            If c > 0 Then
                showerror("Exams " + txteid.Text + " record exist. You have to delete it and re-enter it again!")
                cmddelete.Enabled = True
            Else
                querryString = "insert into events(eventid,term,academic,ename,start,end,comment,sid) values('" + txteid.Text + "','" + term + "','" + academic_year + "','" + txteventname.Text + "','" + txtst.Value.ToString("yyyy-MM-dd") + "','" + txtet.Value.ToString("yyyy-MM-dd") + "','" + txtcom.Text + "','" & sid & "') "
                execute(querryString, 0)
                cmddelete.Enabled = False

            End If
        End If
    End Sub

    Private Sub cmddelete_Click(sender As Object, e As EventArgs) Handles cmddelete.Click
        Dialog1.Label1.Text = "Are you sure you want to delete a record of exams id: " + txteid.Text + ", term " + term + " and class " + txteventname.Text
        Dialog1.ShowDialog()
        If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
            execute("delete from events where eventid = '" + txteid.Text + "' and term='" + term + "' and ename= '" + txteventname.Text + "' and academic='" + academic_year + "' and sid ='" & sid & "'", 2)
        End If
    End Sub



    Private Sub cmdclear_Click(sender As Object, e As EventArgs) Handles cmdclear.Click
        Clear(Me)
    End Sub

    Private Sub events_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
        txtet.Text = Now.Date
        txtst.Text = Now.Date
        If txteid.Text = "" Then
            cmddelete.Enabled = False
        End If
    End Sub
End Class