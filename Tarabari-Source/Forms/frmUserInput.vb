Public Class frmUserInput

    Enum UserInputType
        Maghsad
        Mabda
        Tarikh
    End Enum

    ReadOnly Property MabdaID() As Integer
        Get
            Return cmbMabda.SelectedValue
        End Get
    End Property

    ReadOnly Property MabdaName() As String
        Get
            Return cmbMabda.GetItemText(cmbMabda.SelectedItem)
        End Get
    End Property

    ReadOnly Property MaghsadID() As Integer
        Get
            Return cmbMaghsad.SelectedValue
        End Get
    End Property

    ReadOnly Property MaghsadName() As String
        Get
            Return cmbMaghsad.GetItemText(cmbMaghsad.SelectedItem)
        End Get
    End Property

    ReadOnly Property Tarikh() As String
        Get
            Return txtDate.Text
        End Get
    End Property


    Public Sub New(ByVal FormMode As UserInputType, ByVal CellValue As String)
        '
        InitializeComponent()
        '
        Select Case FormMode

            Case UserInputType.Maghsad
                Me.Tbl_MaghsadTableAdapter.Fill(Me.DsTarabari.tbl_Maghsad)
                pnlMaghsad.Visible = True
                pnlMaghsad.Dock = DockStyle.Fill

            Case UserInputType.Mabda
                Me.Tbl_MabdaTableAdapter.Fill(Me.DsTarabari.tbl_Mabda)
                pnlMabda.Visible = True
                pnlMabda.Dock = DockStyle.Fill

            Case UserInputType.Tarikh
                pnlTarikh.Visible = True
                pnlTarikh.Dock = DockStyle.Fill
                txtDate.Text = CellValue

        End Select

    End Sub

    Private Sub frmUserInput_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub btnOkTarikh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOkTarikh.Click
        If Utilities.IsPersianDate(txtDate.Text) = False Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub btnChangeMaghsad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeMaghsad.Click
        If cmbMaghsad.Visible Then
            cmbMaghsad.Visible = False
            txtMaghsad.Visible = True
        Else
            cmbMaghsad.Visible = True
            txtMaghsad.Visible = False
        End If
    End Sub

    Private Sub btnChangeMabda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeMabda.Click
        If cmbMabda.Visible Then
            cmbMabda.Visible = False
            txtMabda.Visible = True
        Else
            cmbMabda.Visible = True
            txtMabda.Visible = False
        End If
    End Sub

    Private Sub txtMabda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMabda.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim strNewMabda As String = txtMabda.Text.Trim()
            If Not cmbMabda.Items.Contains(strNewMabda) Then
                Dim MabdaBLL As New BLL.Mabda
                MabdaBLL.Insert(strNewMabda)
                Me.Tbl_MabdaTableAdapter.Fill(Me.DsTarabari.tbl_Mabda)
                cmbMabda.Visible = True
                txtMabda.Visible = False
            End If
        End If
    End Sub

    Private Sub txtMaghsad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMaghsad.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim strNewMaghsad As String = txtMaghsad.Text.Trim()
            If Not cmbMaghsad.Items.Contains(strNewMaghsad) Then
                Dim MaghsadBLL As New BLL.Maghsad
                MaghsadBLL.Insert(strNewMaghsad)
                Me.Tbl_MaghsadTableAdapter.Fill(Me.DsTarabari.tbl_Maghsad)
                cmbMaghsad.Visible = True
                txtMaghsad.Visible = False
            End If
        End If
    End Sub

End Class