<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEzamKhodro
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtSaatKhoroojMojtame = New Tarabari.AdvancedMaskedTextBox(Me.components)
        Me.txtSaatSodoorBarname = New Tarabari.AdvancedMaskedTextBox(Me.components)
        Me.txtSaatHozoorMahalBargiri = New Tarabari.AdvancedMaskedTextBox(Me.components)
        Me.txtTarikhKhoroojMojtame = New Tarabari.AdvancedMaskedTextBox(Me.components)
        Me.txtTarikhBarnameRaft = New Tarabari.AdvancedMaskedTextBox(Me.components)
        Me.txtTarikhHozoorMahalBargiri = New Tarabari.AdvancedMaskedTextBox(Me.components)
        Me.txtTarkhEzamBargiri = New Tarabari.AdvancedMaskedTextBox(Me.components)
        Me.cmbMaghsad = New System.Windows.Forms.ComboBox
        Me.TblMaghsadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTarabari = New Tarabari.dsTarabari
        Me.cmbMabda = New System.Windows.Forms.ComboBox
        Me.TblMabdaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtOperationCode = New Tarabari.AdvancedTextBox(Me.components)
        Me.txtTozihat = New Tarabari.AdvancedTextBox(Me.components)
        Me.txtNoeBar = New Tarabari.AdvancedTextBox(Me.components)
        Me.txtMeghdarSookhtKhorooj = New Tarabari.AdvancedTextBox(Me.components)
        Me.txtKiloometrKhorroojMojtame = New Tarabari.AdvancedTextBox(Me.components)
        Me.txtShomareBarnameRaft = New Tarabari.AdvancedTextBox(Me.components)
        Me.txtMashinID = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbMahalBargiri = New System.Windows.Forms.ComboBox
        Me.TblMahalBargiriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbRanande = New System.Windows.Forms.ComboBox
        Me.VSelectRanandeganMashinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblPelak = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.VSelectRanandeganMashinTableAdapter = New Tarabari.dsTarabariTableAdapters.vSelectRanandeganMashinTableAdapter
        Me.Tbl_MabdaTableAdapter = New Tarabari.dsTarabariTableAdapters.tbl_MabdaTableAdapter
        Me.Tbl_MaghsadTableAdapter = New Tarabari.dsTarabariTableAdapters.tbl_MaghsadTableAdapter
        Me.Tbl_MahalBargiriTableAdapter = New Tarabari.dsTarabariTableAdapters.tbl_MahalBargiriTableAdapter
        Me.ErrorCmbRanande = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorMashinID = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorCmbMabda = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorCmbMaghsad = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorNoeBar = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorCmbMahalBargiri = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorTarkhEzamBargiri = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorTarikhHozoorMahalBargiri = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorSaatHozoorMahalBargiri = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorTarikhBarnameRaft = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorSaatSodoorBarname = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorTarikhKhoroojMojtame = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorSaatKhoroojMojtame = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX
        Me.btnNew = New DevComponents.DotNetBar.ButtonX
        Me.btnSave = New DevComponents.DotNetBar.ButtonX
        Me.btnTodayList = New DevComponents.DotNetBar.ButtonX
        Me.GroupBox1.SuspendLayout()
        CType(Me.TblMaghsadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMabdaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMahalBargiriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VSelectRanandeganMashinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorCmbRanande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorMashinID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorCmbMabda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorCmbMaghsad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorNoeBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorCmbMahalBargiri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorTarkhEzamBargiri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorTarikhHozoorMahalBargiri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorSaatHozoorMahalBargiri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorTarikhBarnameRaft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorSaatSodoorBarname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorTarikhKhoroojMojtame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorSaatKhoroojMojtame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSaatKhoroojMojtame)
        Me.GroupBox1.Controls.Add(Me.txtSaatSodoorBarname)
        Me.GroupBox1.Controls.Add(Me.txtSaatHozoorMahalBargiri)
        Me.GroupBox1.Controls.Add(Me.txtTarikhKhoroojMojtame)
        Me.GroupBox1.Controls.Add(Me.txtTarikhBarnameRaft)
        Me.GroupBox1.Controls.Add(Me.txtTarikhHozoorMahalBargiri)
        Me.GroupBox1.Controls.Add(Me.txtTarkhEzamBargiri)
        Me.GroupBox1.Controls.Add(Me.cmbMaghsad)
        Me.GroupBox1.Controls.Add(Me.cmbMabda)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtOperationCode)
        Me.GroupBox1.Controls.Add(Me.txtTozihat)
        Me.GroupBox1.Controls.Add(Me.txtNoeBar)
        Me.GroupBox1.Controls.Add(Me.txtMeghdarSookhtKhorooj)
        Me.GroupBox1.Controls.Add(Me.txtKiloometrKhorroojMojtame)
        Me.GroupBox1.Controls.Add(Me.txtShomareBarnameRaft)
        Me.GroupBox1.Controls.Add(Me.txtMashinID)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbMahalBargiri)
        Me.GroupBox1.Controls.Add(Me.cmbRanande)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblPelak)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(957, 400)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "اعزام خودرو"
        '
        'txtSaatKhoroojMojtame
        '
        Me.txtSaatKhoroojMojtame.BorderColor = System.Drawing.Color.Empty
        Me.txtSaatKhoroojMojtame.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSaatKhoroojMojtame.Location = New System.Drawing.Point(522, 353)
        Me.txtSaatKhoroojMojtame.Mask = "00:00"
        Me.txtSaatKhoroojMojtame.Name = "txtSaatKhoroojMojtame"
        Me.txtSaatKhoroojMojtame.NextControl = Nothing
        Me.txtSaatKhoroojMojtame.PrevControl = Nothing
        Me.txtSaatKhoroojMojtame.Size = New System.Drawing.Size(48, 21)
        Me.txtSaatKhoroojMojtame.TabIndex = 19
        Me.txtSaatKhoroojMojtame.ValidatingType = GetType(Date)
        '
        'txtSaatSodoorBarname
        '
        Me.txtSaatSodoorBarname.BorderColor = System.Drawing.Color.Empty
        Me.txtSaatSodoorBarname.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSaatSodoorBarname.Location = New System.Drawing.Point(275, 276)
        Me.txtSaatSodoorBarname.Mask = "00:00"
        Me.txtSaatSodoorBarname.Name = "txtSaatSodoorBarname"
        Me.txtSaatSodoorBarname.NextControl = Nothing
        Me.txtSaatSodoorBarname.PrevControl = Nothing
        Me.txtSaatSodoorBarname.Size = New System.Drawing.Size(48, 21)
        Me.txtSaatSodoorBarname.TabIndex = 15
        Me.txtSaatSodoorBarname.ValidatingType = GetType(Date)
        '
        'txtSaatHozoorMahalBargiri
        '
        Me.txtSaatHozoorMahalBargiri.BorderColor = System.Drawing.Color.Empty
        Me.txtSaatHozoorMahalBargiri.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSaatHozoorMahalBargiri.Location = New System.Drawing.Point(24, 238)
        Me.txtSaatHozoorMahalBargiri.Mask = "00:00"
        Me.txtSaatHozoorMahalBargiri.Name = "txtSaatHozoorMahalBargiri"
        Me.txtSaatHozoorMahalBargiri.NextControl = Nothing
        Me.txtSaatHozoorMahalBargiri.PrevControl = Nothing
        Me.txtSaatHozoorMahalBargiri.Size = New System.Drawing.Size(48, 21)
        Me.txtSaatHozoorMahalBargiri.TabIndex = 12
        Me.txtSaatHozoorMahalBargiri.ValidatingType = GetType(Date)
        '
        'txtTarikhKhoroojMojtame
        '
        Me.txtTarikhKhoroojMojtame.BorderColor = System.Drawing.Color.Empty
        Me.txtTarikhKhoroojMojtame.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTarikhKhoroojMojtame.Location = New System.Drawing.Point(735, 353)
        Me.txtTarikhKhoroojMojtame.Mask = "0000/00/00"
        Me.txtTarikhKhoroojMojtame.Name = "txtTarikhKhoroojMojtame"
        Me.txtTarikhKhoroojMojtame.NextControl = Nothing
        Me.txtTarikhKhoroojMojtame.PrevControl = Nothing
        Me.txtTarikhKhoroojMojtame.Size = New System.Drawing.Size(83, 21)
        Me.txtTarikhKhoroojMojtame.TabIndex = 18
        '
        'txtTarikhBarnameRaft
        '
        Me.txtTarikhBarnameRaft.BorderColor = System.Drawing.Color.Empty
        Me.txtTarikhBarnameRaft.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTarikhBarnameRaft.Location = New System.Drawing.Point(487, 276)
        Me.txtTarikhBarnameRaft.Mask = "0000/00/00"
        Me.txtTarikhBarnameRaft.Name = "txtTarikhBarnameRaft"
        Me.txtTarikhBarnameRaft.NextControl = Nothing
        Me.txtTarikhBarnameRaft.PrevControl = Nothing
        Me.txtTarikhBarnameRaft.Size = New System.Drawing.Size(83, 21)
        Me.txtTarikhBarnameRaft.TabIndex = 14
        '
        'txtTarikhHozoorMahalBargiri
        '
        Me.txtTarikhHozoorMahalBargiri.BorderColor = System.Drawing.Color.Empty
        Me.txtTarikhHozoorMahalBargiri.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTarikhHozoorMahalBargiri.Location = New System.Drawing.Point(240, 237)
        Me.txtTarikhHozoorMahalBargiri.Mask = "0000/00/00"
        Me.txtTarikhHozoorMahalBargiri.Name = "txtTarikhHozoorMahalBargiri"
        Me.txtTarikhHozoorMahalBargiri.NextControl = Nothing
        Me.txtTarikhHozoorMahalBargiri.PrevControl = Nothing
        Me.txtTarikhHozoorMahalBargiri.Size = New System.Drawing.Size(83, 21)
        Me.txtTarikhHozoorMahalBargiri.TabIndex = 11
        '
        'txtTarkhEzamBargiri
        '
        Me.txtTarkhEzamBargiri.BorderColor = System.Drawing.Color.Empty
        Me.txtTarkhEzamBargiri.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTarkhEzamBargiri.Location = New System.Drawing.Point(487, 237)
        Me.txtTarkhEzamBargiri.Mask = "0000/00/00"
        Me.txtTarkhEzamBargiri.Name = "txtTarkhEzamBargiri"
        Me.txtTarkhEzamBargiri.NextControl = Nothing
        Me.txtTarkhEzamBargiri.PrevControl = Nothing
        Me.txtTarkhEzamBargiri.Size = New System.Drawing.Size(83, 21)
        Me.txtTarkhEzamBargiri.TabIndex = 10
        '
        'cmbMaghsad
        '
        Me.cmbMaghsad.DataSource = Me.TblMaghsadBindingSource
        Me.cmbMaghsad.DisplayMember = "NameMaghsad"
        Me.cmbMaghsad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMaghsad.FormattingEnabled = True
        Me.cmbMaghsad.Location = New System.Drawing.Point(422, 116)
        Me.cmbMaghsad.Name = "cmbMaghsad"
        Me.cmbMaghsad.Size = New System.Drawing.Size(148, 21)
        Me.cmbMaghsad.TabIndex = 6
        Me.cmbMaghsad.ValueMember = "MaghsadID"
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
        'cmbMabda
        '
        Me.cmbMabda.DataSource = Me.TblMabdaBindingSource
        Me.cmbMabda.DisplayMember = "NameMabda"
        Me.cmbMabda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMabda.FormattingEnabled = True
        Me.cmbMabda.Location = New System.Drawing.Point(670, 116)
        Me.cmbMabda.Name = "cmbMabda"
        Me.cmbMabda.Size = New System.Drawing.Size(148, 21)
        Me.cmbMabda.TabIndex = 5
        Me.cmbMabda.ValueMember = "MabdaID"
        '
        'TblMabdaBindingSource
        '
        Me.TblMabdaBindingSource.DataMember = "tbl_Mabda"
        Me.TblMabdaBindingSource.DataSource = Me.DsTarabari
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(329, 240)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(136, 13)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "تاریخ حضور در محل بارگیری :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(824, 356)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(105, 13)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "تاریخ خروج از مجتمع :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(576, 240)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "تاریخ اعزام به بارگیری :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(576, 279)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 13)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "تاریخ بارنامه رفت :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(329, 279)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "ساعت صدور بارنامه :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(824, 317)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(117, 13)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "کیلومتر خروج از مجتمع :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(576, 356)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "ساعت خروج از مجتمع :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(576, 162)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(54, 13)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "توضیحات :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(824, 279)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "شماره بارنامه رفت :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(576, 317)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(126, 13)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "اطلاعات سوخت در خروج :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(824, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "محل بارگیری :"
        '
        'txtOperationCode
        '
        Me.txtOperationCode.BorderColor = System.Drawing.Color.Empty
        Me.txtOperationCode.Enabled = False
        Me.txtOperationCode.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOperationCode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtOperationCode.InputMode = Tarabari.AdvancedTextBox.enInputMode.Normal
        Me.txtOperationCode.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtOperationCode.Location = New System.Drawing.Point(735, 37)
        Me.txtOperationCode.MaxLength = 3
        Me.txtOperationCode.Name = "txtOperationCode"
        Me.txtOperationCode.NextControl = Nothing
        Me.txtOperationCode.PrevControl = Nothing
        Me.txtOperationCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOperationCode.Size = New System.Drawing.Size(83, 21)
        Me.txtOperationCode.TabIndex = 2
        '
        'txtTozihat
        '
        Me.txtTozihat.BorderColor = System.Drawing.Color.Empty
        Me.txtTozihat.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTozihat.InputMode = Tarabari.AdvancedTextBox.enInputMode.Normal
        Me.txtTozihat.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtTozihat.Location = New System.Drawing.Point(367, 154)
        Me.txtTozihat.MaxLength = 500
        Me.txtTozihat.Multiline = True
        Me.txtTozihat.Name = "txtTozihat"
        Me.txtTozihat.NextControl = Nothing
        Me.txtTozihat.PrevControl = Nothing
        Me.txtTozihat.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTozihat.Size = New System.Drawing.Size(203, 67)
        Me.txtTozihat.TabIndex = 8
        '
        'txtNoeBar
        '
        Me.txtNoeBar.BorderColor = System.Drawing.Color.Empty
        Me.txtNoeBar.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNoeBar.InputMode = Tarabari.AdvancedTextBox.enInputMode.Normal
        Me.txtNoeBar.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtNoeBar.Location = New System.Drawing.Point(670, 154)
        Me.txtNoeBar.MaxLength = 255
        Me.txtNoeBar.Name = "txtNoeBar"
        Me.txtNoeBar.NextControl = Nothing
        Me.txtNoeBar.PrevControl = Nothing
        Me.txtNoeBar.Size = New System.Drawing.Size(148, 21)
        Me.txtNoeBar.TabIndex = 7
        '
        'txtMeghdarSookhtKhorooj
        '
        Me.txtMeghdarSookhtKhorooj.BorderColor = System.Drawing.Color.Empty
        Me.txtMeghdarSookhtKhorooj.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMeghdarSookhtKhorooj.InputMode = Tarabari.AdvancedTextBox.enInputMode.Number
        Me.txtMeghdarSookhtKhorooj.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtMeghdarSookhtKhorooj.Location = New System.Drawing.Point(487, 314)
        Me.txtMeghdarSookhtKhorooj.MaxLength = 10
        Me.txtMeghdarSookhtKhorooj.Name = "txtMeghdarSookhtKhorooj"
        Me.txtMeghdarSookhtKhorooj.NextControl = Nothing
        Me.txtMeghdarSookhtKhorooj.PrevControl = Nothing
        Me.txtMeghdarSookhtKhorooj.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMeghdarSookhtKhorooj.Size = New System.Drawing.Size(83, 21)
        Me.txtMeghdarSookhtKhorooj.TabIndex = 17
        '
        'txtKiloometrKhorroojMojtame
        '
        Me.txtKiloometrKhorroojMojtame.BorderColor = System.Drawing.Color.Empty
        Me.txtKiloometrKhorroojMojtame.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKiloometrKhorroojMojtame.InputMode = Tarabari.AdvancedTextBox.enInputMode.Number
        Me.txtKiloometrKhorroojMojtame.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtKiloometrKhorroojMojtame.Location = New System.Drawing.Point(735, 314)
        Me.txtKiloometrKhorroojMojtame.MaxLength = 10
        Me.txtKiloometrKhorroojMojtame.Name = "txtKiloometrKhorroojMojtame"
        Me.txtKiloometrKhorroojMojtame.NextControl = Nothing
        Me.txtKiloometrKhorroojMojtame.PrevControl = Nothing
        Me.txtKiloometrKhorroojMojtame.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtKiloometrKhorroojMojtame.Size = New System.Drawing.Size(83, 21)
        Me.txtKiloometrKhorroojMojtame.TabIndex = 16
        '
        'txtShomareBarnameRaft
        '
        Me.txtShomareBarnameRaft.BorderColor = System.Drawing.Color.Empty
        Me.txtShomareBarnameRaft.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtShomareBarnameRaft.InputMode = Tarabari.AdvancedTextBox.enInputMode.Number
        Me.txtShomareBarnameRaft.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtShomareBarnameRaft.Location = New System.Drawing.Point(735, 276)
        Me.txtShomareBarnameRaft.MaxLength = 10
        Me.txtShomareBarnameRaft.Name = "txtShomareBarnameRaft"
        Me.txtShomareBarnameRaft.NextControl = Nothing
        Me.txtShomareBarnameRaft.PrevControl = Nothing
        Me.txtShomareBarnameRaft.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtShomareBarnameRaft.Size = New System.Drawing.Size(83, 21)
        Me.txtShomareBarnameRaft.TabIndex = 13
        '
        'txtMashinID
        '
        Me.txtMashinID.BorderColor = System.Drawing.Color.Empty
        Me.txtMashinID.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMashinID.InputMode = Tarabari.AdvancedTextBox.enInputMode.Number
        Me.txtMashinID.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtMashinID.Location = New System.Drawing.Point(487, 77)
        Me.txtMashinID.MaxLength = 3
        Me.txtMashinID.Name = "txtMashinID"
        Me.txtMashinID.NextControl = Nothing
        Me.txtMashinID.PrevControl = Nothing
        Me.txtMashinID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMashinID.Size = New System.Drawing.Size(83, 21)
        Me.txtMashinID.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(78, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "ساعت حضور در محل بارگیری :"
        '
        'cmbMahalBargiri
        '
        Me.cmbMahalBargiri.DataSource = Me.TblMahalBargiriBindingSource
        Me.cmbMahalBargiri.DisplayMember = "NameMahal"
        Me.cmbMahalBargiri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMahalBargiri.FormattingEnabled = True
        Me.cmbMahalBargiri.Location = New System.Drawing.Point(705, 237)
        Me.cmbMahalBargiri.Name = "cmbMahalBargiri"
        Me.cmbMahalBargiri.Size = New System.Drawing.Size(110, 21)
        Me.cmbMahalBargiri.TabIndex = 9
        Me.cmbMahalBargiri.ValueMember = "MahalBargiriID"
        '
        'TblMahalBargiriBindingSource
        '
        Me.TblMahalBargiriBindingSource.DataMember = "tbl_MahalBargiri"
        Me.TblMahalBargiriBindingSource.DataSource = Me.DsTarabari
        '
        'cmbRanande
        '
        Me.cmbRanande.DataSource = Me.VSelectRanandeganMashinBindingSource
        Me.cmbRanande.DisplayMember = "Fullname"
        Me.cmbRanande.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRanande.FormattingEnabled = True
        Me.cmbRanande.Location = New System.Drawing.Point(670, 77)
        Me.cmbRanande.Name = "cmbRanande"
        Me.cmbRanande.Size = New System.Drawing.Size(148, 21)
        Me.cmbRanande.TabIndex = 3
        Me.cmbRanande.ValueMember = "RanandePersonalCode"
        '
        'VSelectRanandeganMashinBindingSource
        '
        Me.VSelectRanandeganMashinBindingSource.DataMember = "vSelectRanandeganMashin"
        Me.VSelectRanandeganMashinBindingSource.DataSource = Me.DsTarabari
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(824, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "نوع بار :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(824, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "شماره عملیات :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(824, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "راننده :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(576, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "کد تریلی :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(329, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "شماره انتظامی :"
        '
        'lblPelak
        '
        Me.lblPelak.Location = New System.Drawing.Point(201, 77)
        Me.lblPelak.Name = "lblPelak"
        Me.lblPelak.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblPelak.Size = New System.Drawing.Size(122, 19)
        Me.lblPelak.TabIndex = 5
        Me.lblPelak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(576, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "مقصد :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(824, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "مبداء :"
        '
        'VSelectRanandeganMashinTableAdapter
        '
        Me.VSelectRanandeganMashinTableAdapter.ClearBeforeFill = True
        '
        'Tbl_MabdaTableAdapter
        '
        Me.Tbl_MabdaTableAdapter.ClearBeforeFill = True
        '
        'Tbl_MaghsadTableAdapter
        '
        Me.Tbl_MaghsadTableAdapter.ClearBeforeFill = True
        '
        'Tbl_MahalBargiriTableAdapter
        '
        Me.Tbl_MahalBargiriTableAdapter.ClearBeforeFill = True
        '
        'ErrorCmbRanande
        '
        Me.ErrorCmbRanande.ContainerControl = Me
        Me.ErrorCmbRanande.RightToLeft = True
        '
        'ErrorMashinID
        '
        Me.ErrorMashinID.ContainerControl = Me
        Me.ErrorMashinID.RightToLeft = True
        '
        'ErrorCmbMabda
        '
        Me.ErrorCmbMabda.ContainerControl = Me
        Me.ErrorCmbMabda.RightToLeft = True
        '
        'ErrorCmbMaghsad
        '
        Me.ErrorCmbMaghsad.ContainerControl = Me
        Me.ErrorCmbMaghsad.RightToLeft = True
        '
        'ErrorNoeBar
        '
        Me.ErrorNoeBar.ContainerControl = Me
        Me.ErrorNoeBar.RightToLeft = True
        '
        'ErrorCmbMahalBargiri
        '
        Me.ErrorCmbMahalBargiri.ContainerControl = Me
        Me.ErrorCmbMahalBargiri.RightToLeft = True
        '
        'ErrorTarkhEzamBargiri
        '
        Me.ErrorTarkhEzamBargiri.ContainerControl = Me
        Me.ErrorTarkhEzamBargiri.RightToLeft = True
        '
        'ErrorTarikhHozoorMahalBargiri
        '
        Me.ErrorTarikhHozoorMahalBargiri.ContainerControl = Me
        Me.ErrorTarikhHozoorMahalBargiri.RightToLeft = True
        '
        'ErrorSaatHozoorMahalBargiri
        '
        Me.ErrorSaatHozoorMahalBargiri.ContainerControl = Me
        Me.ErrorSaatHozoorMahalBargiri.RightToLeft = True
        '
        'ErrorTarikhBarnameRaft
        '
        Me.ErrorTarikhBarnameRaft.ContainerControl = Me
        Me.ErrorTarikhBarnameRaft.RightToLeft = True
        '
        'ErrorSaatSodoorBarname
        '
        Me.ErrorSaatSodoorBarname.ContainerControl = Me
        Me.ErrorSaatSodoorBarname.RightToLeft = True
        '
        'ErrorTarikhKhoroojMojtame
        '
        Me.ErrorTarikhKhoroojMojtame.ContainerControl = Me
        Me.ErrorTarikhKhoroojMojtame.RightToLeft = True
        '
        'ErrorSaatKhoroojMojtame
        '
        Me.ErrorSaatKhoroojMojtame.ContainerControl = Me
        Me.ErrorSaatKhoroojMojtame.RightToLeft = True
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Image = Global.Tarabari.My.Resources.Resources.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(621, 433)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 31)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "انصراف"
        '
        'btnNew
        '
        Me.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnNew.Image = Global.Tarabari.My.Resources.Resources._New
        Me.btnNew.Location = New System.Drawing.Point(746, 433)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(87, 31)
        Me.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNew.TabIndex = 5
        Me.btnNew.Text = "جدید"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Image = Global.Tarabari.My.Resources.Resources.Save
        Me.btnSave.Location = New System.Drawing.Point(871, 433)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 31)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "ذخیره"
        '
        'btnTodayList
        '
        Me.btnTodayList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnTodayList.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnTodayList.Location = New System.Drawing.Point(495, 433)
        Me.btnTodayList.Name = "btnTodayList"
        Me.btnTodayList.Size = New System.Drawing.Size(87, 31)
        Me.btnTodayList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnTodayList.TabIndex = 7
        Me.btnTodayList.Text = "لیست امروز"
        '
        'frmEzamKhodro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(995, 481)
        Me.Controls.Add(Me.btnTodayList)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmEzamKhodro"
        Me.Text = "اعزام خودرو به ماموریت"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TblMaghsadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMabdaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMahalBargiriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VSelectRanandeganMashinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorCmbRanande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorMashinID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorCmbMabda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorCmbMaghsad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorNoeBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorCmbMahalBargiri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorTarkhEzamBargiri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorTarikhHozoorMahalBargiri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorSaatHozoorMahalBargiri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorTarikhBarnameRaft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorSaatSodoorBarname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorTarikhKhoroojMojtame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorSaatKhoroojMojtame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMashinID As Tarabari.AdvancedTextBox
    Friend WithEvents cmbRanande As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblPelak As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmbMaghsad As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMabda As System.Windows.Forms.ComboBox
    Friend WithEvents txtOperationCode As Tarabari.AdvancedTextBox
    Friend WithEvents txtTozihat As Tarabari.AdvancedTextBox
    Friend WithEvents txtNoeBar As Tarabari.AdvancedTextBox
    Friend WithEvents cmbMahalBargiri As System.Windows.Forms.ComboBox
    Friend WithEvents txtShomareBarnameRaft As Tarabari.AdvancedTextBox
    Friend WithEvents txtMeghdarSookhtKhorooj As Tarabari.AdvancedTextBox
    Friend WithEvents txtKiloometrKhorroojMojtame As Tarabari.AdvancedTextBox
    Friend WithEvents txtTarikhBarnameRaft As Tarabari.AdvancedMaskedTextBox
    Friend WithEvents txtTarikhHozoorMahalBargiri As Tarabari.AdvancedMaskedTextBox
    Friend WithEvents txtTarkhEzamBargiri As Tarabari.AdvancedMaskedTextBox
    Friend WithEvents txtSaatHozoorMahalBargiri As Tarabari.AdvancedMaskedTextBox
    Friend WithEvents txtSaatKhoroojMojtame As Tarabari.AdvancedMaskedTextBox
    Friend WithEvents txtSaatSodoorBarname As Tarabari.AdvancedMaskedTextBox
    Friend WithEvents txtTarikhKhoroojMojtame As Tarabari.AdvancedMaskedTextBox
    Friend WithEvents DsTarabari As Tarabari.dsTarabari
    Friend WithEvents VSelectRanandeganMashinBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VSelectRanandeganMashinTableAdapter As Tarabari.dsTarabariTableAdapters.vSelectRanandeganMashinTableAdapter
    Friend WithEvents TblMabdaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MabdaTableAdapter As Tarabari.dsTarabariTableAdapters.tbl_MabdaTableAdapter
    Friend WithEvents TblMaghsadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MaghsadTableAdapter As Tarabari.dsTarabariTableAdapters.tbl_MaghsadTableAdapter
    Friend WithEvents TblMahalBargiriBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MahalBargiriTableAdapter As Tarabari.dsTarabariTableAdapters.tbl_MahalBargiriTableAdapter
    Friend WithEvents ErrorCmbRanande As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorMashinID As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorCmbMabda As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorCmbMaghsad As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorNoeBar As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorCmbMahalBargiri As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorTarkhEzamBargiri As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorTarikhHozoorMahalBargiri As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorSaatHozoorMahalBargiri As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorTarikhBarnameRaft As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorSaatSodoorBarname As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorTarikhKhoroojMojtame As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorSaatKhoroojMojtame As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnTodayList As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNew As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX

End Class
