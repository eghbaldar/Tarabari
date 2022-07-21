<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFactorList
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
        Me.txtFilterDate = New Tarabari.AdvancedMaskedTextBox(Me.components)
        Me.cmbFilterType = New System.Windows.Forms.ComboBox
        Me.txtFilter = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.dgvFactorList = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.VFactorListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTarabari = New Tarabari.dsTarabari
        Me.VFactorListTableAdapter = New Tarabari.dsTarabariTableAdapters.vFactorListTableAdapter
        Me.FactorIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RanandePersonalCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FullnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MashinIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvFactorList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VFactorListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnRemoveFilter)
        Me.GroupBox1.Controls.Add(Me.btnFilter)
        Me.GroupBox1.Controls.Add(Me.txtFilterDate)
        Me.GroupBox1.Controls.Add(Me.cmbFilterType)
        Me.GroupBox1.Controls.Add(Me.txtFilter)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(687, 101)
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
        Me.btnRemoveFilter.Location = New System.Drawing.Point(108, 38)
        Me.btnRemoveFilter.Name = "btnRemoveFilter"
        Me.btnRemoveFilter.Size = New System.Drawing.Size(87, 31)
        Me.btnRemoveFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRemoveFilter.TabIndex = 12
        Me.btnRemoveFilter.Text = "لغو فیلتر"
        '
        'btnFilter
        '
        Me.btnFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFilter.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnFilter.Image = Global.Tarabari.My.Resources.Resources.Filter
        Me.btnFilter.Location = New System.Drawing.Point(220, 38)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(87, 31)
        Me.btnFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnFilter.TabIndex = 11
        Me.btnFilter.Text = "فیلتر"
        '
        'txtFilterDate
        '
        Me.txtFilterDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilterDate.BorderColor = System.Drawing.Color.Empty
        Me.txtFilterDate.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFilterDate.Location = New System.Drawing.Point(363, 44)
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
        Me.cmbFilterType.Items.AddRange(New Object() {"شماره فاکتور", "تاریخ", "کد پرسنلی", "کد ماشین"})
        Me.cmbFilterType.Location = New System.Drawing.Point(463, 44)
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
        Me.txtFilter.Location = New System.Drawing.Point(328, 44)
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
        Me.Label8.Location = New System.Drawing.Point(590, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "فیلتر بر اساس :"
        '
        'dgvFactorList
        '
        Me.dgvFactorList.AllowUserToAddRows = False
        Me.dgvFactorList.AllowUserToDeleteRows = False
        Me.dgvFactorList.AllowUserToResizeColumns = False
        Me.dgvFactorList.AllowUserToResizeRows = False
        Me.dgvFactorList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvFactorList.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFactorList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFactorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvFactorList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FactorIDDataGridViewTextBoxColumn, Me.PDateDataGridViewTextBoxColumn, Me.RanandePersonalCodeDataGridViewTextBoxColumn, Me.FullnameDataGridViewTextBoxColumn, Me.MashinIDDataGridViewTextBoxColumn, Me.SubTotalDataGridViewTextBoxColumn, Me.Column1, Me.Column2})
        Me.dgvFactorList.DataSource = Me.VFactorListBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFactorList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFactorList.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvFactorList.Location = New System.Drawing.Point(12, 128)
        Me.dgvFactorList.MultiSelect = False
        Me.dgvFactorList.Name = "dgvFactorList"
        Me.dgvFactorList.ReadOnly = True
        Me.dgvFactorList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvFactorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFactorList.Size = New System.Drawing.Size(687, 334)
        Me.dgvFactorList.TabIndex = 2
        '
        'VFactorListBindingSource
        '
        Me.VFactorListBindingSource.DataMember = "vFactorList"
        Me.VFactorListBindingSource.DataSource = Me.DsTarabari
        '
        'DsTarabari
        '
        Me.DsTarabari.DataSetName = "dsTarabari"
        Me.DsTarabari.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VFactorListTableAdapter
        '
        Me.VFactorListTableAdapter.ClearBeforeFill = True
        '
        'FactorIDDataGridViewTextBoxColumn
        '
        Me.FactorIDDataGridViewTextBoxColumn.DataPropertyName = "FactorID"
        Me.FactorIDDataGridViewTextBoxColumn.HeaderText = "شماره فاکتور"
        Me.FactorIDDataGridViewTextBoxColumn.Name = "FactorIDDataGridViewTextBoxColumn"
        Me.FactorIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PDateDataGridViewTextBoxColumn
        '
        Me.PDateDataGridViewTextBoxColumn.DataPropertyName = "pDate"
        Me.PDateDataGridViewTextBoxColumn.HeaderText = "تاریخ"
        Me.PDateDataGridViewTextBoxColumn.Name = "PDateDataGridViewTextBoxColumn"
        Me.PDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RanandePersonalCodeDataGridViewTextBoxColumn
        '
        Me.RanandePersonalCodeDataGridViewTextBoxColumn.DataPropertyName = "RanandePersonalCode"
        Me.RanandePersonalCodeDataGridViewTextBoxColumn.HeaderText = "کد پرسنلی"
        Me.RanandePersonalCodeDataGridViewTextBoxColumn.Name = "RanandePersonalCodeDataGridViewTextBoxColumn"
        Me.RanandePersonalCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FullnameDataGridViewTextBoxColumn
        '
        Me.FullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname"
        Me.FullnameDataGridViewTextBoxColumn.HeaderText = "نام و نام خانوادگی"
        Me.FullnameDataGridViewTextBoxColumn.Name = "FullnameDataGridViewTextBoxColumn"
        Me.FullnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MashinIDDataGridViewTextBoxColumn
        '
        Me.MashinIDDataGridViewTextBoxColumn.DataPropertyName = "MashinID"
        Me.MashinIDDataGridViewTextBoxColumn.HeaderText = "کد ماشین"
        Me.MashinIDDataGridViewTextBoxColumn.Name = "MashinIDDataGridViewTextBoxColumn"
        Me.MashinIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubTotalDataGridViewTextBoxColumn
        '
        Me.SubTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal"
        Me.SubTotalDataGridViewTextBoxColumn.HeaderText = "مبلغ کل فاکتور"
        Me.SubTotalDataGridViewTextBoxColumn.Name = "SubTotalDataGridViewTextBoxColumn"
        Me.SubTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "ویرایش رکورد"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Text = "ویرایش..."
        Me.Column1.UseColumnTextForButtonValue = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "حذف رکورد"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Text = "حذف..."
        Me.Column2.UseColumnTextForButtonValue = True
        '
        'frmFactorList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(711, 474)
        Me.Controls.Add(Me.dgvFactorList)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.MaximizeBox = True
        Me.Name = "frmFactorList"
        Me.Text = "لیست فاکتورها"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvFactorList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VFactorListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbFilterType As System.Windows.Forms.ComboBox
    Friend WithEvents txtFilter As Tarabari.AdvancedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFilterDate As Tarabari.AdvancedMaskedTextBox
    Friend WithEvents btnRemoveFilter As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnFilter As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgvFactorList As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DsTarabari As Tarabari.dsTarabari
    Friend WithEvents VFactorListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VFactorListTableAdapter As Tarabari.dsTarabariTableAdapters.vFactorListTableAdapter
    Friend WithEvents FactorIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RanandePersonalCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MashinIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewButtonColumn

End Class
