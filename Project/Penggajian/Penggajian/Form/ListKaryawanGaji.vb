Imports System.Data
Imports System.Data.SqlClient
Public Class ListKaryawanGaji
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
        sql = "SELECT nik,nmkaryawan,id_dept,id_jab FROM karyawan"
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
    Private Sub ListKaryawanGaji_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampilgrid()
    End Sub

    Private Sub tcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcari.TextChanged
        Try
            dt.Clear()
            sql = "SELECT nik,nmkaryawan,id_dept,id_jab FROM karyawan WHERE nik like '%" & tcari.Text & "%' OR nmkaryawan like '%" & tcari.Text & "%'"
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
            FormGaji.tnik.Text = row.Cells(0).Value.ToString
            FormGaji.tnama.Text = row.Cells(1).Value.ToString
            FormGaji.tdept.Text = row.Cells(2).Value.ToString
            FormGaji.tjab.Text = row.Cells(3).Value.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class