Public Class frmKafi

    Dim KafiBLL As New BLL.Kafi
    Dim EditMode = False

    Private Sub frmKafi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        '
        If Not ValidateForm() Then Exit Sub

        If EditMode = False Then
            KafiBLL.Insert(txtKafiID.Text, txtShasi.Text.Trim(), txtPelak.Text.Trim())
        Else
            KafiBLL.Update(txtShasi.Text.Trim(), txtPelak.Text.Trim(), txtKafiID.Text)
        End If

        Call ClearForm()
        ''
    End Sub

    Private Function ValidateForm() As Boolean
        '
        Dim bolResult As Boolean = True

        If txtShasi.Text.Trim = String.Empty Then
            ErrorShasi.SetError(txtShasi, "داده درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorPelak.SetError(txtShasi, "")
        End If
        '
        If txtPelak.Text.Trim = String.Empty Then
            ErrorPelak.SetError(txtPelak, "داده درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorPelak.SetError(txtPelak, "")
        End If
        '
        Return bolResult
        '
    End Function

    Private Sub ClearForm()
        txtKafiID.Text = KafiBLL.GetKafiID()
        txtShasi.Text = String.Empty
        txtPelak.Text = String.Empty
        Me.Tbl_KafiTableAdapter.Fill(Me.DsTarabari.tbl_Kafi)
        EditMode = False
        txtShasi.Focus()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Call ClearForm()
    End Sub

    Private Sub frmKafi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Tbl_KafiTableAdapter.Fill(Me.DsTarabari.tbl_Kafi)
        ClearForm()
    End Sub

    Private Sub dgvKafiList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvKafiList.CellClick
        '
        If e.ColumnIndex = 3 Then
            Dim result As MsgBoxResult = MessageBox.Show("آیا میخواهید این اطلاعات حذف شود؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading)
            If result = MsgBoxResult.Yes Then
                Dim KafiID As Integer = dgvKafiList.Rows(e.RowIndex).Cells(0).Value
                KafiBLL.Delete(KafiID)
                ClearForm()
            End If
        End If
        ''
    End Sub

    Private Sub dgvKafiList_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvKafiList.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        EditMode = True
        txtKafiID.Text = dgvKafiList.Rows(e.RowIndex).Cells(0).Value
        txtShasi.Text = dgvKafiList.Rows(e.RowIndex).Cells(1).Value
        txtPelak.Text = dgvKafiList.Rows(e.RowIndex).Cells(2).Value
        txtShasi.Focus()
    End Sub

    Private Sub txtPelak_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPelak.Enter, txtShasi.Enter
        InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(New Globalization.CultureInfo("fa-IR"))
    End Sub

    Private Sub txtPelak_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPelak.Leave, txtShasi.Leave
        InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(New Globalization.CultureInfo("en-US"))
    End Sub

End Class
