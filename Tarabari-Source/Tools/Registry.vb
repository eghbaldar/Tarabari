Imports Microsoft.Win32
Imports System.Windows.Forms

Namespace CaspianTools

    Public Class Registry

        Enum PredefinedKeys
            HKEY_CURRENT_USER
            HKEY_USERS
            HKEY_CLASSES_ROOT
            HKEY_LOCAL_MACHINE
            HKEY_CURRENT_CONFIG
        End Enum

#Region " Writing Methods "
        ''' <summary>
        ''' Function to create a new SubKey in the Windows Registry
        ''' </summary>
        ''' <param name="Hive">RegistryKey -> One of the 6 main keys to create the subkey in</param>
        ''' <param name="sKey">String -> Name of the subkey to create</param>
        ''' <param name="KeyPermissions">RegistryKepPermissionCheck -> Specifies permissions of the SubKey to be created</param>
        ''' <returns>True (Succeeded)/False (Failed)</returns>
        ''' <remarks>Created 23JUN05 -> Richard L. McCutchen</remarks>
        Public Function CreateRegistrySubKey(ByVal Hive As PredefinedKeys, ByVal sKey As String, ByVal KeyPermissions As RegistryKeyPermissionCheck) As Boolean
            '
            Dim MainKey As RegistryKey = ToRegisteryKey(Hive)
            Try
                'create the new subkey
                MainKey.CreateSubKey(sKey, KeyPermissions)
                Return True
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: Creating SubKey", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
            '
        End Function

        Public Function CreateRegistrySubKey(ByVal Hive As PredefinedKeys, ByVal ParentKey As String, ByVal sKey As String, ByVal KeyPermissions As RegistryKeyPermissionCheck) As Boolean
            '
            Dim MainKey As RegistryKey = ToRegisteryKey(Hive)
            Try
                MainKey.OpenSubKey(ParentKey, True).CreateSubKey(sKey, KeyPermissions)
                ''create the new subkey
                'MainKey.CreateSubKey(sKey, KeyPermissions)
                Return True
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: Creating SubKey", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
            '
        End Function

        ''' <summary>
        ''' Writes a value in the Registry
        ''' </summary>
        ''' <param name="Hive">RegistryKey -> One of the 6 main keys that you want to write to</param>
        ''' <param name="sKey">String -> Name of the subkey you want to write to. If the subkey doesnt
        ''' exist it will be created</param>
        ''' <param name="sKeyName">String -> Name of the value to create</param>
        ''' <param name="oNameValue">Object -> Value to be stored</param>
        ''' <param name="RegType">RegistryValueKind -> Data type of the subkey value</param>
        ''' <returns>True (Succeedeed)/False (Failed)</returns>
        ''' <remarks>Created 23JUN05 -> Richard L. McCutchen</remarks>
        Public Function WriteSubKeyValue(ByVal Hive As PredefinedKeys, ByVal sKey As String, ByVal sKeyName As String, ByVal oNameValue As Object, ByVal RegType As RegistryValueKind) As Boolean
            '
            Dim MainKey As RegistryKey = ToRegisteryKey(Hive)
            Dim rkKey As RegistryKey
            Try
                'Open the given subkey
                rkKey = MainKey.OpenSubKey(sKey, True)
                'check to see if the subkey exists
                If rkKey Is Nothing Then 'doesnt exist
                    'create the subkey
                    rkKey = MainKey.CreateSubKey(sKey, RegistryKeyPermissionCheck.Default)
                End If
                'set the value of the subkey
                rkKey.SetValue(sKeyName, oNameValue, RegType)
                Return True
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: Writing Registry Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
            '
        End Function
#End Region

#Region " Reading Methods "

        ''' <summary>
        ''' Function to read a value from the Registry
        ''' </summary>
        ''' <param name="Hive">RegistryKey -> One of the 6 main level keys you want to write to</param>
        ''' <param name="ParentKey">String -> Sub key you want to read</param>
        ''' <param name="sKeyName">String -> Name of the value you want to read</param>
        ''' <param name="oNameValue">Object -> The value to be read</param>
        ''' <returns>True (Succeeded)/False (Failed)</returns>
        ''' <remarks>Created 23JUN05 -> Richard L. McCutchen</remarks>
        Public Function ReadRegistryValue(ByVal Hive As PredefinedKeys, ByVal ParentKey As String, ByVal sKeyName As String, ByRef oNameValue As Object, ByVal DefaultValue As Object) As String
            '
            Dim MainKey As RegistryKey = ToRegisteryKey(Hive)
            Dim rkKey As RegistryKey
            Dim Value As New String("")
            Try
                'open the given subkey
                rkKey = MainKey.OpenSubKey(ParentKey, True)
                'check to see if the subkey exists
                If rkKey Is Nothing Then 'it doesnt exist
                    Value = DefaultValue
                    'Throw New Exception("The Registry SubKey provided doesnt exist!")
                End If
                'get the value
                oNameValue = rkKey.GetValue(sKeyName)
                Value = oNameValue.ToString
            Catch ex As Exception
                Value = DefaultValue
                'MessageBox.Show(ex.Message, "Error: Reading Registry Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Return Value
            ''
        End Function
#End Region

#Region " Deleting Methods "

        ''' <summary>
        ''' Function to delete a subkey value from the Windows Registry
        ''' </summary>
        ''' <param name="Hive">RegistryKey -> One of the 6 main keys you want to delete from</param>
        ''' <param name="sKey">String -> Name of the SubKey you want to delete a value from</param>
        ''' <param name="sKeyName">String -> Name of the value to delete</param>
        ''' <returns>True (Succeeded)/False (Failed)</returns>
        ''' <remarks>Created 23JUN05 -> Richard L. McCutchen</remarks>
        Public Function DeleteSubKeyValue(ByVal Hive As PredefinedKeys, ByVal sKey As String, ByVal sKeyName As String) As Boolean
            '
            Dim MainKey As RegistryKey = ToRegisteryKey(Hive)
            Dim rkKey As RegistryKey
            Try
                'open the given subkey
                rkKey = MainKey.OpenSubKey(sKey, True)
                'check to make sure the subkey exists
                If Not sKey Is Nothing Then 'subkey exists
                    'delete the subkey
                    MainKey.DeleteValue(sKeyName, True)
                    Return True
                Else    'subkey doesnt exist
                    'throw an exception
                    Throw New Exception("The SubKey provided doesnt exist! Please check your entry and try again")
                    Return False
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: Deleting SubKey Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
            '
        End Function

        ''' <summary>
        ''' Function to delete a SubKey from the Windows Registry
        ''' </summary>
        ''' <param name="Hive">RegistryKey -> One of the top main keys to delete from</param>
        ''' <param name="sKey">String -> Name of the SubKey to delete</param>
        ''' <returns>True (Succeeded)/False (Failed)</returns>
        ''' <remarks>Created 23JUN05 -> Richard L. McCutchen</remarks>
        Public Function DeleteRegistrySubKey(ByVal Hive As PredefinedKeys, ByVal sKey As String) As Boolean
            '
            Dim MainKey As RegistryKey = ToRegisteryKey(Hive)
            Dim rkKey As RegistryKey
            Try
                'open the given subkey
                rkKey = MainKey.OpenSubKey(sKey, True)
                'check to make sure the subkey exists
                If Not sKey Is Nothing Then 'subkey exists
                    MainKey.DeleteSubKey(sKey, True)
                    Return True
                Else    'subkey doesnt exist
                    'throw an exception letting the user know
                    Throw New Exception("The SubKey provided doesn't exist. Please check your entry and try again.")
                    Return False
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: Deleting SubKey", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
            '
        End Function

#End Region

        Private Function ToRegisteryKey(ByVal input As PredefinedKeys) As RegistryKey
            '
            Dim tempResult As RegistryKey = Nothing

            Select Case input
                Case PredefinedKeys.HKEY_CURRENT_USER
                    tempResult = Microsoft.Win32.Registry.CurrentUser

                Case PredefinedKeys.HKEY_USERS
                    tempResult = Microsoft.Win32.Registry.Users

                Case PredefinedKeys.HKEY_CLASSES_ROOT
                    tempResult = Microsoft.Win32.Registry.ClassesRoot

                Case PredefinedKeys.HKEY_LOCAL_MACHINE
                    tempResult = Microsoft.Win32.Registry.LocalMachine

                Case PredefinedKeys.HKEY_CURRENT_CONFIG
                    tempResult = Microsoft.Win32.Registry.CurrentConfig
            End Select

            Return tempResult
            '
        End Function

    End Class

End Namespace