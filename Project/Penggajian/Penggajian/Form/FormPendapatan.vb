Imports System.Data
Imports System.Data.SqlClient
Public Class FormPendapatan
    'koneksi ke server
    Dim conn As New KoneksiServer.Class1
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cmd As New SqlCommand
    Dim dt As New DataTable
    Dim dr As SqlDataReader
    Dim sql As String
    'membuat method id_otomatis
    Sub idpendapatanOtomatis()
        dt.Clear()
        sql = "SELECT *FROM pendapatan ORDER BY id_pendapatan desc"
        cmd.Connection = conn.Koneksi
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, "idOtomatis")
        conn.KoneksiGagal()
        dt = ds.Tables("idOtomatis")
        Dim idpendapatan As String
        If dt.Rows.Count = 0 Then
            tidpendapatan.Text = "PEN0000001"
        Else
            With dt.Rows(0)
                tidpendapatan.Text = .Item("id_pendapatan")
            End With
            idpendapatan = Val(Microsoft.VisualBasic.Right(tidpendapatan.Text, 5)) + 1
            tidpendapatan.Text = Microsoft.VisualBasic.Left(tidpendapatan.Text, Len(tidpendapatan.Text) - Len(idpendapatan)) & idpendapatan
        End If
        conn.KoneksiGagal()
    End Sub
    'membuat method kosongkan
    Sub kosongkan()
        tidpendapatan.Text = ""
        tnamapendapatan.Text = ""
        tjumlah.Text = ""
    End Sub

    'membuat method tidakaktif
    Sub tidakaktif()
        tidpendapatan.Enabled = False
        tnamapendapatan.Enabled = False
        tjumlah.Enabled = False
    End Sub

    'membuat method aktif
    Sub aktif()
        tidpendapatan.Enabled = True
        tnamapendapatan.Enabled = True
        tjumlah.Enabled = True

        tidpendapatan.MaxLength = 10
        tnamapendapatan.MaxLength = 30
    End Sub

    'membuat method ketemu data 
    Sub ketemu()
        On Error Resume Next
        tidpendapatan.Text = dr.Item("id_pendapatan")
        tnamapendapatan.Text = dr.Item("nmpendapatan")
        tjumlah.Text = dr.Item("jumlah")

        conn.KoneksiGagal()
    End Sub

    'membuat method tampilgrid
    Sub tampilgrid()
        dt.Clear()
        sql = "SELECT *FROM pendapatan"
        cmd.Connection = conn.Koneksi
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, "pendapatan")
        conn.KoneksiGagal()
        dt = ds.Tables("pendapatan")
        DGV.DataSource = dt
        DGV.ReadOnly = True
        DGV.Columns(0).Width = 100
        DGV.Columns(0).HeaderText = "ID pendapatan"
        DGV.Columns(1).Width = 250
        DGV.Columns(1).HeaderText = "Nama pendapatan"
        DGV.Columns(2).Width = 100
        DGV.Columns(2).HeaderText = "Jumlah"
        DGV.Refresh()
        conn.KoneksiGagal()
    End Sub

    'membuat method CariKode
    Sub CariKode()
        sql = "SELECT *FROM pendapatan WHERE id_pendapatan='" & tidpendapatan.Text & "'"
        conn.KoneksiGagal()
        cmd.CommandText = sql
        cmd.Connection = conn.Koneksi
        dr = cmd.ExecuteReader
        dr.Read()
    End Sub
    'membuat method Kondisi Awal
    Sub KondisiAwal()
        Call tampilgrid()
        Call kosongkan()
        Call tidakaktif()
    End Sub
    Private Sub Formpendapatan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub tidpendapatan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tidpendapatan.KeyPress
        If e.KeyChar = Chr(13) Then
            Call CariKode()
            If dr.HasRows Then
                Call ketemu()
                Call aktif()
            Else
                Call aktif()
            End If
        End If
    End Sub


    Private Sub bbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbatal.Click
        Call kosongkan()
        Call tidakaktif()
    End Sub

    Private Sub bbaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbaru.Click
        Call idpendapatanOtomatis()
        Call aktif()
        Call tampilgrid()
    End Sub

    Private Sub tcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcari.TextChanged
        Try
            dt.Clear()
            sql = "SELECT *FROM pendapatan WHERE id_pendapatan like '%" & tcari.Text & "%' OR nmpendapatan like '%" & tcari.Text & "%'"
            cmd.Connection = conn.Koneksi
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            da = New SqlDataAdapter(cmd)
            da.Fill(ds, "Cari")
            conn.KoneksiGagal()
            dt = ds.Tables("Cari")
            DGV.DataSource = dt
            DGV.ReadOnly = True
            DGV.Refresh()
            conn.KoneksiGagal()
        Catch ex As Exception
            'Kosongkan
        End Try
    End Sub

    Private Sub bsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsimpan.Click
        Try
            If tidpendapatan.Text = "" Or tnamapendapatan.Text = "" Or tjumlah.Text = "" Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Information, "INFORMASI")
            Else
                Call CariKode()
                If Not dr.HasRows Then
                    Dim simpan As String = "INSERT INTO pendapatan VALUES('" & tidpendapatan.Text & "','" & tnamapendapatan.Text & "','" & tjumlah.Text & "')"
                    conn.KoneksiGagal()
                    cmd.CommandText = simpan
                    cmd.Connection = conn.Koneksi
                    cmd.ExecuteNonQuery()
                    conn.KoneksiGagal()
                    Call KondisiAwal()
                    Call tidakaktif()
                    MsgBox("Data Berhasil DiSimpan", MsgBoxStyle.Information, "INFORMASI")
                Else
                    Dim edit As String = "UPDATE pendapatan set nmpendapatan='" & tnamapendapatan.Text & "', jumlah='" & tjumlah.Text & "' WHERE id_pendapatan='" & tidpendapatan.Text & "'"
                    conn.KoneksiGagal()
                    cmd.CommandText = edit
                    cmd.Connection = conn.Koneksi
                    cmd.ExecuteNonQuery()
                    conn.KoneksiGagal()
                    Call KondisiAwal()
                    Call tidakaktif()
                    MsgBox("Data Berhasil DiUpdate", MsgBoxStyle.Information, "INFORMASI")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Call kosongkan()
            Call tidakaktif()
        End Try
    End Sub

    Private Sub bhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bhapus.Click
        If tidpendapatan.Text = "" Then
            MsgBox("Id harus di-Isi", MsgBoxStyle.Information, "INFORMASI")
            tidpendapatan.Focus()
            Exit Sub
        End If

        Call CariKode()
        If Not dr.HasRows Then
            MsgBox("Id tidak terdaftar", MsgBoxStyle.Information, "INFORMASI")
            tidpendapatan.Focus()
            Exit Sub
        End If

        If MsgBox("Yakin Data akan diHapus..?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim hapus As String = "DELETE FROM pendapatan WHERE id_pendapatan = '" & tidpendapatan.Text & "'"
            conn.KoneksiGagal()
            cmd.CommandText = hapus
            cmd.Connection = conn.Koneksi
            cmd.ExecuteNonQuery()
            conn.KoneksiGagal()
            Call KondisiAwal()
        Else
            Call kosongkan()
        End If
    End Sub

    Private Sub bprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bprint.Click
        CetakPendapatan.CrystalReportViewer1.RefreshReport()
        CetakPendapatan.Show()
    End Sub
End Class