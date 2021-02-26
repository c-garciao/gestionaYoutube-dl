Imports System.IO
Public Class ayuda
    Private Sub ayuda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'navAyuda.Navigate(Environment.CurrentDirectory & "\resources\ayuda.pdf")
            Me.Text = "Ayuda oficial"
            Me.TopMost = True
            Console.WriteLine(System.IO.Path.GetFullPath(Application.StartupPath))
            Dim pdfAyuda As FileInfo
            Dim bytesAyuda() As Byte = My.Resources.ayuda
            File.WriteAllBytes(Application.StartupPath & "\ayuda.pdf", bytesAyuda)
            pdfAyuda = New FileInfo(Application.StartupPath & "\ayuda.pdf")
            navAyuda.Navigate(pdfAyuda.ToString)
        Catch ex As Exception
        End Try
    End Sub
End Class