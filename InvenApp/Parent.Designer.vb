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
        Me.Guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
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
        Me.HeaderSliding.Margin = New System.Windows.Forms.Padding(2)
        Me.HeaderSliding.Name = "HeaderSliding"
        Me.HeaderSliding.ShadowDecoration.Parent = Me.HeaderSliding
        Me.HeaderSliding.Size = New System.Drawing.Size(250, 50)
        Me.HeaderSliding.TabIndex = 0
        '
        'SlidingButt
        '
        Me.SlidingButt.BackColor = System.Drawing.Color.Transparent
        Me.SlidingButt.Dock = System.Windows.Forms.DockStyle.Right
        Me.SlidingButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SlidingButt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.SlidingButt.Image = CType(resources.GetObject("SlidingButt.Image"), System.Drawing.Image)
        Me.SlidingButt.Location = New System.Drawing.Point(200, 0)
        Me.SlidingButt.Name = "SlidingButt"
        Me.SlidingButt.Size = New System.Drawing.Size(50, 50)
        Me.SlidingButt.TabIndex = 0
        Me.SlidingButt.UseVisualStyleBackColor = False
        '
        'SlidingPanel
        '
        Me.SlidingPanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SlidingPanel.Controls.Add(Me.Guna2Button6)
        Me.SlidingPanel.Controls.Add(Me.Guna2Button5)
        Me.SlidingPanel.Controls.Add(Me.Guna2Button4)
        Me.SlidingPanel.Controls.Add(Me.Guna2Button3)
        Me.SlidingPanel.Controls.Add(Me.Guna2Button2)
        Me.SlidingPanel.Controls.Add(Me.Guna2Button7)
        Me.SlidingPanel.Controls.Add(Me.HeaderSliding)
        Me.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SlidingPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.SlidingPanel.Location = New System.Drawing.Point(0, 0)
        Me.SlidingPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.SlidingPanel.Name = "SlidingPanel"
        Me.SlidingPanel.ShadowDecoration.Parent = Me.SlidingPanel
        Me.SlidingPanel.Size = New System.Drawing.Size(250, 500)
        Me.SlidingPanel.TabIndex = 0
        '
        'Guna2Button6
        '
        Me.Guna2Button6.CheckedState.Parent = Me.Guna2Button6
        Me.Guna2Button6.CustomImages.Parent = Me.Guna2Button6
        Me.Guna2Button6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button6.ForeColor = System.Drawing.Color.White
        Me.Guna2Button6.HoverState.Parent = Me.Guna2Button6
        Me.Guna2Button6.Location = New System.Drawing.Point(0, 266)
        Me.Guna2Button6.Name = "Guna2Button6"
        Me.Guna2Button6.ShadowDecoration.Parent = Me.Guna2Button6
        Me.Guna2Button6.Size = New System.Drawing.Size(250, 47)
        Me.Guna2Button6.TabIndex = 12
        Me.Guna2Button6.Text = "Hitory Barang"
        '
        'Guna2Button5
        '
        Me.Guna2Button5.CheckedState.Parent = Me.Guna2Button5
        Me.Guna2Button5.CustomImages.Parent = Me.Guna2Button5
        Me.Guna2Button5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button5.ForeColor = System.Drawing.Color.White
        Me.Guna2Button5.HoverState.Parent = Me.Guna2Button5
        Me.Guna2Button5.Location = New System.Drawing.Point(0, 214)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.ShadowDecoration.Parent = Me.Guna2Button5
        Me.Guna2Button5.Size = New System.Drawing.Size(250, 47)
        Me.Guna2Button5.TabIndex = 11
        Me.Guna2Button5.Text = "Pengembalian Barang"
        '
        'Guna2Button4
        '
        Me.Guna2Button4.CheckedState.Parent = Me.Guna2Button4
        Me.Guna2Button4.CustomImages.Parent = Me.Guna2Button4
        Me.Guna2Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.HoverState.Parent = Me.Guna2Button4
        Me.Guna2Button4.Location = New System.Drawing.Point(0, 163)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.ShadowDecoration.Parent = Me.Guna2Button4
        Me.Guna2Button4.Size = New System.Drawing.Size(250, 47)
        Me.Guna2Button4.TabIndex = 10
        Me.Guna2Button4.Text = "Lihat Barang"
        '
        'Guna2Button3
        '
        Me.Guna2Button3.CheckedState.Parent = Me.Guna2Button3
        Me.Guna2Button3.CustomImages.Parent = Me.Guna2Button3
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.HoverState.Parent = Me.Guna2Button3
        Me.Guna2Button3.Location = New System.Drawing.Point(1, 112)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.ShadowDecoration.Parent = Me.Guna2Button3
        Me.Guna2Button3.Size = New System.Drawing.Size(250, 47)
        Me.Guna2Button3.TabIndex = 9
        Me.Guna2Button3.Text = "Pinjam Barang"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(0, 62)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(250, 47)
        Me.Guna2Button2.TabIndex = 8
        Me.Guna2Button2.Text = "Tambah Barang"
        '
        'Guna2Button7
        '
        Me.Guna2Button7.CheckedState.Parent = Me.Guna2Button7
        Me.Guna2Button7.CustomImages.Parent = Me.Guna2Button7
        Me.Guna2Button7.FillColor = System.Drawing.Color.Red
        Me.Guna2Button7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button7.ForeColor = System.Drawing.Color.White
        Me.Guna2Button7.HoverState.Parent = Me.Guna2Button7
        Me.Guna2Button7.Location = New System.Drawing.Point(0, 446)
        Me.Guna2Button7.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Button7.Name = "Guna2Button7"
        Me.Guna2Button7.ShadowDecoration.Parent = Me.Guna2Button7
        Me.Guna2Button7.Size = New System.Drawing.Size(248, 43)
        Me.Guna2Button7.TabIndex = 7
        Me.Guna2Button7.Text = "EXIT"
        '
        'HeaderMenu
        '
        Me.HeaderMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.HeaderMenu.Location = New System.Drawing.Point(0, 0)
        Me.HeaderMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.HeaderMenu.Name = "HeaderMenu"
        Me.HeaderMenu.ShadowDecoration.Parent = Me.HeaderMenu
        Me.HeaderMenu.Size = New System.Drawing.Size(655, 50)
        Me.HeaderMenu.TabIndex = 0
        '
        'MenuPanel
        '
        Me.MenuPanel.Controls.Add(Me.HeaderMenu)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuPanel.Location = New System.Drawing.Point(250, 0)
        Me.MenuPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.ShadowDecoration.Parent = Me.MenuPanel
        Me.MenuPanel.Size = New System.Drawing.Size(655, 500)
        Me.MenuPanel.TabIndex = 1
        '
        'Parent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 500)
        Me.Controls.Add(Me.MenuPanel)
        Me.Controls.Add(Me.SlidingPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents HeaderMenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents MenuPanel As Guna.UI2.WinForms.Guna2Panel
End Class
