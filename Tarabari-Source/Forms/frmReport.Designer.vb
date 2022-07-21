<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.rptKarkardeRoozane1 = New Tarabari.rptKarkardeRoozane
        Me.rptBargeEzam1 = New Tarabari.rptBargeEzam
        Me.rptTankhah1 = New Tarabari.rptTankhah
        Me.rptSanadNaghdi1 = New Tarabari.rptSanadNaghdi
        Me.rptSanadBarname1 = New Tarabari.rptSanadBarname
        Me.rptPardakhtFactorPrice1 = New Tarabari.rptPardakhtFactorPrice
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(737, 487)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(737, 487)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.MaximizeBox = True
        Me.Name = "frmReport"
        Me.Text = "پیش نمایش گزارشات"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptKarkardeRoozane1 As Tarabari.rptKarkardeRoozane
    Friend WithEvents rptBargeEzam1 As Tarabari.rptBargeEzam
    Friend WithEvents rptTankhah1 As Tarabari.rptTankhah
    Friend WithEvents rptSanadNaghdi1 As Tarabari.rptSanadNaghdi
    Friend WithEvents rptSanadBarname1 As Tarabari.rptSanadBarname
    Friend WithEvents rptPardakhtFactorPrice1 As Tarabari.rptPardakhtFactorPrice

End Class
