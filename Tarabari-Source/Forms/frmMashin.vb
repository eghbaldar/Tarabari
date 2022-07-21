Public Class frmMashin

    Dim mashinBLL As New BLL.Mashin
    Dim EditMode = False

    Private Sub frmMashin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        '
        If Not ValidateForm() Then Exit Sub

        If EditMode = False Then
            mashinBLL.Insert(txtMashinID.Text, cmbKafi.SelectedValue, txtPelak.Text, txtShasiNumber.Text, txtMotorNumber.Text)
        Else
            mashinBLL.Update(txtMashinID.Text, cmbKafi.SelectedValue, txtPelak.Text, txtShasiNumber.Text, txtMotorNumber.Text)
        End If

        Call ClearForm()
        ''
    End Sub

    Private Function ValidateForm() As Boolean
        '
        Dim bolResult As Boolean = True

        If txtPelak.Text.Trim = String.Empty Then
            ErrorPelak.SetError(txtPelak, "داده درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorPelak.SetError(txtPelak, "")
        End If

        If cmbKafi.SelectedIndex < 0 Then
            ErrorCodeKafi.SetError(cmbKafi, "شماره کفی را مشخص کنید")
            bolResult = False
        Else
            ErrorCodeKafi.SetError(cmbKafi, "")
        End If

        '
        Return bolResult
        '
    End Function

    Private Sub ClearForm()
        txtMashinID.Text = mashinBLL.GetMashinID()
        If cmbKafi.Items.Count >= 1 Then cmbKafi.SelectedIndex = 0
        txtPelak.Text = String.Empty
        txtShasiNumber.Text = String.Empty
        txtMotorNumber.Text = String.Empty
        Me.Tbl_MashinTableAdapter.Fill(Me.DsTarabari.tbl_Mashin)
        EditMode = False
        cmbKafi.Focus()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Call ClearForm()
    End Sub

    Private Sub frmMashin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Tbl_KafiTableAdapter.Fill(Me.DsTarabari.tbl_Kafi)
        Me.Tbl_MashinTableAdapter.Fill(Me.DsTarabari.tbl_Mashin)
        ClearForm()
    End Sub

    Private Sub dgvMashinList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMashinList.CellClick
        '
        If e.ColumnIndex = 5 Then
            Dim result As MsgBoxResult = MsgBox("آیا میخواهید این اطلاعات حذف شود؟", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "حذف رکورد")
            If result = MsgBoxResult.Yes Then
                Dim mashinID As Integer = dgvMashinList.Rows(e.RowIndex).Cells(0).Value
                mashinBLL.Delete(mashinID)
                ClearForm()
            End If
        End If
        ''
    End Sub

    Private Sub dgvMashinList_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMashinList.CellDoubleClick
        '
        If e.RowIndex < 0 Then Exit Sub
        '
        EditMode = True
        txtMashinID.Text = dgvMashinList.Rows(e.RowIndex).Cells(0).Value
        cmbKafi.SelectedValue = dgvMashinList.Rows(e.RowIndex).Cells(1).Value
        txtPelak.Text = dgvMashinList.Rows(e.RowIndex).Cells(2).Value
        txtShasiNumber.Text = dgvMashinList.Rows(e.RowIndex).Cells(3).Value
        txtMotorNumber.Text = dgvMashinList.Rows(e.RowIndex).Cells(4).Value
        cmbKafi.Focus()
        ''
    End Sub

    Private Sub txtPelak_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPelak.Enter, txtShasiNumber.Enter, txtMotorNumber.Enter
        InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(New Globalization.CultureInfo("fa-IR"))
    End Sub

    Private Sub txtPelak_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPelak.Leave, txtShasiNumber.Leave, txtMotorNumber.Leave
        InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(New Globalization.CultureInfo("en-US"))
    End Sub

End Class