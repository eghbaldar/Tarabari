Imports System.Data

Namespace BLL

    <System.ComponentModel.DataObject()> _
    Public Class Sanad

        Dim SanadDAL As New dsTarabariTableAdapters.tbl_SanadTableAdapter

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)> _
        Public Function Insert(ByVal OperationCode As Integer, ByVal OrderID As Integer, ByVal ShomareBarname As Integer, ByVal TarikhBarname As String, ByVal MabdaID As Integer, ByVal MaghsadID As Integer, ByVal NoeBar As String, _
                               ByVal MabnaKomision As Integer, ByVal KolKerayeBarname As Integer, ByVal PayeKerayeBarname As Integer, ByVal DaryaftNaghdi As Integer, ByVal HaghPayane As Integer, _
                               ByVal KomisionBarname As Integer, ByVal BimeBarbari As Integer, ByVal TafavotKomision As Integer, ByVal BimeOmr As Integer, ByVal Bargiri_Takhliye As Integer, ByVal JarimePolice As Integer, ByVal Nobat As Integer, _
                               ByVal AvarezOtooban As Integer, ByVal SahmRanande As Integer, ByVal HazineGhaza_Raft As Integer, ByVal HazineGhaza_Bargasht As Integer, ByVal MeghdarSookht As Integer, ByVal Total As Integer, _
                               ByVal Darsad_SahmRanande As Single, ByVal Darsad_HazineGhaza_Raft As Single, ByVal Darsad_HazineGhaza_Bargasht As Single, ByVal MablaghSookht As Integer, ByVal Darsad_HaghPayane As Single, _
                               ByVal Darsad_KomisionBarname As Single)
            '
            Try
                SanadDAL.Insert(OperationCode, OrderID, ShomareBarname, TarikhBarname, MabdaID, MaghsadID, NoeBar, _
                                MabnaKomision, KolKerayeBarname, PayeKerayeBarname, DaryaftNaghdi, HaghPayane, _
                                KomisionBarname, BimeBarbari, TafavotKomision, BimeOmr, Bargiri_Takhliye, JarimePolice, Nobat, _
                                AvarezOtooban, SahmRanande, HazineGhaza_Raft, HazineGhaza_Bargasht, MeghdarSookht, Total, _
                                Darsad_SahmRanande, Darsad_HazineGhaza_Raft, Darsad_HazineGhaza_Bargasht, MablaghSookht, Darsad_HaghPayane, _
                                Darsad_KomisionBarname, False)
                Return True
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
                Return False
            End Try
            ''
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)> _
        Public Function DeleteSanad(ByVal OperationCode As Integer) As Boolean
            '
            Try
                SanadDAL.DeleteSanad(OperationCode)
                Return True
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
                Return False
            End Try
            ''
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
        Public Function UpdateProcess(ByVal SanadID As Integer, ByVal Status As Boolean) As Boolean
            '
            Try
                Return SanadDAL.UpdateProcess(Status, SanadID)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
                Return False
            End Try
            ''
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
          Public Function ChangePaymentStatus(ByVal SanadID As Integer, ByVal Status As Boolean) As Boolean
            '
            Try
                Return SanadDAL.ChangePaymentStatus(Status, SanadID)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
                Return False
            End Try
            ''
        End Function

        ' سطر های یک سند را بر میگرداند
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
        Public Function SelectSanadDetailRows(ByVal OperationCode As Integer) As DataTable
            '
            Dim dtTemp As DataTable = Nothing
            Try
                dtTemp = SanadDAL.GetDataByOperationCode(OperationCode)
                Return dtTemp
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
                Return Nothing
            End Try
            ''
        End Function

        Public Function SelectSanadRow(ByVal OperationCode As Integer) As DataTable
            '
            Using vSanadDAL As New dsTarabariTableAdapters.vSanadListTableAdapter
                Return vSanadDAL.GetDataByOperationCode(OperationCode)
            End Using
            ''
        End Function

        Public Function SelectSanadListToTankhah() As DataTable
            '
            Using vSanadDAL As New dsTarabariTableAdapters.vSanadListTableAdapter
                Return vSanadDAL.GetData4Tankhah()
            End Using
            ''
        End Function

    End Class

End Namespace