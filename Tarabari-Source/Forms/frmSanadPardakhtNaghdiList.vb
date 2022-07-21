Public Class frmSanadPardakhtNaghdiList

    Private Sub frmSanadPardakhtNaghdiList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        '
        Dim strFilter As String = String.Empty
        '
        Select Case cmbFilterType.SelectedIndex
            Case 0
                If txtFilter.Text.Trim = String.Empty Then Exit Sub
                strFilter = String.Format("FS_ID = {0}", txtFilter.Text)
            Case 1
                strFilter = String.Format("RanandePersonalCode = {0}", cmbRanande.SelectedValue)
            Case 2
                If txtFilter.Text.Trim = String.Empty Then Exit Sub
                strFilter = String.Format("MashinID = {0}", txtFilter.Text)
        End Select
        '
        VFactorSanadBindingSource.Filter = strFilter
        ''
    End Sub

    Private Sub cmbFilterType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFilterType.SelectedIndexChanged
        '
        HideFilterControl()
        '
        Select Case cmbFilterType.SelectedIndex

            Case 0, 2
                txtFilter.Visible = True
            Case 1
                cmbRanande.Visible = True

        End Select
        '
    End Sub

    Private Sub HideFilterControl()
        '
        txtFilter.Visible = False
        cmbRanande.Visible = False
        '
    End Sub

    Private Sub btnRemoveFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveFilter.Click
        VFactorSanadBindingSource.RemoveFilter()
    End Sub

    Private Sub dgvSanadList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSanadList.CellClick
        '
        If e.RowIndex < 0 Then Exit Sub
        '
        Dim FactorBLL As New BLL.FactorTamirat
        Dim SanadBLL As New BLL.Sanad

        Dim FS_Type As Boolean = CBool(dgvSanadList.CurrentRow.Cells(0).Value)
        Dim FS_ID As Integer = dgvSanadList.CurrentRow.Cells(1).Value
        Dim PeymentStatus As Boolean = CBool(dgvSanadList.CurrentRow.Cells(8).Value)

        ' گزینه تغییر وضعیت
        If e.ColumnIndex = 10 Then
            If FS_Type Then
                FactorBLL.ChangePaymentStatus(FS_ID, Not PeymentStatus)
            Else
                SanadBLL.ChangePaymentStatus(FS_ID, Not PeymentStatus)
            End If
            Me.VFactorSanadTableAdapter.Fill(Me.DsTarabari.vFactorSanad)
        End If

        ' گزینه چاپ
        If e.ColumnIndex = 11 Then
            If FS_Type Then
                Dim dt As DataTable = FactorBLL.GetDataToTankhah(FS_ID)
                Dim TotalValueHoroof As String = FarsiLibrary.Utils.ToWords.ToString(dt.Rows(0).Item("SubTotal")) + " ریال "
                Dim f As New frmReport(dt, TotalValueHoroof, frmReport.EnumReportType.PardakhtFactorPrice)
                f.Show()
            Else
                Dim dt As DataTable = SanadBLL.SelectSanadRow(FS_ID)
                Dim TotalValueHoroof As String = FarsiLibrary.Utils.ToWords.ToString(dt.Rows(0).Item("Total")) + " ریال "
                Dim f As New frmReport(dt, TotalValueHoroof, frmReport.EnumReportType.SanadNaghdi)
                f.Show()
            End If
        End If
        ''
    End Sub

    Private Sub frmSanadPardakhtNaghdiList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        '
        Me.VSelectRanandeganMashinTableAdapter.Fill(Me.DsTarabari.vSelectRanandeganMashin)
        '
        Me.VFactorSanadTableAdapter.Fill(Me.DsTarabari.vFactorSanad)
        '
        cmbFilterType.SelectedIndex = 0
        '
    End Sub

    Private Sub dgvSanadList_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvSanadList.CellFormatting
        '
        If e.ColumnIndex = 9 Then
            If CBool(dgvSanadList(8, e.RowIndex).Value) Then
                dgvSanadList.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightPink
                e.Value = "پرداخت شده است"
            Else
                dgvSanadList.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
                e.Value = "پرداخت نشده است"
            End If
        End If
        '
    End Sub

End Class