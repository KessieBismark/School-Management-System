<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class csv_export
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.exportgrid = New Telerik.WinControls.UI.RadGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.txtclass = New Telerik.WinControls.UI.RadDropDownList()
        Me.txtsubclass = New Telerik.WinControls.UI.RadDropDownList()
        Me.txtterm = New Telerik.WinControls.UI.RadDropDownList()
        Me.txtacademic = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.cmdexport = New Telerik.WinControls.UI.RadButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtcid = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.MaterialTheme1 = New Telerik.WinControls.Themes.MaterialTheme()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.exportgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exportgrid.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.exportgrid.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.txtclass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsubclass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtterm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtacademic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdexport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'exportgrid
        '
        Me.exportgrid.Controls.Add(Me.DataGridView1)
        Me.exportgrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.exportgrid.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.exportgrid.MasterTemplate.AllowAddNewRow = False
        Me.exportgrid.MasterTemplate.AllowColumnReorder = False
        Me.exportgrid.MasterTemplate.AllowColumnResize = False
        Me.exportgrid.MasterTemplate.ShowFilteringRow = False
        Me.exportgrid.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.exportgrid.Name = "exportgrid"
        Me.exportgrid.ReadOnly = True
        Me.exportgrid.ShowGroupPanel = False
        Me.exportgrid.ShowGroupPanelScrollbars = False
        Me.exportgrid.Size = New System.Drawing.Size(864, 442)
        Me.exportgrid.TabIndex = 7
        Me.exportgrid.Text = "RadGridView1"
        Me.exportgrid.ThemeName = "Material"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(516, 145)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 1
        Me.DataGridView1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel10)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(866, 540)
        Me.Panel1.TabIndex = 17
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(864, 24)
        Me.Panel3.TabIndex = 10
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(72, 4)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(201, 16)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "EXPORT STUDENTS RECORDS"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label19.Location = New System.Drawing.Point(3, 4)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 16)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Label19 -"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(841, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "X"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel10.Controls.Add(Me.Panel12)
        Me.Panel10.Location = New System.Drawing.Point(0, 26)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(864, 79)
        Me.Panel10.TabIndex = 11
        '
        'Panel12
        '
        Me.Panel12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel12.BackColor = System.Drawing.Color.White
        Me.Panel12.Controls.Add(Me.Label5)
        Me.Panel12.Controls.Add(Me.ProgressBar1)
        Me.Panel12.Controls.Add(Me.txtclass)
        Me.Panel12.Controls.Add(Me.txtsubclass)
        Me.Panel12.Controls.Add(Me.txtterm)
        Me.Panel12.Controls.Add(Me.txtacademic)
        Me.Panel12.Controls.Add(Me.Label13)
        Me.Panel12.Controls.Add(Me.Label2)
        Me.Panel12.Controls.Add(Me.RadButton1)
        Me.Panel12.Controls.Add(Me.cmdexport)
        Me.Panel12.Controls.Add(Me.Label4)
        Me.Panel12.Controls.Add(Me.Label3)
        Me.Panel12.Location = New System.Drawing.Point(3, 6)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(858, 70)
        Me.Panel12.TabIndex = 9
        '
        'txtclass
        '
        Me.txtclass.BackColor = System.Drawing.SystemColors.Control
        Me.txtclass.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "All"
        Me.txtclass.Items.Add(RadListDataItem1)
        Me.txtclass.Location = New System.Drawing.Point(394, 7)
        Me.txtclass.Name = "txtclass"
        Me.txtclass.Size = New System.Drawing.Size(79, 36)
        Me.txtclass.TabIndex = 1
        Me.txtclass.ThemeName = "Material"
        '
        'txtsubclass
        '
        Me.txtsubclass.BackColor = System.Drawing.SystemColors.Control
        Me.txtsubclass.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem2.Text = "All"
        Me.txtsubclass.Items.Add(RadListDataItem2)
        Me.txtsubclass.Location = New System.Drawing.Point(562, 7)
        Me.txtsubclass.Name = "txtsubclass"
        Me.txtsubclass.Size = New System.Drawing.Size(104, 36)
        Me.txtsubclass.TabIndex = 1
        Me.txtsubclass.ThemeName = "Material"
        '
        'txtterm
        '
        Me.txtterm.BackColor = System.Drawing.SystemColors.Control
        Me.txtterm.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem3.Text = "1"
        RadListDataItem4.Text = "2"
        RadListDataItem5.Text = "3"
        RadListDataItem6.Text = "All"
        Me.txtterm.Items.Add(RadListDataItem3)
        Me.txtterm.Items.Add(RadListDataItem4)
        Me.txtterm.Items.Add(RadListDataItem5)
        Me.txtterm.Items.Add(RadListDataItem6)
        Me.txtterm.Location = New System.Drawing.Point(254, 6)
        Me.txtterm.Name = "txtterm"
        Me.txtterm.Size = New System.Drawing.Size(79, 36)
        Me.txtterm.TabIndex = 1
        Me.txtterm.ThemeName = "Material"
        '
        'txtacademic
        '
        Me.txtacademic.BackColor = System.Drawing.SystemColors.Control
        Me.txtacademic.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.txtacademic.Location = New System.Drawing.Point(80, 8)
        Me.txtacademic.Name = "txtacademic"
        Me.txtacademic.Size = New System.Drawing.Size(114, 36)
        Me.txtacademic.TabIndex = 1
        Me.txtacademic.ThemeName = "Material"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(0, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Academic:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Term :"
        '
        'RadButton1
        '
        Me.RadButton1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.RadButton1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadButton1.ForeColor = System.Drawing.SystemColors.Control
        Me.RadButton1.Location = New System.Drawing.Point(672, 6)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(86, 36)
        Me.RadButton1.TabIndex = 1
        Me.RadButton1.Text = "Get"
        Me.RadButton1.ThemeName = "Material"
        '
        'cmdexport
        '
        Me.cmdexport.BackColor = System.Drawing.Color.Green
        Me.cmdexport.Enabled = False
        Me.cmdexport.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexport.ForeColor = System.Drawing.SystemColors.Control
        Me.cmdexport.Location = New System.Drawing.Point(764, 7)
        Me.cmdexport.Name = "cmdexport"
        Me.cmdexport.Size = New System.Drawing.Size(86, 36)
        Me.cmdexport.TabIndex = 1
        Me.cmdexport.Text = "Export"
        Me.cmdexport.ThemeName = "Material"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(479, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Sub Class :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(340, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Class :"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.exportgrid)
        Me.Panel2.Location = New System.Drawing.Point(0, 101)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(864, 442)
        Me.Panel2.TabIndex = 12
        '
        'txtcid
        '
        Me.txtcid.Location = New System.Drawing.Point(335, 45)
        Me.txtcid.Name = "txtcid"
        Me.txtcid.Size = New System.Drawing.Size(100, 22)
        Me.txtcid.TabIndex = 18
        Me.txtcid.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(119, 102)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 19
        Me.DateTimePicker1.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 49)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(658, 14)
        Me.ProgressBar1.TabIndex = 65
        Me.ProgressBar1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(669, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Label5"
        Me.Label5.Visible = False
        '
        'csv_export
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 540)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtcid)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "csv_export"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "csv_export"
        CType(Me.exportgrid.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exportgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.exportgrid.ResumeLayout(False)
        Me.exportgrid.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        CType(Me.txtclass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsubclass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtterm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtacademic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdexport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exportgrid As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtcid As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Panel12 As Panel
    Friend WithEvents txtsubclass As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txtclass As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txtterm As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txtacademic As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label13 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdexport As Telerik.WinControls.UI.RadButton
    Friend WithEvents MaterialTheme1 As Telerik.WinControls.Themes.MaterialTheme
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label5 As Label
End Class
