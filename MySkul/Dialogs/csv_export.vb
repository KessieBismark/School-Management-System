Imports System.IO
Public Class csv_export
    Dim Tot_rows As Integer
    Dim PROgres_count As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub RadDropDownList1_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles txtclass.SelectedIndexChanged
        Try
            Me.Cursor = Cursors.WaitCursor
            txtsubclass.Items.Clear()

            Dim tb As New DataTable
            tb = ShowData("select s_class from subclass where class = '" + txtclass.Text + "' and sid= '" & sid & "'")
            For i As Integer = 0 To tb.Rows.Count - 1
                txtsubclass.Items.Add(tb.Rows(i)(0).ToString)
            Next
            txtsubclass.Items.Add("All")
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub txtclass_TextChanged(sender As Object, e As EventArgs) Handles txtclass.TextChanged
        Try
            Me.Cursor = Cursors.WaitCursor
            txtsubclass.Items.Clear()
            If txtclass.Text = "All" Then
                txtsubclass.Text = ""
                txtsubclass.Enabled = False
            Else
                txtsubclass.Enabled = True
                Dim tb As New DataTable
                tb = ShowData("select s_class from subclass where class = '" + txtclass.Text + "' and sid ='" & sid & "'")
                For i As Integer = 0 To tb.Rows.Count - 1
                    txtsubclass.Items.Add(tb.Rows(i)(0).ToString)
                Next
                txtsubclass.Items.Add("All")
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub csv_export_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = AppName
        Try
            txtclass.DataSource = New BindingSource(ShowData("select * from class where sid ='" & sid & "'"), Nothing)
            txtclass.DisplayMember = "class_no"
            txtclass.Items.Add("All")

            txtacademic.DataSource = New BindingSource(ShowData("select * from academic_year where sid ='" & sid & "' group by academic  order by academic DESC"), Nothing)
            txtacademic.DisplayMember = "academic"
            txtacademic.Items.Add("All")
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub
    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Try
            If txtacademic.Text = "" Or txtterm.Text = "" Or txtclass.Text = "" Then
                showerror("Please provide all the required information!")
                Exit Sub
            Else
                Dim clause As String = ""
                Dim where_clause As String = ""
                If txtclass.Text = "All" Then
                    If Not txtacademic.Text = "All" Then
                        clause = clause & "academic='" & txtacademic.Text & "'-"
                    End If
                    If Not txtterm.Text = "All" Then
                        clause = clause & "term='" & txtterm.Text & "'-"
                    End If
                Else
                    If txtsubclass.Text = "" Then
                        showerror("Please provide all the required information!")
                        Exit Sub
                    Else
                        If Not txtacademic.Text = "All" Then
                            clause = clause & "academic='" & txtacademic.Text & "'-"
                        End If
                        If Not txtterm.Text = "All" Then
                            clause = clause & "term='" & txtterm.Text & "'-"
                        End If
                        If Not txtsubclass.Text = "All" Then
                            clause = clause & "class='" & txtsubclass.Text & "'-"
                        Else
                            clause = clause & "CONCAT(class,fullname) like '%" & txtclass.Text & "%'-"
                        End If
                    End If
                End If
                If clause = "" Then
                Else
                    Dim trimmed_clause As String = clause.TrimEnd("-")
                    Dim final_clause As String = ""
                    Dim an As Integer = 0
                    If trimmed_clause.Contains("-") Then
                        Dim split_clause As String() = trimmed_clause.Split("-")
                        an = split_clause.Length - 2
                        Dim cc As Integer = 0
                        For i As Integer = 0 To split_clause.Length - 1
                            If cc <= an Then
                                final_clause = final_clause & split_clause(i) & " and "
                            Else
                                final_clause = final_clause & split_clause(i)
                            End If
                            cc = cc + 1
                        Next
                    Else
                        final_clause = trimmed_clause
                    End If
                    where_clause = "and " & final_clause & "order by Class"
                End If
                DataGridView1.DataSource = ShowData("select student_id as Student_ID, fullname as Fullname,gender as Gender,admission_date as Admission_Date,dob as Date_Of_Birth,father_name as Father,mother_name as Mother,father_contact as Father_Contact,mother_contact as Mother_Contact,address as Address,class as Class,nationality as Nationality,disability as Disability,religion as Religion,status as Status,academic as Academic,term as Term from student where sid ='" & sid & "' " & where_clause)
                exportgrid.DataSource = ShowData("Select  student_id As Student_ID, fullname As Fullname, gender As Gender, admission_date As Admission_Date, dob As Date_Of_Birth, father_name As Father, mother_name As Mother, father_contact As Father_Contact, mother_contact As Mother_Contact, address As Address,class as Class, nationality As Nationality, disability As Disability, religion As Religion, status As Status, academic As Academic, term As Term  from student where sid ='" & sid & "' " & where_clause)
                Me.exportgrid.AllowAutoSizeColumns = False
                Me.exportgrid.BestFitColumns()
                Me.exportgrid.Columns("Student_ID").Width = 150
                Me.exportgrid.Columns("Fullname").Width = 400
                Me.exportgrid.Columns("Gender").Width = 120
                Me.exportgrid.Columns("Admission_date").Width = 200
                Me.exportgrid.Columns("Date_Of_Birth").Width = 200
                Me.exportgrid.Columns("Father").Width = 350
                Me.exportgrid.Columns("Mother").Width = 350
                Me.exportgrid.Columns("Father_Contact").Width = 200
                Me.exportgrid.Columns("Mother_Contact").Width = 200
                Me.exportgrid.Columns("Address").Width = 400
                Me.exportgrid.Columns("Class").Width = 120
                Me.exportgrid.Columns("Nationality").Width = 150
                Me.exportgrid.Columns("Disability").Width = 150
                Me.exportgrid.Columns("Religion").Width = 150
                Me.exportgrid.Columns("Status").Width = 150
                Me.exportgrid.Columns("Academic").Width = 150
                Me.exportgrid.Columns("Term").Width = 100
                For i As Integer = 0 To Me.exportgrid.ColumnCount - 1
                    Me.exportgrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
                Next
                If DataGridView1.Rows.Count > 0 Then
                    cmdexport.Enabled = True
                End If
            End If
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub cmdexport_Click(sender As Object, e As EventArgs) Handles cmdexport.Click
        'Try
        '    Me.Cursor = Cursors.WaitCursor
        '    Dim name As String = "Students Record-" & Now.Date.Day & "-" & Now.Date.Month & "-" & Now.Date.Year
        '    Dim csvfile As String = String.Empty
        '    For Each column As DataGridViewColumn In DataGridView1.Columns
        '        csvfile = csvfile & column.HeaderText & ", "
        '    Next
        '    csvfile = csvfile.TrimEnd(", ")
        '    csvfile = csvfile & vbCr & vbLf
        '    For Each row As DataGridViewRow In DataGridView1.Rows
        '        For Each cell As DataGridViewCell In row.Cells
        '            csvfile = csvfile & cell.Value.ToString & ","
        '        Next
        '        csvfile = csvfile.TrimEnd(""",""")
        '        csvfile = csvfile & vbCr & vbLf
        '    Next
        '    Dim loc As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        '    My.Computer.FileSystem.WriteAllText(loc & " \ " & name & ".csv", csvfile, False)
        '    Me.Cursor = Cursors.Default
        '    showinfo("All information has been exported Successfully to 'Documents' with name: " & name)
        'Catch ex As Exception
        '    Me.Cursor = Cursors.Default
        '    showerror(ex.Message)
        'End Try
        Try
            Dim csvfile As String = String.Empty
            Me.Cursor = Cursors.WaitCursor
            Dim name As String = "Students Record-" & Now.Date.Day & "-" & Now.Date.Month & "-" & Now.Date.Year
            Dim loc As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            My.Computer.FileSystem.WriteAllText(loc & "\" & name & ".csv", csvfile, False)

            Dim headers = (From header As DataGridViewColumn In DataGridView1.Columns.Cast(Of DataGridViewColumn)()
                           Select header.HeaderText).ToArray
            Dim rows = From row As DataGridViewRow In DataGridView1.Rows.Cast(Of DataGridViewRow)()
                       Where Not row.IsNewRow
                       Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, """"))

            Using sw As New IO.StreamWriter(loc & "\" & name & ".csv")
                sw.WriteLine(String.Join(",", headers))
                For Each r In rows
                    sw.WriteLine("""" & String.Join(""",""", r) & """")
                Next
            End Using
            Process.Start(loc & "\" & name & ".csv")
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            showerror(ex.Message)
        End Try





        'Tot_rows = DataGridView1.Rows.Count
        'Me.Cursor = Cursors.WaitCursor
        'ProgressBar1.Visible = True
        'Label5.Text = ""
        'Label5.Visible = True
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
        '            Label5.Text = PROgres_count & "%"
        '            ProgressBar1.Value = PROgres_count
        '        Next
        '        ProgressBar1.Value = 100
        '        ProgressBar1.Visible = False
        '        Label5.Visible = False
        '        xlworksheet.SaveAs(SaveFileDialog1.FileName)
        '        xlworkbook.Close()
        '        xlApp.Quit()
        '        releaseobject(xlApp)
        '        releaseobject(xlworkbook)
        '        releaseobject(xlworksheet)
        '        Me.Cursor = Cursors.Default
        '        showinfo("Records have been saved into an excel file")
        '    End If
        ' Me.Cursor = Cursors.Default
        'Catch ex As Exception
        '    Me.Cursor = Cursors.Default
        '    showerror(ex.Message)
        'End Try
        Me.Cursor = Cursors.Default
    End Sub
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
End Class