Public Class frmInstallDB

    'Private Function GetServerName() As List(Of String)
    '    '
    '    Dim ServerList As New List(Of String)

    '    Dim dt As DataTable = System.Data.Sql.SqlDataSourceEnumerator.Instance.GetDataSources()
    '    For Each row As DataRow In dt.Rows
    '        ServerList.Add(row(0).ToString)
    '    Next

    '    Return ServerList
    '    ''
    'End Function

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        '
        Dim SQLUtil As CaspianTools.SqlUtility

        Try
            lblWait.Visible = True

            lblStep1.Visible = True
            SQLUtil = New CaspianTools.SqlUtility(cmbServerName.Text)

            lblStep2.Visible = True
            If chkInstallDB.Checked Then
                'Dim path As String = Application.StartupPath + "\db\dbTarabari.mdf"
                'SQLUtil.CreateAttach("dbTarabari", path)

                Dim path1 As String = Application.StartupPath + "\db\dbTarabari.mdf"
                Dim path2 As String = Application.StartupPath + "\db\dbTarabari_log.ldf"
                SQLUtil.Attach("dbTarabari", path1, path2)
            End If

            lblStep3.Visible = True
            lblWait.Visible = False
            btnOk.Enabled = True

            Dim Reg As New CaspianTools.Registry
            Reg.WriteSubKeyValue(CaspianTools.Registry.PredefinedKeys.HKEY_CURRENT_USER, "Caspian\Tarabari", "FirstRun", "True", Microsoft.Win32.RegistryValueKind.String)

            Dim NewConnectionString As String = CaspianTools.SqlUtility.GetConnectionString(cmbServerName.Text, "dbTarabari")

            EditConnectionString(NewConnectionString)
        Catch ex As Exception
            MessageBox.Show("در پیکربندی نرم افزار خطایی رخ داده است.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading)
            CaspianTools.Logger.WriteError(ex)
        End Try
        '
    End Sub

    Private Sub frmInstallDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbServerName.DataSource = CaspianTools.SqlUtility.GetServerName()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        MessageBox.Show("پس از خروج از صفحه، برنامه را دوباره اجرا کنید.", "نرم افزار مدیریت ترابری", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading)
        Me.Close()
    End Sub

    Private Sub EditConnectionString(ByVal ConnStr As String)
        '
        Dim path As String = Reflection.Assembly.GetExecutingAssembly.Location + ".config"
        Dim myDoc As New Xml.XmlDocument
        myDoc.Load(path)
        Try
            Dim TempNode As Xml.XmlNodeList = myDoc.SelectNodes("configuration//connectionStrings//add")

            'TempNode(0).Attributes(1).Name   ===>   ConnectionString
            TempNode(0).Attributes(1).Value = ConnStr

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        '        
        myDoc.Save(path)
        '
    End Sub

End Class