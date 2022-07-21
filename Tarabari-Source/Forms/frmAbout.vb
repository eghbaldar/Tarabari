Public Class frmAbout

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub

    Private Sub lnkCaspteanTeam_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCaspteanTeam.LinkClicked
        '
        Try
            Shell("explorer " & lnkCaspteanTeam.Text)
        Catch ex As Exception

        End Try
        '
    End Sub

End Class
