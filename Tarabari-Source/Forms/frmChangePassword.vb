Public Class frmChangePassword

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.LoginIcon
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim MembershipBLL As New BLL.Membership
        If MembershipBLL.IsValidUser(txtUsername.Text.Trim, txtOldPassword.Text.Trim) Then
            If MembershipBLL.UpdatePassword(txtUsername.Text.Trim, txtNewPassword.Text.Trim) Then
                MessageBox.Show("کلمه عبور با موفقیت تغییر یافت.", "اعلان", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading)
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class
