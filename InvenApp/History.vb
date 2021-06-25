Public Class History
    Private Sub List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BukaDB()
        isiGrid()
        setHeader()
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

    Sub setHeader()
        tableHistory.Columns(1).HeaderText = "Nama Barang"
        tableHistory.Columns(2).HeaderText = "Jumlah"
        tableHistory.Columns(3).HeaderText = "Kode abrang"
        tableHistory.Columns(4).HeaderText = "Kondisi"

        tableHistory.Columns(1).Width = 90
        tableHistory.Columns(2).Width = 120
        tableHistory.Columns(3).Width = 110
        tableHistory.Columns(4).Width = 110
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tableHistory.CellContentClick

    End Sub
End Class