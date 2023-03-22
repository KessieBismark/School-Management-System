Imports System.IO
Imports System.Text
Imports System.Data.OleDb
Public Class marks
    Dim ex As Double = 0
    Dim mid As Double = 0
    Dim exam As Double = 0
    Dim assessment As Double
    Dim assessment_percentage As Double
    Dim examsp As Double
    Dim exams_percentage As Double
    Dim d_grade As String
    Dim conn As OleDbConnection
    Dim dta As OleDbDataAdapter
    Dim ts As DataSet
    Dim excel As String
    Dim tb1 As New DataTable("Table")
    Dim report As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Dim school_name As String

    Private Sub RadButton6_Click(sender As Object, e As EventArgs) Handles RadButton6.Click
        Me.Cursor = Cursors.WaitCursor
        Dim adm As New addmarks
        addmarks.ShowDialog()
        Me.Cursor = Cursors.WaitCursor
    End Sub
    Sub analysis_bindgrid()
        querryString = "SELECT  `subject` as Subject, `marks_count` as Student_Count, `total_marks` as Total_Marks, `obtained_marks` as Obtained_Marks, `average` as Average, `average_males` as Average_of_Males, `average_females` as Average_of_Females, `academic` as Academic, `term` as Term FROM `exams_analysis` where sid = '" & sid & "' "
        anagrid.DataSource = ShowData(querryString)
        Try
            Me.anagrid.BestFitColumns()
            Me.anagrid.Columns("Student_Count").Width = 50
            Me.anagrid.Columns("Total_Marks").Width = 80
            Me.anagrid.Columns("Obtained_Marks").Width = 100
            Me.anagrid.Columns("Subject").Width = 200
            Me.anagrid.Columns("Average_of_Males").Width = 100
            Me.anagrid.Columns("Average_of_Females").Width = 100
            Me.anagrid.Columns("Average").Width = 80
            Me.anagrid.Columns("Academic").Width = 80
            Me.anagrid.Columns("Term").Width = 50

            For i As Integer = 0 To Me.anagrid.ColumnCount - 1
                Me.anagrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            Next
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        If txtmsubject.Text = "" Or txtclass.Text = "" Then
            showerror("Please select the subject and the class you want to upload its marks")
            Exit Sub
        Else
            Try
                Dim openfiledialog As New OpenFileDialog
                openfiledialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                openfiledialog.Filter = "CSV Files (*.csv)|*.csv"
                If openfiledialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                    Me.Cursor = Cursors.WaitCursor
                    Dim fi As New IO.FileInfo(openfiledialog.FileName)
                    tb1.Rows.Clear()
                    Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(fi.FullName)
                        MyReader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
                        MyReader.Delimiters = New String() {","}
                        Dim currentRow As String()
                        Dim firstline As Boolean = True
                        While Not MyReader.EndOfData
                            Try
                                currentRow = MyReader.ReadFields()
                                If firstline = True Then
                                    firstline = False
                                Else
                                    tb1.Rows.Add(currentRow)
                                End If
                            Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                                showerror("Line " & ex.Message & " is invalid.  Skipping")
                            End Try
                            Application.DoEvents()
                        End While
                    End Using
                    marksgrid.DataSource = tb1
                    Me.Cursor = Cursors.Default
                    For i As Integer = 0 To Me.marksgrid.ColumnCount - 1
                        Me.marksgrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
                    Next
                    cmdmsave.Enabled = True
                End If

                'Dim openfiledialog As New OpenFileDialog
                'openfiledialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                'openfiledialog.Filter = "All Files (*.*)|*.*|Excel Files (*.xlsx)|*.xlsx|Xls Files(*xls)|*.xls"
                'If openfiledialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                '    Dim fi As New IO.FileInfo(openfiledialog.FileName)
                '    Dim filename As String = openfiledialog.FileName
                '    excel = fi.FullName
                '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties =Excel 12.0;")
                '    dta = New OleDbDataAdapter("Select * from [Sheet1$]", conn)
                '    ts = New DataSet
                '    dta.Fill(ts, "[Sheet1$]")
                '    marksgrid.DataSource = ts
                '    marksgrid.DataMember = "[Sheet1$]"
                '    cmdmsave.Enabled = True
                '    conn.Close()
                'End If
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                showerror(ex.Message)
            End Try
        End If

    End Sub

    Private Sub marks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        analysis_bindgrid()

        If ul = "3" Then
            RadButton6.Enabled = False
        End If
        Me.Cursor = Cursors.WaitCursor
        cmdmsave.Enabled = False
        Try
            If ul = "6" Then
                txtmsubject.DataSource = New BindingSource(ShowData("select * from subject_allocation where Staff_ID = '" & staffid & "' and sid ='" & sid & "'  group by Subject"), Nothing)
                txtmsubject.DisplayMember = "Subject"
                txtmsubject.Items.Add("")

                txtspsubject.DataSource = New BindingSource(ShowData("select * from subject_allocation where Staff_ID = '" & staffid & "' and sid = '" & sid & "' group by Subject"), Nothing)
                txtspsubject.DisplayMember = "Subject"
                txtspsubject.Items.Add("")

                txtasub.DataSource = New BindingSource(ShowData("select * from subject_allocation where Staff_ID = '" & staffid & "' and sid = '" & sid & "' group by Subject"), Nothing)
                txtasub.DisplayMember = "Subject"
                txtasub.Items.Add("")

                txtrclass.DataSource = New BindingSource(ShowData("select * from staff where  Staff_ID='" & staffid & "' and sid = '" & sid & "'"), Nothing)
                txtrclass.DisplayMember = "Classes"
                txtrclass.Items.Add("")


            Else
                txtmsubject.DataSource = New BindingSource(ShowData("select * from subject_table where sid ='" & sid & "' group by subject_name"), Nothing)
                txtmsubject.DisplayMember = "subject_name"
                txtmsubject.Items.Add("")

                txtasub.DataSource = New BindingSource(ShowData("select * from subject_table where sid ='" & sid & "' group by subject_name"), Nothing)
                txtasub.DisplayMember = "subject_name"
                txtasub.Items.Add("All")
                txtmsubject.Items.Add("")

                txtspsubject.DataSource = New BindingSource(ShowData("select * from subject_table where sid = '" & sid & "' group by subject_name"), Nothing)
                txtspsubject.DisplayMember = "subject_name"
                txtspsubject.Items.Add("")

                txtrclass.DataSource = New BindingSource(ShowData("select * from subclass where sid = '" & sid & "' order by s_class ASC"), Nothing)
                txtrclass.DisplayMember = "s_class"
                txtrclass.Items.Add("")



            End If

            txtspacademic.DataSource = New BindingSource(ShowData("select * from academic_year  where sid = '" & sid & "' group by academic order by academic DESC"), Nothing)
            txtspacademic.DisplayMember = "academic"
            txtspacademic.Items.Add("")

            txtaacademic.DataSource = New BindingSource(ShowData("select * from academic_year  where sid = '" & sid & "'  group by academic order by academic DESC"), Nothing)
            txtaacademic.DisplayMember = "academic"
            txtaacademic.Items.Add("")



            txtracademic.DataSource = New BindingSource(ShowData("select * from academic_year where sid = '" & sid & "' group by academic order by academic DESC"), Nothing)
            txtracademic.DisplayMember = "academic"
            txtracademic.Items.Add("")
            school_name = getValue("select name from school_profile where sid = '" & sid & "'")
        Catch ex As Exception
            showerror(ex.Message)
        End Try

        tb = New DataTable
        tb = ShowData("select * from d_grade where status = '1' and sid = '" & sid & "'")
        If tb.Rows.Count > 0 Then
            d_grade = tb.Rows(0)(0).ToString
            assessment = tb.Rows(0)(1).ToString
            assessment_percentage = tb.Rows(0)(2).ToString
            examsp = tb.Rows(0)(3).ToString
            exams_percentage = tb.Rows(0)(4).ToString
        Else
            Home.Button3.PerformClick()
            showerror("Please go to 'Assessment' and input the overall marks total and its corresponding percentage!")
            Me.Close()
        End If
        tb1.Columns.Add("Student_ID")
        tb1.Columns.Add("Fullname")
        tb1.Columns.Add("Exercise")
        tb1.Columns.Add("Mid_Term")
        tb1.Columns.Add("Exams")
        Try
            tb2 = New DataTable
            tb2 = ShowData("select * from subject_table where sid ='" & sid & "'")
            tb3 = New DataTable
            tb3 = ShowData("select * from subclass where sid = '" & sid & "'")
            For i As Integer = 0 To tb2.Rows.Count - 1
                For j As Integer = 0 To tb3.Rows.Count - 1
                    tb4 = New DataTable
                    tb4 = ShowData(" SELECT `ID`, `Student_ID`, `Name`, `Subject`, `Class_Score`, `Exams_Score`, `Total`, `Remark`, `Academic`, `Term`, `Position`, `Class`, `Date` FROM `marks` WHERE Class='" & tb3.Rows(j)(1).ToString & "' and Subject='" & tb2.Rows(i)(1).ToString & "' and Academic='" & academic_year & "' and Term='" & term & "' and sid='" & sid & "' and Position is null order by Total DESC")
                    If tb4.Rows.Count > 0 Then
                        tb5 = New DataTable
                        tb5 = ShowData(" SELECT `ID`, `Student_ID`, `Name`, `Subject`, `Class_Score`, `Exams_Score`, `Total`, `Remark`, `Academic`, `Term`, `Position`, `Class`, `Date` FROM `marks` WHERE Class='" & tb3.Rows(j)(1).ToString & "' and Subject='" & tb2.Rows(i)(1).ToString & "' and Academic='" & academic_year & "' and Term='" & term & "' and sid ='" & sid & "' order by Total DESC")
                        Dim r As Integer = 0
                        For q As Integer = 0 To tb5.Rows.Count - 1
                            r = r + 1
                            execute("Update marks set Position = '" & r & "' where ID = '" & tb5.Rows(q)(0).ToString & "' and sid = '" & sid & "'", 3)
                            Dim tt As Double = getnumber("select sum(Total) from marks where Student_ID ='" & tb5.Rows(q)(1).ToString & "' and Class= '" & tb5.Rows(q)(11).ToString & "' and Academic='" & academic_year & "' and Term='" & term & "' and sid ='" & sid & "'")
                            execute("update grade set Overall_Marks='" & tt & "' where Student_Name='" & tb5.Rows(q)(2).ToString & "' and Student_ID='" & tb5.Rows(q)(1).ToString & "' and Academic ='" & academic_year & "' and Term='" & term & "' and sid = '" & sid & "'", 3)
                        Next
                        tb6 = New DataTable
                        tb6 = ShowData("select * from grade where Class= '" & tb3.Rows(j)(1).ToString & "' and Academic='" & academic_year & "' and Term='" & term & "'  and sid = '" & sid & "' order by Overall_Marks DESC")
                        If tb6.Rows.Count > 0 Then
                            Dim cc As Integer = 0
                            For w As Integer = 0 To tb6.Rows.Count - 1
                                cc = cc + 1
                                execute("update grade set Overall_Position='" & cc & "' where Student_Name='" & tb6.Rows(w)(2).ToString & "'and Student_ID='" & tb6.Rows(w)(1).ToString & "' and Academic ='" & academic_year & "' and Term='" & term & "' and sid ='" & sid & "'", 3)
                            Next
                        End If
                    End If
                Next
            Next
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            showerror(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdmsave_Click(sender As Object, e As EventArgs) Handles cmdmsave.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim all As Integer = 0
            For i As Integer = 0 To marksgrid.Rows.Count - 1 Step 1
                tb3 = New DataTable
                tb3 = ShowData("select * from marks where Student_ID = '" & marksgrid.Rows(i).Cells(0).Value.ToString & "' and Subject ='" + txtmsubject.Text + "' and Academic = '" & academic_year & "' and Term = '" & term & "' and sid='" & sid & "'")
                Dim ex_percent As Integer = 0
                Dim exams_percent As Integer = 0
                Dim got As Double = 0
                Dim total As Integer = 0
                Dim tb2 As New DataTable
                got = Val(marksgrid.Rows(i).Cells(2).Value.ToString) + Val(marksgrid.Rows(i).Cells(3).Value.ToString)
                ex_percent = (got / assessment) * assessment_percentage
                exams_percent = (Val(marksgrid.Rows(i).Cells(4).Value.ToString) / examsp) * exams_percentage
                total = ex_percent + exams_percent
                tb2 = ShowData("select * from grading where lower_limit <= '" & total & "' and upper_limit >= '" & total & "' and sid ='" & sid & "'")
                If tb3.Rows.Count < 1 Then
                    execute("INSERT INTO `marks`(`Student_ID`, `Name`, `Subject`, `Class_Score`, `Exams_Score`, `Total`, `Remark`, `Academic`, `Term`,`d_grade`,`Class`,`sid`,`Grading`) VALUES ('" & marksgrid.Rows(i).Cells(0).Value.ToString & "','" & marksgrid.Rows(i).Cells(1).Value.ToString & "','" & txtmsubject.Text & "','" & ex_percent & "','" & exams_percent & "','" & total & "','" & tb2.Rows(0)("remark").ToString & "','" & academic_year & "','" & term & "','" & d_grade & "','" + txtclass.Text + "','" & sid & "','" & tb2.Rows(0)("letter_grade").ToString & "')", 3)
                    'insert into grade
                    Dim c As Integer = record_count("select * from grade where Student_ID='" & marksgrid.Rows(i).Cells(0).Value.ToString & "' and Academic='" & academic_year & "' and Term='" & term & "' and Class ='" & txtclass.Text & "' and sid = '" & sid & "'")
                    If c < 1 Then
                        execute("insert into grade(Student_ID,Student_Name,Academic,Term,Class,sid) values ('" & marksgrid.Rows(i).Cells(0).Value.ToString & "','" & marksgrid.Rows(i).Cells(1).Value.ToString & "','" & academic_year & "','" & term & "','" & txtclass.Text & "','" & sid & "')", 3)
                    End If
                Else
                    If all = 0 Then
                        imdialog.Label1.Text = "Are you sure you want modify the marks of : " & marksgrid.Rows(i).Cells(1).Value.ToString
                        imdialog.ShowDialog()
                        If imdialog.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                            execute("UPDATE `marks` SET `Class_Score`='" & ex_percent & "',`Exams_Score`='" & exams_percent & "',`Total`='" & total & "',`Remark`='" & tb2.Rows(0)("remark").ToString & "',Grading = '" & tb2.Rows(0)("letter_grade").ToString & "' WHERE Student_ID ='" & marksgrid.Rows(i).Cells(0).Value.ToString & "' and Name='" & marksgrid.Rows(i).Cells(1).Value.ToString & "' and Academic='" & academic_year & "' and Term='" & term & "' and Class='" + txtclass.Text + "' and sid ='" & sid & "' and Subject = '" & txtmsubject.Text & "'", 3)
                        ElseIf imdialog.DialogResult = System.Windows.Forms.DialogResult.Retry Then
                            all = 1
                            execute("UPDATE `marks` SET `Class_Score`='" & ex_percent & "',`Exams_Score`='" & exams_percent & "',`Total`='" & total & "',`Remark`='" & tb2.Rows(0)("remark").ToString & "',Grading = '" & tb2.Rows(0)("letter_grade").ToString & "' WHERE Student_ID ='" & marksgrid.Rows(i).Cells(0).Value.ToString & "' and Name='" & marksgrid.Rows(i).Cells(1).Value.ToString & "' and Academic='" & academic_year & "' and Term='" & term & "'and Class='" + txtclass.Text + "' and sid = '" & sid & "' and Subject = '" & txtmsubject.Text & "'", 3)
                        End If
                    Else
                        execute("UPDATE `marks` SET `Class_Score`='" & ex_percent & "',`Exams_Score`='" & exams_percent & "',`Total`='" & total & "',`Remark`='" & tb2.Rows(0)("remark").ToString & "',Grading = '" & tb2.Rows(0)("letter_grade").ToString & "' WHERE Student_ID ='" & marksgrid.Rows(i).Cells(0).Value.ToString & "' and Name='" & marksgrid.Rows(i).Cells(1).Value.ToString & "' and Academic='" & academic_year & "' and Term='" & term & "'and Class='" + txtclass.Text + "' and sid = '" & sid & "' and Subject = '" & txtmsubject.Text & "'", 3)
                    End If
                End If
            Next
            Me.Cursor = Cursors.Default
            showinfo("All marks were saved successfully")
        Catch ex As Exception
            showerror(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
        txtmsubject.Enabled = True
    End Sub

    Private Sub spsearch_Click(sender As Object, e As EventArgs) Handles spsearch.Click
        If txtspacademic.Text = "" Or txtspsubject.Text = "" Or txtspclass.Text = "" Or txtspterm.Text = "" Then
            showerror("Please select the required information!")
            Exit Sub
        Else
            Me.Cursor = Cursors.WaitCursor
            querryString = "SELECT `Student_ID`, `Name`, `Subject`, `Class_Score`, `Exams_Score`, `Total`, `Remark`, `Academic`, `Term`, `Position`, `Class`, `Date`,`d_grade` as GP_ID FROM `marks` where Subject='" & txtspsubject.Text & "' and Academic  ='" & txtspacademic.Text & "' and Class='" & txtspclass.Text & "' and Term='" & txtspterm.Text & "' and sid = '" & sid & "' order by Total DESC"
            spgrid.DataSource = ShowData(querryString)
            Try
                Me.spgrid.BestFitColumns()
                Me.spgrid.Columns("Student_ID").Width = 100
                Me.spgrid.Columns("Name").Width = 250
                Me.spgrid.Columns("Subject").Width = 130
                Me.spgrid.Columns("Class_Score").Width = 100
                Me.spgrid.Columns("Exams_Score").Width = 100
                Me.spgrid.Columns("Total").Width = 100
                Me.spgrid.Columns("Remark").Width = 120
                Me.spgrid.Columns("Academic").Width = 100
                Me.spgrid.Columns("Term").Width = 70
                Me.spgrid.Columns("Position").Width = 100
                Me.spgrid.Columns("Class").Width = 70
                Me.spgrid.Columns("Date").Width = 150
                Me.spgrid.Columns("GP_ID").Width = 100
                For i As Integer = 0 To Me.spgrid.ColumnCount - 1
                    Me.spgrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
                Next
            Catch ex As Exception
                showerror(ex.Message)
            End Try
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub txtspsubject_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles txtspsubject.SelectedIndexChanged
        Try
            If ul = "6" Then
                txtspclass.DataSource = New BindingSource(ShowData("select * from subject_allocation where (Subject ='" + txtspsubject.Text + "' or Subject = 'All') and Staff_ID='" & staffid & "' and sid = '" & sid & "' order by Allocation ASC"), Nothing)
                txtspclass.DisplayMember = "Allocation"
                txtspclass.Items.Add("")
            Else
                txtspclass.DataSource = New BindingSource(ShowData("select * from subject_allocation where (Subject ='" + txtspsubject.Text + "' or Subject = 'All') and sid = '" & sid & "'  order by Allocation ASC"), Nothing)
                txtspclass.DisplayMember = "Allocation"
                txtspclass.Items.Add("")
            End If
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub txtspsubject_TextChanged(sender As Object, e As EventArgs) Handles txtspsubject.TextChanged
        Try
            If ul = "6" Then
                txtspclass.DataSource = New BindingSource(ShowData("select * from subject_allocation where Subject ='" + txtspsubject.Text + "'and Staff_ID='" & staffid & "' and sid = '" & sid & "'  order by Allocation ASC"), Nothing)
                txtspclass.DisplayMember = "Allocation"
                txtspclass.Items.Add("")
            Else
                txtspclass.DataSource = New BindingSource(ShowData("select * from subject_allocation where Subject ='" + txtspsubject.Text + "'and  sid = '" & sid & "'  order by Allocation ASC"), Nothing)
                txtspclass.DisplayMember = "Allocation"
                txtspclass.Items.Add("")
            End If
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub gsave_Click(sender As Object, e As EventArgs) Handles gsave.Click
        If txtracademic.Text = "" Or txtrname.Text = "" Or txtrclass.Text = "" Or txtrterm.Text = "" Then
            showerror("Please select the required information!")
            Exit Sub
        Else
            Me.Cursor = Cursors.WaitCursor
            querryString = "SELECT  `Subject`, `Class_Score`, `Exams_Score`, `Total`,`Position`,`Grading`,`Remark` FROM `marks` where Name='" & txtrname.Text & "' and Academic  ='" & txtracademic.Text & "' and Class='" & txtrclass.Text & "' and Term='" & txtrterm.Text & "' and sid = '" & sid & "' order by Subject ASC"
            gradegrid.DataSource = ShowData(querryString)
            Try
                Me.gradegrid.BestFitColumns()
                Me.gradegrid.Columns("Subject").Width = 150
                Me.gradegrid.Columns("Class_Score").Width = 100
                Me.gradegrid.Columns("Exams_Score").Width = 100
                Me.gradegrid.Columns("Total").Width = 100
                Me.gradegrid.Columns("Position").Width = 100
                Me.gradegrid.Columns("Grading").Width = 100
                Me.gradegrid.Columns("Remark").Width = 120
                For i As Integer = 0 To Me.gradegrid.ColumnCount - 1
                    Me.gradegrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
                Next
                tb = New DataTable
                tb = ShowData("select * from grade where Student_Name='" & txtrname.Text & "' and Academic  ='" & txtracademic.Text & "' and Class='" & txtrclass.Text & "' and Term='" & txtrterm.Text & "' and sid = '" & sid & "'")
                lblposition.Text = "Overall Marks : " & tb.Rows(0)(3).ToString & vbCrLf & "Overall Position : " & tb.Rows(0)(4).ToString & vbCrLf & "Remarks: " & tb.Rows(0)("Remark").ToString
                If ul = "6" Then
                    cmdaddr.Visible = True
                    addremark.lblstudent_id.Text = tb.Rows(0)("Student_ID").ToString
                    addremark.lblstinfo.Text = "Student Name : " & tb.Rows(0)("Student_Name").ToString & vbCrLf & "Overall Marks : " & tb.Rows(0)(3).ToString & vbCrLf & "Overall Position : " & tb.Rows(0)(4).ToString
                End If
            Catch ex As Exception
                showerror(ex.Message)
            End Try
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub txtrclass_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles txtrclass.SelectedIndexChanged
        Try
            txtrname.Text = ""
            txtrname.DataSource = New BindingSource(ShowData("select * from grade where class='" + txtrclass.Text + "' and sid = '" & sid & "' order by Student_Name ASC"), Nothing)
            txtrname.DisplayMember = "Student_Name"
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub txtrclass_TextChanged(sender As Object, e As EventArgs) Handles txtrclass.TextChanged
        Try
            txtrname.Text = ""
            txtrname.DataSource = New BindingSource(ShowData("select * from grade where class='" + txtrclass.Text + "' and sid ='" & sid & "' order by Student_Name DESC"), Nothing)
            txtrname.DisplayMember = "Student_Name"
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub txtmsubject_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles txtmsubject.SelectedIndexChanged
        Try
            If ul = "6" Then
                txtclass.DataSource = New BindingSource(ShowData("select * from subject_allocation where (Subject ='" + txtmsubject.Text + "' or Subject = 'All') and Staff_ID='" & staffid & "' and sid = '" & sid & "' order by Allocation"), Nothing)
                txtclass.DisplayMember = "Allocation"
                txtclass.Items.Add("")
            Else
                txtclass.DataSource = New BindingSource(ShowData("select * from subject_allocation where (Subject ='" + txtmsubject.Text + "'or Subject = 'All') and  sid = '" & sid & "' order by Allocation"), Nothing)
                txtclass.DisplayMember = "Allocation"
                txtclass.Items.Add("")
            End If
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub txtmsubject_TextChanged(sender As Object, e As EventArgs) Handles txtmsubject.TextChanged
        Try
            If ul = "6" Then
                txtclass.DataSource = New BindingSource(ShowData("select * from subject_allocation where Subject ='" + txtmsubject.Text + "'and Staff_ID='" & staffid & "' and sid = '" & sid & "'  order by Allocation"), Nothing)
                txtclass.DisplayMember = "Allocation"
                txtclass.Items.Add("")
            Else
                txtclass.DataSource = New BindingSource(ShowData("select * from subject_allocation where Subject ='" + txtmsubject.Text + "'and  sid = '" & sid & "'  order by Allocation"), Nothing)
                txtclass.DisplayMember = "Allocation"
                txtclass.Items.Add("")
            End If
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub


    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            'exams analysis of last academic year 
            Dim ttb = New DataTable
            Dim ta As New DataTable
            ta = ShowData("select academic,term from academic_year where  id = (select (max(id)-1) from academic_year where sid = '" & sid & "') and sid = '" & sid & "'")
            If ta.Rows.Count > 0 Then
                ttb = ShowData("select count(`Student_ID`) as 'Total_count', SUM(`Total`) as 'Total_sum',Subject as 'Subject' from marks where  sid ='" & sid & "' and Academic = '" & ta.Rows(0)("academic").ToString & "' and term='" & ta.Rows(0)("term").ToString & "' GROUP by Subject")
                Dim total_count, total_sum, average As Double
                tb3 = New DataTable
                tb2 = New DataTable
                tb2 = ShowData("select count(`Student_ID`) as 'Total_count', SUM(`Total`) as 'Total_sum',Subject as 'Subject' from marks where Student_ID != all (select student_id from student where gender='Female' and sid= '" & sid & "') and sid ='" & sid & "' and Academic = '" & ta.Rows(0)("academic").ToString & "' and term='" & ta.Rows(0)("term").ToString & "' GROUP by Subject")
                tb3 = ShowData("select count(`Student_ID`) as 'Total_count', SUM(`Total`) as 'Total_sum',Subject as 'Subject' from marks where Student_ID= any(select student_id from student where gender='Female' and sid='" & sid & "')  and sid ='" & sid & "' and Academic = '" & ta.Rows(0)("academic").ToString & "' and term='" & ta.Rows(0)("term").ToString & "' GROUP by Subject")
                Dim total_marks As Integer
                Dim ma, mf As Double

                For r As Integer = 0 To ttb.Rows.Count - 1
                    'calculations
                    total_marks = Val(ttb.Rows(r)("Total_count").ToString) * 100
                    total_count = Val(ttb.Rows(r)("Total_count").ToString)
                    total_sum = Val(ttb.Rows(r)("Total_sum").ToString)
                    average = total_sum / total_count

                    Dim fm As String = ""
                    'for males
                    For w As Integer = 0 To tb2.Rows.Count - 1
                        If tb2.Rows(w)("Subject").ToString = ttb.Rows(r)("Subject").ToString Then
                            Dim fmm As Double = Val(tb2.Rows(w)("Total_sum").ToString) / tb2.Rows(w)("Total_count").ToString
                            ma = Math.Round(fmm, 2)
                        End If
                    Next
                    'for females
                    For j As Integer = 0 To tb3.Rows.Count - 1
                        If tb3.Rows(j)("Subject").ToString = ttb.Rows(r)("Subject").ToString Then
                            Dim fmm As Double = Val(tb3.Rows(j)("Total_sum").ToString) / tb3.Rows(j)("Total_count").ToString
                            mf = Math.Round(fmm, 2)
                        End If
                    Next
                    Dim rc As Integer = record_count("select * from exams_analysis where sid='" & sid & "' and academic= '" & ta.Rows(0)("academic").ToString & "' and term='" & ta.Rows(0)("term").ToString & "' and subject = '" & ttb.Rows(r)("Subject").ToString & "'")
                    If rc > 0 Then
                        execute("UPDATE `exams_analysis` SET `marks_count`='" & total_count & "',`total_marks`='" & total_marks & "',`obtained_marks`='" & total_sum & "',`average`='" & Math.Round(average, 2) & "',`average_males`='" & ma & "',`average_females`='" & mf & "' WHERE sid='" & ta.Rows(0)("term").ToString & "' and academic= '" & ta.Rows(0)("academic").ToString & "' and term='" & ta.Rows(0)("term").ToString & "' and  subject = '" & ttb.Rows(r)("Subject").ToString & "'", 3)
                    Else
                        execute("INSERT INTO `exams_analysis`(`marks_count`, `total_marks`, `obtained_marks`, `average`, `average_males`, `average_females`, `subject`, `academic`, `term`, `sid`) VALUES ('" & total_count & "','" & total_marks & "','" & total_sum & "','" & Math.Round(average, 2) & "','" & ma & "','" & mf & "','" & ttb.Rows(r)("Subject").ToString & "','" & ta.Rows(0)("academic").ToString & "','" & ta.Rows(0)("term").ToString & "','" & sid & "')", 3)
                    End If
                Next
            End If

            'exams analysis of this academic year 
            ttb = New DataTable
                ta = New DataTable
            ta = ShowData("select academic,term from academic_year where  status = '1' and  sid = '" & sid & "'")
            If ta.Rows.Count > 0 Then
                ttb = ShowData("select count(`Student_ID`) as 'Total_count', SUM(`Total`) as 'Total_sum',Subject as 'Subject' from marks where  sid ='" & sid & "' and Academic = '" & ta.Rows(0)("academic").ToString & "' and term='" & ta.Rows(0)("term").ToString & "' GROUP by Subject")
                Dim total_count, total_sum, average As Double
                tb3 = New DataTable
                tb2 = New DataTable
                tb2 = ShowData("select count(`Student_ID`) as 'Total_count', SUM(`Total`) as 'Total_sum',Subject as 'Subject' from marks where Student_ID != all (select student_id from student where gender='Female' and sid= '" & sid & "') and sid ='" & sid & "' and Academic = '" & ta.Rows(0)("academic").ToString & "' and term='" & ta.Rows(0)("term").ToString & "' GROUP by Subject")
                tb3 = ShowData("select count(`Student_ID`) as 'Total_count', SUM(`Total`) as 'Total_sum',Subject as 'Subject' from marks where Student_ID= any(select student_id from student where gender='Female' and sid='" & sid & "')  and sid ='" & sid & "' and Academic = '" & ta.Rows(0)("academic").ToString & "' and term='" & ta.Rows(0)("term").ToString & "' GROUP by Subject")
                Dim total_marks As Integer
                Dim ma, mf As Double
                For r As Integer = 0 To ttb.Rows.Count - 1
                    'calculations
                    total_marks = Val(ttb.Rows(r)("Total_count").ToString) * 100
                    total_count = Val(ttb.Rows(r)("Total_count").ToString)
                    total_sum = Val(ttb.Rows(r)("Total_sum").ToString)
                    average = total_sum / total_count

                    Dim fm As String = ""
                    'for males
                    For w As Integer = 0 To tb2.Rows.Count - 1
                        If tb2.Rows(w)("Subject").ToString = ttb.Rows(r)("Subject").ToString Then
                            Dim fmm As Double = Val(tb2.Rows(w)("Total_sum").ToString) / tb2.Rows(w)("Total_count").ToString
                            ma = Math.Round(fmm, 2)
                        End If
                    Next
                    'for females
                    For j As Integer = 0 To tb3.Rows.Count - 1
                        If tb3.Rows(j)("Subject").ToString = ttb.Rows(r)("Subject").ToString Then
                            Dim fmm As Double = Val(tb3.Rows(j)("Total_sum").ToString) / tb3.Rows(j)("Total_count").ToString
                            mf = Math.Round(fmm, 2)
                        End If
                    Next
                    Dim rc As Integer = record_count("select * from exams_analysis where sid='" & sid & "' and academic= '" & ta.Rows(0)("academic").ToString & "' and term='" & ta.Rows(0)("term").ToString & "' and subject = '" & ttb.Rows(r)("Subject").ToString & "'")
                    If rc > 0 Then
                        execute("UPDATE `exams_analysis` SET `marks_count`='" & total_count & "',`total_marks`='" & total_marks & "',`obtained_marks`='" & total_sum & "',`average`='" & Math.Round(average, 2) & "',`average_males`='" & ma & "',`average_females`='" & mf & "' WHERE sid='" & ta.Rows(0)("term").ToString & "' and academic= '" & ta.Rows(0)("academic").ToString & "' and term='" & ta.Rows(0)("term").ToString & "' and  subject = '" & ttb.Rows(r)("Subject").ToString & "'", 3)
                    Else
                        execute("INSERT INTO `exams_analysis`(`marks_count`, `total_marks`, `obtained_marks`, `average`, `average_males`, `average_females`, `subject`, `academic`, `term`, `sid`) VALUES ('" & total_count & "','" & total_marks & "','" & total_sum & "','" & Math.Round(average, 2) & "','" & ma & "','" & mf & "','" & ttb.Rows(r)("Subject").ToString & "','" & ta.Rows(0)("academic").ToString & "','" & ta.Rows(0)("term").ToString & "','" & sid & "')", 3)
                    End If
                Next
                Me.Cursor = Cursors.Default
            End If
            analysis_bindgrid()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            showerror(ex.Message)
        End Try
    End Sub
    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If txtaacademic.Text = "" Or txtaterm.Text = "" Or txtasub.Text = "" Then
                Me.Cursor = Cursors.Default
                showerror("Please select the required information!")
                Exit Sub
            ElseIf txtasub.Text = "All" Then
                anagrid.DataSource = ShowData("SELECT  `marks_count` as Student_Count, `total_marks` as Total_Marks, `obtained_marks` as Obtained_Marks, `average` as Average, `average_males` as Average_of_Males, `average_females` as Average_of_Females, `subject` as Subject, `academic` as Academic, `term` as Term FROM `exams_analysis` WHERE term= '" & txtaterm.Text & "' and sid = '" & sid & "' and academic= '" & txtaacademic.Text & "'")
            Else
                anagrid.DataSource = ShowData("SELECT  `marks_count` as Student_Count, `total_marks` as Total_Marks, `obtained_marks` as Obtained_Marks, `average` as Average, `average_males` as Average_of_Males, `average_females` as Average_of_Females, `subject` as Subject, `academic` as Academic, `term` as Term FROM `exams_analysis` WHERE term= '" & txtaterm.Text & "' and sid = '" & sid & "' and academic= '" & txtaacademic.Text & "' and subject ='" & txtasub.Text & "'")
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            showerror(ex.Message)
        End Try
    End Sub
    Private Sub cmdaddr_Click(sender As Object, e As EventArgs) Handles cmdaddr.Click
        addremark.ShowDialog()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tb2 = New DataTable
        tb3 = New DataTable
        tb = New DataTable
        tb4 = New DataTable
        tb5 = New DataTable
        tb6 = New DataTable
        Dim pm As String
        Dim dg As String = ""
        Dim avg As Double
        If txtracademic.Text = "" Or txtrname.Text = "" Or txtrclass.Text = "" Or txtrterm.Text = "" Then
            showerror("Please select the required information!")
            Exit Sub
        Else
            Me.Cursor = Cursors.WaitCursor
            tb = ShowData("SELECT  `Subject`, `Class_Score`, `Exams_Score`, `Total`,`Position`,`Grading`,`Remark`as Remarks  FROM `marks` where Name='" & txtrname.Text & "' and Academic  ='" & txtracademic.Text & "' and Class='" & txtrclass.Text & "' and Term='" & txtrterm.Text & "' and sid = '" & sid & "' order by Subject ASC")
            If tb.Rows.Count > 3 Then
                Dim report As CrystalDecisions.CrystalReports.Engine.ReportDocument
                report = New report
                Dim Fmreport As New ReportHolder
                report.SetDataSource(tb)
                Fmreport.CrystalReportViewer1.ReportSource = report

                Dim classno As Integer = record_count("select * from marks where sid='" & sid & "' and Academic='" & txtracademic.Text & "' and Term = '" & txtrterm.Text & "' and Class='" & txtrclass.Text & "' group by Student_ID")
                tb2 = ShowData("select * from academic_year where academic ='" & txtracademic.Text & "' and term ='" & txtrterm.Text & "' and sid = '" & sid & "'")
                tb3 = ShowData("select * from grade where Student_Name= '" & txtrname.Text & "' and Academic='" & txtracademic.Text & "' and Term='" & txtrterm.Text & "' and sid = '" & sid & "' and Class='" & txtrclass.Text & "'")
                tb5 = ShowData("select * from grading where sid='" & sid & "' order by lower_limit DESC")
                tb6 = ShowData("select * from school_profile where sid='" & sid & "'")
                Dim logopath, signpath As String
                logopath = Application.StartupPath & "Images\School Profile\" & tb6.Rows(0)("logo").ToString
                signpath = Application.StartupPath & "Images\School Profile\" & tb6.Rows(0)("sign_head").ToString
                For i As Integer = 0 To tb5.Rows.Count - 1 Step 1
                    dg = dg & tb5.Rows(i)("lower_limit").ToString & "%-" & tb5.Rows(i)("upper_limit").ToString & "%     " & tb5.Rows(i)("letter_grade").ToString & "    " & tb5.Rows(i)("remark").ToString & "               "
                Next
                If term = 3 Then
                    tb4 = ShowData("select * from student where student_id = '" & tb3.Rows(0)("Student_ID").ToString & "' and sid = '" & sid & "'")
                    If tb4.Rows(0)("class").ToString = tb4.Rows(0)("previous_class").ToString Then
                        pm = "REPEATED TO: " & tb4.Rows(0)("class").ToString
                    Else
                        pm = "PROMOTED TO: " & tb4.Rows(0)("class").ToString
                    End If
                Else
                    pm = "PROMOTED TO: "
                End If
                Dim ndate As Date = tb2.Rows(0)("next_term").ToString
                avg = Val(tb3.Rows(0)("Overall_Marks").ToString / tb3.Rows(0)("Overall_Position").ToString)
                report.SetParameterValue("school_name", tb6.Rows(0)("name").ToString)
                report.SetParameterValue("location", tb6.Rows(0)("town").ToString)
                report.SetParameterValue("contact", tb6.Rows(0)("phone").ToString)
                report.SetParameterValue("student_name", txtrname.Text)
                report.SetParameterValue("class", txtrclass.Text)
                report.SetParameterValue("term", txtrterm.Text)
                report.SetParameterValue("student_no", tb3.Rows(0)("Student_ID").ToString)
                report.SetParameterValue("average", avg)
                report.SetParameterValue("promoted", pm)
                report.SetParameterValue("school_logo", logopath)
                report.SetParameterValue("sign", signpath)
                report.SetParameterValue("academic", txtracademic.Text)
                report.SetParameterValue("nterm", ndate.ToString("D"))
                report.SetParameterValue("class_no", classno)
                report.SetParameterValue("position", tb3.Rows(0)("Overall_Position").ToString)
                report.SetParameterValue("dgrade", dg)
                report.SetParameterValue("attitude", tb3.Rows(0)("Remark").ToString)
                report.SetParameterValue("attendance", tb3.Rows(0)("Attendance").ToString)
                report.SetParameterValue("tattendance", tb2.Rows(0)("days").ToString)
                Fmreport.ShowDialog()
            End If
                Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub spprint_Click(sender As Object, e As EventArgs) Handles spprint.Click
        Try
            If txtspterm.Text = "" Or txtspacademic.Text = "" Or txtspsubject.Text = "" Then
                showerror("Please select the required information!")
                Exit Sub
            Else
                Me.Cursor = Cursors.WaitCursor
                Dim head As String
                Dim prf As New DataTable

                prf = ShowData("SELECT `Student_ID`, `Name`, `Class_Score`, `Exams_Score`, `Total`, `Remark`,`d_grade` as GP_ID FROM `marks` where Subject='" & txtspsubject.Text & "' and Academic  ='" & txtspacademic.Text & "' and Class='" & txtspclass.Text & "' and Term='" & txtspterm.Text & "' and sid = '" & sid & "' order by Total DESC")
                head = UCase(txtspclass.Text & " Subject position of " & txtspsubject.Text & " in " & txtspacademic.Text & ", term  " & txtspterm.Text)
                If prf.Rows.Count > 0 Then
                    report = New sPosition
                    report.SetDataSource(prf)
                    report.SetParameterValue("sname", school_name)
                    report.SetParameterValue("head", head)
                    Dim fmreport As New ReportHolder
                    fmreport.CrystalReportViewer1.ReportSource = report
                    fmreport.ShowDialog()
                Else
                    showinfo("No record was found!")
                End If
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If txtaterm.Text = "" Or txtaacademic.Text = "" Or txtasub.Text = "" Then
                showerror("Please select the required information!")
                Exit Sub
            Else
                Me.Cursor = Cursors.WaitCursor
                Dim head As String
                Dim prf As New DataTable
                If txtasub.Text = "All" Then
                    prf = ShowData("SELECT `subject` as Subject, `marks_count` as Student_Count, `total_marks` as Total_Marks, `obtained_marks` as Obtained_Marks, `average` as Average, `average_males` as Males_Average, `average_females` as Females_Average FROM `exams_analysis` WHERE term= '" & txtaterm.Text & "' and sid = '" & sid & "' and academic= '" & txtaacademic.Text & "'")
                    head = UCase("exams analysis of " & txtaacademic.Text & ", term " & txtaterm.Text)
                Else
                    head = UCase("exams analysis of " & txtaacademic.Text & ", term " & txtaterm.Text)
                    prf = ShowData("SELECT `subject` as Subject, `marks_count` as Student_Count, `total_marks` as Total_Marks, `obtained_marks` as Obtained_Marks, `average` as Average, `average_males` as Males_Average, `average_females` as Females_Average FROM `exams_analysis` WHERE term= '" & txtaterm.Text & "' and sid = '" & sid & "' and academic= '" & txtaacademic.Text & "' and subject ='" & txtasub.Text & "'")
                End If
                If prf.Rows.Count > 0 Then
                    report = New analysis
                    report.SetDataSource(prf)
                    report.SetParameterValue("sname", school_name)
                    report.SetParameterValue("head", head)
                    Dim fmreport As New ReportHolder
                    fmreport.CrystalReportViewer1.ReportSource = report
                    fmreport.ShowDialog()
                Else
                    showinfo("No record was found!")
                End If
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            showerror(ex.Message)
        End Try
    End Sub
End Class