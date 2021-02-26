Public Class frmPrincDescargas
    Dim nombreColumnas As New List(Of String) From {"URL"}
    Dim portapapeles, nombreCarpeta, rutaExes, redireccion
    Dim primeraEjec As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.dw
        rutaExes = Environment.GetEnvironmentVariable("userprofile") & "\Documents\FicherosEsencialesDescargas"
        If My.Settings.rutaEjecutables <> "" Then
            If Not VentanaOpciones.compruebaDirectorioFichero(My.Settings.rutaEjecutables & "\youtube-dl.exe", "a") Or Not VentanaOpciones.compruebaDirectorioFichero(My.Settings.rutaEjecutables & "\ffmpeg.exe", "a") Then
                If My.Settings.primeraEjecucion Or My.Settings.primeraEjecucion = True Then
                    Dim respuesta As DialogResult = MessageBox.Show("No se han descargado los ficheros necesarios" & vbCrLf & "¿Desea descargarlos?", "Descarga de ficheros necesarios", MessageBoxButtons.YesNo)
                    If respuesta = DialogResult.Yes Then
                        VentanaOpciones.descargaFicheros()
                    Else
                        muestraCuadroMensaje("Los ficheros son necesarios. Se va a cerrar la aplicación", "Ficheros necesarios", MessageBoxIcon.Exclamation)
                        Application.Exit()
                    End If
                End If
            Else
                primeraEjec = False
            End If
            rutaExes = My.Settings.rutaEjecutables
        Else
             My.Settings.rutaEjecutables = rutaExes
        End If


        'compruebaVariableEntorno()
        For i As Integer = 0 To nombreColumnas.Count - 1
            Console.WriteLine(nombreColumnas(i))
            matrizDatos01.Columns.Add(nombreColumnas(i), nombreColumnas(i))
            matrizDatos01.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next

        '  If My.Settings.rutaEjecutables = "" Then
        ' My.Settings.rutaEjecutables = rutaExes
        ' Else
        ' rutaExes = My.Settings.rutaEjecutables
        ' End If
        'If My.Settings.youtubeExe Then 'Not nombreCarpeta Then
        '    If System.IO.Directory.Exists(My.Settings.youtubeExe) AndAlso System.IO.Directory.Exists(My.Settings.ffmpegExe) Then
        '    Else
        '        muestraCuadroMensaje("No se han encontrado los ficheros necesarios. ¿Desea instalarlos?", "InfoDescargad")
        '
        '    End If
        'Else

        '  End If

    End Sub

    Private Sub pegarPortapapeles(sender As Object, e As KeyEventArgs) Handles matrizDatos01.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            portapapeles = Clipboard.GetText
            Try
                For Each linea In portapapeles.Split(vbCrLf)
                    If Not linea.Trim.ToString = "" Then
                        Me.matrizDatos01.Rows.Add(linea)
                    End If
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    'Private Sub compruebaInsercionDatos(sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles matrizDatos01.CellValueChanged
    '    If matrizDatos01.Rows.Count >= 1 Then
    '        btnDescarga.Enabled = True
    '    Else
    '        btnDescarga.Enabled = False
    '    End If
    'End Sub

    Private Sub btnEliminaRegistros_Click(sender As Object, e As EventArgs) Handles btnEliminaRegistros.Click
        Dim opcion As DialogResult = MessageBox.Show("Se eliminarán todos los registros. ¿Continuar?", "Confirmar borrado de los registros", MessageBoxButtons.YesNo)
        If opcion = DialogResult.Yes Then
            matrizDatos01.Rows.Clear()
        End If
    End Sub

    Private Sub btnDescarga_Click(sender As Object, e As EventArgs) Handles btnDescarga.Click
        descargaFicheros()
    End Sub
    Public Sub descargaFicheros()
        Dim numeroColumnas, numeroFilas As Integer
        Dim parametrosSeleccion, comando As String '= ""
        Dim valorCelda
        If nombreCarpeta = "" Then
            If My.Settings.rutaDefectoDescargas = "" Then
                nombreCarpeta = Environment.GetEnvironmentVariable("userprofile") & "\Downloads"
                My.Settings.rutaDefectoDescargas = nombreCarpeta
                If (Not System.IO.Directory.Exists(nombreCarpeta)) Then
                    System.IO.Directory.CreateDirectory(nombreCarpeta)
                End If
            Else
                nombreCarpeta = My.Settings.rutaDefectoDescargas
            End If
        End If

        If opcSelecAudio.Checked Then
            parametrosSeleccion = "-x --audio-format mp3"

        ElseIf opcSelecVideo.Checked Then
            parametrosSeleccion = "-f best"
            parametrosSeleccion = "-f bestvideo[ext=mp4]+bestaudio"
            parametrosSeleccion = "-f bestvideo+bestaudio/best/best"
        Else
            parametrosSeleccion = "-f best"
        End If
        If My.Settings.guardarLogs = True Then
            redireccion = " >" & Chr(34) & nombreCarpeta & "\ejecucion.log" & Chr(34)
        Else
            redireccion = " >nul"
        End If
        Try
            numeroColumnas = matrizDatos01.Columns.Count - 1
            numeroFilas = matrizDatos01.Rows.Count - 1

            If numeroFilas < 1 Then
                muestraCuadroMensaje("Error. No ha introducido ninúna url. No puede dejar las celdas vacías", "Error. No ha introducido datos", MessageBoxIcon.Error)
            Else
                barraProgresoDescarga.Visible = True
                barraProgresoDescarga.Maximum = numeroFilas
                Cursor = Cursors.WaitCursor
                matrizDatos01.Enabled = False
                btnDescarga.Enabled = False
                btnAbrirCarpeta.Visible = False
                btnEliminaRegistros.Enabled = False
                btnCancelarProceso.Visible = True
                btnCancelarProceso.Enabled = True
                grupoBtnOpcs.Enabled = False
                For i = 0 To numeroColumnas
                    For j = 0 To numeroFilas - 1
                        'comando = Environment.GetEnvironmentVariable("userprofile") & "\Desktop\youtube-dl.exe " & parametrosSeleccion & " --output " & Chr(34) & nombreCarpeta & Chr(34) & "\%(title)s.%(ext)s "
                        valorCelda = matrizDatos01.Rows(j).Cells(i).Value

                        If comprobarCaracteresEspeciales(valorCelda) Then
                            parametrosSeleccion += " -i --yes-playlist "
                        End If
                        'comando = Environment.GetEnvironmentVariable("userprofile") & "\Desktop\youtube-dl.exe " & parametrosSeleccion & " --output " & Chr(34) & nombreCarpeta & Chr(34) & "\%(title)s.%(ext)s "
                        comando = rutaExes & "\youtube-dl.exe " & parametrosSeleccion & " --output " & Chr(34) & nombreCarpeta & Chr(34) & "\%(title)s.%(ext)s "
                        comando = comando & Chr(34) & valorCelda.Replace(vbLf, "") & Chr(34) & redireccion
                        'Process.Start("powershell.exe")
                        'Shell(comando)
                        txtPrgresoDescarga.Text = j + 1 & "/" & numeroFilas
                        Me.Text = "Progreso de descarga: " & j + 1 & " de " & numeroFilas
                        barraProgresoDescarga.Value = j + 1
                        descargaFichero(comando)
                    Next
                Next
                'Me.ResetText()
                Me.Text = "Descarga"
                muestraCuadroMensaje("Se han descargado los archivos en " & vbCrLf & nombreCarpeta, "Descarga finalizada", MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            'Console.WriteLine(comando)
            Console.WriteLine(ex)
            muestraCuadroMensaje("Error : " & vbCrLf & ex.Message, "Error en la descarga", MessageBoxIcon.Error)
        Finally
            txtPrgresoDescarga.Text = ""
            Cursor = Cursors.Default
            matrizDatos01.Enabled = True
            btnDescarga.Enabled = True
            btnEliminaRegistros.Enabled = True
            btnAbrirCarpeta.Visible = True
            barraProgresoDescarga.Visible = False
            btnCancelarProceso.Visible = False
            btnCancelarProceso.Enabled = False
            grupoBtnOpcs.Enabled = True
            matrizDatos01.Rows.Clear()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAbrirCarpeta.Click

        cuadroDialogoCarpetaDescarga.Title = "Escoger carpeta de destino"
        cuadroDialogoCarpetaDescarga.FileName = "Seleccionar carpeta"
        cuadroDialogoCarpetaDescarga.ShowDialog()
        nombreCarpeta = System.IO.Path.GetDirectoryName(cuadroDialogoCarpetaDescarga.FileName)
    End Sub

    Private Function compruebaVariableEntorno() As Boolean
        Dim variableEntornoI, variableEntornoII
        Dim resultado As Boolean
        Try
            variableEntornoI = System.Environment.GetEnvironmentVariable("youtube-dl")
            variableEntornoII = System.Environment.GetEnvironmentVariable("ffmpeg")
            If Not variableEntornoI Or Not variableEntornoII Then
                resultado = False
            Else
                resultado = True
            End If
        Catch ex As Exception

        End Try
        Return resultado
    End Function

    Private Sub btnCancelarProceso_Click(sender As Object, e As EventArgs) Handles btnCancelarProceso.Click
        Dim opcionSeleccionada As DialogResult = MessageBox.Show("¿Seguro que quieres detener la descarga actual?", "Cancelar descarga", MessageBoxButtons.YesNo)
    End Sub

    Public Sub descargaFichero(comandos)
        Dim proceso As New ProcessStartInfo("cmd.exe", "/C " & comandos)
        proceso.RedirectStandardError = False
        proceso.RedirectStandardOutput = False
        proceso.CreateNoWindow = True
        proceso.WindowStyle = ProcessWindowStyle.Hidden
        proceso.UseShellExecute = False
        Dim ejecucionProceso As Process = Process.Start(proceso)
        ejecucionProceso.WaitForExit()

    End Sub
    Public Function comprobarCaracteresEspeciales(ByVal texto As String) As Boolean
        Dim resultado As Boolean
        'If texto.IndexOfAny("[~`!@#$%^&*()-+=|{}':;.,<>/?]".ToCharArray) = -1 Then
        If texto.IndexOfAny("[&]".ToCharArray) = -1 Then
            resultado = False
        Else
            resultado = True
        End If
        Return resultado
    End Function

    Private Sub ConfiguracionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguracionToolStripMenuItem.Click
        'ventanaOpciones = New Ve
        Dim vent = New VentanaOpciones()
        vent.Show()
    End Sub

    Private Sub ManualDeUsoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualDeUsoToolStripMenuItem.Click
        Dim ayuda = New ayuda
        ayuda.Show()
    End Sub

    Private Sub frmPrincDescargas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim ayuda = New ayuda
            ayuda.Show()
        End If
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        muestraCuadroMensaje("Carlos 2021", "Información", MessageBoxIcon.Information)
    End Sub

    Private Sub frmPrincDescargas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        rutaExes = My.Settings.rutaEjecutables
        If Not primeraEjec Then
            My.Settings.primeraEjecucion = False
        End If
        If My.Settings.rutaDefectoDescargas = "" Then
            My.Settings.rutaDefectoDescargas = nombreCarpeta
        End If
    End Sub

    Public Sub muestraCuadroMensaje(mensajeMostrar As String, titulo As String, tipo As MessageBoxIcon)
        MessageBox.Show(mensajeMostrar, titulo, MessageBoxButtons.OK, tipo)
    End Sub

End Class
