<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstallDB
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbServerName = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblWait = New System.Windows.Forms.Label
        Me.btnStart = New DevComponents.DotNetBar.ButtonX
        Me.lblStep1 = New System.Windows.Forms.Label
        Me.lblStep2 = New System.Windows.Forms.Label
        Me.lblStep3 = New System.Windows.Forms.Label
        Me.btnOk = New DevComponents.DotNetBar.ButtonX
        Me.chkInstallDB = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "در کادر زیر نام سرور بانک اطلاعاتی را مشخص کنید."
        '
        'cmbServerName
        '
        Me.cmbServerName.FormattingEnabled = True
        Me.cmbServerName.Location = New System.Drawing.Point(182, 74)
        Me.cmbServerName.Name = "cmbServerName"
        Me.cmbServerName.Size = New System.Drawing.Size(145, 21)
        Me.cmbServerName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(333, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "نام سرور :"
        '
        'lblWait
        '
        Me.lblWait.AutoSize = True
        Me.lblWait.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblWait.Location = New System.Drawing.Point(161, 160)
        Me.lblWait.Name = "lblWait"
        Me.lblWait.Size = New System.Drawing.Size(116, 13)
        Me.lblWait.TabIndex = 3
        Me.lblWait.Text = "لطفا کمی صبر کنید...."
        Me.lblWait.Visible = False
        '
        'btnStart
        '
        Me.btnStart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnStart.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnStart.Location = New System.Drawing.Point(61, 103)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(87, 31)
        Me.btnStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnStart.TabIndex = 12
        Me.btnStart.Text = "شروع عملیات"
        '
        'lblStep1
        '
        Me.lblStep1.AutoSize = True
        Me.lblStep1.Location = New System.Drawing.Point(249, 203)
        Me.lblStep1.Name = "lblStep1"
        Me.lblStep1.Size = New System.Drawing.Size(81, 13)
        Me.lblStep1.TabIndex = 13
        Me.lblStep1.Text = "شناسایی سرور"
        Me.lblStep1.Visible = False
        '
        'lblStep2
        '
        Me.lblStep2.AutoSize = True
        Me.lblStep2.Location = New System.Drawing.Point(233, 236)
        Me.lblStep2.Name = "lblStep2"
        Me.lblStep2.Size = New System.Drawing.Size(97, 13)
        Me.lblStep2.TabIndex = 13
        Me.lblStep2.Text = "نصب بانک اطلاعاتی"
        Me.lblStep2.Visible = False
        '
        'lblStep3
        '
        Me.lblStep3.AutoSize = True
        Me.lblStep3.Location = New System.Drawing.Point(263, 269)
        Me.lblStep3.Name = "lblStep3"
        Me.lblStep3.Size = New System.Drawing.Size(67, 13)
        Me.lblStep3.TabIndex = 13
        Me.lblStep3.Text = "اتمام عملیات"
        Me.lblStep3.Visible = False
        '
        'btnOk
        '
        Me.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOk.Enabled = False
        Me.btnOk.Location = New System.Drawing.Point(161, 305)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(87, 31)
        Me.btnOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnOk.TabIndex = 14
        Me.btnOk.Text = "تایید"
        '
        'chkInstallDB
        '
        Me.chkInstallDB.AutoSize = True
        Me.chkInstallDB.Location = New System.Drawing.Point(241, 117)
        Me.chkInstallDB.Name = "chkInstallDB"
        Me.chkInstallDB.Size = New System.Drawing.Size(144, 17)
        Me.chkInstallDB.TabIndex = 15
        Me.chkInstallDB.Text = "بانک اطلاعاتی نصب شود."
        Me.chkInstallDB.UseVisualStyleBackColor = True
        '
        'frmInstallDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(424, 359)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkInstallDB)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblStep3)
        Me.Controls.Add(Me.lblStep2)
        Me.Controls.Add(Me.lblStep1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblWait)
        Me.Controls.Add(Me.cmbServerName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmInstallDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "پیکر بندی نرم افزار"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbServerName As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblWait As System.Windows.Forms.Label
    Friend WithEvents btnStart As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblStep1 As System.Windows.Forms.Label
    Friend WithEvents lblStep2 As System.Windows.Forms.Label
    Friend WithEvents lblStep3 As System.Windows.Forms.Label
    Friend WithEvents btnOk As DevComponents.DotNetBar.ButtonX
    Friend WithEvents chkInstallDB As System.Windows.Forms.CheckBox

End Class
