Public Class frmNavganList

    Private _OperationCode As String

    Private Sub frmSelectNavgan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmSelectNavgan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.VSelectNavganTableAdapter.Fill(Me.DsTarabari.vSelectNavgan)
    End Sub

    Private Sub bntFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        '
        'If txtFilter.Text.Trim = String.Empty Then Exit Sub
        '
        Dim strFilter As String = String.Empty

        Select Case cmbFilterType.SelectedIndex
            Case 0
                strFilter = "DarMamooriyat = 1"
            Case 1
                Dim pd As String = FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(Date.Now).ToString("yyyy/mm/dd")
                strFilter = String.Format("TarikhKhoroojMojtame = '{0}'", pd)
            Case 2
                strFilter = String.Format("TarikhKhoroojMojtame = '{0}'", txtDate.Text.Trim)
        End Select
        '
        VSelectNavganBindingSource.Filter = strFilter
        ''
    End Sub

    Private Sub cmbFilterType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFilterType.SelectedIndexChanged
        txtDate.Enabled = (cmbFilterType.SelectedIndex = 2)
    End Sub

    Private Sub btnRemoveFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveFilter.Click
        'VSelectNavganBindingSource.Filter = "DarMamooriyat = 1"
        VSelectNavganBindingSource.RemoveFilter()
    End Sub

    Private Sub dgvNavganList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvNavganList.CellClick
        '
        If e.RowIndex < 0 Then Exit Sub
        '
        If e.ColumnIndex = 11 Then
            '
            Dim NavganBLL As New BLL.vSelectNavgan
            Dim OperationCode As String = dgvNavganList.Rows(e.RowIndex).Cells(0).Value
            Dim dt As DataTable = NavganBLL.SelectDtByOperationCode(OperationCode)
            '
            Dim f As New frmReport(dt, "", frmReport.EnumReportType.Barge_Ezam)
            f.Show()
            '
        End If
        ''
    End Sub

    Private Sub dgvNavganList_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvNavganList.CellDoubleClick
        _OperationCode = dgvNavganList.Rows(e.RowIndex).Cells(0).Value
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

End Class