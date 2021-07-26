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



    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If tableHistory.RowCount > 0 Then
            'Deklarasi Object
            Dim ApExcel As Object

            'Set sebagai excel  object
            ApExcel = CreateObject("Excel.application")

            'Menyembunyikan proses excel
            ApExcel.Visible = False

            'Membuat/menambah workbook baru
            ApExcel.Workbooks.Add()

            'Lebar Kolom
            ApExcel.Columns(1).ColumnWidth = 15
            ApExcel.Columns(2).ColumnWidth = 20

            'Tulis nama kolom ke excel
            For i As Integer = 1 To tableHistory.Columns.Count
                ApExcel.Cells(1, i).Value = tableHistory.Columns(i - 1).Name
            Next

            'Tulis data ke excel
            For r = 0 To tableHistory.RowCount - 1
                For i As Integer = 1 To tableHistory.Columns.Count
                    ApExcel.Cells(r + 2, i).Value = tableHistory.Rows(r).Cells(i - 1).Value
                Next
            Next

            'Membuat Font Bold
            ApExcel.Range("A1:J1").Font.Bold = True

            'Memberi warna backgound
            ApExcel.Range("A1:J1").interior.colorindex = 36

            'Agar nilai cell yang panjang menjadi beberapa baris
            ApExcel.Range("A2:J" & tableHistory.RowCount + 1).WrapText = True

            'Membuat border hitam
            ApExcel.Range("A1:J" & tableHistory.RowCount + 1).Borders.Color = RGB(0, 0, 0)

            ApExcel.Visible = True

            ApExcel = Nothing
        End If
    End Sub
End Class