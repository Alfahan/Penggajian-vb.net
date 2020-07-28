Imports System.Data
Imports System.Data.SqlClient
Public Class Formuser
    Dim conn As New KoneksiServer.Class1
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cmd As New SqlCommand
    Dim dt As New DataTable
    Dim dr As SqlDataReader
    Dim sql As String
    Sub iduserOtomatis()
        dt.Clear()
        sql = "SELECT *FROM userr ORDER BY id_user desc"
        cmd.Connection = conn.Koneksi
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, "idOtomatis")
        conn.KoneksiGagal()
        dt = ds.Tables("idOtomatis")
        Dim iduser As String
        If dt.Rows.Count = 0 Then
            tiduser.Text = "USER000001"
        Else
            With dt.Rows(0)
                tiduser.Text = .Item("id_user")
            End With
            iduser = Val(Microsoft.VisualBasic.Right(tiduser.Text, 5)) + 1
            tiduser.Text = Microsoft.VisualBasic.Left(tiduser.Text, Len(tiduser.Text) - Len(iduser)) & iduser
        End If
        conn.KoneksiGagal()
    End Sub
    Sub kosongkan()
        tiduser.Text = ""
        tnama.Text = ""
        tpassword.Text = ""
        clevel.Text = ""
    End Sub
    Sub level()
        clevel.Items.Add("Administrator")
        clevel.Items.Add("Admin")
    End Sub
    Sub tidakaktif()
        tiduser.Enabled = False
        tnama.Enabled = False
        tpassword.Enabled = False
        clevel.Enabled = False
    End Sub
    Sub aktif()
        tiduser.Enabled = True
        tnama.Enabled = True
        tpassword.Enabled = True
        clevel.Enabled = True

        tiduser.MaxLength = 10
        tnama.MaxLength = 30
        tpassword.MaxLength = 12
        clevel.MaxLength = 15
    End Sub

    Sub ketemu()
        On Error Resume Next
        tiduser.Text = dr.Item("id_userr")
        tnama.Text = dr.Item("username")
        tpassword.Text = dr.Item("pass")
        clevel.Text = dr.Item("lvl")

        conn.KoneksiGagal()
    End Sub
    Sub TampilGrid()
        dt.Clear()
        sql = "SELECT *FROM userr"
        cmd.Connection = conn.Koneksi
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, "userr")
        conn.KoneksiGagal()
        dt = ds.Tables("userr")
        DGV.DataSource = dt
        DGV.ReadOnly = True
        DGV.Columns(0).Width = 80
        DGV.Columns(0).HeaderText = "ID User"
        DGV.Columns(1).Width = 150
        DGV.Columns(1).HeaderText = "Username"
        DGV.Columns(2).Width = 100
        DGV.Columns(2).HeaderText = "Password"
        DGV.Columns(3).Width = 100
        DGV.Columns(3).HeaderText = "Level"
        DGV.Refresh()
        conn.KoneksiGagal()
    End Sub
    Sub CariKode()
        sql = "SELECT *FROM userr WHERE id_user='" & tiduser.Text & "'"
        conn.KoneksiGagal()
        cmd.CommandText = sql
        cmd.Connection = conn.Koneksi
        dr = cmd.ExecuteReader
        dr.Read()
    End Sub

    Sub Kondisiawal()
        Call TampilGrid()
        Call kosongkan()
        Call tidakaktif()
    End Sub

    Private Sub FormSiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Kondisiawal()
        Call level()
    End Sub

    Private Sub tiduser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tiduser.KeyPress
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
        Call iduserOtomatis()
        Call aktif()
        Call TampilGrid()
    End Sub

    Private Sub bsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsimpan.Click
        Try
            If tiduser.Text = "" Or tnama.Text = "" Or tpassword.Text = "" Or clevel.Text = "" Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Information, "INFORMASI")
            Else
                Call CariKode()
                If Not dr.HasRows Then
                    Dim simpan As String = "INSERT INTO userr VALUES('" & tiduser.Text & "','" & tnama.Text & "','" & tpassword.Text & "','" & clevel.Text & "')"
                    conn.KoneksiGagal()
                    cmd.CommandText = simpan
                    cmd.Connection = conn.Koneksi
                    cmd.ExecuteNonQuery()
                    conn.KoneksiGagal()
                    Call Kondisiawal()
                    MsgBox("Data Berhasil DiSimpan", MsgBoxStyle.Information, "INFORMASI")
                Else
                    Dim edit As String = "UPDATE userr set username='" & tnama.Text & "',pass='" & tpassword.Text & "',lvl='" & clevel.Text & "'WHERE id_user='" & tiduser.Text & "'"
                    conn.KoneksiGagal()
                    cmd.CommandText = edit
                    cmd.Connection = conn.Koneksi
                    cmd.ExecuteNonQuery()
                    conn.KoneksiGagal()
                    Call Kondisiawal()
                    MsgBox("Data Berhasil DiUpdate", MsgBoxStyle.Information, "INFORMASI")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Call kosongkan()
        End Try
    End Sub

    Private Sub bhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bhapus.Click
        If tiduser.Text = "" Then
            MsgBox("Id harus di-Isi", MsgBoxStyle.Information, "INFORMASI")
            tiduser.Focus()
            Exit Sub
        End If

        Call CariKode()
        If Not dr.HasRows Then
            MsgBox("Id tidak terdaftar", MsgBoxStyle.Information, "INFORMASI")
            tiduser.Focus()
            Exit Sub
        End If

        If MsgBox("Yakin Data Buku akan diHapus..?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim hapus As String = "DELETE FROM userr WHERE id_user = '" & tiduser.Text & "'"
            conn.KoneksiGagal()
            cmd.CommandText = hapus
            cmd.Connection = conn.Koneksi
            cmd.ExecuteNonQuery()
            conn.KoneksiGagal()
            Call Kondisiawal()
        Else
            Call kosongkan()
        End If
    End Sub

    Private Sub tcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            dt.Clear()
            sql = "SELECT *FROM userr WHERE id_user like '%" & tcari.Text & "%' OR username like '%" & tcari.Text & "%'"
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

    Private Sub bprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bprint.Click
        CetakUser.CrystalReportViewer1.RefreshReport()
        CetakUser.Show()
    End Sub
End Class
