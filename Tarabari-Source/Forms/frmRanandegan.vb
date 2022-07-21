Imports System.IO

Public Class frmRanandegan

    Dim RanandeBLL As New BLL.Ranandegan
    Dim EditMode = False

    Private Sub frmRanandegan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        '
        If Not ValidateForm() Then Exit Sub

        Dim bolAction As Boolean
        If EditMode = False Then
            bolAction = RanandeBLL.Insert(txtPersonalCode.Text.Trim, txtfname.Text.Trim, txtlname.Text.Trim, txtMelliCode.Text, _
                                          txtAddress.Text.Trim, GetNumberFromCombo(), _
                                          Utilities.Pic_2_ByteArray(picPersonalPhoto.Image), _
                                          txtKartHooshmand.Text, txt_KH_StartDate.Text, txt_KH_EndDate.Text, _
                                          txtKartSalamat.Text, txt_KS_StartDate.Text, txt_KS_EndDate.Text, _
                                          txtKartGovahiname.Text, txt_KG_StartDate.Text, txt_KG_EndDate.Text, _
                                          IIf(cmbMashinID.SelectedIndex <> -1, cmbMashinID.SelectedValue, 0))
        Else
            bolAction = RanandeBLL.Update(txtPersonalCode.Text.Trim, txtfname.Text.Trim, txtlname.Text.Trim, txtMelliCode.Text, _
                                          txtAddress.Text.Trim, GetNumberFromCombo(), _
                                          Utilities.Pic_2_ByteArray(picPersonalPhoto.Image), _
                                          txtKartHooshmand.Text, txt_KH_StartDate.Text, txt_KH_EndDate.Text, _
                                          txtKartSalamat.Text, txt_KS_StartDate.Text, txt_KS_EndDate.Text, _
                                          txtKartGovahiname.Text, txt_KG_StartDate.Text, txt_KG_EndDate.Text, _
                                          IIf(cmbMashinID.SelectedIndex <> -1, cmbMashinID.SelectedValue, 0))
        End If

        If bolAction = True Then
            Call ClearForm()
        Else
            MessageBox.Show("خطا در هنگام ذخیره سازی", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading)
        End If
        ''
    End Sub

    Private Function GetNumberFromCombo() As String
        '
        Dim strResult As String = String.Empty
        For Each item As Object In cmbTelNumbers.Items
            strResult &= item.ToString & ","
        Next
        If strResult.Length > 0 Then strResult = strResult.Remove(strResult.Length - 1, 1)
        '
        Return strResult
        '
    End Function

    Private Sub FillToCombo(ByVal ParamArray items() As String)
        '
        cmbTelNumbers.Items.Clear()
        For Each item As String In items
            If item.Trim <> String.Empty Then
                cmbTelNumbers.Items.Add(item)
            End If
        Next
        If cmbTelNumbers.Items.Count > 0 Then cmbTelNumbers.SelectedIndex = 0
        '
    End Sub

    ' ورود شماره تلفن در کومبو باکس
    Private Sub cmbTelNumbers_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbTelNumbers.KeyDown
        '
        Dim item As String = cmbTelNumbers.Text
        If item = String.Empty Then Exit Sub
        '
        If e.KeyCode = Keys.Enter Then
            If Not cmbTelNumbers.Items.Contains(item) Then
                cmbTelNumbers.Items.Add(item)
            End If
            e.SuppressKeyPress = True
        End If
        ''
    End Sub

    Private Sub cmbTelNumbers_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTelNumbers.KeyPress
        '
        If Not (IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = Keys.Back) Then
            e.Handled = True
            MyBase.OnKeyPress(e)
        End If
        ''
    End Sub

    Private Sub btnRemoveNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveNumber.Click
        '
        cmbTelNumbers.Items.Remove(cmbTelNumbers.SelectedItem)
        If cmbTelNumbers.Items.Count = 0 Then
            cmbTelNumbers.Text = String.Empty
        Else
            cmbTelNumbers.SelectedIndex = 0
        End If
        '
    End Sub

    Private Function ValidateForm() As Boolean
        '
        Dim bolResult As Boolean = True

        'Validate Personal Code
        If txtPersonalCode.Text.Trim = String.Empty Then
            ErrorPersonalCode.SetError(txtPersonalCode, "کد پرسنلی را وارد کنید")
            bolResult = False
        Else
            ErrorPersonalCode.SetError(txtPersonalCode, "")
        End If

        'Validate first name
        If txtfname.Text.Trim = String.Empty Then
            ErrorFname.SetError(txtfname, "نام را وارد کنید")
            bolResult = False
        Else
            ErrorFname.SetError(txtfname, "")
        End If

        'Validate last Code
        If txtlname.Text.Trim = String.Empty Then
            ErrorLName.SetError(txtlname, "نام خانوادگی را وارد کنید")
            bolResult = False
        Else
            ErrorLName.SetError(txtlname, "")
        End If

        'Validate Address
        If txtAddress.Text.Trim = String.Empty Then
            ErrorAddress.SetError(txtAddress, "آدرس را وارد کنید")
            bolResult = False
        Else
            ErrorAddress.SetError(txtAddress, "")
        End If

        'Validate Mashin ID
        'If cmbMashinID.SelectedIndex < 0 Then
        '    ErrorMashinID.SetError(cmbMashinID, "کد ماشین را وارد کنید")
        '    bolResult = False
        'Else
        '    ErrorMashinID.SetError(cmbMashinID, "")
        'End If
        '

        If (txt_KH_StartDate.Text.Replace("/", "").Trim.Length <> 0 And Utilities.IsPersianDate(txt_KH_StartDate.Text) = False) Or _
           (txt_KH_EndDate.Text.Replace("/", "").Trim.Length <> 0 And Utilities.IsPersianDate(txt_KH_EndDate.Text) = False) Or _
           (txt_KS_StartDate.Text.Replace("/", "").Trim.Length <> 0 And Utilities.IsPersianDate(txt_KS_StartDate.Text) = False) Or _
           (txt_KS_EndDate.Text.Replace("/", "").Trim.Length <> 0 And Utilities.IsPersianDate(txt_KS_EndDate.Text) = False) Or _
           (txt_KG_StartDate.Text.Replace("/", "").Trim.Length <> 0 And Utilities.IsPersianDate(txt_KG_StartDate.Text) = False) Or _
           (txt_KG_EndDate.Text.Replace("/", "").Trim.Length <> 0 And Utilities.IsPersianDate(txt_KG_EndDate.Text) = False) Then

            bolResult = False
            MessageBox.Show("مقدار تاریخ را درست وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading)
        End If
        '
        Return bolResult
        '
    End Function

    Private Sub ClearForm()
        '
        txtPersonalCode.Text = String.Empty
        txtPersonalCode.BackColor = Color.White
        txtfname.Text = String.Empty
        txtlname.Text = String.Empty
        txtMelliCode.Text = String.Empty
        txtAddress.Text = String.Empty
        cmbMashinID.SelectedIndex = -1
        cmbTelNumbers.Items.Clear()
        cmbTelNumbers.Text = String.Empty
        picPersonalPhoto.Image = My.Resources.UnknowUser
        '=======
        txtKartHooshmand.Text = String.Empty
        txtKartHooshmand.BackColor = Color.White
        txt_KH_StartDate.Text = String.Empty
        txt_KH_EndDate.Text = String.Empty

        txtKartSalamat.Text = String.Empty
        txt_KS_StartDate.Text = String.Empty
        txt_KS_EndDate.Text = String.Empty

        txtKartGovahiname.Text = String.Empty
        txt_KG_StartDate.Text = String.Empty
        txt_KG_EndDate.Text = String.Empty
        '==============================
        Me.VSelectRanandeganMashinTableAdapter.Fill(Me.DsTarabari.vSelectRanandeganMashin)

        EditMode = False
        TabControl1.SelectTab(0)
        txtPersonalCode.Focus()
        ''
    End Sub

    Private Sub frmRanandegan_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
        InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(New Globalization.CultureInfo("fa-IR"))
    End Sub

    Private Sub frmRanandegan_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(New Globalization.CultureInfo("en-US"))
    End Sub

    Private Sub frmRanandegan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.VSelectRanandeganMashinTableAdapter.Fill(Me.DsTarabari.vSelectRanandeganMashin)
        Me.Tbl_MashinTableAdapter.Fill(Me.DsTarabari.tbl_Mashin)
        Call ClearForm()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Call ClearForm()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        '
        If txtFilter.Text.Trim = String.Empty Then Exit Sub
        '
        Dim strFilter As String = String.Empty

        Select Case cmbFilterType.SelectedIndex
            Case 0
                strFilter = String.Format("RanandePersonalCode = '{0}'", txtFilter.Text.Trim)
            Case 1
                strFilter = String.Format("fname = '{0}'", txtFilter.Text.Trim)
            Case 2
                strFilter = String.Format("lname = '{0}'", txtFilter.Text.Trim)
            Case 3
                strFilter = String.Format("MashinID = {0}", txtFilter.Text.Trim)
        End Select

        VSelectRanandeganMashinBindingSource.Filter = strFilter
        ''
    End Sub

    Private Sub btnRemoveFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveFilter.Click
        VSelectRanandeganMashinBindingSource.RemoveFilter()
    End Sub

    Private Sub dgvRM_List_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRM_List.CellClick
        '
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex = 6 Then
            Dim result As MsgBoxResult = MsgBox("آیا میخواهید این اطلاعات حذف شود؟", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "حذف رکورد")
            If result = MsgBoxResult.Yes Then
                Dim PersonalCode As Integer = dgvRM_List.Rows(e.RowIndex).Cells(1).Value
                RanandeBLL.Delete(PersonalCode)
                ClearForm()
            End If
        End If
        ''
    End Sub

    Private Sub dgvRM_List_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRM_List.CellDoubleClick
        '
        If e.RowIndex < 0 Then Exit Sub
        EditMode = True
        '
        Dim RanandePersonalCode As String = dgvRM_List.Rows(e.RowIndex).Cells(1).Value
        Dim row As DataRow = RanandeBLL.SelectRow(RanandePersonalCode)

        txtPersonalCode.Text = row("RanandePersonalCode").ToString
        txtfname.Text = row("Fname").ToString
        txtlname.Text = row("Lname").ToString
        txtMelliCode.Text = row("CodeMelli").ToString
        txtAddress.Text = row("Address").ToString
        FillToCombo(row("TelNumbers").ToString.Split(","))
        cmbMashinID.SelectedValue = dgvRM_List.CurrentRow.Cells(5).Value

        If IsDBNull(row("Picture")) = False Then
            Dim ByteArray() As Byte = DirectCast(row("Picture"), Byte())
            If ByteArray.Length <> 0 Then
                picPersonalPhoto.Image = Utilities.ByteArray_2_Pic(ByteArray)
            End If
        Else
            picPersonalPhoto.Image = My.Resources.UnknowUser
        End If

        '
        txtKartHooshmand.Text = row("KartHooshmandNo").ToString
        txt_KH_StartDate.Text = row("KH_StartDate").ToString
        txt_KH_EndDate.Text = row("KH_EndDate").ToString

        txtKartSalamat.Text = row("KartSalamatNo").ToString
        txt_KS_StartDate.Text = row("KS_StartDate").ToString
        txt_KS_EndDate.Text = row("KS_EndDate").ToString

        txtKartGovahiname.Text = row("KartGovahinameNo").ToString
        txt_KG_StartDate.Text = row("KG_StartDate").ToString
        txt_KG_EndDate.Text = row("KG_EndDate").ToString
        '
        txtPersonalCode.Focus()
        ''
    End Sub

    Private Sub dgvRM_List_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvRM_List.CellFormatting
        If e.ColumnIndex = 0 Then e.Value = (e.RowIndex + 1).ToString()
    End Sub

    Private Sub picPersonalPhoto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPersonalPhoto.DoubleClick
        '
        OpenFileDialog1.InitialDirectory = Environment.SpecialFolder.MyPictures
        OpenFileDialog1.Filter = "All Picture files|*.bmp;*.jpg;*.gif;*.png"
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.CheckFileExists = True
        '
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            picPersonalPhoto.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
        ''
    End Sub

    Private Sub DeletePictureMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeletePictureMenu.Click
        picPersonalPhoto.Image = My.Resources.UnknowUser
    End Sub

End Class