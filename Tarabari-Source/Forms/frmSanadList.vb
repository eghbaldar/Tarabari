Public Class frmSanadList

    Private Sub frmSanadList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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
                strFilter = String.Format("OperationCode = {0}", txtFilter.Text)
            Case 1
                strFilter = String.Format("RanandePersonalCode = {0}", cmbRanande.SelectedValue)
            Case 2
                strFilter = String.Format("MabdaID = {0}", cmbMabda.SelectedValue)
            Case 3
                strFilter = String.Format("MaghsadID = {0}", cmbMaghsad.SelectedValue)
            Case 4
                If Not Utilities.IsPersianDate(txtFilterDate.Text) Then Exit Sub
                strFilter = String.Format("TarikhKhoroojMojtame = '{0}'", txtFilterDate.Text)
            Case 5
                If Not Utilities.IsPersianDate(txtFilterDate.Text) Then Exit Sub
                strFilter = String.Format("TarikhVoroodMojtame = '{0}'", txtFilterDate.Text)
            Case 6
                If txtFilter.Text.Trim = String.Empty Then Exit Sub
                strFilter = String.Format("MashinID = {0}", txtFilter.Text)
        End Select
        '
        VSanadListBindingSource.Filter = strFilter
        ''
    End Sub

    Private Sub cmbFilterType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFilterType.SelectedIndexChanged
        '
        HideFilterControl()
        '
        Select Case cmbFilterType.SelectedIndex

            Case 0, 6
                txtFilter.Visible = True
            Case 1
                cmbRanande.Visible = True
            Case 2
                cmbMabda.Visible = True
            Case 3
                cmbMaghsad.Visible = True
            Case 4, 5
                txtFilterDate.Visible = True

        End Select
        '
    End Sub

    Private Sub HideFilterControl()
        '
        txtFilter.Visible = False
        cmbRanande.Visible = False
        cmbMabda.Visible = False
        cmbMaghsad.Visible = False
        txtFilterDate.Visible = False
        '
    End Sub

    Private Sub btnRemoveFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveFilter.Click
        VSanadListBindingSource.RemoveFilter()
    End Sub

    Private Sub dgvSanadList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSanadList.CellClick
        '
        If e.RowIndex < 0 Then Exit Sub
        '
        Dim OperationCode As Integer = dgvSanadList.CurrentRow.Cells(0).Value

        ' گزینه چاپ
        If e.ColumnIndex = 12 Then
            '
            Dim SanadBLL As New BLL.Sanad
            Dim dtTemp As DataTable = SanadBLL.SelectSanadDetailRows(3)
            Dim dtReport As DataTable = BuildTable4Print(dtTemp)

            Dim RanandeFullname As String = dgvSanadList.CurrentRow.Cells(1).Value
            Dim Pelak As String = dgvSanadList.CurrentRow.Cells(4).Value
            Dim MAshinID As String = dgvSanadList.CurrentRow.Cells(5).Value
            Dim pDate As String = dgvSanadList.CurrentRow.Cells(10).Value

            Dim f As New frmReport(dtReport, RanandeFullname, pDate, MAshinID, Pelak)
            f.Show()
            '
        End If


        ' گزینه ویرایش
        If e.ColumnIndex = 13 Then
            Using f As New frmAddEditSanad(OperationCode)
                If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.VSanadListTableAdapter.Fill(Me.DsTarabari.vSanadList)
                End If
            End Using
        End If

        ' گزینه حذف
        If e.ColumnIndex = 14 Then
            Dim SanadBLL As New BLL.FactorTamirat
            Dim msgResul As DialogResult = MessageBox.Show("آیا میخواهید این رکورد حذف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading)
            If msgResul = Windows.Forms.DialogResult.Yes Then
                SanadBLL.Delete(OperationCode)
                Me.VSanadListTableAdapter.Fill(Me.DsTarabari.vSanadList)
            End If
        End If
        ''
    End Sub

    Private Sub frmSanadList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        '
        Me.Tbl_MaghsadTableAdapter.Fill(Me.DsTarabari.tbl_Maghsad)
        Me.Tbl_MabdaTableAdapter.Fill(Me.DsTarabari.tbl_Mabda)
        Me.VSelectRanandeganMashinTableAdapter.Fill(Me.DsTarabari.vSelectRanandeganMashin)

        Me.VSanadListTableAdapter.Fill(Me.DsTarabari.vSanadList)
        '
        cmbFilterType.SelectedIndex = 0
        ''
    End Sub

    Public Function BuildTable4Print(ByVal dtInput As DataTable) As DataTable
        '
        Dim RowHeaderTitle() As String = {"شماره بارنامه", "تاریخ بارنامه", "مبداء", "مقصد", "نوع بار", "مبنای محاسبه کمیسیون", _
                               "کل کرایه مندرج در بارنامه", "پایه کرایه مندرج در بارنامه", "دریافت نقدی کرایه", _
 _
                               "حق پایانه", "کمیسون طبق بارنامه", "بیمه باربری", "جمع", _
 _
                               "مابه التفاوت کمیسیون", "بیمه عمر رانندگان", "بارگیری و تخلیه", "جریمه پلیس راه", _
                               "نوبت", "عوارض اتوبان", "سهم راننده", "کمک هزینه غذا (رفت)", "کمک هزینه غذا (برگشت)", "جمع", _
 _
                               "مقدار سوخت به لیتر", "مبلغ سوخت تایید شده", "جمع", _
 _
                               "جمع کل"}
        '
        Dim dtResult As New DataTable
        Dim MabdaBLL As New BLL.Mabda
        Dim MaghsadBLL As New BLL.Maghsad
        '
        For i As Integer = 0 To 5
            dtResult.Columns.Add(Convert.ToString(i))
        Next
        '
        Dim r As DataRow
        For k As Integer = 0 To RowHeaderTitle.Count - 1
            r = dtResult.NewRow()
            r(0) = RowHeaderTitle(k)
            '
            Select Case k

                Case 0, 1, 4, 5, 6, 7, 8, 9, 10, 11
                    For j As Integer = 1 To 4
                        Try
                            r(j) = dtInput(j - 1)(k + 2)
                        Catch ex As Exception
                            If k = 0 Or k = 1 Or k = 4 Then
                                r(j) = "-"
                            Else
                                r(j) = 0
                            End If
                        End Try
                    Next

                Case 2
                    For j As Integer = 1 To 4
                        Try
                            r(j) = MabdaBLL.GetNameByID(dtInput(j - 1)(k + 2))
                        Catch ex As Exception
                            r(j) = "-"
                        End Try
                    Next

                Case 3
                    For j As Integer = 1 To 4
                        Try
                            r(j) = MaghsadBLL.GetNameByID(dtInput(j - 1)(k + 2))
                        Catch ex As Exception
                            r(j) = "-"
                        End Try
                    Next


                Case 12
                    For j As Integer = 1 To 4
                        Try
                            r(j) = dtInput(j - 1)("HaghPayane") + dtInput(j - 1)("KomisionBarname") + dtInput(j - 1)("BimeBarbari")
                        Catch ex As Exception
                            r(j) = 0
                        End Try
                    Next

                Case 13, 14, 15, 16, 17, 18, 19, 20, 21
                    For j As Integer = 1 To 4
                        Try
                            r(j) = dtInput(j - 1)(k + 1)
                        Catch ex As Exception
                            r(j) = 0
                        End Try
                    Next

                Case 22
                    For j As Integer = 1 To 4
                        Try
                            r(j) = dtInput(j - 1)(14) + _
                                   dtInput(j - 1)(15) + _
                                   dtInput(j - 1)(16) + _
                                   dtInput(j - 1)(17) + _
                                   dtInput(j - 1)(18) + _
                                   dtInput(j - 1)(19) + _
                                   dtInput(j - 1)(20) + _
                                   dtInput(j - 1)(21) + _
                                   dtInput(j - 1)(22)
                        Catch ex As Exception
                            r(j) = 0
                        End Try
                    Next

                Case 23
                    For j As Integer = 1 To 4
                        Try
                            r(j) = dtInput(j - 1)("MeghdarSookht")
                        Catch ex As Exception
                            r(j) = 0
                        End Try
                    Next

                Case 24
                    For j As Integer = 1 To 4
                        Try
                            r(j) = dtInput(j - 1)("MeghdarSookht") * dtInput(j - 1)("MablaghSookht")
                        Catch ex As Exception
                            r(j) = 0
                        End Try
                    Next

                Case 25
                    For j As Integer = 1 To 4
                        Try
                            r(j) = CInt(dtResult(22)(j)) + CInt(dtResult(24)(j))
                        Catch ex As Exception
                            r(j) = 0
                        End Try
                    Next

                Case 26
                    For j As Integer = 1 To 4
                        Try
                            r(j) = dtInput(j - 1)("Total")
                        Catch ex As Exception
                            r(j) = 0
                        End Try
                    Next

            End Select
            '
            dtResult.Rows.Add(r)
        Next
        '
        For i As Integer = 5 To dtResult.Rows.Count - 1
            Dim temp As Long = 0
            For j = 1 To dtInput.Rows.Count
                temp += Integer.Parse(dtResult(i)(j))
            Next
            dtResult(i)(5) = temp
        Next
        '
        Return dtResult
        ''
    End Function

End Class