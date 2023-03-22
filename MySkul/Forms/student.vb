Public Class student
    Dim search2 As String = "select student_id as Student_ID, fullname as Fullname,gender as Gender,admission_date as Admission_Date,dob as Date_Of_Birth,father_name as Father,mother_name as Mother,father_contact as Father_Contact,mother_contact as Mother_Contact,address as Address,class as Class,nationality as Nationality,disability as Disability,religion as Religion,status as Status,academic as Academic,term as Term from student where sid = '" & sid & "' and class='" & tclass & "' and CONCAT(student_id,fullname,father_name,mother_name,class,gender`status`)"

    Dim search As String = "select student_id as Student_ID, fullname as Fullname,gender as Gender,admission_date as Admission_Date,dob as Date_Of_Birth,father_name as Father,mother_name as Mother,father_contact as Father_Contact,mother_contact as Mother_Contact,address as Address,class as Class,nationality as Nationality,disability as Disability,religion as Religion,status as Status,academic as Academic,term as Term from student where sid = '" & sid & "' and CONCAT(student_id,fullname,father_name,mother_name,class,gender,`status`)"
    Sub bindgrid()
        If ul = "6" Then
            querryString = "select student_id as Student_ID, fullname as Fullname,gender as Gender,admission_date as Admission_Date,dob as Date_Of_Birth,father_name as Father,mother_name as Mother,father_contact as Father_Contact,mother_contact as Mother_Contact,address as Address,class as Class,nationality as Nationality,disability as Disability,religion as Religion,status as Status,academic as Academic,term as Term from student where sid = '" & sid & "' and class='" & tclass & "'"
        Else
            querryString = "select student_id as Student_ID, fullname as Fullname,gender as Gender,admission_date as Admission_Date,dob as Date_Of_Birth,father_name as Father,mother_name as Mother,father_contact as Father_Contact,mother_contact as Mother_Contact,address as Address,class as Class,nationality as Nationality,disability as Disability,religion as Religion,status as Status,academic as Academic,term as Term from student where sid = '" & sid & "'"
        End If
        studentgrid.DataSource = ShowData(querryString)
        Try
            Me.studentgrid.BestFitColumns()
            Me.studentgrid.Columns("Student_ID").Width = 150
            Me.studentgrid.Columns("Fullname").Width = 400
            Me.studentgrid.Columns("Gender").Width = 120
            Me.studentgrid.Columns("Admission_date").Width = 200
            Me.studentgrid.Columns("Date_Of_Birth").Width = 200
            Me.studentgrid.Columns("Father").Width = 350
            Me.studentgrid.Columns("Mother").Width = 350
            Me.studentgrid.Columns("Father_Contact").Width = 200
            Me.studentgrid.Columns("Mother_Contact").Width = 200
            Me.studentgrid.Columns("Address").Width = 400
            Me.studentgrid.Columns("Class").Width = 120
            Me.studentgrid.Columns("Nationality").Width = 150
            Me.studentgrid.Columns("Disability").Width = 150
            Me.studentgrid.Columns("Religion").Width = 150
            Me.studentgrid.Columns("Status").Width = 150
            Me.studentgrid.Columns("Academic").Width = 150
            Me.studentgrid.Columns("Term").Width = 100
            For i As Integer = 0 To Me.studentgrid.ColumnCount - 1
                Me.studentgrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Sub bindgrid2(ByVal q As String)
        If ul = "6" Then
            querryString = "select student_id as Student_ID, fullname as Fullname,gender as Gender,admission_date as Admission_Date,dob as Date_Of_Birth,father_name as Father,mother_name as Mother,father_contact as Father_Contact,mother_contact as Mother_Contact,address as Address,class as Class,nationality as Nationality,disability as Disability,religion as Religion,status as Status,academic as Academic,term as Term from student where sid = '" & sid & "' and class='" & tclass & "'"
        Else
            querryString = "select student_id as Student_ID, fullname as Fullname,gender as Gender,admission_date as Admission_Date,dob as Date_Of_Birth,father_name as Father,mother_name as Mother,father_contact as Father_Contact,mother_contact as Mother_Contact,address as Address,class as Class,nationality as Nationality,disability as Disability,religion as Religion,status as Status,academic as Academic,term as Term from student where sid = '" & sid & "'"
        End If
        studentgrid.DataSource = ShowData(q)
        Try
            Me.studentgrid.AutoSize = False
            Me.studentgrid.Columns("Student_ID").Width = 150
            Me.studentgrid.Columns("Fullname").Width = 400
            Me.studentgrid.Columns("Gender").Width = 120
            Me.studentgrid.Columns("Admission_date").Width = 200
            Me.studentgrid.Columns("Date_Of_Birth").Width = 200
            Me.studentgrid.Columns("Father").Width = 350
            Me.studentgrid.Columns("Mother").Width = 350
            Me.studentgrid.Columns("Father_Contact").Width = 200
            Me.studentgrid.Columns("Mother_Contact").Width = 200
            Me.studentgrid.Columns("Address").Width = 400
            Me.studentgrid.Columns("Class").Width = 120
            Me.studentgrid.Columns("Nationality").Width = 150
            Me.studentgrid.Columns("Disability").Width = 150
            Me.studentgrid.Columns("Religion").Width = 150
            Me.studentgrid.Columns("Status").Width = 150
            Me.studentgrid.Columns("Academic").Width = 150
            Me.studentgrid.Columns("Term").Width = 100
            Me.studentgrid.HorizontalScrollState = True
            For i As Integer = 0 To Me.studentgrid.ColumnCount - 1
                Me.studentgrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
    Private Sub cmddelete_Click(sender As Object, e As EventArgs) Handles cmddelete.Click
        If txtid.Text = "" Then
            showerror("Please select a record to delete")
            Exit Sub
        Else
            Dialog1.Label1.Text = "Are you sure you want to delete a record with Student ID: " + txtid.Text
            Dialog1.ShowDialog()
            If Dialog1.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                querryString = "delete from student where student_id = '" + txtid.Text + "' and sid = '" & sid & "'"
                execute(querryString, 2)
                bindgrid()
            End If
        End If
    End Sub
    Private Sub cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        Dim c As Integer = record_count("select * from subclass where sid = '" & sid & "'")
        If c < 1 Then
            showerror("Please go to academics -> class and subclass to add class and a sub-class before you can register a student")
            Home.Button3.PerformClick()
        Else
            Dim adstu As New adstudent
            adstu.ShowDialog()
        End If
    End Sub
    Private Sub student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bindgrid()
        If ul = "3" Then
            cmddelete.Enabled = False
            RadButton2.Enabled = False
        ElseIf ul = "6" Or ul = "4" Or ul = "5" Then
            cmddelete.Enabled = False
            cmdadd.Enabled = False
            RadButton2.Enabled = False
        End If
    End Sub
    Private Sub RadGridView1_Click(sender As Object, e As EventArgs) Handles studentgrid.Click
        Try
            txtid.Text = studentgrid.CurrentRow.Cells(0).Value.ToString
        Catch ex As Exception
        End Try
    End Sub
    Private Sub RadTextBox1_TextChanged(sender As Object, e As EventArgs)
        If ul = "6" Then
            studentgrid.DataSource = filterdata(txtsearch.Text, search2)
        Else
            studentgrid.DataSource = filterdata(txtsearch.Text, search)
        End If
    End Sub
    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            If ul = "6" Then
                studentgrid.DataSource = filterdata(txtsearch.Text, search2)
            Else
                studentgrid.DataSource = filterdata(txtsearch.Text, search)
            End If
        End If
    End Sub
    Private Sub RadGridView1_DoubleClick(sender As Object, e As EventArgs) Handles studentgrid.DoubleClick
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim adstudent As New adstudent
            Dim Fullname As String = studentgrid.CurrentRow.Cells(1).Value.ToString.Trim
            If Fullname.Contains(",") Then
                Dim parts As String() = Fullname.Split(",")
                Dim other As String
                other = parts(1)
                adstudent.txtln.Text = parts(0)
                If other.Contains(" ") Then
                    Dim part2 As String() = other.Split(" ")
                    If part2.Count = 2 Then
                        adstudent.txtfirstname.Text = part2(0)
                        adstudent.txtmiddle.Text = part2(1)
                    ElseIf part2.Count = 3 Then
                        adstudent.txtfirstname.Text = part2(0)
                        adstudent.txtmiddle.Text = part2(1) & " " & part2(2)
                    End If
                Else
                    adstudent.txtfirstname.Text = other
                End If
            End If
            adstudent.txtstnum.Text = studentgrid.CurrentRow.Cells(0).Value.ToString
            adstudent.txtgender.Text = studentgrid.CurrentRow.Cells(2).Value.ToString
            adstudent.dob.Text = studentgrid.CurrentRow.Cells(4).Value.ToString
            adstudent.txtfn.Text = studentgrid.CurrentRow.Cells(5).Value.ToString
            adstudent.txtmn.Text = studentgrid.CurrentRow.Cells(6).Value.ToString
            adstudent.txtfc.Text = studentgrid.CurrentRow.Cells(7).Value.ToString
            adstudent.txtmc.Text = studentgrid.CurrentRow.Cells(8).Value.ToString
            adstudent.txtaddress.Text = studentgrid.CurrentRow.Cells(9).Value.ToString
            adstudent.lblclass.Text = "Class : " & studentgrid.CurrentRow.Cells(10).Value.ToString
            adstudent.txtn.Text = studentgrid.CurrentRow.Cells(11).Value.ToString
            adstudent.txtd.Text = studentgrid.CurrentRow.Cells(12).Value.ToString
            adstudent.txtrg.Text = studentgrid.CurrentRow.Cells(13).Value.ToString
            adstudent.txtadm.Text = studentgrid.CurrentRow.Cells(3).Value.ToString
            adstudent.txtid.Text = studentgrid.CurrentRow.Cells(0).Value.ToString
            adstudent.txtstatus.Text = studentgrid.CurrentRow.Cells(14).Value.ToString
            adstudent.txtsclass.Text = studentgrid.CurrentRow.Cells(10).Value.ToString
            adstudent.lblacademic.Text = "Academic year : " & studentgrid.CurrentRow.Cells(15).Value.ToString
            adstudent.lblterm.Text = "Term : " & studentgrid.CurrentRow.Cells(16).Value.ToString
            up = 1
            adstudent.ShowDialog()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        bindgrid()
    End Sub
    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Me.Cursor = Cursors.WaitCursor
        Dim export As New csv_export
        export.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        Me.Cursor = Cursors.WaitCursor
        Dim import As New csv_import
        import.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub txtsearch_TextChanged_1(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        If ul = "6" Then
            studentgrid.DataSource = filterdata(txtsearch.Text, search2)

        Else
            studentgrid.DataSource = filterdata(txtsearch.Text, search)

        End If
    End Sub
End Class