Public Class frmReport

    Public Enum EnumReportType
        Karkarde_Roozane
        Barge_Ezam
        Tankhah
        SanadNaghdi
        PardakhtFactorPrice
    End Enum

    Public Sub New(ByVal dt As DataTable, ByVal strData As String, ByVal ReportType As EnumReportType)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        '
        Select Case ReportType

            Case EnumReportType.Karkarde_Roozane
                rptKarkardeRoozane1.SetDataSource(dt)
                rptKarkardeRoozane1.SetParameterValue("Tarikh", strData)
                CrystalReportViewer1.ReportSource = rptKarkardeRoozane1

            Case EnumReportType.Barge_Ezam
                rptBargeEzam1.SetDataSource(dt)
                CrystalReportViewer1.ReportSource = rptBargeEzam1

            Case EnumReportType.Tankhah
                rptTankhah1.SetDataSource(dt)
                rptTankhah1.SetParameterValue("TotalValueHoroofi", strData)
                CrystalReportViewer1.ReportSource = rptTankhah1

            Case EnumReportType.SanadNaghdi
                rptSanadNaghdi1.SetDataSource(dt)
                rptSanadNaghdi1.SetParameterValue("TotalValueHoroofi", strData)
                CrystalReportViewer1.ReportSource = rptSanadNaghdi1

            Case EnumReportType.PardakhtFactorPrice
                rptPardakhtFactorPrice1.SetDataSource(dt)
                rptPardakhtFactorPrice1.SetParameterValue("SubTotal", strData)
                CrystalReportViewer1.ReportSource = rptPardakhtFactorPrice1


        End Select
        ''
    End Sub

    Public Sub New(ByVal dt As DataTable, ByVal RanandeFullname As String, ByVal pDate As String, ByVal MashinID As Integer, ByVal Pelak As String)
        InitializeComponent()
        '
        rptSanadBarname1.SetDataSource(dt)
        rptSanadBarname1.SetParameterValue("RanandeFullname", RanandeFullname)
        rptSanadBarname1.SetParameterValue("pDate", pDate)
        rptSanadBarname1.SetParameterValue("MahinID", MashinID.ToString)
        rptSanadBarname1.SetParameterValue("Pelak", Pelak)
        CrystalReportViewer1.ReportSource = rptSanadBarname1
        ''
    End Sub
End Class
