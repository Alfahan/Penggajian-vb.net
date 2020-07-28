Imports System.Data
Imports System.Data.SqlClient
Public Class FormKaryawan
    'koneksi ke server
    Dim conn As New KoneksiServer.Class1
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cmd As New SqlCommand
    Dim dt As New DataTable
    Dim dr As SqlDataReader
    Dim sql As String
    'membuat method nik_otomatis
    Sub nikOtomatis()
        dt.Clear()
        sql = "SELECT *FROM karyawan ORDER BY nik desc"
        cmd.Connection = conn.Koneksi
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, "idOtomatis")
        conn.KoneksiGagal()
        dt = ds.Tables("idOtomatis")
        Dim karyawan As String
        If dt.Rows.Count = 0 Then
            tnik.Text = Format(Today, "yyMMdd") + "0001"
        Else
            With dt.Rows(0)
                tnik.Text = .Item("nik")
            End With
            karyawan = Val(Microsoft.VisualBasic.Right(tnik.Text, 4)) + 1
            tnik.Text = Format(Today, "yyMMdd") + Microsoft.VisualBasic.Right("000" & karyawan, 4)

        End If
        conn.KoneksiGagal()
    End Sub
    'membuat method tampil dept
    Sub tampildept()
        Dim deptcomb As String = "SELECT id_dept from departemen"
        cmd.Connection = conn.Koneksi()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = deptcomb
        dr = cmd.ExecuteReader
        cdept.Items.Clear()
        Do While dr.Read
            cdept.Items.Add(dr.Item("id_dept"))
        Loop
        conn.KoneksiGagal()
    End Sub
    'membuat method tampil jabatan
    Sub tampiljab()
        Dim deptcomb As String = "SELECT id_jab from jabatan"
        cmd.Connection = conn.Koneksi()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = deptcomb
        dr = cmd.ExecuteReader
        cjab.Items.Clear()
        Do While dr.Read
            cjab.Items.Add(dr.Item("id_jab"))
        Loop
        conn.KoneksiGagal()
    End Sub
    'membuat method isi combobox pendidikan
    Sub listpendidikan()
        cpendidikan.Items.Add("SD")
        cpendidikan.Items.Add("SMP")
        cpendidikan.Items.Add("SMA/SMK")
        cpendidikan.Items.Add("D3")
        cpendidikan.Items.Add("S1")
        cpendidikan.Items.Add("S2")
    End Sub
    'membuat method isi combobox status
    Sub liststatus()
        cstatus.Items.Add("Tetap")
        cstatus.Items.Add("Kontrak")
        cstatus.Items.Add("Harian")
        cstatus.Items.Add("Magang")
    End Sub

    'membuat method kosongkan
    Sub kosongkan()
        tnik.Text = ""
        tnama.Text = ""
        ttempatlahir.Text = ""
        dtplahir.Value = Today
        ttelp.Text = ""
        talamat.Text = ""
        cpendidikan.Text = ""
        tnpwp.Text = ""
        temail.Text = ""
        cstatus.Text = ""
        dtpgabung.Text = ""
        'cdept.Text = ""
        tnamadept.Text = ""
        'cjab.Text = ""
        tjab.Text = ""
    End Sub

    'membuat method tidakaktif
    Sub tidakaktif()

        tnik.Enabled = False
        tnama.Enabled = False
        ttempatlahir.Enabled = False
        dtplahir.Enabled = False
        ttelp.Enabled = False
        talamat.Enabled = False
        cpendidikan.Enabled = False
        tnpwp.Enabled = False
        temail.Enabled = False
        cstatus.Enabled = False
        dtpgabung.Enabled = False
        cdept.Enabled = False
        tnamadept.Enabled = False
        cjab.Enabled = False
        tjab.Enabled = False
    End Sub

    'membuat method aktif
    Sub aktif()
        tnik.Enabled = True
        tnama.Enabled = True
        ttempatlahir.Enabled = True
        dtplahir.Enabled = True
        ttelp.Enabled = True
        talamat.Enabled = True
        cpendidikan.Enabled = True
        tnpwp.Enabled = True
        temail.Enabled = True
        cstatus.Enabled = True
        dtpgabung.Enabled = True
        cdept.Enabled = True
        cjab.Enabled = True

        tnik.MaxLength = 10
        tnama.MaxLength = 30
        ttempatlahir.MaxLength = 30
        ttelp.MaxLength = 13
        tnpwp.MaxLength = 20
        temail.MaxLength = 50

    End Sub

    'membuat method ketemu data 
    Sub ketemu()
        On Error Resume Next
        tnik.Text = dr.Item("nik")
        tnama.Text = dr.Item("nmkaryawan")
        ttempatlahir.Text = dr.Item("templahir")
        dtplahir.Text = dr.Item("tgllahir")
        ttelp.Text = dr.Item("notelp")
        talamat.Text = dr.Item("alamat")
        cpendidikan.Text = dr.Item("pendidikan")
        tnpwp.Text = dr.Item("npwp")
        temail.Text = dr.Item("email")
        cstatus.Text = dr.Item("status_karyawan")
        dtpgabung.Text = dr.Item("tglgabung")
        cdept.Text = dr.Item("id_dept")
        cjab.Text = dr.Item("id_jab")

        conn.KoneksiGagal()
    End Sub

    'membuat method tampilgrid
    Sub tampilgrid()
        dt.Clear()
        sql = "SELECT *FROM karyawan"
        cmd.Connection = conn.Koneksi
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, "karyawan")
        conn.KoneksiGagal()
        dt = ds.Tables("karyawan")
        DGV.DataSource = dt
        DGV.ReadOnly = True
        DGV.Refresh()
        conn.KoneksiGagal()
    End Sub

    'membuat method CariKode
    Sub CariKode()
        sql = "SELECT *FROM karyawan WHERE nik='" & tnik.Text & "'"
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
    Private Sub Formkaryawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call listpendidikan()
        Call liststatus()
        Call tampildept()
        Call tampiljab()
    End Sub

    Private Sub tnik_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tnik.KeyPress
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
        Call nikOtomatis()
        Call aktif()
        Call tampilgrid()
    End Sub

    Private Sub tcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcari.TextChanged
        Try
            dt.Clear()
            sql = "SELECT *FROM karyawan WHERE nik like '%" & tcari.Text & "%' OR nmkaryawan like '%" & tcari.Text & "%'"
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
            If tnik.Text = "" Or tnama.Text = "" Or ttempatlahir.Text = "" Or dtplahir.Text = "" Or ttelp.Text = "" Or talamat.Text = "" Or cpendidikan.Text = "" Or tnpwp.Text = "" Or temail.Text = "" Or cstatus.Text = "" Or dtpgabung.Text = "" Or cdept.Text = "" Or cjab.Text = "" Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Information, "INFORMASI")
            Else
                Call CariKode()
                If Not dr.HasRows Then
                    Dim simpan As String = "INSERT INTO karyawan VALUES('" & tnik.Text & "','" & tnama.Text & "','" & ttempatlahir.Text & "','" & Format(dtplahir.Value, "yyyy-MM-dd") & "','" & ttelp.Text & "','" & talamat.Text & "','" & cpendidikan.Text & "','" & tnpwp.Text & "','" & temail.Text & "','" & cstatus.Text & "','" & Format(dtpgabung.Value, "yyyy-MM-dd") & "','" & cdept.Text & "','" & cjab.Text & "')"
                    conn.KoneksiGagal()
                    cmd.CommandText = simpan
                    cmd.Connection = conn.Koneksi
                    cmd.ExecuteNonQuery()
                    conn.KoneksiGagal()
                    Call KondisiAwal()
                    Call tidakaktif()
                    MsgBox("Data Berhasil DiSimpan", MsgBoxStyle.Information, "INFORMASI")
                Else
                    Dim edit As String = "UPDATE karyawan set nmkaryawan='" & tnama.Text & "', templahir='" & ttempatlahir.Text & "',tgllahir='" & Format(dtplahir.Value, "yyyy-MM-dd") & "',notelp ='" & ttelp.Text & "',alamat ='" & talamat.Text & "',pendidikan ='" & cpendidikan.Text & "',npwp ='" & tnpwp.Text & "',email ='" & temail.Text & "',status_karyawan ='" & cstatus.Text & "',tglgabung ='" & Format(dtpgabung.Value, "yyyy-MM-dd") & "',id_dept ='" & cdept.Text & "',id_jab ='" & cjab.Text & "' WHERE nik='" & tnik.Text & "'"
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
        If tnik.Text = "" Then
            MsgBox("Id harus di-Isi", MsgBoxStyle.Information, "INFORMASI")
            tnik.Focus()
            Exit Sub
        End If

        Call CariKode()
        If Not dr.HasRows Then
            MsgBox("Id tidak terdaftar", MsgBoxStyle.Information, "INFORMASI")
            tnik.Focus()
            Exit Sub
        End If

        If MsgBox("Yakin Data akan diHapus..?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim hapus As String = "DELETE FROM karyawan WHERE nik = '" & tnik.Text & "'"
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

    Private Sub cdept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cdept.SelectedIndexChanged
        Dim departemen As String = "SELECT *FROM departemen WHERE id_dept = '" & cdept.Text & "'"
        cmd.Connection = conn.Koneksi()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = departemen
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            tnamadept.Text = dr.Item("nmdept")
        Else
            MsgBox("Id Dept Tidak Terdaftar", MsgBoxStyle.Information, "INFORMASI")
        End If
        conn.KoneksiGagal()
    End Sub

    Private Sub cjab_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cjab.SelectedIndexChanged
        Dim jabatan As String = "SELECT *FROM jabatan WHERE id_jab = '" & cjab.Text & "'"
        cmd.Connection = conn.Koneksi()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = jabatan
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            tjab.Text = dr.Item("nmjab")
        Else
            MsgBox("Id Jabatan Tidak Terdaftar", MsgBoxStyle.Information, "INFORMASI")
        End If
        conn.KoneksiGagal()
    End Sub

    Private Sub bprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bprint.Click
        CetakKaryawan.CrystalReportViewer1.RefreshReport()
        CetakKaryawan.Show()
    End Sub

    Private Sub bimport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bimport.Click
        FormImportKaryawan.Show()
    End Sub
End Class