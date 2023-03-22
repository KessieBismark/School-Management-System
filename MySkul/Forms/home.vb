Public Class Home
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Cursor = Cursors.WaitCursor
        If WindowState = FormWindowState.Maximized Then
            Dim expiable As New dashboard2
            Panelcn.Controls.Clear()
            expiable.TopLevel = False
            Panelcn.Controls.Add(expiable)
            btn()
            Button1.BackColor = Color.FromArgb(224, 224, 224)
            Button1.ForeColor = Color.Black
            acf.Text = "Home"
            expiable.Show()
            expiable.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            Dim expiable As New dashboard
            Panelcn.Controls.Clear()
            expiable.TopLevel = False
            Panelcn.Controls.Add(expiable)
            btn()
            Button1.BackColor = Color.FromArgb(224, 224, 224)
            Button1.ForeColor = Color.Black
            acf.Text = "Home"
            expiable.Show()
            expiable.WindowState = FormWindowState.Normal
        End If
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Cursor = Cursors.WaitCursor
        If WindowState = FormWindowState.Maximized Then
            Dim expiable As New student
            Panelcn.Controls.Clear()
            expiable.TopLevel = False
            Panelcn.Controls.Add(expiable)
            btn()
            Button2.BackColor = Color.FromArgb(224, 224, 224)
            Button2.ForeColor = Color.Black
            acf.Text = "Students"
            expiable.Show()
            expiable.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            Dim expiable As New student
            Panelcn.Controls.Clear()
            expiable.TopLevel = False
            Panelcn.Controls.Add(expiable)
            btn()
            Button2.BackColor = Color.FromArgb(224, 224, 224)
            Button2.ForeColor = Color.Black
            acf.Text = "Students"
            expiable.Show()
            expiable.WindowState = FormWindowState.Normal
        End If
        Me.Cursor = Cursors.Default

    End Sub
    Private Sub MaximizeForms()
        For Each frm As Form In Me.Panelcn.Controls
            If frm.WindowState = ActiveForm.WindowState Then
            Else
                frm.WindowState = ActiveForm.WindowState
            End If
        Next
    End Sub
    Private Sub btn()
        For Each btt As Button In Me.Panel2.Controls
            btt.BackColor = Color.Transparent
            btt.ForeColor = Color.White
        Next
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ul = "6" Then
            Button10.Enabled = False
            Button6.Enabled = False
            Button8.Enabled = False
            Button3.Enabled = False
            Button9.Enabled = False
            RadMenuItem3.Enabled = False
            RadMenuItem5.Enabled = False
            RadMenuItem2.Enabled = False
            RadMenuItem6.Enabled = False
            Button6.Visible = False
        ElseIf ul = "2" Or ul = "3" Then
            Button10.Enabled = False
            '  Button6.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            RadMenuItem3.Enabled = False
            RadMenuItem5.Enabled = False
            RadMenuItem2.Enabled = False
            RadMenuItem2.Enabled = False
            RadMenuItem6.Enabled = False
        ElseIf ul = "4" Or ul = "5" Then
            '  Button6.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            RadMenuItem3.Enabled = False
            RadMenuItem5.Enabled = False
            RadMenuItem2.Enabled = False
            RadMenuItem6.Enabled = False
        End If
        SetAcademic()
        calculate_income()
        calculate_expenses()
        Me.Cursor = Cursors.WaitCursor
        If WindowState = FormWindowState.Maximized Then
            Dim expiable As New dashboard
            Panelcn.Controls.Clear()
            expiable.TopLevel = False
            Panelcn.Controls.Add(expiable)
            btn()
            Button1.BackColor = Color.FromArgb(224, 224, 224)
            Button1.ForeColor = Color.Black
            acf.Text = "Home"
            expiable.Show()
            expiable.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            Dim expiable As New dashboard
            Panelcn.Controls.Clear()
            expiable.TopLevel = False
            Panelcn.Controls.Add(expiable)
            btn()
            Button1.BackColor = Color.FromArgb(224, 224, 224)
            Button1.ForeColor = Color.Black
            acf.Text = "Home"
            expiable.Show()
            expiable.WindowState = FormWindowState.Normal
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If WindowState = FormWindowState.Normal Then
                WindowState = FormWindowState.Maximized
                MaximizeForms()
                If Button1.ForeColor = Color.Black Then
                    Button1.PerformClick()
                End If
            ElseIf WindowState = FormWindowState.Maximized Then
                WindowState = FormWindowState.Normal
                MaximizeForms()
                If Button1.ForeColor = Color.Black Then
                    Button1.PerformClick()
                End If
            End If
        Catch ex As Exception
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        tb = New DataTable
        tb = ShowData("select * from d_grade where status = '1' and sid = '" & sid & "'")
        If tb.Rows.Count > 0 Then
            Me.Cursor = Cursors.WaitCursor
            If WindowState = FormWindowState.Maximized Then
                Dim expiable As New marks
                Panelcn.Controls.Clear()
                expiable.TopLevel = False
                Panelcn.Controls.Add(expiable)
                btn()
                Button4.BackColor = Color.FromArgb(224, 224, 224)
                Button4.ForeColor = Color.Black
                acf.Text = "Marks/Reports"
                expiable.Show()
                expiable.WindowState = FormWindowState.Maximized
            ElseIf WindowState = FormWindowState.Normal Then
                Dim expiable As New marks
                Panelcn.Controls.Clear()
                expiable.TopLevel = False
                Panelcn.Controls.Add(expiable)
                btn()
                Button4.BackColor = Color.FromArgb(224, 224, 224)
                Button4.ForeColor = Color.Black
                acf.Text = "Marks/Reports"
                expiable.Show()
                expiable.WindowState = FormWindowState.Normal
            End If
            Me.Cursor = Cursors.Default
        Else
            showerror("Please go to 'Assessment' and input the overall total marks and its corresponding percentage!")
            Button3.PerformClick()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Cursor = Cursors.WaitCursor
        If WindowState = FormWindowState.Maximized Then
            Dim expiable As New configuration
            Panelcn.Controls.Clear()
            expiable.TopLevel = False
            Panelcn.Controls.Add(expiable)
            btn()
            Button6.BackColor = Color.FromArgb(224, 224, 224)
            Button6.ForeColor = Color.Black
            acf.Text = "Reports"
            expiable.Show()
            expiable.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            Dim expiable As New configuration
            Panelcn.Controls.Clear()
            expiable.TopLevel = False
            Panelcn.Controls.Add(expiable)
            btn()
            Button6.BackColor = Color.FromArgb(224, 224, 224)
            Button6.ForeColor = Color.Black
            acf.Text = "Reports"
            expiable.Show()
            expiable.WindowState = FormWindowState.Normal
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Cursor = Cursors.WaitCursor
        If WindowState = FormWindowState.Maximized Then
            Dim expiable As New classroom
            Panelcn.Controls.Clear()
            expiable.TopLevel = False
            Panelcn.Controls.Add(expiable)
            btn()
            Button3.BackColor = Color.FromArgb(224, 224, 224)
            Button3.ForeColor = Color.Black
            acf.Text = "Academic Setups"
            expiable.Show()
            expiable.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            Dim expiable As New classroom
            Panelcn.Controls.Clear()
            expiable.TopLevel = False
            Panelcn.Controls.Add(expiable)
            btn()
            Button3.BackColor = Color.FromArgb(224, 224, 224)
            Button3.ForeColor = Color.Black
            acf.Text = "Academic Setup"
            expiable.Show()
            expiable.WindowState = FormWindowState.Normal
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub RadMenuItem2_Click(sender As Object, e As EventArgs) Handles RadMenuItem2.Click
        Dim bk As New dbBackup
        bk.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Cursor = Cursors.WaitCursor
        If WindowState = FormWindowState.Maximized Then
            Dim expiable As New staff
            Panelcn.Controls.Clear()
            expiable.TopLevel = False
            Panelcn.Controls.Add(expiable)
            btn()
            Button10.BackColor = Color.FromArgb(224, 224, 224)
            Button10.ForeColor = Color.Black
            acf.Text = "Non Teaching Staff"
            expiable.Show()
            expiable.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            Dim expiable As New staff
            Panelcn.Controls.Clear()
            expiable.TopLevel = False
            Panelcn.Controls.Add(expiable)
            btn()
            Button10.BackColor = Color.FromArgb(224, 224, 224)
            Button10.ForeColor = Color.Black
            acf.Text = "Non Teaching Staff"
            expiable.Show()
            expiable.WindowState = FormWindowState.Normal
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Cursor = Cursors.WaitCursor
        If WindowState = FormWindowState.Maximized Then
            Dim expiable As New transactions
            Panelcn.Controls.Clear()
            expiable.TopLevel = False
            Panelcn.Controls.Add(expiable)
            btn()
            Button9.BackColor = Color.FromArgb(224, 224, 224)
            Button9.ForeColor = Color.Black
            acf.Text = "Transaction"
            expiable.Show()
            expiable.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            Dim expiable As New transactions
            Panelcn.Controls.Clear()
            expiable.TopLevel = False
            Panelcn.Controls.Add(expiable)
            btn()
            Button9.BackColor = Color.FromArgb(224, 224, 224)
            Button9.ForeColor = Color.Black
            acf.Text = "Transaction"
            expiable.Show()
            expiable.WindowState = FormWindowState.Normal
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mousex
            Me.Top = Cursor.Position.Y - mousey
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Cursor = Cursors.WaitCursor
        If WindowState = FormWindowState.Maximized Then
            Dim expiable As New payroll
            Panelcn.Controls.Clear()
            expiable.TopLevel = False
            Panelcn.Controls.Add(expiable)
            btn()
            Button8.BackColor = Color.FromArgb(224, 224, 224)
            Button8.ForeColor = Color.Black
            acf.Text = "Payroll"
            expiable.Show()
            expiable.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            Dim expiable As New payroll
            Panelcn.Controls.Clear()
            expiable.TopLevel = False
            Panelcn.Controls.Add(expiable)
            btn()
            Button8.BackColor = Color.FromArgb(224, 224, 224)
            Button8.ForeColor = Color.Black
            acf.Text = "Payroll"
            expiable.Show()
            expiable.WindowState = FormWindowState.Normal
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Cursor = Cursors.WaitCursor
        If WindowState = FormWindowState.Maximized Then
            Dim expiable As New Files
            Panelcn.Controls.Clear()
            expiable.TopLevel = False
            Panelcn.Controls.Add(expiable)
            btn()
            Button5.BackColor = Color.FromArgb(224, 224, 224)
            Button5.ForeColor = Color.Black
            acf.Text = "Files"
            expiable.Show()
            expiable.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            Dim expiable As New Files
            Panelcn.Controls.Clear()
            expiable.TopLevel = False
            Panelcn.Controls.Add(expiable)
            btn()
            Button5.BackColor = Color.FromArgb(224, 224, 224)
            Button5.ForeColor = Color.Black
            acf.Text = "Files"
            expiable.Show()
            expiable.WindowState = FormWindowState.Normal
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub RadMenuItem3_Click(sender As Object, e As EventArgs) Handles RadMenuItem3.Click
        Me.Cursor = Cursors.WaitCursor
        Dim adu As New users
        adu.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub RadMenuItem4_Click(sender As Object, e As EventArgs) Handles RadMenuItem4.Click
        Me.Cursor = Cursors.WaitCursor
        Dim ra As New reset_account
        ra.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Cursor = Cursors.WaitCursor
        If WindowState = FormWindowState.Maximized Then
            Dim expiable As New messages
            Panelcn.Controls.Clear()
            expiable.TopLevel = False
            Panelcn.Controls.Add(expiable)
            btn()
            Button7.BackColor = Color.FromArgb(224, 224, 224)
            Button7.ForeColor = Color.Black
            acf.Text = "Messages"
            expiable.Show()
            expiable.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            Dim expiable As New messages
            Panelcn.Controls.Clear()
            expiable.TopLevel = False
            Panelcn.Controls.Add(expiable)
            btn()
            Button7.BackColor = Color.FromArgb(224, 224, 224)
            Button7.ForeColor = Color.Black
            acf.Text = "Messages"
            expiable.Show()
            expiable.WindowState = FormWindowState.Normal
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub RadMenuItem5_Click(sender As Object, e As EventArgs) Handles RadMenuItem5.Click
        Dim config As New dbconfig
        config.ShowDialog()
    End Sub

    Private Sub RadMenuItem7_Click(sender As Object, e As EventArgs) Handles RadMenuItem7.Click
        login.Show()
        Me.Close()
    End Sub

    Private Sub RadMenuItem6_Click(sender As Object, e As EventArgs) Handles RadMenuItem6.Click
        Dim school As New school_registration
        school.TextBox1.Text = sid
        school.ShowDialog()
    End Sub
End Class
