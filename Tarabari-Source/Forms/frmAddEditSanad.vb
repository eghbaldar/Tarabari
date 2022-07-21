Public Class frmAddEditSanad

    Dim MySetting As BLL.Setting.ApplicationSetting
    Dim SettingBLL As New BLL.Setting
    '
    Dim MabdaIdList As New ArrayList
    Dim MaghsadIdList As New ArrayList
    Dim RowHeaderTitle() As String = {"شماره بارنامه", "تاریخ بارنامه", "مبداء", "مقصد", "نوع بار", "مبنای محاسبه کمیسیون", _
                                      "کل کرایه مندرج در بارنامه", "پایه کرایه مندرج در بارنامه", "دریافت نقدی کرایه", _
 _
                                      "حق پایانه", "کمیسون طبق بارنامه", "بیمه باربری", "جمع", _
 _
                                      "مابه التفاوت کمیسیون", "بیمه عمر رانندگان", "بارگیری و تخلیه", "جریمه پلیس راه", _
                                      "نوبت", "عوارض اتوبان", "سهم راننده", "کمک هزینه غذا (رفت)", "کمک هزینه غذا (برگشت)", "جمع", _
 _
                                      "مقدار سوخت به لیتر", "مبلغ سوخت تایید شده", "جمع", _
 _
                                      "جمع کل"}
    '
    Dim EzamInfoBLL As New BLL.vSelectNavgan
    Dim SanabdBLL As New BLL.Sanad
    Dim MabdaBLL As New BLL.Mabda
    Dim MaghsadBLL As New BLL.Maghsad
    Dim CellEdit(26, 3) As Boolean
    Dim editMode As Boolean = False

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Using f As New frmSelectNavgan()
            If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtOperationCode.Text = f.OperationCode
            End If
        End Using
    End Sub

    Private Sub frmAddEditSanad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub InitArray()
        '
        For i As Integer = CellEdit.GetLowerBound(0) To CellEdit.GetUpperBound(0)
            For j As Integer = 0 To 3
                CellEdit(i, j) = True
            Next
        Next
        ''
    End Sub

    Private Sub frmAddEditSanad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '
        InitArray()

        If editMode = False Then
            Call CustomizeDataGridView()
            ' لود تنظیمات
            MySetting = SettingBLL.ReadSetting()
        End If
        ''
    End Sub

    Private Sub CustomizeDataGridView()
        '
        dgvSanad.Rows.Clear()
        ' نوشتن عنوان های هر سطر
        For i As Byte = 0 To 26
            If i >= 5 Then
                dgvSanad.Rows.Add(0, 0, 0, 0)
            Else
                dgvSanad.Rows.Add()
            End If
            dgvSanad.Rows(i).HeaderCell.Value = RowHeaderTitle(i)
        Next
        '
        ' رنگ آمیزی سطرها به رنگ های مختلف
        For i = 0 To 8
            dgvSanad.Rows(i).DefaultCellStyle.BackColor = Color.Beige
        Next
        For i = 9 To 11
            dgvSanad.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
        Next
        dgvSanad.Rows(12).DefaultCellStyle.BackColor = Color.LightGray
        For i = 13 To 21
            dgvSanad.Rows(i).DefaultCellStyle.BackColor = Color.LightCyan
        Next
        dgvSanad.Rows(22).DefaultCellStyle.BackColor = Color.LightGray
        For i = 23 To 24
            dgvSanad.Rows(i).DefaultCellStyle.BackColor = Color.LightSteelBlue
        Next
        dgvSanad.Rows(25).DefaultCellStyle.BackColor = Color.LightGray
        dgvSanad.Rows(26).DefaultCellStyle.BackColor = Color.LightSeaGreen
        '
        ' غیر فعال کردن سطرها

        ' تاریخ بارنامه
        dgvSanad.Rows(1).ReadOnly = True
        ' مبدا
        dgvSanad.Rows(2).ReadOnly = True
        ' مقصد
        dgvSanad.Rows(3).ReadOnly = True
        ' حق پایانه
        'dgvSanad.Rows(9).ReadOnly = True
        ' کمیسیون طبق بارنامه
        'dgvSanad.Rows(10).ReadOnly = True
        ' جمع اول
        dgvSanad.Rows(12).ReadOnly = True
        ' سهم راننده
        'dgvSanad.Rows(19).ReadOnly = True
        ' هزینه غذا رفت
        'dgvSanad.Rows(20).ReadOnly = True
        ' هزینه غذا برگشت
        'dgvSanad.Rows(21).ReadOnly = True
        ' جمع دوم
        dgvSanad.Rows(22).ReadOnly = True
        ' مبلغ سوخت تایید شده
        dgvSanad.Rows(24).ReadOnly = True
        ' جمع سوم
        dgvSanad.Rows(25).ReadOnly = True
        ' جمع کل
        dgvSanad.Rows(26).ReadOnly = True
        '=================
        dgvSanad(4, 0).ReadOnly = True
        dgvSanad(4, 1).ReadOnly = True
        dgvSanad(4, 2).ReadOnly = True
        dgvSanad(4, 3).ReadOnly = True
        dgvSanad(4, 4).ReadOnly = True
        '=================
        For i As Integer = 0 To 26
            dgvSanad.Rows(i).Cells(4).ToolTipText = RowHeaderTitle(i)
        Next
        ''
    End Sub

    Private Sub dgvSanad_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSanad.CellEndEdit
        Call CalculateTotal(e.RowIndex, e.ColumnIndex)
    End Sub

    Private Sub CalculateTotal(ByVal row As Integer, ByVal col As Integer)
        '
        ' شماره سطر ردیف مبنای محاسبه کمیسیون
        If row = 5 Then
            '
            ' سهم راننده = مبنای محاسبه کمیسیون * .10
            If CellEdit(19, col) Then
                dgvSanad.Rows(19).Cells(col).Value = Convert.ToInt32(dgvSanad.Rows(5).Cells(col).Value * MySetting.SahmRanande)
                CellEdit(19, col) = False
            End If

            ' کمک هزینه غذا رفت = مبنای محاسبه کمیسیون * .6
            If col = 0 Then
                If CellEdit(20, 0) Then
                    dgvSanad.Rows(20).Cells(col).Value = Convert.ToInt32(dgvSanad.Rows(5).Cells(col).Value * MySetting.HazineGhaza_Raft)
                    CellEdit(20, col) = False
                End If
            End If

            ' کمک هزینه غذا برگشت = مبنای محاسبه کمیسیون * .3
            If col <> 0 Then
                If CellEdit(21, col) Then
                    dgvSanad.Rows(21).Cells(col).Value = Convert.ToInt32(dgvSanad.Rows(5).Cells(col).Value * MySetting.HazineGhaza_Bargasht)
                    CellEdit(21, col) = False
                End If
            End If
            '
        End If

        '======================================
        ' شماره سطر ردیف کل کرایه مندرج در بارنامه
        If row = 6 Then
            '
            ' محاسبه حق پایانه = کل کرایه مندرج در بارنامه * .7
            dgvSanad.Rows(9).Cells(col).Value = Convert.ToInt32(dgvSanad.Rows(6).Cells(col).Value * MySetting.HaghPayane)
            CellEdit(9, col) = False

            ' محاسبه کمیسیون طبق بارنامه = کل کرایه مندرج در بارنامه * .7
            dgvSanad.Rows(10).Cells(col).Value = Convert.ToInt32(dgvSanad.Rows(6).Cells(col).Value * MySetting.KomisionBarname)
            CellEdit(10, col) = False
            '
        End If

        '======================================
        ' جمع اول = حق پایانه + کمیسیون طبق بارنامه + بیمه باربری
        'If row = 6 Or row = 11 Then
        For i As Integer = 0 To 3
            dgvSanad.Rows(12).Cells(i).Value = CInt(dgvSanad.Rows(9).Cells(i).Value) + _
                                               CInt(dgvSanad.Rows(10).Cells(i).Value) + _
                                               CInt(dgvSanad.Rows(11).Cells(i).Value)
        Next i

        '======================================
        ' محاسبه جمع دومی
        'If rowID = 5 Or rowID = 13 Or rowID = 14 Or rowID = 15 Or rowID = 16 Or rowID = 17 Or rowID = 18 Then
        For i As Integer = 0 To 3
            dgvSanad.Rows(22).Cells(i).Value = CInt(dgvSanad.Rows(13).Cells(i).Value) + _
                                               CInt(dgvSanad.Rows(14).Cells(i).Value) + _
                                               CInt(dgvSanad.Rows(15).Cells(i).Value) + _
                                               CInt(dgvSanad.Rows(16).Cells(i).Value) + _
                                               CInt(dgvSanad.Rows(17).Cells(i).Value) + _
                                               CInt(dgvSanad.Rows(18).Cells(i).Value) + _
                                               CInt(dgvSanad.Rows(19).Cells(i).Value) + _
                                               CInt(dgvSanad.Rows(20).Cells(i).Value) + _
                                               CInt(dgvSanad.Rows(21).Cells(i).Value)

        Next
        'End If
        '======================================
        ' ملغ سوخت تایید شده
        'If rowID = 23 Then   ' شماره سطر ردیف مقدار سوخت به لیتر
        For i As Integer = 0 To 3
            ' ملغ سوخت تایید شده
            dgvSanad.Rows(24).Cells(i).Value = dgvSanad.Rows(23).Cells(i).Value * MySetting.MablaghSookht
        Next
        'End If
        '======================================
        ' محاسبه جمع سومی
        For i As Integer = 0 To 3
            dgvSanad.Rows(25).Cells(i).Value = dgvSanad.Rows(22).Cells(i).Value + dgvSanad.Rows(24).Cells(i).Value
        Next
        '======================================

        ' محاسبه جمع کل
        For i As Integer = 0 To 3
            dgvSanad.Rows(26).Cells(i).Value = dgvSanad.Rows(12).Cells(i).Value + dgvSanad.Rows(25).Cells(i).Value
        Next

        '======================================
        ' محاسبه سطری
        For i As Integer = 5 To 26
            Dim intRowTotal As Long = 0
            For j As Integer = 0 To 3
                intRowTotal += dgvSanad.Rows(i).Cells(j).Value
            Next
            dgvSanad.Rows(i).Cells(4).Value = intRowTotal
        Next
        '======================================
        ''
    End Sub

    Private Sub dgvSanad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvSanad.KeyDown
        '
        If e.KeyCode = Keys.Add Or e.KeyCode = Keys.Oemplus Then
            '
            Dim row As Integer = dgvSanad.CurrentRow.Index
            Dim col As Integer = dgvSanad.CurrentCell.ColumnIndex

            If col > 3 Then Exit Sub

            Dim choose As frmUserInput.UserInputType

            Select Case row
                Case 1
                    choose = frmUserInput.UserInputType.Tarikh
                Case 2
                    choose = frmUserInput.UserInputType.Mabda
                Case 3
                    choose = frmUserInput.UserInputType.Maghsad
            End Select
            '
            Using f As New frmUserInput(choose, dgvSanad.CurrentCell.Value)
                '
                If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    '
                    Select Case row
                        Case 1
                            dgvSanad(col, row).Value = f.Tarikh
                        Case 2
                            dgvSanad(col, row).Value = f.MabdaName
                            MabdaIdList.Insert(col, f.MabdaID)
                        Case 3
                            dgvSanad(col, row).Value = f.MaghsadName
                            MaghsadIdList.Insert(col, f.MaghsadID)
                    End Select
                    '
                End If
                '
            End Using
            '
        End If
        ''
    End Sub

    Private Sub ShowData(ByVal OperationCode As String)
        '
        '
        Dim dr As DataRow = EzamInfoBLL.SelectByOperationCode(OperationCode)
        Dim dtSanad As DataTable = SanabdBLL.SelectSanadDetailRows(OperationCode)
        Dim colIndex As Integer = 0
        '
        '==============
        If dtSanad.Rows.Count > 0 Then
            '
            dgvSanad.Enabled = True
            CustomizeDataGridView()
            MySetting = SettingBLL.ReadSetting()
            '=======
            lblRanande.Text = dr("RanandeFullName")
            lblMashinID.Text = dr("MashinID")
            lblPelak.Text = dr("Pelak")
            lblTarikh.Text = dr("TarikhKhoroojMojtame")
            '
            For Each Sanadrow As DataRow In dtSanad.Rows
                '
                MySetting.SahmRanande = Sanadrow("Darsad_SahmRanande")
                MySetting.HazineGhaza_Raft = Sanadrow("Darsad_HazineGhaza_Raft")
                MySetting.HazineGhaza_Bargasht = Sanadrow("Darsad_HazineGhaza_Bargasht")
                MySetting.MablaghSookht = Sanadrow("MablaghSookht")
                MySetting.HaghPayane = Sanadrow("Darsad_HaghPayane")
                MySetting.KomisionBarname = Sanadrow("Darsad_KomisionBarname")
                '
                dgvSanad(colIndex, 0).Value = Sanadrow("ShomareBarname")
                dgvSanad(colIndex, 1).Value = Sanadrow("TarikhBarname")
                dgvSanad(colIndex, 2).Value = MabdaBLL.GetNameByID(CInt(Sanadrow("MabdaID"))) : MabdaIdList.Insert(0, CInt(dr("MabdaID")))
                dgvSanad(colIndex, 3).Value = MaghsadBLL.GetNameByID(CInt(Sanadrow("MaghsadID"))) : MaghsadIdList.Insert(0, CInt(dr("MaghsadID")))
                dgvSanad(colIndex, 4).Value = Sanadrow("NoeBar")
                dgvSanad(colIndex, 5).Value = Sanadrow("MabnaKomision")
                dgvSanad(colIndex, 6).Value = Sanadrow("KolKerayeBarname")
                dgvSanad(colIndex, 7).Value = Sanadrow("PayeKerayeBarname")
                dgvSanad(colIndex, 8).Value = Sanadrow("DaryaftNaghdi")
                dgvSanad(colIndex, 9).Value = Sanadrow("HaghPayane")
                dgvSanad(colIndex, 10).Value = Sanadrow("KomisionBarname")
                dgvSanad(colIndex, 11).Value = Sanadrow("BimeBarbari")
                'dgvSanad(colIndex, 12).Value = Sanadrow("OperationCode")
                dgvSanad(colIndex, 13).Value = Sanadrow("TafavotKomision")
                dgvSanad(colIndex, 14).Value = Sanadrow("BimeOmr")
                dgvSanad(colIndex, 15).Value = Sanadrow("Bargiri_Takhliye")
                dgvSanad(colIndex, 16).Value = Sanadrow("JarimePolice")
                dgvSanad(colIndex, 17).Value = Sanadrow("Nobat")
                dgvSanad(colIndex, 18).Value = Sanadrow("AvarezOtooban")
                dgvSanad(colIndex, 19).Value = Sanadrow("SahmRanande")
                dgvSanad(colIndex, 20).Value = Sanadrow("HazineGhaza_Raft")
                dgvSanad(colIndex, 21).Value = Sanadrow("HazineGhaza_Bargasht")
                'dgvSanad(colIndex, 22).Value = Sanadrow("OperationCode")
                dgvSanad(colIndex, 23).Value = Sanadrow("MeghdarSookht")
                'dgvSanad(colIndex, 24).Value = Sanadrow("OperationCode")
                'dgvSanad(colIndex, 25).Value = Sanadrow("OperationCode")
                'dgvSanad(colIndex, 26).Value = Sanadrow("OperationCode")
                '
                colIndex += 1
                '
            Next
            '
            Call CalculateTotal(0, 0)
            '
        ElseIf dr IsNot Nothing AndAlso CBool(dr("DarMamooriyat")) = False Then
            '
            dgvSanad.Enabled = True
            CustomizeDataGridView()
            MySetting = SettingBLL.ReadSetting()
            '=======
            lblRanande.Text = dr("RanandeFullName")
            lblMashinID.Text = dr("MashinID")
            lblPelak.Text = dr("Pelak")
            lblTarikh.Text = dr("TarikhKhoroojMojtame")
            '=======
            dgvSanad(0, 0).Value = dr("ShomareBarnameRaft")
            dgvSanad(0, 1).Value = dr("TarikhBarnameRaft")
            dgvSanad(0, 2).Value = dr("NameMabda") : MabdaIdList.Insert(0, CInt(dr("MabdaID")))
            dgvSanad(0, 3).Value = dr("NameMaghsad") : MaghsadIdList.Insert(0, CInt(dr("MaghsadID")))
            dgvSanad(0, 4).Value = dr("NoeBar")
            dgvSanad(0, 23).Value = dr("SookhtMasrafShode")
            '
        ElseIf dr IsNot Nothing AndAlso CBool(dr("DarMamooriyat")) = True Then
            lblRanande.Text = String.Empty
            lblMashinID.Text = String.Empty
            lblPelak.Text = String.Empty
            lblTarikh.Text = String.Empty
            '===========
            CustomizeDataGridView()
            dgvSanad.Enabled = False
            MessageBox.Show("این خوردو از ماموریت برنگشته است.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading)
        Else
            '
            lblRanande.Text = String.Empty
            lblMashinID.Text = String.Empty
            lblPelak.Text = String.Empty
            lblTarikh.Text = String.Empty
            '===========
            CustomizeDataGridView()
            dgvSanad.Enabled = False
            MessageBox.Show("ماموریتی با این کد وجود ندارد.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading)
            '
        End If
        '==============
        ''
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        '
        If txtOperationCode.Text.Trim = String.Empty Then Exit Sub
        '
        Dim OperationCode As String = txtOperationCode.Text.Trim
        ShowData(OperationCode)
        ''
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        '
        If Not ValidateForm() Then Exit Sub
        '
        ' insert to db
        '
        SanabdBLL.DeleteSanad(txtOperationCode.Text.Trim)
        '
        For i As Integer = 0 To 3
            '
            If dgvSanad(i, 0).Value IsNot Nothing Then
                '
                SanabdBLL.Insert(txtOperationCode.Text.Trim, _
                    i + 1, _
                    dgvSanad(i, 0).Value, _
                    dgvSanad(i, 1).Value, _
                    MabdaIdList.Item(i), _
                    MaghsadIdList.Item(i), _
                    dgvSanad(i, 4).Value, _
                    dgvSanad(i, 5).Value, _
                    dgvSanad(i, 6).Value, _
                    dgvSanad(i, 7).Value, _
                    dgvSanad(i, 8).Value, _
                    dgvSanad(i, 9).Value, _
                    dgvSanad(i, 10).Value, _
                    dgvSanad(i, 11).Value, _
                    dgvSanad(i, 13).Value, _
                    dgvSanad(i, 14).Value, _
                    dgvSanad(i, 15).Value, _
                    dgvSanad(i, 16).Value, _
                    dgvSanad(i, 17).Value, _
                    dgvSanad(i, 18).Value, _
                    dgvSanad(i, 19).Value, _
                    dgvSanad(i, 20).Value, _
                    dgvSanad(i, 21).Value, _
                    dgvSanad(i, 23).Value, _
                    dgvSanad(i, 26).Value, _
                    MySetting.SahmRanande, _
                    MySetting.HazineGhaza_Raft, _
                    MySetting.HazineGhaza_Bargasht, _
                    MySetting.MablaghSookht, _
                    MySetting.HaghPayane, _
                    MySetting.KomisionBarname)
                '
            End If
            '
        Next
        '
        CustomizeDataGridView()
        dgvSanad.Enabled = False
        InitArray()
        ''
    End Sub

    Private Function ValidateForm() As Boolean
        '
        Dim bolResult As Boolean = True
        '
        '
        Return bolResult
        ''
    End Function

#Region "Validating DatagridView cells"

    'Private Sub dgvFactorList_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgvFactorList.CellValidating

    '    If e.ColumnIndex = 4 Or _
    '       e.ColumnIndex = 5 Or _
    '       e.ColumnIndex = 6 Then

    '        dgvFactorList.Rows(e.RowIndex).ErrorText = ""

    '        ' Don't try to validate the 'new row' until finished 
    '        ' editing since there
    '        ' is not any point in validating its initial value.
    '        If e.FormattedValue.ToString().Trim() = String.Empty Then
    '            e.Cancel = True
    '            dgvFactorList.Rows(e.RowIndex).ErrorText = "مقدار مورد نظر را وارد کنید"
    '        End If
    '    End If

    'End Sub

    Private Sub dgvSanad_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvSanad.EditingControlShowing
        '
        If (dgvSanad.CurrentRow.Index > 4) Or (dgvSanad.CurrentRow.Index = 0) Then
            '
            Dim tb As TextBox = CType(e.Control, TextBox)
            AddHandler tb.KeyPress, AddressOf NumericTextBox_KeyPress
            '
        Else
            '
            Dim tb As TextBox = CType(e.Control, TextBox)
            AddHandler tb.KeyPress, AddressOf AlphabeticTextBox_KeyPress
            '
        End If
        ''
    End Sub

    Private Sub NumericTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            If Asc(e.KeyChar) = 46 Then
                If CType(sender, TextBox).Text.Contains(Chr(46)) Then
                    e.Handled = True
                Else
                    e.Handled = False
                End If
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub AlphabeticTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = False
    End Sub

#End Region

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal OperationCode As Integer)
        '
        InitializeComponent()
        '
        txtOperationCode.Text = OperationCode
        ShowData(OperationCode)
        editMode = True
        ''
    End Sub

End Class