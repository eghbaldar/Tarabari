Imports System.Data

Namespace BLL

    <System.ComponentModel.DataObject()> _
    Public Class Navgan

        Dim NavganDAL As New dsTarabariTableAdapters.tbl_EzamNavganTableAdapter

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)> _
         Public Function EzamKhodro(ByVal OperationCode As Integer, ByVal RanandePersonalCode As String, ByVal MashinID As Integer, ByVal MahalBargiriID As Integer, ByVal MabdaID As Integer, ByVal MaghsadID As Integer, ByVal NoeBar As String, ByVal Tozihat As String, ByVal TarikhEzamBargiri As String, ByVal TarikhHozoorMahalBargiri As String, ByVal SaatHozoorMahalBagiri As String, ByVal ShomareBarnameRaft As String, ByVal TarikhBarnameRaft As String, ByVal SaatSodoorBarname As String, ByVal KiloometrKhorroojMojtame As Integer, ByVal MeghdarSookhtKhorooj As Integer, ByVal TarikhKhoroojMojtame As String, ByVal SaatKhoroojMojtame As String) As Boolean
            Dim bolResult As Boolean
            Try
                bolResult = NavganDAL.EzamKhodro(OperationCode, RanandePersonalCode, MashinID, MahalBargiriID, MabdaID, MaghsadID, NoeBar, Tozihat, TarikhEzamBargiri, TarikhHozoorMahalBargiri, SaatHozoorMahalBagiri, ShomareBarnameRaft, TarikhBarnameRaft, SaatSodoorBarname, KiloometrKhorroojMojtame, MeghdarSookhtKhorooj, TarikhKhoroojMojtame, SaatKhoroojMojtame)
                Return bolResult
            Catch ex As Exception
                Return False
                CaspianTools.Logger.WriteError(ex)
            End Try
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)> _
        Public Function BazgashtKhodro(ByVal KiloometrVoroodMojtame As Integer, ByVal MeghdarSookhtVorood As Integer, ByVal MasafatTeyShode As Integer, ByVal SookhtMasrafShode As Integer, ByVal TarikhHozoorMahalTakhliyeAval As String, ByVal SaatHozoorMahalTakhliyeAval As String, ByVal TarikhBargiriMojadad As String, ByVal SaatBargiriMojadad As String, ByVal TarikhKhoroojMahalTakhliyeAval As String, ByVal SaatKhooojMahalTakhliyeAval As String, ByVal ShomareBarnameBargasht As String, ByVal TarikhBarnameBargasht As String, ByVal MablaghKerayeBargasht As Integer, ByVal MablaghKerayeRaft As Integer, ByVal TarikhVoroodMojtame As String, ByVal SaatVoroodMojtame As String, ByVal OperationCode As String) As Boolean
            'Dim bolResult As Boolean
            'Try
            '    bolResult = NavganDAL.BazgashtKhodro(IIf(KiloometrVoroodMojtame = "", 0, KiloometrVoroodMojtame), _
            '                                         IIf(MeghdarSookhtVorood = "", 0, MeghdarSookhtVorood), _
            '                                         IIf(MasafatTeyShode = "", 0, MasafatTeyShode), _
            '                                         IIf(SookhtMasrafShode = "", 0, SookhtMasrafShode), _
            '                                         TarikhHozoorMahalTakhliyeAval, _
            '                                         SaatHozoorMahalTakhliyeAval, _
            '                                         TarikhBargiriMojadad, _
            '                                         SaatBargiriMojadad, _
            '                                         TarikhKhoroojMahalTakhliyeAval, _
            '                                         SaatKhooojMahalTakhliyeAval, _
            '                                         IIf(ShomareBarnameBargasht = "", Nothing, ShomareBarnameBargasht), _
            '                                         TarikhBarnameBargasht, _
            '                                         IIf(MablaghKerayeBargasht = "", Nothing, MablaghKerayeBargasht), _
            '                                         MablaghKerayeRaft, _
            '                                         TarikhVoroodMojtame, _
            '                                         SaatVoroodMojtame, _
            '                                         OperationCode)
            '    Return bolResult
            'Catch ex As Exception
            '    Return False
            '    ''TODO: trace log
            'End Try


            If ShomareBarnameBargasht = String.Empty Then ShomareBarnameBargasht = Nothing
            Return NavganDAL.BazgashtKhodro(KiloometrVoroodMojtame, _
                                            MeghdarSookhtVorood, _
                                            MasafatTeyShode, _
                                            SookhtMasrafShode, _
                                            TarikhHozoorMahalTakhliyeAval, _
                                            SaatHozoorMahalTakhliyeAval, _
                                            TarikhBargiriMojadad, _
                                            SaatBargiriMojadad, _
                                            TarikhKhoroojMahalTakhliyeAval, _
                                            SaatKhooojMahalTakhliyeAval, _
                                            ShomareBarnameBargasht, _
                                            TarikhBarnameBargasht, _
                                            MablaghKerayeBargasht, _
                                            MablaghKerayeRaft, _
                                            TarikhVoroodMojtame, _
                                            SaatVoroodMojtame, _
                                            OperationCode)


        End Function

        '<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)> _
        'Public Function Delete(ByVal RanandePersonalCode As String) As Boolean
        '    Dim bolResult As Boolean = False
        '    Try
        '        bolResult = ranandeDAL.DeleteQuery(RanandePersonalCode)
        '        Return bolResult
        '    Catch ex As Exception
        '        ''TODO: trace log
        '        Return bolResult
        '    End Try
        'End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
        Public Function SelectAll() As DataTable
            Return NavganDAL.GetData()
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function SelectRow(ByVal OperatinCode As String) As DataRow
            Try
                Return NavganDAL.GetDataByOperationCode(OperatinCode).Rows(0)
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function GetCurrentOperationCode() As Integer
            Return NavganDAL.usp_GetCurrentOperationCode()
        End Function

        Public Function KarkardRoozane(ByVal pDate As String) As DataTable
            Using action As New dsTarabariTableAdapters.usp_KarkardeRoozane4PrintTableAdapter
                Dim dt As DataTable = action.GetData(pDate)
                Return dt
            End Using
        End Function

    End Class

End Namespace