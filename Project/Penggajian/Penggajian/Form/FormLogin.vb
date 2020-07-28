Imports System.Data
Imports System.Data.SqlClient
Public Class FormLogin
    Dim conn As New KoneksiServer.Class1
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cmd As New SqlCommand
    Dim dt As New DataTable
    Dim dr As SqlDataReader
    Dim sql As String

    Sub KondisiAwal()
        tnamauser.Text = ""
        tpassword.Text = ""
    End Sub
    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tpassword.UseSystemPasswordChar = True
    End Sub

    Private Sub blogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blogin.Click
        sql = "SELECT *FROM userr WHERE username='" & tnamauser.Text & "' AND pass='" & tpassword.Text & "'"
        conn.KoneksiGagal()
        cmd.CommandText = sql
        cmd.Connection = conn.Koneksi
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            MsgBox("Login Gagal", MsgBoxStyle.Information, "INFORMASI")
            Call KondisiAwal()
            Exit Sub
        Else
            Me.Visible = False
            MenuUtama.Show()

            MenuUtama.panel1.Text = dr.Item("id_user")
            MenuUtama.panel2.Text = dr.Item("username")
            MenuUtama.panel3.Text = dr.Item("lvl")
            
            'Inilah pembagian hak aksesnya
            If MenuUtama.panel3.Text = "Administrator" Then
                MenuUtama.UserToolStripMenuItem.Visible = True
                MenuUtama.DepartemenToolStripMenuItem.Visible = True
                MenuUtama.JabatanToolStripMenuItem.Visible = True
                MenuUtama.PendapatanToolStripMenuItem.Visible = True
                MenuUtama.PotonganToolStripMenuItem.Visible = True
                MenuUtama.KaryawanToolStripMenuItem1.Visible = True
                MenuUtama.AbsensiToolStripMenuItem.Visible = True
                MenuUtama.PenggajianToolStripMenuItem.Visible = True
                MenuUtama.LaporanAbsensiToolStripMenuItem.Visible = True
                MenuUtama.LaporanPenggajianToolStripMenuItem.Visible = True
                MenuUtama.LogOffToolStripMenuItem.Visible = True
                MenuUtama.TutupAplikasiToolStripMenuItem.Visible = True
                MenuUtama.buser.Visible = True
                MenuUtama.bdept.Visible = True
                MenuUtama.bjabatan.Visible = True
                MenuUtama.bpendapatan.Visible = True
                MenuUtama.bpotongan.Visible = True
                MenuUtama.bkaryawan.Visible = True
                MenuUtama.babsensi.Visible = True
                MenuUtama.bpenggajian.Visible = True
                MenuUtama.blaporanabsensi.Visible = True
                MenuUtama.blaporanpenggajian.Visible = True
                MenuUtama.blogoff.Visible = True
                MenuUtama.btutupaplikasi.Visible = True
            ElseIf MenuUtama.panel3.Text = "Admin" Then
                MenuUtama.UserToolStripMenuItem.Visible = False
                MenuUtama.DepartemenToolStripMenuItem.Visible = False
                MenuUtama.JabatanToolStripMenuItem.Visible = False
                MenuUtama.PendapatanToolStripMenuItem.Visible = False
                MenuUtama.PotonganToolStripMenuItem.Visible = False
                MenuUtama.KaryawanToolStripMenuItem1.Visible = True
                MenuUtama.AbsensiToolStripMenuItem.Visible = True
                MenuUtama.PenggajianToolStripMenuItem.Visible = True
                MenuUtama.LaporanAbsensiToolStripMenuItem.Visible = True
                MenuUtama.LaporanPenggajianToolStripMenuItem.Visible = True
                MenuUtama.LogOffToolStripMenuItem.Visible = True
                MenuUtama.TutupAplikasiToolStripMenuItem.Visible = True
                MenuUtama.buser.Visible = False
                MenuUtama.bdept.Visible = False
                MenuUtama.bjabatan.Visible = False
                MenuUtama.bpendapatan.Visible = False
                MenuUtama.bpotongan.Visible = False
                MenuUtama.bkaryawan.Visible = True
                MenuUtama.babsensi.Visible = True
                MenuUtama.bpenggajian.Visible = True
                MenuUtama.blaporanabsensi.Visible = True
                MenuUtama.blaporanpenggajian.Visible = True
                MenuUtama.blogoff.Visible = True
                MenuUtama.btutupaplikasi.Visible = True

            End If
        End If

    End Sub

    Private Sub bcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcancel.Click
        Call KondisiAwal()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If tpassword.UseSystemPasswordChar = True Then
            tpassword.UseSystemPasswordChar = False
        Else
            tpassword.UseSystemPasswordChar = True
        End If
    End Sub

  
End Class