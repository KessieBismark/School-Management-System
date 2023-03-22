Imports MySql.Data.MySqlClient
Public Class etimetable
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub cmdclear_Click(sender As Object, e As EventArgs) Handles cmdclear.Click
        Clear(Me)
    End Sub

    Private Sub cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        eid.Text = academic_year & "-" & term
        If txtclass.Text = "" Or txtsubject.Text = "" Or txtst.Text = "" Or txtet.Text = "" Or txtdate.Value <= Now.Date Then
            showerror("Please do not leave any field empty and select the correct date!")
            Exit Sub
        Else
            Dim c As Integer = record_count("select * from exams where examid = '" + eid.Text + "' and class='" + txtclass.Text + "' and subject= '" + txtsubject.Text + "' and sid = '" & sid & "'")
            If c > 0 Then
                showerror("Exams " + eid.Text + " record exist. You have to delete it and re-enter it again!")
                cmddelete.Enabled = True
            Else
                querryString = "insert into exams(examid,subject,class,start,end,term,academic,date,sid) values('" + eid.Text + "','" + txtsubject.Text + "','" + txtclass.Text + "','" + txtst.Text + "','" + txtet.Text + "','" + term + "','" + academic_year + "','" + txtdate.Value.ToString("yyyy-MM-dd") + "','" & sid & "') "
                execute(querryString, 0)
                cmddelete.Enabled = False
            End If
        End If
    End Sub

    Private Sub etimetable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
        If eid.Text = "" Then
            txtclass.DataSource = New BindingSource(ShowData("select * from class where sid ='" & sid & "'"), Nothing)
            txtclass.DisplayMember = "class_no"

            txtsubject.DataSource = New BindingSource(ShowData("select * from subject_table where sid = '" & sid & "'"), Nothing)
            txtsubject.DisplayMember = "subject_name"
            txtdate.Value = Now.Date
            txtdate.Text = Now.Date
        End If
        If eid.Text = "" Then
            cmddelete.Enabled = False
        End If
    End Sub

    Private Sub cmddelete_Click(sender As Object, e As EventArgs) Handles cmddelete.Click
        Dialog1.Label1.Text = "Are you sure you want to delete a record of exams id: " + eid.Text + ", subject " + txtsubject.Text + " and class " + txtclass.Text
        Dialog1.ShowDialog()
        If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
            execute("delete from exams where examid = '" + eid.Text + "' and class='" + txtclass.Text + "' and subject= '" + txtsubject.Text + "' where sid = '" & sid & "'", 2)
        End If
    End Sub
End Class