<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSanadPardakhtNaghdiList
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnRemoveFilter = New DevComponents.DotNetBar.ButtonX
        Me.btnFilter = New DevComponents.DotNetBar.ButtonX
        Me.cmbRanande = New System.Windows.Forms.ComboBox
        Me.cmbFilterType = New System.Windows.Forms.ComboBox
        Me.txtFilter = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.dgvSanadList = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.VFactorSanadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTarabari = New Tarabari.dsTarabari
        Me.VSelectRanandeganMashinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblMaghsadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblMabdaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VSelectRanandeganMashinTableAdapter = New Tarabari.dsTarabariTableAdapters.vSelectRanandeganMashinTableAdapter
        Me.Tbl_MabdaTableAdapter = New Tarabari.dsTarabariTableAdapters.tbl_MabdaTableAdapter
        Me.Tbl_MaghsadTableAdapter = New Tarabari.dsTarabariTableAdapters.tbl_MaghsadTableAdapter
        Me.VFactorSanadTableAdapter = New Tarabari.dsTarabariTableAdapters.vFactorSanadTableAdapter
        Me.FSTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FSIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RanandePersonalCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FullnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MashinIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PelakDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PaymentStatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewButtonColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSanadList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VFactorSanadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VSelectRanandeganMashinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMaghsadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMabdaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnRemoveFilter)
        Me.GroupBox1.Controls.Add(Me.btnFilter)
        Me.GroupBox1.Controls.Add(Me.cmbRanande)
        Me.GroupBox1.Controls.Add(Me.cmbFilterType)
        Me.GroupBox1.Controls.Add(Me.txtFilter)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(742, 101)
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
        Me.btnRemoveFilter.Location = New System.Drawing.Point(159, 38)
        Me.btnRemoveFilter.Name = "btnRemoveFilter"
        Me.btnRemoveFilter.Size = New System.Drawing.Size(87, 31)
        Me.btnRemoveFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRemoveFilter.TabIndex = 17
        Me.btnRemoveFilter.Text = "لغو فیلتر"
        '
        'btnFilter
        '
        Me.btnFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFilter.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnFilter.Image = Global.Tarabari.My.Resources.Resources.Filter
        Me.btnFilter.Location = New System.Drawing.Point(271, 38)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(87, 31)
        Me.btnFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnFilter.TabIndex = 16
        Me.btnFilter.Text = "فیلتر"
        '
        'cmbRanande
        '
        Me.cmbRanande.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbRanande.DataSource = Me.VSelectRanandeganMashinBindingSource
        Me.cmbRanande.DisplayMember = "Fullname"
        Me.cmbRanande.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRanande.FormattingEnabled = True
        Me.cmbRanande.Location = New System.Drawing.Point(383, 44)
        Me.cmbRanande.Name = "cmbRanande"
        Me.cmbRanande.Size = New System.Drawing.Size(121, 21)
        Me.cmbRanande.TabIndex = 13
        Me.cmbRanande.ValueMember = "RanandePersonalCode"
        '
        'cmbFilterType
        '
        Me.cmbFilterType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilterType.FormattingEnabled = True
        Me.cmbFilterType.Items.AddRange(New Object() {"شماره فاکتور / سند", "نام راننده", "کد ماشین"})
        Me.cmbFilterType.Location = New System.Drawing.Point(518, 44)
        Me.cmbFilterType.Name = "cmbFilterType"
        Me.cmbFilterType.Size = New System.Drawing.Size(121, 21)
        Me.cmbFilterType.TabIndex = 1
        '
        'txtFilter
        '
        Me.txtFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilter.BorderColor = System.Drawing.Color.Empty
        Me.txtFilter.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFilter.InputMode = Tarabari.AdvancedTextBox.enInputMode.Normal
        Me.txtFilter.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtFilter.Location = New System.Drawing.Point(386, 44)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.NextControl = Nothing
        Me.txtFilter.PrevControl = Nothing
        Me.txtFilter.Size = New System.Drawing.Size(118, 21)
        Me.txtFilter.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(645, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "فیلتر بر اساس :"
        '
        'dgvSanadList
        '
        Me.dgvSanadList.AllowUserToAddRows = False
        Me.dgvSanadList.AllowUserToDeleteRows = False
        Me.dgvSanadList.AllowUserToResizeColumns = False
        Me.dgvSanadList.AllowUserToResizeRows = False
        Me.dgvSanadList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSanadList.AutoGenerateColumns = False
        Me.dgvSanadList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSanadList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSanadList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSanadList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FSTypeDataGridViewTextBoxColumn, Me.FSIDDataGridViewTextBoxColumn, Me.PDateDataGridViewTextBoxColumn, Me.RanandePersonalCodeDataGridViewTextBoxColumn, Me.FullnameDataGridViewTextBoxColumn, Me.MashinIDDataGridViewTextBoxColumn, Me.PelakDataGridViewTextBoxColumn, Me.SubTotalDataGridViewTextBoxColumn, Me.PaymentStatusDataGridViewCheckBoxColumn, Me.Column2, Me.Column3, Me.Column1})
        Me.dgvSanadList.DataSource = Me.VFactorSanadBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSanadList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSanadList.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvSanadList.Location = New System.Drawing.Point(12, 127)
        Me.dgvSanadList.MultiSelect = False
        Me.dgvSanadList.Name = "dgvSanadList"
        Me.dgvSanadList.ReadOnly = True
        Me.dgvSanadList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvSanadList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSanadList.Size = New System.Drawing.Size(742, 420)
        Me.dgvSanadList.TabIndex = 9
        '
        'VFactorSanadBindingSource
        '
        Me.VFactorSanadBindingSource.DataMember = "vFactorSanad"
        Me.VFactorSanadBindingSource.DataSource = Me.DsTarabari
        '
        'DsTarabari
        '
        Me.DsTarabari.DataSetName = "dsTarabari"
        Me.DsTarabari.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VSelectRanandeganMashinBindingSource
        '
        Me.VSelectRanandeganMashinBindingSource.DataMember = "vSelectRanandeganMashin"
        Me.VSelectRanandeganMashinBindingSource.DataSource = Me.DsTarabari
        '
        'TblMaghsadBindingSource
        '
        Me.TblMaghsadBindingSource.DataMember = "tbl_Maghsad"
        Me.TblMaghsadBindingSource.DataSource = Me.DsTarabari
        '
        'TblMabdaBindingSource
        '
        Me.TblMabdaBindingSource.DataMember = "tbl_Mabda"
        Me.TblMabdaBindingSource.DataSource = Me.DsTarabari
        '
        'VSelectRanandeganMashinTableAdapter
        '
        Me.VSelectRanandeganMashinTableAdapter.ClearBeforeFill = True
        '
        'Tbl_MabdaTableAdapter
        '
        Me.Tbl_MabdaTableAdapter.ClearBeforeFill = True
        '
        'Tbl_MaghsadTableAdapter
        '
        Me.Tbl_MaghsadTableAdapter.ClearBeforeFill = True
        '
        'VFactorSanadTableAdapter
        '
        Me.VFactorSanadTableAdapter.ClearBeforeFill = True
        '
        'FSTypeDataGridViewTextBoxColumn
        '
        Me.FSTypeDataGridViewTextBoxColumn.DataPropertyName = "FS_Type"
        Me.FSTypeDataGridViewTextBoxColumn.HeaderText = "FS_Type"
        Me.FSTypeDataGridViewTextBoxColumn.Name = "FSTypeDataGridViewTextBoxColumn"
        Me.FSTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.FSTypeDataGridViewTextBoxColumn.Visible = False
        Me.FSTypeDataGridViewTextBoxColumn.Width = 74
        '
        'FSIDDataGridViewTextBoxColumn
        '
        Me.FSIDDataGridViewTextBoxColumn.DataPropertyName = "FS_ID"
        Me.FSIDDataGridViewTextBoxColumn.HeaderText = "شماره فاکتور / سند"
        Me.FSIDDataGridViewTextBoxColumn.Name = "FSIDDataGridViewTextBoxColumn"
        Me.FSIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.FSIDDataGridViewTextBoxColumn.Width = 122
        '
        'PDateDataGridViewTextBoxColumn
        '
        Me.PDateDataGridViewTextBoxColumn.DataPropertyName = "pDate"
        Me.PDateDataGridViewTextBoxColumn.HeaderText = "تاریخ"
        Me.PDateDataGridViewTextBoxColumn.Name = "PDateDataGridViewTextBoxColumn"
        Me.PDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.PDateDataGridViewTextBoxColumn.Width = 53
        '
        'RanandePersonalCodeDataGridViewTextBoxColumn
        '
        Me.RanandePersonalCodeDataGridViewTextBoxColumn.DataPropertyName = "RanandePersonalCode"
        Me.RanandePersonalCodeDataGridViewTextBoxColumn.HeaderText = "کد پرسنلی"
        Me.RanandePersonalCodeDataGridViewTextBoxColumn.Name = "RanandePersonalCodeDataGridViewTextBoxColumn"
        Me.RanandePersonalCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.RanandePersonalCodeDataGridViewTextBoxColumn.Width = 84
        '
        'FullnameDataGridViewTextBoxColumn
        '
        Me.FullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname"
        Me.FullnameDataGridViewTextBoxColumn.HeaderText = "نام و نام خانوادگی"
        Me.FullnameDataGridViewTextBoxColumn.Name = "FullnameDataGridViewTextBoxColumn"
        Me.FullnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FullnameDataGridViewTextBoxColumn.Width = 114
        '
        'MashinIDDataGridViewTextBoxColumn
        '
        Me.MashinIDDataGridViewTextBoxColumn.DataPropertyName = "MashinID"
        Me.MashinIDDataGridViewTextBoxColumn.HeaderText = "کد ماشین"
        Me.MashinIDDataGridViewTextBoxColumn.Name = "MashinIDDataGridViewTextBoxColumn"
        Me.MashinIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MashinIDDataGridViewTextBoxColumn.Width = 78
        '
        'PelakDataGridViewTextBoxColumn
        '
        Me.PelakDataGridViewTextBoxColumn.DataPropertyName = "Pelak"
        Me.PelakDataGridViewTextBoxColumn.HeaderText = "پلاک"
        Me.PelakDataGridViewTextBoxColumn.Name = "PelakDataGridViewTextBoxColumn"
        Me.PelakDataGridViewTextBoxColumn.ReadOnly = True
        Me.PelakDataGridViewTextBoxColumn.Width = 53
        '
        'SubTotalDataGridViewTextBoxColumn
        '
        Me.SubTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal"
        Me.SubTotalDataGridViewTextBoxColumn.HeaderText = "مبلغ کل"
        Me.SubTotalDataGridViewTextBoxColumn.Name = "SubTotalDataGridViewTextBoxColumn"
        Me.SubTotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubTotalDataGridViewTextBoxColumn.Width = 68
        '
        'PaymentStatusDataGridViewCheckBoxColumn
        '
        Me.PaymentStatusDataGridViewCheckBoxColumn.DataPropertyName = "PaymentStatus"
        Me.PaymentStatusDataGridViewCheckBoxColumn.HeaderText = "PaymentStatus"
        Me.PaymentStatusDataGridViewCheckBoxColumn.Name = "PaymentStatusDataGridViewCheckBoxColumn"
        Me.PaymentStatusDataGridViewCheckBoxColumn.ReadOnly = True
        Me.PaymentStatusDataGridViewCheckBoxColumn.Visible = False
        Me.PaymentStatusDataGridViewCheckBoxColumn.Width = 86
        '
        'Column2
        '
        Me.Column2.HeaderText = "وضعیت پرداخت مبلغ"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "تغییر وضعیت پرداخت"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Text = "تغییر وضعیت..."
        Me.Column3.UseColumnTextForButtonValue = True
        Me.Column3.Width = 108
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = "چاپ سند"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Text = "چاپ..."
        Me.Column1.UseColumnTextForButtonValue = True
        '
        'frmSanadPardakhtNaghdiList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(766, 559)
        Me.Controls.Add(Me.dgvSanadList)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = True
        Me.Name = "frmSanadPardakhtNaghdiList"
        Me.Text = "لیست اسناد پرداخت نقدی"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvSanadList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VFactorSanadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VSelectRanandeganMashinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMaghsadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMabdaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbFilterType As System.Windows.Forms.ComboBox
    Friend WithEvents txtFilter As Tarabari.AdvancedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DsTarabari As Tarabari.dsTarabari
    Friend WithEvents cmbRanande As System.Windows.Forms.ComboBox
    Friend WithEvents VSelectRanandeganMashinBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VSelectRanandeganMashinTableAdapter As Tarabari.dsTarabariTableAdapters.vSelectRanandeganMashinTableAdapter
    Friend WithEvents TblMabdaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MabdaTableAdapter As Tarabari.dsTarabariTableAdapters.tbl_MabdaTableAdapter
    Friend WithEvents TblMaghsadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MaghsadTableAdapter As Tarabari.dsTarabariTableAdapters.tbl_MaghsadTableAdapter
    Friend WithEvents btnRemoveFilter As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnFilter As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgvSanadList As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents SahmRanandeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VFactorSanadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VFactorSanadTableAdapter As Tarabari.dsTarabariTableAdapters.vFactorSanadTableAdapter
    Friend WithEvents FSTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FSIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RanandePersonalCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MashinIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PelakDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentStatusDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn

End Class
