Imports System.Data.Odbc

Module Koneksi
    Public conn As OdbcConnection
    Public DA As OdbcDataAdapter
    Public DR As OdbcDataReader
    Public DS As DataSet
    Public DT As DataTable
    Public CMD As OdbcCommand

    Sub BukaDB()
        Try
            conn = New OdbcConnection("DSN=invenApp;MultipleActiveResultSets=True")
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi Gagal", vbExclamation, "Gagal koneksi ke server")
            BukaDB()
        End Try
    End Sub

    Sub RunQuery(ByVal sql As String)
        Dim objcmd As New OdbcCommand
        Try
            objcmd.Connection = conn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = sql
            objcmd.ExecuteNonQuery()
            objcmd.Dispose()

        Catch ex As Exception
            MsgBox("Tidak Bisa diproses " & sql)

        End Try
    End Sub
End Module
