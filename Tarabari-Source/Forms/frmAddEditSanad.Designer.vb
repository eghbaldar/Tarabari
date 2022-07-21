<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditSanad
    Inherits Tarabari.frmBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditSanad))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnShow = New DevComponents.DotNetBar.ButtonX
        Me.btnSearch = New DevComponents.DotNetBar.ButtonX
        Me.txtOperationCode = New Tarabari.AdvancedTextBox(Me.components)
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblTarikh = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblRanande = New System.Windows.Forms.Label
        Me.lblMashinID = New System.Windows.Forms.Label
        Me.lblPelak = New System.Windows.Forms.Label
        Me.dgvSanad = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnSave = New DevComponents.DotNetBar.ButtonX
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSanad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnShow)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtOperationCode)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.lblTarikh)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblRanande)
        Me.GroupBox1.Controls.Add(Me.lblMashinID)
        Me.GroupBox1.Controls.Add(Me.lblPelak)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(744, 117)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مشخصات سند"
        '
        'btnShow
        '
        Me.btnShow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnShow.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnShow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnShow.Image = Global.Tarabari.My.Resources.Resources.Show
        Me.btnShow.Location = New System.Drawing.Point(425, 21)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(87, 31)
        Me.btnShow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnShow.TabIndex = 21
        Me.btnShow.Text = "نمایش"
        '
        'btnSearch
        '
        Me.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(533, 25)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSearch.TabIndex = 20
        '
        'txtOperationCode
        '
        Me.txtOperationCode.BorderColor = System.Drawing.Color.Empty
        Me.txtOperationCode.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOperationCode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtOperationCode.InputMode = Tarabari.AdvancedTextBox.enInputMode.Number
        Me.txtOperationCode.Language = Tarabari.AdvancedTextBox.enLanguage.English
        Me.txtOperationCode.Location = New System.Drawing.Point(560, 27)
        Me.txtOperationCode.MaxLength = 9999999
        Me.txtOperationCode.Name = "txtOperationCode"
        Me.txtOperationCode.NextControl = Nothing
        Me.txtOperationCode.PrevControl = Nothing
        Me.txtOperationCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOperationCode.Size = New System.Drawing.Size(83, 21)
        Me.txtOperationCode.TabIndex = 19
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(197, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 13)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "تاریخ :"
        '
        'lblTarikh
        '
        Me.lblTarikh.ForeColor = System.Drawing.Color.Blue
        Me.lblTarikh.Location = New System.Drawing.Point(108, 28)
        Me.lblTarikh.Name = "lblTarikh"
        Me.lblTarikh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTarikh.Size = New System.Drawing.Size(83, 19)
        Me.lblTarikh.TabIndex = 17
        Me.lblTarikh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(649, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "شماره عملیات :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(649, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "راننده :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(383, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "کد تریلی :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(147, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "شماره انتظامی :"
        '
        'lblRanande
        '
        Me.lblRanande.ForeColor = System.Drawing.Color.Blue
        Me.lblRanande.Location = New System.Drawing.Point(465, 69)
        Me.lblRanande.Name = "lblRanande"
        Me.lblRanande.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblRanande.Size = New System.Drawing.Size(178, 19)
        Me.lblRanande.TabIndex = 12
        Me.lblRanande.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMashinID
        '
        Me.lblMashinID.ForeColor = System.Drawing.Color.Blue
        Me.lblMashinID.Location = New System.Drawing.Point(255, 69)
        Me.lblMashinID.Name = "lblMashinID"
        Me.lblMashinID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblMashinID.Size = New System.Drawing.Size(122, 19)
        Me.lblMashinID.TabIndex = 10
        Me.lblMashinID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPelak
        '
        Me.lblPelak.ForeColor = System.Drawing.Color.Blue
        Me.lblPelak.Location = New System.Drawing.Point(19, 69)
        Me.lblPelak.Name = "lblPelak"
        Me.lblPelak.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblPelak.Size = New System.Drawing.Size(122, 19)
        Me.lblPelak.TabIndex = 11
        Me.lblPelak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvSanad
        '
        Me.dgvSanad.AllowUserToAddRows = False
        Me.dgvSanad.AllowUserToDeleteRows = False
        Me.dgvSanad.AllowUserToResizeColumns = False
        Me.dgvSanad.AllowUserToResizeRows = False
        Me.dgvSanad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSanad.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSanad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSanad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSanad.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSanad.Enabled = False
        Me.dgvSanad.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvSanad.Location = New System.Drawing.Point(15, 143)
        Me.dgvSanad.MultiSelect = False
        Me.dgvSanad.Name = "dgvSanad"
        Me.dgvSanad.RowHeadersWidth = 170
        Me.dgvSanad.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvSanad.Size = New System.Drawing.Size(744, 426)
        Me.dgvSanad.TabIndex = 9
        '
        'Column1
        '
        Me.Column1.HeaderText = "1"
        Me.Column1.Name = "Column1"
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column2
        '
        Me.Column2.HeaderText = "2"
        Me.Column2.Name = "Column2"
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column3
        '
        Me.Column3.HeaderText = "3"
        Me.Column3.Name = "Column3"
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column4
        '
        Me.Column4.HeaderText = "4"
        Me.Column4.Name = "Column4"
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column5
        '
        Me.Column5.HeaderText = "مجموع"
        Me.Column5.Name = "Column5"
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Image = Global.Tarabari.My.Resources.Resources.Save
        Me.btnSave.Location = New System.Drawing.Point(672, 579)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 31)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "ذخیره"
        '
        'frmAddEditSanad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(773, 622)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgvSanad)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "frmAddEditSanad"
        Me.Text = "اسناد بارنامه ای"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvSanad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblRanande As System.Windows.Forms.Label
    Friend WithEvents lblMashinID As System.Windows.Forms.Label
    Friend WithEvents lblPelak As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblTarikh As System.Windows.Forms.Label
    Friend WithEvents txtOperationCode As Tarabari.AdvancedTextBox
    Friend WithEvents dgvSanad As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnShow As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSearch As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX

End Class
