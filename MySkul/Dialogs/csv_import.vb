Imports System.Data.OleDb
Imports System.IO
Imports System.Text
Public Class csv_import
    Dim Tot_rows As Integer
    Dim PROgres_count As Integer
    Dim conn As OleDbConnection
    Dim dta As OleDbDataAdapter
    Dim ts As DataSet
    Dim excel As String
    Private Sub releaseobject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Dim tb1 As New DataTable("Table")
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
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
                                Me.DataGridView1.Rows.Add(currentRow)
                                tb1.Rows.Add(currentRow)
                            End If
                        Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                            showerror("Line " & ex.Message & " is invalid.  Skipping")
                        End Try
                        Application.DoEvents()
                    End While
                End Using
                import.DataSource = tb1
                If import.Rows.Count > 0 Then
                    RadButton2.Enabled = True
                Else
                    RadButton2.Enabled = False
                End If
            End If
            Me.Cursor = Cursors.Default

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
            '    import.DataSource = ts
            '    import.DataMember = "[Sheet1$]"
            '    RadButton2.Enabled = True
            '    conn.Close()
            'End If
            'For i As Integer = 0 To Me.import.ColumnCount - 1
            '    Me.import.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
            '    Me.import.Columns(i).Width = 150
            'Next
            '' reader.Close()
            'Lcount.Text = import.Rows.Count & " Records"
            'Lcount.Visible = True
            'Me.Cursor = Cursors.Default
            '' End If
            'If DataGridView1.Rows.Count > 0 Then
            '    RadButton2.Enabled = True
            'Else
            '    RadButton2.Enabled = False
            'End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub RadButton6_Click(sender As Object, e As EventArgs) Handles RadButton6.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim name As String = "CSV Format"
            Dim csvfile As String = String.Empty
            For Each column As DataGridViewColumn In DataGridView1.Columns
                csvfile = csvfile & column.HeaderText & ","
            Next
            csvfile = csvfile.TrimEnd(",")
            csvfile = csvfile & vbCr & vbLf
            For Each row As DataGridViewRow In DataGridView1.Rows
                For Each cell As DataGridViewCell In row.Cells
                    csvfile = csvfile & cell.FormattedValue.replace(",", "") & ","
                Next
                csvfile = csvfile.TrimEnd(",")
                csvfile = csvfile & vbCr & vbLf
            Next
            Dim loc As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            My.Computer.FileSystem.WriteAllText(loc & "\" & name & ".csv", csvfile, False)
            Me.Cursor = Cursors.Default
            showinfo("Data format has been expoted to document")
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            showerror(ex.Message)
        End Try

        'Me.Cursor = Cursors.WaitCursor
        'ProgressBar1.Visible = True
        'Try
        '    SaveFileDialog1.Filter = "Excel Document (*.xlsx) |*.xlsx"
        '    If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        '        Dim xlworkbook As Microsoft.Office.Interop.Excel.Workbook
        '        Dim xlworksheet As Microsoft.Office.Interop.Excel.Worksheet
        '        Dim misvalue As Object = System.Reflection.Missing.Value
        '        Dim i, j As Integer
        '        xlApp = New Microsoft.Office.Interop.Excel.Application
        '        xlworkbook = xlApp.Workbooks.Add(misvalue)
        '        xlworksheet = xlworkbook.Sheets("Sheet1")
        '        For i = 0 To DataGridView1.Rows.Count - 2
        '            For j = 0 To DataGridView1.ColumnCount - 1
        '                For k As Integer = 1 To DataGridView1.ColumnCount
        '                    xlworksheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
        '                    xlworksheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString
        '                Next
        '            Next
        '            PROgres_count = CInt((i / Tot_rows) * 100)
        '            ProgressBar1.Value = PROgres_count
        '        Next
        '        ProgressBar1.Value = 100
        '        ProgressBar1.Visible = False
        '        xlworksheet.SaveAs(SaveFileDialog1.FileName)
        '        xlworkbook.Close()
        '        xlApp.Quit()
        '        releaseobject(xlApp)
        '        releaseobject(xlworkbook)
        '        releaseobject(xlworksheet)
        '        Me.Cursor = Cursors.Default
        '        showinfo("Records have been saved into an excel file")
        '    End If
        '    Me.Cursor = Cursors.Default
        'Catch ex As Exception
        '    Me.Cursor = Cursors.Default
        '    showerror(ex.Message)
        'End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub csv_import_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
        tb1.Columns.Add("Student_id")
        tb1.Columns.Add("First_Name")
        tb1.Columns.Add("Middle_Name")
        tb1.Columns.Add("Last_Name")
        tb1.Columns.Add("Date_Of_birth")
        tb1.Columns.Add("Gender")
        tb1.Columns.Add("Father_Name")
        tb1.Columns.Add("Mother_Name")
        tb1.Columns.Add("Father_Contact")
        tb1.Columns.Add("Mother_Contact")
        tb1.Columns.Add("Address")
        tb1.Columns.Add("Class")
        tb1.Columns.Add("Status")
        tb1.Columns.Add("Academic")
        tb1.Columns.Add("Term")
        Me.import.AllowAutoSizeColumns = False
        Me.import.BestFitColumns()
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        Try
            Dim fullname As String
            Dim dob As Date

            Me.Cursor = Cursors.WaitCursor
            Dim all As Integer = 0
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                fullname = UCase(DataGridView1.Rows(i).Cells(3).Value.ToString.Trim) & "," & Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(DataGridView1.Rows(i).Cells(1).Value.ToString.Trim) & " " & Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(DataGridView1.Rows(i).Cells(2).Value.ToString.Trim)
                dob = DataGridView1.Rows(i).Cells(4).Value
                Dim c As Integer = record_count("select * from student where student_id ='" & DataGridView1.Rows(i).Cells(0).Value.ToString.Trim & "' and sid ='" & sid & "'")
                If c > 0 Then
                    If all = 0 Then
                        imdialog.Label1.Text = "Student with student ID : " & DataGridView1.Rows(i).Cells(0).Value.ToString.Trim & " already exist in the database. Do you want to update it "
                        imdialog.ShowDialog()
                        If imdialog.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                            execute("UPDATE `student` SET `fullname`='" & fullname & "',`dob`='" & dob.ToString("yyyy-M-dd") & "',`gender`='" & DataGridView1.Rows(i).Cells(5).Value.ToString.Trim & "',`father_name`='" & DataGridView1.Rows(i).Cells(6).Value.ToString.Trim & "',`mother_name`='" & DataGridView1.Rows(i).Cells(7).Value.ToString.Trim & "',`father_contact`='" & DataGridView1.Rows(i).Cells(8).Value.ToString.Trim & "',`mother_contact`='" & DataGridView1.Rows(i).Cells(9).Value.ToString.Trim & "',`address`='" & DataGridView1.Rows(i).Cells(10).Value.ToString.Trim & "',`class`='" & DataGridView1.Rows(i).Cells(11).Value.ToString.Trim & "',`status`='" & DataGridView1.Rows(i).Cells(12).Value.ToString.Trim & "',`academic`='" & DataGridView1.Rows(i).Cells(13).Value.ToString.Trim & "',`term`='" & DataGridView1.Rows(i).Cells(14).Value.ToString.Trim & "' WHERE student_id ='" & DataGridView1.Rows(i).Cells(0).Value.ToString.Trim & "' and sid = '" & sid & "'", 3)
                            If Not DataGridView1.Rows(i).Cells(7).Value.ToString.Trim = "" And Not DataGridView1.Rows(i).Cells(9).Value.ToString.Trim = "" Then
                                execute("UPDATE  `parents_account` set `parent`='" & DataGridView1.Rows(i).Cells(7).Value.ToString.Trim & "', `password`='" & DataGridView1.Rows(i).Cells(9).Value.ToString.Trim & "' where sid ='" & sid & "' and `student_id`='" & DataGridView1.Rows(i).Cells(0).Value.ToString.Trim & "' ", 3)
                            End If
                            If Not DataGridView1.Rows(i).Cells(6).Value.ToString.Trim = "" And Not DataGridView1.Rows(i).Cells(8).Value.ToString.Trim = "" Then
                                execute("UPDATE  `parents_account` set  `parent`='" & DataGridView1.Rows(i).Cells(6).Value.ToString.Trim & "', `password`='" & DataGridView1.Rows(i).Cells(8).Value.ToString.Trim & "' where sid ='" & sid & "' and `student_id`='" & DataGridView1.Rows(i).Cells(0).Value.ToString.Trim & "' ", 3)
                            End If
                        ElseIf imdialog.DialogResult = System.Windows.Forms.DialogResult.Retry Then
                            all = 1
                            execute("UPDATE `student` SET `fullname`='" & fullname & "',`dob`='" & dob.ToString("yyyy-M-dd") & "',`gender`='" & DataGridView1.Rows(i).Cells(5).Value.ToString.Trim & "',`father_name`='" & DataGridView1.Rows(i).Cells(6).Value.ToString.Trim & "',`mother_name`='" & DataGridView1.Rows(i).Cells(7).Value.ToString.Trim & "',`father_contact`='" & DataGridView1.Rows(i).Cells(8).Value.ToString.Trim & "',`mother_contact`='" & DataGridView1.Rows(i).Cells(9).Value.ToString.Trim & "',`address`='" & DataGridView1.Rows(i).Cells(10).Value.ToString.Trim & "',`class`='" & DataGridView1.Rows(i).Cells(11).Value.ToString.Trim & "',`status`='" & DataGridView1.Rows(i).Cells(12).Value.ToString.Trim & "',`academic`='" & DataGridView1.Rows(i).Cells(13).Value.ToString.Trim & "',`term`='" & DataGridView1.Rows(i).Cells(14).Value.ToString.Trim & "' WHERE student_id ='" & DataGridView1.Rows(i).Cells(0).Value.ToString.Trim & "' and sid = '" & sid & "'", 3)
                            If Not DataGridView1.Rows(i).Cells(6).Value.ToString.Trim = "" And Not DataGridView1.Rows(i).Cells(8).Value.ToString.Trim = "" Then
                                execute("UPDATE  `parents_account` set  `parent`='" & DataGridView1.Rows(i).Cells(6).Value.ToString.Trim & "', `password`='" & DataGridView1.Rows(i).Cells(8).Value.ToString.Trim & "' where sid ='" & sid & "' and `student_id`='" & DataGridView1.Rows(i).Cells(0).Value.ToString.Trim & "' ", 3)
                            End If
                            If Not DataGridView1.Rows(i).Cells(7).Value.ToString.Trim = "" And Not DataGridView1.Rows(i).Cells(9).Value.ToString.Trim = "" Then
                                execute("UPDATE  `parents_account` set  `parent`='" & DataGridView1.Rows(i).Cells(7).Value.ToString.Trim & "', `password`='" & DataGridView1.Rows(i).Cells(9).Value.ToString.Trim & "' where sid ='" & sid & "' and `student_id`='" & DataGridView1.Rows(i).Cells(0).Value.ToString.Trim & "' ", 3)
                            End If
                        End If
                    Else
                        execute("UPDATE `student` SET `fullname`='" & fullname & "',`dob`='" & dob.ToString("yyyy-M-dd") & "',`gender`='" & DataGridView1.Rows(i).Cells(5).Value.ToString.Trim & "',`father_name`='" & DataGridView1.Rows(i).Cells(6).Value.ToString.Trim & "',`mother_name`='" & DataGridView1.Rows(i).Cells(7).Value.ToString.Trim & "',`father_contact`='" & DataGridView1.Rows(i).Cells(8).Value.ToString.Trim & "',`mother_contact`='" & DataGridView1.Rows(i).Cells(9).Value.ToString.Trim & "',`address`='" & DataGridView1.Rows(i).Cells(10).Value.ToString.Trim & "',`class`='" & DataGridView1.Rows(i).Cells(11).Value.ToString.Trim & "',`status`='" & DataGridView1.Rows(i).Cells(12).Value.ToString.Trim & "',`academic`='" & DataGridView1.Rows(i).Cells(13).Value.ToString.Trim & "',`term`='" & DataGridView1.Rows(i).Cells(14).Value.ToString.Trim & "' WHERE student_id ='" & DataGridView1.Rows(i).Cells(0).Value.ToString.Trim & "' and sid = '" & sid & "'", 3)
                        If Not DataGridView1.Rows(i).Cells(6).Value.ToString.Trim = "" And Not DataGridView1.Rows(i).Cells(8).Value.ToString.Trim = "" Then
                            execute("UPDATE  `parents_account` set  `parent`='" & DataGridView1.Rows(i).Cells(6).Value.ToString.Trim & "', `password`='" & DataGridView1.Rows(i).Cells(8).Value.ToString.Trim & "' where sid ='" & sid & "' and `student_id`='" & DataGridView1.Rows(i).Cells(0).Value.ToString.Trim & "' ", 3)
                        End If
                        If Not DataGridView1.Rows(i).Cells(4).Value.ToString.Trim = "" And Not DataGridView1.Rows(i).Cells(4).Value.ToString.Trim = "" Then
                            execute("UPDATE  `parents_account` set  `parent`='" & DataGridView1.Rows(i).Cells(7).Value.ToString.Trim & "', `password`='" & DataGridView1.Rows(i).Cells(9).Value.ToString.Trim & "' where sid ='" & sid & "' and `student_id`='" & DataGridView1.Rows(i).Cells(0).Value.ToString.Trim & "' ", 3)
                        End If
                    End If
                Else
                    execute("insert into student(student_id,fullname,dob,gender,father_name,mother_name,father_contact,mother_contact,address,class,status,academic,term,sid,admission_date) values ('" & DataGridView1.Rows(i).Cells(0).Value.ToString.Trim & "','" & fullname & "','" & dob.ToString("yyyy-M-dd") & "','" & DataGridView1.Rows(i).Cells(5).Value.ToString.Trim & "','" & DataGridView1.Rows(i).Cells(6).Value.ToString.Trim & "','" & DataGridView1.Rows(i).Cells(7).Value.ToString.Trim & "','" & DataGridView1.Rows(i).Cells(8).Value.ToString.Trim & "','" & DataGridView1.Rows(i).Cells(9).Value.ToString.Trim & "','" & DataGridView1.Rows(i).Cells(10).Value.ToString.Trim & "','" & DataGridView1.Rows(i).Cells(11).Value.ToString.Trim & "','" & DataGridView1.Rows(i).Cells(12).Value.ToString.Trim & "','" & DataGridView1.Rows(i).Cells(13).Value.ToString.Trim & "','" & DataGridView1.Rows(i).Cells(14).Value.ToString.Trim & "','" & sid & "','" & Now.Date.ToString("yyyy-M-dd") & "')", 3)
                    If Not DataGridView1.Rows(i).Cells(6).Value.ToString.Trim = "" And Not DataGridView1.Rows(i).Cells(8).Value.ToString.Trim = "" Then
                        execute("INSERT INTO `parents_account`(`student_id`, `parent`, `password`,`sid`) VALUES ('" & DataGridView1.Rows(i).Cells(0).Value.ToString.Trim & "','" & DataGridView1.Rows(i).Cells(6).Value.ToString.Trim & "','" & DataGridView1.Rows(i).Cells(8).Value.ToString.Trim & "','" & sid & "')", 3)
                    End If
                    If Not DataGridView1.Rows(i).Cells(7).Value.ToString.Trim = "" And Not DataGridView1.Rows(i).Cells(9).Value.ToString.Trim = "" Then
                        execute("INSERT INTO `parents_account`(`student_id`, `parent`, `password`,`sid`) VALUES ('" & DataGridView1.Rows(i).Cells(0).Value.ToString.Trim & "','" & DataGridView1.Rows(i).Cells(7).Value.ToString.Trim & "','" & DataGridView1.Rows(i).Cells(9).Value.ToString.Trim & "','" & sid & "')", 3)
                    End If
                End If
            Next
            showinfo("All records were saved successfully")
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            showerror(ex.Message)
        End Try
        Lcount.Visible = False
    End Sub
End Class
