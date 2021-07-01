Public Class History
    Private Sub List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BukaDB()
        isiGrid()
    End Sub
    Sub isiGrid()
        Try
            DA = New Odbc.OdbcDataAdapter("SELECT * FROM `tb_pinjam`", conn)
            DS = New DataSet
            DA.Fill(DS)
            tableHistory.DataSource = DS.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tableHistory.CellContentClick

    End Sub

    Private Sub txtPeminjam_TextChanged(sender As Object, e As EventArgs) Handles txtPeminjam.TextChanged
        Try
            DA = New Odbc.OdbcDataAdapter("SELECT * FROM `tb_pinjam` WHERE CONCAT_WS(id_pinjam nama_peminjam, jumlah,id_barang,instansi,kontak,) LIKE '%" & txtPeminjam.Text & "%' ", conn)
            DS = New DataSet
            DA.Fill(DS)
            tableHistory.DataSource = DS.Tables(0)
        Catch ex As Exception
            MsgBox(e.ToString)
        End Try
    End Sub
End Class