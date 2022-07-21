Public Class frmSetting

    Dim MySetting As BLL.Setting.ApplicationSetting
    Dim SettingBLL As New BLL.Setting

    Private Sub frmSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        '
        MySetting = SettingBLL.ReadSetting
        '
        txtSahmRanande.Text = MySetting.SahmRanande * 100
        txtHazineGhaza_Raft.Text = MySetting.HazineGhaza_Raft * 100
        txtHazineGhaza_Bargasht.Text = MySetting.HazineGhaza_Bargasht * 100
        txtMablaghSookht.Text = MySetting.MablaghSookht
        txtHaghPayane.Text = MySetting.HaghPayane * 100
        txtKomisionBarname.Text = MySetting.KomisionBarname * 100
        ''
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SettingBLL.UpdateSetting(txtSahmRanande.Text, txtHazineGhaza_Raft.Text, txtHazineGhaza_Bargasht.Text, txtMablaghSookht.Text, txtHaghPayane.Text, txtKomisionBarname.Text)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class