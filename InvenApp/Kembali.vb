Public Class Kembali
    Private Sub List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BukaDB()
        isiGrid()
        setHeader()
    End Sub
    Sub isiGrid()
        Try
            DA = New Odbc.OdbcDataAdapter("SELECT * FROM `tb_pinjam`where status='belum kembali'", conn)
            DS = New DataSet
            DA.Fill(DS)
            tableKembali.DataSource = DS.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Sub setHeader()
        tableKembali.Columns(1).HeaderText = "Nama Barang"
        tableKembali.Columns(2).HeaderText = "Jumlah"
        tableKembali.Columns(3).HeaderText = "Kode abrang"
        tableKembali.Columns(4).HeaderText = "Kondisi"

        tableKembali.Columns(1).Width = 90
        tableKembali.Columns(2).Width = 120
        tableKembali.Columns(3).Width = 110
        tableKembali.Columns(4).Width = 110
    End Sub
End Class