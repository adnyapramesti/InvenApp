<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.tableHistory = New System.Windows.Forms.DataGridView()
        Me.KodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaPeminjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tglK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tglP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtPeminjam = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuPanel.SuspendLayout()
        CType(Me.tableHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuPanel
        '
        Me.MenuPanel.Controls.Add(Me.tableHistory)
        Me.MenuPanel.Controls.Add(Me.btnCari)
        Me.MenuPanel.Controls.Add(Me.txtPeminjam)
        Me.MenuPanel.Controls.Add(Me.Label1)
        Me.MenuPanel.Controls.Add(Me.Label5)
        Me.MenuPanel.Location = New System.Drawing.Point(-3, -15)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.ShadowDecoration.Parent = Me.MenuPanel
        Me.MenuPanel.Size = New System.Drawing.Size(1280, 800)
        Me.MenuPanel.TabIndex = 13
        '
        'tableHistory
        '
        Me.tableHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeBarang, Me.NamaBarang, Me.Jumlah, Me.NamaPeminjam, Me.tglK, Me.tglP, Me.Status})
        Me.tableHistory.Location = New System.Drawing.Point(21, 194)
        Me.tableHistory.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tableHistory.Name = "tableHistory"
        Me.tableHistory.RowHeadersWidth = 62
        Me.tableHistory.Size = New System.Drawing.Size(892, 523)
        Me.tableHistory.TabIndex = 22
        '
        'KodeBarang
        '
        Me.KodeBarang.HeaderText = "Kode Barang"
        Me.KodeBarang.MinimumWidth = 8
        Me.KodeBarang.Name = "KodeBarang"
        Me.KodeBarang.Width = 50
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
        Me.Jumlah.Width = 50
        '
        'NamaPeminjam
        '
        Me.NamaPeminjam.HeaderText = "Nama Peminjam"
        Me.NamaPeminjam.MinimumWidth = 8
        Me.NamaPeminjam.Name = "NamaPeminjam"
        Me.NamaPeminjam.Width = 150
        '
        'tglK
        '
        Me.tglK.HeaderText = "Tanggal Kembali"
        Me.tglK.MinimumWidth = 8
        Me.tglK.Name = "tglK"
        Me.tglK.Width = 150
        '
        'tglP
        '
        Me.tglP.HeaderText = "Tanggal Pinjam"
        Me.tglP.MinimumWidth = 8
        Me.tglP.Name = "tglP"
        Me.tglP.Width = 150
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.MinimumWidth = 8
        Me.Status.Name = "Status"
        Me.Status.Width = 150
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(480, 162)
        Me.btnCari.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(50, 35)
        Me.btnCari.TabIndex = 21
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
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
        Me.txtPeminjam.Location = New System.Drawing.Point(206, 163)
        Me.txtPeminjam.Name = "txtPeminjam"
        Me.txtPeminjam.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPeminjam.PlaceholderText = ""
        Me.txtPeminjam.SelectedText = ""
        Me.txtPeminjam.ShadowDecoration.Parent = Me.txtPeminjam
        Me.txtPeminjam.Size = New System.Drawing.Size(276, 35)
        Me.txtPeminjam.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nama Peminjam"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(269, 40)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "History Barang"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1275, 769)
        Me.Controls.Add(Me.MenuPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "History"
        Me.Text = "Form8"
        Me.MenuPanel.ResumeLayout(False)
        Me.MenuPanel.PerformLayout()
        CType(Me.tableHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents tableHistory As DataGridView
    Friend WithEvents btnCari As Button
    Friend WithEvents txtPeminjam As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents KodeBarang As DataGridViewTextBoxColumn
    Friend WithEvents NamaBarang As DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As DataGridViewTextBoxColumn
    Friend WithEvents NamaPeminjam As DataGridViewTextBoxColumn
    Friend WithEvents tglK As DataGridViewTextBoxColumn
    Friend WithEvents tglP As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
End Class
