Public Class frmTankhahList

    Private Sub frmTankhahList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_TankhahTableAdapter.Fill(Me.DsTarabari.tbl_Tankhah)
        cmbFilterType.SelectedIndex = 0
    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        '
        Dim strFilter As String = String.Empty
        '
        Select Case cmbFilterType.SelectedIndex
            Case 0
                If txtFilter.Text.Trim = String.Empty Then Exit Sub
                strFilter = String.Format("TankhahID = {0}", txtFilter.Text)
            Case 1
                If txtFilterDate.Text.Trim = String.Empty Then Exit Sub
                strFilter = String.Format("pdate = '{0}'", txtFilterDate.Text.Trim)
        End Select
        '
        TblTankhahBindingSource.Filter = strFilter
        ''
    End Sub

    Private Sub cmbFilterType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFilterType.SelectedIndexChanged
        txtFilter.Visible = (cmbFilterType.SelectedIndex = 0)
        txtFilterDate.Visible = Not txtFilter.Visible
    End Sub

    Private Sub btnRemoveFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveFilter.Click
        TblTankhahBindingSource.RemoveFilter()
    End Sub

    Private Sub dgvTankhahList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTankhahList.CellClick
        '
        If e.RowIndex < 0 Then Exit Sub
        '
        Dim TankhahID As Integer = dgvTankhahList.CurrentRow.Cells(0).Value
        '
        ' گزینه ویرایش
        If e.ColumnIndex = 5 Then
            Using f As New frmTankhah(TankhahID)
                f.ShowDialog()
            End Using
            Me.Tbl_TankhahTableAdapter.Fill(Me.DsTarabari.tbl_Tankhah)
        End If

        ' گزینه نمایش
        If e.ColumnIndex = 6 Then
            Using f As New frmQVTankhah(TankhahID)
                f.ShowDialog()
            End Using
        End If

        ' گزینه چاپ
        If e.ColumnIndex = 7 Then
            '
            Dim TankhahBLL As New BLL.Tankhah
            Dim dt As DataTable = TankhahBLL.SelectTankhahDetail4Print(TankhahID)
            Dim TotalValueHoroof As String = FarsiLibrary.Utils.ToWords.ToString(dt.Rows(0).Item("TotalValue")) + " ریال "
            Dim f As New frmReport(dt, TotalValueHoroof, frmReport.EnumReportType.Tankhah)
            f.Show()
            '
        End If
        ''
    End Sub

End Class