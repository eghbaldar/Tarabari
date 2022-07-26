Imports System.Windows.Forms

Public Class AdvancedTextBox
    Inherits System.Windows.Forms.TextBox

    Enum enInputMode
        [Normal]
        [Alphabetic]
        [Number]
    End Enum

    Enum enLanguage
        [English]
        [Farsi]
    End Enum

    Private _InputMode As enInputMode
    Private _FocusColor As System.Drawing.Color
    Private _DefaultColor As System.Drawing.Color
    Private _NextControl As Control
    Private _PrevControl As Control
    Private _Language As enLanguage
    Private _BorderColor As Color

    'این ثابت ها برای رسم حاشیه دور جعبه متن بکار می روند
    Private Shared WM_NCPAINT As Integer = &H85
    Private Shared WM_ERASEBKGND As Integer = &H14
    Private Shared WM_PAINT As Integer = &HF

#Region "Properties"

    Public Property FocusColor() As System.Drawing.Color
        Get
            Return _FocusColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            _DefaultColor = MyBase.BackColor
            _FocusColor = value
        End Set
    End Property

    Public Property BorderColor() As System.Drawing.Color
        Get
            Return _BorderColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            _BorderColor = value
        End Set
    End Property

    Public Property NextControl() As Control
        Get
            Return _NextControl
        End Get
        Set(ByVal value As Control)
            _NextControl = value
        End Set
    End Property

    Public Property PrevControl() As Control
        Get
            Return _PrevControl
        End Get
        Set(ByVal value As Control)
            _PrevControl = value
        End Set
    End Property

    Public Property InputMode() As enInputMode
        Get
            Return _InputMode
        End Get
        Set(ByVal value As enInputMode)
            _InputMode = value
        End Set
    End Property

    Public Property Language() As enLanguage
        Get
            Return _Language
        End Get
        Set(ByVal value As enLanguage)
            '
            If Not DesignMode Then
                '_Language = 
                Dim StrLang As String = String.Empty
                If value = enLanguage.English Then
                    StrLang = "en-US"
                Else
                    StrLang = "fa-IR"
                End If
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(New Globalization.CultureInfo(StrLang))
            End If
            '
        End Set
    End Property

#End Region

#Region "Events"

    Protected Overrides Sub OnEnter(ByVal e As System.EventArgs)
        MyBase.BackColor = _FocusColor
        MyBase.OnEnter(e)
    End Sub

    Protected Overrides Sub OnLeave(ByVal e As System.EventArgs)
        MyBase.BackColor = _DefaultColor
        MyBase.OnLeave(e)
    End Sub

    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        '
        'اگر حالت چند خطی فعال بود روتین های زیر اجرا نمی شوند
        If MyBase.Multiline = True Then
            MyBase.OnKeyDown(e)
            Exit Sub
        End If
        'اگر حالت چند خطی فعال نبود روتین زیر اجرا می شوند
        Select Case e.KeyCode
            'down بررسی فشرده شدن کلید
            Case Keys.Down
                If Not (_NextControl Is Nothing) Then
                    _NextControl.Select()
                    _NextControl.Focus()
                Else
                    SendKeys.Send("{TAB}")
                End If
                'Up بررسی فشرده شدن کلید
            Case Keys.Up
                If Not (_PrevControl Is Nothing) Then
                    _PrevControl.Select()
                    _PrevControl.Focus()
                Else
                    SendKeys.Send("+{TAB}")
                End If
            Case Else
                MyBase.OnKeyDown(e)
        End Select
        '
    End Sub

    Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        '
        'اگر حالت چند خطی فعال بود روتین های زیر اجرا نمی شوند
        If MyBase.Multiline = True Then
            MyBase.OnKeyPress(e)
            Exit Sub
        End If
        'اگر حالت چند خطی فعال نبود روتین زیر اجرا می شوند
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            If Not (_NextControl Is Nothing) Then
                _NextControl.Select()
                _NextControl.Focus()
            Else
                SendKeys.Send("{TAB}")
            End If
        Else
            'در این قسمت نحوه ورود اعداد و الفبا چک می شود
            Call ProcessKeys(e)
        End If
        '
    End Sub

#End Region

#Region "Methods"
    ''' <summary>
    ''' این تابع چک می کند که اطلاعات ورودی به چه صورت وارد شوند
    ''' </summary>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ProcessKeys(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        '
        Select Case _InputMode
            'در این حالت تنها حروف الفبا می توانند وارد شوند
            Case enInputMode.Alphabetic
                If IsNumeric(e.KeyChar) Then
                    e.Handled = True
                    MyBase.OnKeyPress(e)
                End If
                'در این حالت تنها اعداد می توانند وارد شوند
            Case enInputMode.Number
                If Not (IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = Keys.Back) Then
                    e.Handled = True
                    MyBase.OnKeyPress(e)
                End If
                'در این حالت تمامی کارکترها می توانند وارد شوند
            Case Else
                MyBase.OnKeyPress(e)
        End Select
        '
    End Sub

    'سه تابع زیر برای رسم حاشیه دور جعبه متن بکار می روند
    <Runtime.InteropServices.DllImport("user32.dll")> _
    Shared Function GetDCEx(ByVal hwnd As IntPtr, ByVal hrgnclip As IntPtr, ByVal fdwOptions As UInt32) As IntPtr
    End Function

    <Runtime.InteropServices.DllImport("user32.dll")> _
    Shared Function ReleaseDC(ByVal hwnd As IntPtr, ByVal hDC As IntPtr) As Integer
    End Function

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)
        If m.Msg = WM_NCPAINT Or m.Msg = WM_ERASEBKGND Or m.Msg = WM_PAINT Then
            Dim hdc As IntPtr = GetDCEx(m.HWnd, CType(1, IntPtr), 1 Or &H20)
            If (hdc <> IntPtr.Zero) Then
                Dim graphics As Graphics = Drawing.Graphics.FromHdc(hdc)
                Dim rectangle As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)
                ControlPaint.DrawBorder(graphics, rectangle, _BorderColor, ButtonBorderStyle.Solid)
                m.Result = CType(1, IntPtr)
                ReleaseDC(m.HWnd, hdc)
            End If
        End If
    End Sub

#End Region

End Class
