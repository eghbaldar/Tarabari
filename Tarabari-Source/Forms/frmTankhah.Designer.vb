<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTankhah
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnAddFactor = New DevComponents.DotNetBar.ButtonX
        Me.btnSave = New DevComponents.DotNetBar.ButtonX
        Me.lblTotalValue = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDate = New Tarabari.AdvancedMaskedTextBox(Me.components)
        Me.txtSanadSeryalNo = New Tarabari.AdvancedTextBox(Me.components)
        Me.txtVajhe = New Tarabari.AdvancedTextBox(Me.components)
        Me.txtTankhahNumber = New Tarabari.AdvancedTextBox(Me.components)
        Me.ErrorDate = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorVajhe = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorSeryalSanadNo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dgvTankhahItems = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnAddSanad = New DevComponents.DotNetBar.ButtonX
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorVajhe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorSeryalSanadNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTankhahItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAddSanad)
        Me.GroupBox1.Controls.Add(Me.btnAddFactor)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.lblTotalValue)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Controls.Add(Me.txtSanadSeryalNo)
        Me.GroupBox1.Controls.Add(Me.txtVajhe)
        Me.GroupBox1.Controls.Add(Me.txtTankhahNumber)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(934, 189)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnAddFactor
        '
        Me.btnAddFactor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAddFactor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAddFactor.Location = New System.Drawing.Point(668, 123)
        Me.btnAddFactor.Name = "btnAddFactor"
        Me.btnAddFactor.Size = New System.Drawing.Size(87, 31)
        Me.btnAddFactor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAddFactor.TabIndex = 17
        Me.btnAddFactor.Text = "افزودن فاکتور"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Image = Global.Tarabari.My.Resources.Resources.Save
        Me.btnSave.Location = New System.Drawing.Point(785, 124)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 31)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "ذخیره"
        '
        'lblTotalValue
        '
        Me.lblTotalValue.Location = New System.Drawing.Point(245, 80)
        Me.lblTotalValue.Name = "lblTotalValue"
        Me.lblTotalValue.Size = New System.Drawing.Size(598, 13)
        Me.lblTotalValue.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(849, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "مبلغ کل :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(855, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "شماره :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(153, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "شماره سریال سند :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(429, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "در وجه :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(650, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "تاریخ :"
        '
        'txtDate
        '
        Me.txtDate.BorderColor = System.Drawing.Color.Empty
        Me.txtDate.FocusColor = System.Drawing.Color.Empty
        Me.txtDate.Location = New System.Drawing.Point(544, 36)
        Me.txtDate.Mask = "0000/00/00"
        Me.txtDate.Name = "txtDate"
        Me.txtDate.NextControl = Nothing
        Me.txtDate.PrevControl = Nothing
        Me.txtDate.Size = New System.Drawing.Size(100, 21)
        Me.txtDate.TabIndex = 1
        '
        'txtSanadSeryalNo
        '
        Me.txtSanadSeryalNo.BorderColor = System.Drawing.Color.Empty
        Me.txtSanadSeryalNo.FocusColor = System.Drawing.Color.Empty
        Me.txtSanadSeryalNo.InputMode = Tarabari.AdvancedTextBox.enInputMode.Number
        Me.txtSanadSeryalNo.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtSanadSeryalNo.Location = New System.Drawing.Point(47, 39)
        Me.txtSanadSeryalNo.MaxLength = 10
        Me.txtSanadSeryalNo.Name = "txtSanadSeryalNo"
        Me.txtSanadSeryalNo.NextControl = Nothing
        Me.txtSanadSeryalNo.PrevControl = Nothing
        Me.txtSanadSeryalNo.Size = New System.Drawing.Size(100, 21)
        Me.txtSanadSeryalNo.TabIndex = 2
        '
        'txtVajhe
        '
        Me.txtVajhe.BorderColor = System.Drawing.Color.Empty
        Me.txtVajhe.FocusColor = System.Drawing.Color.Empty
        Me.txtVajhe.InputMode = Tarabari.AdvancedTextBox.enInputMode.Normal
        Me.txtVajhe.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtVajhe.Location = New System.Drawing.Point(323, 36)
        Me.txtVajhe.Name = "txtVajhe"
        Me.txtVajhe.NextControl = Nothing
        Me.txtVajhe.PrevControl = Nothing
        Me.txtVajhe.Size = New System.Drawing.Size(100, 21)
        Me.txtVajhe.TabIndex = 2
        '
        'txtTankhahNumber
        '
        Me.txtTankhahNumber.BorderColor = System.Drawing.Color.Empty
        Me.txtTankhahNumber.Enabled = False
        Me.txtTankhahNumber.FocusColor = System.Drawing.Color.Empty
        Me.txtTankhahNumber.InputMode = Tarabari.AdvancedTextBox.enInputMode.Normal
        Me.txtTankhahNumber.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtTankhahNumber.Location = New System.Drawing.Point(749, 33)
        Me.txtTankhahNumber.Name = "txtTankhahNumber"
        Me.txtTankhahNumber.NextControl = Nothing
        Me.txtTankhahNumber.PrevControl = Nothing
        Me.txtTankhahNumber.Size = New System.Drawing.Size(100, 21)
        Me.txtTankhahNumber.TabIndex = 0
        '
        'ErrorDate
        '
        Me.ErrorDate.ContainerControl = Me
        Me.ErrorDate.RightToLeft = True
        '
        'ErrorVajhe
        '
        Me.ErrorVajhe.ContainerControl = Me
        Me.ErrorVajhe.RightToLeft = True
        '
        'ErrorSeryalSanadNo
        '
        Me.ErrorSeryalSanadNo.ContainerControl = Me
        Me.ErrorSeryalSanadNo.RightToLeft = True
        '
        'dgvTankhahItems
        '
        Me.dgvTankhahItems.AllowUserToAddRows = False
        Me.dgvTankhahItems.AllowUserToDeleteRows = False
        Me.dgvTankhahItems.AllowUserToResizeColumns = False
        Me.dgvTankhahItems.AllowUserToResizeRows = False
        Me.dgvTankhahItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTankhahItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTankhahItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvTankhahItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTankhahItems.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvTankhahItems.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvTankhahItems.Location = New System.Drawing.Point(17, 216)
        Me.dgvTankhahItems.MultiSelect = False
        Me.dgvTankhahItems.Name = "dgvTankhahItems"
        Me.dgvTankhahItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgvTankhahItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvTankhahItems.Size = New System.Drawing.Size(934, 355)
        Me.dgvTankhahItems.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "FS_ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Is_Factor"
        Me.Column2.Name = "Column2"
        Me.Column2.Visible = False
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column3.HeaderText = "ردیف"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 50
        '
        'Column4
        '
        Me.Column4.HeaderText = "شرح - نام راننده"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column5.HeaderText = "شماره کامیون"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 80
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column6.HeaderText = "تعداد برگهای ضمیمه"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 110
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column7.HeaderText = "شماره سند پرداخت"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 110
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column8.HeaderText = "شماره رسید انبار"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column9.HeaderText = "مبلغ به ریال"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 80
        '
        'Column10
        '
        Me.Column10.HeaderText = "ملاحضات"
        Me.Column10.Name = "Column10"
        '
        'btnAddSanad
        '
        Me.btnAddSanad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAddSanad.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAddSanad.Location = New System.Drawing.Point(549, 124)
        Me.btnAddSanad.Name = "btnAddSanad"
        Me.btnAddSanad.Size = New System.Drawing.Size(87, 31)
        Me.btnAddSanad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAddSanad.TabIndex = 18
        Me.btnAddSanad.Text = "افزودن سند"
        '
        'frmTankhah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(968, 583)
        Me.Controls.Add(Me.dgvTankhahItems)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmTankhah"
        Me.Text = "ایجاد سند تنخواه"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorVajhe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorSeryalSanadNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTankhahItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDate As Tarabari.AdvancedMaskedTextBox
    Friend WithEvents txtVajhe As Tarabari.AdvancedTextBox
    Friend WithEvents txtTankhahNumber As Tarabari.AdvancedTextBox
    Friend WithEvents lblTotalValue As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ErrorDate As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorVajhe As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSanadSeryalNo As Tarabari.AdvancedTextBox
    Friend WithEvents ErrorSeryalSanadNo As System.Windows.Forms.ErrorProvider
    Friend WithEvents dgvTankhahItems As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAddFactor As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAddSanad As DevComponents.DotNetBar.ButtonX

End Class
