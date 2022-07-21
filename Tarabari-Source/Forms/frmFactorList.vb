Public Class frmFactorList

    Private Sub frmFactorList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmFactorList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.VFactorListTableAdapter.Fill(Me.DsTarabari.vFactorList)

        cmbFilterType.SelectedIndex = 0
    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        '
        Dim strFilter As String = String.Empty
        '
        Select Case cmbFilterType.SelectedIndex
            Case 0
                If txtFilter.Text.Trim = String.Empty Then Exit Sub
                strFilter = String.Format("FactorID = {0}", txtFilter.Text)
            Case 1
                If txtFilterDate.Text.Trim = String.Empty Then Exit Sub
                strFilter = String.Format("pdate = '{0}'", txtFilterDate.Text.Trim)
            Case 2
                If txtFilter.Text.Trim = String.Empty Then Exit Sub
                strFilter = String.Format("RanandePersonalCode = '{0}'", txtFilter.Text.Trim)
            Case 3
                If txtFilter.Text.Trim = String.Empty Then Exit Sub
                strFilter = String.Format("MashinID = {0}", txtFilter.Text.Trim)
        End Select
        '
        VFactorListBindingSource.Filter = strFilter
        '
    End Sub

    Private Sub cmbFilterType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFilterType.SelectedIndexChanged
        txtFilter.Visible = (cmbFilterType.SelectedIndex = 0) Or (cmbFilterType.SelectedIndex = 2) Or (cmbFilterType.SelectedIndex = 3)
        txtFilterDate.Visible = Not txtFilter.Visible
    End Sub

    Private Sub btnRemoveFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveFilter.Click
        VFactorListBindingSource.RemoveFilter()
    End Sub

    Private Sub dgvFactorList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFactorList.CellClick
        '
        If e.RowIndex < 0 Then Exit Sub
        '
        ' گزینه ویرایش
        If e.ColumnIndex = 6 Then
            Dim FactorID As Integer = dgvFactorList.CurrentRow.Cells(0).Value
            Dim f As New frmFactorTamirgah(FactorID)
            If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.VFactorListTableAdapter.Fill(Me.DsTarabari.vFactorList)
            End If
        End If

        ' گزینه حذف
        If e.ColumnIndex = 7 Then
            Dim FactorBLL As New BLL.FactorTamirat
            Dim msgResul As DialogResult = MessageBox.Show("آیا میخواهید این رکورد حذف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading)
            If msgResul = Windows.Forms.DialogResult.Yes Then
                Dim FactorID As Integer = dgvFactorList.CurrentRow.Cells(0).Value
                FactorBLL.Delete(FactorID)
                Me.VFactorListTableAdapter.Fill(Me.DsTarabari.vFactorList)
            End If
        End If
        ''
    End Sub

End Class