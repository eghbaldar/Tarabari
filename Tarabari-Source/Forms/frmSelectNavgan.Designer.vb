<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectNavgan
    Inherits Tarabari.frmBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.VSelectNavganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTarabari = New Tarabari.dsTarabari
        Me.VSelectNavganTableAdapter = New Tarabari.dsTarabariTableAdapters.vSelectNavganTableAdapter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnRemoveFilter = New DevComponents.DotNetBar.ButtonX
        Me.btnFilter = New DevComponents.DotNetBar.ButtonX
        Me.txtDate = New Tarabari.AdvancedMaskedTextBox(Me.components)
        Me.cmbFilterType = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgvNavganList = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.OperationCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RanandeFullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MashinIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PelakDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameMabdaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameMaghsadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TozihatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TarikhKhoroojMojtameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaatKhoroojMojtameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.VSelectNavganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvNavganList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VSelectNavganBindingSource
        '
        Me.VSelectNavganBindingSource.DataMember = "vSelectNavgan"
        Me.VSelectNavganBindingSource.DataSource = Me.DsTarabari
        '
        'DsTarabari
        '
        Me.DsTarabari.DataSetName = "dsTarabari"
        Me.DsTarabari.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VSelectNavganTableAdapter
        '
        Me.VSelectNavganTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnRemoveFilter)
        Me.GroupBox1.Controls.Add(Me.btnFilter)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Controls.Add(Me.cmbFilterType)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(724, 96)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "فیلتر"
        '
        'btnRemoveFilter
        '
        Me.btnRemoveFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRemoveFilter.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnRemoveFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRemoveFilter.Image = Global.Tarabari.My.Resources.Resources.RemoveFilter
        Me.btnRemoveFilter.Location = New System.Drawing.Point(159, 36)
        Me.btnRemoveFilter.Name = "btnRemoveFilter"
        Me.btnRemoveFilter.Size = New System.Drawing.Size(87, 31)
        Me.btnRemoveFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRemoveFilter.TabIndex = 19
        Me.btnRemoveFilter.Text = "لغو فیلتر"
        '
        'btnFilter
        '
        Me.btnFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFilter.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnFilter.Image = Global.Tarabari.My.Resources.Resources.Filter
        Me.btnFilter.Location = New System.Drawing.Point(271, 36)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(87, 31)
        Me.btnFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnFilter.TabIndex = 18
        Me.btnFilter.Text = "فیلتر"
        '
        'txtDate
        '
        Me.txtDate.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtDate.BorderColor = System.Drawing.Color.Empty
        Me.txtDate.Enabled = False
        Me.txtDate.FocusColor = System.Drawing.Color.Empty
        Me.txtDate.Location = New System.Drawing.Point(379, 44)
        Me.txtDate.Mask = "0000/00/00"
        Me.txtDate.Name = "txtDate"
        Me.txtDate.NextControl = Nothing
        Me.txtDate.PrevControl = Nothing
        Me.txtDate.Size = New System.Drawing.Size(75, 21)
        Me.txtDate.TabIndex = 2
        '
        'cmbFilterType
        '
        Me.cmbFilterType.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilterType.FormattingEnabled = True
        Me.cmbFilterType.Items.AddRange(New Object() {"خودروهای در حال ماموریت", "خودروهای اعزامی در امروز", "تاریخ"})
        Me.cmbFilterType.Location = New System.Drawing.Point(469, 44)
        Me.cmbFilterType.Name = "cmbFilterType"
        Me.cmbFilterType.Size = New System.Drawing.Size(139, 21)
        Me.cmbFilterType.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(614, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "فیلتر بر اساس :"
        '
        'dgvNavganList
        '
        Me.dgvNavganList.AllowUserToAddRows = False
        Me.dgvNavganList.AllowUserToDeleteRows = False
        Me.dgvNavganList.AllowUserToResizeColumns = False
        Me.dgvNavganList.AllowUserToResizeRows = False
        Me.dgvNavganList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvNavganList.AutoGenerateColumns = False
        Me.dgvNavganList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNavganList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvNavganList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvNavganList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OperationCodeDataGridViewTextBoxColumn, Me.RanandeFullNameDataGridViewTextBoxColumn, Me.MashinIDDataGridViewTextBoxColumn, Me.PelakDataGridViewTextBoxColumn, Me.NameMabdaDataGridViewTextBoxColumn, Me.NameMaghsadDataGridViewTextBoxColumn, Me.TozihatDataGridViewTextBoxColumn, Me.TarikhKhoroojMojtameDataGridViewTextBoxColumn, Me.SaatKhoroojMojtameDataGridViewTextBoxColumn})
        Me.dgvNavganList.DataSource = Me.VSelectNavganBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvNavganList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvNavganList.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvNavganList.Location = New System.Drawing.Point(12, 123)
        Me.dgvNavganList.MultiSelect = False
        Me.dgvNavganList.Name = "dgvNavganList"
        Me.dgvNavganList.ReadOnly = True
        Me.dgvNavganList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvNavganList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNavganList.Size = New System.Drawing.Size(724, 345)
        Me.dgvNavganList.TabIndex = 10
        '
        'OperationCodeDataGridViewTextBoxColumn
        '
        Me.OperationCodeDataGridViewTextBoxColumn.DataPropertyName = "OperationCode"
        Me.OperationCodeDataGridViewTextBoxColumn.HeaderText = "کد عملیات"
        Me.OperationCodeDataGridViewTextBoxColumn.Name = "OperationCodeDataGridViewTextBoxColumn"
        Me.OperationCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RanandeFullNameDataGridViewTextBoxColumn
        '
        Me.RanandeFullNameDataGridViewTextBoxColumn.DataPropertyName = "RanandeFullName"
        Me.RanandeFullNameDataGridViewTextBoxColumn.HeaderText = "نام راننده"
        Me.RanandeFullNameDataGridViewTextBoxColumn.Name = "RanandeFullNameDataGridViewTextBoxColumn"
        Me.RanandeFullNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MashinIDDataGridViewTextBoxColumn
        '
        Me.MashinIDDataGridViewTextBoxColumn.DataPropertyName = "MashinID"
        Me.MashinIDDataGridViewTextBoxColumn.HeaderText = "شماره ماشین"
        Me.MashinIDDataGridViewTextBoxColumn.Name = "MashinIDDataGridViewTextBoxColumn"
        Me.MashinIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PelakDataGridViewTextBoxColumn
        '
        Me.PelakDataGridViewTextBoxColumn.DataPropertyName = "Pelak"
        Me.PelakDataGridViewTextBoxColumn.HeaderText = "پلاک"
        Me.PelakDataGridViewTextBoxColumn.Name = "PelakDataGridViewTextBoxColumn"
        Me.PelakDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameMabdaDataGridViewTextBoxColumn
        '
        Me.NameMabdaDataGridViewTextBoxColumn.DataPropertyName = "NameMabda"
        Me.NameMabdaDataGridViewTextBoxColumn.HeaderText = "مبدا"
        Me.NameMabdaDataGridViewTextBoxColumn.Name = "NameMabdaDataGridViewTextBoxColumn"
        Me.NameMabdaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameMaghsadDataGridViewTextBoxColumn
        '
        Me.NameMaghsadDataGridViewTextBoxColumn.DataPropertyName = "NameMaghsad"
        Me.NameMaghsadDataGridViewTextBoxColumn.HeaderText = "مقصد"
        Me.NameMaghsadDataGridViewTextBoxColumn.Name = "NameMaghsadDataGridViewTextBoxColumn"
        Me.NameMaghsadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TozihatDataGridViewTextBoxColumn
        '
        Me.TozihatDataGridViewTextBoxColumn.DataPropertyName = "NoeBar"
        Me.TozihatDataGridViewTextBoxColumn.HeaderText = "نوع بار"
        Me.TozihatDataGridViewTextBoxColumn.Name = "TozihatDataGridViewTextBoxColumn"
        Me.TozihatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TarikhKhoroojMojtameDataGridViewTextBoxColumn
        '
        Me.TarikhKhoroojMojtameDataGridViewTextBoxColumn.DataPropertyName = "TarikhKhoroojMojtame"
        Me.TarikhKhoroojMojtameDataGridViewTextBoxColumn.HeaderText = "تاریخ خروج از مجتمع"
        Me.TarikhKhoroojMojtameDataGridViewTextBoxColumn.Name = "TarikhKhoroojMojtameDataGridViewTextBoxColumn"
        Me.TarikhKhoroojMojtameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaatKhoroojMojtameDataGridViewTextBoxColumn
        '
        Me.SaatKhoroojMojtameDataGridViewTextBoxColumn.DataPropertyName = "SaatKhoroojMojtame"
        Me.SaatKhoroojMojtameDataGridViewTextBoxColumn.HeaderText = "ساعت خروج از مجتمع"
        Me.SaatKhoroojMojtameDataGridViewTextBoxColumn.Name = "SaatKhoroojMojtameDataGridViewTextBoxColumn"
        Me.SaatKhoroojMojtameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmSelectNavgan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(748, 480)
        Me.Controls.Add(Me.dgvNavganList)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.MaximizeBox = True
        Me.Name = "frmSelectNavgan"
        Me.Text = "لیست خودروهای اعزامی"
        CType(Me.VSelectNavganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvNavganList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DsTarabari As Tarabari.dsTarabari
    Friend WithEvents VSelectNavganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VSelectNavganTableAdapter As Tarabari.dsTarabariTableAdapters.vSelectNavganTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbFilterType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDate As Tarabari.AdvancedMaskedTextBox
    Friend WithEvents btnRemoveFilter As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnFilter As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgvNavganList As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents OperationCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RanandeFullNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MashinIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PelakDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameMabdaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameMaghsadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TozihatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TarikhKhoroojMojtameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaatKhoroojMojtameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
