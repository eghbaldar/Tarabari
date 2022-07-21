Public Class frmTankhah


    Dim TankhahBLL As New BLL.Tankhah
    Dim FactorBLL As New BLL.FactorTamirat
    Dim SanadBLL As New BLL.Sanad

    Dim _OldSelectedFactor As New ArrayList
    Dim _OldSelectedSanad As New ArrayList
    Dim editMode As Boolean = False

    Private Sub btnAddFactor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFactor.Click
        '
        Using frm As New frmQVFactorList(CurrentFactors, OldSelectedFactor)
            '
            frm.ShowDialog()
            '
            For Each item As Integer In frm.SelectedFactor
                ' این ایتم در گرید وجود ندارد
                If Not Me.CurrentFactors.Contains(item) Then
                    Dim dRow As DataRow = FactorBLL.SelectOnFactorDetail(CInt(item))
                    Dim rowNumber As Integer = dgvTankhahItems.Rows.Add(CInt(item), True, dgvTankhahItems.Rows.Count + 1, dRow("FullName"), dRow("Pelak"), "", "", "", dRow("SubTotal"), "")
                    dgvTankhahItems.Rows(rowNumber).DefaultCellStyle.BackColor = Color.FromArgb(&HCC, &HFF, &HCC)
                End If
            Next

            ' پاک کردن ایتمهایی که در لیست انتخابی وجود ندارد اما در گرید وجود دارد
            For i As Integer = 0 To dgvTankhahItems.Rows.Count - 1
                Try
                    If Not frm.SelectedFactor.Contains(dgvTankhahItems.Rows(i).Cells(0).Value) And CBool(dgvTankhahItems.Rows(i).Cells(1).Value) = True Then
                        dgvTankhahItems.Rows.RemoveAt(i)
                        i = i - 1
                    End If
                Catch ex As Exception

                End Try
            Next

            ' حذف تمام سطرهای مربوط به فاکتور ها از جدول
            If frm.SelectedFactor.Count = 0 Then
                For Each row As DataGridViewRow In dgvTankhahItems.Rows
                    If CBool(row.Cells(1).Value) Then
                        dgvTankhahItems.Rows.Remove(row)
                    End If
                Next
            End If
            '
        End Using
        '
        lblTotalValue.Text = FarsiLibrary.Utils.ToWords.ToString(GetTotalFromGridView()) + " ریال "
        ''
    End Sub

    Private Sub btnAddSanad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSanad.Click
        '
        Using frm As New frmQVSanadList(CurrentSanads, OldSelectedSanad)
            '
            frm.ShowDialog()
            '
            For Each item As Integer In frm.SelectedSanad
                ' این ایتم در گرید وجود ندارد
                If Not Me.CurrentSanads.Contains(item) Then
                    Dim dRow As DataRow = SanadBLL.SelectSanadRow(CInt(item)).Rows(0)
                    Dim rowNumber As Integer = dgvTankhahItems.Rows.Add(CInt(item), False, dgvTankhahItems.Rows.Count + 1, dRow("RanandeFullName"), dRow("Pelak"), "", "", "", dRow("Total"), "")
                    dgvTankhahItems.Rows(rowNumber).DefaultCellStyle.BackColor = Color.MistyRose
                End If
            Next

            ' پاک کردن ایتمهایی که در لیست انتخابی وجود ندارد اما در گرید وجود دارد
            For i As Integer = 0 To dgvTankhahItems.Rows.Count - 1
                Try
                    If Not frm.SelectedSanad.Contains(dgvTankhahItems.Rows(i).Cells(0).Value) And CBool(dgvTankhahItems.Rows(i).Cells(1).Value) = False Then
                        dgvTankhahItems.Rows.RemoveAt(i)
                        i = i - 1
                    End If
                Catch ex As Exception

                End Try
            Next

            ' حذف تمام سطرهای مربوط به سند ها از جدول
            If frm.SelectedSanad.Count = 0 Then
                For Each row As DataGridViewRow In dgvTankhahItems.Rows
                    If Not CBool(row.Cells(1).Value) Then
                        dgvTankhahItems.Rows.Remove(row)
                    End If
                Next
            End If
            '
        End Using
        '
        lblTotalValue.Text = FarsiLibrary.Utils.ToWords.ToString(GetTotalFromGridView()) + " ریال "
        ''
    End Sub

    Private Function GetTotalFromGridView() As Long
        '
        Dim lngResult As Long = 0
        '
        For i As Integer = 0 To dgvTankhahItems.Rows.Count - 1
            lngResult += CLng(dgvTankhahItems.Rows(i).Cells(8).Value.ToString)
        Next
        '
        Return lngResult
        '
    End Function

    Private Function OldSelectedFactor() As ArrayList
        '
        Return _OldSelectedFactor
        ''
    End Function

    Private Function OldSelectedSanad() As ArrayList
        '
        Return _OldSelectedSanad
        '
    End Function

    Private Function CurrentFactors() As ArrayList
        '
        Dim tempArray As New ArrayList
        '
        For Each row As DataGridViewRow In dgvTankhahItems.Rows
            If CBool(row.Cells(1).Value) Then
                tempArray.Add(row.Cells(0).Value)
            End If
        Next
        '
        Return tempArray
        ''
    End Function

    Private Function CurrentSanads() As ArrayList
        '
        Dim tempArray As New ArrayList
        '
        For Each row As DataGridViewRow In dgvTankhahItems.Rows
            If Not CBool(row.Cells(1).Value) Then
                tempArray.Add(row.Cells(0).Value)
            End If

        Next
        '
        Return tempArray
        ''
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        '
        If Not ValiateForm() Then Exit Sub
        '
        Dim Detail As New List(Of BLL.TankhahDetailStructor)
        Dim item As BLL.TankhahDetailStructor

        ' برگرداندن حالت فاکتورها و سندها به حالت پردازش نشده
        If editMode Then
            '
            For Each i As Integer In OldSelectedFactor()
                FactorBLL.UpdateProcess(i, False)
            Next
            '
            For Each j As Integer In OldSelectedSanad()
                SanadBLL.UpdateProcess(j, False)
            Next
            '
        End If
        '
        For Each row As DataGridViewRow In dgvTankhahItems.Rows
            '
            item.FS_ID = row.Cells(0).Value
            item.TedadBargZamime = row.Cells(5).Value
            item.ShomareSanadPardakht = row.Cells(6).Value
            item.ShomareResidAnbar = row.Cells(7).Value
            item.Molahezat = row.Cells(9).Value
            item.IsFactor = CBool(row.Cells(1).Value)
            '
            Detail.Add(item)
            '
            If item.IsFactor Then
                FactorBLL.UpdateProcess(item.FS_ID, True)
            Else
                SanadBLL.UpdateProcess(item.FS_ID, True)
            End If
            '
        Next
        '
        Try
            '
            If editMode = True Then
                TankhahBLL.Update(txtTankhahNumber.Text, txtSanadSeryalNo.Text, txtDate.Text, txtVajhe.Text, GetTotalFromGridView(), Detail)
            Else
                TankhahBLL.Insert(txtTankhahNumber.Text, txtSanadSeryalNo.Text, txtDate.Text, txtVajhe.Text, GetTotalFromGridView(), Detail)
            End If

            If editMode Then
                Me.Close()
            Else
                MessageBox.Show("سند جدید با موفقیت ثبت گردید", "سند تنخواه", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading)
            End If
            '
        Catch ex As Exception
            MsgBox("خطا در افزودن مقدار جدید")
        End Try
        '
        Call ClearForm()
        ''
    End Sub

    Private Sub ClearForm()
        '
        txtTankhahNumber.Text = TankhahBLL.GetCurrentTankhahID()
        txtDate.Text = FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(Date.Now).ToString("yyyy/mm/dd")
        txtVajhe.Text = String.Empty
        lblTotalValue.Text = String.Empty
        dgvTankhahItems.Rows.Clear()
        ''
    End Sub

    'Private Sub dgvTankhahItems_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTankhahItems.CellClick
    '    '
    '    If e.RowIndex < 0 Then Exit Sub
    '    '
    '    ' گزینه حذف
    '    If e.ColumnIndex = 10 Then
    '        '
    '        Dim FS_ID As Integer = dgvTankhahItems.Rows(e.RowIndex).Cells(0).Value
    '        Dim IsFactor As Boolean = CBool(dgvTankhahItems.Rows(e.RowIndex).Cells(1).Value)
    '        dgvTankhahItems.Rows.RemoveAt(e.RowIndex)

    '        If IsFactor Then
    '            FactorBLL.UpdateProcess(FS_ID, False)
    '        Else
    '            SanadBLL.UpdateProcess(FS_ID, False)
    '        End If
    '        '
    '        lblTotalValue.Text = FarsiLibrary.Utils.ToWords.ToString(GetTotalFromGridView()) + " ریال "
    '        '
    '    End If
    '    ''
    'End Sub

    Private Function ValiateForm() As Boolean
        '
        Dim bolResult As Boolean = True
        '
        ' تاریخ سند 
        If txtDate.Text.Replace("/", "").Trim() = String.Empty Or Utilities.IsPersianDate(txtDate.Text) = False Then
            ErrorDate.SetError(txtDate, "تاریخ درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorDate.SetError(txtDate, "")
        End If
        '
        If txtVajhe.Text.Trim = String.Empty Then
            ErrorVajhe.SetError(txtVajhe, "مقدار درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorVajhe.SetError(txtVajhe, "")

        End If
        '
        If txtSanadSeryalNo.Text.Trim = String.Empty Then
            ErrorSeryalSanadNo.SetError(txtSanadSeryalNo, "مقدار درخواستی را وارد کنید")
            bolResult = False
        Else
            ErrorSeryalSanadNo.SetError(txtSanadSeryalNo, "")

        End If
        '
        If dgvTankhahItems.Rows.Count = 0 Then bolResult = False
        '
        For Each row As DataGridViewRow In dgvTankhahItems.Rows
            If row.Cells(4).Value.ToString = String.Empty Or _
               row.Cells(5).Value.ToString = String.Empty Then
                '
                bolResult = False
                '
            End If
        Next
        '
        Return bolResult
        '
    End Function

#Region "Validating DatagridView cells"

    Private Sub dgvTankhahItems_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgvTankhahItems.CellValidating

        If e.ColumnIndex = 5 Or _
           e.ColumnIndex = 6 Then

            dgvTankhahItems.Rows(e.RowIndex).ErrorText = ""

            If e.FormattedValue.ToString().Trim() = String.Empty Then
                e.Cancel = True
                dgvTankhahItems.Rows(e.RowIndex).ErrorText = "مقدار مورد نظر را وارد کنید"
            End If

        End If

    End Sub

    Private Sub dgvTankhahItems_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvTankhahItems.EditingControlShowing
        '
        If dgvTankhahItems.CurrentCell.ColumnIndex = 5 Or _
           dgvTankhahItems.CurrentCell.ColumnIndex = 6 Then
            'dgvTankhahItems.CurrentCell.ColumnIndex = 7 Then

            Dim tb As TextBox = CType(e.Control, TextBox)
            AddHandler tb.KeyPress, AddressOf NumericTextBox_KeyPress
        Else
            Dim tb As TextBox = CType(e.Control, TextBox)
            AddHandler tb.KeyPress, AddressOf AlphabeticTextBox_KeyPress
        End If
        ''
    End Sub

    Private Sub NumericTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Public Sub New()
        InitializeComponent()
        Call ClearForm()
    End Sub

    Public Sub New(ByVal TankhahID As Integer)
        InitializeComponent()
        '
        editMode = True
        '
        Dim TankhahBLL As New BLL.Tankhah
        Dim dtTankhah As DataTable = TankhahBLL.SelectTankhahDetail4Print(TankhahID)
        Dim TotalValue As Long = 0
        '
        txtTankhahNumber.Text = dtTankhah.Rows(0).Item("TankhahID")
        txtDate.Text = dtTankhah.Rows(0).Item("pDate")
        txtVajhe.Text = dtTankhah.Rows(0).Item("Vajhe")
        txtSanadSeryalNo.Text = dtTankhah.Rows(0).Item("TankhahSanadID")
        ''
        For Each row As DataRow In dtTankhah.Rows
            '
            Dim rowNumber As Integer = dgvTankhahItems.Rows.Add(row("FS_ID"), _
                                                CBool(row("Type")), _
                                                dgvTankhahItems.Rows.Count + 1, _
                                                row("Fullname"), _
                                                row("Pelak"), _
                                                row("TedadBargZamime").ToString, _
                                                row("ShomareSanadPardakht").ToString, _
                                                row("ShomareResidAnbar").ToString, _
                                                row("SubTotal"), _
                                                row("Molahezat"))

            If CBool(row("Type")) Then
                dgvTankhahItems.Rows(rowNumber).DefaultCellStyle.BackColor = Color.FromArgb(&HCC, &HFF, &HCC)
                _OldSelectedFactor.Add(row("FS_ID"))
            Else
                dgvTankhahItems.Rows(rowNumber).DefaultCellStyle.BackColor = Color.MistyRose
                _OldSelectedSanad.Add(row("FS_ID"))
            End If
            '
        Next
        '
        lblTotalValue.Text = FarsiLibrary.Utils.ToWords.ToString(dtTankhah.Rows(0).Item("TotalValue")) + " ریال "
        '     
    End Sub

End Class