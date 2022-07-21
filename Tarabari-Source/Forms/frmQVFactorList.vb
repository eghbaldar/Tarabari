Public Class frmQVFactorList

    Private _SelectedFactor As New ArrayList

    ReadOnly Property SelectedFactor() As ArrayList
        Get
            Return _SelectedFactor
        End Get
    End Property

    Private Sub dgvFactorList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFactorList.CellClick
        If e.ColumnIndex = 0 Then
            dgvFactorList(e.ColumnIndex, e.RowIndex).Value = Not CBool(dgvFactorList(e.ColumnIndex, e.RowIndex).Value)
        End If
    End Sub

    Private Sub dgvFactorList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvFactorList.KeyDown
        If e.KeyCode = Keys.Space Then
            dgvFactorList.CurrentRow.Cells(0).Value = Not (dgvFactorList.CurrentRow.Cells(0).Value)
        End If
    End Sub

    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click
        For Each row As DataGridViewRow In dgvFactorList.Rows
            If CBool(row.Cells(0).Value) = True Then
                _SelectedFactor.Add(row.Cells(1).Value)
            End If
        Next
        Me.Close()
    End Sub

    Public Sub New(ByVal SelectItemInSanadTankhah As ArrayList, ByVal OldSelectedFactor As ArrayList)
        '
        InitializeComponent()
        '
        '====================
        Dim FactorBLL As New BLL.FactorTamirat
        dgvFactorList.Rows.Clear()
        '
        For Each item As Integer In OldSelectedFactor
            Dim row As DataRow = FactorBLL.GetDataToTankhah(item).Rows(0)
            dgvFactorList.Rows.Add(IIf(SelectItemInSanadTankhah.Contains(CInt(row("FactorID"))), True, False), _
                                   row("FactorID"), _
                                   row("pDate"), _
                                   row("FullName"), _
                                   row("MashinID"), _
                                   row("Pelak"), _
                                   row("SubTotal"))
        Next
        '
        Dim dt As DataTable = FactorBLL.GetDataToTankhah
        For Each dRow As DataRow In dt.Rows
            dgvFactorList.Rows.Add(IIf(SelectItemInSanadTankhah.Contains(CInt(dRow("FactorID"))), True, False), _
                                   dRow("FactorID"), _
                                   dRow("pDate"), _
                                   dRow("FullName"), _
                                   dRow("MashinID"), _
                                   dRow("Pelak"), _
                                   dRow("SubTotal"))
        Next
        '
    End Sub

 
End Class