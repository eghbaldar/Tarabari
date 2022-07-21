<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKafi
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
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX
        Me.btnSave = New DevComponents.DotNetBar.ButtonX
        Me.txtShasi = New Tarabari.AdvancedTextBox(Me.components)
        Me.txtPelak = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtKafiID = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.ErrorPelak = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TblKafiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTarabari = New Tarabari.dsTarabari
        Me.ErrorShasi = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Tbl_KafiTableAdapter = New Tarabari.dsTarabariTableAdapters.tbl_KafiTableAdapter
        Me.dgvKafiList = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.KafiIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShasiNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PelakDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorPelak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblKafiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorShasi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvKafiList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.txtShasi)
        Me.GroupBox1.Controls.Add(Me.txtPelak)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtKafiID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(513, 201)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "کفی"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = Global.Tarabari.My.Resources.Resources.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(145, 149)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 31)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "انصراف"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Image = Global.Tarabari.My.Resources.Resources.Save
        Me.btnSave.Location = New System.Drawing.Point(282, 149)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 31)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "ذخیره"
        '
        'txtShasi
        '
        Me.txtShasi.BorderColor = System.Drawing.Color.Empty
        Me.txtShasi.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtShasi.InputMode = Tarabari.AdvancedTextBox.enInputMode.Number
        Me.txtShasi.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtShasi.Location = New System.Drawing.Point(266, 87)
        Me.txtShasi.MaxLength = 20
        Me.txtShasi.Name = "txtShasi"
        Me.txtShasi.NextControl = Nothing
        Me.txtShasi.PrevControl = Nothing
        Me.txtShasi.Size = New System.Drawing.Size(125, 21)
        Me.txtShasi.TabIndex = 1
        '
        'txtPelak
        '
        Me.txtPelak.BorderColor = System.Drawing.Color.Empty
        Me.txtPelak.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPelak.InputMode = Tarabari.AdvancedTextBox.enInputMode.Number
        Me.txtPelak.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtPelak.Location = New System.Drawing.Point(34, 87)
        Me.txtPelak.MaxLength = 20
        Me.txtPelak.Name = "txtPelak"
        Me.txtPelak.NextControl = Nothing
        Me.txtPelak.PrevControl = Nothing
        Me.txtPelak.Size = New System.Drawing.Size(125, 21)
        Me.txtPelak.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(397, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "شماره شاسی :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(165, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "شماره انتظامی :"
        '
        'txtKafiID
        '
        Me.txtKafiID.BorderColor = System.Drawing.Color.Empty
        Me.txtKafiID.Enabled = False
        Me.txtKafiID.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKafiID.InputMode = Tarabari.AdvancedTextBox.enInputMode.Normal
        Me.txtKafiID.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtKafiID.Location = New System.Drawing.Point(333, 41)
        Me.txtKafiID.MaxLength = 4
        Me.txtKafiID.Name = "txtKafiID"
        Me.txtKafiID.NextControl = Nothing
        Me.txtKafiID.PrevControl = Nothing
        Me.txtKafiID.Size = New System.Drawing.Size(58, 21)
        Me.txtKafiID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(397, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " کد کفی :"
        '
        'ErrorPelak
        '
        Me.ErrorPelak.ContainerControl = Me
        Me.ErrorPelak.RightToLeft = True
        '
        'TblKafiBindingSource
        '
        Me.TblKafiBindingSource.DataMember = "tbl_Kafi"
        Me.TblKafiBindingSource.DataSource = Me.DsTarabari
        '
        'DsTarabari
        '
        Me.DsTarabari.DataSetName = "dsTarabari"
        Me.DsTarabari.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ErrorShasi
        '
        Me.ErrorShasi.ContainerControl = Me
        Me.ErrorShasi.RightToLeft = True
        '
        'Tbl_KafiTableAdapter
        '
        Me.Tbl_KafiTableAdapter.ClearBeforeFill = True
        '
        'dgvKafiList
        '
        Me.dgvKafiList.AllowUserToAddRows = False
        Me.dgvKafiList.AllowUserToDeleteRows = False
        Me.dgvKafiList.AllowUserToResizeColumns = False
        Me.dgvKafiList.AllowUserToResizeRows = False
        Me.dgvKafiList.AutoGenerateColumns = False
        Me.dgvKafiList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvKafiList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvKafiList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvKafiList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KafiIDDataGridViewTextBoxColumn, Me.ShasiNumberDataGridViewTextBoxColumn, Me.PelakDataGridViewTextBoxColumn, Me.Column1})
        Me.dgvKafiList.DataSource = Me.TblKafiBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvKafiList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvKafiList.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvKafiList.Location = New System.Drawing.Point(17, 236)
        Me.dgvKafiList.MultiSelect = False
        Me.dgvKafiList.Name = "dgvKafiList"
        Me.dgvKafiList.ReadOnly = True
        Me.dgvKafiList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvKafiList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvKafiList.Size = New System.Drawing.Size(513, 189)
        Me.dgvKafiList.TabIndex = 5
        '
        'KafiIDDataGridViewTextBoxColumn
        '
        Me.KafiIDDataGridViewTextBoxColumn.DataPropertyName = "KafiID"
        Me.KafiIDDataGridViewTextBoxColumn.HeaderText = "شماره کفی"
        Me.KafiIDDataGridViewTextBoxColumn.Name = "KafiIDDataGridViewTextBoxColumn"
        Me.KafiIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ShasiNumberDataGridViewTextBoxColumn
        '
        Me.ShasiNumberDataGridViewTextBoxColumn.DataPropertyName = "ShasiNumber"
        Me.ShasiNumberDataGridViewTextBoxColumn.HeaderText = "شماره شاسی"
        Me.ShasiNumberDataGridViewTextBoxColumn.Name = "ShasiNumberDataGridViewTextBoxColumn"
        Me.ShasiNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PelakDataGridViewTextBoxColumn
        '
        Me.PelakDataGridViewTextBoxColumn.DataPropertyName = "Pelak"
        Me.PelakDataGridViewTextBoxColumn.HeaderText = "پلاک"
        Me.PelakDataGridViewTextBoxColumn.Name = "PelakDataGridViewTextBoxColumn"
        Me.PelakDataGridViewTextBoxColumn.ReadOnly = True
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
        'frmKafi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(549, 437)
        Me.Controls.Add(Me.dgvKafiList)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "frmKafi"
        Me.Text = "اطلاعات کفی ها"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorPelak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblKafiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorShasi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvKafiList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtKafiID As Tarabari.AdvancedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorPelak As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtPelak As Tarabari.AdvancedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtShasi As Tarabari.AdvancedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ErrorShasi As System.Windows.Forms.ErrorProvider
    Friend WithEvents DsTarabari As Tarabari.dsTarabari
    Friend WithEvents TblKafiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_KafiTableAdapter As Tarabari.dsTarabariTableAdapters.tbl_KafiTableAdapter
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgvKafiList As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents KafiIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShasiNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PelakDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn

End Class
