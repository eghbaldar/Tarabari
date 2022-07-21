Public Class frmFactorTamirgah

    Dim factorBLL As New BLL.FactorTamirat
    Dim editMode As Boolean = False

    Private Sub frmFactorTamirgah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.VSelectRanandeganMashinTableAdapter.Fill(Me.DsTarabari.vSelectRanandeganMashin)
        '
        If Not editMode Then Call ClearForm()
    End Sub

    Private Sub ClearForm()
        '
        lblFactorID.Text = factorBLL.GetCurrentFactorID()
        cmbRanande.SelectedIndex = -1
        txtMashinID.Text = String.Empty
        txtDate.Text = FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(Date.Now).ToString("yyyy/mm/dd")
        txtTamirgah.Text = String.Empty
        txtBimehSales.Text = String.Empty
        txtBimehBadane.Text = String.Empty
        dgvDetail.Rows.Clear()
        lblTotal.Text = String.Empty
        '
    End Sub

    Private Sub cmbRanande_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRanande.SelectedIndexChanged
        '
        Dim mrBLL As New BLL.Ranandegan
        Dim intResul As Integer = mrBLL.GetMashinIDByPersonalCode(cmbRanande.SelectedValue)
        If intResul <> 0 Then txtMashinID.Text = intResul
        ''
    End Sub

    Private Sub txtMashinID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMashinID.TextChanged
        '
        Dim MashinBLL As New BLL.Mashin
        Try
            lblPelak.Text = MashinBLL.GetPelakByMashinID(txtMashinID.Text)
        Catch ex As Exception
            lblPelak.Text = String.Empty
        End Try
        ''
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        '
        If Not ValiateForm() Then Exit Sub
        '
        Dim Detail As New List(Of BLL.FactorDetailStructor)
        Dim item As BLL.FactorDetailStructor

        For Each row As DataGridViewRow In dgvDetail.Rows
            If Not row.IsNewRow Then
                '
                item.Sharh = row.Cells(1).Value
                item.Mablagh = row.Cells(2).Value
                Detail.Add(item)
                '
            End If
        Next
        '
        Try
            '
            Dim tempSales As Long
            Dim tempBadane As Long
            Long.TryParse(txtBimehSales.Text, tempSales)
            Long.TryParse(txtBimehBadane.Text, tempBadane)
            '
            If editMode = True Then
                factorBLL.Update(lblFactorID.Text, _
                                 cmbRanande.SelectedValue, _
                                 txtMashinID.Text, _
                                 txtDate.Text, _
                                 txtTamirgah.Text, _
                                 tempSales, _
                                 tempBadane, _
                                 Detail)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else

                factorBLL.Insert(lblFactorID.Text, _
                                 cmbRanande.SelectedValue, _
                                 txtMashinID.Text, _
                                 txtDate.Text, _
                                 txtTamirgah.Text, _
                                 tempSales, _
                                 tempBadane, _
                                 Detail)
            End If
            '
        Catch ex As Exception
            MsgBox("خطا در افزودن مقدار جدید")
            CaspianTools.Logger.WriteError(ex)
        End Try

        Call ClearForm()
        ''
    End Sub

    Private Function ValiateForm() As Boolean
        '
        Dim bolResult As Boolean = True
        '
        'نام راننده
        If cmbRanande.SelectedIndex < 0 Then
            ErrorRanande.SetError(cmbRanande, "نام راننده را انتخاب کنید")
            bolResult = False
        Else
            ErrorRanande.SetError(cmbRanande, "")
        End If
        '
        'کد ماشین
        If txtMashinID.Text.Trim = String.Empty Then
            ErrorMashinID.SetError(txtMashinID, "شماره ماشین را وارد کنید")
            bolResult = False
        Else
            ErrorMashinID.SetError(txtMashinID, "")
        End If
        '
        ' نام تعمیرگاه
        If txtTamirgah.Text.Trim = String.Empty Then
            ErrorTamirgah.SetError(txtTamirgah, "مقدار درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorTamirgah.SetError(txtTamirgah, "")
        End If
        '
        ' تاریخ فاکتور 
        If txtDate.Text.Replace("/", "").Trim() = String.Empty Or Utilities.IsPersianDate(txtDate.Text) = False Then
            ErrorDate.SetError(txtDate, "تاریخ درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorDate.SetError(txtDate, "")
        End If
        '
        Return bolResult
        '
    End Function

#Region "DataGridView Events"

    Private Sub dgvDetail_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetail.CellEndEdit
        '
        If e.ColumnIndex = 2 Then
            Call CalculateTotal()
        End If
        ''
    End Sub

    Private Sub dgvDetail_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgvDetail.CellValidating

        If e.ColumnIndex = 1 Then
            Me.dgvDetail.Rows(e.RowIndex).ErrorText = ""

            If dgvDetail.Rows(e.RowIndex).IsNewRow Then Return
            If e.FormattedValue.ToString().Trim() = String.Empty Then
                e.Cancel = True
                Me.dgvDetail.Rows(e.RowIndex).ErrorText = "مقدار مورد نظر را وارد کنید"
            End If

        End If

    End Sub

    Private Sub dgvDetail_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvDetail.RowsAdded
        dgvDetail.Rows(e.RowIndex).Cells(0).Value = e.RowIndex + 1
    End Sub

    Private Sub dgvDetail_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgvDetail.RowsRemoved
        For i As Integer = 0 To dgvDetail.Rows.Count - 1
            dgvDetail.Rows(i).Cells(0).Value = i + 1
        Next
    End Sub

    Private Sub dgvDetail_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvDetail.EditingControlShowing
        If dgvDetail.CurrentCell.ColumnIndex = 2 Then 'And Not e.Control Is Nothing Then
            '
            Dim tb As TextBox = CType(e.Control, TextBox)
            AddHandler tb.KeyPress, AddressOf TextBox_KeyPress
            '
        Else
            '
            Dim tb As TextBox = CType(e.Control, TextBox)
            AddHandler tb.KeyPress, AddressOf AlphabeticTextBox_KeyPress
            '
        End If
    End Sub

    Private Sub TextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            If Asc(e.KeyChar) = 46 Then
                If CType(sender, TextBox).Text.Contains(Chr(46)) Then
                    e.Handled = True
                Else
                    e.Handled = False
                End If
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub AlphabeticTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = False
    End Sub

#End Region

    Private Sub txtBimehBadane_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBimehBadane.TextChanged, txtBimehSales.TextChanged
        Call CalculateTotal()
    End Sub

    Private Sub CalculateTotal()
        '
        'بیمه بدنه
        Dim badane As Long
        Long.TryParse(txtBimehBadane.Text, badane)

        'بیمه ثالث
        Dim sales As Long
        Long.TryParse(txtBimehSales.Text, sales)


        'محاسبه مقادیر گرید
        Dim totalCols As Long = 0
        Dim temp As Long = 0
        For Each row As DataGridViewRow In dgvDetail.Rows
            If Not row.IsNewRow Then
                Long.TryParse(row.Cells(2).Value, temp)
                totalCols += temp
            End If
        Next
        '
        lblTotal.Text = Format(badane + sales + totalCols, "N0")
        '
    End Sub

    Private Sub dgvDetail_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTamirgah.Leave
        InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(New Globalization.CultureInfo("en-US"))
    End Sub

    Private Sub dgvDetail_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTamirgah.Enter
        InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(New Globalization.CultureInfo("fa-IR"))
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal FactorID As Integer)
        '
        InitializeComponent()
        '
        editMode = True

        Dim dr As DataRow = factorBLL.SelectOneFactor(FactorID)
        Dim factorDetail As List(Of BLL.FactorDetailStructor) = factorBLL.SelectFactorDetail(FactorID)

        lblFactorID.Text = dr("FactorID")
        cmbRanande.SelectedValue = dr("RanandePersonalCode")
        txtMashinID.Text = dr("MashinID")
        txtDate.Text = dr("pdate")
        txtTamirgah.Text = dr("NameTamirgah")
        txtBimehSales.Text = dr("KhesaratSales")
        txtBimehBadane.Text = dr("KhesaratBadane")

        dgvDetail.AllowUserToAddRows = False
        For Each item As BLL.FactorDetailStructor In factorDetail
            dgvDetail.Rows.Add("", item.Sharh, item.Mablagh)
        Next
        dgvDetail.AllowUserToAddRows = True
        Call CalculateTotal()
        '
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class