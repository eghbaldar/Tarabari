Public Class frmMabda

    Dim mabdaBLL As New BLL.Mabda
    Dim EditMode = False

    Private Sub frmMabda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        '
        If Not ValidateForm() Then Exit Sub

        If EditMode = False Then
            mabdaBLL.Insert(txtMabda.Text.Trim)
        Else
            mabdaBLL.Update(txtMabda.Text, txtMabda.Tag)
        End If

        Call ClearForm()
        ''
    End Sub

    Private Function ValidateForm() As Boolean
        '
        Dim bolResult As Boolean = True

        If txtMabda.Text.Trim = String.Empty Then
            ErrorProvider1.SetError(txtMabda, "داده درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorProvider1.SetError(txtMabda, "")
        End If
        '
        Return bolResult
        '
    End Function

    Private Sub ClearForm()
        txtMabda.Text = String.Empty
        Me.Tbl_MabdaTableAdapter.Fill(Me.DsTarabari.tbl_Mabda)
        EditMode = False
        txtMabda.Focus()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Call ClearForm()
    End Sub

    Private Sub frmMabda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Tbl_MabdaTableAdapter.Fill(Me.DsTarabari.tbl_Mabda)
    End Sub

    Private Sub dgvMabdaList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMabdaList.CellClick
        '
        If e.ColumnIndex = 3 Then
            Dim result As MsgBoxResult = MsgBox("آیا میخواهید این اطلاعات حذف شود؟", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "حذف رکورد")
            If result = MsgBoxResult.Yes Then
                Dim mdID As Integer = dgvMabdaList.Rows(e.RowIndex).Cells(0).Value
                mabdaBLL.Delete(mdID)
                ClearForm()
            End If
        End If
        ''
    End Sub

    Private Sub dgvMabdaList_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMabdaList.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        EditMode = True
        txtMabda.Text = dgvMabdaList.Rows(e.RowIndex).Cells(2).Value
        txtMabda.Tag = dgvMabdaList.Rows(e.RowIndex).Cells(0).Value
        txtMabda.Focus()
    End Sub

    Private Sub dgvMabdaList_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvMabdaList.CellFormatting
        If e.ColumnIndex = 1 Then e.Value = (e.RowIndex + 1).ToString()
    End Sub

    Private Sub txtMabda_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMabda.Enter
        InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(New Globalization.CultureInfo("fa-IR"))
    End Sub

    Private Sub txtMabda_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMabda.Leave
        InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(New Globalization.CultureInfo("en-US"))
    End Sub

End Class
