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
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
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
        Me.Label5.Location = New System.Drawing.Point(58, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(227, 40)
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
        Me.btnEdit.Location = New System.Drawing.Point(62, 446)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ShadowDecoration.Parent = Me.btnEdit
        Me.btnEdit.Size = New System.Drawing.Size(180, 45)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "Edit Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 371)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 20)
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
        Me.txtKdInventaris.Location = New System.Drawing.Point(202, 371)
        Me.txtKdInventaris.Name = "txtKdInventaris"
        Me.txtKdInventaris.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKdInventaris.PlaceholderText = ""
        Me.txtKdInventaris.SelectedText = ""
        Me.txtKdInventaris.ShadowDecoration.Parent = Me.txtKdInventaris
        Me.txtKdInventaris.Size = New System.Drawing.Size(320, 35)
        Me.txtKdInventaris.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 308)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
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
        Me.txtKondisi.Location = New System.Drawing.Point(202, 308)
        Me.txtKondisi.Name = "txtKondisi"
        Me.txtKondisi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKondisi.PlaceholderText = ""
        Me.txtKondisi.SelectedText = ""
        Me.txtKondisi.ShadowDecoration.Parent = Me.txtKondisi
        Me.txtKondisi.Size = New System.Drawing.Size(320, 35)
        Me.txtKondisi.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Jumlah"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nama Barang"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'HeaderMenu
        '
        Me.HeaderMenu.Controls.Add(Me.Guna2Button2)
        Me.HeaderMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.HeaderMenu.Location = New System.Drawing.Point(0, 0)
        Me.HeaderMenu.Name = "HeaderMenu"
        Me.HeaderMenu.ShadowDecoration.Parent = Me.HeaderMenu
        Me.HeaderMenu.Size = New System.Drawing.Size(726, 77)
        Me.HeaderMenu.TabIndex = 0
        '
        'Guna2Button2
        '
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.Red
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(669, 0)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(54, 45)
        Me.Guna2Button2.TabIndex = 14
        Me.Guna2Button2.Text = "X"
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
        Me.txtJumlah.Location = New System.Drawing.Point(202, 242)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJumlah.PlaceholderText = ""
        Me.txtJumlah.SelectedText = ""
        Me.txtJumlah.ShadowDecoration.Parent = Me.txtJumlah
        Me.txtJumlah.Size = New System.Drawing.Size(320, 35)
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
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.ShadowDecoration.Parent = Me.MenuPanel
        Me.MenuPanel.Size = New System.Drawing.Size(726, 692)
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
        Me.txtNmBarang.Location = New System.Drawing.Point(202, 177)
        Me.txtNmBarang.Name = "txtNmBarang"
        Me.txtNmBarang.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNmBarang.PlaceholderText = ""
        Me.txtNmBarang.SelectedText = ""
        Me.txtNmBarang.ShadowDecoration.Parent = Me.txtNmBarang
        Me.txtNmBarang.Size = New System.Drawing.Size(320, 35)
        Me.txtNmBarang.TabIndex = 1
        '
        'Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 692)
        Me.Controls.Add(Me.MenuPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
End Class
