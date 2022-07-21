Public Class frmNavganStatus

    Dim NStatusBLL As New BLL.NavganStatus
    Dim RanandeBLL As New BLL.Ranandegan

    'dgvNavganStatus

    Private Sub frmNavganStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDate.Text = FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(Date.Now).ToString("yyyy/mm/dd")
        Call FillGridView(txtDate.Text)
    End Sub

    Private Sub FillGridView(ByVal pdate As String)
        '
        If txtDate.Text.Replace("/", "").Trim() = String.Empty Or Utilities.IsPersianDate(txtDate.Text) = False Then
            ErrorDate.SetError(txtDate, "تاریخ درخواستی را وارد کنید")
            Exit Sub
        Else
            ErrorDate.SetError(txtDate, "")
        End If

        '
        dgvNavganStatus.Rows.Clear()
        '
        ' نشاد دادن اطلاعات ذخیره شده در بانک در مورد وضعیتها
        Using dtNavganStatus As DataTable = NStatusBLL.SelectByDate(txtDate.Text)
            '
            If dtNavganStatus.Rows.Count = 0 Then   ' اگر جدول خالی باشد یعنی برای اولین بار
                ' نشاد دادن اسامی رانندگان در جدول
                Using dt As DataTable = RanandeBLL.SelectAll
                    For Each row As DataRow In dt.Rows
                        dgvNavganStatus.Rows.Add(row("RanandePersonalCode"), String.Format("{0} {1}", row("fname"), row("lname")))
                    Next
                End Using
                '
            Else
                '
                Dim intRowt As Integer = 0   ' برای مشخض ص کردن سطر جاری
                For Each Record As DataRow In dtNavganStatus.Rows
                    '
                    dgvNavganStatus.Rows.Add(Record("RanandePersonalCode"), RanandeBLL.GetFullNameByPersonalCode(Record("RanandePersonalCode")))
                    For intCol As Integer = 2 To 5
                        '
                        Dim cell As DataGridViewComboBoxCell = dgvNavganStatus.Rows(intRowt).Cells(intCol)
                        Dim intStatus = Record(intCol + 1) ' بازیابی مقدار ذخیره شده از جدول
                        ' نمایش گزینه مناسب
                        If intStatus <> 255 Then cell.Value = cell.Items(intStatus)
                        '
                    Next
                    dgvNavganStatus.Rows(dgvNavganStatus.Rows.Count - 1).Cells(6).Value = Record("Description")
                    '
                    intRowt += 1
                Next
                '
            End If
            '
        End Using
        '
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        '
        For Each row As DataGridViewRow In dgvNavganStatus.Rows
            '
            Dim arrVaziyat(3) As Integer
            Dim index As Integer
            '
            For i As Integer = 2 To 5
                Dim cell As DataGridViewComboBoxCell = row.Cells(i)
                Try
                    index = cell.Items.IndexOf(cell.Value.ToString)
                Catch ex As NullReferenceException
                    index = 255
                Finally
                    arrVaziyat(i - 2) = index
                End Try
            Next
            '
            SaveToDB(row.Cells(0).Value, txtDate.Text, arrVaziyat, _
                     IIf(row.Cells(6).Value Is System.DBNull.Value, "", row.Cells(6).Value))
            '
        Next
        MessageBox.Show("عملیات بروز رسانی وضعیت ناوگان با موفقیت انجام شد", "اعلان", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading)
        ''
    End Sub

    Private Sub SaveToDB(ByVal PersonalCode As String, ByVal pDate As String, ByVal Vaziyat() As Integer, ByVal Description As String)
        NStatusBLL.Insert(PersonalCode, pDate, _
                          Vaziyat(0), _
                          Vaziyat(1), _
                          Vaziyat(2), _
                          Vaziyat(3), _
                          Description)

    End Sub

    Private Sub btnShowData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowData.Click
        Call FillGridView(txtDate.Text)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        '
        If dgvNavganStatus.CurrentCell.ColumnIndex >= 2 And dgvNavganStatus.CurrentCell.ColumnIndex <= 5 Then

            Dim cell As DataGridViewComboBoxCell = dgvNavganStatus.CurrentRow.Cells(dgvNavganStatus.CurrentCell.ColumnIndex)
            cell.Value = Nothing

        Else

            Dim cell As DataGridViewTextBoxCell = dgvNavganStatus.CurrentRow.Cells(dgvNavganStatus.CurrentCell.ColumnIndex)
            cell.Value = String.Empty

        End If
        ''
    End Sub
End Class

'Dim cell As DataGridViewComboBoxCell = dgvNavganStatus.Rows(0).Cells(2)
'cell.Value = cell.Items(2)
'cell.Value = cell.Items(-1)
'Dim index As Integer = cell.Items.IndexOf(cell.Value.ToString)
'MsgBox(index)
'int index = cell.Items.IndexOf(cell.Value.ToString());
'Dim index= dgvNavganStatus.Rows(0).Cells(2).

