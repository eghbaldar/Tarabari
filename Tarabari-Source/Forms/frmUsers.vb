Imports System.IO

Public Class frmUsers

    Dim MembershipBLL As New BLL.Membership
    Dim EditMode = False

    Private Sub frmUsers_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        '
        If Not ValidateForm() Then Exit Sub

        Dim bolAction As Boolean
        If EditMode = False Then
            bolAction = MembershipBLL.AddUser(txtUsername.Text.Trim, txtPassword.Text.Trim, _
                                            txtPersonalCode.Text.Trim, txtfname.Text.Trim, _
                                            txtlname.Text.Trim, txtMelliCode.Text, _
                                            txtAddress.Text.Trim, GetNumberFromCombo(), _
                                            Utilities.Pic_2_ByteArray(picPersonalPhoto.Image))

        Else

            bolAction = MembershipBLL.UpdateUser(txtUsername.Text.Trim, txtPassword.Text.Trim, _
                                                 txtPersonalCode.Text.Trim, txtfname.Text.Trim, _
                                                 txtlname.Text.Trim, txtMelliCode.Text, _
                                                 txtAddress.Text.Trim, GetNumberFromCombo(), _
                                                 Utilities.Pic_2_ByteArray(picPersonalPhoto.Image))

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
        '
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

        'Validate User name
        If txtUsername.Text.Trim = String.Empty Then
            ErrorUsername.SetError(txtUsername, "نام کاربری را وارد کنید")
            bolResult = False
        Else
            ErrorUsername.SetError(txtUsername, "")
        End If

        'Validate Password
        If txtPassword.Text.Trim = String.Empty Then
            ErrorPassword.SetError(txtPassword, "نام کاربری را وارد کنید")
            bolResult = False
        Else
            ErrorPassword.SetError(txtPassword, "")
        End If

        '
        Return bolResult
        ''
    End Function

    Private Sub ClearForm()
        '
        txtUsername.Text = String.Empty
        txtPassword.Text = String.Empty

        txtPersonalCode.Text = String.Empty
        txtfname.Text = String.Empty
        txtlname.Text = String.Empty
        txtMelliCode.Text = String.Empty
        txtAddress.Text = String.Empty
        cmbTelNumbers.Items.Clear()
        cmbTelNumbers.Text = String.Empty
        picPersonalPhoto.Image = My.Resources.UnknowUser
        '==============================
        Me.Tbl_UsersTableAdapter.Fill(Me.DsLogin.tbl_Users)
        '
        EditMode = False
        TabControl1.SelectTab(0)
        txtPersonalCode.Focus()
        ''
    End Sub

    Private Sub frmUsers_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
        InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(New Globalization.CultureInfo("fa-IR"))
    End Sub

    Private Sub frmUsers_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(New Globalization.CultureInfo("en-US"))
    End Sub

    Private Sub frmUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
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
                strFilter = String.Format("Username = '{0}'", txtFilter.Text.Trim)
            Case 1
                strFilter = String.Format("PersonalCode = '{0}'", txtFilter.Text.Trim)
            Case 2
                strFilter = String.Format("fname = '{0}'", txtFilter.Text.Trim)
            Case 3
                strFilter = String.Format("lname = '{0}'", txtFilter.Text.Trim)
        End Select
        TblUsersBindingSource.Filter = strFilter
        '
    End Sub

    Private Sub btnRemoveFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveFilter.Click
        TblUsersBindingSource.RemoveFilter()
    End Sub

    Private Sub dgvRM_List_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRM_List.CellClick
        '
        If e.RowIndex < 0 Then Exit Sub

        ' تغییر وضعیت
        If e.ColumnIndex = 8 Then
            Dim Username As String = dgvRM_List.Rows(e.RowIndex).Cells(3).Value
            Dim Status As Boolean = CBool(dgvRM_List.Rows(e.RowIndex).Cells(1).Value)
            MembershipBLL.SetActive(Username, Not Status)
            ClearForm()
        End If

        ' حذف کاربر
        If e.ColumnIndex = 9 Then
            Dim result As MsgBoxResult = MsgBox("آیا میخواهید این کاربر حذف شود؟", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "حذف رکورد")
            If result = MsgBoxResult.Yes Then
                Dim Username As String = dgvRM_List.Rows(e.RowIndex).Cells(3).Value
                MembershipBLL.Delete(Username)
                ClearForm()
            End If
        End If
        '
    End Sub

    Private Sub dgvRM_List_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRM_List.CellDoubleClick
        '
        If e.RowIndex < 0 Then Exit Sub
        EditMode = True
        '
        Dim Username As String = dgvRM_List.Rows(e.RowIndex).Cells(3).Value
        Dim row As DataRow = MembershipBLL.SelectRow(Username)

        txtUsername.Text = row("Username")
        txtPassword.Text = row("Password")
        txtPersonalCode.Text = row("PersonalCode").ToString
        txtfname.Text = row("Fname").ToString
        txtlname.Text = row("Lname").ToString
        txtMelliCode.Text = row("CodeMelli").ToString
        txtAddress.Text = row("Address").ToString
        FillToCombo(row("TelNumbers").ToString.Split(","))

        If IsDBNull(row("Picture")) = False Then
            Dim ByteArray() As Byte = DirectCast(row("Picture"), Byte())
            If ByteArray.Length <> 0 Then
                picPersonalPhoto.Image = Utilities.ByteArray_2_Pic(ByteArray)
            End If
        Else
            picPersonalPhoto.Image = My.Resources.UnknowUser
        End If

        txtUsername.Focus()
        '
    End Sub

    Private Sub dgvRM_List_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvRM_List.CellFormatting

        ' نام کاربری
        If e.ColumnIndex = 0 Then e.Value = (e.RowIndex + 1).ToString()

        ' وضعیت فعالیت
        If e.ColumnIndex = 2 Then
            e.Value = IIf(CBool(dgvRM_List.Rows(e.RowIndex).Cells(1).Value), "فعال", "غیر فعال")
        End If

        ' نام و نام خانوادگی
        If e.ColumnIndex = 6 Then
            e.Value = String.Format("{0} {1}", dgvRM_List.Rows(e.RowIndex).Cells(4).Value, dgvRM_List.Rows(e.RowIndex).Cells(5).Value)
        End If
        ''
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