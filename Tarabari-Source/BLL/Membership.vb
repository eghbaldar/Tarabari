Imports System.Data

Namespace BLL

    <System.ComponentModel.DataObject()> _
    Public Class Membership

        Dim UsersDAL As New dsLoginTableAdapters.tbl_UsersTableAdapter
        Dim LoginHistoryDAL As New dsLoginTableAdapters.tbl_LoginHistoryTableAdapter

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)> _
         Public Function AddUser(ByVal Username As String, ByVal Password As String, ByVal PersonalCode As String, ByVal Fname As String, ByVal Lname As String, ByVal CodeMelli As String, ByVal Address As String, ByVal TelNumbers As String, ByVal Picture() As Byte) As Boolean
            Try
                Return UsersDAL.Insert(Username, Password, PersonalCode, Fname, Lname, CodeMelli, Address, TelNumbers, Picture, False)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
            End Try
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
        Public Function UpdateUser(ByVal Username As String, ByVal Password As String, ByVal PersonalCode As String, ByVal Fname As String, ByVal Lname As String, ByVal CodeMelli As String, ByVal Address As String, ByVal TelNumbers As String, ByVal Picture() As Byte) As Boolean
            Try
                Return UsersDAL.UpdateUser(Password, PersonalCode, Fname, Lname, CodeMelli, Address, TelNumbers, Picture, Username)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
            End Try
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
        Public Function UpdatePassword(ByVal Username As String, ByVal Password As String) As Boolean
            Try
                Return UsersDAL.UpdatePassword(Username, Password)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
            End Try
        End Function

        Public Sub SetActive(ByVal Username As String, ByVal IsActive As Boolean)
            Try
                UsersDAL.SetActive(IsActive, Username)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
            End Try
        End Sub

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)> _
        Public Function Delete(ByVal Username As String) As Boolean
            Try
                Return UsersDAL.DeleteQuery(Username)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
            End Try
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
        Public Function SelectAll() As DataTable
            Return UsersDAL.GetData()
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function SelectRow(ByVal Username As String) As DataRow
            Return UsersDAL.GetData.FindByUsername(Username)
        End Function

        Public Function IsValidUser(ByVal Username As String, ByVal Password As String) As Boolean
            'Try
            Return CBool(UsersDAL.IsValidUser(Username, Password))
            'Catch ex As Exception
            'CaspianTools.Logger.WriteError(ex)
            'End Try
        End Function

        Private Function GetCurrentLoginHistoryID() As Integer
            Try
                Return LoginHistoryDAL.usp_GetCurrentLoginHistoryID()
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
            End Try
        End Function

        Public Function HistoryLogin(ByVal Username As String, ByVal LoginDate As String, ByVal LoginTime As String) As Integer
            Try
                Dim id As Integer = GetCurrentLoginHistoryID()
                LoginHistoryDAL.Login(id, Username, LoginDate, LoginTime)
                Return id
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
            End Try
        End Function

        Public Function HistoryLogout(ByVal ID As Long, ByVal LogoutDate As String, ByVal LogoutTime As String) As Boolean
            Try
                Return LoginHistoryDAL.Logout(LogoutDate, LogoutTime, ID)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
            End Try
        End Function

    End Class

End Namespace