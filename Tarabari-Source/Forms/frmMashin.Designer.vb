﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMashin
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
        Me.txtMotorNumber = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtShasiNumber = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbKafi = New System.Windows.Forms.ComboBox
        Me.TblKafiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTarabari = New Tarabari.dsTarabari
        Me.txtPelak = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMashinID = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.TblMashinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_MashinTableAdapter = New Tarabari.dsTarabariTableAdapters.tbl_MashinTableAdapter
        Me.Tbl_KafiTableAdapter = New Tarabari.dsTarabariTableAdapters.tbl_KafiTableAdapter
        Me.dgvMashinList = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.MashinIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KafiIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PelakDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShasiNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MotorNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn
        Me.ErrorPelak = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorCodeKafi = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.TblKafiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMashinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMashinList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorPelak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorCodeKafi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.txtMotorNumber)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtShasiNumber)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbKafi)
        Me.GroupBox1.Controls.Add(Me.txtPelak)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMashinID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(625, 264)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ماشین"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = Global.Tarabari.My.Resources.Resources.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(211, 211)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(92, 31)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "انصراف"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Image = Global.Tarabari.My.Resources.Resources.Save
        Me.btnSave.Location = New System.Drawing.Point(340, 211)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 31)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "ذخیره"
        '
        'txtMotorNumber
        '
        Me.txtMotorNumber.BorderColor = System.Drawing.Color.Empty
        Me.txtMotorNumber.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMotorNumber.InputMode = Tarabari.AdvancedTextBox.enInputMode.Number
        Me.txtMotorNumber.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtMotorNumber.Location = New System.Drawing.Point(144, 155)
        Me.txtMotorNumber.MaxLength = 20
        Me.txtMotorNumber.Name = "txtMotorNumber"
        Me.txtMotorNumber.NextControl = Nothing
        Me.txtMotorNumber.PrevControl = Nothing
        Me.txtMotorNumber.Size = New System.Drawing.Size(125, 21)
        Me.txtMotorNumber.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(275, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "شماره موتور :"
        '
        'txtShasiNumber
        '
        Me.txtShasiNumber.BorderColor = System.Drawing.Color.Empty
        Me.txtShasiNumber.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtShasiNumber.InputMode = Tarabari.AdvancedTextBox.enInputMode.Number
        Me.txtShasiNumber.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtShasiNumber.Location = New System.Drawing.Point(372, 155)
        Me.txtShasiNumber.MaxLength = 20
        Me.txtShasiNumber.Name = "txtShasiNumber"
        Me.txtShasiNumber.NextControl = Nothing
        Me.txtShasiNumber.PrevControl = Nothing
        Me.txtShasiNumber.Size = New System.Drawing.Size(125, 21)
        Me.txtShasiNumber.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(503, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "شماره شاسی :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(507, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "کد کفی :"
        '
        'cmbKafi
        '
        Me.cmbKafi.DataSource = Me.TblKafiBindingSource
        Me.cmbKafi.DisplayMember = "KafiID"
        Me.cmbKafi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKafi.FormattingEnabled = True
        Me.cmbKafi.Location = New System.Drawing.Point(439, 75)
        Me.cmbKafi.Name = "cmbKafi"
        Me.cmbKafi.Size = New System.Drawing.Size(58, 21)
        Me.cmbKafi.TabIndex = 1
        Me.cmbKafi.ValueMember = "KafiID"
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
        'txtPelak
        '
        Me.txtPelak.BorderColor = System.Drawing.Color.Empty
        Me.txtPelak.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPelak.InputMode = Tarabari.AdvancedTextBox.enInputMode.Number
        Me.txtPelak.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtPelak.Location = New System.Drawing.Point(372, 116)
        Me.txtPelak.MaxLength = 10
        Me.txtPelak.Name = "txtPelak"
        Me.txtPelak.NextControl = Nothing
        Me.txtPelak.PrevControl = Nothing
        Me.txtPelak.Size = New System.Drawing.Size(125, 21)
        Me.txtPelak.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(503, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "شماره انتظامی :"
        '
        'txtMashinID
        '
        Me.txtMashinID.BorderColor = System.Drawing.Color.Empty
        Me.txtMashinID.Enabled = False
        Me.txtMashinID.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMashinID.InputMode = Tarabari.AdvancedTextBox.enInputMode.Normal
        Me.txtMashinID.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtMashinID.Location = New System.Drawing.Point(439, 38)
        Me.txtMashinID.MaxLength = 4
        Me.txtMashinID.Name = "txtMashinID"
        Me.txtMashinID.NextControl = Nothing
        Me.txtMashinID.PrevControl = Nothing
        Me.txtMashinID.Size = New System.Drawing.Size(58, 21)
        Me.txtMashinID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(503, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "کد تریلی :"
        '
        'TblMashinBindingSource
        '
        Me.TblMashinBindingSource.DataMember = "tbl_Mashin"
        Me.TblMashinBindingSource.DataSource = Me.DsTarabari
        '
        'Tbl_MashinTableAdapter
        '
        Me.Tbl_MashinTableAdapter.ClearBeforeFill = True
        '
        'Tbl_KafiTableAdapter
        '
        Me.Tbl_KafiTableAdapter.ClearBeforeFill = True
        '
        'dgvMashinList
        '
        Me.dgvMashinList.AllowUserToAddRows = False
        Me.dgvMashinList.AllowUserToDeleteRows = False
        Me.dgvMashinList.AllowUserToResizeColumns = False
        Me.dgvMashinList.AllowUserToResizeRows = False
        Me.dgvMashinList.AutoGenerateColumns = False
        Me.dgvMashinList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMashinList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMashinList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvMashinList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MashinIDDataGridViewTextBoxColumn, Me.KafiIDDataGridViewTextBoxColumn, Me.PelakDataGridViewTextBoxColumn, Me.ShasiNumberDataGridViewTextBoxColumn, Me.MotorNumberDataGridViewTextBoxColumn, Me.Column1})
        Me.dgvMashinList.DataSource = Me.TblMashinBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMashinList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMashinList.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvMashinList.Location = New System.Drawing.Point(17, 291)
        Me.dgvMashinList.MultiSelect = False
        Me.dgvMashinList.Name = "dgvMashinList"
        Me.dgvMashinList.ReadOnly = True
        Me.dgvMashinList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvMashinList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMashinList.Size = New System.Drawing.Size(625, 190)
        Me.dgvMashinList.TabIndex = 1
        '
        'MashinIDDataGridViewTextBoxColumn
        '
        Me.MashinIDDataGridViewTextBoxColumn.DataPropertyName = "MashinID"
        Me.MashinIDDataGridViewTextBoxColumn.HeaderText = "کد تریلی"
        Me.MashinIDDataGridViewTextBoxColumn.Name = "MashinIDDataGridViewTextBoxColumn"
        Me.MashinIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KafiIDDataGridViewTextBoxColumn
        '
        Me.KafiIDDataGridViewTextBoxColumn.DataPropertyName = "KafiID"
        Me.KafiIDDataGridViewTextBoxColumn.HeaderText = "شماره کفی"
        Me.KafiIDDataGridViewTextBoxColumn.Name = "KafiIDDataGridViewTextBoxColumn"
        Me.KafiIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PelakDataGridViewTextBoxColumn
        '
        Me.PelakDataGridViewTextBoxColumn.DataPropertyName = "Pelak"
        Me.PelakDataGridViewTextBoxColumn.HeaderText = "پلاک"
        Me.PelakDataGridViewTextBoxColumn.Name = "PelakDataGridViewTextBoxColumn"
        Me.PelakDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ShasiNumberDataGridViewTextBoxColumn
        '
        Me.ShasiNumberDataGridViewTextBoxColumn.DataPropertyName = "ShasiNumber"
        Me.ShasiNumberDataGridViewTextBoxColumn.HeaderText = "شماره شاسی"
        Me.ShasiNumberDataGridViewTextBoxColumn.Name = "ShasiNumberDataGridViewTextBoxColumn"
        Me.ShasiNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MotorNumberDataGridViewTextBoxColumn
        '
        Me.MotorNumberDataGridViewTextBoxColumn.DataPropertyName = "MotorNumber"
        Me.MotorNumberDataGridViewTextBoxColumn.HeaderText = "شماره موتور"
        Me.MotorNumberDataGridViewTextBoxColumn.Name = "MotorNumberDataGridViewTextBoxColumn"
        Me.MotorNumberDataGridViewTextBoxColumn.ReadOnly = True
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
        'ErrorPelak
        '
        Me.ErrorPelak.ContainerControl = Me
        Me.ErrorPelak.RightToLeft = True
        '
        'ErrorCodeKafi
        '
        Me.ErrorCodeKafi.ContainerControl = Me
        Me.ErrorCodeKafi.RightToLeft = True
        '
        'frmMashin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(657, 493)
        Me.Controls.Add(Me.dgvMashinList)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "frmMashin"
        Me.Text = "اطلاعات ماشن ها"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TblKafiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMashinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMashinList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorPelak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorCodeKafi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMashinID As Tarabari.AdvancedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPelak As Tarabari.AdvancedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DsTarabari As Tarabari.dsTarabari
    Friend WithEvents TblMashinBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MashinTableAdapter As Tarabari.dsTarabariTableAdapters.tbl_MashinTableAdapter
    Friend WithEvents cmbKafi As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TblKafiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_KafiTableAdapter As Tarabari.dsTarabariTableAdapters.tbl_KafiTableAdapter
    Friend WithEvents txtMotorNumber As Tarabari.AdvancedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtShasiNumber As Tarabari.AdvancedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgvMashinList As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents MashinIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KafiIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PelakDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShasiNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MotorNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ErrorPelak As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorCodeKafi As System.Windows.Forms.ErrorProvider

End Class
