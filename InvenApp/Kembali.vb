
Public Class Kembali
    Dim jum, a, b As Integer

    Private Sub Kembali_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BukaDB()

        isiGrid()

    End Sub





    Private Sub txtPeminjam_TextChanged(sender As Object, e As EventArgs) Handles txtPeminjam.TextChanged
        Try
            DA = New Odbc.OdbcDataAdapter("SELECT * FROM `tb_pinjam` where status = 'belum kembali' AND nama_peminjam LIKE '%" & txtPeminjam.Text & "%'", conn)
            DS = New DataSet
            DA.Fill(DS)
            DGV.DataSource = DS.Tables(0)
        Catch ex As Exception
            MsgBox(e.ToString)
        End Try

    End Sub
    Sub isiGrid()
        Try
            DA = New Odbc.OdbcDataAdapter("SELECT * FROM `tb_pinjam` where status = 'belum kembali'", conn)
            DS = New DataSet
            DA.Fill(DS)
            DGV.DataSource = DS.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub
    Sub isitextbox(ByVal x As Integer)

        txtname.Text = DGV.Rows(x).Cells(0).Value
        txtjum.Text = DGV.Rows(x).Cells(3).Value
    End Sub

    Sub clear()
        txtJumlah.Clear()
        txtname.Clear()
        txtPeminjam.Clear()
        txtPeminjam.Focus()



    End Sub

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged

    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        isitextbox(e.RowIndex)
    End Sub

    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        Try
            CMD = New Odbc.OdbcCommand("SELECT * FROM tb_pinjam WHERE id_pinjam = '" & txtname.Text & "' AND jumlah = '" & txtJumlah.Text & "'", conn)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                Dim tgl = Format(dateKembali.Value, "yyyy-MM-dd hh:mm")
                RunQuery("UPDATE `tb_pinjam` SET `status`='kembali', `tgl_kembali` = '" & tgl & "' WHERE id_pinjam = '" & txtname.Text & "'")
                MsgBox("Data Berhasil di simpan", vbInformation, "Simpan")
                isiGrid()
                clear()

            Else

                a = txtjum.Text
                b = txtJumlah.Text
                jum = a - b
                txtk.Text = jum


                RunQuery("UPDATE `tb_pinjam` SET `jumlah`='" & txtk.Text & "' WHERE id_pinjam = '" & txtname.Text & "'")
                MsgBox("Data Berhasil di simpan", vbInformation, "Simpan")
                isiGrid()
                clear()


            End If

        Catch ex As Exception

        End Try
    End Sub
End Class