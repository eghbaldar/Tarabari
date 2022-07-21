<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMahalBargiri
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
        Me.txtMahalBargiri = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.TblMahalBargiriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTarabari = New Tarabari.dsTarabari
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Tbl_MahalBargiriTableAdapter = New Tarabari.dsTarabariTableAdapters.tbl_MahalBargiriTableAdapter
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX
        Me.btnSave = New DevComponents.DotNetBar.ButtonX
        Me.dgvMahalBargiriList = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.MahalBargiriIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameMahalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.TblMahalBargiriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMahalBargiriList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.txtMahalBargiri)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 98)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "محل بارگیری"
        '
        'txtMahalBargiri
        '
        Me.txtMahalBargiri.BorderColor = System.Drawing.Color.Empty
        Me.txtMahalBargiri.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMahalBargiri.InputMode = Tarabari.AdvancedTextBox.enInputMode.Normal
        Me.txtMahalBargiri.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtMahalBargiri.Location = New System.Drawing.Point(228, 43)
        Me.txtMahalBargiri.Name = "txtMahalBargiri"
        Me.txtMahalBargiri.NextControl = Nothing
        Me.txtMahalBargiri.PrevControl = Nothing
        Me.txtMahalBargiri.Size = New System.Drawing.Size(155, 21)
        Me.txtMahalBargiri.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(389, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "نام محل :"
        '
        'TblMahalBargiriBindingSource
        '
        Me.TblMahalBargiriBindingSource.DataMember = "tbl_MahalBargiri"
        Me.TblMahalBargiriBindingSource.DataSource = Me.DsTarabari
        '
        'DsTarabari
        '
        Me.DsTarabari.DataSetName = "dsTarabari"
        Me.DsTarabari.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.RightToLeft = True
        '
        'Tbl_MahalBargiriTableAdapter
        '
        Me.Tbl_MahalBargiriTableAdapter.ClearBeforeFill = True
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = Global.Tarabari.My.Resources.Resources.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(19, 36)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(92, 31)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "انصراف"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Image = Global.Tarabari.My.Resources.Resources.Save
        Me.btnSave.Location = New System.Drawing.Point(126, 36)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 31)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "ذخیره"
        '
        'dgvMahalBargiriList
        '
        Me.dgvMahalBargiriList.AllowUserToAddRows = False
        Me.dgvMahalBargiriList.AllowUserToDeleteRows = False
        Me.dgvMahalBargiriList.AllowUserToResizeColumns = False
        Me.dgvMahalBargiriList.AllowUserToResizeRows = False
        Me.dgvMahalBargiriList.AutoGenerateColumns = False
        Me.dgvMahalBargiriList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMahalBargiriList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMahalBargiriList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvMahalBargiriList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MahalBargiriIDDataGridViewTextBoxColumn, Me.Column2, Me.NameMahalDataGridViewTextBoxColumn, Me.Column1})
        Me.dgvMahalBargiriList.DataSource = Me.TblMahalBargiriBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMahalBargiriList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMahalBargiriList.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvMahalBargiriList.Location = New System.Drawing.Point(16, 130)
        Me.dgvMahalBargiriList.MultiSelect = False
        Me.dgvMahalBargiriList.Name = "dgvMahalBargiriList"
        Me.dgvMahalBargiriList.ReadOnly = True
        Me.dgvMahalBargiriList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvMahalBargiriList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMahalBargiriList.Size = New System.Drawing.Size(449, 173)
        Me.dgvMahalBargiriList.TabIndex = 8
        '
        'MahalBargiriIDDataGridViewTextBoxColumn
        '
        Me.MahalBargiriIDDataGridViewTextBoxColumn.DataPropertyName = "MahalBargiriID"
        Me.MahalBargiriIDDataGridViewTextBoxColumn.HeaderText = "MahalBargiriID"
        Me.MahalBargiriIDDataGridViewTextBoxColumn.Name = "MahalBargiriIDDataGridViewTextBoxColumn"
        Me.MahalBargiriIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MahalBargiriIDDataGridViewTextBoxColumn.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.HeaderText = "ردیف"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 80
        '
        'NameMahalDataGridViewTextBoxColumn
        '
        Me.NameMahalDataGridViewTextBoxColumn.DataPropertyName = "NameMahal"
        Me.NameMahalDataGridViewTextBoxColumn.HeaderText = "نام محل بارگیری"
        Me.NameMahalDataGridViewTextBoxColumn.Name = "NameMahalDataGridViewTextBoxColumn"
        Me.NameMahalDataGridViewTextBoxColumn.ReadOnly = True
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
        'frmMahalBargiri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(483, 319)
        Me.Controls.Add(Me.dgvMahalBargiriList)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "frmMahalBargiri"
        Me.Text = "اطلاعات محل بارگیری"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TblMahalBargiriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMahalBargiriList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMahalBargiri As Tarabari.AdvancedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents DsTarabari As Tarabari.dsTarabari
    Friend WithEvents TblMahalBargiriBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MahalBargiriTableAdapter As Tarabari.dsTarabariTableAdapters.tbl_MahalBargiriTableAdapter
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgvMahalBargiriList As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents MahalBargiriIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameMahalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn

End Class
