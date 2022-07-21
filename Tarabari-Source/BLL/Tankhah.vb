Imports System.Data

Namespace BLL

    Public Structure TankhahDetailStructor
        Dim FS_ID As Integer   ' Factor Sanad ID
        Dim TedadBargZamime As String
        Dim ShomareSanadPardakht As Integer
        Dim ShomareResidAnbar As Integer
        Dim Molahezat As String
        Dim IsFactor As Boolean
    End Structure

    <System.ComponentModel.DataObject()> _
    Public Class Tankhah

        Dim masterDAL As New dsTarabariTableAdapters.tbl_TankhahTableAdapter
        Dim DetailSanadDAL As New dsTarabariTableAdapters.tbl_TankhahDetail_SanadTableAdapter
        Dim DetailFactorDAL As New dsTarabariTableAdapters.tbl_TankhahDetail_FactorTableAdapter

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)> _
         Public Function Insert(ByVal TankhahID As Integer, ByVal TankhahSanadID As Integer, ByVal pDate As String, ByVal Vajhe As String, ByVal TotalValue As Integer, ByVal Detail As List(Of TankhahDetailStructor)) As Boolean
            '
            Try
                masterDAL.Insert(TankhahID, TankhahSanadID, pDate, Vajhe, TotalValue)
                If Detail.Count > 0 Then
                    For Each item As TankhahDetailStructor In Detail
                        If item.IsFactor Then
                            DetailFactorDAL.Insert(TankhahID, item.FS_ID, item.TedadBargZamime, item.ShomareSanadPardakht, item.ShomareResidAnbar, item.Molahezat)
                        Else
                            DetailSanadDAL.Insert(TankhahID, item.FS_ID, item.TedadBargZamime, item.ShomareSanadPardakht, item.ShomareResidAnbar, item.Molahezat)
                        End If
                    Next
                End If
                Return True
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
                Return False
            End Try
            ''
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)> _
         Public Function Update(ByVal TankhahID As Integer, ByVal TankhahSanadID As Integer, ByVal pDate As String, ByVal Vajhe As String, ByVal TotalValue As Integer, ByVal Detail As List(Of TankhahDetailStructor)) As Boolean
            '
            Try
                ' ویرایش اطلاعات هدر
                masterDAL.UpdateQuery(TankhahSanadID, pDate, Vajhe, TotalValue, TankhahID)


                ' حذف اطلاعات قبلی در دیتل
                DetailFactorDAL.DeleteQuery(TankhahID)
                DetailSanadDAL.DeleteQuery(TankhahID)

                ' افزودن اطلاعات جدید
                If Detail.Count > 0 Then
                    For Each item As TankhahDetailStructor In Detail
                        If item.IsFactor Then
                            DetailFactorDAL.Insert(TankhahID, item.FS_ID, item.TedadBargZamime, item.ShomareSanadPardakht, item.ShomareResidAnbar, item.Molahezat)
                        Else
                            DetailSanadDAL.Insert(TankhahID, item.FS_ID, item.TedadBargZamime, item.ShomareSanadPardakht, item.ShomareResidAnbar, item.Molahezat)
                        End If
                    Next
                End If
                Return True

            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
                Return False
            End Try
            '
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)> _
        Public Function Delete(ByVal TankhahID As Integer) As Boolean
            Try
                masterDAL.DeleteTankhah(TankhahID)
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

        '<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        'Public Function SelectTankhahRow(ByVal TankhahID As Integer) As DataRow
        '    Return masterDAL.GetData.FindByTankhahID(TankhahID)
        'End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function SelectTankhahDetail(ByVal TankhahID As Integer) As List(Of TankhahDetailStructor)
            '
            Dim tempDatil As New List(Of TankhahDetailStructor)
            Dim tblTemp As DataTable
            Using tempDAL As New dsTarabariTableAdapters.usp_GetTankhahDetailByTankhahIDTableAdapter
                tblTemp = tempDAL.GetData(TankhahID)
            End Using

            Dim item As TankhahDetailStructor
            '
            For Each r As DataRow In tblTemp.Rows
                item.FS_ID = r("FS_ID")
                item.TedadBargZamime = r("TedadBargZamime")
                item.ShomareSanadPardakht = r("ShomareSanadPardakht")
                item.ShomareResidAnbar = r("ShomareResidAnbar")
                item.Molahezat = r("Molahezat")
                item.IsFactor = IIf(CBool(r("Type")), True, False)
                tempDatil.Add(item)
            Next
            '
            Return tempDatil
            '
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function SelectTankhahDetail4Print(ByVal TankhahID As Integer) As DataTable
            '
            Dim tblTemp As DataTable
            '
            Using tempDAL As New dsTarabariTableAdapters.usp_GetTankhahDetailByTankhahIDTableAdapter
                tblTemp = tempDAL.GetData(TankhahID)
            End Using
            '
            Return tblTemp
            ''
        End Function

        Public Function GetCurrentTankhahID() As Integer
            Return masterDAL.usp_GetTankhahID()
        End Function

    End Class

End Namespace