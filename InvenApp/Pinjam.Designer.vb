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
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtNmBarang = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtKdInventaris = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKontak = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDivisi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPeminjam = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dateKembali = New System.Windows.Forms.DateTimePicker()
        Me.datePinjam = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPinjam = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtJumlah = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuPanel
        '
        Me.MenuPanel.Controls.Add(Me.btnCari)
        Me.MenuPanel.Controls.Add(Me.txtNmBarang)
        Me.MenuPanel.Controls.Add(Me.txtKdInventaris)
        Me.MenuPanel.Controls.Add(Me.Label9)
        Me.MenuPanel.Controls.Add(Me.Label1)
        Me.MenuPanel.Controls.Add(Me.txtKontak)
        Me.MenuPanel.Controls.Add(Me.Label4)
        Me.MenuPanel.Controls.Add(Me.Label8)
        Me.MenuPanel.Controls.Add(Me.txtDivisi)
        Me.MenuPanel.Controls.Add(Me.Label7)
        Me.MenuPanel.Controls.Add(Me.txtPeminjam)
        Me.MenuPanel.Controls.Add(Me.dateKembali)
        Me.MenuPanel.Controls.Add(Me.datePinjam)
        Me.MenuPanel.Controls.Add(Me.Label5)
        Me.MenuPanel.Controls.Add(Me.Label6)
        Me.MenuPanel.Controls.Add(Me.Label3)
        Me.MenuPanel.Controls.Add(Me.btnPinjam)
        Me.MenuPanel.Controls.Add(Me.Label2)
        Me.MenuPanel.Controls.Add(Me.txtJumlah)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.ShadowDecoration.Parent = Me.MenuPanel
        Me.MenuPanel.Size = New System.Drawing.Size(1275, 769)
        Me.MenuPanel.TabIndex = 5
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(480, 151)
        Me.btnCari.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(50, 35)
        Me.btnCari.TabIndex = 21
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'txtNmBarang
        '
        Me.txtNmBarang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNmBarang.DefaultText = ""
        Me.txtNmBarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNmBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNmBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNmBarang.DisabledState.Parent = Me.txtNmBarang
        Me.txtNmBarang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNmBarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNmBarang.FocusedState.Parent = Me.txtNmBarang
        Me.txtNmBarang.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNmBarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNmBarang.HoverState.Parent = Me.txtNmBarang
        Me.txtNmBarang.Location = New System.Drawing.Point(206, 152)
        Me.txtNmBarang.Name = "txtNmBarang"
        Me.txtNmBarang.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNmBarang.PlaceholderText = ""
        Me.txtNmBarang.SelectedText = ""
        Me.txtNmBarang.ShadowDecoration.Parent = Me.txtNmBarang
        Me.txtNmBarang.Size = New System.Drawing.Size(276, 35)
        Me.txtNmBarang.TabIndex = 7
        '
        'txtKdInventaris
        '
        Me.txtKdInventaris.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKdInventaris.DefaultText = ""
        Me.txtKdInventaris.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtKdInventaris.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtKdInventaris.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtKdInventaris.DisabledState.Parent = Me.txtKdInventaris
        Me.txtKdInventaris.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtKdInventaris.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtKdInventaris.FocusedState.Parent = Me.txtKdInventaris
        Me.txtKdInventaris.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtKdInventaris.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtKdInventaris.HoverState.Parent = Me.txtKdInventaris
        Me.txtKdInventaris.Location = New System.Drawing.Point(206, 198)
        Me.txtKdInventaris.Name = "txtKdInventaris"
        Me.txtKdInventaris.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKdInventaris.PlaceholderText = ""
        Me.txtKdInventaris.SelectedText = ""
        Me.txtKdInventaris.ShadowDecoration.Parent = Me.txtKdInventaris
        Me.txtKdInventaris.Size = New System.Drawing.Size(320, 35)
        Me.txtKdInventaris.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(64, 343)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 20)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Kontak Peminjam"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
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
        Me.txtKontak.Location = New System.Drawing.Point(206, 343)
        Me.txtKontak.Name = "txtKontak"
        Me.txtKontak.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKontak.PlaceholderText = ""
        Me.txtKontak.SelectedText = ""
        Me.txtKontak.ShadowDecoration.Parent = Me.txtKontak
        Me.txtKontak.Size = New System.Drawing.Size(320, 35)
        Me.txtKontak.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Kode Inventaris"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(64, 292)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 20)
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
        Me.txtDivisi.Location = New System.Drawing.Point(206, 292)
        Me.txtDivisi.Name = "txtDivisi"
        Me.txtDivisi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDivisi.PlaceholderText = ""
        Me.txtDivisi.SelectedText = ""
        Me.txtDivisi.ShadowDecoration.Parent = Me.txtDivisi
        Me.txtDivisi.Size = New System.Drawing.Size(320, 35)
        Me.txtDivisi.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(64, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 20)
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
        Me.txtPeminjam.Location = New System.Drawing.Point(206, 243)
        Me.txtPeminjam.Name = "txtPeminjam"
        Me.txtPeminjam.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPeminjam.PlaceholderText = ""
        Me.txtPeminjam.SelectedText = ""
        Me.txtPeminjam.ShadowDecoration.Parent = Me.txtPeminjam
        Me.txtPeminjam.Size = New System.Drawing.Size(320, 35)
        Me.txtPeminjam.TabIndex = 15
        '
        'dateKembali
        '
        Me.dateKembali.Location = New System.Drawing.Point(206, 483)
        Me.dateKembali.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dateKembali.Name = "dateKembali"
        Me.dateKembali.Size = New System.Drawing.Size(318, 26)
        Me.dateKembali.TabIndex = 14
        '
        'datePinjam
        '
        Me.datePinjam.Location = New System.Drawing.Point(206, 440)
        Me.datePinjam.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.datePinjam.Name = "datePinjam"
        Me.datePinjam.Size = New System.Drawing.Size(318, 26)
        Me.datePinjam.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(266, 40)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Pinjam Barang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(64, 483)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Tanggal Kembali"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 440)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Tanggal Pinjam"
        '
        'btnPinjam
        '
        Me.btnPinjam.CheckedState.Parent = Me.btnPinjam
        Me.btnPinjam.CustomImages.Parent = Me.btnPinjam
        Me.btnPinjam.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPinjam.ForeColor = System.Drawing.Color.White
        Me.btnPinjam.HoverState.Parent = Me.btnPinjam
        Me.btnPinjam.Location = New System.Drawing.Point(62, 552)
        Me.btnPinjam.Name = "btnPinjam"
        Me.btnPinjam.ShadowDecoration.Parent = Me.btnPinjam
        Me.btnPinjam.Size = New System.Drawing.Size(180, 45)
        Me.btnPinjam.TabIndex = 9
        Me.btnPinjam.Text = "Pinjam Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 388)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
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
        Me.txtJumlah.Location = New System.Drawing.Point(206, 388)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJumlah.PlaceholderText = ""
        Me.txtJumlah.SelectedText = ""
        Me.txtJumlah.ShadowDecoration.Parent = Me.txtJumlah
        Me.txtJumlah.Size = New System.Drawing.Size(320, 35)
        Me.txtJumlah.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Pinjam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1275, 769)
        Me.Controls.Add(Me.MenuPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Pinjam"
        Me.Text = "Form3"
        Me.MenuPanel.ResumeLayout(False)
        Me.MenuPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btnPinjam As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNmBarang As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtJumlah As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtKdInventaris As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dateKembali As DateTimePicker
    Friend WithEvents datePinjam As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDivisi As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPeminjam As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtKontak As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnCari As Button
End Class
