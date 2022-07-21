Imports System.Data.SqlClient

Namespace CaspianTools

    Public Class SqlUtility

        Private _ConnectionString As String

#Region "Constructor"

        Public Sub New(ByVal ServerName As String)
            _ConnectionString = String.Format("Data Source={0:G};Initial Catalog=master;Integrated Security=SSPI;", ServerName)
        End Sub

        Public Sub New(ByVal ServerName As String, ByVal Database As String)
            _ConnectionString = String.Format("Data Source={0:G};Initial Catalog={1:G};Integrated Security=SSPI;", ServerName, Database)
        End Sub

        Public Sub New(ByVal ServerName As String, ByVal Username As String, ByVal Password As String)
            _ConnectionString = String.Format("Server={0:G};Database=master;User ID={1:G};Password={2:G};Trusted_Connection=False;", ServerName, Username, Password)
        End Sub

        Public Sub New(ByVal ServerName As String, ByVal Database As String, ByVal Username As String, ByVal Password As String)
            _ConnectionString = String.Format("Server={0:G};Database={1:G};User ID={2:G};Password={3:G};Trusted_Connection=False;", ServerName, Database, Username, Password)
        End Sub

#End Region

        Public Shared Function GetServerName() As List(Of String)
            '
            Dim ServerList As New List(Of String)

            Dim dt As DataTable = System.Data.Sql.SqlDataSourceEnumerator.Instance.GetDataSources()
            For Each row As DataRow In dt.Rows
                ServerList.Add(row(0).ToString)
            Next

            Return ServerList
            ''
        End Function

        Public Shared Function GetConnectionString(ByVal ServerName As String, ByVal Database As String) As String
            Return String.Format("Data Source={0:G};Initial Catalog={1:G};Integrated Security=SSPI;", ServerName, Database)
        End Function


        Public Sub Attach(ByVal DatabaseName As String, ByVal Filename1 As String, ByVal Filename2 As String)
            '
            Dim cmdText As String = String.Format("EXEC sp_attach_db @dbname = N'{0}', @filename1 = N'{1}', @filename2 = N'{2}'", DatabaseName, Filename1, Filename2)

            ExecuteNonQuery(cmdText)
            ''
        End Sub

        Public Sub CreateAttach(ByVal DatabaseName As String, ByVal Path As String)
            '
            Dim cmdText As String = String.Format("IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = N'{0}') " & _
                                                  "CREATE DATABASE {1} " & _
                                                  "ON PRIMARY (FILENAME = '{2}') FOR ATTACH", DatabaseName, DatabaseName, Path)

            ExecuteNonQuery(cmdText)
            ''
        End Sub

        Public Sub Detach(ByVal DatabaseName As String)
            '
            Dim cmdText As String = String.Format("EXEC sp_detach_db @dbname = '{0}' ,@skipchecks = 'true', @KeepFulltextIndexFile = 'true';", DatabaseName)

            ExecuteNonQuery(cmdText)
            ''
        End Sub

        Public Function ExistDB(ByVal DatabaseName As String) As Boolean
            '
            Dim cmdText As String = String.Format("SELECT DB_ID(N'{0}');", DatabaseName)

            Dim intResult As Integer = ExcuteScaler(cmdText)

            Return IIf(intResult = Nothing, 0, intResult)
            ''
        End Function

        Public Function DefaultPath() As String
            '
            Dim cmdText As String = "SELECT SUBSTRING(physical_name, 1, CHARINDEX(N'master.mdf', LOWER(physical_name)) - 1) FROM master.sys.master_files WHERE database_id = 1 AND file_id = 1;"
            Dim strResult As String = ExcuteScaler(cmdText).ToString
            Return strResult
            ''
        End Function

        Public Function DatabasePath(ByVal DatabaseName As String) As String
            '
            Dim cmdText As String = String.Format("SELECT physical_name FROM master.sys.master_files WHERE file_id = 1 and name='{0}'", DatabaseName)
            Dim strResult As String = ExcuteScaler(cmdText)
            Dim f As New IO.FileInfo(strResult)

            Return f.Directory.ToString & "\"
            ''
        End Function

        Public Sub DropDatabase(ByVal DatabaseName As String)
            '
            Dim cmdText As String = String.Format("IF DB_ID (N'{0}') IS NOT NULL DROP DATABASE {1};", DatabaseName, DatabaseName)

            ExecuteNonQuery(cmdText)
            ''
        End Sub

        Public Sub Backup(ByVal DatabaseName As String, ByVal BackupPath As String)
            '
            Dim cmdText As String = String.Format("BACKUP DATABASE {0} TO  DISK = N'{1}' WITH NOFORMAT, NOINIT, NAME = N'{2}-Full Database Backup', SKIP", DatabaseName, BackupPath, DatabaseName)

            ExecuteNonQuery(cmdText)
            ''
        End Sub

        Public Sub Restore(ByVal DatabaseName As String, ByVal BackupPath As String)
            '
            Dim cmdText As String = String.Format("RESTORE DATABASE {0} FROM  DISK = N'{1}' WITH FILE = 1, NOUNLOAD, REPLACE", DatabaseName, BackupPath)

            ExecuteNonQuery(cmdText)
            ''
        End Sub

        Private Function ExcuteScaler(ByVal cmdText As String) As Object
            '
            Dim objResult As Object
            Try
                Using sqlConn As New SqlConnection(_ConnectionString)
                    Using sqlCmd As New SqlCommand(cmdText, sqlConn)
                        sqlConn.Open()
                        objResult = sqlCmd.ExecuteScalar()
                        sqlConn.Close()
                    End Using
                End Using
                Return IIf(objResult Is DBNull.Value, Nothing, objResult)
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
                'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Return Nothing
            End Try
            ''
        End Function

        Private Function ExecuteNonQuery(ByVal cmdText As String) As Integer
            '
            Dim intResult As Object
            Try
                Using sqlConn As New SqlConnection(_ConnectionString)
                    Using sqlCmd As New SqlCommand(cmdText, sqlConn)
                        sqlConn.Open()
                        intResult = sqlCmd.ExecuteNonQuery()
                        sqlConn.Close()
                    End Using
                End Using
                Return intResult
            Catch ex As Exception
                CaspianTools.Logger.WriteError(ex)
                'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Return -1
            End Try
            ''
        End Function

    End Class

End Namespace

'Namespace CaspianTools

'    Public Class SqlUtility

'        Private _ConnectionString As String

'#Region "Constructor"

'        Public Sub New(ByVal ServerName As String)
'            _ConnectionString = String.Format("Data Source={0:G};Initial Catalog=master;Integrated Security=SSPI;", ServerName)
'        End Sub

'        Public Sub New(ByVal ServerName As String, ByVal Database As String)
'            _ConnectionString = String.Format("Data Source={0:G};Initial Catalog={1:G};Integrated Security=SSPI;", ServerName, Database)
'        End Sub

'        Public Sub New(ByVal ServerName As String, ByVal Username As String, ByVal Password As String)
'            _ConnectionString = String.Format("Server={0:G};Database=master;User ID={1:G};Password={2:G};Trusted_Connection=False;", ServerName, Username, Password)
'        End Sub

'        Public Sub New(ByVal ServerName As String, ByVal Database As String, ByVal Username As String, ByVal Password As String)
'            _ConnectionString = String.Format("Server={0:G};Database={1:G};User ID={2:G};Password={3:G};Trusted_Connection=False;", ServerName, Database, Username, Password)
'        End Sub

'#End Region

'        Public Sub Attach(ByVal DatabaseName As String, ByVal Filename1 As String, ByVal Filename2 As String)
'            '
'            Dim cmdText As String = String.Format("EXEC sp_attach_db @dbname = N'{0}', @filename1 = N'{1}', @filename2 = N'{2}'", DatabaseName, Filename1, Filename2)

'            Try
'                Using sqlConn As New SqlConnection(_ConnectionString)
'                    Using sqlCmd As New SqlCommand(cmdText, sqlConn)
'                        sqlConn.Open()
'                        sqlCmd.ExecuteNonQuery()
'                        sqlConn.Close()
'                    End Using
'                End Using
'            Catch ex As Exception
'                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
'            End Try
'            '
'        End Sub

'        Public Sub CreateAttach(ByVal DatabaseName As String, ByVal Path As String)
'            '
'            Dim cmdText As String = String.Format("IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = N'{0}') " & _
'                                                  "CREATE DATABASE {1} " & _
'                                                  "ON PRIMARY (FILENAME = '{2}') FOR ATTACH", DatabaseName, DatabaseName, Path)

'            Try
'                Using sqlConn As New SqlConnection(_ConnectionString)
'                    Using sqlCmd As New SqlCommand(cmdText, sqlConn)
'                        sqlConn.Open()
'                        sqlCmd.ExecuteNonQuery()
'                        sqlConn.Close()
'                    End Using
'                End Using
'            Catch ex As Exception
'                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
'            End Try
'            '
'        End Sub

'        Public Sub Detach(ByVal DatabaseName As String)
'            '
'            Dim cmdText As String = String.Format("EXEC sp_detach_db @dbname = '{0}' ,@skipchecks = 'true', @KeepFulltextIndexFile = 'true';", DatabaseName)

'            Try
'                Using sqlConn As New SqlConnection(_ConnectionString)
'                    Using sqlCmd As New SqlCommand(cmdText, sqlConn)
'                        sqlConn.Open()
'                        sqlCmd.ExecuteNonQuery()
'                        sqlConn.Close()
'                    End Using
'                End Using
'            Catch ex As Exception
'                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
'            End Try
'            '
'        End Sub

'        Public Function DefaultPath() As String
'            '
'            Dim cmdText As String = "SELECT SUBSTRING(physical_name, 1, CHARINDEX(N'master.mdf', LOWER(physical_name)) - 1) FROM master.sys.master_files WHERE database_id = 1 AND file_id = 1;"
'            Dim strResult As String = String.Empty

'            Try
'                Using sqlConn As New SqlConnection(_ConnectionString)
'                    Using sqlCmd As New SqlCommand(cmdText, sqlConn)
'                        sqlConn.Open()
'                        strResult = sqlCmd.ExecuteScalar()
'                        sqlConn.Close()
'                    End Using
'                End Using
'                Return strResult
'            Catch ex As Exception
'                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
'                Return strResult
'            End Try
'            '
'        End Function

'        Public Function DatabasePath(ByVal DatabaseName As String) As String
'            '
'            Dim cmdText As String = String.Format("SELECT physical_name FROM master.sys.master_files WHERE file_id = 1 and name='{0}'", DatabaseName)
'            Dim strResult As String = String.Empty

'            Try
'                Using sqlConn As New SqlConnection(_ConnectionString)
'                    Using sqlCmd As New SqlCommand(cmdText, sqlConn)
'                        sqlConn.Open()
'                        strResult = sqlCmd.ExecuteScalar()
'                        sqlConn.Close()
'                    End Using
'                End Using
'                Dim f As New IO.FileInfo(strResult)
'                Return f.Directory.ToString & "\"
'            Catch ex As Exception
'                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
'                Return strResult
'            End Try
'            '
'        End Function

'        Public Sub DropDatabase(ByVal DatabaseName As String)
'            '
'            Dim cmdText As String = String.Format("IF DB_ID (N'{0}') IS NOT NULL DROP DATABASE {1};", DatabaseName, DatabaseName)

'            Try
'                Using sqlConn As New SqlConnection(_ConnectionString)
'                    Using sqlCmd As New SqlCommand(cmdText, sqlConn)
'                        sqlConn.Open()
'                        sqlCmd.ExecuteNonQuery()
'                        sqlConn.Close()
'                    End Using
'                End Using
'            Catch ex As Exception
'                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
'            End Try
'            ''
'        End Sub

'        Public Sub Backup(ByVal DatabaseName As String, ByVal BackupPath As String)
'            '
'            Dim cmdText As String = String.Format("BACKUP DATABASE {0} TO  DISK = N'{1}' WITH NOFORMAT, NOINIT, NAME = N'{2}-Full Database Backup', SKIP", DatabaseName, BackupPath, DatabaseName)
'            Try
'                Using sqlConn As New SqlConnection(_ConnectionString)
'                    Using sqlCmd As New SqlCommand(cmdText, sqlConn)
'                        sqlConn.Open()
'                        sqlCmd.ExecuteNonQuery()
'                        sqlConn.Close()
'                    End Using
'                End Using
'            Catch ex As Exception
'                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
'            End Try
'            ''
'        End Sub

'        Public Sub Restore(ByVal DatabaseName As String, ByVal BackupPath As String)
'            '
'            Dim cmdText As String = String.Format("RESTORE DATABASE {0} FROM  DISK = N'{1}' WITH FILE = 1, NOUNLOAD, REPLACE", DatabaseName, BackupPath)
'            Try
'                Using sqlConn As New SqlConnection(_ConnectionString)
'                    Using sqlCmd As New SqlCommand(cmdText, sqlConn)
'                        sqlConn.Open()
'                        sqlCmd.ExecuteNonQuery()
'                        sqlConn.Close()
'                    End Using
'                End Using
'            Catch ex As Exception
'                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
'            End Try
'            ''
'        End Sub

'        Private Function ExcuteScaler(ByVal cmdText As String) As Object
'            '
'            Dim objResult As Object
'            Try
'                Using sqlConn As New SqlConnection(_ConnectionString)
'                    Using sqlCmd As New SqlCommand(cmdText, sqlConn)
'                        sqlConn.Open()
'                        objResult = sqlCmd.ExecuteScalar()
'                        sqlConn.Close()
'                    End Using
'                End Using
'                Return objResult
'            Catch ex As Exception
'                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
'                Return Nothing
'            End Try
'            '
'        End Function

'        Private Function ExecuteNonQuery(ByVal cmdText As String) As Integer
'            '
'            Dim intResult As Object
'            Try
'                Using sqlConn As New SqlConnection(_ConnectionString)
'                    Using sqlCmd As New SqlCommand(cmdText, sqlConn)
'                        sqlConn.Open()
'                        intResult = sqlCmd.ExecuteNonQuery()
'                        sqlConn.Close()
'                    End Using
'                End Using
'                Return intResult
'            Catch ex As Exception
'                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
'                Return -1
'            End Try
'            ''
'        End Function

'    End Class

'End Namespace