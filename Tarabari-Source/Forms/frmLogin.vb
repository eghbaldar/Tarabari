Public Class frmLogin

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.LoginIcon
        lblDate.Text = FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(Date.Now).ToString("yyyy/mm/dd")
        lblTime.Text = FormatDateTime(Date.Now, DateFormat.LongTime)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = FormatDateTime(Date.Now, DateFormat.LongTime)
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim MembershipBLL As New BLL.Membership
        If MembershipBLL.IsValidUser(txtUsername.Text.Trim, txtPassword.Text.Trim) Then
            Dim pdate As String = FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(Date.Now).ToString("yyyy/mm/dd")
            Dim time As String = FormatDateTime(Date.Now, DateFormat.ShortTime)
            Utilities.hID = MembershipBLL.HistoryLogin(txtUsername.Text.Trim, pdate, time)
            ''TODO: رفتن به فرم اصلی
            frmMain.Show()
            Me.Hide()
        Else
            MessageBox.Show("نام کاربری یا کلمه عبور اشتباه است.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading)
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class
