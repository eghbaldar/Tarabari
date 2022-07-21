<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetting
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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btnSave = New DevComponents.DotNetBar.ButtonX
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtKomisionBarname = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtHaghPayane = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtMablaghSookht = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtHazineGhaza_Bargasht = New Tarabari.AdvancedTextBox(Me.components)
        Me.txtHazineGhaza_Raft = New Tarabari.AdvancedTextBox(Me.components)
        Me.txtSahmRanande = New Tarabari.AdvancedTextBox(Me.components)
        Me.btnExit = New DevComponents.DotNetBar.ButtonX
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(371, 353)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.txtKomisionBarname)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtHaghPayane)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtMablaghSookht)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtHazineGhaza_Bargasht)
        Me.TabPage1.Controls.Add(Me.txtHazineGhaza_Raft)
        Me.TabPage1.Controls.Add(Me.txtSahmRanande)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(363, 327)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "سند بارنامه ای"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Image = Global.Tarabari.My.Resources.Resources.Save
        Me.btnSave.Location = New System.Drawing.Point(253, 275)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 31)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "ذخیره"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(85, 226)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "درصد"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(222, 226)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "درصد محاسبه کمیسیون :"
        '
        'txtKomisionBarname
        '
        Me.txtKomisionBarname.BorderColor = System.Drawing.Color.Empty
        Me.txtKomisionBarname.FocusColor = System.Drawing.Color.Empty
        Me.txtKomisionBarname.InputMode = Tarabari.AdvancedTextBox.enInputMode.Number
        Me.txtKomisionBarname.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtKomisionBarname.Location = New System.Drawing.Point(122, 223)
        Me.txtKomisionBarname.MaxLength = 2
        Me.txtKomisionBarname.Name = "txtKomisionBarname"
        Me.txtKomisionBarname.NextControl = Nothing
        Me.txtKomisionBarname.PrevControl = Nothing
        Me.txtKomisionBarname.Size = New System.Drawing.Size(62, 21)
        Me.txtKomisionBarname.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(85, 188)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "درصد"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(225, 188)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "درصد محاسبه حق پایانه :"
        '
        'txtHaghPayane
        '
        Me.txtHaghPayane.BorderColor = System.Drawing.Color.Empty
        Me.txtHaghPayane.FocusColor = System.Drawing.Color.Empty
        Me.txtHaghPayane.InputMode = Tarabari.AdvancedTextBox.enInputMode.Number
        Me.txtHaghPayane.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtHaghPayane.Location = New System.Drawing.Point(122, 185)
        Me.txtHaghPayane.MaxLength = 2
        Me.txtHaghPayane.Name = "txtHaghPayane"
        Me.txtHaghPayane.NextControl = Nothing
        Me.txtHaghPayane.PrevControl = Nothing
        Me.txtHaghPayane.Size = New System.Drawing.Size(62, 21)
        Me.txtHaghPayane.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(92, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "ریال"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(230, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "مبلغ سوخت تایید شده :"
        '
        'txtMablaghSookht
        '
        Me.txtMablaghSookht.BorderColor = System.Drawing.Color.Empty
        Me.txtMablaghSookht.FocusColor = System.Drawing.Color.Empty
        Me.txtMablaghSookht.InputMode = Tarabari.AdvancedTextBox.enInputMode.Number
        Me.txtMablaghSookht.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtMablaghSookht.Location = New System.Drawing.Point(122, 147)
        Me.txtMablaghSookht.MaxLength = 5
        Me.txtMablaghSookht.Name = "txtMablaghSookht"
        Me.txtMablaghSookht.NextControl = Nothing
        Me.txtMablaghSookht.PrevControl = Nothing
        Me.txtMablaghSookht.Size = New System.Drawing.Size(62, 21)
        Me.txtMablaghSookht.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(85, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "درصد"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(85, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "درصد"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "درصد"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(190, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "درصد کمک هزینه غذا - برگشت :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "درصد کمک هزینه غذا - رفت :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(253, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "درصد سهم راننده :"
        '
        'txtHazineGhaza_Bargasht
        '
        Me.txtHazineGhaza_Bargasht.BorderColor = System.Drawing.Color.Empty
        Me.txtHazineGhaza_Bargasht.FocusColor = System.Drawing.Color.Empty
        Me.txtHazineGhaza_Bargasht.InputMode = Tarabari.AdvancedTextBox.enInputMode.Number
        Me.txtHazineGhaza_Bargasht.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtHazineGhaza_Bargasht.Location = New System.Drawing.Point(122, 108)
        Me.txtHazineGhaza_Bargasht.MaxLength = 2
        Me.txtHazineGhaza_Bargasht.Name = "txtHazineGhaza_Bargasht"
        Me.txtHazineGhaza_Bargasht.NextControl = Nothing
        Me.txtHazineGhaza_Bargasht.PrevControl = Nothing
        Me.txtHazineGhaza_Bargasht.Size = New System.Drawing.Size(62, 21)
        Me.txtHazineGhaza_Bargasht.TabIndex = 3
        '
        'txtHazineGhaza_Raft
        '
        Me.txtHazineGhaza_Raft.BorderColor = System.Drawing.Color.Empty
        Me.txtHazineGhaza_Raft.FocusColor = System.Drawing.Color.Empty
        Me.txtHazineGhaza_Raft.InputMode = Tarabari.AdvancedTextBox.enInputMode.Number
        Me.txtHazineGhaza_Raft.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtHazineGhaza_Raft.Location = New System.Drawing.Point(122, 70)
        Me.txtHazineGhaza_Raft.MaxLength = 2
        Me.txtHazineGhaza_Raft.Name = "txtHazineGhaza_Raft"
        Me.txtHazineGhaza_Raft.NextControl = Nothing
        Me.txtHazineGhaza_Raft.PrevControl = Nothing
        Me.txtHazineGhaza_Raft.Size = New System.Drawing.Size(62, 21)
        Me.txtHazineGhaza_Raft.TabIndex = 2
        '
        'txtSahmRanande
        '
        Me.txtSahmRanande.BorderColor = System.Drawing.Color.Empty
        Me.txtSahmRanande.FocusColor = System.Drawing.Color.Empty
        Me.txtSahmRanande.InputMode = Tarabari.AdvancedTextBox.enInputMode.Number
        Me.txtSahmRanande.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtSahmRanande.Location = New System.Drawing.Point(122, 32)
        Me.txtSahmRanande.MaxLength = 2
        Me.txtSahmRanande.Name = "txtSahmRanande"
        Me.txtSahmRanande.NextControl = Nothing
        Me.txtSahmRanande.PrevControl = Nothing
        Me.txtSahmRanande.Size = New System.Drawing.Size(62, 21)
        Me.txtSahmRanande.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Image = Global.Tarabari.My.Resources.Resources._Exit
        Me.btnExit.Location = New System.Drawing.Point(16, 375)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 31)
        Me.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "خروج"
        '
        'frmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(396, 416)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.TabControl1)
        Me.KeyPreview = True
        Me.Name = "frmSetting"
        Me.Text = "تنظیمات نرم افزار"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtSahmRanande As Tarabari.AdvancedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtHazineGhaza_Bargasht As Tarabari.AdvancedTextBox
    Friend WithEvents txtHazineGhaza_Raft As Tarabari.AdvancedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMablaghSookht As Tarabari.AdvancedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtKomisionBarname As Tarabari.AdvancedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtHaghPayane As Tarabari.AdvancedTextBox
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnExit As DevComponents.DotNetBar.ButtonX

End Class
