<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKdInventaris = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKondisi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HeaderMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.txtJumlah = New Guna.UI2.WinForms.Guna2TextBox()
        Me.MenuPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtNmBarang = New Guna.UI2.WinForms.Guna2TextBox()
        Me.HeaderMenu.SuspendLayout()
        Me.MenuPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 62)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 29)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Edit Barang "
        '
        'btnEdit
        '
        Me.btnEdit.CheckedState.Parent = Me.btnEdit
        Me.btnEdit.CustomImages.Parent = Me.btnEdit
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.HoverState.Parent = Me.btnEdit
        Me.btnEdit.Location = New System.Drawing.Point(41, 290)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ShadowDecoration.Parent = Me.btnEdit
        Me.btnEdit.Size = New System.Drawing.Size(120, 29)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "Edit Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 241)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Kode Inventaris"
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
        Me.txtKdInventaris.Location = New System.Drawing.Point(135, 241)
        Me.txtKdInventaris.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtKdInventaris.Name = "txtKdInventaris"
        Me.txtKdInventaris.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKdInventaris.PlaceholderText = ""
        Me.txtKdInventaris.SelectedText = ""
        Me.txtKdInventaris.ShadowDecoration.Parent = Me.txtKdInventaris
        Me.txtKdInventaris.Size = New System.Drawing.Size(213, 23)
        Me.txtKdInventaris.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 200)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Kondisi"
        '
        'txtKondisi
        '
        Me.txtKondisi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKondisi.DefaultText = ""
        Me.txtKondisi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtKondisi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtKondisi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtKondisi.DisabledState.Parent = Me.txtKondisi
        Me.txtKondisi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtKondisi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtKondisi.FocusedState.Parent = Me.txtKondisi
        Me.txtKondisi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtKondisi.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtKondisi.HoverState.Parent = Me.txtKondisi
        Me.txtKondisi.Location = New System.Drawing.Point(135, 200)
        Me.txtKondisi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtKondisi.Name = "txtKondisi"
        Me.txtKondisi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKondisi.PlaceholderText = ""
        Me.txtKondisi.SelectedText = ""
        Me.txtKondisi.ShadowDecoration.Parent = Me.txtKondisi
        Me.txtKondisi.Size = New System.Drawing.Size(213, 23)
        Me.txtKondisi.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 157)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Jumlah"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 115)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nama Barang"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'HeaderMenu
        '
        Me.HeaderMenu.Controls.Add(Me.btnExit)
        Me.HeaderMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.HeaderMenu.Location = New System.Drawing.Point(0, 0)
        Me.HeaderMenu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.HeaderMenu.Name = "HeaderMenu"
        Me.HeaderMenu.ShadowDecoration.Parent = Me.HeaderMenu
        Me.HeaderMenu.Size = New System.Drawing.Size(484, 50)
        Me.HeaderMenu.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.CheckedState.Parent = Me.btnExit
        Me.btnExit.CustomImages.Parent = Me.btnExit
        Me.btnExit.FillColor = System.Drawing.Color.Red
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.HoverState.Parent = Me.btnExit
        Me.btnExit.Location = New System.Drawing.Point(424, 0)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.ShadowDecoration.Parent = Me.btnExit
        Me.btnExit.Size = New System.Drawing.Size(58, 48)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "X"
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
        Me.txtJumlah.Location = New System.Drawing.Point(135, 157)
        Me.txtJumlah.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJumlah.PlaceholderText = ""
        Me.txtJumlah.SelectedText = ""
        Me.txtJumlah.ShadowDecoration.Parent = Me.txtJumlah
        Me.txtJumlah.Size = New System.Drawing.Size(213, 23)
        Me.txtJumlah.TabIndex = 2
        '
        'MenuPanel
        '
        Me.MenuPanel.Controls.Add(Me.Label5)
        Me.MenuPanel.Controls.Add(Me.btnEdit)
        Me.MenuPanel.Controls.Add(Me.Label4)
        Me.MenuPanel.Controls.Add(Me.txtKdInventaris)
        Me.MenuPanel.Controls.Add(Me.Label3)
        Me.MenuPanel.Controls.Add(Me.txtKondisi)
        Me.MenuPanel.Controls.Add(Me.Label2)
        Me.MenuPanel.Controls.Add(Me.Label1)
        Me.MenuPanel.Controls.Add(Me.txtJumlah)
        Me.MenuPanel.Controls.Add(Me.txtNmBarang)
        Me.MenuPanel.Controls.Add(Me.HeaderMenu)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuPanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.ShadowDecoration.Parent = Me.MenuPanel
        Me.MenuPanel.Size = New System.Drawing.Size(484, 450)
        Me.MenuPanel.TabIndex = 3
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
        Me.txtNmBarang.Location = New System.Drawing.Point(135, 115)
        Me.txtNmBarang.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNmBarang.Name = "txtNmBarang"
        Me.txtNmBarang.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNmBarang.PlaceholderText = ""
        Me.txtNmBarang.SelectedText = ""
        Me.txtNmBarang.ShadowDecoration.Parent = Me.txtNmBarang
        Me.txtNmBarang.Size = New System.Drawing.Size(213, 23)
        Me.txtNmBarang.TabIndex = 1
        '
        'Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 450)
        Me.Controls.Add(Me.MenuPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Edit"
        Me.Text = "Form6"
        Me.HeaderMenu.ResumeLayout(False)
        Me.MenuPanel.ResumeLayout(False)
        Me.MenuPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtKdInventaris As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKondisi As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents HeaderMenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtJumlah As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents MenuPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtNmBarang As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnExit As Guna.UI2.WinForms.Guna2Button
End Class
