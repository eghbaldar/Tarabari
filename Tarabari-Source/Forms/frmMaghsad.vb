Public Class frmMaghsad

    Dim maghsadBLL As New BLL.Maghsad
    Dim EditMode = False

    Private Sub frmMaghsad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        '
        If Not ValidateForm() Then Exit Sub

        If EditMode = False Then
            maghsadBLL.Insert(txtMaghsad.Text.Trim)
        Else
            maghsadBLL.Update(txtMaghsad.Text, txtMaghsad.Tag)
        End If

        Call ClearForm()
        ''
    End Sub

    Private Function ValidateForm() As Boolean
        '
        Dim bolResult As Boolean = True

        If txtMaghsad.Text.Trim = String.Empty Then
            ErrorProvider1.SetError(txtMaghsad, "داده درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorProvider1.SetError(txtMaghsad, "")
        End If
        '
        Return bolResult
        '
    End Function

    Private Sub ClearForm()
        txtMaghsad.Text = String.Empty
        Me.Tbl_MaghsadTableAdapter.Fill(Me.DsTarabari.tbl_Maghsad)
        EditMode = False
        txtMaghsad.Focus()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Call ClearForm()
    End Sub

    Private Sub frmMaghsad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Tbl_MaghsadTableAdapter.Fill(Me.DsTarabari.tbl_Maghsad)
    End Sub

    Private Sub dgvMaghsadList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMaghsadList.CellClick
        '
        If e.ColumnIndex = 3 Then
            Dim result As MsgBoxResult = MsgBox("آیا میخواهید این اطلاعات حذف شود؟", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "حذف رکورد")
            If result = MsgBoxResult.Yes Then
                Dim mdID As Integer = dgvMaghsadList.Rows(e.RowIndex).Cells(0).Value
                maghsadBLL.Delete(mdID)
                ClearForm()
            End If
        End If
        ''
    End Sub

    Private Sub dgvMaghsadList_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMaghsadList.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        EditMode = True
        txtMaghsad.Text = dgvMaghsadList.Rows(e.RowIndex).Cells(2).Value
        txtMaghsad.Tag = dgvMaghsadList.Rows(e.RowIndex).Cells(0).Value
        txtMaghsad.Focus()
    End Sub

    Private Sub dgvMaghsadList_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvMaghsadList.CellFormatting
        If e.ColumnIndex = 1 Then e.Value = (e.RowIndex + 1).ToString()
    End Sub

    Private Sub txtMaghsad_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMaghsad.Enter
        InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(New Globalization.CultureInfo("fa-IR"))
    End Sub

    Private Sub txtMaghsad_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMaghsad.Leave
        InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(New Globalization.CultureInfo("en-US"))
    End Sub

End Class
