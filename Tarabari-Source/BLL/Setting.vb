Imports System.Data

Namespace BLL

    <System.ComponentModel.DataObject()> _
    Public Class Setting

        Dim SettingDAL As New dsTarabariTableAdapters.tbl_SettingTableAdapter

        Public Structure ApplicationSetting
            Dim SahmRanande As Double
            Dim HazineGhaza_Raft As Double
            Dim HazineGhaza_Bargasht As Double
            Dim MablaghSookht As Integer
            Dim HaghPayane As Double
            Dim KomisionBarname As Double
        End Structure

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)> _
        Public Function UpdateSetting(ByVal SahmRanande As Byte, ByVal HazineGhaza_Raft As Byte, ByVal HazineGhaza_Bargasht As Byte, ByVal MablaghSookht As Integer, ByVal HaghPayane As Byte, ByVal KomisionBarname As Integer) As Boolean
            Try
                SettingDAL.UpdateQuery(SahmRanande, HazineGhaza_Raft, HazineGhaza_Bargasht, MablaghSookht, HaghPayane, KomisionBarname)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
            End Try
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function ReadSetting() As ApplicationSetting
            '
            Dim tempSetting As ApplicationSetting
            Dim dr As DataRow = SettingDAL.GetData.FindByID(1)
            '
            tempSetting.SahmRanande = dr("SahmRanande") / 100
            tempSetting.HazineGhaza_Raft = dr("HazineGhaza_Raft") / 100
            tempSetting.HazineGhaza_Bargasht = dr("HazineGhaza_Bargasht") / 100
            tempSetting.MablaghSookht = dr("MablaghSookht")
            tempSetting.HaghPayane = dr("HaghPayane") / 100
            tempSetting.KomisionBarname = dr("KomisionBarname") / 100
            '
            Return tempSetting
            '
        End Function

    End Class

End Namespace