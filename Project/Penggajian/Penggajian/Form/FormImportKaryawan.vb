Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class FormImportKaryawan
    'koneksi ke server
    Dim conn As New KoneksiServer.Class1
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cmd As New SqlCommand
    Dim dt As New DataTable
    Dim dr As SqlDataReader
    Dim sql As String

    Dim connexcel As OleDbConnection
    Dim daexcel As OleDbDataAdapter
    Dim dsexcel As New DataSet
    Private Sub bimport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bimport.Click
        Try
            OpenFileDialog1.Filter = "(*.xlsx)|*.xlsx|(*.xls)|*.xls|All files (*.*)|*.*"
            OpenFileDialog1.ShowDialog()

            connexcel = New OleDbConnection("provider=Microsoft.JET.OLEDB.4.0;" & _
                        "data source='" & OpenFileDialog1.FileName & "';Extended Properties=Excel 8.0;")

            daexcel = New OleDbDataAdapter("SELECT * FROM [Sheet1$]", connexcel)
            connexcel.Open()
            dsexcel.Clear()
            daexcel.Fill(dsexcel)
            DGV.DataSource = dsexcel.Tables(0)
            DGV.ReadOnly = True
            connexcel.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub bsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsimpan.Click
        Try
            'simpan detail_absen
            For i As Integer = 0 To DGV.RowCount - 2
                sql = "INSERT INTO karyawan(nik,nmkaryawan,templahir,tgllahir,notelp,alamat,pendidikan,npwp,email,status_karyawan,tglgabung,id_dept,id_jab)VALUES('" & DGV.Rows(i).Cells(0).Value & _
                    "','" & DGV.Rows(i).Cells(1).Value & _
                    "','" & DGV.Rows(i).Cells(2).Value & _
                    "','" & DGV.Rows(i).Cells(3).Value & _
                    "','" & DGV.Rows(i).Cells(4).Value & _
                    "','" & DGV.Rows(i).Cells(5).Value & _
                    "','" & DGV.Rows(i).Cells(6).Value & _
                    "','" & DGV.Rows(i).Cells(7).Value & _
                    "','" & DGV.Rows(i).Cells(8).Value & _
                    "','" & DGV.Rows(i).Cells(9).Value & _
                    "','" & DGV.Rows(i).Cells(10).Value & _
                    "','" & DGV.Rows(i).Cells(11).Value & _
                    "','" & DGV.Rows(i).Cells(12).Value & "')"
                conn.KoneksiGagal()
                cmd.CommandText = sql
                cmd.Connection = conn.Koneksi
                cmd.ExecuteNonQuery()
                conn.KoneksiGagal()
            Next
            MsgBox("Data Berhasil diSimpan", MsgBoxStyle.Information, "INFORMASI")
            DGV.Columns.Clear()
            
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

    End Sub
End Class