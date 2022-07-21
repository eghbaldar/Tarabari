Public Class frmSummaryFactors

    Dim months() As String = {"فروردین", "اردیبهشت", "خرداد", _
                              "تیر", "مرداد", "شهریور", _
                              "مهر", "آبان", "آذر", _
                              "دی", "بهمن", "اسفند"}

    Dim factorBLL As New BLL.FactorTamirat

    Private Sub frmSummaryFactors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillComboBox()
        Call InitializeListView()
    End Sub

    Private Sub FillComboBox()
        cmbYears.DataSource = factorBLL.GetYears()
    End Sub

    Private Sub InitializeListView()
        '
        lsvByMonths.Items.Clear()
        For i = 0 To 11
            Dim entryListItem As ListViewItem = lsvByMonths.Items.Add(months(i))
            entryListItem.UseItemStyleForSubItems = True
        Next

    End Sub

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPocess.Click
        '
        If txtMashinID.Text = String.Empty Then Exit Sub
        '
        Dim dt As DataTable = factorBLL.GetFactorsByMashinIdAndYear(txtMashinID.Text, cmbYears.SelectedItem.ToString)
        '
        'پر کردن دیتا گرید
        dgvFactorList.Rows.Clear()
        For Each row As DataRow In dt.Rows
            dgvFactorList.Rows.Add(row("FactorID"), row("pDate"), row("Fullname"), row("SubTotal"))
        Next
        dt.Clear()
        '
        '
        dt = factorBLL.GetTotalPriceByMonth(txtMashinID.Text, cmbYears.SelectedItem.ToString)
        Call InitializeListView()
        'پر کردن لیست ویو
        Dim Sum As Integer = 0
        For Each row As DataRow In dt.Rows
            Dim index As Integer = Int(row("Months")) - 1
            lsvByMonths.Items(index).SubItems.Add(Format(row("SubTotal"), "N0"))
            Sum += Int(row("SubTotal"))
        Next
        '
        lblTotalPrice.Text = Format(Sum, "N0")
        lblTotalBadane.Text = Format(factorBLL.GetTotalBadane(txtMashinID.Text, cmbYears.SelectedItem.ToString), "N0")
        lblTotalSales.Text = Format(factorBLL.GetTotalSales(txtMashinID.Text, cmbYears.SelectedItem.ToString), "N0")
        ''
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class