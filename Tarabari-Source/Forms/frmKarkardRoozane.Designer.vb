<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKarkardRoozane
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
        Me.btnExit = New DevComponents.DotNetBar.ButtonX
        Me.btnShowData = New DevComponents.DotNetBar.ButtonX
        Me.btnPrint = New DevComponents.DotNetBar.ButtonX
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDate = New Tarabari.AdvancedMaskedTextBox(Me.components)
        Me.UspKarkardeRoozane4ShowBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTarabari = New Tarabari.dsTarabari
        Me.Usp_KarkardeRoozane4ShowTableAdapter = New Tarabari.dsTarabariTableAdapters.usp_KarkardeRoozane4ShowTableAdapter
        Me.dgvkarkardeRoozane = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.OperationCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RanandePersonalCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RanandeFullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PelakDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameMabdaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameMaghsadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NoeBarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaatKhoroojMojtameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaatVoroodMojtameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VaziyatSafarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VaziyatBazgashtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VaziyatTamirgahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VaziyatRanandehDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.UspKarkardeRoozane4ShowBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvkarkardeRoozane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnShowData)
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(813, 93)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "فیلتر"
        '
        'btnExit
        '
        Me.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Image = Global.Tarabari.My.Resources.Resources._Exit
        Me.btnExit.Location = New System.Drawing.Point(299, 36)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 31)
        Me.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "خروج"
        '
        'btnShowData
        '
        Me.btnShowData.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnShowData.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnShowData.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnShowData.Image = Global.Tarabari.My.Resources.Resources.Show
        Me.btnShowData.Location = New System.Drawing.Point(545, 36)
        Me.btnShowData.Name = "btnShowData"
        Me.btnShowData.Size = New System.Drawing.Size(87, 31)
        Me.btnShowData.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnShowData.TabIndex = 1
        Me.btnShowData.Text = "نمایش"
        '
        'btnPrint
        '
        Me.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPrint.Image = Global.Tarabari.My.Resources.Resources.Print
        Me.btnPrint.Location = New System.Drawing.Point(423, 36)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(87, 31)
        Me.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "چاپ"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(753, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "تاریخ :"
        '
        'txtDate
        '
        Me.txtDate.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtDate.BorderColor = System.Drawing.Color.Empty
        Me.txtDate.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDate.Location = New System.Drawing.Point(664, 42)
        Me.txtDate.Mask = "0000/00/00"
        Me.txtDate.Name = "txtDate"
        Me.txtDate.NextControl = Nothing
        Me.txtDate.PrevControl = Nothing
        Me.txtDate.Size = New System.Drawing.Size(83, 21)
        Me.txtDate.TabIndex = 0
        '
        'UspKarkardeRoozane4ShowBindingSource
        '
        Me.UspKarkardeRoozane4ShowBindingSource.DataMember = "usp_KarkardeRoozane4Show"
        Me.UspKarkardeRoozane4ShowBindingSource.DataSource = Me.DsTarabari
        '
        'DsTarabari
        '
        Me.DsTarabari.DataSetName = "dsTarabari"
        Me.DsTarabari.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Usp_KarkardeRoozane4ShowTableAdapter
        '
        Me.Usp_KarkardeRoozane4ShowTableAdapter.ClearBeforeFill = True
        '
        'dgvkarkardeRoozane
        '
        Me.dgvkarkardeRoozane.AllowUserToAddRows = False
        Me.dgvkarkardeRoozane.AllowUserToDeleteRows = False
        Me.dgvkarkardeRoozane.AllowUserToResizeColumns = False
        Me.dgvkarkardeRoozane.AllowUserToResizeRows = False
        Me.dgvkarkardeRoozane.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvkarkardeRoozane.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvkarkardeRoozane.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvkarkardeRoozane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvkarkardeRoozane.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OperationCodeDataGridViewTextBoxColumn, Me.RanandePersonalCodeDataGridViewTextBoxColumn, Me.RanandeFullNameDataGridViewTextBoxColumn, Me.PelakDataGridViewTextBoxColumn, Me.NameMabdaDataGridViewTextBoxColumn, Me.NameMaghsadDataGridViewTextBoxColumn, Me.NoeBarDataGridViewTextBoxColumn, Me.SaatKhoroojMojtameDataGridViewTextBoxColumn, Me.SaatVoroodMojtameDataGridViewTextBoxColumn, Me.PDateDataGridViewTextBoxColumn, Me.VaziyatSafarDataGridViewTextBoxColumn, Me.VaziyatBazgashtDataGridViewTextBoxColumn, Me.VaziyatTamirgahDataGridViewTextBoxColumn, Me.VaziyatRanandehDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn})
        Me.dgvkarkardeRoozane.DataSource = Me.UspKarkardeRoozane4ShowBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvkarkardeRoozane.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvkarkardeRoozane.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvkarkardeRoozane.Location = New System.Drawing.Point(12, 122)
        Me.dgvkarkardeRoozane.MultiSelect = False
        Me.dgvkarkardeRoozane.Name = "dgvkarkardeRoozane"
        Me.dgvkarkardeRoozane.ReadOnly = True
        Me.dgvkarkardeRoozane.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvkarkardeRoozane.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvkarkardeRoozane.Size = New System.Drawing.Size(813, 391)
        Me.dgvkarkardeRoozane.TabIndex = 0
        '
        'OperationCodeDataGridViewTextBoxColumn
        '
        Me.OperationCodeDataGridViewTextBoxColumn.DataPropertyName = "OperationCode"
        Me.OperationCodeDataGridViewTextBoxColumn.HeaderText = "OperationCode"
        Me.OperationCodeDataGridViewTextBoxColumn.Name = "OperationCodeDataGridViewTextBoxColumn"
        Me.OperationCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.OperationCodeDataGridViewTextBoxColumn.Visible = False
        '
        'RanandePersonalCodeDataGridViewTextBoxColumn
        '
        Me.RanandePersonalCodeDataGridViewTextBoxColumn.DataPropertyName = "RanandePersonalCode"
        Me.RanandePersonalCodeDataGridViewTextBoxColumn.HeaderText = "RanandePersonalCode"
        Me.RanandePersonalCodeDataGridViewTextBoxColumn.Name = "RanandePersonalCodeDataGridViewTextBoxColumn"
        Me.RanandePersonalCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.RanandePersonalCodeDataGridViewTextBoxColumn.Visible = False
        '
        'RanandeFullNameDataGridViewTextBoxColumn
        '
        Me.RanandeFullNameDataGridViewTextBoxColumn.DataPropertyName = "RanandeFullName"
        Me.RanandeFullNameDataGridViewTextBoxColumn.HeaderText = "نام راننده"
        Me.RanandeFullNameDataGridViewTextBoxColumn.Name = "RanandeFullNameDataGridViewTextBoxColumn"
        Me.RanandeFullNameDataGridViewTextBoxColumn.ReadOnly = True
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
        'NoeBarDataGridViewTextBoxColumn
        '
        Me.NoeBarDataGridViewTextBoxColumn.DataPropertyName = "NoeBar"
        Me.NoeBarDataGridViewTextBoxColumn.HeaderText = "نوع بار"
        Me.NoeBarDataGridViewTextBoxColumn.Name = "NoeBarDataGridViewTextBoxColumn"
        Me.NoeBarDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaatKhoroojMojtameDataGridViewTextBoxColumn
        '
        Me.SaatKhoroojMojtameDataGridViewTextBoxColumn.DataPropertyName = "SaatKhoroojMojtame"
        Me.SaatKhoroojMojtameDataGridViewTextBoxColumn.HeaderText = "ساعت خروج"
        Me.SaatKhoroojMojtameDataGridViewTextBoxColumn.Name = "SaatKhoroojMojtameDataGridViewTextBoxColumn"
        Me.SaatKhoroojMojtameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaatVoroodMojtameDataGridViewTextBoxColumn
        '
        Me.SaatVoroodMojtameDataGridViewTextBoxColumn.DataPropertyName = "SaatVoroodMojtame"
        Me.SaatVoroodMojtameDataGridViewTextBoxColumn.HeaderText = "ساعت ورود"
        Me.SaatVoroodMojtameDataGridViewTextBoxColumn.Name = "SaatVoroodMojtameDataGridViewTextBoxColumn"
        Me.SaatVoroodMojtameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PDateDataGridViewTextBoxColumn
        '
        Me.PDateDataGridViewTextBoxColumn.DataPropertyName = "pDate"
        Me.PDateDataGridViewTextBoxColumn.HeaderText = "pDate"
        Me.PDateDataGridViewTextBoxColumn.Name = "PDateDataGridViewTextBoxColumn"
        Me.PDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.PDateDataGridViewTextBoxColumn.Visible = False
        '
        'VaziyatSafarDataGridViewTextBoxColumn
        '
        Me.VaziyatSafarDataGridViewTextBoxColumn.DataPropertyName = "VaziyatSafar"
        Me.VaziyatSafarDataGridViewTextBoxColumn.HeaderText = "وضعیت سفر"
        Me.VaziyatSafarDataGridViewTextBoxColumn.Name = "VaziyatSafarDataGridViewTextBoxColumn"
        Me.VaziyatSafarDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VaziyatBazgashtDataGridViewTextBoxColumn
        '
        Me.VaziyatBazgashtDataGridViewTextBoxColumn.DataPropertyName = "VaziyatBazgasht"
        Me.VaziyatBazgashtDataGridViewTextBoxColumn.HeaderText = "وضعیت بازگشت"
        Me.VaziyatBazgashtDataGridViewTextBoxColumn.Name = "VaziyatBazgashtDataGridViewTextBoxColumn"
        Me.VaziyatBazgashtDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VaziyatTamirgahDataGridViewTextBoxColumn
        '
        Me.VaziyatTamirgahDataGridViewTextBoxColumn.DataPropertyName = "VaziyatTamirgah"
        Me.VaziyatTamirgahDataGridViewTextBoxColumn.HeaderText = "وضعیت تعمیرگاه"
        Me.VaziyatTamirgahDataGridViewTextBoxColumn.Name = "VaziyatTamirgahDataGridViewTextBoxColumn"
        Me.VaziyatTamirgahDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VaziyatRanandehDataGridViewTextBoxColumn
        '
        Me.VaziyatRanandehDataGridViewTextBoxColumn.DataPropertyName = "VaziyatRanandeh"
        Me.VaziyatRanandehDataGridViewTextBoxColumn.HeaderText = "وضعیت راننده"
        Me.VaziyatRanandehDataGridViewTextBoxColumn.Name = "VaziyatRanandehDataGridViewTextBoxColumn"
        Me.VaziyatRanandehDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "توضیحات"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmKarkardRoozane
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(837, 525)
        Me.Controls.Add(Me.dgvkarkardeRoozane)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = True
        Me.Name = "frmKarkardRoozane"
        Me.Text = "گزارش روزانه حمل و نقل از آخرین وضعیت ناوگان"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UspKarkardeRoozane4ShowBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvkarkardeRoozane, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDate As Tarabari.AdvancedMaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UspKarkardeRoozane4ShowBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsTarabari As Tarabari.dsTarabari
    Friend WithEvents Usp_KarkardeRoozane4ShowTableAdapter As Tarabari.dsTarabariTableAdapters.usp_KarkardeRoozane4ShowTableAdapter
    Friend WithEvents btnExit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnShowData As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPrint As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgvkarkardeRoozane As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents OperationCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RanandePersonalCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RanandeFullNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PelakDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameMabdaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameMaghsadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoeBarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaatKhoroojMojtameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaatVoroodMojtameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VaziyatSafarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VaziyatBazgashtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VaziyatTamirgahDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VaziyatRanandehDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
