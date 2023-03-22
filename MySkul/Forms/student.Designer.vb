<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class student
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.MaterialTheme2 = New Telerik.WinControls.Themes.MaterialTheme()
        Me.cmdadd = New Telerik.WinControls.UI.RadButton()
        Me.cmddelete = New Telerik.WinControls.UI.RadButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtsearch = New Telerik.WinControls.UI.RadTextBox()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.MaterialTheme1 = New Telerik.WinControls.Themes.MaterialTheme()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.studentgrid = New Telerik.WinControls.UI.RadGridView()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.cmdadd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmddelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.txtsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.studentgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.studentgrid.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.studentgrid.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdadd
        '
        Me.cmdadd.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdadd.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdadd.ForeColor = System.Drawing.SystemColors.Control
        Me.cmdadd.Location = New System.Drawing.Point(8, 8)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(87, 36)
        Me.cmdadd.TabIndex = 0
        Me.cmdadd.Text = "Add"
        Me.cmdadd.ThemeName = "Material"
        '
        'cmddelete
        '
        Me.cmddelete.BackColor = System.Drawing.Color.IndianRed
        Me.cmddelete.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddelete.ForeColor = System.Drawing.SystemColors.Control
        Me.cmddelete.Location = New System.Drawing.Point(109, 8)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(92, 36)
        Me.cmddelete.TabIndex = 1
        Me.cmddelete.Text = "Delete"
        Me.cmddelete.ThemeName = "Material"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(463, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search :"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.txtsearch)
        Me.Panel3.Controls.Add(Me.RadButton2)
        Me.Panel3.Controls.Add(Me.RadButton1)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.LinkLabel1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.cmddelete)
        Me.Panel3.Controls.Add(Me.cmdadd)
        Me.Panel3.Location = New System.Drawing.Point(6, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(892, 50)
        Me.Panel3.TabIndex = 3
        '
        'txtsearch
        '
        Me.txtsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtsearch.Location = New System.Drawing.Point(537, 8)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(292, 36)
        Me.txtsearch.TabIndex = 59
        Me.txtsearch.ThemeName = "Material"
        '
        'RadButton2
        '
        Me.RadButton2.BackColor = System.Drawing.Color.DarkCyan
        Me.RadButton2.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadButton2.ForeColor = System.Drawing.SystemColors.Control
        Me.RadButton2.Location = New System.Drawing.Point(375, 8)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(80, 36)
        Me.RadButton2.TabIndex = 58
        Me.RadButton2.Text = "Import"
        Me.RadButton2.ThemeName = "Material"
        '
        'RadButton1
        '
        Me.RadButton1.BackColor = System.Drawing.Color.Green
        Me.RadButton1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadButton1.ForeColor = System.Drawing.SystemColors.Control
        Me.RadButton1.Location = New System.Drawing.Point(281, 8)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(80, 36)
        Me.RadButton1.TabIndex = 58
        Me.RadButton1.Text = "Export"
        Me.RadButton1.ThemeName = "Material"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(215, 18)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(52, 16)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Refresh"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(892, 27)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Records"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.studentgrid)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(6, 60)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(892, 495)
        Me.Panel1.TabIndex = 2
        '
        'studentgrid
        '
        Me.studentgrid.Controls.Add(Me.txtid)
        Me.studentgrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.studentgrid.Location = New System.Drawing.Point(0, 27)
        '
        '
        '
        Me.studentgrid.MasterTemplate.AllowAddNewRow = False
        Me.studentgrid.MasterTemplate.AllowColumnReorder = False
        Me.studentgrid.MasterTemplate.AllowDeleteRow = False
        Me.studentgrid.MasterTemplate.AllowEditRow = False
        Me.studentgrid.MasterTemplate.EnableFiltering = True
        Me.studentgrid.MasterTemplate.EnableGrouping = False
        Me.studentgrid.MasterTemplate.ShowFilteringRow = False
        Me.studentgrid.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.studentgrid.Name = "studentgrid"
        Me.studentgrid.ReadOnly = True
        Me.studentgrid.ShowGroupPanel = False
        Me.studentgrid.ShowGroupPanelScrollbars = False
        Me.studentgrid.Size = New System.Drawing.Size(892, 468)
        Me.studentgrid.TabIndex = 3
        Me.studentgrid.Text = "tgrid"
        Me.studentgrid.ThemeName = "Material"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(291, 81)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(100, 22)
        Me.txtid.TabIndex = 1
        Me.txtid.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Image = Global.MySkul.My.Resources.Resources.Print_1
        Me.Button1.Location = New System.Drawing.Point(841, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 36)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = False
        '
        'student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(910, 568)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "student"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "student"
        CType(Me.cmdadd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmddelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.txtsearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.studentgrid.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.studentgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.studentgrid.ResumeLayout(False)
        Me.studentgrid.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialTheme2 As Telerik.WinControls.Themes.MaterialTheme
    Friend WithEvents cmdadd As Telerik.WinControls.UI.RadButton
    Friend WithEvents cmddelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MaterialTheme1 As Telerik.WinControls.Themes.MaterialTheme
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtsearch As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents studentgrid As Telerik.WinControls.UI.RadGridView
End Class
