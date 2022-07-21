Imports System.Data

Namespace BLL

    <System.ComponentModel.DataObject()> _
    Public Class Mashin

        Dim MashinDAL As New dsTarabariTableAdapters.tbl_MashinTableAdapter

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)> _
         Public Function Insert(ByVal MashinID As Integer, ByVal KafiID As Integer, ByVal Pelak As String, ByVal ShasiNumber As String, ByVal MotorNumber As String) As Boolean
            Try
                Return MashinDAL.Insert(MashinID, KafiID, Pelak, ShasiNumber, MotorNumber)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
            End Try
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)> _
        Public Function Update(ByVal MashinID As Integer, ByVal KafiID As Integer, ByVal Pelak As String, ByVal ShasiNumber As String, ByVal MotorNumber As String) As Boolean
            Try
                MashinDAL.UpdateQuery(KafiID, Pelak, ShasiNumber, MotorNumber, MashinID)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
            End Try
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)> _
        Public Function Delete(ByVal MashinID As Integer) As Boolean
            Try
                Return MashinDAL.DeleteQuery(MashinID)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
            End Try
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
        Public Function SelectAll() As DataTable
            Return MashinDAL.GetData()
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function SelectRow(ByVal MashinID As Integer) As DataRow
            Return MashinDAL.GetData.FindByMashinID(MashinID)
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function GetMashinID() As Integer
            Return CInt(MashinDAL.usp_GetMashinID())
        End Function

        Public Function GetPelakByMashinID(ByVal MashinID As Integer) As String
            Try
                Dim dr As DataRow = MashinDAL.GetData.FindByMashinID(MashinID)
                Return dr.Item("Pelak").ToString
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
                Return String.Empty
            End Try
        End Function

    End Class

End Namespace