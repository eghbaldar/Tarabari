Imports System.Data

Namespace BLL

    <System.ComponentModel.DataObject()> _
    Public Class Maghsad

        Dim MaghsadDAL As New dsTarabariTableAdapters.tbl_MaghsadTableAdapter

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)> _
         Public Function Insert(ByVal NameMaghsad As String) As Boolean
            Try
                Return MaghsadDAL.Insert(NameMaghsad)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
            End Try
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)> _
        Public Function Update(ByVal NameMaghsad As String, ByVal MaghsadID As Integer) As Boolean
            Try
                MaghsadDAL.UpdateQuery(NameMaghsad, MaghsadID)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
            End Try
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)> _
        Public Function Delete(ByVal MaghsadID As Integer) As Boolean
            Try
                Return MaghsadDAL.DeleteQuery(MaghsadID)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
            End Try
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
        Public Function selectall() As DataTable
            Return MaghsadDAL.GetData()
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function SelectRow(ByVal MaghsadID As Integer) As DataRow
            Return MaghsadDAL.GetData.FindByMaghsadID(MaghsadID)
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function GetNameByID(ByVal MaghsadID As Integer) As String
            Return MaghsadDAL.GetNameByID(MaghsadID)
        End Function

    End Class

End Namespace