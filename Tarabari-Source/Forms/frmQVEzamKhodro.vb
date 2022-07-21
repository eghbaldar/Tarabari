Public Class frmQVEzamKhodro

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal OperationCode As String)
        '
        InitializeComponent()
        '
        Call ShowData(OperationCode)
        '
    End Sub

    Private Sub ShowData(ByVal OperationCode As String)
        '
        Dim EzamInfo As New BLL.vSelectNavgan

        Dim dr As DataRow = EzamInfo.SelectByOperationCode(OperationCode)

        lblOperationCode.Text = dr("OperationCode").ToString()
        '==============
        lblRanande.Text = dr("RanandeFullName").ToString()
        lblMashinID.Text = dr("MashinID").ToString()
        lblPelak.Text = dr("Pelak").ToString()
        '==============
        lblMabda.Text = dr("NameMabda").ToString()
        lblMaghsad.Text = dr("NameMaghsad").ToString()
        '==============
        lblNoeBar.Text = dr("NoeBar").ToString()
        lblTozihat.Text = dr("Tozihat").ToString()
        '==============
        lblMahalBargiri.Text = dr("NameMahal").ToString()
        lblTarkhEzamBargiri.Text = dr("TarikhEzamBargiri").ToString()
        lblTarikhHozoorMahalBargiri.Text = dr("TarikhHozoorMahalBargiri").ToString()
        lblSaatHozoorMahalBargiri.Text = dr("SaatHozoorMahalBagiri").ToString()
        '==============
        lblShomareBarnameRaft.Text = dr("ShomareBarnameRaft").ToString()
        lblTarikhBarnameRaft.Text = dr("TarikhBarnameRaft").ToString()
        lblSaatSodoorBarname.Text = dr("SaatSodoorBarname").ToString()
        '==============
        lblKiloometrKhorroojMojtame.Text = dr("KiloometrKhorroojMojtame").ToString()
        lblMeghdarSookhtKhorooj.Text = dr("MeghdarSookhtKhorooj").ToString()
        '==============
        lblTarikhKhoroojMojtame.Text = dr("TarikhKhoroojMojtame").ToString()
        lblSaatKhoroojMojtame.Text = dr("SaatKhoroojMojtame").ToString()
        '==============
        ''
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub

    Private Sub frmQVEzamKhodro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
