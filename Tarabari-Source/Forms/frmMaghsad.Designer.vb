<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaghsad
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
        Me.txtMaghsad = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TblMaghsadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTarabari = New Tarabari.dsTarabari
        Me.Tbl_MaghsadTableAdapter = New Tarabari.dsTarabariTableAdapters.tbl_MaghsadTableAdapter
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX
        Me.btnSave = New DevComponents.DotNetBar.ButtonX
        Me.dgvMaghsadList = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.MaghsadIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameMaghsadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMaghsadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMaghsadList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.txtMaghsad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 98)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مبداء"
        '
        'txtMaghsad
        '
        Me.txtMaghsad.BorderColor = System.Drawing.Color.Empty
        Me.txtMaghsad.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMaghsad.InputMode = Tarabari.AdvancedTextBox.enInputMode.Normal
        Me.txtMaghsad.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtMaghsad.Location = New System.Drawing.Point(223, 43)
        Me.txtMaghsad.Name = "txtMaghsad"
        Me.txtMaghsad.NextControl = Nothing
        Me.txtMaghsad.PrevControl = Nothing
        Me.txtMaghsad.Size = New System.Drawing.Size(155, 21)
        Me.txtMaghsad.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(384, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "نام مقصد :"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.RightToLeft = True
        '
        'TblMaghsadBindingSource
        '
        Me.TblMaghsadBindingSource.DataMember = "tbl_Maghsad"
        Me.TblMaghsadBindingSource.DataSource = Me.DsTarabari
        '
        'DsTarabari
        '
        Me.DsTarabari.DataSetName = "dsTarabari"
        Me.DsTarabari.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_MaghsadTableAdapter
        '
        Me.Tbl_MaghsadTableAdapter.ClearBeforeFill = True
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = Global.Tarabari.My.Resources.Resources.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(17, 36)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(92, 31)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "انصراف"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Image = Global.Tarabari.My.Resources.Resources.Save
        Me.btnSave.Location = New System.Drawing.Point(124, 36)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 31)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "ذخیره"
        '
        'dgvMaghsadList
        '
        Me.dgvMaghsadList.AllowUserToAddRows = False
        Me.dgvMaghsadList.AllowUserToDeleteRows = False
        Me.dgvMaghsadList.AllowUserToResizeColumns = False
        Me.dgvMaghsadList.AllowUserToResizeRows = False
        Me.dgvMaghsadList.AutoGenerateColumns = False
        Me.dgvMaghsadList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMaghsadList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMaghsadList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvMaghsadList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaghsadIDDataGridViewTextBoxColumn, Me.Column2, Me.NameMaghsadDataGridViewTextBoxColumn, Me.Column1})
        Me.dgvMaghsadList.DataSource = Me.TblMaghsadBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMaghsadList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMaghsadList.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvMaghsadList.Location = New System.Drawing.Point(17, 134)
        Me.dgvMaghsadList.MultiSelect = False
        Me.dgvMaghsadList.Name = "dgvMaghsadList"
        Me.dgvMaghsadList.ReadOnly = True
        Me.dgvMaghsadList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvMaghsadList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMaghsadList.Size = New System.Drawing.Size(449, 173)
        Me.dgvMaghsadList.TabIndex = 7
        '
        'MaghsadIDDataGridViewTextBoxColumn
        '
        Me.MaghsadIDDataGridViewTextBoxColumn.DataPropertyName = "MaghsadID"
        Me.MaghsadIDDataGridViewTextBoxColumn.HeaderText = "MaghsadID"
        Me.MaghsadIDDataGridViewTextBoxColumn.Name = "MaghsadIDDataGridViewTextBoxColumn"
        Me.MaghsadIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MaghsadIDDataGridViewTextBoxColumn.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.HeaderText = "ردیف"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 80
        '
        'NameMaghsadDataGridViewTextBoxColumn
        '
        Me.NameMaghsadDataGridViewTextBoxColumn.DataPropertyName = "NameMaghsad"
        Me.NameMaghsadDataGridViewTextBoxColumn.HeaderText = "نام مقصد"
        Me.NameMaghsadDataGridViewTextBoxColumn.Name = "NameMaghsadDataGridViewTextBoxColumn"
        Me.NameMaghsadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = "حذف رکورد"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Text = "حذف..."
        Me.Column1.UseColumnTextForButtonValue = True
        Me.Column1.Width = 80
        '
        'frmMaghsad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(483, 319)
        Me.Controls.Add(Me.dgvMaghsadList)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "frmMaghsad"
        Me.Text = "اطلاعات مقصد ها"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMaghsadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMaghsadList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMaghsad As Tarabari.AdvancedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents DsTarabari As Tarabari.dsTarabari
    Friend WithEvents TblMaghsadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MaghsadTableAdapter As Tarabari.dsTarabariTableAdapters.tbl_MaghsadTableAdapter
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgvMaghsadList As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents MaghsadIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameMaghsadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn

End Class
