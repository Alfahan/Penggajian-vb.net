Imports System.Data
Imports System.Data.SqlClient
Public Class FormJabatan
    'koneksi ke server
    Dim conn As New KoneksiServer.Class1
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cmd As New SqlCommand
    Dim dt As New DataTable
    Dim dr As SqlDataReader
    Dim sql As String
    'membuat method id_otomatis
    Sub idjabOtomatis()
        dt.Clear()
        sql = "SELECT *FROM jabatan ORDER BY id_jab desc"
        cmd.Connection = conn.Koneksi
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, "idOtomatis")
        conn.KoneksiGagal()
        dt = ds.Tables("idOtomatis")
        Dim idjab As String
        If dt.Rows.Count = 0 Then
            tidjab.Text = "JAB0000001"
        Else
            With dt.Rows(0)
                tidjab.Text = .Item("id_jab")
            End With
            idjab = Val(Microsoft.VisualBasic.Right(tidjab.Text, 5)) + 1
            tidjab.Text = Microsoft.VisualBasic.Left(tidjab.Text, Len(tidjab.Text) - Len(idjab)) & idjab
        End If
        conn.KoneksiGagal()
    End Sub
    'membuat method kosongkan
    Sub kosongkan()
        tidjab.Text = ""
        tnamajab.Text = ""
    End Sub

    'membuat method tidakaktif
    Sub tidakaktif()
        tidjab.Enabled = False
        tnamajab.Enabled = False
    End Sub

    'membuat method aktif
    Sub aktif()
        tidjab.Enabled = True
        tnamajab.Enabled = True

        tidjab.MaxLength = 10
        tnamajab.MaxLength = 30
    End Sub

    'membuat method ketemu data 
    Sub ketemu()
        On Error Resume Next
        tidjab.Text = dr.Item("id_jab")
        tnamajab.Text = dr.Item("nmjab")

        conn.KoneksiGagal()
    End Sub

    'membuat method tampilgrid
    Sub tampilgrid()
        dt.Clear()
        sql = "SELECT *FROM jabatan"
        cmd.Connection = conn.Koneksi
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, "jabatan")
        conn.KoneksiGagal()
        dt = ds.Tables("jabatan")
        DGV.DataSource = dt
        DGV.ReadOnly = True
        DGV.Columns(0).Width = 150
        DGV.Columns(0).HeaderText = "ID Jabatan"
        DGV.Columns(1).Width = 280
        DGV.Columns(1).HeaderText = "Nama Jabatan"
        DGV.Refresh()
        conn.KoneksiGagal()
    End Sub

    'membuat method CariKode
    Sub CariKode()
        sql = "SELECT *FROM jabatan WHERE id_jab='" & tidjab.Text & "'"
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
    Private Sub Formjabatan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub tidjab_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tidjab.KeyPress
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
        Call idjabOtomatis()
        Call aktif()
        Call tampilgrid()
    End Sub

    Private Sub tcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcari.TextChanged
        Try
            dt.Clear()
            sql = "SELECT *FROM jabatan WHERE id_jab like '%" & tcari.Text & "%' OR nmjab like '%" & tcari.Text & "%'"
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
            If tidjab.Text = "" Or tnamajab.Text = "" Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Information, "INFORMASI")
            Else
                Call CariKode()
                If Not dr.HasRows Then
                    Dim simpan As String = "INSERT INTO jabatan VALUES('" & tidjab.Text & "','" & tnamajab.Text & "')"
                    conn.KoneksiGagal()
                    cmd.CommandText = simpan
                    cmd.Connection = conn.Koneksi
                    cmd.ExecuteNonQuery()
                    conn.KoneksiGagal()
                    Call KondisiAwal()
                    Call tidakaktif()
                    MsgBox("Data Berhasil DiSimpan", MsgBoxStyle.Information, "INFORMASI")
                Else
                    Dim edit As String = "UPDATE jabatan set nmjab='" & tnamajab.Text & "' WHERE id_jab='" & tidjab.Text & "'"
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
        If tidjab.Text = "" Then
            MsgBox("Id harus di-Isi", MsgBoxStyle.Information, "INFORMASI")
            tidjab.Focus()
            Exit Sub
        End If

        Call CariKode()
        If Not dr.HasRows Then
            MsgBox("Id tidak terdaftar", MsgBoxStyle.Information, "INFORMASI")
            tidjab.Focus()
            Exit Sub
        End If

        If MsgBox("Yakin Data akan diHapus..?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim hapus As String = "DELETE FROM jabatan WHERE id_jab = '" & tidjab.Text & "'"
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
        CetakJabatan.CrystalReportViewer1.RefreshReport()
        CetakJabatan.Show()
    End Sub
End Class