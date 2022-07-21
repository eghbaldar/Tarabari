Imports System.Data

Namespace BLL

    <System.ComponentModel.DataObject()> _
    Public Class vSelectNavgan

        Dim DAL As New dsTarabariTableAdapters.vSelectNavganTableAdapter

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
        Public Function SelectAll() As DataTable
            Return DAL.GetData()
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function SelectByOperationCode(ByVal OpeartionCode As String) As DataRow
            Try
                Return DAL.GetDataByOperationCode(OpeartionCode).Rows(0)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
                Return Nothing
            End Try
        End Function


        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function SelectDtByOperationCode(ByVal OpeartionCode As String) As DataTable
            Try
                Return DAL.GetDataByOperationCode(OpeartionCode)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
                Return Nothing
            End Try
        End Function

    End Class

End Namespace