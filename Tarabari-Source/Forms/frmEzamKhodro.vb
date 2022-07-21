Public Class frmEzamKhodro

    Dim NavganBLL As New BLL.Navgan

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Call ClearForm()
    End Sub

    Private Sub ClearForm()
        '
        For Each x As Control In Me.GroupBox1.Controls
            If (TypeOf x Is AdvancedTextBox) Or (TypeOf x Is AdvancedMaskedTextBox) Then
                x.Text = String.Empty
            End If
        Next
        '
        cmbMabda.SelectedIndex = -1
        cmbMaghsad.SelectedIndex = -1
        cmbMahalBargiri.SelectedIndex = -1
        cmbRanande.SelectedIndex = -1
        '
        txtOperationCode.Text = NavganBLL.GetCurrentOperationCode()
        txtTarikhKhoroojMojtame.Text = FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(Date.Now).ToString("yyyy/mm/dd")
        txtSaatKhoroojMojtame.Text = FormatDateTime(Date.Now, DateFormat.ShortTime)
        '
        cmbRanande.Focus()
        ''
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        '
        If Not ValidateForm() Then Exit Sub
        '
        NavganBLL.EzamKhodro(txtOperationCode.Text.Trim, cmbRanande.SelectedValue, txtMashinID.Text.Trim, cmbMahalBargiri.SelectedValue, cmbMabda.SelectedValue, _
                             cmbMaghsad.SelectedValue, txtNoeBar.Text.Trim, txtTozihat.Text.Trim, txtTarkhEzamBargiri.Text.Trim, txtTarikhHozoorMahalBargiri.Text.Trim, _
                             txtSaatHozoorMahalBargiri.Text.Trim, txtShomareBarnameRaft.Text, txtTarikhBarnameRaft.Text, txtSaatSodoorBarname.Text.Trim, txtKiloometrKhorroojMojtame.Text.Trim, _
                             txtMeghdarSookhtKhorooj.Text.Trim, txtTarikhKhoroojMojtame.Text.Trim, txtSaatKhoroojMojtame.Text)
        '
        Call ClearForm()
        ''
    End Sub

    Private Function ValidateForm() As Boolean
        Dim bolResult As Boolean = True
        '
        'نام راننده
        If cmbRanande.SelectedIndex < 0 Then
            ErrorCmbRanande.SetError(cmbRanande, "نام راننده را انتخاب کنید")
            bolResult = False
        Else
            ErrorCmbRanande.SetError(cmbRanande, "")
        End If
        '
        'کد ماشین
        If txtMashinID.Text.Trim = String.Empty Then
            ErrorMashinID.SetError(txtMashinID, "شماره ماشین را وارد کنید")
            bolResult = False
        Else
            ErrorMashinID.SetError(txtMashinID, "")
        End If
        '
        'مبداء
        If cmbMabda.SelectedIndex < 0 Then
            ErrorCmbMabda.SetError(cmbMabda, "مبداء را انتخاب کنید")
            bolResult = False
        Else
            ErrorCmbMabda.SetError(cmbMabda, "")
        End If
        '
        'مقصد
        If cmbMaghsad.SelectedIndex < 0 Then
            ErrorCmbMaghsad.SetError(cmbMaghsad, "مقصد را انتخاب کنید")
            bolResult = False
        Else
            ErrorCmbMaghsad.SetError(cmbMaghsad, "")
        End If
        '
        'محل بارگیری
        If cmbMahalBargiri.SelectedIndex < 0 Then
            ErrorCmbMahalBargiri.SetError(cmbMahalBargiri, "محل بارگیری را انتخاب کنید")
            bolResult = False
        Else
            ErrorCmbMahalBargiri.SetError(cmbMahalBargiri, "")
        End If
        '
        'تاریخ اعزام به بارگیری
        If txtTarkhEzamBargiri.Text.Replace("/", "").Trim() = String.Empty Or Utilities.IsPersianDate(txtTarkhEzamBargiri.Text) = False Then
            ErrorTarkhEzamBargiri.SetError(txtTarkhEzamBargiri, "تاریخ درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorTarkhEzamBargiri.SetError(txtTarkhEzamBargiri, "")
        End If
        '
        'تاریخ حضور در محل بارگیری
        If txtTarikhHozoorMahalBargiri.Text.Replace("/", "").Trim() = String.Empty Or Utilities.IsPersianDate(txtTarikhHozoorMahalBargiri.Text) = False Then
            ErrorTarikhHozoorMahalBargiri.SetError(txtTarikhHozoorMahalBargiri, "تاریخ درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorTarikhHozoorMahalBargiri.SetError(txtTarikhHozoorMahalBargiri, "")
        End If
        '
        'ساعت حضور در محل بارگیری
        If txtSaatHozoorMahalBargiri.Text.Replace(":", "").Trim() = String.Empty Or IsDate(txtSaatHozoorMahalBargiri.Text) = False Then
            ErrorSaatHozoorMahalBargiri.SetError(txtSaatHozoorMahalBargiri, "مقدار درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorSaatHozoorMahalBargiri.SetError(txtSaatHozoorMahalBargiri, "")
        End If
        '
        ''شماره بارنامه رفت
        'If txtShomareBarnameRaft.Text.Trim = String.Empty Then
        '    ErrorShomareBarnameRaft.SetError(txtShomareBarnameRaft, "مقدار درخواستی را وارد کنید")
        '    bolResult = False
        'Else
        '    ErrorShomareBarnameRaft.SetError(txtShomareBarnameRaft, "")
        'End If
        '
        'تاریخ بارنامه رفت
        If txtTarikhBarnameRaft.Text.Replace("/", "").Trim() = String.Empty Or Utilities.IsPersianDate(txtTarikhBarnameRaft.Text) = False Then
            ErrorTarikhBarnameRaft.SetError(txtTarikhBarnameRaft, "تاریخ درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorTarikhBarnameRaft.SetError(txtTarikhBarnameRaft, "")
        End If
        '
        'ساعت صدور بارنامه
        If txtSaatSodoorBarname.Text.Replace(":", "").Trim() = String.Empty Or IsDate(txtSaatSodoorBarname.Text) = False Then
            ErrorSaatSodoorBarname.SetError(txtSaatSodoorBarname, "مقدار درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorSaatSodoorBarname.SetError(txtSaatSodoorBarname, "")
        End If
        '
        ''کیلومتر خروج از مجتمع
        'If txtKiloometrKhorroojMojtame.Text.Trim = String.Empty Then
        '    ErrorKiloometrKhorroojMojtame.SetError(txtKiloometrKhorroojMojtame, "مقدار درخواستی را وارد کنید")
        '    bolResult = False
        'Else
        '    ErrorKiloometrKhorroojMojtame.SetError(txtKiloometrKhorroojMojtame, "")
        'End If
        '
        ''مقدار سوخت در خروج
        'If txtMeghdarSookhtKhorooj.Text.Trim = String.Empty Then
        '    ErrorMeghdarSookhtKhorooj.SetError(txtMeghdarSookhtKhorooj, "مقدار درخواستی را وارد کنید")
        '    bolResult = False
        'Else
        '    ErrorMeghdarSookhtKhorooj.SetError(txtMeghdarSookhtKhorooj, "")
        'End If
        '
        'تاریخ خروج از مجتمع
        If txtTarikhKhoroojMojtame.Text.Replace("/", "").Trim() = String.Empty Or Utilities.IsPersianDate(txtTarikhKhoroojMojtame.Text) = False Then
            ErrorTarikhKhoroojMojtame.SetError(txtTarikhKhoroojMojtame, "تاریخ درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorTarikhKhoroojMojtame.SetError(txtTarikhKhoroojMojtame, "")
        End If
        '
        'ساعت خروج از مجتمع
        If txtSaatKhoroojMojtame.Text.Replace(":", "").Trim() = String.Empty Or IsDate(txtSaatKhoroojMojtame.Text) = False Then
            ErrorSaatKhoroojMojtame.SetError(txtSaatKhoroojMojtame, "مقدار درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorSaatKhoroojMojtame.SetError(txtSaatKhoroojMojtame, "")
        End If
        '
        Return bolResult
        ''
    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmEzamKhodro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_MahalBargiriTableAdapter.Fill(Me.DsTarabari.tbl_MahalBargiri)
        Me.Tbl_MaghsadTableAdapter.Fill(Me.DsTarabari.tbl_Maghsad)
        Me.Tbl_MabdaTableAdapter.Fill(Me.DsTarabari.tbl_Mabda)
        Me.VSelectRanandeganMashinTableAdapter.Fill(Me.DsTarabari.vSelectRanandeganMashin)
        '
        Call ClearForm()
    End Sub

    Private Sub cmbRanande_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRanande.SelectedIndexChanged
        '
        Dim mrBLL As New BLL.Ranandegan
        Dim intResul As Integer = mrBLL.GetMashinIDByPersonalCode(cmbRanande.SelectedValue)
        If intResul <> 0 Then txtMashinID.Text = intResul
        ''
    End Sub

    Private Sub txtMashinID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMashinID.TextChanged
        '
        Dim MashinBLL As New BLL.Mashin
        Try
            lblPelak.Text = MashinBLL.GetPelakByMashinID(txtMashinID.Text)
        Catch ex As Exception
            lblPelak.Text = String.Empty
        End Try
        ''
    End Sub

    Private Sub btnTodayList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTodayList.Click
        'TODO: لیست خودروهای اعزامی امروز
        Using f As New frmNavganList()
            f.ShowDialog()
        End Using
    End Sub

End Class