Public Class frmKarkardRoozane

    Shared counter As Integer = 0

    Private Sub frmKarkardRoozane_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call PaintGrid()
    End Sub

    Private Sub frmKarkardRoozane_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDate.Text = FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(Date.Now).ToString("yyyy/mm/dd")
        '
        Call FillGrid(txtDate.Text)
    End Sub

    Private Sub btnShowData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowData.Click
        Call FillGrid(txtDate.Text)
    End Sub

    Private Sub FillGrid(ByVal pDate As String)
        '
        If Not Utilities.IsPersianDate(txtDate.Text) Then Exit Sub
        Me.Usp_KarkardeRoozane4ShowTableAdapter.Fill(Me.DsTarabari.usp_KarkardeRoozane4Show, pDate)
        '
        Call PaintGrid()
        '
    End Sub

    Private Sub PaintGrid()
        '
        For Each row As DataGridViewRow In dgvkarkardeRoozane.Rows

            For Each col As DataGridViewCell In row.Cells
                If String.IsNullOrEmpty(col.Value.ToString) Then
                    col.Style.BackColor = Color.Pink
                End If
            Next

        Next
        '
    End Sub

    Private Sub dgvkarkardeRoozane_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvkarkardeRoozane.Sorted
        Call PaintGrid()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        '
        If Not Utilities.IsPersianDate(txtDate.Text) Then Exit Sub
        Dim NavganAction As New BLL.Navgan
        Dim dt As DataTable = NavganAction.KarkardRoozane(txtDate.Text)
        Dim f As New frmReport(dt, txtDate.Text, frmReport.EnumReportType.Karkarde_Roozane)
        f.Show()
        ''
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class