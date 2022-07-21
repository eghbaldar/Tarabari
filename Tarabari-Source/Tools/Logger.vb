
Namespace CaspianTools

    Public Class Logger

        Public Shared Sub WriteError(ByVal ex As Exception)
            '
            Dim pDate As String = FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(Date.Now).ToString("yyyy/mm/dd")
            Dim time As String = Date.Now.ToShortTimeString()
            Dim ErrorDate As String = String.Format("{0} {1}", pDate, time)
            'Dim errorMessage As String = ErroDate + vbCrLf + "InnerException : " + ex.InnerException.Message + vbCrLf + ex.StackTrace
            'Dim errorMessage As String = String.Format("{0}{1}InnerException : {2}{1}{3}{1}", _
            '                                           ErrorDate, _
            '                                           vbCrLf, _
            '                                           IIf(ex.InnerException Is Nothing, "", ex.InnerException.Message), _
            '                                           ex.StackTrace)

            Dim errorMessage As String = ErrorDate + vbCrLf + ex.ToString + vbCrLf

            Dim logger As New Logging.Log
            logger.DefaultFileLogWriter.Location = Logging.LogFileLocation.ExecutableDirectory
            logger.WriteException(ex)
            logger.DefaultFileLogWriter.WriteLine(errorMessage)
            '
        End Sub

    End Class

End Namespace