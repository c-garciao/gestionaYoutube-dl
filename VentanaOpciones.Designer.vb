<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaOpciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.chkGenLogs = New System.Windows.Forms.CheckBox()
        Me.chkActualizaciones = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDescargaFicheros = New System.Windows.Forms.Button()
        Me.btnAbreSelecFich = New System.Windows.Forms.Button()
        Me.abreLocExes = New System.Windows.Forms.SaveFileDialog()
        Me.btnCambiaRutaDefecto = New System.Windows.Forms.Button()
        Me.abrCambiaRutaDefecto = New System.Windows.Forms.SaveFileDialog()
        Me.lblMuestraCarpeta = New System.Windows.Forms.Label()
        Me.pctBoxGifCarga = New System.Windows.Forms.PictureBox()
        Me.bgWkDescargaFicherosEsenciales = New System.ComponentModel.BackgroundWorker()
        CType(Me.pctBoxGifCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkGenLogs
        '
        Me.chkGenLogs.AutoSize = True
        Me.chkGenLogs.Checked = True
        Me.chkGenLogs.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGenLogs.Location = New System.Drawing.Point(13, 13)
        Me.chkGenLogs.Name = "chkGenLogs"
        Me.chkGenLogs.Size = New System.Drawing.Size(86, 17)
        Me.chkGenLogs.TabIndex = 0
        Me.chkGenLogs.Text = "Generar logs"
        Me.chkGenLogs.UseVisualStyleBackColor = True
        '
        'chkActualizaciones
        '
        Me.chkActualizaciones.AutoSize = True
        Me.chkActualizaciones.Location = New System.Drawing.Point(13, 37)
        Me.chkActualizaciones.Name = "chkActualizaciones"
        Me.chkActualizaciones.Size = New System.Drawing.Size(160, 17)
        Me.chkActualizaciones.TabIndex = 1
        Me.chkActualizaciones.Text = "Actualizaciones atuomáticas"
        Me.chkActualizaciones.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Localizar ejecutables"
        '
        'btnDescargaFicheros
        '
        Me.btnDescargaFicheros.Location = New System.Drawing.Point(140, 133)
        Me.btnDescargaFicheros.Name = "btnDescargaFicheros"
        Me.btnDescargaFicheros.Size = New System.Drawing.Size(75, 34)
        Me.btnDescargaFicheros.TabIndex = 5
        Me.btnDescargaFicheros.Text = "Descargar ficheros"
        Me.btnDescargaFicheros.UseVisualStyleBackColor = True
        '
        'btnAbreSelecFich
        '
        Me.btnAbreSelecFich.Location = New System.Drawing.Point(15, 139)
        Me.btnAbreSelecFich.Name = "btnAbreSelecFich"
        Me.btnAbreSelecFich.Size = New System.Drawing.Size(73, 23)
        Me.btnAbreSelecFich.TabIndex = 6
        Me.btnAbreSelecFich.Text = "Seleccionar"
        Me.btnAbreSelecFich.UseVisualStyleBackColor = True
        '
        'btnCambiaRutaDefecto
        '
        Me.btnCambiaRutaDefecto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCambiaRutaDefecto.Location = New System.Drawing.Point(72, 83)
        Me.btnCambiaRutaDefecto.Name = "btnCambiaRutaDefecto"
        Me.btnCambiaRutaDefecto.Size = New System.Drawing.Size(75, 23)
        Me.btnCambiaRutaDefecto.TabIndex = 7
        Me.btnCambiaRutaDefecto.Text = "Cambiar ruta"
        Me.btnCambiaRutaDefecto.UseVisualStyleBackColor = True
        '
        'lblMuestraCarpeta
        '
        Me.lblMuestraCarpeta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMuestraCarpeta.Location = New System.Drawing.Point(13, 57)
        Me.lblMuestraCarpeta.Name = "lblMuestraCarpeta"
        Me.lblMuestraCarpeta.Size = New System.Drawing.Size(202, 23)
        Me.lblMuestraCarpeta.TabIndex = 8
        Me.lblMuestraCarpeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pctBoxGifCarga
        '
        Me.pctBoxGifCarga.Enabled = False
        Me.pctBoxGifCarga.Location = New System.Drawing.Point(153, 86)
        Me.pctBoxGifCarga.Name = "pctBoxGifCarga"
        Me.pctBoxGifCarga.Size = New System.Drawing.Size(47, 44)
        Me.pctBoxGifCarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBoxGifCarga.TabIndex = 9
        Me.pctBoxGifCarga.TabStop = False
        '
        'bgWkDescargaFicherosEsenciales
        '
        '
        'VentanaOpciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 186)
        Me.Controls.Add(Me.pctBoxGifCarga)
        Me.Controls.Add(Me.lblMuestraCarpeta)
        Me.Controls.Add(Me.btnCambiaRutaDefecto)
        Me.Controls.Add(Me.btnAbreSelecFich)
        Me.Controls.Add(Me.btnDescargaFicheros)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkActualizaciones)
        Me.Controls.Add(Me.chkGenLogs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VentanaOpciones"
        Me.Text = "Opciones"
        Me.TopMost = True
        CType(Me.pctBoxGifCarga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkGenLogs As CheckBox
    Friend WithEvents chkActualizaciones As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDescargaFicheros As Button
    Friend WithEvents btnAbreSelecFich As Button
    Friend WithEvents abreLocExes As SaveFileDialog
    Friend WithEvents btnCambiaRutaDefecto As Button
    Friend WithEvents abrCambiaRutaDefecto As SaveFileDialog
    Friend WithEvents lblMuestraCarpeta As Label
    Friend WithEvents pctBoxGifCarga As PictureBox
    Friend WithEvents bgWkDescargaFicherosEsenciales As System.ComponentModel.BackgroundWorker
End Class
