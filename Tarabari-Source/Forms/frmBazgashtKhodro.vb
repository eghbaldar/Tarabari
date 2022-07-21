Public Class frmBazgashtKhodro

    Dim NavganBLL As New BLL.Navgan
    Dim CurrentRow As DataRow

    Private Sub WriteData()
        txtKiloometrVoroodMojtame.Text = CurrentRow.Item("KiloometrVoroodMojtame").ToString
        txtMeghdarSookhtVorood.Text = CurrentRow.Item("MeghdarSookhtVorood").ToString
        lblMasafatTeyShode.Text = CurrentRow.Item("MasafatTeyShode").ToString
        lblSookhtMasrafShode.Text = CurrentRow.Item("SookhtMasrafShode").ToString
        txtTarikhHozoorMahalTakhliyeAval.Text = CurrentRow.Item("TarikhHozoorMahalTakhliyeAval").ToString
        txtSaatHozoorMahalTakhliyeAval.Text = CurrentRow.Item("SaatHozoorMahalTakhliyeAval").ToString
        txtTarikhBargiriMojadad.Text = CurrentRow.Item("TarikhBargiriMojadad").ToString
        txtSaatBargiriMojadad.Text = CurrentRow.Item("SaatBargiriMojadad").ToString
        txtTarikhKhoroojMahalTakhliyeAval.Text = CurrentRow.Item("TarikhKhoroojMahalTakhliyeAval").ToString
        txtSaatKhooojMahalTakhliyeAval.Text = CurrentRow.Item("SaatKhooojMahalTakhliyeAval").ToString
        txtShomareBarnameBargasht.Text = CurrentRow.Item("ShomareBarnameBargasht").ToString
        txtTarikhBarnameBargasht.Text = CurrentRow.Item("TarikhBarnameBargasht").ToString
        txtMablaghKerayeRaft.Text = CurrentRow.Item("MablaghKerayeRaft").ToString
        txtMablaghKerayeBargasht.Text = CurrentRow.Item("MablaghKerayeBargasht").ToString
        txtTarikhVoroodMojtame.Text = CurrentRow.Item("TarikhVoroodMojtame").ToString
        txtSaatVoroodMojtame.Text = CurrentRow.Item("SaatVoroodMojtame").ToString
    End Sub

    Private Sub ActiveThisForm(ByVal status As Boolean)
        '
        For Each x As Control In Me.GroupBox1.Controls
            If (TypeOf x Is AdvancedTextBox) Or (TypeOf x Is AdvancedMaskedTextBox) Then
                If x.Name <> "txtOperationCode" Then
                    x.Text = String.Empty
                End If
            End If
        Next
        '
        For Each x As Control In Me.GroupBox1.Controls
            If (TypeOf x Is AdvancedTextBox) Or (TypeOf x Is AdvancedMaskedTextBox) Then
                If x.Name <> "txtOperationCode" Then
                    x.Enabled = status
                    If Not status Then x.BackColor = Color.LightGray Else x.BackColor = Color.White
                End If
            End If
        Next
        '
        If status = False Then CurrentRow = Nothing
        txtTarikhVoroodMojtame.Text = FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(Date.Now).ToString("yyyy/mm/dd")
        txtSaatVoroodMojtame.Text = FormatDateTime(Date.Now, DateFormat.ShortTime)

        lblRanandeName.Text = String.Empty
        lblMashinID.Text = String.Empty
        lblMasafatTeyShode.Text = String.Empty
        lblSookhtMasrafShode.Text = String.Empty
        '
        txtOperationCode.Focus()
        '
    End Sub

    Private Function ValidateForm() As Boolean
        '
        Dim bolResult As Boolean = True
        '
        'کیلومتر ورود به مجتمع
        If txtKiloometrVoroodMojtame.Text = String.Empty Then
            ErrorKiloometrVoroodMojtame.SetError(txtKiloometrVoroodMojtame, "مقدار درخواستی را وارد کنید.")
            bolResult = False
        Else
            ErrorKiloometrVoroodMojtame.SetError(txtKiloometrVoroodMojtame, "")
        End If
        '
        ' مقدار سوخت در ورود
        If txtMeghdarSookhtVorood.Text.Trim = String.Empty Then
            ErrorMeghdarSookhtVorood.SetError(txtMeghdarSookhtVorood, "مقدار درخواستی را وارد کنید.")
            bolResult = False
        Else
            ErrorMeghdarSookhtVorood.SetError(txtMeghdarSookhtVorood, "")
        End If
        '
        ' مبلغ کرایه رفت
        If txtMablaghKerayeRaft.Text.Trim = String.Empty Then
            ErrorMablaghKerayeRaft.SetError(txtMablaghKerayeRaft, "مقدار درخواستی را وارد کنید.")
            bolResult = False
        Else
            ErrorMablaghKerayeRaft.SetError(txtMablaghKerayeRaft, "")
        End If
        '===========================
        '
        ' تاریخ حضور در محل تخلیه اول
        If txtTarikhHozoorMahalTakhliyeAval.Text.Replace("/", "").Trim() <> String.Empty And Utilities.IsPersianDate(txtTarikhHozoorMahalTakhliyeAval.Text) = False Then
            ErrorTarikhHozoorMahalTakhliyeAval.SetError(txtTarikhHozoorMahalTakhliyeAval, "تاریخ درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorTarikhHozoorMahalTakhliyeAval.SetError(txtTarikhHozoorMahalTakhliyeAval, "")
        End If

        ' ساعت حضور در محل تخلیه اول
        If txtSaatHozoorMahalTakhliyeAval.Text.Replace(":", "").Trim() <> String.Empty And IsDate(txtSaatHozoorMahalTakhliyeAval.Text) = False Then
            ErrorSaatHozoorMahalTakhliyeAval.SetError(txtSaatHozoorMahalTakhliyeAval, "مقدار درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorSaatHozoorMahalTakhliyeAval.SetError(txtSaatHozoorMahalTakhliyeAval, "")
        End If
        '====================
        '
        ' تاریخ بارگیری مجدد
        If txtTarikhBargiriMojadad.Text.Replace("/", "").Trim() <> String.Empty And Utilities.IsPersianDate(txtTarikhBargiriMojadad.Text) = False Then
            ErrorTarikhBargiriMojadad.SetError(txtTarikhBargiriMojadad, "تاریخ درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorTarikhBargiriMojadad.SetError(txtTarikhBargiriMojadad, "")
        End If

        ' ساعت بارگیری مجدد
        If txtSaatBargiriMojadad.Text.Replace(":", "").Trim() <> String.Empty And IsDate(txtSaatHozoorMahalTakhliyeAval.Text) = False Then
            ErrorSaatBargiriMojadad.SetError(txtSaatBargiriMojadad, "مقدار درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorSaatBargiriMojadad.SetError(txtSaatBargiriMojadad, "")
        End If
        '==========================
        ' تاریخ خروج از محل تخلیه اول 
        If txtTarikhKhoroojMahalTakhliyeAval.Text.Replace("/", "").Trim() <> String.Empty And Utilities.IsPersianDate(txtTarikhKhoroojMahalTakhliyeAval.Text) = False Then
            ErrorTarikhKhoroojMahalTakhliyeAval.SetError(txtTarikhKhoroojMahalTakhliyeAval, "تاریخ درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorTarikhKhoroojMahalTakhliyeAval.SetError(txtTarikhKhoroojMahalTakhliyeAval, "")
        End If

        ' ساعت خروج از محل تخلیه اول 
        If txtSaatKhooojMahalTakhliyeAval.Text.Replace(":", "").Trim() <> String.Empty And IsDate(txtSaatKhooojMahalTakhliyeAval.Text) = False Then
            ErrorSaatKhooojMahalTakhliyeAval.SetError(txtSaatKhooojMahalTakhliyeAval, "مقدار درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorSaatKhooojMahalTakhliyeAval.SetError(txtSaatKhooojMahalTakhliyeAval, "")
        End If

        '====================
        ' تاریخ بارنامه برگشت 
        If txtTarikhBarnameBargasht.Text.Replace("/", "").Trim() <> String.Empty And Utilities.IsPersianDate(txtTarikhBarnameBargasht.Text) = False Then
            ErrorTarikhBarnameBargasht.SetError(txtTarikhBarnameBargasht, "تاریخ درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorTarikhBarnameBargasht.SetError(txtTarikhBarnameBargasht, "")
        End If
        '
        '================
        ' تاریخ ورود به مجتمع
        If txtTarikhVoroodMojtame.Text.Replace("/", "").Trim() = String.Empty Or Utilities.IsPersianDate(txtTarikhVoroodMojtame.Text) = False Then
            ErrorTarikhVoroodMojtame.SetError(txtTarikhVoroodMojtame, "تاریخ درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorTarikhVoroodMojtame.SetError(txtTarikhVoroodMojtame, "")
        End If
        '
        ' ساعت ورود به مجتمع
        If txtSaatVoroodMojtame.Text.Replace(":", "").Trim() = String.Empty Or IsDate(txtSaatVoroodMojtame.Text) = False Then
            ErrorSaatVoroodMojtame.SetError(txtSaatVoroodMojtame, "مقدار درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorSaatVoroodMojtame.SetError(txtSaatVoroodMojtame, "")
        End If
        '
        Return bolResult
        ''
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        '
        If Not ValidateForm() Then Exit Sub

        If CurrentRow Is Nothing Then Exit Sub
        '
        'TODO : داده ها در هتنگام ذخیره، باید اعتبار سنجی بشود
        NavganBLL.BazgashtKhodro(txtKiloometrVoroodMojtame.Text, _
                                 txtMeghdarSookhtVorood.Text, _
                                 lblMasafatTeyShode.Text, _
                                 lblSookhtMasrafShode.Text, _
                                 txtTarikhHozoorMahalTakhliyeAval.Text, _
                                 txtSaatHozoorMahalTakhliyeAval.Text, _
                                 txtTarikhBargiriMojadad.Text, _
                                 txtSaatBargiriMojadad.Text, _
                                 txtTarikhKhoroojMahalTakhliyeAval.Text, _
                                 txtSaatKhooojMahalTakhliyeAval.Text, _
                                 IIf(txtShomareBarnameBargasht.Text = "", Nothing, txtShomareBarnameBargasht.Text), _
                                 txtTarikhBarnameBargasht.Text, _
                                 IIf(txtMablaghKerayeBargasht.Text = "", Nothing, txtMablaghKerayeBargasht.Text), _
                                 txtMablaghKerayeRaft.Text, _
                                 txtTarikhVoroodMojtame.Text, _
                                 txtSaatVoroodMojtame.Text, _
                                 CurrentRow.Item(0))
        '
        Call ActiveThisForm(False)
        ''
    End Sub

    Private Sub frmBazgashtKhodro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActiveThisForm(False)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtKiloometrVoroodMojtame_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKiloometrVoroodMojtame.Leave
        Try
            lblMasafatTeyShode.Text = txtKiloometrVoroodMojtame.Text - CurrentRow.Item("KiloometrKhorroojMojtame")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtMeghdarSookhtVorood_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMeghdarSookhtVorood.Leave
        Try
            lblSookhtMasrafShode.Text = txtMeghdarSookhtVorood.Text - CurrentRow.Item("MeghdarSookhtKhorooj")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnShowData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowData.Click
        If CurrentRow Is Nothing Then Exit Sub
        Using f As New frmQVEzamKhodro(CurrentRow.Item(0).ToString())
            f.ShowDialog()
        End Using
    End Sub

    Private Sub frmBazgashtKhodro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            If CurrentRow Is Nothing Then Exit Sub
            Using f As New frmQVEzamKhodro(CurrentRow.Item(0).ToString())
                f.ShowDialog()
            End Using
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Using f As New frmSelectNavgan()
            If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtOperationCode.Text = f.OperationCode
            End If
        End Using
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        '
        CurrentRow = NavganBLL.SelectRow(txtOperationCode.Text)

        If CurrentRow IsNot Nothing Then
            Call ActiveThisForm(True)
            Dim RanandeBLL As New BLL.Ranandegan
            Dim dr As DataRow = RanandeBLL.SelectRow(CurrentRow.Item("RanandePersonalCode"))
            lblRanandeName.Text = String.Format("{0} {1}", dr("fname"), dr("lname"))
            lblMashinID.Text = CurrentRow.Item("MashinID")
            If CBool(CurrentRow.Item("DarMamooriyat")) = False Then WriteData()
        Else
            ActiveThisForm(False)
            MessageBox.Show("ماموریتی با این کد وجود ندارد.", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading)
        End If
        '
    End Sub

End Class
