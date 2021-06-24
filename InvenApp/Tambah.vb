Imports System.Data.Odbc
Public Class Tambah
    Sub tampil_data()
        DA = New OdbcDataAdapter("SELECT * FROM tb_barang", conn)
        DS = New DataSet
        DA.Fill(DS)
    End Sub

    Sub bersihkan()
        txtNmBarang.Clear()
        txtJumlah.Clear()
        txtKondisi.Clear()
        txtKdInventaris.Clear()

        txtNmBarang.Focus()
    End Sub

    Private Sub MenuPanel_Paint(sender As Object, e As PaintEventArgs) Handles MenuPanel.Paint
        Call BukaDB()
        Call tampil_data()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Try
            If txtNmBarang.Text = "" Then
                MsgBox("Nama Barang tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txtJumlah.Text = "" Then
                MsgBox("Jumlah tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txtKdInventaris.Text = "" Then
                MsgBox("Kondisi tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txtKondisi.Text = "" Then
                MsgBox("Kode Inventaris tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub

            Else
                CMD = New OdbcCommand("SELECT * FROM tb_barang WHERE id_brg = '" & "'", conn)
                DR = CMD.ExecuteReader
                DR.Read()
                If Not DR.HasRows Then
                    Dim simpan As String = "INSERT INTO tb_barang (id_brg,nama_barang,jumlah,kd_barang,kondisi) 
                            VALUE ('" & "','" _
                                  & txtNmBarang.Text & "','" _
                                  & txtJumlah.Text & "','" _
                                  & txtKdInventaris.Text & "','" _
                                  & txtKondisi.Text & "')"
                    CMD = New OdbcCommand(simpan, conn)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data Berhasil di simpan", vbInformation, "Simpan")
                    Call tampil_data()
                    Call bersihkan()
                Else
                    MsgBox("Data Sudah Ada")

                End If
            End If

        Catch ex As Exception
            MsgBox("Terdapat Kesalahan" & ex.Message)
        End Try
    End Sub

End Class