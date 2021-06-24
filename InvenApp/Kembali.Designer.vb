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
        Me.btnCari = New System.Windows.Forms.Button()
        Me.dateKembali = New System.Windows.Forms.DateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnPinjam = New Guna.UI2.WinForms.Guna2Button()
        Me.MenuPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtJumlah = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tableKembali = New System.Windows.Forms.DataGridView()
        Me.NamaPeminjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pilih = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuPanel.SuspendLayout()
        CType(Me.tableKembali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(64, 498)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Tanggal Kembali"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
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
        Me.txtPeminjam.Location = New System.Drawing.Point(206, 152)
        Me.txtPeminjam.Name = "txtPeminjam"
        Me.txtPeminjam.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPeminjam.PlaceholderText = ""
        Me.txtPeminjam.SelectedText = ""
        Me.txtPeminjam.ShadowDecoration.Parent = Me.txtPeminjam
        Me.txtPeminjam.Size = New System.Drawing.Size(276, 35)
        Me.txtPeminjam.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(392, 40)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Pengembalian Barang"
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
        'dateKembali
        '
        Me.dateKembali.Location = New System.Drawing.Point(206, 498)
        Me.dateKembali.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dateKembali.Name = "dateKembali"
        Me.dateKembali.Size = New System.Drawing.Size(318, 26)
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
        Me.btnPinjam.Location = New System.Drawing.Point(62, 552)
        Me.btnPinjam.Name = "btnPinjam"
        Me.btnPinjam.ShadowDecoration.Parent = Me.btnPinjam
        Me.btnPinjam.Size = New System.Drawing.Size(180, 45)
        Me.btnPinjam.TabIndex = 9
        Me.btnPinjam.Text = "Pinjam Barang"
        '
        'MenuPanel
        '
        Me.MenuPanel.Controls.Add(Me.txtJumlah)
        Me.MenuPanel.Controls.Add(Me.Label2)
        Me.MenuPanel.Controls.Add(Me.tableKembali)
        Me.MenuPanel.Controls.Add(Me.btnCari)
        Me.MenuPanel.Controls.Add(Me.txtPeminjam)
        Me.MenuPanel.Controls.Add(Me.Label1)
        Me.MenuPanel.Controls.Add(Me.dateKembali)
        Me.MenuPanel.Controls.Add(Me.Label5)
        Me.MenuPanel.Controls.Add(Me.Label6)
        Me.MenuPanel.Controls.Add(Me.btnPinjam)
        Me.MenuPanel.Location = New System.Drawing.Point(16, 0)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.ShadowDecoration.Parent = Me.MenuPanel
        Me.MenuPanel.Size = New System.Drawing.Size(1258, 769)
        Me.MenuPanel.TabIndex = 7
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
        Me.txtJumlah.Location = New System.Drawing.Point(206, 455)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJumlah.PlaceholderText = ""
        Me.txtJumlah.SelectedText = ""
        Me.txtJumlah.ShadowDecoration.Parent = Me.txtJumlah
        Me.txtJumlah.Size = New System.Drawing.Size(276, 35)
        Me.txtJumlah.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 462)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Jumlah"
        '
        'tableKembali
        '
        Me.tableKembali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableKembali.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NamaPeminjam, Me.KodeBarang, Me.NamaBarang, Me.Jumlah, Me.pilih})
        Me.tableKembali.Location = New System.Drawing.Point(206, 214)
        Me.tableKembali.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tableKembali.Name = "tableKembali"
        Me.tableKembali.RowHeadersWidth = 62
        Me.tableKembali.Size = New System.Drawing.Size(608, 231)
        Me.tableKembali.TabIndex = 22
        '
        'NamaPeminjam
        '
        Me.NamaPeminjam.HeaderText = "Nama Peminjam"
        Me.NamaPeminjam.MinimumWidth = 8
        Me.NamaPeminjam.Name = "NamaPeminjam"
        Me.NamaPeminjam.Width = 150
        '
        'KodeBarang
        '
        Me.KodeBarang.HeaderText = "Kode Barang"
        Me.KodeBarang.MinimumWidth = 8
        Me.KodeBarang.Name = "KodeBarang"
        Me.KodeBarang.Width = 150
        '
        'NamaBarang
        '
        Me.NamaBarang.HeaderText = "NamaBarang"
        Me.NamaBarang.MinimumWidth = 8
        Me.NamaBarang.Name = "NamaBarang"
        Me.NamaBarang.Width = 150
        '
        'Jumlah
        '
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.MinimumWidth = 8
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.Width = 150
        '
        'pilih
        '
        Me.pilih.HeaderText = "Select"
        Me.pilih.MinimumWidth = 8
        Me.pilih.Name = "pilih"
        Me.pilih.Width = 150
        '
        'Kembali
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1275, 769)
        Me.Controls.Add(Me.MenuPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Kembali"
        Me.Text = "Form4"
        Me.MenuPanel.ResumeLayout(False)
        Me.MenuPanel.PerformLayout()
        CType(Me.tableKembali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPeminjam As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCari As Button
    Friend WithEvents dateKembali As DateTimePicker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnPinjam As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents MenuPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtJumlah As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tableKembali As DataGridView
    Friend WithEvents NamaPeminjam As DataGridViewTextBoxColumn
    Friend WithEvents KodeBarang As DataGridViewTextBoxColumn
    Friend WithEvents NamaBarang As DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As DataGridViewTextBoxColumn
    Friend WithEvents pilih As DataGridViewTextBoxColumn
End Class
