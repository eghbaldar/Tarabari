<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsers))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnRemoveFilter = New DevComponents.DotNetBar.ButtonX
        Me.btnFilter = New DevComponents.DotNetBar.ButtonX
        Me.cmbFilterType = New System.Windows.Forms.ComboBox
        Me.txtFilter = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btnRemoveNumber = New DevComponents.DotNetBar.ButtonX
        Me.txtMelliCode = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label6 = New System.Windows.Forms.Label
        Me.picPersonalPhoto = New System.Windows.Forms.PictureBox
        Me.PictureMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeletePictureMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.txtAddress = New Tarabari.AdvancedTextBox(Me.components)
        Me.txtlname = New Tarabari.AdvancedTextBox(Me.components)
        Me.txtfname = New Tarabari.AdvancedTextBox(Me.components)
        Me.cmbTelNumbers = New System.Windows.Forms.ComboBox
        Me.txtPersonalCode = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtPassword = New Tarabari.AdvancedTextBox(Me.components)
        Me.txtUsername = New Tarabari.AdvancedTextBox(Me.components)
        Me.btnSave = New DevComponents.DotNetBar.ButtonX
        Me.btnNew = New DevComponents.DotNetBar.ButtonX
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX
        Me.TblUsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsLogin = New Tarabari.dsLogin
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ErrorUsername = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorPassword = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Tbl_UsersTableAdapter = New Tarabari.dsLoginTableAdapters.tbl_UsersTableAdapter
        Me.dgvRM_List = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IsActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TelNumbersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn
        Me.GroupBox2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.picPersonalPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PictureMenu.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.TblUsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRM_List, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnRemoveFilter)
        Me.GroupBox2.Controls.Add(Me.btnFilter)
        Me.GroupBox2.Controls.Add(Me.cmbFilterType)
        Me.GroupBox2.Controls.Add(Me.txtFilter)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 292)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(722, 70)
        Me.GroupBox2.TabIndex = 4
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
        Me.cmbFilterType.Items.AddRange(New Object() {"نام کاربری", "کد پرسنلی", "نام", "نام خانوادگی"})
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
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnRemoveNumber)
        Me.TabPage1.Controls.Add(Me.txtMelliCode)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.picPersonalPhoto)
        Me.TabPage1.Controls.Add(Me.txtAddress)
        Me.TabPage1.Controls.Add(Me.txtlname)
        Me.TabPage1.Controls.Add(Me.txtfname)
        Me.TabPage1.Controls.Add(Me.cmbTelNumbers)
        Me.TabPage1.Controls.Add(Me.txtPersonalCode)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(714, 197)
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
        Me.btnRemoveNumber.TabIndex = 6
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
        Me.txtMelliCode.TabIndex = 3
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
        Me.txtAddress.TabIndex = 4
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
        Me.txtlname.TabIndex = 2
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
        Me.txtfname.TabIndex = 1
        '
        'cmbTelNumbers
        '
        Me.cmbTelNumbers.FormattingEnabled = True
        Me.cmbTelNumbers.Location = New System.Drawing.Point(498, 157)
        Me.cmbTelNumbers.Name = "cmbTelNumbers"
        Me.cmbTelNumbers.Size = New System.Drawing.Size(121, 21)
        Me.cmbTelNumbers.TabIndex = 5
        '
        'txtPersonalCode
        '
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
        Me.txtPersonalCode.TabIndex = 0
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
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(22, 17)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(722, 223)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txtPassword)
        Me.TabPage2.Controls.Add(Me.txtUsername)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(714, 197)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "اطلاعات عبور"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(625, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "کلمه عبور :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(625, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "نام کاربری :"
        '
        'txtPassword
        '
        Me.txtPassword.BorderColor = System.Drawing.Color.Empty
        Me.txtPassword.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPassword.InputMode = Tarabari.AdvancedTextBox.enInputMode.Normal
        Me.txtPassword.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtPassword.Location = New System.Drawing.Point(471, 65)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.NextControl = Nothing
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PrevControl = Nothing
        Me.txtPassword.Size = New System.Drawing.Size(148, 21)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.BorderColor = System.Drawing.Color.Empty
        Me.txtUsername.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUsername.InputMode = Tarabari.AdvancedTextBox.enInputMode.Normal
        Me.txtUsername.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtUsername.Location = New System.Drawing.Point(471, 23)
        Me.txtUsername.MaxLength = 50
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.NextControl = Nothing
        Me.txtUsername.PrevControl = Nothing
        Me.txtUsername.Size = New System.Drawing.Size(148, 21)
        Me.txtUsername.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Image = Global.Tarabari.My.Resources.Resources.Save
        Me.btnSave.Location = New System.Drawing.Point(633, 252)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 31)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "ذخیره"
        '
        'btnNew
        '
        Me.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnNew.Image = Global.Tarabari.My.Resources.Resources._New
        Me.btnNew.Location = New System.Drawing.Point(513, 252)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(87, 31)
        Me.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNew.TabIndex = 2
        Me.btnNew.Text = "جدید"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Image = Global.Tarabari.My.Resources.Resources.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(393, 252)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 31)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "انصراف"
        '
        'TblUsersBindingSource
        '
        Me.TblUsersBindingSource.DataMember = "tbl_Users"
        Me.TblUsersBindingSource.DataSource = Me.DsLogin
        '
        'DsLogin
        '
        Me.DsLogin.DataSetName = "dsLogin"
        Me.DsLogin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ErrorUsername
        '
        Me.ErrorUsername.ContainerControl = Me
        Me.ErrorUsername.RightToLeft = True
        '
        'ErrorPassword
        '
        Me.ErrorPassword.ContainerControl = Me
        Me.ErrorPassword.RightToLeft = True
        '
        'Tbl_UsersTableAdapter
        '
        Me.Tbl_UsersTableAdapter.ClearBeforeFill = True
        '
        'dgvRM_List
        '
        Me.dgvRM_List.AllowUserToAddRows = False
        Me.dgvRM_List.AllowUserToDeleteRows = False
        Me.dgvRM_List.AllowUserToResizeColumns = False
        Me.dgvRM_List.AllowUserToResizeRows = False
        Me.dgvRM_List.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRM_List.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRM_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRM_List.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.IsActiveDataGridViewCheckBoxColumn, Me.Column5, Me.UsernameDataGridViewTextBoxColumn, Me.FnameDataGridViewTextBoxColumn, Me.LnameDataGridViewTextBoxColumn, Me.Column4, Me.TelNumbersDataGridViewTextBoxColumn, Me.Column1, Me.Column2})
        Me.dgvRM_List.DataSource = Me.TblUsersBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRM_List.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRM_List.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvRM_List.Location = New System.Drawing.Point(22, 377)
        Me.dgvRM_List.MultiSelect = False
        Me.dgvRM_List.Name = "dgvRM_List"
        Me.dgvRM_List.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRM_List.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRM_List.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvRM_List.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvRM_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRM_List.Size = New System.Drawing.Size(722, 206)
        Me.dgvRM_List.TabIndex = 5
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Username"
        Me.Column3.HeaderText = "ردیف"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'IsActiveDataGridViewCheckBoxColumn
        '
        Me.IsActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive"
        Me.IsActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive"
        Me.IsActiveDataGridViewCheckBoxColumn.Name = "IsActiveDataGridViewCheckBoxColumn"
        Me.IsActiveDataGridViewCheckBoxColumn.ReadOnly = True
        Me.IsActiveDataGridViewCheckBoxColumn.Visible = False
        '
        'Column5
        '
        Me.Column5.HeaderText = "وضعیت فعالیت"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "نام کاربری"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FnameDataGridViewTextBoxColumn
        '
        Me.FnameDataGridViewTextBoxColumn.DataPropertyName = "Fname"
        Me.FnameDataGridViewTextBoxColumn.HeaderText = "Fname"
        Me.FnameDataGridViewTextBoxColumn.Name = "FnameDataGridViewTextBoxColumn"
        Me.FnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FnameDataGridViewTextBoxColumn.Visible = False
        '
        'LnameDataGridViewTextBoxColumn
        '
        Me.LnameDataGridViewTextBoxColumn.DataPropertyName = "Lname"
        Me.LnameDataGridViewTextBoxColumn.HeaderText = "Lname"
        Me.LnameDataGridViewTextBoxColumn.Name = "LnameDataGridViewTextBoxColumn"
        Me.LnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LnameDataGridViewTextBoxColumn.Visible = False
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Username"
        Me.Column4.HeaderText = "نام و نام خانوادگی"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'TelNumbersDataGridViewTextBoxColumn
        '
        Me.TelNumbersDataGridViewTextBoxColumn.DataPropertyName = "TelNumbers"
        Me.TelNumbersDataGridViewTextBoxColumn.HeaderText = "شماره تلفن"
        Me.TelNumbersDataGridViewTextBoxColumn.Name = "TelNumbersDataGridViewTextBoxColumn"
        Me.TelNumbersDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "تغییر وضعیت"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Text = "تغییر..."
        Me.Column1.UseColumnTextForButtonValue = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "حذف کاربر"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Text = "حذف..."
        Me.Column2.UseColumnTextForButtonValue = True
        '
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(766, 595)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.dgvRM_List)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmUsers"
        Me.Text = "اطلاعات کاربران"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.picPersonalPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PictureMenu.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.TblUsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRM_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbFilterType As System.Windows.Forms.ComboBox
    Friend WithEvents txtFilter As Tarabari.AdvancedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tel1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tel2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BothDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtAddress As Tarabari.AdvancedTextBox
    Friend WithEvents txtlname As Tarabari.AdvancedTextBox
    Friend WithEvents txtfname As Tarabari.AdvancedTextBox
    Friend WithEvents cmbTelNumbers As System.Windows.Forms.ComboBox
    Friend WithEvents txtPersonalCode As Tarabari.AdvancedTextBox
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
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeletePictureMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As Tarabari.AdvancedTextBox
    Friend WithEvents txtUsername As Tarabari.AdvancedTextBox
    Friend WithEvents ErrorUsername As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorPassword As System.Windows.Forms.ErrorProvider
    Friend WithEvents DsLogin As Tarabari.dsLogin
    Friend WithEvents TblUsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_UsersTableAdapter As Tarabari.dsLoginTableAdapters.tbl_UsersTableAdapter
    Friend WithEvents dgvRM_List As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsActiveDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelNumbersDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnRemoveNumber As DevComponents.DotNetBar.ButtonX

End Class
