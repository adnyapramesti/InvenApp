Public Class Edit
    Dim id, a As Integer

    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BukaDB()
        isitextbox()




    End Sub

    Sub isitextbox()
        id = List.id
        txtNmBarang.Text = List.nam
        txtJumlah.Text = List.jum
        txtKdInventaris.Text = List.kd
        txtKondisi.Text = List.kon

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        List.id = 0
        List.nam = ""
        List.jum = 0
        List.kd = ""
        List.kon = ""
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtNmBarang.Text = "" Then
            MsgBox("Nama tidak boleh kosong")
        ElseIf txtJumlah.Text = "" Then
            MsgBox("Jumlah tidak boleh kosong")
        ElseIf txtKondisi.Text = "" Then
            MsgBox("KOndisi tidak boleh kosong")
        ElseIf txtKdInventaris.Text = "" Then
            MsgBox("Kode Inventaris tidak boleh kosong")
        Else
            Try
                RunQuery("UPDATE `tb_barang` SET `nama_barang`='" & txtNmBarang.Text & "',`jumlah`='" & txtJumlah.Text & "',`kd_barang`='" & txtKdInventaris.Text & "',`kondisi`='" & txtKondisi.Text & "' WHERE id_brg = '" & id & "'")
                a = 1

                BukaDB()


            Catch ex As Exception
                a = 0
            End Try
        End If

        If a = 1 Then
            MsgBox("Data Berhasil Diubah")
            List.isiGrid()
            Me.Close()
        Else
            MsgBox("Data Gagal Diubah")
            List.isiGrid()
        End If

    End Sub
End Class