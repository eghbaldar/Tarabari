<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserInput
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
        Me.pnlMaghsad = New System.Windows.Forms.Panel
        Me.btnOkMaghsad = New DevComponents.DotNetBar.ButtonX
        Me.btnChangeMaghsad = New DevComponents.DotNetBar.ButtonX
        Me.cmbMaghsad = New System.Windows.Forms.ComboBox
        Me.TblMaghsadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTarabari = New Tarabari.dsTarabari
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMaghsad = New Tarabari.AdvancedTextBox(Me.components)
        Me.pnlMabda = New System.Windows.Forms.Panel
        Me.btnOkMabda = New DevComponents.DotNetBar.ButtonX
        Me.btnChangeMabda = New DevComponents.DotNetBar.ButtonX
        Me.cmbMabda = New System.Windows.Forms.ComboBox
        Me.TblMabdaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMabda = New Tarabari.AdvancedTextBox(Me.components)
        Me.pnlTarikh = New System.Windows.Forms.Panel
        Me.btnOkTarikh = New DevComponents.DotNetBar.ButtonX
        Me.txtDate = New Tarabari.AdvancedMaskedTextBox(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.Tbl_MaghsadTableAdapter = New Tarabari.dsTarabariTableAdapters.tbl_MaghsadTableAdapter
        Me.Tbl_MabdaTableAdapter = New Tarabari.dsTarabariTableAdapters.tbl_MabdaTableAdapter
        Me.ErrorDate = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlMaghsad.SuspendLayout()
        CType(Me.TblMaghsadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMabda.SuspendLayout()
        CType(Me.TblMabdaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTarikh.SuspendLayout()
        CType(Me.ErrorDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMaghsad
        '
        Me.pnlMaghsad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMaghsad.Controls.Add(Me.btnOkMaghsad)
        Me.pnlMaghsad.Controls.Add(Me.btnChangeMaghsad)
        Me.pnlMaghsad.Controls.Add(Me.cmbMaghsad)
        Me.pnlMaghsad.Controls.Add(Me.Label1)
        Me.pnlMaghsad.Controls.Add(Me.txtMaghsad)
        Me.pnlMaghsad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMaghsad.Location = New System.Drawing.Point(0, 0)
        Me.pnlMaghsad.Name = "pnlMaghsad"
        Me.pnlMaghsad.Size = New System.Drawing.Size(256, 167)
        Me.pnlMaghsad.TabIndex = 0
        Me.pnlMaghsad.Visible = False
        '
        'btnOkMaghsad
        '
        Me.btnOkMaghsad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOkMaghsad.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOkMaghsad.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOkMaghsad.Location = New System.Drawing.Point(76, 91)
        Me.btnOkMaghsad.Name = "btnOkMaghsad"
        Me.btnOkMaghsad.Size = New System.Drawing.Size(87, 31)
        Me.btnOkMaghsad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnOkMaghsad.TabIndex = 12
        Me.btnOkMaghsad.Text = "تایید"
        '
        'btnChangeMaghsad
        '
        Me.btnChangeMaghsad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnChangeMaghsad.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnChangeMaghsad.Image = Global.Tarabari.My.Resources.Resources.Change
        Me.btnChangeMaghsad.Location = New System.Drawing.Point(18, 40)
        Me.btnChangeMaghsad.Name = "btnChangeMaghsad"
        Me.btnChangeMaghsad.Size = New System.Drawing.Size(28, 23)
        Me.btnChangeMaghsad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnChangeMaghsad.TabIndex = 4
        '
        'cmbMaghsad
        '
        Me.cmbMaghsad.DataSource = Me.TblMaghsadBindingSource
        Me.cmbMaghsad.DisplayMember = "NameMaghsad"
        Me.cmbMaghsad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMaghsad.FormattingEnabled = True
        Me.cmbMaghsad.Location = New System.Drawing.Point(52, 41)
        Me.cmbMaghsad.Name = "cmbMaghsad"
        Me.cmbMaghsad.Size = New System.Drawing.Size(134, 21)
        Me.cmbMaghsad.TabIndex = 2
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "مقصد :"
        '
        'txtMaghsad
        '
        Me.txtMaghsad.BorderColor = System.Drawing.Color.Empty
        Me.txtMaghsad.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMaghsad.InputMode = Tarabari.AdvancedTextBox.enInputMode.Normal
        Me.txtMaghsad.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtMaghsad.Location = New System.Drawing.Point(52, 41)
        Me.txtMaghsad.Name = "txtMaghsad"
        Me.txtMaghsad.NextControl = Nothing
        Me.txtMaghsad.PrevControl = Nothing
        Me.txtMaghsad.Size = New System.Drawing.Size(134, 21)
        Me.txtMaghsad.TabIndex = 5
        Me.txtMaghsad.Visible = False
        '
        'pnlMabda
        '
        Me.pnlMabda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMabda.Controls.Add(Me.btnOkMabda)
        Me.pnlMabda.Controls.Add(Me.btnChangeMabda)
        Me.pnlMabda.Controls.Add(Me.cmbMabda)
        Me.pnlMabda.Controls.Add(Me.Label2)
        Me.pnlMabda.Controls.Add(Me.txtMabda)
        Me.pnlMabda.Location = New System.Drawing.Point(275, 12)
        Me.pnlMabda.Name = "pnlMabda"
        Me.pnlMabda.Size = New System.Drawing.Size(251, 173)
        Me.pnlMabda.TabIndex = 4
        Me.pnlMabda.Visible = False
        '
        'btnOkMabda
        '
        Me.btnOkMabda.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOkMabda.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOkMabda.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOkMabda.Location = New System.Drawing.Point(77, 91)
        Me.btnOkMabda.Name = "btnOkMabda"
        Me.btnOkMabda.Size = New System.Drawing.Size(87, 31)
        Me.btnOkMabda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnOkMabda.TabIndex = 13
        Me.btnOkMabda.Text = "تایید"
        '
        'btnChangeMabda
        '
        Me.btnChangeMabda.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnChangeMabda.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnChangeMabda.Image = Global.Tarabari.My.Resources.Resources.Change
        Me.btnChangeMabda.Location = New System.Drawing.Point(18, 44)
        Me.btnChangeMabda.Name = "btnChangeMabda"
        Me.btnChangeMabda.Size = New System.Drawing.Size(28, 23)
        Me.btnChangeMabda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnChangeMabda.TabIndex = 5
        '
        'cmbMabda
        '
        Me.cmbMabda.DataSource = Me.TblMabdaBindingSource
        Me.cmbMabda.DisplayMember = "NameMabda"
        Me.cmbMabda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMabda.FormattingEnabled = True
        Me.cmbMabda.Location = New System.Drawing.Point(52, 45)
        Me.cmbMabda.Name = "cmbMabda"
        Me.cmbMabda.Size = New System.Drawing.Size(134, 21)
        Me.cmbMabda.TabIndex = 2
        Me.cmbMabda.ValueMember = "MabdaID"
        '
        'TblMabdaBindingSource
        '
        Me.TblMabdaBindingSource.DataMember = "tbl_Mabda"
        Me.TblMabdaBindingSource.DataSource = Me.DsTarabari
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "مبداء :"
        '
        'txtMabda
        '
        Me.txtMabda.BorderColor = System.Drawing.Color.Empty
        Me.txtMabda.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMabda.InputMode = Tarabari.AdvancedTextBox.enInputMode.Normal
        Me.txtMabda.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtMabda.Location = New System.Drawing.Point(52, 45)
        Me.txtMabda.Name = "txtMabda"
        Me.txtMabda.NextControl = Nothing
        Me.txtMabda.PrevControl = Nothing
        Me.txtMabda.Size = New System.Drawing.Size(134, 21)
        Me.txtMabda.TabIndex = 5
        Me.txtMabda.Visible = False
        '
        'pnlTarikh
        '
        Me.pnlTarikh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTarikh.Controls.Add(Me.btnOkTarikh)
        Me.pnlTarikh.Controls.Add(Me.txtDate)
        Me.pnlTarikh.Controls.Add(Me.Label3)
        Me.pnlTarikh.Location = New System.Drawing.Point(12, 196)
        Me.pnlTarikh.Name = "pnlTarikh"
        Me.pnlTarikh.Size = New System.Drawing.Size(246, 167)
        Me.pnlTarikh.TabIndex = 5
        Me.pnlTarikh.Visible = False
        '
        'btnOkTarikh
        '
        Me.btnOkTarikh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOkTarikh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOkTarikh.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOkTarikh.Location = New System.Drawing.Point(73, 96)
        Me.btnOkTarikh.Name = "btnOkTarikh"
        Me.btnOkTarikh.Size = New System.Drawing.Size(87, 31)
        Me.btnOkTarikh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnOkTarikh.TabIndex = 12
        Me.btnOkTarikh.Text = "تایید"
        '
        'txtDate
        '
        Me.txtDate.BorderColor = System.Drawing.Color.Empty
        Me.txtDate.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDate.Location = New System.Drawing.Point(56, 44)
        Me.txtDate.Mask = "0000/00/00"
        Me.txtDate.Name = "txtDate"
        Me.txtDate.NextControl = Nothing
        Me.txtDate.PrevControl = Nothing
        Me.txtDate.Size = New System.Drawing.Size(83, 21)
        Me.txtDate.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(145, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "تاریخ :"
        '
        'Tbl_MaghsadTableAdapter
        '
        Me.Tbl_MaghsadTableAdapter.ClearBeforeFill = True
        '
        'Tbl_MabdaTableAdapter
        '
        Me.Tbl_MabdaTableAdapter.ClearBeforeFill = True
        '
        'ErrorDate
        '
        Me.ErrorDate.ContainerControl = Me
        Me.ErrorDate.RightToLeft = True
        '
        'frmUserInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(256, 167)
        Me.Controls.Add(Me.pnlTarikh)
        Me.Controls.Add(Me.pnlMabda)
        Me.Controls.Add(Me.pnlMaghsad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmUserInput"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ورود داده"
        Me.pnlMaghsad.ResumeLayout(False)
        Me.pnlMaghsad.PerformLayout()
        CType(Me.TblMaghsadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTarabari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMabda.ResumeLayout(False)
        Me.pnlMabda.PerformLayout()
        CType(Me.TblMabdaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTarikh.ResumeLayout(False)
        Me.pnlTarikh.PerformLayout()
        CType(Me.ErrorDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlMaghsad As System.Windows.Forms.Panel
    Friend WithEvents cmbMaghsad As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DsTarabari As Tarabari.dsTarabari
    Friend WithEvents TblMaghsadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MaghsadTableAdapter As Tarabari.dsTarabariTableAdapters.tbl_MaghsadTableAdapter
    Friend WithEvents pnlMabda As System.Windows.Forms.Panel
    Friend WithEvents cmbMabda As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TblMabdaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MabdaTableAdapter As Tarabari.dsTarabariTableAdapters.tbl_MabdaTableAdapter
    Friend WithEvents pnlTarikh As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDate As Tarabari.AdvancedMaskedTextBox
    Friend WithEvents ErrorDate As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnChangeMaghsad As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnChangeMabda As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtMabda As Tarabari.AdvancedTextBox
    Friend WithEvents txtMaghsad As Tarabari.AdvancedTextBox
    Friend WithEvents btnOkMaghsad As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnOkMabda As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnOkTarikh As DevComponents.DotNetBar.ButtonX

End Class
