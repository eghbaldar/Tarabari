Imports System.Data

Namespace BLL

    <System.ComponentModel.DataObject()> _
    Public Class Mabda

        Dim mabdaDAL As New dsTarabariTableAdapters.tbl_MabdaTableAdapter

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)> _
         Public Function Insert(ByVal NameMabda As String) As Boolean
            Try
                Return mabdaDAL.Insert(NameMabda)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
            End Try
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)> _
        Public Function Update(ByVal NameMabda As String, ByVal MabdaID As Integer) As Boolean
            Try
                mabdaDAL.UpdateQuery(NameMabda, MabdaID)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
            End Try
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)> _
        Public Function Delete(ByVal MabdaID As Integer) As Boolean
            Try
                Return mabdaDAL.DeleteQuery(MabdaID)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
            End Try
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
        Public Function SelectAll() As DataTable
            Return mabdaDAL.GetData()
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function SelectRow(ByVal MabdaID As Integer) As DataRow
            Return mabdaDAL.GetData.FindByMabdaID(MabdaID)
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function GetNameByID(ByVal MabdaID As Integer) As String
            Return mabdaDAL.GetNameByID(MabdaID)
        End Function

    End Class

End Namespace