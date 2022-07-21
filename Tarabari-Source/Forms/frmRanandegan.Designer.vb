<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRanandegan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRanandegan))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TblMashinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTarabari = New Tarabari.dsTarabari
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnRemoveFilter = New DevComponents.DotNetBar.ButtonX
        Me.btnFilter = New DevComponents.DotNetBar.ButtonX
        Me.cmbFilterType = New System.Windows.Forms.ComboBox
        Me.txtFilter = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.ErrorPersonalCode = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorFname = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorLName = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorAddress = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorMashinID = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Tbl_MashinTableAdapter = New Tarabari.dsTarabariTableAdapters.tbl_MashinTableAdapter
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btnRemoveNumber = New DevComponents.DotNetBar.ButtonX
        Me.cmbTelNumbers = New System.Windows.Forms.ComboBox
        Me.txtMelliCode = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label6 = New System.Windows.Forms.Label
        Me.picPersonalPhoto = New System.Windows.Forms.PictureBox
        Me.PictureMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeletePictureMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.txtAddress = New Tarabari.AdvancedTextBox(Me.components)
        Me.txtlname = New Tarabari.AdvancedTextBox(Me.components)
        Me.txtfname = New Tarabari.AdvancedTextBox(Me.components)
        Me.cmbMashinID = New System.Windows.Forms.ComboBox
        Me.txtPersonalCode = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.txt_KG_EndDate = New Tarabari.AdvancedMaskedTextBox(Me.components)
        Me.txt_KS_EndDate = New Tarabari.AdvancedMaskedTextBox(Me.components)
        Me.txt_KG_StartDate = New Tarabari.AdvancedMaskedTextBox(Me.components)
        Me.txt_KS_StartDate = New Tarabari.AdvancedMaskedTextBox(Me.components)
        Me.txt_KH_EndDate = New Tarabari.AdvancedMaskedTextBox(Me.components)
        Me.txt_KH_StartDate = New Tarabari.AdvancedMaskedTextBox(Me.components)
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtKartGovahiname = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtKartSalamat = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtKartHooshmand = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnSave = New DevComponents.DotNetBar.ButtonX
        Me.btnNew = New DevComponents.DotNetBar.ButtonX
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX
        Me.dgvRM_List = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RanandePersonalCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FullnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TelNumbersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MashinIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn
        Me.VSelectRanandeganMashinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VSelectRanandeganMashinTableAdapter = New Tarabari.dsTarabariTableAdapters.vSelectRanandeganMashinTableAdapter
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.TblMashinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorPersonalCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorFname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorLName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorMashinID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.picPersonalPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PictureMenu.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvRM_List, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VSelectRanandeganMashinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblMashinBindingSource
        '
        Me.TblMashinBindingSource.DataMember = "tbl_Mashin"
        Me.TblMashinBindingSource.DataSource = Me.DsTarabari
        '
        'DsTarabari
        '
        Me.DsTarabari.DataSetName = "dsTarabari"
        Me.DsTarabari.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnRemoveFilter)
        Me.GroupBox2.Controls.Add(Me.btnFilter)
        Me.GroupBox2.Controls.Add(Me.cmbFilterType)
        Me.GroupBox2.Controls.Add(Me.txtFilter)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 314)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(722, 70)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "فیلتر"
        '
        'btnRemoveFilter
        '
        Me.btnRemoveFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRemoveFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRemoveFilter.Image = Global.Tarabari.My.Resources.Resources.RemoveFilter
        Me.btnRemoveFilter.Location = New System.Drawing.Point(107, 24)
        Me.btnRemoveFilter.Name = "btnRemoveFilter"
        Me.btnRemoveFilter.Size = New System.Drawing.Size(87, 31)
        Me.btnRemoveFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRemoveFilter.TabIndex = 3
        Me.btnRemoveFilter.Text = "لغو فیلتر"
        '
        'btnFilter
        '
        Me.btnFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnFilter.Image = Global.Tarabari.My.Resources.Resources.Filter
        Me.btnFilter.Location = New System.Drawing.Point(219, 24)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(87, 31)
        Me.btnFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnFilter.TabIndex = 2
        Me.btnFilter.Text = "فیلتر"
        '
        'cmbFilterType
        '
        Me.cmbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilterType.FormattingEnabled = True
        Me.cmbFilterType.Items.AddRange(New Object() {"کد پرسنلی", "نام", "نام خانوادگی", "شماره ماشین"})
        Me.cmbFilterType.Location = New System.Drawing.Point(481, 30)
        Me.cmbFilterType.Name = "cmbFilterType"
        Me.cmbFilterType.Size = New System.Drawing.Size(121, 21)
        Me.cmbFilterType.TabIndex = 0
        '
        'txtFilter
        '
        Me.txtFilter.BorderColor = System.Drawing.Color.Empty
        Me.txtFilter.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFilter.InputMode = Tarabari.AdvancedTextBox.enInputMode.Normal
        Me.txtFilter.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtFilter.Location = New System.Drawing.Point(346, 30)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.NextControl = Nothing
        Me.txtFilter.PrevControl = Nothing
        Me.txtFilter.Size = New System.Drawing.Size(118, 21)
        Me.txtFilter.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(608, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "جستجو بر اساس :"
        '
        'ErrorPersonalCode
        '
        Me.ErrorPersonalCode.ContainerControl = Me
        Me.ErrorPersonalCode.RightToLeft = True
        '
        'ErrorFname
        '
        Me.ErrorFname.ContainerControl = Me
        Me.ErrorFname.RightToLeft = True
        '
        'ErrorLName
        '
        Me.ErrorLName.ContainerControl = Me
        Me.ErrorLName.RightToLeft = True
        '
        'ErrorAddress
        '
        Me.ErrorAddress.ContainerControl = Me
        Me.ErrorAddress.RightToLeft = True
        '
        'ErrorMashinID
        '
        Me.ErrorMashinID.ContainerControl = Me
        Me.ErrorMashinID.RightToLeft = True
        '
        'Tbl_MashinTableAdapter
        '
        Me.Tbl_MashinTableAdapter.ClearBeforeFill = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnRemoveNumber)
        Me.TabPage1.Controls.Add(Me.cmbTelNumbers)
        Me.TabPage1.Controls.Add(Me.txtMelliCode)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.picPersonalPhoto)
        Me.TabPage1.Controls.Add(Me.txtAddress)
        Me.TabPage1.Controls.Add(Me.txtlname)
        Me.TabPage1.Controls.Add(Me.txtfname)
        Me.TabPage1.Controls.Add(Me.cmbMashinID)
        Me.TabPage1.Controls.Add(Me.txtPersonalCode)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(714, 227)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "اطلاعات پرسنلی"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnRemoveNumber
        '
        Me.btnRemoveNumber.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRemoveNumber.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRemoveNumber.Image = CType(resources.GetObject("btnRemoveNumber.Image"), System.Drawing.Image)
        Me.btnRemoveNumber.Location = New System.Drawing.Point(468, 155)
        Me.btnRemoveNumber.Name = "btnRemoveNumber"
        Me.btnRemoveNumber.Size = New System.Drawing.Size(24, 23)
        Me.btnRemoveNumber.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRemoveNumber.TabIndex = 7
        '
        'cmbTelNumbers
        '
        Me.cmbTelNumbers.FormattingEnabled = True
        Me.cmbTelNumbers.Location = New System.Drawing.Point(498, 157)
        Me.cmbTelNumbers.Name = "cmbTelNumbers"
        Me.cmbTelNumbers.Size = New System.Drawing.Size(121, 21)
        Me.cmbTelNumbers.TabIndex = 6
        '
        'txtMelliCode
        '
        Me.txtMelliCode.BorderColor = System.Drawing.Color.Empty
        Me.txtMelliCode.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMelliCode.InputMode = Tarabari.AdvancedTextBox.enInputMode.Number
        Me.txtMelliCode.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtMelliCode.Location = New System.Drawing.Point(505, 90)
        Me.txtMelliCode.MaxLength = 35
        Me.txtMelliCode.Name = "txtMelliCode"
        Me.txtMelliCode.NextControl = Nothing
        Me.txtMelliCode.PrevControl = Nothing
        Me.txtMelliCode.Size = New System.Drawing.Size(114, 21)
        Me.txtMelliCode.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(625, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "کد ملی :"
        '
        'picPersonalPhoto
        '
        Me.picPersonalPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPersonalPhoto.ContextMenuStrip = Me.PictureMenu
        Me.picPersonalPhoto.Image = Global.Tarabari.My.Resources.Resources.UnknowUser
        Me.picPersonalPhoto.Location = New System.Drawing.Point(16, 22)
        Me.picPersonalPhoto.Name = "picPersonalPhoto"
        Me.picPersonalPhoto.Size = New System.Drawing.Size(108, 121)
        Me.picPersonalPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPersonalPhoto.TabIndex = 23
        Me.picPersonalPhoto.TabStop = False
        '
        'PictureMenu
        '
        Me.PictureMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeletePictureMenu})
        Me.PictureMenu.Name = "PictureMenu"
        Me.PictureMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PictureMenu.Size = New System.Drawing.Size(126, 26)
        Me.PictureMenu.Text = "حذف تصویر"
        '
        'DeletePictureMenu
        '
        Me.DeletePictureMenu.Image = Global.Tarabari.My.Resources.Resources.Delete
        Me.DeletePictureMenu.Name = "DeletePictureMenu"
        Me.DeletePictureMenu.Size = New System.Drawing.Size(125, 22)
        Me.DeletePictureMenu.Text = "حذف تصویر"
        '
        'txtAddress
        '
        Me.txtAddress.BorderColor = System.Drawing.Color.Empty
        Me.txtAddress.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAddress.InputMode = Tarabari.AdvancedTextBox.enInputMode.Normal
        Me.txtAddress.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtAddress.Location = New System.Drawing.Point(149, 123)
        Me.txtAddress.MaxLength = 255
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.NextControl = Nothing
        Me.txtAddress.PrevControl = Nothing
        Me.txtAddress.Size = New System.Drawing.Size(470, 21)
        Me.txtAddress.TabIndex = 5
        '
        'txtlname
        '
        Me.txtlname.BorderColor = System.Drawing.Color.Empty
        Me.txtlname.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtlname.InputMode = Tarabari.AdvancedTextBox.enInputMode.Normal
        Me.txtlname.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtlname.Location = New System.Drawing.Point(172, 56)
        Me.txtlname.MaxLength = 35
        Me.txtlname.Name = "txtlname"
        Me.txtlname.NextControl = Nothing
        Me.txtlname.PrevControl = Nothing
        Me.txtlname.Size = New System.Drawing.Size(154, 21)
        Me.txtlname.TabIndex = 3
        '
        'txtfname
        '
        Me.txtfname.BorderColor = System.Drawing.Color.Empty
        Me.txtfname.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtfname.InputMode = Tarabari.AdvancedTextBox.enInputMode.Normal
        Me.txtfname.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtfname.Location = New System.Drawing.Point(465, 56)
        Me.txtfname.MaxLength = 25
        Me.txtfname.Name = "txtfname"
        Me.txtfname.NextControl = Nothing
        Me.txtfname.PrevControl = Nothing
        Me.txtfname.Size = New System.Drawing.Size(154, 21)
        Me.txtfname.TabIndex = 2
        '
        'cmbMashinID
        '
        Me.cmbMashinID.DataSource = Me.TblMashinBindingSource
        Me.cmbMashinID.DisplayMember = "MashinID"
        Me.cmbMashinID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMashinID.FormattingEnabled = True
        Me.cmbMashinID.Location = New System.Drawing.Point(553, 192)
        Me.cmbMashinID.Name = "cmbMashinID"
        Me.cmbMashinID.Size = New System.Drawing.Size(66, 21)
        Me.cmbMashinID.TabIndex = 8
        Me.cmbMashinID.ValueMember = "MashinID"
        '
        'txtPersonalCode
        '
        Me.txtPersonalCode.BackColor = System.Drawing.Color.White
        Me.txtPersonalCode.BorderColor = System.Drawing.Color.Empty
        Me.txtPersonalCode.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPersonalCode.InputMode = Tarabari.AdvancedTextBox.enInputMode.Normal
        Me.txtPersonalCode.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtPersonalCode.Location = New System.Drawing.Point(505, 22)
        Me.txtPersonalCode.MaxLength = 20
        Me.txtPersonalCode.Name = "txtPersonalCode"
        Me.txtPersonalCode.NextControl = Nothing
        Me.txtPersonalCode.PrevControl = Nothing
        Me.txtPersonalCode.Size = New System.Drawing.Size(114, 21)
        Me.txtPersonalCode.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(625, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "شماره ماشین :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(625, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "تلفن :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(625, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "آدرس :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(332, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "نام خانوادگی :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(625, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "نام :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(625, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "کد پرسنلی :"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(22, 17)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(722, 253)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txt_KG_EndDate)
        Me.TabPage2.Controls.Add(Me.txt_KS_EndDate)
        Me.TabPage2.Controls.Add(Me.txt_KG_StartDate)
        Me.TabPage2.Controls.Add(Me.txt_KS_StartDate)
        Me.TabPage2.Controls.Add(Me.txt_KH_EndDate)
        Me.TabPage2.Controls.Add(Me.txt_KH_StartDate)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txtKartGovahiname)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.txtKartSalamat)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.txtKartHooshmand)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(714, 227)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "مشخصات گواهی ها"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txt_KG_EndDate
        '
        Me.txt_KG_EndDate.BorderColor = System.Drawing.Color.Empty
        Me.txt_KG_EndDate.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_KG_EndDate.Location = New System.Drawing.Point(87, 121)
        Me.txt_KG_EndDate.Mask = "0000/00/00"
        Me.txt_KG_EndDate.Name = "txt_KG_EndDate"
        Me.txt_KG_EndDate.NextControl = Nothing
        Me.txt_KG_EndDate.PrevControl = Nothing
        Me.txt_KG_EndDate.Size = New System.Drawing.Size(83, 21)
        Me.txt_KG_EndDate.TabIndex = 8
        '
        'txt_KS_EndDate
        '
        Me.txt_KS_EndDate.BorderColor = System.Drawing.Color.Empty
        Me.txt_KS_EndDate.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_KS_EndDate.Location = New System.Drawing.Point(87, 78)
        Me.txt_KS_EndDate.Mask = "0000/00/00"
        Me.txt_KS_EndDate.Name = "txt_KS_EndDate"
        Me.txt_KS_EndDate.NextControl = Nothing
        Me.txt_KS_EndDate.PrevControl = Nothing
        Me.txt_KS_EndDate.Size = New System.Drawing.Size(83, 21)
        Me.txt_KS_EndDate.TabIndex = 5
        '
        'txt_KG_StartDate
        '
        Me.txt_KG_StartDate.BorderColor = System.Drawing.Color.Empty
        Me.txt_KG_StartDate.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_KG_StartDate.Location = New System.Drawing.Point(275, 121)
        Me.txt_KG_StartDate.Mask = "0000/00/00"
        Me.txt_KG_StartDate.Name = "txt_KG_StartDate"
        Me.txt_KG_StartDate.NextControl = Nothing
        Me.txt_KG_StartDate.PrevControl = Nothing
        Me.txt_KG_StartDate.Size = New System.Drawing.Size(83, 21)
        Me.txt_KG_StartDate.TabIndex = 7
        '
        'txt_KS_StartDate
        '
        Me.txt_KS_StartDate.BorderColor = System.Drawing.Color.Empty
        Me.txt_KS_StartDate.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_KS_StartDate.Location = New System.Drawing.Point(275, 78)
        Me.txt_KS_StartDate.Mask = "0000/00/00"
        Me.txt_KS_StartDate.Name = "txt_KS_StartDate"
        Me.txt_KS_StartDate.NextControl = Nothing
        Me.txt_KS_StartDate.PrevControl = Nothing
        Me.txt_KS_StartDate.Size = New System.Drawing.Size(83, 21)
        Me.txt_KS_StartDate.TabIndex = 4
        '
        'txt_KH_EndDate
        '
        Me.txt_KH_EndDate.BorderColor = System.Drawing.Color.Empty
        Me.txt_KH_EndDate.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_KH_EndDate.Location = New System.Drawing.Point(87, 31)
        Me.txt_KH_EndDate.Mask = "0000/00/00"
        Me.txt_KH_EndDate.Name = "txt_KH_EndDate"
        Me.txt_KH_EndDate.NextControl = Nothing
        Me.txt_KH_EndDate.PrevControl = Nothing
        Me.txt_KH_EndDate.Size = New System.Drawing.Size(83, 21)
        Me.txt_KH_EndDate.TabIndex = 2
        '
        'txt_KH_StartDate
        '
        Me.txt_KH_StartDate.BorderColor = System.Drawing.Color.Empty
        Me.txt_KH_StartDate.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_KH_StartDate.Location = New System.Drawing.Point(275, 31)
        Me.txt_KH_StartDate.Mask = "0000/00/00"
        Me.txt_KH_StartDate.Name = "txt_KH_StartDate"
        Me.txt_KH_StartDate.NextControl = Nothing
        Me.txt_KH_StartDate.PrevControl = Nothing
        Me.txt_KH_StartDate.Size = New System.Drawing.Size(83, 21)
        Me.txt_KH_StartDate.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(176, 127)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 13)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "تاریخ پایان :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(176, 81)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "تاریخ پایان :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(176, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "تاریخ پایان :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(364, 127)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "تاریخ شروع :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(364, 81)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "تاریخ شروع :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(364, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "تاریخ شروع :"
        '
        'txtKartGovahiname
        '
        Me.txtKartGovahiname.BackColor = System.Drawing.SystemColors.Window
        Me.txtKartGovahiname.BorderColor = System.Drawing.Color.Empty
        Me.txtKartGovahiname.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKartGovahiname.InputMode = Tarabari.AdvancedTextBox.enInputMode.Number
        Me.txtKartGovahiname.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtKartGovahiname.Location = New System.Drawing.Point(471, 121)
        Me.txtKartGovahiname.MaxLength = 25
        Me.txtKartGovahiname.Name = "txtKartGovahiname"
        Me.txtKartGovahiname.NextControl = Nothing
        Me.txtKartGovahiname.PrevControl = Nothing
        Me.txtKartGovahiname.Size = New System.Drawing.Size(114, 21)
        Me.txtKartGovahiname.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(591, 124)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "شماره گواهینامه :"
        '
        'txtKartSalamat
        '
        Me.txtKartSalamat.BorderColor = System.Drawing.Color.Empty
        Me.txtKartSalamat.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKartSalamat.InputMode = Tarabari.AdvancedTextBox.enInputMode.Number
        Me.txtKartSalamat.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtKartSalamat.Location = New System.Drawing.Point(471, 75)
        Me.txtKartSalamat.MaxLength = 25
        Me.txtKartSalamat.Name = "txtKartSalamat"
        Me.txtKartSalamat.NextControl = Nothing
        Me.txtKartSalamat.PrevControl = Nothing
        Me.txtKartSalamat.Size = New System.Drawing.Size(114, 21)
        Me.txtKartSalamat.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(591, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 13)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "شماره کارت سلامت :"
        '
        'txtKartHooshmand
        '
        Me.txtKartHooshmand.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKartHooshmand.BorderColor = System.Drawing.Color.Empty
        Me.txtKartHooshmand.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKartHooshmand.InputMode = Tarabari.AdvancedTextBox.enInputMode.Number
        Me.txtKartHooshmand.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtKartHooshmand.Location = New System.Drawing.Point(471, 28)
        Me.txtKartHooshmand.MaxLength = 25
        Me.txtKartHooshmand.Name = "txtKartHooshmand"
        Me.txtKartHooshmand.NextControl = Nothing
        Me.txtKartHooshmand.PrevControl = Nothing
        Me.txtKartHooshmand.Size = New System.Drawing.Size(114, 21)
        Me.txtKartHooshmand.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(591, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "شماره کارت هوشمند :"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Image = Global.Tarabari.My.Resources.Resources.Save
        Me.btnSave.Location = New System.Drawing.Point(644, 278)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 31)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "ذخیره"
        '
        'btnNew
        '
        Me.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnNew.Image = Global.Tarabari.My.Resources.Resources._New
        Me.btnNew.Location = New System.Drawing.Point(524, 278)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(87, 31)
        Me.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNew.TabIndex = 3
        Me.btnNew.Text = "جدید"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Image = Global.Tarabari.My.Resources.Resources.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(404, 278)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 31)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "انصراف"
        '
        'dgvRM_List
        '
        Me.dgvRM_List.AllowUserToAddRows = False
        Me.dgvRM_List.AllowUserToDeleteRows = False
        Me.dgvRM_List.AllowUserToResizeColumns = False
        Me.dgvRM_List.AllowUserToResizeRows = False
        Me.dgvRM_List.AutoGenerateColumns = False
        Me.dgvRM_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRM_List.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRM_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRM_List.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.RanandePersonalCodeDataGridViewTextBoxColumn, Me.FullnameDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.TelNumbersDataGridViewTextBoxColumn, Me.MashinIDDataGridViewTextBoxColumn, Me.Column1})
        Me.dgvRM_List.DataSource = Me.VSelectRanandeganMashinBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRM_List.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRM_List.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvRM_List.Location = New System.Drawing.Point(22, 400)
        Me.dgvRM_List.MultiSelect = False
        Me.dgvRM_List.Name = "dgvRM_List"
        Me.dgvRM_List.ReadOnly = True
        Me.dgvRM_List.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvRM_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRM_List.Size = New System.Drawing.Size(722, 207)
        Me.dgvRM_List.TabIndex = 4
        '
        'Column2
        '
        Me.Column2.HeaderText = "ردیف"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
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
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn1.HeaderText = "آدرس"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TelNumbersDataGridViewTextBoxColumn
        '
        Me.TelNumbersDataGridViewTextBoxColumn.DataPropertyName = "TelNumbers"
        Me.TelNumbersDataGridViewTextBoxColumn.HeaderText = "شماره تلفن"
        Me.TelNumbersDataGridViewTextBoxColumn.Name = "TelNumbersDataGridViewTextBoxColumn"
        Me.TelNumbersDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MashinIDDataGridViewTextBoxColumn
        '
        Me.MashinIDDataGridViewTextBoxColumn.DataPropertyName = "MashinID"
        Me.MashinIDDataGridViewTextBoxColumn.HeaderText = "شماره تریلی"
        Me.MashinIDDataGridViewTextBoxColumn.Name = "MashinIDDataGridViewTextBoxColumn"
        Me.MashinIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "حذف رکورد"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Text = "حذف..."
        Me.Column1.UseColumnTextForButtonValue = True
        '
        'VSelectRanandeganMashinBindingSource
        '
        Me.VSelectRanandeganMashinBindingSource.DataMember = "vSelectRanandeganMashin"
        Me.VSelectRanandeganMashinBindingSource.DataSource = Me.DsTarabari
        '
        'VSelectRanandeganMashinTableAdapter
        '
        Me.VSelectRanandeganMashinTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmRanandegan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(766, 619)
        Me.Controls.Add(Me.dgvRM_List)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmRanandegan"
        Me.Text = "اطلاعات رانندگان"
        CType(Me.TblMashinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorPersonalCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorFname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorLName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorMashinID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.picPersonalPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PictureMenu.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvRM_List, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VSelectRanandeganMashinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbFilterType As System.Windows.Forms.ComboBox
    Friend WithEvents txtFilter As Tarabari.AdvancedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ErrorPersonalCode As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorFname As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorLName As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorAddress As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorMashinID As System.Windows.Forms.ErrorProvider
    Friend WithEvents DsTarabari As Tarabari.dsTarabari
    Friend WithEvents TblMashinBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MashinTableAdapter As Tarabari.dsTarabariTableAdapters.tbl_MashinTableAdapter
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tel1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tel2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BothDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtAddress As Tarabari.AdvancedTextBox
    Friend WithEvents txtlname As Tarabari.AdvancedTextBox
    Friend WithEvents txtfname As Tarabari.AdvancedTextBox
    Friend WithEvents cmbMashinID As System.Windows.Forms.ComboBox
    Friend WithEvents txtPersonalCode As Tarabari.AdvancedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picPersonalPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents txtMelliCode As Tarabari.AdvancedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNew As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnRemoveFilter As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnFilter As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtKartHooshmand As Tarabari.AdvancedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtKartGovahiname As Tarabari.AdvancedTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtKartSalamat As Tarabari.AdvancedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_KG_EndDate As Tarabari.AdvancedMaskedTextBox
    Friend WithEvents txt_KS_EndDate As Tarabari.AdvancedMaskedTextBox
    Friend WithEvents txt_KG_StartDate As Tarabari.AdvancedMaskedTextBox
    Friend WithEvents txt_KS_StartDate As Tarabari.AdvancedMaskedTextBox
    Friend WithEvents txt_KH_EndDate As Tarabari.AdvancedMaskedTextBox
    Friend WithEvents txt_KH_StartDate As Tarabari.AdvancedMaskedTextBox
    Friend WithEvents dgvRM_List As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents VSelectRanandeganMashinBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VSelectRanandeganMashinTableAdapter As Tarabari.dsTarabariTableAdapters.vSelectRanandeganMashinTableAdapter
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RanandePersonalCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelNumbersDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MashinIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeletePictureMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRemoveNumber As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbTelNumbers As System.Windows.Forms.ComboBox

End Class
