Imports System.Data

Namespace BLL

    <System.ComponentModel.DataObject()> _
    Public Class Kafi

        Dim KafiDAL As New dsTarabariTableAdapters.tbl_KafiTableAdapter

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)> _
         Public Function Insert(ByVal KafiID As Integer, ByVal ShasiNumber As String, ByVal Pelak As String) As Boolean
            Try
                Return KafiDAL.Insert(KafiID, ShasiNumber, Pelak)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
            End Try
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)> _
        Public Function Update(ByVal ShasiNumber As String, ByVal Pelak As String, ByVal KafiID As Integer) As Boolean
            Try
                KafiDAL.UpdateQuery(ShasiNumber, Pelak, KafiID)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
            End Try
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)> _
        Public Function Delete(ByVal KafiID As Integer) As Boolean
            Try
                Return KafiDAL.DeleteQuery(KafiID)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
            End Try
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
        Public Function SelectAll() As DataTable
            Return KafiDAL.GetData()
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function SelectRow(ByVal KafiID As Integer) As DataRow
            Return KafiDAL.GetData.FindByKafiID(KafiID)
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function GetKafiID() As Integer
            Return CInt(KafiDAL.usp_GetKafiID())
        End Function

        'Public Function GetPelakByMashinID(ByVal MashinID As Integer) As String
        '    Try
        '        Dim dr As DataRow = KafiDAL.GetData.FindByMashinID(MashinID)
        '        Return dr.Item("Pelak").ToString
        '    Catch ex As Exception
        '        'TODO: trace log
        '        Return String.Empty
        '    End Try
        'End Function

    End Class

End Namespace