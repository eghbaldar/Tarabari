Imports System.Data

Namespace BLL

    <System.ComponentModel.DataObject()> _
    Public Class Ranandegan

        Dim ranandeDAL As New dsTarabariTableAdapters.tbl_RanandeganTableAdapter
        Dim mrDAL As New dsTarabariTableAdapters.tbl_MashinRanandeTableAdapter

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)> _
         Public Function Insert(ByVal RanandePersonalCode As String, ByVal fname As String, ByVal lname As String, ByVal CodeMelli As String, ByVal Address As String, ByVal TelNumbers As String, ByVal Picture() As Byte, ByVal KartHooshmandNo As String, ByVal KH_StartDate As String, ByVal KH_EndDate As String, ByVal KartSalamatNo As String, ByVal KS_StartDate As String, ByVal KS_EndDate As String, ByVal KartGovahinameNo As String, ByVal KG_StartDate As String, ByVal KG_EndDate As String, Optional ByVal MashinID As Integer = Nothing) As Boolean
            Dim bolResult As Boolean
            Try
                bolResult = ranandeDAL.Insert(RanandePersonalCode, fname, lname, CodeMelli, Address, TelNumbers, Picture, KartHooshmandNo, KH_StartDate, KH_EndDate, KartSalamatNo, KS_StartDate, KS_EndDate, KartGovahinameNo, KG_StartDate, KG_EndDate)

                If MashinID <> Nothing Then
                    mrDAL.usp_InsertData(RanandePersonalCode, MashinID)
                End If
                Return bolResult
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
                Return False
            End Try
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)> _
        Public Function Update(ByVal RanandePersonalCode As String, ByVal fname As String, ByVal lname As String, ByVal CodeMelli As String, ByVal Address As String, ByVal TelNumbers As String, ByVal Picture() As Byte, ByVal KartHooshmandNo As String, ByVal KH_StartDate As String, ByVal KH_EndDate As String, ByVal KartSalamatNo As String, ByVal KS_StartDate As String, ByVal KS_EndDate As String, ByVal KartGovahinameNo As String, ByVal KG_StartDate As String, ByVal KG_EndDate As String, Optional ByVal MashinID As Integer = Nothing) As Boolean
            Dim bolResult As Boolean
            Try
                bolResult = ranandeDAL.UpdateQuery(fname, lname, CodeMelli, Address, TelNumbers, Picture, KartHooshmandNo, KH_StartDate, KH_EndDate, KartSalamatNo, KS_StartDate, KS_EndDate, KartGovahinameNo, KG_StartDate, KG_EndDate, RanandePersonalCode)
                If MashinID <> Nothing Then
                    mrDAL.usp_InsertData(RanandePersonalCode, MashinID)
                End If
                Return bolResult
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
                Return False
            End Try
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)> _
        Public Function Delete(ByVal RanandePersonalCode As String) As Boolean
            Dim bolResult As Boolean = False
            Try
                bolResult = ranandeDAL.DeleteQuery(RanandePersonalCode)
                Return bolResult
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
                Return bolResult
            End Try
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
        Public Function SelectAll() As DataTable
            Return ranandeDAL.GetData()
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
        Public Function SelectAll(ByVal RanandePersonalCode As String) As DataRow
            Return ranandeDAL.GetData.FindByRanandePersonalCode(RanandePersonalCode)
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function SelectRow(ByVal RanandePersonalCode As String) As DataRow
            Return ranandeDAL.GetData.FindByRanandePersonalCode(RanandePersonalCode)
        End Function

        Public Function GetMashinIDByPersonalCode(ByVal RanandePersonalCode As String) As Integer
            Try
                Dim dr As DataRow = mrDAL.GetDataByPersonalCode(RanandePersonalCode).Rows(0)
                Return CInt(dr.Item("MashinID").ToString)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
                Return 0
            End Try
        End Function

        Public Function GetFullNameByPersonalCode(ByVal RanandePersonalCode As String) As String
            Try
                Return ranandeDAL.GetFullNameByPersonalCode(RanandePersonalCode)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
                Return String.Empty
            End Try
        End Function

    End Class

End Namespace