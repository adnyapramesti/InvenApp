Public Class List
    Public id, jum, a As Integer
    Public nam, kon, kd As String

    Private Sub List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BukaDB()
        isiGrid()
        setHeader()
        btnEdit.Enabled = False
        btnHapus.Enabled = False


    End Sub


    Sub isiGrid()
        Try
            DA = New Odbc.OdbcDataAdapter("SELECT * FROM `tb_barang`", conn)
            DS = New DataSet
            DA.Fill(DS)
            tbListBarang.DataSource = DS.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub tbListBarang_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles tbListBarang.CellMouseClick
        passData(e.RowIndex)
        btnEdit.Enabled = True
        btnHapus.Enabled = True
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus?", "Caption", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                RunQuery("DELETE FROM tb_barang WHERE id_brg = '" & id & "'")
                a = 1

                BukaDB()
                isiGrid()


            Catch ex As Exception
                MessageBox.Show("Data Gagal Dihapus")
            End Try
            If a = 1 Then
                MessageBox.Show("Data Berhasil Dihapus")
            End If
        End If
            If result = DialogResult.No Then

            btnEdit.Enabled = False
            btnHapus.Enabled = False

        End If
    End Sub

    Sub setHeader()
        tbListBarang.Columns(1).HeaderText = "Nama Barang"
        tbListBarang.Columns(2).HeaderText = "Jumlah"
        tbListBarang.Columns(3).HeaderText = "Kode abrang"
        tbListBarang.Columns(4).HeaderText = "Kondisi"

        tbListBarang.Columns(1).Width = 90
        tbListBarang.Columns(2).Width = 120
        tbListBarang.Columns(3).Width = 110
        tbListBarang.Columns(4).Width = 110
    End Sub
    Public Sub passData(ByVal x As Integer)
        id = tbListBarang.Rows(x).Cells(0).Value
        nam = tbListBarang.Rows(x).Cells(1).Value
        jum = tbListBarang.Rows(x).Cells(2).Value
        kd = tbListBarang.Rows(x).Cells(3).Value
        kon = tbListBarang.Rows(x).Cells(4).Value

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        Edit.Show()
    End Sub
End Class