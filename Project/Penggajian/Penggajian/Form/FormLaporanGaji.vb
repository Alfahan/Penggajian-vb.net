Public Class FormLaporanGaji

    Private Sub bcetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcetak.Click
        CetakLaporanGaji.CrystalReportViewer1.SelectionFormula = "{gaji.tglgaji} ='" & Format(dtptgl.Value, "yyyy-MM-dd") & "'"
        CetakLaporanGaji.CrystalReportViewer1.RefreshReport()
        CetakLaporanGaji.Show()
    End Sub

  
End Class