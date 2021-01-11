Imports System.IO
Imports System.IO.Compression
Public Class VentanaOpciones
    Dim urlExe = New List(Of String) From {"https://yt-dl.org/latest/youtube-dl.exe", "https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-essentials.7z"}
    'Dim urlExe = New Dictionary(Of Uri, String) From {{"https://yt-dl.org/latest/youtube-dl.exe", "youtube-dl.exe"}, {"https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-essentials.zip", "ffmpeg.exe"}}
    Dim carpetaDefectoDescargas As String = My.Settings.rutaDefectoDescargas
    Dim urlExeNombresFich = New List(Of String) From {"youtube-dl.exe", "ffmpeg.zip"}
    Dim rutaEjecutables = My.Settings.rutaEjecutables
    Dim nombreDirectorio As String




    Private Sub VentanaOpciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.guardarLogs = True Then
            chkGenLogs.Checked = True
        Else
            chkGenLogs.Checked = False
        End If
        If My.Settings.rutaDefectoDescargas <> "" Then
            lblMuestraCarpeta.Text = My.Settings.rutaDefectoDescargas
        End If
    End Sub

    Private Sub VentanaOpciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If chkGenLogs.Checked = True Then
            My.Settings.guardarLogs = True
        Else
            My.Settings.guardarLogs = False
        End If
        If nombreDirectorio <> "" Then
            My.Settings.rutaDefectoDescargas = nombreDirectorio
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim opcion As DialogResult = MessageBox.Show("¿Desea descargar de nuevo los ficheros?", "Descarga de los ficheros", MessageBoxButtons.YesNo)
        If opcion = DialogResult.Yes Then
            descargaFicheros()
        End If
    End Sub
    Public Sub descargaFicheros()

        Dim clienteWeb As New System.Net.WebClient

        'If Not System.IO.Directory.Exists(rutaEjecutables) Then
        If Not compruebaDirectorioFichero(rutaEjecutables, "d") Then
            System.IO.Directory.CreateDirectory(rutaEjecutables)
        End If
        Try
            For i As Integer = 0 To urlExe.Count - 1
                'Dim solicitudWeb01 As System.Net.WebRequest = System.Net.WebRequest.Create(url)
                clienteWeb.DownloadFile(urlExe(i), rutaEjecutables & "\" & urlExeNombresFich(i)) ' , "", "", 100000, True)
            Next
            clienteWeb.Dispose()
            descomprimeArchivos(rutaEjecutables & "\" & urlExeNombresFich(1), rutaEjecutables, urlExeNombresFich(1))
            My.Settings.rutaYoutubeDl = rutaEjecutables & "\" & urlExeNombresFich(0)

            If compruebaDirectorioFichero(rutaEjecutables & "\" & urlExeNombresFich(0), "a") AndAlso compruebaDirectorioFichero(rutaEjecutables & "\" & urlExeNombresFich(1), "a") Then
                frmPrincDescargas.muestraCuadroMensaje("Se han descargado correctamente los ficheros", "Descarga completada", MessageBoxIcon.Information)
            Else
                frmPrincDescargas.muestraCuadroMensaje("Error, no se han descargado todos los ficheros. Revisar manualmente", "Error al descargar", MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Public Function compruebaDirectorioFichero(ByVal nombreFichero As String, tipoFichero As Char) As Boolean
        Dim resultado As Boolean
        If tipoFichero = "d" Then
            If System.IO.Directory.Exists(nombreFichero) Then
                resultado = True
            Else
                resultado = False
            End If

        ElseIf tipoFichero = "a" Then
            If System.IO.File.Exists(nombreFichero) Then
                resultado = True
            Else
                resultado = False
            End If
        End If
        Return resultado
    End Function
    Public Sub descomprimeArchivos(ByVal nombreFicheroComprimido As String, rutaDescomprimida As String, nombreFinal As String)
        Try
            Using archive = ZipFile.OpenRead(nombreFicheroComprimido)
                For Each entrada As ZipArchiveEntry In archive.Entries
                    If (entrada.FullName.EndsWith(".exe", StringComparison.OrdinalIgnoreCase)) Then
                        entrada.ExtractToFile(Path.Combine(rutaDescomprimida, entrada.FullName), True)
                    End If
                Next
            End Using
            ZipFile.ExtractToDirectory(nombreFicheroComprimido, rutaDescomprimida & "\tmp")
            My.Computer.FileSystem.MoveFile(rutaDescomprimida & "\*.exe", My.Settings.rutaEjecutables)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            frmPrincDescargas.muestraCuadroMensaje(ex.Message, "Error", MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCambiaRutaDefecto.Click
        abrCambiaRutaDefecto.Title = "Escoger nueva carpeta de destino"
        abrCambiaRutaDefecto.FileName = "Seleccionar carpeta"
        abrCambiaRutaDefecto.ShowDialog()
        nombreDirectorio = System.IO.Path.GetDirectoryName(abrCambiaRutaDefecto.FileName)
        My.Settings.rutaDefectoDescargas = nombreDirectorio
        lblMuestraCarpeta.Text = nombreDirectorio
        frmPrincDescargas.muestraCuadroMensaje("Se ha actualizado la carpeta por defecto a " & nombreDirectorio, "Cambios guardados", MessageBoxIcon.Information)
    End Sub
End Class