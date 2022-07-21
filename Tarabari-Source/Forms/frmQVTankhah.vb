Public Class frmQVTankhah

    Public Sub New(ByVal TankhahID As Integer)
        '
        InitializeComponent()
        '
        Dim TankhahBLL As New BLL.Tankhah
        Dim dtTankhah As DataTable = TankhahBLL.SelectTankhahDetail4Print(TankhahID)
        Dim TotalValue As Long = 0
        '
        lblTankhahID.Text = dtTankhah.Rows(0).Item("TankhahID")
        lblpDate.Text = dtTankhah.Rows(0).Item("pDate")
        lblVajhe.Text = dtTankhah.Rows(0).Item("Vajhe")
        '
        For Each row As DataRow In dtTankhah.Rows
            '
            dgvTankhahItems.Rows.Add(row("FS_ID"), _
                                     dgvTankhahItems.Rows.Count + 1, _
                                     row("Fullname"), _
                                     row("Pelak"), _
                                     row("TedadBargZamime"), _
                                     row("ShomareSanadPardakht"), _
                                     row("ShomareResidAnbar"), _
                                     row("SubTotal"), _
                                     row("Molahezat"))
            '
        Next
        '
        lblTotalValue.Text = FarsiLibrary.Utils.ToWords.ToString(dtTankhah.Rows(0).Item("TotalValue")) + " ریال "
        '     
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class