Public Class Pinjam

    Private Sub Pinjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
    Sub tampil()
        DA = New Odbc.OdbcDataAdapter("SELECT * FROM `tb_barang`", conn)
        DT = New DataTable
        DA.Fill(DT)

        ComboBox1.DataSource = DT
        ComboBox1.DisplayMember = "nama_barang"
        ComboBox1.ValueMember = "id_brg"
        ComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems

    End Sub
End Class