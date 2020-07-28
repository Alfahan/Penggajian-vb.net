Imports System.Data
Imports System.Data.SqlClient
Public Class FormDepartemen
    'koneksi ke server
    Dim conn As New KoneksiServer.Class1
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cmd As New SqlCommand
    Dim dt As New DataTable
    Dim dr As SqlDataReader
    Dim sql As String
    'membuat method id_otomatis
    Sub iddeptOtomatis()
        dt.Clear()
        sql = "SELECT *FROM departemen ORDER BY id_dept desc"
        cmd.Connection = conn.Koneksi
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, "idOtomatis")
        conn.KoneksiGagal()
        dt = ds.Tables("idOtomatis")
        Dim iddept As String
        If dt.Rows.Count = 0 Then
            tiddept.Text = "DEPT000001"
        Else
            With dt.Rows(0)
                tiddept.Text = .Item("id_dept")
            End With
            iddept = Val(Microsoft.VisualBasic.Right(tiddept.Text, 5)) + 1
            tiddept.Text = Microsoft.VisualBasic.Left(tiddept.Text, Len(tiddept.Text) - Len(iddept)) & iddept
        End If
        conn.KoneksiGagal()
    End Sub
    'membuat method kosongkan
    Sub kosongkan()
        tiddept.Text = ""
        tnamadept.Text = ""
    End Sub

    'membuat method tidakaktif
    Sub tidakaktif()
        tiddept.Enabled = False
        tnamadept.Enabled = False
    End Sub

    'membuat method aktif
    Sub aktif()
        tiddept.Enabled = True
        tnamadept.Enabled = True

        tiddept.MaxLength = 10
        tnamadept.MaxLength = 30
    End Sub

    'membuat method ketemu data 
    Sub ketemu()
        On Error Resume Next
        tiddept.Text = dr.Item("id_dept")
        tnamadept.Text = dr.Item("nmdept")

        conn.KoneksiGagal()
    End Sub

    'membuat method tampilgrid
    Sub tampilgrid()
        dt.Clear()
        sql = "SELECT *FROM departemen"
        cmd.Connection = conn.Koneksi
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, "departemen")
        conn.KoneksiGagal()
        dt = ds.Tables("departemen")
        DGV.DataSource = dt
        DGV.ReadOnly = True
        DGV.Columns(0).Width = 150
        DGV.Columns(0).HeaderText = "ID Departemen"
        DGV.Columns(1).Width = 280
        DGV.Columns(1).HeaderText = "Nama Departemen"
        DGV.Refresh()
        conn.KoneksiGagal()
    End Sub

    'membuat method CariKode
    Sub CariKode()
        sql = "SELECT *FROM departemen WHERE id_dept='" & tiddept.Text & "'"
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
    Private Sub FormDepartemen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub tiddept_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tiddept.KeyPress
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
        Call iddeptOtomatis()
        Call aktif()
        Call tampilgrid()
    End Sub

    Private Sub tcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcari.TextChanged
        Try
            dt.Clear()
            sql = "SELECT *FROM departemen WHERE id_dept like '%" & tcari.Text & "%' OR nmdept like '%" & tcari.Text & "%'"
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
            If tiddept.Text = "" Or tnamadept.Text = "" Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Information, "INFORMASI")
            Else
                Call CariKode()
                If Not dr.HasRows Then
                    Dim simpan As String = "INSERT INTO departemen VALUES('" & tiddept.Text & "','" & tnamadept.Text & "')"
                    conn.KoneksiGagal()
                    cmd.CommandText = simpan
                    cmd.Connection = conn.Koneksi
                    cmd.ExecuteNonQuery()
                    conn.KoneksiGagal()
                    Call KondisiAwal()
                    Call tidakaktif()
                    MsgBox("Data Berhasil DiSimpan", MsgBoxStyle.Information, "INFORMASI")
                Else
                    Dim edit As String = "UPDATE departemen set nmdept='" & tnamadept.Text & "' WHERE id_dept='" & tiddept.Text & "'"
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
        If tiddept.Text = "" Then
            MsgBox("Id harus di-Isi", MsgBoxStyle.Information, "INFORMASI")
            tiddept.Focus()
            Exit Sub
        End If

        Call CariKode()
        If Not dr.HasRows Then
            MsgBox("Id tidak terdaftar", MsgBoxStyle.Information, "INFORMASI")
            tiddept.Focus()
            Exit Sub
        End If

        If MsgBox("Yakin Data akan diHapus..?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim hapus As String = "DELETE FROM departemen WHERE id_dept = '" & tiddept.Text & "'"
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
        CetakDept.CrystalReportViewer1.RefreshReport()
        CetakDept.Show()
    End Sub
End Class