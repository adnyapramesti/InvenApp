<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Kembali
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPeminjam = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dateKembali = New System.Windows.Forms.DateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnPinjam = New Guna.UI2.WinForms.Guna2Button()
        Me.MenuPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtk = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.txtname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtJumlah = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtjum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.MenuPanel.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 356)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Tanggal Kembali"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 103)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nama Peminjam"
        '
        'txtPeminjam
        '
        Me.txtPeminjam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPeminjam.DefaultText = ""
        Me.txtPeminjam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPeminjam.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPeminjam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPeminjam.DisabledState.Parent = Me.txtPeminjam
        Me.txtPeminjam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPeminjam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPeminjam.FocusedState.Parent = Me.txtPeminjam
        Me.txtPeminjam.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPeminjam.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPeminjam.HoverState.Parent = Me.txtPeminjam
        Me.txtPeminjam.Location = New System.Drawing.Point(137, 99)
        Me.txtPeminjam.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPeminjam.Name = "txtPeminjam"
        Me.txtPeminjam.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPeminjam.PlaceholderText = ""
        Me.txtPeminjam.SelectedText = ""
        Me.txtPeminjam.ShadowDecoration.Parent = Me.txtPeminjam
        Me.txtPeminjam.Size = New System.Drawing.Size(274, 23)
        Me.txtPeminjam.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 52)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(271, 29)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Pengembalian Barang"
        '
        'dateKembali
        '
        Me.dateKembali.Location = New System.Drawing.Point(137, 356)
        Me.dateKembali.Name = "dateKembali"
        Me.dateKembali.Size = New System.Drawing.Size(274, 20)
        Me.dateKembali.TabIndex = 14
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'btnPinjam
        '
        Me.btnPinjam.CheckedState.Parent = Me.btnPinjam
        Me.btnPinjam.CustomImages.Parent = Me.btnPinjam
        Me.btnPinjam.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPinjam.ForeColor = System.Drawing.Color.White
        Me.btnPinjam.HoverState.Parent = Me.btnPinjam
        Me.btnPinjam.Location = New System.Drawing.Point(41, 391)
        Me.btnPinjam.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPinjam.Name = "btnPinjam"
        Me.btnPinjam.ShadowDecoration.Parent = Me.btnPinjam
        Me.btnPinjam.Size = New System.Drawing.Size(174, 29)
        Me.btnPinjam.TabIndex = 9
        Me.btnPinjam.Text = "Pengembalian Barang"
        '
        'MenuPanel
        '
        Me.MenuPanel.Controls.Add(Me.txtk)
        Me.MenuPanel.Controls.Add(Me.DGV)
        Me.MenuPanel.Controls.Add(Me.txtname)
        Me.MenuPanel.Controls.Add(Me.Label3)
        Me.MenuPanel.Controls.Add(Me.txtJumlah)
        Me.MenuPanel.Controls.Add(Me.Label2)
        Me.MenuPanel.Controls.Add(Me.txtPeminjam)
        Me.MenuPanel.Controls.Add(Me.Label1)
        Me.MenuPanel.Controls.Add(Me.dateKembali)
        Me.MenuPanel.Controls.Add(Me.Label5)
        Me.MenuPanel.Controls.Add(Me.Label6)
        Me.MenuPanel.Controls.Add(Me.btnPinjam)
        Me.MenuPanel.Controls.Add(Me.txtjum)
        Me.MenuPanel.Location = New System.Drawing.Point(11, 0)
        Me.MenuPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.ShadowDecoration.Parent = Me.MenuPanel
        Me.MenuPanel.Size = New System.Drawing.Size(839, 500)
        Me.MenuPanel.TabIndex = 7
        '
        'txtk
        '
        Me.txtk.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtk.DefaultText = ""
        Me.txtk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtk.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtk.DisabledState.Parent = Me.txtk
        Me.txtk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtk.FocusedState.Parent = Me.txtk
        Me.txtk.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtk.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtk.HoverState.Parent = Me.txtk
        Me.txtk.Location = New System.Drawing.Point(536, 322)
        Me.txtk.Margin = New System.Windows.Forms.Padding(2)
        Me.txtk.Name = "txtk"
        Me.txtk.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtk.PlaceholderText = ""
        Me.txtk.SelectedText = ""
        Me.txtk.ShadowDecoration.Parent = Me.txtk
        Me.txtk.Size = New System.Drawing.Size(274, 23)
        Me.txtk.TabIndex = 29
        Me.txtk.Visible = False
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(137, 128)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(274, 150)
        Me.DGV.TabIndex = 27
        '
        'txtname
        '
        Me.txtname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtname.DefaultText = ""
        Me.txtname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtname.DisabledState.Parent = Me.txtname
        Me.txtname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtname.FocusedState.Parent = Me.txtname
        Me.txtname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtname.HoverState.Parent = Me.txtname
        Me.txtname.Location = New System.Drawing.Point(137, 298)
        Me.txtname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtname.Name = "txtname"
        Me.txtname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtname.PlaceholderText = ""
        Me.txtname.SelectedText = ""
        Me.txtname.ShadowDecoration.Parent = Me.txtname
        Me.txtname.Size = New System.Drawing.Size(274, 23)
        Me.txtname.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 302)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "ID Peminjaman"
        '
        'txtJumlah
        '
        Me.txtJumlah.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJumlah.DefaultText = ""
        Me.txtJumlah.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtJumlah.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtJumlah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtJumlah.DisabledState.Parent = Me.txtJumlah
        Me.txtJumlah.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtJumlah.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtJumlah.FocusedState.Parent = Me.txtJumlah
        Me.txtJumlah.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtJumlah.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtJumlah.HoverState.Parent = Me.txtJumlah
        Me.txtJumlah.Location = New System.Drawing.Point(137, 328)
        Me.txtJumlah.Margin = New System.Windows.Forms.Padding(2)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJumlah.PlaceholderText = ""
        Me.txtJumlah.SelectedText = ""
        Me.txtJumlah.ShadowDecoration.Parent = Me.txtJumlah
        Me.txtJumlah.Size = New System.Drawing.Size(274, 23)
        Me.txtJumlah.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 332)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Jumlah"
        '
        'txtjum
        '
        Me.txtjum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtjum.DefaultText = ""
        Me.txtjum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtjum.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtjum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtjum.DisabledState.Parent = Me.txtjum
        Me.txtjum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtjum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtjum.FocusedState.Parent = Me.txtjum
        Me.txtjum.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtjum.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtjum.HoverState.Parent = Me.txtjum
        Me.txtjum.Location = New System.Drawing.Point(137, 298)
        Me.txtjum.Margin = New System.Windows.Forms.Padding(2)
        Me.txtjum.Name = "txtjum"
        Me.txtjum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjum.PlaceholderText = ""
        Me.txtjum.SelectedText = ""
        Me.txtjum.ShadowDecoration.Parent = Me.txtjum
        Me.txtjum.Size = New System.Drawing.Size(274, 23)
        Me.txtjum.TabIndex = 28
        Me.txtjum.Visible = False
        '
        'Kembali
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 500)
        Me.Controls.Add(Me.MenuPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Kembali"
        Me.Text = "Form4"
        Me.MenuPanel.ResumeLayout(False)
        Me.MenuPanel.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPeminjam As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dateKembali As DateTimePicker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnPinjam As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents MenuPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtJumlah As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents txtjum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtk As Guna.UI2.WinForms.Guna2TextBox
End Class
