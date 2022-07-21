Imports System.Data

Namespace BLL

    Public Structure FactorDetailStructor
        Dim Sharh As String
        Dim Mablagh As Integer
    End Structure

    <System.ComponentModel.DataObject()> _
    Public Class FactorTamirat

        Dim masterDAL As New dsTarabariTableAdapters.tbl_TamiratTableAdapter
        Dim DetailDAL As New dsTarabariTableAdapters.tbl_TamiratJoziyatTableAdapter

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)> _
         Public Function Insert(ByVal FactorID As Integer, ByVal RanandePersonalCode As String, ByVal MashinID As Integer, ByVal pDate As String, ByVal NameTamirgah As String, ByVal KhesaratSales As Integer, ByVal KhesaratBadane As Integer, ByVal Detail As List(Of FactorDetailStructor)) As Boolean
            '
            Try
                masterDAL.Insert(FactorID, RanandePersonalCode, MashinID, pDate, NameTamirgah, KhesaratSales, KhesaratBadane)
                If Detail.Count > 0 Then
                    For Each x As FactorDetailStructor In Detail
                        DetailDAL.Insert(FactorID, x.Sharh, x.Mablagh)
                    Next
                End If
                Return True
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
                Return False
            End Try
            '
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)> _
        Public Function Update(ByVal FactorID As Integer, ByVal RanandePersonalCode As String, ByVal MashinID As Integer, ByVal pDate As String, ByVal NameTamirgah As String, ByVal KhesaratSales As Integer, ByVal KhesaratBadane As Integer, ByVal Detail As List(Of FactorDetailStructor)) As Boolean
            '
            Try
                masterDAL.UpdateQuery(RanandePersonalCode, MashinID, pDate, NameTamirgah, KhesaratSales, KhesaratBadane, FactorID)
                DetailDAL.DeleteDetail(FactorID)
                If Detail.Count > 0 Then
                    For Each x As FactorDetailStructor In Detail
                        DetailDAL.Insert(FactorID, x.Sharh, x.Mablagh)
                    Next
                End If
                Return True

            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
                Return False
            End Try
            '
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
        Public Function UpdateProcess(ByVal FactorID As Integer, ByVal Status As Boolean) As Boolean
            '
            Try
                Return masterDAL.UpdateProcess(Status, FactorID)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
                Return False
            End Try
            ''
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
          Public Function ChangePaymentStatus(ByVal FactorID As Integer, ByVal Status As Boolean) As Boolean
            '
            Try
                Return masterDAL.ChangePaymentStatus(Status, FactorID)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
                Return False
            End Try
            ''
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)> _
        Public Function Delete(ByVal FactorID As Integer) As Boolean
            Try
                DetailDAL.DeleteDetail(FactorID)
                masterDAL.DeleteQuery(FactorID)

                Return True
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
                Return False
            End Try
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
        Public Function SelectAll() As DataTable
            Return masterDAL.GetData()
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function SelectOneFactor(ByVal FactorID As Integer) As DataRow
            Return masterDAL.GetData.FindByFactorID(FactorID)
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function SelectOnFactorDetail(ByVal FactorID As Integer) As DataRow
            '
            Using fDAL As New dsTarabariTableAdapters.vFactorListTableAdapter
                Return fDAL.GetData().FindByFactorID(FactorID)
            End Using
            ''
        End Function

        Public Function SelectFactorDetail(ByVal FactorID As Integer) As List(Of FactorDetailStructor)
            '
            Dim tempDatil As New List(Of FactorDetailStructor)
            Dim tblTemp As DataTable = DetailDAL.GetFactorDetail(FactorID)
            Dim item As FactorDetailStructor
            '
            For Each r As DataRow In tblTemp.Rows
                item.Sharh = r("SharhTamirat")
                item.Mablagh = r("Mablagh")
                tempDatil.Add(item)
            Next
            '
            Return tempDatil
            '
        End Function

        Public Function GetCurrentFactorID() As Integer
            Return masterDAL.usp_GetFactorID()
        End Function

        Public Function GetYears() As List(Of String)
            '
            Dim YearsDAL As New dsTarabariTableAdapters.SelectYearsTableAdapter
            Dim resultTemp As New List(Of String)
            Dim dtTemp As DataTable = YearsDAL.GetData
            '
            For Each row As DataRow In dtTemp.Rows
                resultTemp.Add(row("Years"))
            Next
            '
            Return resultTemp
            '
        End Function

        Public Function GetDataToTankhah() As DataTable
            '
            Using fDAL As New dsTarabariTableAdapters.vFactorListTableAdapter
                Return fDAL.GetDataToTankhah()
            End Using
            ''
        End Function

        Public Function GetDataToTankhah(ByVal FactorID As Integer) As DataTable
            '
            Using fDAL As New dsTarabariTableAdapters.vFactorListTableAdapter
                Return fDAL.FindByFactorID(FactorID)
            End Using
            ''
        End Function

        Public Function GetFactorsByMashinIdAndYear(ByVal MashinID As Integer, ByVal Year As String)
            '
            Using fDAL As New dsTarabariTableAdapters.vFactorListTableAdapter
                Return fDAL.GetDataByMashinIdAndYear(MashinID, Year)
            End Using
            ''
        End Function

        Public Function GetTotalPriceByMonth(ByVal MashinID As Integer, ByVal Year As String) As DataTable
            '
            Using tempDAL As New dsTarabariTableAdapters.usp_GetFactorPriceByMonthsTableAdapter
                Return tempDAL.GetData(MashinID, Year)
            End Using
            '
        End Function

        Public Function GetTotalSales(ByVal MashinID As Integer, ByVal Year As String) As Long
            Try
                Return Long.Parse(masterDAL.usp_GetTotalSales(MashinID, Year))
            Catch ex As Exception
                Return 0
            End Try

        End Function

        Public Function GetTotalBadane(ByVal MashinID As Integer, ByVal Year As String) As Long
            Try
                Return Long.Parse(masterDAL.usp_GetTotalBadane(MashinID, Year))
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
                Return 0
            End Try
        End Function

    End Class

End Namespace