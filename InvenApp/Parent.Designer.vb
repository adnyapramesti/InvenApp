<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Parent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Parent))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HeaderSliding = New Guna.UI2.WinForms.Guna2Panel()
        Me.SlidingButt = New System.Windows.Forms.Button()
        Me.SlidingPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnHistory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnkembali = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLihat = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPinjam = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTambah = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button7 = New Guna.UI2.WinForms.Guna2Button()
        Me.HeaderMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.MenuPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.HeaderSliding.SuspendLayout()
        Me.SlidingPanel.SuspendLayout()
        Me.MenuPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'HeaderSliding
        '
        Me.HeaderSliding.Controls.Add(Me.SlidingButt)
        Me.HeaderSliding.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderSliding.FillColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.HeaderSliding.Location = New System.Drawing.Point(0, 0)
        Me.HeaderSliding.Name = "HeaderSliding"
        Me.HeaderSliding.ShadowDecoration.Parent = Me.HeaderSliding
        Me.HeaderSliding.Size = New System.Drawing.Size(375, 77)
        Me.HeaderSliding.TabIndex = 0
        '
        'SlidingButt
        '
        Me.SlidingButt.BackColor = System.Drawing.Color.Transparent
        Me.SlidingButt.Dock = System.Windows.Forms.DockStyle.Right
        Me.SlidingButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SlidingButt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.SlidingButt.Image = CType(resources.GetObject("SlidingButt.Image"), System.Drawing.Image)
        Me.SlidingButt.Location = New System.Drawing.Point(300, 0)
        Me.SlidingButt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SlidingButt.Name = "SlidingButt"
        Me.SlidingButt.Size = New System.Drawing.Size(75, 77)
        Me.SlidingButt.TabIndex = 0
        Me.SlidingButt.UseVisualStyleBackColor = False
        '
        'SlidingPanel
        '
        Me.SlidingPanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SlidingPanel.Controls.Add(Me.btnHistory)
        Me.SlidingPanel.Controls.Add(Me.btnkembali)
        Me.SlidingPanel.Controls.Add(Me.btnLihat)
        Me.SlidingPanel.Controls.Add(Me.btnPinjam)
        Me.SlidingPanel.Controls.Add(Me.btnTambah)
        Me.SlidingPanel.Controls.Add(Me.Guna2Button7)
        Me.SlidingPanel.Controls.Add(Me.HeaderSliding)
        Me.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SlidingPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.SlidingPanel.Location = New System.Drawing.Point(0, 0)
        Me.SlidingPanel.Name = "SlidingPanel"
        Me.SlidingPanel.ShadowDecoration.Parent = Me.SlidingPanel
        Me.SlidingPanel.Size = New System.Drawing.Size(375, 769)
        Me.SlidingPanel.TabIndex = 0
        '
        'btnHistory
        '
        Me.btnHistory.CheckedState.Parent = Me.btnHistory
        Me.btnHistory.CustomImages.Parent = Me.btnHistory
        Me.btnHistory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnHistory.ForeColor = System.Drawing.Color.White
        Me.btnHistory.HoverState.Parent = Me.btnHistory
        Me.btnHistory.Location = New System.Drawing.Point(0, 409)
        Me.btnHistory.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.ShadowDecoration.Parent = Me.btnHistory
        Me.btnHistory.Size = New System.Drawing.Size(375, 72)
        Me.btnHistory.TabIndex = 12
        Me.btnHistory.Text = "Hitory Barang"
        '
        'btnkembali
        '
        Me.btnkembali.CheckedState.Parent = Me.btnkembali
        Me.btnkembali.CustomImages.Parent = Me.btnkembali
        Me.btnkembali.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnkembali.ForeColor = System.Drawing.Color.White
        Me.btnkembali.HoverState.Parent = Me.btnkembali
        Me.btnkembali.Location = New System.Drawing.Point(0, 329)
        Me.btnkembali.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.ShadowDecoration.Parent = Me.btnkembali
        Me.btnkembali.Size = New System.Drawing.Size(375, 72)
        Me.btnkembali.TabIndex = 11
        Me.btnkembali.Text = "Pengembalian Barang"
        '
        'btnLihat
        '
        Me.btnLihat.CheckedState.Parent = Me.btnLihat
        Me.btnLihat.CustomImages.Parent = Me.btnLihat
        Me.btnLihat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLihat.ForeColor = System.Drawing.Color.White
        Me.btnLihat.HoverState.Parent = Me.btnLihat
        Me.btnLihat.Location = New System.Drawing.Point(0, 251)
        Me.btnLihat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLihat.Name = "btnLihat"
        Me.btnLihat.ShadowDecoration.Parent = Me.btnLihat
        Me.btnLihat.Size = New System.Drawing.Size(375, 72)
        Me.btnLihat.TabIndex = 10
        Me.btnLihat.Text = "Lihat Barang"
        '
        'btnPinjam
        '
        Me.btnPinjam.CheckedState.Parent = Me.btnPinjam
        Me.btnPinjam.CustomImages.Parent = Me.btnPinjam
        Me.btnPinjam.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPinjam.ForeColor = System.Drawing.Color.White
        Me.btnPinjam.HoverState.Parent = Me.btnPinjam
        Me.btnPinjam.Location = New System.Drawing.Point(2, 172)
        Me.btnPinjam.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPinjam.Name = "btnPinjam"
        Me.btnPinjam.ShadowDecoration.Parent = Me.btnPinjam
        Me.btnPinjam.Size = New System.Drawing.Size(375, 72)
        Me.btnPinjam.TabIndex = 9
        Me.btnPinjam.Text = "Pinjam Barang"
        '
        'btnTambah
        '
        Me.btnTambah.CheckedState.Parent = Me.btnTambah
        Me.btnTambah.CustomImages.Parent = Me.btnTambah
        Me.btnTambah.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.HoverState.Parent = Me.btnTambah
        Me.btnTambah.Location = New System.Drawing.Point(0, 95)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.ShadowDecoration.Parent = Me.btnTambah
        Me.btnTambah.Size = New System.Drawing.Size(375, 72)
        Me.btnTambah.TabIndex = 8
        Me.btnTambah.Text = "Tambah Barang"
        '
        'Guna2Button7
        '
        Me.Guna2Button7.CheckedState.Parent = Me.Guna2Button7
        Me.Guna2Button7.CustomImages.Parent = Me.Guna2Button7
        Me.Guna2Button7.FillColor = System.Drawing.Color.Red
        Me.Guna2Button7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button7.ForeColor = System.Drawing.Color.White
        Me.Guna2Button7.HoverState.Parent = Me.Guna2Button7
        Me.Guna2Button7.Location = New System.Drawing.Point(0, 686)
        Me.Guna2Button7.Name = "Guna2Button7"
        Me.Guna2Button7.ShadowDecoration.Parent = Me.Guna2Button7
        Me.Guna2Button7.Size = New System.Drawing.Size(372, 66)
        Me.Guna2Button7.TabIndex = 7
        Me.Guna2Button7.Text = "EXIT"
        '
        'HeaderMenu
        '
        Me.HeaderMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.HeaderMenu.Location = New System.Drawing.Point(0, 0)
        Me.HeaderMenu.Name = "HeaderMenu"
        Me.HeaderMenu.ShadowDecoration.Parent = Me.HeaderMenu
        Me.HeaderMenu.Size = New System.Drawing.Size(983, 77)
        Me.HeaderMenu.TabIndex = 0
        '
        'MenuPanel
        '
        Me.MenuPanel.Controls.Add(Me.HeaderMenu)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuPanel.Location = New System.Drawing.Point(375, 0)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.ShadowDecoration.Parent = Me.MenuPanel
        Me.MenuPanel.Size = New System.Drawing.Size(983, 769)
        Me.MenuPanel.TabIndex = 1
        '
        'Parent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1358, 769)
        Me.Controls.Add(Me.MenuPanel)
        Me.Controls.Add(Me.SlidingPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "Parent"
        Me.Text = "Form1"
        Me.HeaderSliding.ResumeLayout(False)
        Me.SlidingPanel.ResumeLayout(False)
        Me.MenuPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents HeaderSliding As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents SlidingButt As Button
    Friend WithEvents SlidingPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button7 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHistory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnkembali As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLihat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPinjam As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTambah As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents HeaderMenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents MenuPanel As Guna.UI2.WinForms.Guna2Panel
End Class
