Public Class MenuUtama


    Private Sub UserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserToolStripMenuItem.Click
        Formuser.Show()
    End Sub

    Private Sub DepartemenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartemenToolStripMenuItem.Click
        FormDepartemen.Show()
    End Sub

    Private Sub JabatanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JabatanToolStripMenuItem.Click
        FormJabatan.Show()
    End Sub

    Private Sub KaryawanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PendapatanToolStripMenuItem.Click
        FormPendapatan.Show()
    End Sub

    Private Sub PotonganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PotonganToolStripMenuItem.Click
        FormPotongan.Show()
    End Sub

    Private Sub KaryawanToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KaryawanToolStripMenuItem1.Click
        FormKaryawan.Show()
    End Sub

    Private Sub AbsensiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbsensiToolStripMenuItem.Click
        FormAbsen.Show()
    End Sub

    Private Sub PenggajianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenggajianToolStripMenuItem.Click
        FormGaji.Show()
    End Sub

    Private Sub LogOffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOffToolStripMenuItem.Click
        panel1.Text = ""
        panel2.Text = ""
        panel3.Text = ""
        Me.Close()
        FormLogin.Show()
        FormLogin.Visible = True
        FormLogin.tnamauser.Text = ""
        FormLogin.tpassword.Text = ""
        FormLogin.tnamauser.Focus()
    End Sub

    Private Sub TutupAplikasiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TutupAplikasiToolStripMenuItem.Click
        If MsgBox("Yakin ingin Tutup Aplikasi..?", MsgBoxStyle.YesNo, "INFORMASI") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub buser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buser.Click
        Formuser.Show()
    End Sub

    Private Sub bdept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bdept.Click
        FormDepartemen.Show()
    End Sub

    Private Sub bjabatan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bjabatan.Click
        FormJabatan.Show()
    End Sub

    Private Sub bpendapatan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bpendapatan.Click
        FormPendapatan.Show()
    End Sub

    Private Sub bpotongan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bpotongan.Click
        FormPotongan.Show()
    End Sub

    Private Sub bkaryawan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bkaryawan.Click
        FormKaryawan.Show()
    End Sub

    Private Sub babsensi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles babsensi.Click
        FormAbsen.Show()
    End Sub

    Private Sub bpenggajian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bpenggajian.Click
        FormGaji.Show()
    End Sub

  

    Private Sub blogoff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blogoff.Click
        panel1.Text = ""
        panel2.Text = ""
        panel3.Text = ""
        Me.Close()
        FormLogin.Show()
        FormLogin.Visible = True
        FormLogin.tnamauser.Text = ""
        FormLogin.tpassword.Text = ""
        FormLogin.tnamauser.Focus()
    End Sub

    Private Sub btutupaplikasi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btutupaplikasi.Click
        If MsgBox("Yakin ingin Tutup Aplikasi..?", MsgBoxStyle.YesNo, "INFORMASI") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub LaporanAbsensiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanAbsensiToolStripMenuItem.Click
        FormLaporanAbsen.Show()
    End Sub

    Private Sub LaporanPenggajianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPenggajianToolStripMenuItem.Click
        FormLaporanGaji.Show()
    End Sub

    Private Sub blaporanpenggajian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blaporanpenggajian.Click
        FormLaporanGaji.Show()
    End Sub

    Private Sub blaporanabsensi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blaporanabsensi.Click
        FormLaporanAbsen.Show()
    End Sub
End Class