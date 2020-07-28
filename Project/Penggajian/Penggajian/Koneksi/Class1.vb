Imports System.Data
Imports System.Data.SqlClient
Namespace KoneksiServer
    Public Class Class1
        Dim HubServer As New SqlConnection("Data Source=DESKTOP-PP7H8OH;Initial Catalog=Db_penggajian;Integrated Security=True")
        Public Function Koneksi() As SqlConnection
            With HubServer
                If .State <> ConnectionState.Open Then .Open()
            End With
            Return HubServer
        End Function

        Public Sub KoneksiGagal()
            HubServer.Close()
        End Sub
    End Class
End Namespace
