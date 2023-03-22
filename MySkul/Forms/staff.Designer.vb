<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staff
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
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.MaterialTheme1 = New Telerik.WinControls.Themes.MaterialTheme()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtsearch = New Telerik.WinControls.UI.RadTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmddelete = New Telerik.WinControls.UI.RadButton()
        Me.cmdadd = New Telerik.WinControls.UI.RadButton()
        Me.MaterialTheme2 = New Telerik.WinControls.Themes.MaterialTheme()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tgrid = New Telerik.WinControls.UI.RadGridView()
        Me.txttid = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ntgrid = New Telerik.WinControls.UI.RadGridView()
        Me.txtntid = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.txtsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmddelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdadd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.tgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgrid.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tgrid.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.ntgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ntgrid.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ntgrid.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.LinkLabel1)
        Me.Panel3.Controls.Add(Me.txtsearch)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.cmddelete)
        Me.Panel3.Controls.Add(Me.cmdadd)
        Me.Panel3.Location = New System.Drawing.Point(3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(895, 50)
        Me.Panel3.TabIndex = 5
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(298, 20)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(65, 18)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Refresh"
        '
        'txtsearch
        '
        Me.txtsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.AutoSize = False
        Me.txtsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtsearch.Location = New System.Drawing.Point(501, 9)
        Me.txtsearch.Multiline = True
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(319, 36)
        Me.txtsearch.TabIndex = 3
        Me.txtsearch.ThemeName = "Material"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(422, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search :"
        '
        'cmddelete
        '
        Me.cmddelete.BackColor = System.Drawing.Color.IndianRed
        Me.cmddelete.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddelete.ForeColor = System.Drawing.SystemColors.Control
        Me.cmddelete.Location = New System.Drawing.Point(148, 8)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(120, 36)
        Me.cmddelete.TabIndex = 1
        Me.cmddelete.Text = "Delete"
        Me.cmddelete.ThemeName = "Material"
        '
        'cmdadd
        '
        Me.cmdadd.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdadd.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdadd.ForeColor = System.Drawing.SystemColors.Control
        Me.cmdadd.Location = New System.Drawing.Point(8, 8)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(120, 36)
        Me.cmdadd.TabIndex = 0
        Me.cmdadd.Text = "Add"
        Me.cmdadd.ThemeName = "Material"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.Location = New System.Drawing.Point(3, 58)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(895, 498)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 31)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(887, 463)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Teaching Staff"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tgrid)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(881, 457)
        Me.Panel1.TabIndex = 5
        '
        'tgrid
        '
        Me.tgrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tgrid.Controls.Add(Me.txttid)
        Me.tgrid.Location = New System.Drawing.Point(0, 25)
        '
        '
        '
        Me.tgrid.MasterTemplate.AllowAddNewRow = False
        Me.tgrid.MasterTemplate.AllowColumnReorder = False
        Me.tgrid.MasterTemplate.AllowDeleteRow = False
        Me.tgrid.MasterTemplate.AllowEditRow = False
        Me.tgrid.MasterTemplate.EnableFiltering = True
        Me.tgrid.MasterTemplate.EnableGrouping = False
        Me.tgrid.MasterTemplate.ShowFilteringRow = False
        Me.tgrid.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.tgrid.Name = "tgrid"
        Me.tgrid.ReadOnly = True
        Me.tgrid.ShowGroupPanel = False
        Me.tgrid.ShowGroupPanelScrollbars = False
        Me.tgrid.Size = New System.Drawing.Size(881, 432)
        Me.tgrid.TabIndex = 2
        Me.tgrid.Text = "tgrid"
        Me.tgrid.ThemeName = "Material"
        '
        'txttid
        '
        Me.txttid.Location = New System.Drawing.Point(388, 37)
        Me.txttid.Name = "txttid"
        Me.txttid.Size = New System.Drawing.Size(100, 29)
        Me.txttid.TabIndex = 1
        Me.txttid.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(881, 25)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Teaching Staff Records"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TabPage2.Location = New System.Drawing.Point(4, 31)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(887, 463)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Non Teaching Staff"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.ntgrid)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(881, 457)
        Me.Panel4.TabIndex = 6
        '
        'ntgrid
        '
        Me.ntgrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ntgrid.Controls.Add(Me.txtntid)
        Me.ntgrid.Location = New System.Drawing.Point(0, 25)
        '
        '
        '
        Me.ntgrid.MasterTemplate.AllowAddNewRow = False
        Me.ntgrid.MasterTemplate.AllowColumnReorder = False
        Me.ntgrid.MasterTemplate.AllowDeleteRow = False
        Me.ntgrid.MasterTemplate.AllowEditRow = False
        Me.ntgrid.MasterTemplate.EnableFiltering = True
        Me.ntgrid.MasterTemplate.EnableGrouping = False
        Me.ntgrid.MasterTemplate.ShowFilteringRow = False
        Me.ntgrid.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.ntgrid.Name = "ntgrid"
        Me.ntgrid.ReadOnly = True
        Me.ntgrid.ShowGroupPanel = False
        Me.ntgrid.ShowGroupPanelScrollbars = False
        Me.ntgrid.Size = New System.Drawing.Size(881, 432)
        Me.ntgrid.TabIndex = 1
        Me.ntgrid.Text = "ntgrid"
        Me.ntgrid.ThemeName = "Material"
        '
        'txtntid
        '
        Me.txtntid.Location = New System.Drawing.Point(352, 118)
        Me.txtntid.Name = "txtntid"
        Me.txtntid.Size = New System.Drawing.Size(100, 29)
        Me.txtntid.TabIndex = 1
        Me.txtntid.Visible = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(881, 25)
        Me.Panel5.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(4, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Non-Teaching Staff Records"
        '
        'staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(910, 568)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "staff"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "nonts"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.txtsearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmddelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdadd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.tgrid.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tgrid.ResumeLayout(False)
        Me.tgrid.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.ntgrid.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ntgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ntgrid.ResumeLayout(False)
        Me.ntgrid.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MaterialTheme1 As Telerik.WinControls.Themes.MaterialTheme
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtsearch As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmddelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents cmdadd As Telerik.WinControls.UI.RadButton
    Friend WithEvents MaterialTheme2 As Telerik.WinControls.Themes.MaterialTheme
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ntgrid As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txttid As TextBox
    Friend WithEvents tgrid As Telerik.WinControls.UI.RadGridView
    Friend WithEvents txtntid As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
