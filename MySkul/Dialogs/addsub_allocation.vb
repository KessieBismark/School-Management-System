Public Class addsub_allocation
    Dim subj As String
    Dim subb As String
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub cclear_Click(sender As Object, e As EventArgs) Handles cclear.Click
        Clear(Me)

    End Sub

    Private Sub addsub_allocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
        If txtcid.Text = "" Then
            Try
                cmddelete.Enabled = False
                txtsname.DataSource = New BindingSource(ShowData("select * from staff where employment_type ='Teaching Staff' and sid ='" & sid & "' "), Nothing)
                txtsname.DisplayMember = "fullname"

                txtsubject.DataSource = New BindingSource(ShowData("select * from subject_table where sid ='" & sid & "'order by subject_name ASC"), Nothing)
                txtsubject.DisplayMember = "subject_name"
                txtsubject.Items.Add("All")
                txtsubject.Items.Add("")
            Catch ex As Exception
                showerror(ex.Message)
            End Try
        Else
            txtsname.Text = getValue("select fullname from staff where staff_id = '" & txtcid.Text & "' and sid ='" & sid & "'")
            txtsubject.DataSource = New BindingSource(ShowData("select * from subject_table where sid ='" & sid & "' order by subject_name ASC"), Nothing)
            txtsubject.DisplayMember = "subject_name"
            txtsubject.Items.Add("All")
            txtsubject.Items.Add("")
            cmddelete.Enabled = True
        End If
    End Sub

    Private Sub txtsubject_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles txtsubject.SelectedIndexChanged
        subj = txtsubject.Text
        txtcclass.DataSource = New BindingSource(ShowData("SELECT * FROM subclass where sid = '" & sid & "' and s_class not in (SELECT Allocation from subject_allocation where Subject = '" + txtsubject.Text + "' and sid='" & sid & "') order by s_class ASC"), Nothing)
        txtcclass.DisplayMember = "s_class"
        txtcclass.Items.Add("")
    End Sub

    Private Sub cadd_Click(sender As Object, e As EventArgs) Handles cadd.Click
        If txtcid.Text = "" Or txtsname.Text = "" Or txtcclass.Text = "" Then
            showerror("Please do not leave any field empty!")
            Exit Sub
        Else
            If txtsubject.Text = "All" Then
                Dim all As Integer = 0
                Dim sb As New DataTable
                Dim sbid As New DataTable
                sb = ShowData("select * from subject_table where sid='" & sid & "'")
                If sb.Rows.Count > 0 Then
                    For i As Integer = 0 To sb.Rows.Count - 1
                        Dim c As Integer = record_count("select * from subject_allocation where Staff_ID= '" + txtcid.Text + "' and Subject = '" + sb.Rows(i)("subject_name").ToString + "'  and sid='" & sid & "'")
                        Dim record As String = getValue("select ID from subject_allocation where Staff_ID= '" + txtcid.Text + "' and Subject = '" + sb.Rows(i)("subject_name").ToString + "' and sid='" & sid & "'")
                        If c < 1 Then
                            execute("INSERT INTO `subject_allocation`(`Staff_ID`, `Subject`, `Allocation`,`sid`) VALUES ('" + txtcid.Text + "','" + sb.Rows(i)("subject_name").ToString + "','" + txtcclass.Text + "','" & sid & "')", 3)
                        Else
                            If all = 0 Then
                                imdialog.Label1.Text = "Record exist in the database. Do you want to update it "
                                imdialog.ShowDialog()
                                If imdialog.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                                    execute("Update subject_allocation set Allocation = '" + txtcclass.Text + "',Subject ='" & sb.Rows(i)("subject_name").ToString & "' where ID='" & record & "' and sid ='" & sid & "'", 3)
                                ElseIf imdialog.DialogResult = System.Windows.Forms.DialogResult.Retry Then
                                    execute("Update subject_allocation set Allocation = '" + txtcclass.Text + "',Subject ='" & sb.Rows(i)("subject_name").ToString & "' where ID='" & record & "' and sid ='" & sid & "'", 3)
                                    all = 1
                                End If
                            Else
                                execute("Update subject_allocation set Allocation = '" + txtcclass.Text + "',Subject ='" & sb.Rows(i)("subject_name").ToString & "' where ID='" & record & "' and sid ='" & sid & "'", 3)
                            End If
                        End If
                    Next
                    txtcclass.Text = ""

                    showinfo("All information has been saved!")
                End If
            Else
                Dim c As Integer = record_count("select * from subject_allocation where Staff_ID= '" + txtcid.Text + "' and Subject = '" + txtsubject.Text + "' and Allocation = '" + txtcclass.Text + "' and sid='" & sid & "'")
                Dim record As String = getValue("select ID from subject_allocation where Staff_ID= '" + txtcid.Text + "' and Subject = '" + txtsubject.Text + "' and Allocation = '" + txtcclass.Text + "' and sid='" & sid & "'")
                If c < 1 Then
                    execute("INSERT INTO `subject_allocation`(`Staff_ID`, `Subject`, `Allocation`,`sid`) VALUES ('" + txtcid.Text + "','" + txtsubject.Text + "','" + txtcclass.Text + "','" & sid & "')", 0)
                    txtcclass.Text = ""
                Else
                    Dialog1.Label1.Text = "Record exist in the database. Do you want to update it "
                    Dialog1.ShowDialog()
                    If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                        execute("Update subject_allocation set Allocation = '" + txtcclass.Text + "' where ID='" & record & "' and sid ='" & sid & "'", 2)
                        txtcclass.Text = ""
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtsname_SelectedIndexChanged_1(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles txtsname.SelectedIndexChanged
        Try
            txtcid.Text = getValue("select staff_id from staff where fullname = '" + txtsname.Text + "' and sid ='" & sid & "'")
            txtsubject.Text = ""
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtsname_TextChanged(sender As Object, e As EventArgs) Handles txtsname.TextChanged
        Try
            txtcid.Text = getValue("select staff_id from staff where fullname = '" + txtsname.Text + "' and sid ='" & sid & "'")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtsubject_TextChanged(sender As Object, e As EventArgs) Handles txtsubject.TextChanged
        txtcclass.DataSource = New BindingSource(ShowData("SELECT * FROM subclass where sid ='" & sid & "' and s_class not in (SELECT Allocation from subject_allocation where Subject = '" + txtsubject.Text + "' and sid ='" & sid & "') order by s_class ASC"), Nothing)
        txtcclass.DisplayMember = "s_class"
        txtcclass.Items.Add("")
    End Sub
End Class