<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class List
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
        Me.tableListBarang = New System.Windows.Forms.DataGridView()
        Me.KodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kondisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtNmBarang = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuPanel.SuspendLayout()
        CType(Me.tableListBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuPanel
        '
        Me.MenuPanel.Controls.Add(Me.tableListBarang)
        Me.MenuPanel.Controls.Add(Me.btnCari)
        Me.MenuPanel.Controls.Add(Me.txtNmBarang)
        Me.MenuPanel.Controls.Add(Me.Label1)
        Me.MenuPanel.Controls.Add(Me.Label5)
        Me.MenuPanel.Controls.Add(Me.btnEdit)
        Me.MenuPanel.Location = New System.Drawing.Point(-2, -31)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.ShadowDecoration.Parent = Me.MenuPanel
        Me.MenuPanel.Size = New System.Drawing.Size(1282, 800)
        Me.MenuPanel.TabIndex = 9
        '
        'tableListBarang
        '
        Me.tableListBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableListBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeBarang, Me.NamaBarang, Me.Jumlah, Me.kondisi})
        Me.tableListBarang.Location = New System.Drawing.Point(70, 206)
        Me.tableListBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tableListBarang.Name = "tableListBarang"
        Me.tableListBarang.RowHeadersWidth = 62
        Me.tableListBarang.Size = New System.Drawing.Size(663, 372)
        Me.tableListBarang.TabIndex = 22
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
        'kondisi
        '
        Me.kondisi.HeaderText = "Kondisi"
        Me.kondisi.MinimumWidth = 8
        Me.kondisi.Name = "kondisi"
        Me.kondisi.Width = 150
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
        Me.txtNmBarang.Location = New System.Drawing.Point(206, 163)
        Me.txtNmBarang.Name = "txtNmBarang"
        Me.txtNmBarang.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNmBarang.PlaceholderText = ""
        Me.txtNmBarang.SelectedText = ""
        Me.txtNmBarang.ShadowDecoration.Parent = Me.txtNmBarang
        Me.txtNmBarang.Size = New System.Drawing.Size(276, 35)
        Me.txtNmBarang.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nama Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 40)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "List Barang"
        '
        'btnEdit
        '
        Me.btnEdit.CheckedState.Parent = Me.btnEdit
        Me.btnEdit.CustomImages.Parent = Me.btnEdit
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.HoverState.Parent = Me.btnEdit
        Me.btnEdit.Location = New System.Drawing.Point(99, 609)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ShadowDecoration.Parent = Me.btnEdit
        Me.btnEdit.Size = New System.Drawing.Size(180, 45)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "Edit Barang"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1275, 769)
        Me.Controls.Add(Me.MenuPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "List"
        Me.Text = "Form5"
        Me.MenuPanel.ResumeLayout(False)
        Me.MenuPanel.PerformLayout()
        CType(Me.tableListBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents tableListBarang As DataGridView
    Friend WithEvents btnCari As Button
    Friend WithEvents txtNmBarang As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents KodeBarang As DataGridViewTextBoxColumn
    Friend WithEvents NamaBarang As DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As DataGridViewTextBoxColumn
    Friend WithEvents kondisi As DataGridViewTextBoxColumn
End Class
