Public Class FormLaporanAbsen

    Private Sub bcetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcetak.Click

        CetakAbsen.CrystalReportViewer1.SelectionFormula = "{absen.tglabsen} ='" & Format(dtptgl.Value, "yyyy-MM-dd") & "'"
        CetakAbsen.CrystalReportViewer1.RefreshReport()
        CetakAbsen.Show()
    End Sub

   
End Class