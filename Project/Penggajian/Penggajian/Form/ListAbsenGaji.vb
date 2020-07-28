Imports System.Data
Imports System.Data.SqlClient
Public Class ListAbsenGaji
    'koneksi ke server
    Dim conn As New KoneksiServer.Class1
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cmd As New SqlCommand
    Dim dt As New DataTable
    Dim dr As SqlDataReader
    Dim sql As String
    Sub tampilgrid()
        dt.Clear()
        sql = "SELECT nik,nmkaryawan,masuk,sakit,izin,alfa,ot_reguler,ot_libur_hari,ot_libur_jam FROM detail_absen,absen where detail_absen.id_absen = absen.id_absen AND month(tglabsen) = '" & Month(dtptgl.Value) & "' AND year(tglabsen) = '" & Year(dtptgl.Value) & "'"
        cmd.Connection = conn.Koneksi
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, "detail_absen")
        conn.KoneksiGagal()
        dt = ds.Tables("detail_absen")
        DGV.DataSource = dt
        DGV.ReadOnly = True
        DGV.Refresh()
        conn.KoneksiGagal()
    End Sub
    Private Sub ListKaryawanGaji_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampilgrid()
    End Sub

    Private Sub tcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcari.TextChanged
        Try
            dt.Clear()
            sql = "SELECT nik,nmkaryawan,masuk,sakit,izin,alfa,ot_reguler,ot_libur_hari,ot_libur_jam FROM detail_absen,absen where detail_absen.id_absen = absen.id_absen AND month(tglabsen) = '" & Month(dtptgl.Value) & "' AND year(tglabsen) = '" & Year(dtptgl.Value) & "' AND nmkaryawan like '%" & tcari.Text & "%'"
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
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick
        Dim row As DataGridViewRow = DGV.CurrentRow
        Try
            If FormGaji.tnik.Text <> row.Cells(0).Value.ToString Then
                MsgBox("Ini bukan data Absen karyawan tersebut", MsgBoxStyle.Information, "INFORMASI")
            Else
                FormGaji.tmasuk.Text = row.Cells(2).Value.ToString
                FormGaji.tizin.Text = row.Cells(3).Value.ToString
                FormGaji.tsakit.Text = row.Cells(4).Value.ToString
                FormGaji.talfa.Text = row.Cells(5).Value.ToString
                FormGaji.totreguler.Text = row.Cells(6).Value.ToString
                FormGaji.totliburjam.Text = row.Cells(7).Value.ToString
                FormGaji.totliburhari.Text = row.Cells(8).Value.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class