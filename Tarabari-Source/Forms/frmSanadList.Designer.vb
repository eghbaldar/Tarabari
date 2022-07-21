<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSanadList
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
        Me.VSanadListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTarabari = New Tarabari.dsTarabari
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnRemoveFilter = New DevComponents.DotNetBar.ButtonX
        Me.btnFilter = New DevComponents.DotNetBar.ButtonX
        Me.cmbRanande = New System.Windows.Forms.ComboBox
        Me.VSelectRanandeganMashinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbMaghsad = New System.Windows.Forms.ComboBox
        Me.TblMaghsadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbMabda = New System.Windows.Forms.ComboBox
        Me.TblMabdaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtFilterDate = New Tarabari.AdvancedMaskedTextBox(Me.components)
        Me.cmbFilterType = New System.Windows.Forms.ComboBox
        Me.txtFilter = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.VSanadListTableAdapter = New Tarabari.dsTarabariTableAdapters.vSanadListTableAdapter
        Me.VSelectRanandeganMashinTableAdapter = New Tarabari.dsTarabariTableAdapters.vSelectRanandeganMashinTableAdapter
        Me.Tbl_MabdaTableAdapter = New Tarabari.dsTarabariTableAdapters.tbl_MabdaTableAdapter
        Me.Tbl_MaghsadTableAdapter = New Tarabari.dsTarabariTableAdapters.tbl_MaghsadTableAdapter
        Me.dgvSanadList = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.OperationCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RanandeFullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RanandePersonalCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MashinIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PelakDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MabdaIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameMabdaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MaghsadIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameMaghsadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TarikhKhoroojMojtameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TarikhVoroodMojtameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewButtonColumn
        CType(Me.VSanadListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VSelectRanandeganMashinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMaghsadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMabdaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSanadList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VSanadListBindingSource
        '
        Me.VSanadListBindingSource.DataMember = "vSanadList"
        Me.VSanadListBindingSource.DataSource = Me.DsTarabari
        '
        'DsTarabari
        '
        Me.DsTarabari.DataSetName = "dsTarabari"
        Me.DsTarabari.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnRemoveFilter)
        Me.GroupBox1.Controls.Add(Me.btnFilter)
        Me.GroupBox1.Controls.Add(Me.cmbRanande)
        Me.GroupBox1.Controls.Add(Me.cmbMaghsad)
        Me.GroupBox1.Controls.Add(Me.cmbMabda)
        Me.GroupBox1.Controls.Add(Me.txtFilterDate)
        Me.GroupBox1.Controls.Add(Me.cmbFilterType)
        Me.GroupBox1.Controls.Add(Me.txtFilter)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(926, 101)
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
        Me.btnRemoveFilter.Location = New System.Drawing.Point(346, 38)
        Me.btnRemoveFilter.Name = "btnRemoveFilter"
        Me.btnRemoveFilter.Size = New System.Drawing.Size(87, 31)
        Me.btnRemoveFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRemoveFilter.TabIndex = 15
        Me.btnRemoveFilter.Text = "لغو فیلتر"
        '
        'btnFilter
        '
        Me.btnFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFilter.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnFilter.Image = Global.Tarabari.My.Resources.Resources.Filter
        Me.btnFilter.Location = New System.Drawing.Point(458, 38)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(87, 31)
        Me.btnFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnFilter.TabIndex = 14
        Me.btnFilter.Text = "فیلتر"
        '
        'cmbRanande
        '
        Me.cmbRanande.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbRanande.DataSource = Me.VSelectRanandeganMashinBindingSource
        Me.cmbRanande.DisplayMember = "Fullname"
        Me.cmbRanande.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRanande.FormattingEnabled = True
        Me.cmbRanande.Location = New System.Drawing.Point(567, 44)
        Me.cmbRanande.Name = "cmbRanande"
        Me.cmbRanande.Size = New System.Drawing.Size(121, 21)
        Me.cmbRanande.TabIndex = 13
        Me.cmbRanande.ValueMember = "RanandePersonalCode"
        '
        'VSelectRanandeganMashinBindingSource
        '
        Me.VSelectRanandeganMashinBindingSource.DataMember = "vSelectRanandeganMashin"
        Me.VSelectRanandeganMashinBindingSource.DataSource = Me.DsTarabari
        '
        'cmbMaghsad
        '
        Me.cmbMaghsad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMaghsad.DataSource = Me.TblMaghsadBindingSource
        Me.cmbMaghsad.DisplayMember = "NameMaghsad"
        Me.cmbMaghsad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMaghsad.FormattingEnabled = True
        Me.cmbMaghsad.Location = New System.Drawing.Point(567, 44)
        Me.cmbMaghsad.Name = "cmbMaghsad"
        Me.cmbMaghsad.Size = New System.Drawing.Size(121, 21)
        Me.cmbMaghsad.TabIndex = 12
        Me.cmbMaghsad.ValueMember = "MaghsadID"
        '
        'TblMaghsadBindingSource
        '
        Me.TblMaghsadBindingSource.DataMember = "tbl_Maghsad"
        Me.TblMaghsadBindingSource.DataSource = Me.DsTarabari
        '
        'cmbMabda
        '
        Me.cmbMabda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMabda.DataSource = Me.TblMabdaBindingSource
        Me.cmbMabda.DisplayMember = "NameMabda"
        Me.cmbMabda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMabda.FormattingEnabled = True
        Me.cmbMabda.Location = New System.Drawing.Point(567, 44)
        Me.cmbMabda.Name = "cmbMabda"
        Me.cmbMabda.Size = New System.Drawing.Size(121, 21)
        Me.cmbMabda.TabIndex = 11
        Me.cmbMabda.ValueMember = "MabdaID"
        '
        'TblMabdaBindingSource
        '
        Me.TblMabdaBindingSource.DataMember = "tbl_Mabda"
        Me.TblMabdaBindingSource.DataSource = Me.DsTarabari
        '
        'txtFilterDate
        '
        Me.txtFilterDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilterDate.BorderColor = System.Drawing.Color.Empty
        Me.txtFilterDate.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFilterDate.Location = New System.Drawing.Point(605, 44)
        Me.txtFilterDate.Mask = "0000/00/00"
        Me.txtFilterDate.Name = "txtFilterDate"
        Me.txtFilterDate.NextControl = Nothing
        Me.txtFilterDate.PrevControl = Nothing
        Me.txtFilterDate.Size = New System.Drawing.Size(83, 21)
        Me.txtFilterDate.TabIndex = 2
        '
        'cmbFilterType
        '
        Me.cmbFilterType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilterType.FormattingEnabled = True
        Me.cmbFilterType.Items.AddRange(New Object() {"شماره سند", "نام راننده", "مبداء", "مقصد", "تاریخ خروج", "تاریخ ورود", "کد ماشین"})
        Me.cmbFilterType.Location = New System.Drawing.Point(702, 44)
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
        Me.txtFilter.Location = New System.Drawing.Point(570, 44)
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
        Me.Label8.Location = New System.Drawing.Point(829, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "فیلتر بر اساس :"
        '
        'VSanadListTableAdapter
        '
        Me.VSanadListTableAdapter.ClearBeforeFill = True
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSanadList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSanadList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSanadList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OperationCodeDataGridViewTextBoxColumn, Me.RanandeFullNameDataGridViewTextBoxColumn, Me.RanandePersonalCodeDataGridViewTextBoxColumn, Me.MashinIDDataGridViewTextBoxColumn, Me.PelakDataGridViewTextBoxColumn, Me.MabdaIDDataGridViewTextBoxColumn, Me.NameMabdaDataGridViewTextBoxColumn, Me.MaghsadIDDataGridViewTextBoxColumn, Me.NameMaghsadDataGridViewTextBoxColumn, Me.TarikhKhoroojMojtameDataGridViewTextBoxColumn, Me.TarikhVoroodMojtameDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.Column1, Me.Column2, Me.Column3})
        Me.dgvSanadList.DataSource = Me.VSanadListBindingSource
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
        Me.dgvSanadList.Size = New System.Drawing.Size(926, 420)
        Me.dgvSanadList.TabIndex = 8
        '
        'OperationCodeDataGridViewTextBoxColumn
        '
        Me.OperationCodeDataGridViewTextBoxColumn.DataPropertyName = "OperationCode"
        Me.OperationCodeDataGridViewTextBoxColumn.HeaderText = "شماره سند"
        Me.OperationCodeDataGridViewTextBoxColumn.Name = "OperationCodeDataGridViewTextBoxColumn"
        Me.OperationCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.OperationCodeDataGridViewTextBoxColumn.Width = 105
        '
        'RanandeFullNameDataGridViewTextBoxColumn
        '
        Me.RanandeFullNameDataGridViewTextBoxColumn.DataPropertyName = "RanandeFullName"
        Me.RanandeFullNameDataGridViewTextBoxColumn.HeaderText = "نام راننده"
        Me.RanandeFullNameDataGridViewTextBoxColumn.Name = "RanandeFullNameDataGridViewTextBoxColumn"
        Me.RanandeFullNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.RanandeFullNameDataGridViewTextBoxColumn.Width = 118
        '
        'RanandePersonalCodeDataGridViewTextBoxColumn
        '
        Me.RanandePersonalCodeDataGridViewTextBoxColumn.DataPropertyName = "RanandePersonalCode"
        Me.RanandePersonalCodeDataGridViewTextBoxColumn.HeaderText = "شماره پرسنلی"
        Me.RanandePersonalCodeDataGridViewTextBoxColumn.Name = "RanandePersonalCodeDataGridViewTextBoxColumn"
        Me.RanandePersonalCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.RanandePersonalCodeDataGridViewTextBoxColumn.Width = 141
        '
        'MashinIDDataGridViewTextBoxColumn
        '
        Me.MashinIDDataGridViewTextBoxColumn.DataPropertyName = "MashinID"
        Me.MashinIDDataGridViewTextBoxColumn.HeaderText = "شماره ماشین"
        Me.MashinIDDataGridViewTextBoxColumn.Name = "MashinIDDataGridViewTextBoxColumn"
        Me.MashinIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MashinIDDataGridViewTextBoxColumn.Width = 76
        '
        'PelakDataGridViewTextBoxColumn
        '
        Me.PelakDataGridViewTextBoxColumn.DataPropertyName = "Pelak"
        Me.PelakDataGridViewTextBoxColumn.HeaderText = "پلاک"
        Me.PelakDataGridViewTextBoxColumn.Name = "PelakDataGridViewTextBoxColumn"
        Me.PelakDataGridViewTextBoxColumn.ReadOnly = True
        Me.PelakDataGridViewTextBoxColumn.Width = 57
        '
        'MabdaIDDataGridViewTextBoxColumn
        '
        Me.MabdaIDDataGridViewTextBoxColumn.DataPropertyName = "MabdaID"
        Me.MabdaIDDataGridViewTextBoxColumn.HeaderText = "MabdaID"
        Me.MabdaIDDataGridViewTextBoxColumn.Name = "MabdaIDDataGridViewTextBoxColumn"
        Me.MabdaIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MabdaIDDataGridViewTextBoxColumn.Visible = False
        Me.MabdaIDDataGridViewTextBoxColumn.Width = 75
        '
        'NameMabdaDataGridViewTextBoxColumn
        '
        Me.NameMabdaDataGridViewTextBoxColumn.DataPropertyName = "NameMabda"
        Me.NameMabdaDataGridViewTextBoxColumn.HeaderText = "مبداء"
        Me.NameMabdaDataGridViewTextBoxColumn.Name = "NameMabdaDataGridViewTextBoxColumn"
        Me.NameMabdaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameMabdaDataGridViewTextBoxColumn.Width = 91
        '
        'MaghsadIDDataGridViewTextBoxColumn
        '
        Me.MaghsadIDDataGridViewTextBoxColumn.DataPropertyName = "MaghsadID"
        Me.MaghsadIDDataGridViewTextBoxColumn.HeaderText = "MaghsadID"
        Me.MaghsadIDDataGridViewTextBoxColumn.Name = "MaghsadIDDataGridViewTextBoxColumn"
        Me.MaghsadIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MaghsadIDDataGridViewTextBoxColumn.Visible = False
        Me.MaghsadIDDataGridViewTextBoxColumn.Width = 86
        '
        'NameMaghsadDataGridViewTextBoxColumn
        '
        Me.NameMaghsadDataGridViewTextBoxColumn.DataPropertyName = "NameMaghsad"
        Me.NameMaghsadDataGridViewTextBoxColumn.HeaderText = "مقصد"
        Me.NameMaghsadDataGridViewTextBoxColumn.Name = "NameMaghsadDataGridViewTextBoxColumn"
        Me.NameMaghsadDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameMaghsadDataGridViewTextBoxColumn.Width = 102
        '
        'TarikhKhoroojMojtameDataGridViewTextBoxColumn
        '
        Me.TarikhKhoroojMojtameDataGridViewTextBoxColumn.DataPropertyName = "TarikhKhoroojMojtame"
        Me.TarikhKhoroojMojtameDataGridViewTextBoxColumn.HeaderText = "تاریخ خروج"
        Me.TarikhKhoroojMojtameDataGridViewTextBoxColumn.Name = "TarikhKhoroojMojtameDataGridViewTextBoxColumn"
        Me.TarikhKhoroojMojtameDataGridViewTextBoxColumn.ReadOnly = True
        Me.TarikhKhoroojMojtameDataGridViewTextBoxColumn.Width = 139
        '
        'TarikhVoroodMojtameDataGridViewTextBoxColumn
        '
        Me.TarikhVoroodMojtameDataGridViewTextBoxColumn.DataPropertyName = "TarikhVoroodMojtame"
        Me.TarikhVoroodMojtameDataGridViewTextBoxColumn.HeaderText = "تاریخ ورود"
        Me.TarikhVoroodMojtameDataGridViewTextBoxColumn.Name = "TarikhVoroodMojtameDataGridViewTextBoxColumn"
        Me.TarikhVoroodMojtameDataGridViewTextBoxColumn.ReadOnly = True
        Me.TarikhVoroodMojtameDataGridViewTextBoxColumn.Width = 136
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "مبلغ سند"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalDataGridViewTextBoxColumn.Width = 56
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "OperationCode"
        Me.Column1.HeaderText = "چاپ سند"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Text = "چاپ..."
        Me.Column1.UseColumnTextForButtonValue = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "ویرایش سند"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Text = "ویرایش..."
        Me.Column2.UseColumnTextForButtonValue = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "حذف سند"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Text = "حذف..."
        Me.Column3.UseColumnTextForButtonValue = True
        '
        'frmSanadList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(950, 559)
        Me.Controls.Add(Me.dgvSanadList)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.MaximizeBox = True
        Me.Name = "frmSanadList"
        Me.Text = "لیست اسناد"
        CType(Me.VSanadListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VSelectRanandeganMashinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMaghsadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMabdaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSanadList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbFilterType As System.Windows.Forms.ComboBox
    Friend WithEvents txtFilter As Tarabari.AdvancedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFilterDate As Tarabari.AdvancedMaskedTextBox
    Friend WithEvents DsTarabari As Tarabari.dsTarabari
    Friend WithEvents VSanadListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VSanadListTableAdapter As Tarabari.dsTarabariTableAdapters.vSanadListTableAdapter
    Friend WithEvents cmbMaghsad As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMabda As System.Windows.Forms.ComboBox
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
    Friend WithEvents OperationCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RanandeFullNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RanandePersonalCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MashinIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PelakDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MabdaIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameMabdaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaghsadIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameMaghsadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TarikhKhoroojMojtameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TarikhVoroodMojtameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewButtonColumn

End Class
