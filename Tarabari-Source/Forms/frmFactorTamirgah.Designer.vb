<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFactorTamirgah
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgvDetail = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtDate = New Tarabari.AdvancedMaskedTextBox(Me.components)
        Me.txtBimehBadane = New Tarabari.AdvancedTextBox(Me.components)
        Me.txtBimehSales = New Tarabari.AdvancedTextBox(Me.components)
        Me.txtTamirgah = New Tarabari.AdvancedTextBox(Me.components)
        Me.txtMashinID = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbRanande = New System.Windows.Forms.ComboBox
        Me.VSelectRanandeganMashinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTarabari = New Tarabari.dsTarabari
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblFactorID = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblPelak = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.VSelectRanandeganMashinTableAdapter = New Tarabari.dsTarabariTableAdapters.vSelectRanandeganMashinTableAdapter
        Me.ErrorRanande = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorMashinID = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorTamirgah = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorDate = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX
        Me.btnSave = New DevComponents.DotNetBar.ButtonX
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VSelectRanandeganMashinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorRanande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorMashinID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorTamirgah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvDetail)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Controls.Add(Me.txtBimehBadane)
        Me.GroupBox1.Controls.Add(Me.txtBimehSales)
        Me.GroupBox1.Controls.Add(Me.txtTamirgah)
        Me.GroupBox1.Controls.Add(Me.txtMashinID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbRanande)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.lblFactorID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblPelak)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(577, 463)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "اطلاعات فاکتور"
        '
        'dgvDetail
        '
        Me.dgvDetail.AllowUserToResizeColumns = False
        Me.dgvDetail.AllowUserToResizeRows = False
        Me.dgvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.Column2})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetail.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDetail.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvDetail.Location = New System.Drawing.Point(11, 230)
        Me.dgvDetail.MultiSelect = False
        Me.dgvDetail.Name = "dgvDetail"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetail.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvDetail.Size = New System.Drawing.Size(555, 184)
        Me.dgvDetail.TabIndex = 13
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column3.HeaderText = "ردیف"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 50
        '
        'Column1
        '
        Me.Column1.FillWeight = 98.47716!
        Me.Column1.HeaderText = "شرح تعمیرات"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.FillWeight = 101.5228!
        Me.Column2.HeaderText = "مبلغ"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 120
        '
        'txtDate
        '
        Me.txtDate.BorderColor = System.Drawing.Color.Empty
        Me.txtDate.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDate.Location = New System.Drawing.Point(130, 38)
        Me.txtDate.Mask = "0000/00/00"
        Me.txtDate.Name = "txtDate"
        Me.txtDate.NextControl = Nothing
        Me.txtDate.PrevControl = Nothing
        Me.txtDate.Size = New System.Drawing.Size(83, 21)
        Me.txtDate.TabIndex = 0
        '
        'txtBimehBadane
        '
        Me.txtBimehBadane.BorderColor = System.Drawing.Color.Empty
        Me.txtBimehBadane.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBimehBadane.InputMode = Tarabari.AdvancedTextBox.enInputMode.Number
        Me.txtBimehBadane.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtBimehBadane.Location = New System.Drawing.Point(36, 193)
        Me.txtBimehBadane.MaxLength = 10
        Me.txtBimehBadane.Name = "txtBimehBadane"
        Me.txtBimehBadane.NextControl = Nothing
        Me.txtBimehBadane.PrevControl = Nothing
        Me.txtBimehBadane.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBimehBadane.Size = New System.Drawing.Size(111, 21)
        Me.txtBimehBadane.TabIndex = 5
        '
        'txtBimehSales
        '
        Me.txtBimehSales.BorderColor = System.Drawing.Color.Empty
        Me.txtBimehSales.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBimehSales.InputMode = Tarabari.AdvancedTextBox.enInputMode.Number
        Me.txtBimehSales.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtBimehSales.Location = New System.Drawing.Point(311, 193)
        Me.txtBimehSales.MaxLength = 10
        Me.txtBimehSales.Name = "txtBimehSales"
        Me.txtBimehSales.NextControl = Nothing
        Me.txtBimehSales.PrevControl = Nothing
        Me.txtBimehSales.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBimehSales.Size = New System.Drawing.Size(111, 21)
        Me.txtBimehSales.TabIndex = 4
        '
        'txtTamirgah
        '
        Me.txtTamirgah.BorderColor = System.Drawing.Color.Empty
        Me.txtTamirgah.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTamirgah.InputMode = Tarabari.AdvancedTextBox.enInputMode.Normal
        Me.txtTamirgah.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtTamirgah.Location = New System.Drawing.Point(274, 153)
        Me.txtTamirgah.MaxLength = 50
        Me.txtTamirgah.Name = "txtTamirgah"
        Me.txtTamirgah.NextControl = Nothing
        Me.txtTamirgah.PrevControl = Nothing
        Me.txtTamirgah.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTamirgah.Size = New System.Drawing.Size(148, 21)
        Me.txtTamirgah.TabIndex = 3
        '
        'txtMashinID
        '
        Me.txtMashinID.BorderColor = System.Drawing.Color.Empty
        Me.txtMashinID.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMashinID.InputMode = Tarabari.AdvancedTextBox.enInputMode.Number
        Me.txtMashinID.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtMashinID.Location = New System.Drawing.Point(339, 113)
        Me.txtMashinID.MaxLength = 3
        Me.txtMashinID.Name = "txtMashinID"
        Me.txtMashinID.NextControl = Nothing
        Me.txtMashinID.PrevControl = Nothing
        Me.txtMashinID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMashinID.Size = New System.Drawing.Size(83, 21)
        Me.txtMashinID.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(219, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "تاریخ :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(219, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "شماره انتظامی :"
        '
        'cmbRanande
        '
        Me.cmbRanande.DataSource = Me.VSelectRanandeganMashinBindingSource
        Me.cmbRanande.DisplayMember = "Fullname"
        Me.cmbRanande.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRanande.FormattingEnabled = True
        Me.cmbRanande.Location = New System.Drawing.Point(274, 74)
        Me.cmbRanande.Name = "cmbRanande"
        Me.cmbRanande.Size = New System.Drawing.Size(148, 21)
        Me.cmbRanande.TabIndex = 1
        Me.cmbRanande.ValueMember = "RanandePersonalCode"
        '
        'VSelectRanandeganMashinBindingSource
        '
        Me.VSelectRanandeganMashinBindingSource.DataMember = "vSelectRanandeganMashin"
        Me.VSelectRanandeganMashinBindingSource.DataSource = Me.DsTarabari
        '
        'DsTarabari
        '
        Me.DsTarabari.DataSetName = "dsTarabari"
        Me.DsTarabari.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(179, 426)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTotal.Size = New System.Drawing.Size(243, 19)
        Me.lblTotal.TabIndex = 12
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFactorID
        '
        Me.lblFactorID.Location = New System.Drawing.Point(311, 38)
        Me.lblFactorID.Name = "lblFactorID"
        Me.lblFactorID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblFactorID.Size = New System.Drawing.Size(111, 19)
        Me.lblFactorID.TabIndex = 12
        Me.lblFactorID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(153, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "مبلغ خسارت بیمه ای بدنه :"
        '
        'lblPelak
        '
        Me.lblPelak.Location = New System.Drawing.Point(91, 113)
        Me.lblPelak.Name = "lblPelak"
        Me.lblPelak.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblPelak.Size = New System.Drawing.Size(122, 19)
        Me.lblPelak.TabIndex = 12
        Me.lblPelak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(428, 429)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "مبلغ کل فاکتور :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(428, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "مبلغ خسارت بیمه ای ثالث :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(428, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "شماره فاکتور :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(428, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "نام تعمیرگاه :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(428, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "راننده :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(428, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "کد تریلی :"
        '
        'VSelectRanandeganMashinTableAdapter
        '
        Me.VSelectRanandeganMashinTableAdapter.ClearBeforeFill = True
        '
        'ErrorRanande
        '
        Me.ErrorRanande.ContainerControl = Me
        Me.ErrorRanande.RightToLeft = True
        '
        'ErrorMashinID
        '
        Me.ErrorMashinID.ContainerControl = Me
        Me.ErrorMashinID.RightToLeft = True
        '
        'ErrorTamirgah
        '
        Me.ErrorTamirgah.ContainerControl = Me
        Me.ErrorTamirgah.RightToLeft = True
        '
        'ErrorDate
        '
        Me.ErrorDate.ContainerControl = Me
        Me.ErrorDate.RightToLeft = True
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = Global.Tarabari.My.Resources.Resources.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(186, 498)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 31)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "انصراف"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Image = Global.Tarabari.My.Resources.Resources.Save
        Me.btnSave.Location = New System.Drawing.Point(323, 498)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 31)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "ذخیره"
        '
        'frmFactorTamirgah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(601, 555)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "frmFactorTamirgah"
        Me.Text = "فاکتور"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VSelectRanandeganMashinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorRanande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorMashinID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorTamirgah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMashinID As Tarabari.AdvancedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbRanande As System.Windows.Forms.ComboBox
    Friend WithEvents lblPelak As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DsTarabari As Tarabari.dsTarabari
    Friend WithEvents VSelectRanandeganMashinBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VSelectRanandeganMashinTableAdapter As Tarabari.dsTarabariTableAdapters.vSelectRanandeganMashinTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFactorID As System.Windows.Forms.Label
    Friend WithEvents txtTamirgah As Tarabari.AdvancedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBimehBadane As Tarabari.AdvancedTextBox
    Friend WithEvents txtBimehSales As Tarabari.AdvancedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ErrorRanande As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorMashinID As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorTamirgah As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDate As Tarabari.AdvancedMaskedTextBox
    Friend WithEvents ErrorDate As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgvDetail As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
