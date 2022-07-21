Imports System.Windows.Forms

Public Class frmMain

    Private Sub MahalBargiriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MahalBargiriToolStripMenuItem.Click
        Dim f As New frmMahalBargiri()
        f.Icon = Me.Icon
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MabdaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MabdaToolStripMenuItem.Click
        Dim f As New frmMabda()
        f.Icon = Me.Icon
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MaghsadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaghsadToolStripMenuItem.Click
        Dim f As New frmMaghsad()
        f.Icon = Me.Icon
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MashinToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MashinToolStripMenuItem.Click
        Dim f As New frmMashin
        f.Icon = Me.Icon
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub RanandeganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RanandeganToolStripMenuItem.Click
        Dim f As New frmRanandegan
        f.Icon = Me.Icon
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub EzamToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EzamToolStripMenuItem.Click
        Dim f As New frmEzamKhodro
        f.Icon = Me.Icon
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub BazgashtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BazgashtToolStripMenuItem.Click
        Dim f As New frmBazgashtKhodro
        f.Icon = Me.Icon
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub NewFactorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewFactorToolStripMenuItem.Click
        Dim frm As New frmFactorTamirgah
        frm.Icon = Me.Icon
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub FactorListoolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FactorListoolStripMenuItem.Click
        Dim f As New frmFactorList
        f.Icon = Me.Icon
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub SumaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SumaryToolStripMenuItem.Click
        Dim f As New frmSummaryFactors
        f.Icon = Me.Icon
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub VaziyatNavganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VaziyatNavganToolStripMenuItem.Click
        Dim f As New frmNavganStatus
        f.Icon = Me.Icon
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ListMashinToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListMashinToolStripMenuItem.Click
        Dim f As New frmNavganList
        f.Icon = Me.Icon
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub KarkardeRoozaneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KarkardeRoozaneToolStripMenuItem.Click
        Dim f As New frmKarkardRoozane
        f.Icon = Me.Icon
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
        Dim f As New frmAbout()
        f.Icon = Me.Icon
        f.ShowDialog()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.TarabariLogo
    End Sub

    Private Sub AddSanadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSanadToolStripMenuItem.Click
        Dim f As New frmAddEditSanad()
        f.Icon = Me.Icon
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub TankhahToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TankhahToolStripMenuItem1.Click
        Dim f As New frmTankhah
        f.Icon = Me.Icon
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub TankhahListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TankhahListToolStripMenuItem.Click
        Dim f As New frmTankhahList
        f.Icon = Me.Icon
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSetting.Click
        Dim f As New frmSetting
        f.Icon = Me.Icon
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub SanadListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SanadListToolStripMenuItem.Click
        Dim f As New frmSanadList
        f.Icon = Me.Icon
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub SanadNaghdiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SanadNaghdiToolStripMenuItem.Click
        Dim f As New frmSanadPardakhtNaghdiList
        f.Icon = Me.Icon
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub KafiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KafiToolStripMenuItem.Click
        Dim f As New frmKafi
        f.Icon = Me.Icon
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub UserManagerItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserManagerItem.Click
        Dim f As New frmUsers
        f.Icon = Me.Icon
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ChangePasswordItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordItem.Click
        Dim f As New frmChangePassword
        f.Icon = Me.Icon
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ExitProcess()
        '
        Dim MembershipBLL As New BLL.Membership
        Dim pdate As String = FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(Date.Now).ToString("yyyy/mm/dd")
        Dim time As String = FormatDateTime(Date.Now, DateFormat.ShortTime)
        MembershipBLL.HistoryLogout(Utilities.hID, pdate, time)
        '
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim dResult As DialogResult = MessageBox.Show("آیا از برنامه خارج می شوید؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading)
        If dResult = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            ExitProcess()
            'Application.Exit()
            End
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

End Class
