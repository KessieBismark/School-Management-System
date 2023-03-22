Public Class Files
    Dim Tot_rows As Integer
    Dim PROgres_count As Integer
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

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        Clear(Me)
    End Sub

    Private Sub Files_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If ul = "6" Then
                txtsrclass.Items.Add(tclass)
                txtmclass.Items.Add(tclass)
            Else

                txtsrclass.DataSource = New BindingSource(ShowData("select * from subclass where sid = '" & sid & "' order by s_class ASC"), Nothing)
                txtsrclass.DisplayMember = "s_class"
                txtsrclass.Items.Add("")

                txtmclass.DataSource = New BindingSource(ShowData("select * from subclass where sid='" & sid & "' order by s_class ASC"), Nothing)
                txtmclass.DisplayMember = "s_class"
                txtmclass.Items.Add("")
            End If

            txtmacademic.DataSource = New BindingSource(ShowData("select * from academic_year where sid ='" & sid & "' group by academic  order by academic DESC"), Nothing)
            txtmacademic.DisplayMember = "academic"

            cmdexport.Enabled = False
            cmdmexport.Enabled = False
        Catch ex As Exception
            showerror(ex.Message)
        End Try
    End Sub

    Private Sub cmdclear_Click(sender As Object, e As EventArgs) Handles cmdexport.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim name As String = "Class-" & txtsrclass.Text
            Dim csvfile As String = String.Empty
            Me.Cursor = Cursors.WaitCursor
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
        '        showinfo("Records have been saved into an excel file format")
        '        cmdexport.Enabled = False
        '    End If
        '    Me.Cursor = Cursors.Default
        'Catch ex As Exception
        '    Me.Cursor = Cursors.Default
        '    showerror(ex.Message)
        'End Try
        'Me.Cursor = Cursors.Default

    End Sub

    Private Sub cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        srgrid.DataSource = ShowData("select student_id as Student_ID, fullname as Fullname , ''as Exercise,'' as Mid_Term,'' as Exams from student where class= '" + txtsrclass.Text + "' and sid ='" & sid & "'")
        DataGridView1.Refresh()
        DataGridView1.DataSource = ShowData("select student_id as Student_ID, fullname as Fullname , ''as Exercise,'' as Mid_Term,'' as Exams from student where class= '" + txtsrclass.Text + "' and sid ='" & sid & "'")
        Tot_rows = DataGridView1.Rows.Count
        If Tot_rows > 0 Then
            cmdexport.Enabled = True
        End If
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        mgrid.DataSource = ShowData("select Student_ID,Name,Subject,Class_Score,Exams_Score,Total,Remark,Academic,Term,Position from marks where class= '" + txtmclass.Text + "' and Academic='" + txtmacademic.Text + "' and Term='" + Txtmterm.Text + "' and sid ='" & sid & "' order by Student_ID")
        For i As Integer = 0 To Me.mgrid.ColumnCount - 1
            Me.mgrid.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
        Next
        DataGridView1.Refresh()
        DataGridView1.DataSource = ShowData("select Student_ID,Name,Subject,Class_Score,Exams_Score,Total,Remark,Academic,Term,Position from marks where class= '" + txtmclass.Text + "' and Academic='" + txtmacademic.Text + "' and Term='" + Txtmterm.Text + "' and sid ='" & sid & "' order by Student_ID")
        Tot_rows = DataGridView1.Rows.Count
        If Tot_rows > 0 Then
            cmdmexport.Enabled = True
        End If
    End Sub

    Private Sub cmdmexport_Click(sender As Object, e As EventArgs) Handles cmdmexport.Click
        Try
            Dim name As String = "Marks-" & txtmclass.Text & "-" & Txtmterm.Text
            Dim csvfile As String = String.Empty
            Me.Cursor = Cursors.WaitCursor
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

        'Me.Cursor = Cursors.WaitCursor
        'ProgressBar2.Visible = True
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
        '            ProgressBar2.Value = PROgres_count
        '        Next
        '        ProgressBar2.Value = 100
        '        ProgressBar2.Visible = False
        '        xlworksheet.SaveAs(SaveFileDialog1.FileName)
        '        xlworkbook.Close()
        '        xlApp.Quit()
        '        releaseobject(xlApp)
        '        releaseobject(xlworkbook)
        '        releaseobject(xlworksheet)
        '        Me.Cursor = Cursors.Default
        '        showinfo("Records have been saved into an excel file")
        '        cmdmexport.Enabled = False
        '    End If
        '    Me.Cursor = Cursors.Default
        'Catch ex As Exception
        '    Me.Cursor = Cursors.Default
        '    showerror(ex.Message)
        'End Try
        'Me.Cursor = Cursors.Default

    End Sub

    Private Sub RadButton6_Click(sender As Object, e As EventArgs) Handles RadButton6.Click
        qgrid.DataSource = ShowData(txtquery.Text)
        DataGridView1.Refresh()
        DataGridView1.DataSource = ShowData(txtquery.Text)
        Tot_rows = DataGridView1.Rows.Count
        If Tot_rows > 0 Then
            cmdmexport.Enabled = True
        End If
    End Sub

    Private Sub cmdqexport_Click(sender As Object, e As EventArgs) Handles cmdqexport.Click
        Try
            Dim name As String = "Query-" & DateTime.Now.Second
            Dim csvfile As String = String.Empty
            Me.Cursor = Cursors.WaitCursor
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


        'Me.Cursor = Cursors.WaitCursor
        'ProgressBar3.Visible = True
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
        '            ProgressBar3.Value = PROgres_count
        '        Next
        '        ProgressBar3.Value = 100
        '        ProgressBar3.Visible = False
        '        xlworksheet.SaveAs(SaveFileDialog1.FileName)
        '        xlworkbook.Close()
        '        xlApp.Quit()
        '        releaseobject(xlApp)
        '        releaseobject(xlworkbook)
        '        releaseobject(xlworksheet)
        '        Me.Cursor = Cursors.Default
        '        showinfo("Records have been saved into an excel file")
        '        cmdqexport.Enabled = False
        '    End If
        '    Me.Cursor = Cursors.Default
        'Catch ex As Exception
        '    Me.Cursor = Cursors.Default
        '    showerror(ex.Message)
        'End Try
        'Me.Cursor = Cursors.Default
    End Sub
End Class