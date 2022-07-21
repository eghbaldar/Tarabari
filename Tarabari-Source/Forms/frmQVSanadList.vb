Public Class frmQVSanadList

    Private _SelectedSanad As New ArrayList

    ReadOnly Property SelectedSanad() As ArrayList
        Get
            Return _SelectedSanad
        End Get
    End Property

    Private Sub dgvSanadList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSanadList.CellClick
        If e.ColumnIndex = 0 Then
            dgvSanadList(e.ColumnIndex, e.RowIndex).Value = Not CBool(dgvSanadList(e.ColumnIndex, e.RowIndex).Value)
        End If
    End Sub

    Private Sub dgvSanadList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvSanadList.KeyDown
        If e.KeyCode = Keys.Space Then
            dgvSanadList.CurrentRow.Cells(0).Value = Not (dgvSanadList.CurrentRow.Cells(0).Value)
        End If
    End Sub

    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click
        For Each row As DataGridViewRow In dgvSanadList.Rows
            If CBool(row.Cells(0).Value) = True Then
                _SelectedSanad.Add(row.Cells(1).Value)
            End If
        Next
        Me.Close()
    End Sub

    Public Sub New(ByVal SelectItemInSanadTankhah As ArrayList, ByVal OldSelectedSanad As ArrayList)
        '
        InitializeComponent()
        '
        '====================
        Dim SanadBLL As New BLL.Sanad
        dgvSanadList.Rows.Clear()

        For Each item As Integer In OldSelectedSanad
            Dim row As DataRow = SanadBLL.SelectSanadRow(item).Rows(0)
            dgvSanadList.Rows.Add(IIf(SelectItemInSanadTankhah.Contains(CInt(row("OperationCode"))), True, False), _
                                  row("OperationCode"), _
                                  row("TarikhVoroodMojtame"), _
                                  row("RanandeFullName"), _
                                  row("MashinID"), _
                                  row("Pelak"), _
                                  row("Total"))
        Next
        '
        Dim dt As DataTable = SanadBLL.SelectSanadListToTankhah()
        For Each dRow As DataRow In dt.Rows
            dgvSanadList.Rows.Add(IIf(SelectItemInSanadTankhah.Contains(CInt(dRow("OperationCode"))), True, False), _
                                  dRow("OperationCode"), _
                                  dRow("TarikhVoroodMojtame"), _
                                  dRow("RanandeFullName"), _
                                  dRow("MashinID"), _
                                  dRow("Pelak"), _
                                  dRow("Total"))
        Next
        ''
    End Sub

End Class