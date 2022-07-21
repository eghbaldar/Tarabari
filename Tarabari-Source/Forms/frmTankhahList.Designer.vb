<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTankhahList
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
        Me.TblTankhahBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTarabari = New Tarabari.dsTarabari
        Me.Tbl_TankhahTableAdapter = New Tarabari.dsTarabariTableAdapters.tbl_TankhahTableAdapter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnRemoveFilter = New DevComponents.DotNetBar.ButtonX
        Me.btnFilter = New DevComponents.DotNetBar.ButtonX
        Me.txtFilterDate = New Tarabari.AdvancedMaskedTextBox(Me.components)
        Me.cmbFilterType = New System.Windows.Forms.ComboBox
        Me.txtFilter = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.dgvTankhahList = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.TankhahIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TankhahSanadIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VajheDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewButtonColumn
        CType(Me.TblTankhahBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvTankhahList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblTankhahBindingSource
        '
        Me.TblTankhahBindingSource.DataMember = "tbl_Tankhah"
        Me.TblTankhahBindingSource.DataSource = Me.DsTarabari
        '
        'DsTarabari
        '
        Me.DsTarabari.DataSetName = "dsTarabari"
        Me.DsTarabari.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_TankhahTableAdapter
        '
        Me.Tbl_TankhahTableAdapter.ClearBeforeFill = True
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(764, 101)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "فیلتر"
        '
        'btnRemoveFilter
        '
        Me.btnRemoveFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRemoveFilter.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnRemoveFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRemoveFilter.Image = Global.Tarabari.My.Resources.Resources.RemoveFilter
        Me.btnRemoveFilter.Location = New System.Drawing.Point(184, 37)
        Me.btnRemoveFilter.Name = "btnRemoveFilter"
        Me.btnRemoveFilter.Size = New System.Drawing.Size(87, 31)
        Me.btnRemoveFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRemoveFilter.TabIndex = 21
        Me.btnRemoveFilter.Text = "لغو فیلتر"
        '
        'btnFilter
        '
        Me.btnFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFilter.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnFilter.Image = Global.Tarabari.My.Resources.Resources.Filter
        Me.btnFilter.Location = New System.Drawing.Point(296, 37)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(87, 31)
        Me.btnFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnFilter.TabIndex = 20
        Me.btnFilter.Text = "فیلتر"
        '
        'txtFilterDate
        '
        Me.txtFilterDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilterDate.BorderColor = System.Drawing.Color.Empty
        Me.txtFilterDate.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFilterDate.Location = New System.Drawing.Point(440, 44)
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
        Me.cmbFilterType.Items.AddRange(New Object() {"شماره سند", "تاریخ"})
        Me.cmbFilterType.Location = New System.Drawing.Point(540, 44)
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
        Me.txtFilter.Location = New System.Drawing.Point(405, 44)
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
        Me.Label8.Location = New System.Drawing.Point(667, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "فیلتر بر اساس :"
        '
        'dgvTankhahList
        '
        Me.dgvTankhahList.AllowUserToAddRows = False
        Me.dgvTankhahList.AllowUserToDeleteRows = False
        Me.dgvTankhahList.AllowUserToResizeColumns = False
        Me.dgvTankhahList.AllowUserToResizeRows = False
        Me.dgvTankhahList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTankhahList.AutoGenerateColumns = False
        Me.dgvTankhahList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTankhahList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTankhahList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvTankhahList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TankhahIDDataGridViewTextBoxColumn, Me.TankhahSanadIDDataGridViewTextBoxColumn, Me.PDateDataGridViewTextBoxColumn, Me.VajheDataGridViewTextBoxColumn, Me.TotalValueDataGridViewTextBoxColumn, Me.Column1, Me.Column2, Me.Column3})
        Me.dgvTankhahList.DataSource = Me.TblTankhahBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTankhahList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTankhahList.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvTankhahList.Location = New System.Drawing.Point(12, 132)
        Me.dgvTankhahList.MultiSelect = False
        Me.dgvTankhahList.Name = "dgvTankhahList"
        Me.dgvTankhahList.ReadOnly = True
        Me.dgvTankhahList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvTankhahList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTankhahList.Size = New System.Drawing.Size(764, 360)
        Me.dgvTankhahList.TabIndex = 11
        '
        'TankhahIDDataGridViewTextBoxColumn
        '
        Me.TankhahIDDataGridViewTextBoxColumn.DataPropertyName = "TankhahID"
        Me.TankhahIDDataGridViewTextBoxColumn.HeaderText = "شماره سند تنخواه"
        Me.TankhahIDDataGridViewTextBoxColumn.Name = "TankhahIDDataGridViewTextBoxColumn"
        Me.TankhahIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TankhahSanadIDDataGridViewTextBoxColumn
        '
        Me.TankhahSanadIDDataGridViewTextBoxColumn.DataPropertyName = "TankhahSanadID"
        Me.TankhahSanadIDDataGridViewTextBoxColumn.HeaderText = "شماره سریال سند تنخواه"
        Me.TankhahSanadIDDataGridViewTextBoxColumn.Name = "TankhahSanadIDDataGridViewTextBoxColumn"
        Me.TankhahSanadIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PDateDataGridViewTextBoxColumn
        '
        Me.PDateDataGridViewTextBoxColumn.DataPropertyName = "pDate"
        Me.PDateDataGridViewTextBoxColumn.HeaderText = "تاریخ"
        Me.PDateDataGridViewTextBoxColumn.Name = "PDateDataGridViewTextBoxColumn"
        Me.PDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VajheDataGridViewTextBoxColumn
        '
        Me.VajheDataGridViewTextBoxColumn.DataPropertyName = "Vajhe"
        Me.VajheDataGridViewTextBoxColumn.HeaderText = "در وجه"
        Me.VajheDataGridViewTextBoxColumn.Name = "VajheDataGridViewTextBoxColumn"
        Me.VajheDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalValueDataGridViewTextBoxColumn
        '
        Me.TotalValueDataGridViewTextBoxColumn.DataPropertyName = "TotalValue"
        Me.TotalValueDataGridViewTextBoxColumn.HeaderText = "مبلغ سند"
        Me.TotalValueDataGridViewTextBoxColumn.Name = "TotalValueDataGridViewTextBoxColumn"
        Me.TotalValueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "ویرایش سند"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Text = "ویرایش..."
        Me.Column1.UseColumnTextForButtonValue = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "مشاهده سند"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Text = "مشاهده..."
        Me.Column2.UseColumnTextForButtonValue = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "چاپ سند"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Text = "چاپ..."
        Me.Column3.UseColumnTextForButtonValue = True
        '
        'frmTankhahList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(788, 504)
        Me.Controls.Add(Me.dgvTankhahList)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmTankhahList"
        Me.Text = "لیست اسناد تنخواه"
        CType(Me.TblTankhahBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvTankhahList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DsTarabari As Tarabari.dsTarabari
    Friend WithEvents TblTankhahBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_TankhahTableAdapter As Tarabari.dsTarabariTableAdapters.tbl_TankhahTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFilterDate As Tarabari.AdvancedMaskedTextBox
    Friend WithEvents cmbFilterType As System.Windows.Forms.ComboBox
    Friend WithEvents txtFilter As Tarabari.AdvancedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnRemoveFilter As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnFilter As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgvTankhahList As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TankhahIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TankhahSanadIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VajheDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewButtonColumn

End Class
