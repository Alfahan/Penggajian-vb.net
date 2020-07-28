﻿Imports System.Data
Imports System.Data.SqlClient
Public Class ListPendapatanGaji
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
        sql = "SELECT * FROM pendapatan"
        cmd.Connection = conn.Koneksi
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, "pendapatan")
        conn.KoneksiGagal()
        dt = ds.Tables("pendapatan")
        DGV.DataSource = dt
        DGV.ReadOnly = True
        DGV.Refresh()
        conn.KoneksiGagal()
    End Sub
    Private Sub ListPendapatanGaji_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampilgrid()
    End Sub

    Private Sub tcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcari.TextChanged
        Try
            dt.Clear()
            sql = "SELECT * FROM pendapatan WHERE nmpendapatan like '%" & tcari.Text & "%' OR id_pendapatan like '%" & tcari.Text & "%' "
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
    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        Dim row As String() = New String() {DGV.Rows(e.RowIndex).Cells(0).Value, DGV.Rows(e.RowIndex).Cells(1).Value, DGV.Rows(e.RowIndex).Cells(2).Value, 1, 1 * DGV.Rows(e.RowIndex).Cells(2).Value}
        FormGaji.DGVPendapatan.Rows.Add(row)

        For i As Integer = 0 To FormGaji.DGVPendapatan.RowCount - 1
            For j As Integer = i + 1 To FormGaji.DGVPendapatan.RowCount - 1
                If FormGaji.DGVPendapatan.Rows(i).Cells(0).Value = FormGaji.DGVPendapatan.Rows(j).Cells(0).Value Then
                    MsgBox("Pendapatan " & FormGaji.DGVPendapatan.Rows(i).Cells(0).Value & "Sudah di Entry", MsgBoxStyle.Information, "INFORMASI")
                    SendKeys.Send("{up}")
                    FormGaji.DGVPendapatan.Rows(j).Cells(0).Value = ""
                    FormGaji.DGVPendapatan.Rows(j).Cells(1).Value = ""
                    FormGaji.DGVPendapatan.Rows(j).Cells(2).Value = ""
                    FormGaji.DGVPendapatan.Rows.RemoveAt(j)
                    Exit Sub
                End If

            Next
        Next
    End Sub

End Class