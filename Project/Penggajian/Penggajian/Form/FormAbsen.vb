Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class FormAbsen
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

    Sub idabsenOtomatis()
        dt.Clear()
        sql = "SELECT *FROM absen ORDER BY id_absen desc"
        cmd.Connection = conn.Koneksi
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, "idOtomatis")
        conn.KoneksiGagal()
        dt = ds.Tables("idOtomatis")
        Dim absen As String
        If dt.Rows.Count = 0 Then
            tidabsen.Text = Format(Now, "yyMMdd") + "0001"
        Else
            With dt.Rows(0)
                tidabsen.Text = .Item("id_absen")
            End With
            absen = Val(Microsoft.VisualBasic.Right(tidabsen.Text, 4)) + 1
            tidabsen.Text = Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & absen, 4)
        End If
        conn.KoneksiGagal()
    End Sub
    Sub kosong()
        tidabsen.Text = ""
        dtptgl.Text = ""
    End Sub
    Sub tidakaktif()
        tidabsen.Enabled = False
        dtptgl.Enabled = False
    End Sub
    Private Sub bimport_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bimport.Click
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
            If tidabsen.Text = "" Or dtptgl.Text = "" Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Information, "INFORMASI")
            Else
                sql = "SELECT *FROM absen WHERE month(tglabsen)='" & Month(dtptgl.Value) & "' AND year(tglabsen)='" & Year(dtptgl.Value) & "'"
                conn.KoneksiGagal()
                cmd.CommandText = sql
                cmd.Connection = conn.Koneksi
                dr = cmd.ExecuteReader
                dr.Read()
                If Not dr.HasRows Then
                    'simpan absen
                    sql = "INSERT INTO absen VALUES('" & tidabsen.Text & "','" & Format(dtptgl.Value, "yyyy-MM-dd") & "')"
                    conn.KoneksiGagal()
                    cmd.CommandText = sql
                    cmd.Connection = conn.Koneksi
                    cmd.ExecuteNonQuery()
                    conn.KoneksiGagal()
                    'simpan detail_absen
                    For i As Integer = 0 To DGV.RowCount - 2
                        sql = "INSERT INTO detail_absen(id_absen,nik,nmkaryawan,masuk,sakit,izin,alfa,ot_reguler,ot_libur_hari,ot_libur_jam)VALUES('" & tidabsen.Text & _
                            "','" & DGV.Rows(i).Cells(0).Value & _
                            "','" & DGV.Rows(i).Cells(1).Value & _
                            "','" & DGV.Rows(i).Cells(2).Value & _
                            "','" & DGV.Rows(i).Cells(3).Value & _
                            "','" & DGV.Rows(i).Cells(4).Value & _
                            "','" & DGV.Rows(i).Cells(5).Value & _
                            "','" & DGV.Rows(i).Cells(6).Value & _
                            "','" & DGV.Rows(i).Cells(7).Value & _
                            "','" & DGV.Rows(i).Cells(8).Value & "')"
                        conn.KoneksiGagal()
                        cmd.CommandText = sql
                        cmd.Connection = conn.Koneksi
                        cmd.ExecuteNonQuery()
                        conn.KoneksiGagal()
                    Next
                    MsgBox("Data Berhasil diSimpan", MsgBoxStyle.Information, "INFORMASI")
                    DGV.Columns.Clear()
                    Call kosong()
                Else
                    MsgBox("Data absen bulan ini sudah di-input", MsgBoxStyle.Information, "INFORMASI")
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub FormAbsen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tidakaktif()
    End Sub

    Private Sub bbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbatal.Click
        Call kosong()
        DGV.Columns.Clear()
    End Sub

    Private Sub bbaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbaru.Click
        Call idabsenOtomatis()
        dtptgl.Text = Today
    End Sub
End Class