Public Class Parent

    Dim slideButt As String = "close"

    Private Sub SlidingButt_Click(sender As Object, e As EventArgs) Handles SlidingButt.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If slideButt = "open" Then
            SlidingPanel.Width += 25
            If SlidingPanel.Width >= 250 Then
                Timer1.Stop()
                slideButt = "close"
            End If
        Else
            SlidingPanel.Width -= 25
            If SlidingPanel.Width <= 50 Then
                Timer1.Stop()
                slideButt = "open"
            End If
        End If
    End Sub


    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        Tambah.Close()
        List.Close()
        History.Close()
        Pinjam.Close()

        Kembali.TopLevel = False
        MenuPanel.Controls.Add(Kembali)
        Kembali.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        History.Close()
        List.Close()
        Kembali.Close()
        Pinjam.Close()

        Tambah.TopLevel = False
        MenuPanel.Controls.Add(Tambah)
        Tambah.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        Tambah.Close()
        List.Close()
        Kembali.Close()
        History.Close()

        Pinjam.TopLevel = False
        MenuPanel.Controls.Add(Pinjam)
        Pinjam.Show()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles btnLihat.Click
        Tambah.Close()
        History.Close()
        Kembali.Close()
        Pinjam.Close()
        List.TopLevel = False
        MenuPanel.Controls.Add(List)
        List.Show()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Tambah.Close()
        List.Close()
        Kembali.Close()
        Pinjam.Close()
        History.TopLevel = False
        MenuPanel.Controls.Add(History)
        History.Show()
    End Sub
End Class
