Imports System.IO

Public Class Utilities

    Public Shared hID As Integer

    Shared Function IsPersianDate(ByVal d As String) As Boolean
        '
        Dim bolResult As Boolean
        '
        Try
            Dim f As New FarsiLibrary.Utils.PersianDate(d)
            bolResult = True
        Catch ex As Exception
            bolResult = False
        End Try
        '
        Return bolResult
        ''
    End Function

    Public Shared Function Pic_2_ByteArray(ByVal img As Image) As Byte()
        '
        Using image As New Bitmap(img)
            Using stream As New MemoryStream()
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp)
                '
                Return stream.ToArray()
            End Using
        End Using
        ''
    End Function

    Public Shared Function ByteArray_2_Pic(ByVal ByteArray() As Byte) As Image
        '
        Dim bmp As Byte() = DirectCast(ByteArray, Byte())
        Using stream As New MemoryStream(bmp)
            Dim image As New Bitmap(stream)
            '
            Return image
        End Using
        ''
    End Function

End Class