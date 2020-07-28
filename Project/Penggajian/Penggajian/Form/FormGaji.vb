Imports System.Data
Imports System.Data.SqlClient
Public Class FormGaji
    'koneksi ke server
    Dim conn As New KoneksiServer.Class1
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cmd As New SqlCommand
    Dim dt As New DataTable
    Dim dr As SqlDataReader
    Dim sql As String
    Sub noslipOtomatis()
        dt.Clear()
        sql = "SELECT *FROM gaji ORDER BY noslip desc"
        cmd.Connection = conn.Koneksi
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, "noslipOtomatis")
        conn.KoneksiGagal()
        dt = ds.Tables("noslipOtomatis")
        Dim noslip As String
        If dt.Rows.Count = 0 Then
            tnoslip.Text = Format(Now, "yyMMdd") + "0001"
        Else
            With dt.Rows(0)
                tnoslip.Text = .Item("noslip")
            End With
            noslip = Val(Microsoft.VisualBasic.Right(tnoslip.Text, 4)) + 1
            tnoslip.Text = Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & noslip, 4)
        End If
        conn.KoneksiGagal()
    End Sub
    Sub kosong()
        tnoslip.Text = ""
        tnik.Text = ""
        tnama.Text = ""
        tdept.Text = ""
        tdept.Enabled = False
        tnmdept.Text = ""
        tjab.Text = ""
        tjab.Enabled = False
        tnmjab.Text = ""
        tmasuk.Text = ""
        tizin.Text = ""
        tsakit.Text = ""
        talfa.Text = ""
        totreguler.Text = ""
        totliburhari.Text = ""
        totliburjam.Text = ""
        DGVPendapatan.Rows.Clear()
        DGVPendapatan.Refresh()

        DGVPotongan.Rows.Clear()
        DGVPotongan.Refresh()

        ttotalpendapatan.Text = ""
        ttotalpotongan.Text = ""

        ttotal.Text = ""
        tpenghasilanbruto.Text = ""
        tpphsetahun.Text = ""
        tpphsebulan.Text = ""
        tgajiditerima.Text = ""
    End Sub
    Sub tidakaktif()
        tnoslip.Enabled = False
        tnama.Enabled = False
        tdept.Enabled = False
        tnmdept.Enabled = False
        tjab.Enabled = False
        tnmjab.Enabled = False

        ttgl.Enabled = False

        tmasuk.Enabled = False
        tsakit.Enabled = False
        tizin.Enabled = False
        talfa.Enabled = False
        totreguler.Enabled = False
        totliburhari.Enabled = False
        totliburjam.Enabled = False
    End Sub
    
    Private Sub FormGaji_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tidakaktif()
        ttgl.Text = Today
    End Sub

    Private Sub tnik_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tnik.KeyPress
        If e.KeyChar = Chr(13) Then
            sql = "SELECT *FROM karyawan WHERE nik='" & tnik.Text & "'"
            conn.KoneksiGagal()
            cmd.CommandText = sql
            cmd.Connection = conn.Koneksi
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                On Error Resume Next
                tnik.Text = dr.Item("nik")
                tnama.Text = dr.Item("nmkaryawan")
                tdept.Text = dr.Item("id_dept")
                tjab.Text = dr.Item("id_jab")
                tdept.Enabled = True
                tdept.Focus()
            Else
                MsgBox("Data tidak terdaftar", MsgBoxStyle.Information, "INFORMASI")
                tnik.Focus()
            End If
            conn.KoneksiGagal()
        End If
    End Sub

    Private Sub tdept_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdept.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim departemen As String = "SELECT *FROM departemen WHERE id_dept = '" & tdept.Text & "'"
            cmd.Connection = conn.Koneksi()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = departemen
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                tnmdept.Text = dr.Item("nmdept")
                tjab.Enabled = True
                tjab.Focus()
            Else
                MsgBox("Id Dept Tidak Terdaftar", MsgBoxStyle.Information, "INFORMASI")
            End If
            conn.KoneksiGagal()
        End If
    End Sub

    Private Sub tjab_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tjab.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim jabatan As String = "SELECT *FROM jabatan WHERE id_jab = '" & tjab.Text & "'"
            cmd.Connection = conn.Koneksi()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = jabatan
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                tnmjab.Text = dr.Item("nmjab")
                '
            Else
                MsgBox("Id Jabatan Tidak Terdaftar", MsgBoxStyle.Information, "INFORMASI")
            End If
            conn.KoneksiGagal()
        End If
    End Sub

    Private Sub tjab_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tjab.TextChanged
        
    End Sub

   
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListKaryawanGaji.Show()
    End Sub

    Private Sub bbaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbaru.Click
        Call noslipOtomatis()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListAbsenGaji.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListPendapatanGaji.Show()
    End Sub
    Sub totalpendapatan()
        Dim hitung As Integer = 0
        For baris As Integer = 0 To DGVPendapatan.RowCount - 1
            hitung = hitung + DGVPendapatan.Rows(baris).Cells(4).Value
            ttotalpendapatan.Text = hitung
        Next
    End Sub
    Private Sub DGVPendapatan_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVPendapatan.CellEndEdit
        If e.ColumnIndex = 3 Then
            Try
                DGVPendapatan.Rows(e.RowIndex).Cells(4).Value = DGVPendapatan.Rows(e.RowIndex).Cells(2).Value * DGVPendapatan.Rows(e.RowIndex).Cells(3).Value
                Call totalpendapatan()
            Catch ex As Exception
                MsgBox("Harus Angka", MsgBoxStyle.Information, "INFORMASI")
                SendKeys.Send("{up}")
                DGVPendapatan.Rows(e.RowIndex).Cells(3).Value = 1
                DGVPendapatan.Rows(e.RowIndex).Cells(4).Value = DGVPendapatan.Rows(e.RowIndex).Cells(2).Value * DGVPendapatan.Rows(e.RowIndex).Cells(3).Value
                Call totalpendapatan()
            End Try
        End If
    End Sub
    Sub totalpotongan()
        Dim hitung As Integer = 0
        For baris As Integer = 0 To DGVPotongan.RowCount - 1
            hitung = hitung + DGVPotongan.Rows(baris).Cells(4).Value
            ttotalpotongan.Text = hitung
        Next
    End Sub
    Sub pajak()
        Dim hitung As Integer = 0
        hitung = Val(ttotalpendapatan.Text) - Val(ttotalpotongan.Text)
        ttotal.Text = hitung

        Dim penghasilanbruto As Integer = 0
        penghasilanbruto = Val(ttotal.Text) * 12
        tpenghasilanbruto.Text = penghasilanbruto

        Dim wp As Integer = 54000000
        Dim pajak As Integer = 0
        pajak = penghasilanbruto - wp

        If pajak > 0 Then
            Dim pph21setahun As Integer = 0
            pph21setahun = pajak * 5 / 100
            tpphsetahun.Text = pph21setahun

            Dim pph21sebulan As Integer = 0
            pph21sebulan = pph21setahun / 12
            tpphsebulan.Text = pph21sebulan
        Else
            tpphsetahun.Text = 0
            tpphsebulan.Text = 0
        End If

        Dim gajiterima As Integer = 0
        gajiterima = Val(ttotal.Text) - Val(tpphsebulan.Text)
        tgajiditerima.Text = gajiterima

    End Sub

    Private Sub DGVPotongan_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVPotongan.CellEndEdit
        If e.ColumnIndex = 3 Then
            Try
                DGVPotongan.Rows(e.RowIndex).Cells(4).Value = DGVPotongan.Rows(e.RowIndex).Cells(2).Value * DGVPotongan.Rows(e.RowIndex).Cells(3).Value
                Call totalpotongan()
            Catch ex As Exception
                MsgBox("Harus Angka", MsgBoxStyle.Information, "INFORMASI")
                SendKeys.Send("{up}")
                DGVPotongan.Rows(e.RowIndex).Cells(3).Value = 1
                DGVPotongan.Rows(e.RowIndex).Cells(4).Value = DGVPotongan.Rows(e.RowIndex).Cells(2).Value * DGVPotongan.Rows(e.RowIndex).Cells(3).Value
                Call totalpotongan()
            End Try
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListPotonganGaji.Show()
    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Call pajak()
    End Sub

    Private Sub bsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsimpan.Click
        If tnoslip.Text = "" Or tnik.Text = "" Or tnama.Text = "" Or tdept.Text = "" Or tnmdept.Text = "" Or tjab.Text = "" Or tnmjab.Text = "" Or tmasuk.Text = "" Or tsakit.Text = "" Or tizin.Text = "" Or talfa.Text = "" Or totreguler.Text = "" Or totliburhari.Text = "" Or totliburjam.Text = "" Or ttotalpendapatan.Text = "" Or ttotalpotongan.Text = "" Or ttotal.Text = "" Or tpenghasilanbruto.Text = "" Or tpphsetahun.Text = "" Or tpphsebulan.Text = "" Or tgajiditerima.Text = "" Then
            MsgBox("Maaf data belum Lengkap", MsgBoxStyle.Information, "INFORMASI")
        Else
            sql = "SELECT *FROM gaji WHERE nik = '" & tnik.Text & "' AND month(tglgaji)='" & Month(ttgl.Text) & "' AND year(tglgaji)='" & Year(ttgl.Text) & "'"
            conn.KoneksiGagal()
            cmd.CommandText = sql
            cmd.Connection = conn.Koneksi
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                'Simpan ke Table Gaji
                sql = "INSERT INTO gaji(noslip,nik,pajak,tglgaji,totalpendapatan,totalpotongan,totalterima)VALUES('" & tnoslip.Text & _
                    "','" & tnik.Text & _
                    "','" & tpphsebulan.Text & _
                    "','" & ttgl.Text & _
                    "','" & ttotalpendapatan.Text & _
                    "','" & ttotalpotongan.Text & _
                    "','" & tgajiditerima.Text & "')"
                conn.KoneksiGagal()
                cmd.CommandText = sql
                cmd.Connection = conn.Koneksi
                cmd.ExecuteNonQuery()
                conn.KoneksiGagal()

                'simpan ke Detail_Gaji 
                For i As Integer = 0 To DGVPendapatan.Rows.Count - 2
                    sql = "INSERT detail_gaji(noslip,id_pendapatan,nmpendapatan,jumlah_pendapatan)VALUES('" & tnoslip.Text & _
                        "','" & DGVPendapatan.Rows(i).Cells(0).Value & _
                        "','" & DGVPendapatan.Rows(i).Cells(1).Value & _
                        "','" & DGVPendapatan.Rows(i).Cells(4).Value & "')"
                    conn.KoneksiGagal()
                    cmd.CommandText = sql
                    cmd.Connection = conn.Koneksi
                    cmd.ExecuteNonQuery()
                    conn.KoneksiGagal()
                Next

                For i As Integer = 0 To DGVPotongan.Rows.Count - 2
                    sql = "INSERT detail_gaji(noslip,id_potongan,nmpotongan,jumlah_potongan)VALUES('" & tnoslip.Text & _
                        "','" & DGVPotongan.Rows(i).Cells(0).Value & _
                        "','" & DGVPotongan.Rows(i).Cells(1).Value & _
                        "','" & DGVPotongan.Rows(i).Cells(4).Value & "')"
                    conn.KoneksiGagal()
                    cmd.CommandText = sql
                    cmd.Connection = conn.Koneksi
                    cmd.ExecuteNonQuery()
                    conn.KoneksiGagal()
                Next
                MsgBox("Data Gaji Berhasil di Simpan", MsgBoxStyle.Information, "INFORMASI")
                CetakGaji.CrystalReportViewer1.SelectionFormula = "{gaji.noslip} like '" & tnoslip.Text & "' "
                CetakGaji.CrystalReportViewer1.RefreshReport()
                CetakGaji.Show()
                Call kosong()
            Else
                MsgBox("Karyawan tersebut Bulan ini sudah Gajian", MsgBoxStyle.Information, "INFORMASI")
                Call kosong()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub bbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbatal.Click
        Call kosong()
    End Sub


    Private Sub DGVPendapatan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DGVPendapatan.KeyPress
        On Error Resume Next
        If e.KeyChar = Chr(27) Then
            DGVPendapatan.Rows.Remove(DGVPendapatan.CurrentRow)
            Call totalpendapatan()
        End If
    End Sub

    Private Sub DGVPotongan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DGVPotongan.KeyPress
        On Error Resume Next
        If e.KeyChar = Chr(27) Then
            DGVPendapatan.Rows.Remove(DGVPendapatan.CurrentRow)
            Call totalpendapatan()
        End If
    End Sub
End Class