Public Class frmMahalBargiri

    Dim mbBLL As New BLL.MahalBargiri
    Dim EditMode = False

    Private Sub frmMahalBargiri_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        '
        If Not ValidateForm() Then Exit Sub

        If EditMode = False Then
            mbBLL.Insert(txtMahalBargiri.Text.Trim)
        Else
            mbBLL.Update(txtMahalBargiri.Text, txtMahalBargiri.Tag)
        End If

        Call ClearForm()
        ''
    End Sub

    Private Function ValidateForm() As Boolean
        '
        Dim bolResult As Boolean = True

        If txtMahalBargiri.Text.Trim = String.Empty Then
            ErrorProvider1.SetError(txtMahalBargiri, "داده درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorProvider1.SetError(txtMahalBargiri, "")
        End If
        '
        Return bolResult
        '
    End Function

    Private Sub ClearForm()
        txtMahalBargiri.Text = String.Empty
        Me.Tbl_MahalBargiriTableAdapter.Fill(Me.DsTarabari.tbl_MahalBargiri)
        EditMode = False
        txtMahalBargiri.Focus()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Call ClearForm()
    End Sub

    Private Sub frmMahalBargiri_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Tbl_MahalBargiriTableAdapter.Fill(Me.DsTarabari.tbl_MahalBargiri)
    End Sub

    Private Sub dgvMahalBargiriList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMahalBargiriList.CellClick
        '
        If e.ColumnIndex = 3 Then
            Dim result As MsgBoxResult = MsgBox("آیا میخواهید این اطلاعات حذف شود؟", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "حذف رکورد")
            If result = MsgBoxResult.Yes Then
                Dim mdID As Integer = dgvMahalBargiriList.Rows(e.RowIndex).Cells(0).Value
                mbBLL.Delete(mdID)
                ClearForm()
            End If
        End If
        ''
    End Sub

    Private Sub dgvMahalBargiriList_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMahalBargiriList.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        EditMode = True
        txtMahalBargiri.Text = dgvMahalBargiriList.Rows(e.RowIndex).Cells(2).Value
        txtMahalBargiri.Tag = dgvMahalBargiriList.Rows(e.RowIndex).Cells(0).Value
        txtMahalBargiri.Focus()
    End Sub

    Private Sub dgvMahalBargiriList_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvMahalBargiriList.CellFormatting
        If e.ColumnIndex = 1 Then e.Value = (e.RowIndex + 1).ToString()
    End Sub

    Private Sub txtMahalBargiri_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMahalBargiri.Enter
        InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(New Globalization.CultureInfo("fa-IR"))
    End Sub

    Private Sub txtMahalBargiri_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMahalBargiri.Leave
        InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(New Globalization.CultureInfo("en-US"))
    End Sub

End Class