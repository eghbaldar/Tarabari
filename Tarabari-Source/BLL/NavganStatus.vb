Imports System.Data

Namespace BLL

    <System.ComponentModel.DataObject()> _
    Public Class NavganStatus

        Dim DAL As New dsTarabariTableAdapters.tbl_NavganStatusTableAdapter

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)> _
        Public Function Insert(ByVal RanandePersonalCode As String, ByVal pDate As String, ByVal VaziyatSafar As Byte, ByVal VaziyatBazgasht As Byte, ByVal VaziyatTamirgah As Byte, ByVal VaziyatRanandeh As Byte, ByVal Description As String) As Boolean
            '
            Dim bolResult As Boolean
            Try
                bolResult = DAL.usp_InsertNavagnStatus(RanandePersonalCode, _
                                                       pDate, _
                                                       VaziyatSafar, _
                                                       VaziyatBazgasht, _
                                                       VaziyatTamirgah, _
                                                       VaziyatRanandeh, _
                                                       Description)
                Return bolResult
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
                Return False
            End Try
            ''
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
        Public Function SelectByDate(ByVal pDate As String) As DataTable
            '
            Try
                Return DAL.SelectByDate(pDate)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
                Return Nothing
            End Try
            ''
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
        Public Function SelectByPersonalCodeAndDate(ByVal PersonalCode As Integer, ByVal pDate As String) As DataTable
            '
            Try
                Return DAL.SelectByPersonalCodeAndDate(pDate, PersonalCode)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
                Return Nothing
            End Try
            ''
        End Function

    End Class

End Namespace