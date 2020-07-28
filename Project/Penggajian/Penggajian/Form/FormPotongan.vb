Imports System.Data
Imports System.Data.SqlClient
Public Class FormPotongan
    'koneksi ke server
    Dim conn As New KoneksiServer.Class1
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cmd As New SqlCommand
    Dim dt As New DataTable
    Dim dr As SqlDataReader
    Dim sql As String
    'membuat method id_otomatis
    Sub idpotonganOtomatis()
        dt.Clear()
        sql = "SELECT *FROM potongan ORDER BY id_potongan desc"
        cmd.Connection = conn.Koneksi
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, "idOtomatis")
        conn.KoneksiGagal()
        dt = ds.Tables("idOtomatis")
        Dim idpotongan As String
        If dt.Rows.Count = 0 Then
            tidpotongan.Text = "POT0000001"
        Else
            With dt.Rows(0)
                tidpotongan.Text = .Item("id_potongan")
            End With
            idpotongan = Val(Microsoft.VisualBasic.Right(tidpotongan.Text, 5)) + 1
            tidpotongan.Text = Microsoft.VisualBasic.Left(tidpotongan.Text, Len(tidpotongan.Text) - Len(idpotongan)) & idpotongan
        End If
        conn.KoneksiGagal()
    End Sub
    'membuat method kosongkan
    Sub kosongkan()
        tidpotongan.Text = ""
        tnamapotongan.Text = ""
        tjumlah.Text = ""
    End Sub

    'membuat method tidakaktif
    Sub tidakaktif()
        tidpotongan.Enabled = False
        tnamapotongan.Enabled = False
        tjumlah.Enabled = False
    End Sub

    'membuat method aktif
    Sub aktif()
        tidpotongan.Enabled = True
        tnamapotongan.Enabled = True
        tjumlah.Enabled = True

        tidpotongan.MaxLength = 10
        tnamapotongan.MaxLength = 30
    End Sub

    'membuat method ketemu data 
    Sub ketemu()
        On Error Resume Next
        tidpotongan.Text = dr.Item("id_potongan")
        tnamapotongan.Text = dr.Item("nmpotongan")
        tjumlah.Text = dr.Item("jumlah")

        conn.KoneksiGagal()
    End Sub

    'membuat method tampilgrid
    Sub tampilgrid()
        dt.Clear()
        sql = "SELECT *FROM potongan"
        cmd.Connection = conn.Koneksi
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, "potongan")
        conn.KoneksiGagal()
        dt = ds.Tables("potongan")
        DGV.DataSource = dt
        DGV.ReadOnly = True
        DGV.Columns(0).Width = 100
        DGV.Columns(0).HeaderText = "ID potongan"
        DGV.Columns(1).Width = 250
        DGV.Columns(1).HeaderText = "Nama potongan"
        DGV.Columns(2).Width = 100
        DGV.Columns(2).HeaderText = "Jumlah"
        DGV.Refresh()
        conn.KoneksiGagal()
    End Sub

    'membuat method CariKode
    Sub CariKode()
        sql = "SELECT *FROM potongan WHERE id_potongan='" & tidpotongan.Text & "'"
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
    Private Sub Formpotongan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub tidpotongan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tidpotongan.KeyPress
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
        Call idpotonganOtomatis()
        Call aktif()
        Call tampilgrid()
    End Sub

    Private Sub tcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcari.TextChanged
        Try
            dt.Clear()
            sql = "SELECT *FROM potongan WHERE id_potongan like '%" & tcari.Text & "%' OR nmpotongan like '%" & tcari.Text & "%'"
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
            If tidpotongan.Text = "" Or tnamapotongan.Text = "" Or tjumlah.Text = "" Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Information, "INFORMASI")
            Else
                Call CariKode()
                If Not dr.HasRows Then
                    Dim simpan As String = "INSERT INTO potongan VALUES('" & tidpotongan.Text & "','" & tnamapotongan.Text & "','" & Val(tjumlah.Text) & "')"
                    conn.KoneksiGagal()
                    cmd.CommandText = simpan
                    cmd.Connection = conn.Koneksi
                    cmd.ExecuteNonQuery()
                    conn.KoneksiGagal()
                    Call KondisiAwal()
                    Call tidakaktif()
                    MsgBox("Data Berhasil DiSimpan", MsgBoxStyle.Information, "INFORMASI")
                Else
                    Dim edit As String = "UPDATE potongan set nmpotongan='" & tnamapotongan.Text & "', jumlah='" & Val(tjumlah.Text) & "' WHERE id_potongan='" & tidpotongan.Text & "'"
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
        If tidpotongan.Text = "" Then
            MsgBox("Id harus di-Isi", MsgBoxStyle.Information, "INFORMASI")
            tidpotongan.Focus()
            Exit Sub
        End If

        Call CariKode()
        If Not dr.HasRows Then
            MsgBox("Id tidak terdaftar", MsgBoxStyle.Information, "INFORMASI")
            tidpotongan.Focus()
            Exit Sub
        End If

        If MsgBox("Yakin Data akan diHapus..?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim hapus As String = "DELETE FROM potongan WHERE id_potongan = '" & tidpotongan.Text & "'"
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
        CetakPotongan.CrystalReportViewer1.RefreshReport()
        CetakPotongan.Show()
    End Sub

End Class