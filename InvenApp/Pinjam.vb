Imports System.Data.Odbc

Public Class Pinjam

    Private Sub Pinjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BukaDB()
        btnPinjam.Enabled = False
        isiGrid()

    End Sub

    Private Sub txtJumlh_KeyPress(ByVal sender As Object,
            ByVal e As System.Windows.Forms.KeyPressEventArgs) _
            Handles txtJumlah.KeyPress
        Select Case Microsoft.VisualBasic.Asc(e.KeyChar)
            Case Is < 32
            Case 46
                If InStr(txtJumlah.Text, ".") <> 0 Then e.Handled = True
            Case 48 To 57
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub tbListBaran_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles tbListBaran.CellMouseClick
        passData(e.RowIndex)
        btnPinjam.Enabled = True

    End Sub
    Public Sub passData(ByVal x As Integer)
        txtIdBrg.Text = tbListBaran.Rows(x).Cells(0).Value
    End Sub
    Sub isiGrid()
        Try
            DA = New Odbc.OdbcDataAdapter("SELECT * FROM `tb_barang`", conn)
            DS = New DataSet
            DA.Fill(DS)
            tbListBaran.DataSource = DS.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub
    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged
        Try
            DA = New Odbc.OdbcDataAdapter("SELECT * FROM `tb_barang` WHERE nama_barang LIKE '%" & txtNama.Text & "%' ", conn)
            DS = New DataSet
            DA.Fill(DS)
            tbListBaran.DataSource = DS.Tables(0)
        Catch ex As Exception
            MsgBox(e.ToString)
        End Try
    End Sub

    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        Try
            If txtPeminjam.Text = "" Then
                MsgBox("Nama Peminjam tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txtDivisi.Text = "" Then
                MsgBox("Instansi tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txtKontak.Text = "" Then
                MsgBox("Kontak tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txtJumlah.Text = "" Then
                MsgBox("Jumlah tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub

            Else
                CMD = New OdbcCommand("SELECT * FROM tb_barang WHERE id_brg = '" & txtIdBrg.Text & "' AND jumlah > '" & txtJumlah.Text & "'", conn)
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    Dim tgl = Format(dateKembali.Value, "yyyy-MM-dd hh:mm")
                    Dim simpan As String = "INSERT INTO tb_pinjam (nama_peminjam,jumlah,id_brg,instansi,kontak,tgl_pred_kembali) 
                            VALUE ('" _
                                  & txtPeminjam.Text & "','" _
                                  & txtJumlah.Text & "','" _
                                  & txtIdBrg.Text & "','" _
                                  & txtDivisi.Text & "','" _
                                  & txtKontak.Text & "','" _
                                  & tgl & "')"
                    CMD = New OdbcCommand(simpan, conn)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data Berhasil di simpan", vbInformation, "Simpan")

                Else
                    MsgBox("Jumlah Stok Kurang")

                End If
            End If

        Catch ex As Exception
            MsgBox("Terdapat Kesalahan" & ex.Message)
        End Try
    End Sub

    Sub clear()
        txtJumlah.Clear()
        txtNama.Clear()
        txtPeminjam.Clear()
        txtDivisi.Clear()
        txtKontak.Clear()
        txtIdBrg.Clear()


        txtNama.Focus()



    End Sub
End Class