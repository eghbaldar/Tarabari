Imports System.Data

Namespace BLL

    <System.ComponentModel.DataObject()> _
    Public Class MahalBargiri

        Dim MahalBargiriDAL As New dsTarabariTableAdapters.tbl_MahalBargiriTableAdapter

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)> _
         Public Function Insert(ByVal NameMahal As String) As Boolean
            Try
                Return MahalBargiriDAL.Insert(NameMahal)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
            End Try
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)> _
        Public Function Update(ByVal NameMahal As String, ByVal MahalBargiriID As Integer) As Boolean
            Try
                MahalBargiriDAL.UpdateQuery(NameMahal, MahalBargiriID)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
            End Try
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)> _
        Public Function Delete(ByVal MahalBargiriID As Integer) As Boolean
            Try
                Return MahalBargiriDAL.DeleteQuery(MahalBargiriID)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
            End Try
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
        Public Function selectall() As DataTable
            Return MahalBargiriDAL.GetData()
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function SelectRow(ByVal MahalBargiriID As Integer) As DataRow
            Return MahalBargiriDAL.GetData.FindByMahalBargiriID(MahalBargiriID)
        End Function

    End Class

End Namespace