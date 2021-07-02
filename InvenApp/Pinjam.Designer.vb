<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pinjam
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
        Me.MenuPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.tbListBaran = New System.Windows.Forms.DataGridView()
        Me.txtNama = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtIdBrg = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKontak = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDivisi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPeminjam = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dateKembali = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnPinjam = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtJumlah = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuPanel.SuspendLayout()
        CType(Me.tbListBaran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuPanel
        '
        Me.MenuPanel.Controls.Add(Me.tbListBaran)
        Me.MenuPanel.Controls.Add(Me.txtNama)
        Me.MenuPanel.Controls.Add(Me.txtIdBrg)
        Me.MenuPanel.Controls.Add(Me.Label9)
        Me.MenuPanel.Controls.Add(Me.Label1)
        Me.MenuPanel.Controls.Add(Me.txtKontak)
        Me.MenuPanel.Controls.Add(Me.Label4)
        Me.MenuPanel.Controls.Add(Me.Label8)
        Me.MenuPanel.Controls.Add(Me.txtDivisi)
        Me.MenuPanel.Controls.Add(Me.Label7)
        Me.MenuPanel.Controls.Add(Me.txtPeminjam)
        Me.MenuPanel.Controls.Add(Me.dateKembali)
        Me.MenuPanel.Controls.Add(Me.Label5)
        Me.MenuPanel.Controls.Add(Me.Label6)
        Me.MenuPanel.Controls.Add(Me.btnPinjam)
        Me.MenuPanel.Controls.Add(Me.Label2)
        Me.MenuPanel.Controls.Add(Me.txtJumlah)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.ShadowDecoration.Parent = Me.MenuPanel
        Me.MenuPanel.Size = New System.Drawing.Size(850, 500)
        Me.MenuPanel.TabIndex = 5
        '
        'tbListBaran
        '
        Me.tbListBaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tbListBaran.Location = New System.Drawing.Point(137, 137)
        Me.tbListBaran.Name = "tbListBaran"
        Me.tbListBaran.RowHeadersWidth = 62
        Me.tbListBaran.Size = New System.Drawing.Size(348, 91)
        Me.tbListBaran.TabIndex = 23
        '
        'txtNama
        '
        Me.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNama.DefaultText = ""
        Me.txtNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNama.DisabledState.Parent = Me.txtNama
        Me.txtNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNama.FocusedState.Parent = Me.txtNama
        Me.txtNama.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNama.HoverState.Parent = Me.txtNama
        Me.txtNama.Location = New System.Drawing.Point(137, 102)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNama.PlaceholderText = ""
        Me.txtNama.SelectedText = ""
        Me.txtNama.ShadowDecoration.Parent = Me.txtNama
        Me.txtNama.Size = New System.Drawing.Size(348, 23)
        Me.txtNama.TabIndex = 21
        '
        'txtIdBrg
        '
        Me.txtIdBrg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdBrg.DefaultText = ""
        Me.txtIdBrg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtIdBrg.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtIdBrg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIdBrg.DisabledState.Parent = Me.txtIdBrg
        Me.txtIdBrg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIdBrg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdBrg.FocusedState.Parent = Me.txtIdBrg
        Me.txtIdBrg.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtIdBrg.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdBrg.HoverState.Parent = Me.txtIdBrg
        Me.txtIdBrg.Location = New System.Drawing.Point(137, 233)
        Me.txtIdBrg.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdBrg.Name = "txtIdBrg"
        Me.txtIdBrg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdBrg.PlaceholderText = ""
        Me.txtIdBrg.ReadOnly = True
        Me.txtIdBrg.SelectedText = ""
        Me.txtIdBrg.ShadowDecoration.Parent = Me.txtIdBrg
        Me.txtIdBrg.Size = New System.Drawing.Size(348, 23)
        Me.txtIdBrg.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(43, 327)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Kontak Peminjam"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 103)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nama Barang"
        '
        'txtKontak
        '
        Me.txtKontak.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKontak.DefaultText = ""
        Me.txtKontak.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtKontak.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtKontak.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtKontak.DisabledState.Parent = Me.txtKontak
        Me.txtKontak.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtKontak.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtKontak.FocusedState.Parent = Me.txtKontak
        Me.txtKontak.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtKontak.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtKontak.HoverState.Parent = Me.txtKontak
        Me.txtKontak.Location = New System.Drawing.Point(137, 327)
        Me.txtKontak.Margin = New System.Windows.Forms.Padding(2)
        Me.txtKontak.Name = "txtKontak"
        Me.txtKontak.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKontak.PlaceholderText = ""
        Me.txtKontak.SelectedText = ""
        Me.txtKontak.ShadowDecoration.Parent = Me.txtKontak
        Me.txtKontak.Size = New System.Drawing.Size(348, 23)
        Me.txtKontak.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 235)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ID Barang"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(43, 294)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Instansi/Divisi"
        '
        'txtDivisi
        '
        Me.txtDivisi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDivisi.DefaultText = ""
        Me.txtDivisi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDivisi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDivisi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDivisi.DisabledState.Parent = Me.txtDivisi
        Me.txtDivisi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDivisi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDivisi.FocusedState.Parent = Me.txtDivisi
        Me.txtDivisi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDivisi.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDivisi.HoverState.Parent = Me.txtDivisi
        Me.txtDivisi.Location = New System.Drawing.Point(137, 294)
        Me.txtDivisi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDivisi.Name = "txtDivisi"
        Me.txtDivisi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDivisi.PlaceholderText = ""
        Me.txtDivisi.SelectedText = ""
        Me.txtDivisi.ShadowDecoration.Parent = Me.txtDivisi
        Me.txtDivisi.Size = New System.Drawing.Size(348, 23)
        Me.txtDivisi.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 262)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Peminjam"
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
        Me.txtPeminjam.Location = New System.Drawing.Point(137, 262)
        Me.txtPeminjam.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPeminjam.Name = "txtPeminjam"
        Me.txtPeminjam.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPeminjam.PlaceholderText = ""
        Me.txtPeminjam.SelectedText = ""
        Me.txtPeminjam.ShadowDecoration.Parent = Me.txtPeminjam
        Me.txtPeminjam.Size = New System.Drawing.Size(348, 23)
        Me.txtPeminjam.TabIndex = 15
        '
        'dateKembali
        '
        Me.dateKembali.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateKembali.Location = New System.Drawing.Point(137, 418)
        Me.dateKembali.Name = "dateKembali"
        Me.dateKembali.Size = New System.Drawing.Size(348, 20)
        Me.dateKembali.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 52)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 29)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Pinjam Barang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 418)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Tanggal Kembali"
        '
        'btnPinjam
        '
        Me.btnPinjam.CheckedState.Parent = Me.btnPinjam
        Me.btnPinjam.CustomImages.Parent = Me.btnPinjam
        Me.btnPinjam.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPinjam.ForeColor = System.Drawing.Color.White
        Me.btnPinjam.HoverState.Parent = Me.btnPinjam
        Me.btnPinjam.Location = New System.Drawing.Point(41, 463)
        Me.btnPinjam.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPinjam.Name = "btnPinjam"
        Me.btnPinjam.ShadowDecoration.Parent = Me.btnPinjam
        Me.btnPinjam.Size = New System.Drawing.Size(120, 29)
        Me.btnPinjam.TabIndex = 9
        Me.btnPinjam.Text = "Pinjam Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 356)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Jumlah"
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
        Me.txtJumlah.Location = New System.Drawing.Point(137, 356)
        Me.txtJumlah.Margin = New System.Windows.Forms.Padding(2)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJumlah.PlaceholderText = ""
        Me.txtJumlah.SelectedText = ""
        Me.txtJumlah.ShadowDecoration.Parent = Me.txtJumlah
        Me.txtJumlah.Size = New System.Drawing.Size(348, 23)
        Me.txtJumlah.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Pinjam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 500)
        Me.Controls.Add(Me.MenuPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Pinjam"
        Me.Text = "Form3"
        Me.MenuPanel.ResumeLayout(False)
        Me.MenuPanel.PerformLayout()
        CType(Me.tbListBaran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btnPinjam As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtJumlah As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtIdBrg As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents dateKembali As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDivisi As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPeminjam As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtKontak As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNama As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbListBaran As DataGridView
End Class
