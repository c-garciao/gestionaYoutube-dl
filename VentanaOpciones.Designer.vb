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
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnAbreSelecFich = New System.Windows.Forms.Button()
        Me.abreLocExes = New System.Windows.Forms.SaveFileDialog()
        Me.btnCambiaRutaDefecto = New System.Windows.Forms.Button()
        Me.abrCambiaRutaDefecto = New System.Windows.Forms.SaveFileDialog()
        Me.lblMuestraCarpeta = New System.Windows.Forms.Label()
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
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(13, 37)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(160, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Actualizaciones atuomáticas"
        Me.CheckBox2.UseVisualStyleBackColor = True
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
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(140, 133)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 34)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Descargar ficheros"
        Me.Button3.UseVisualStyleBackColor = True
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
        Me.lblMuestraCarpeta.Location = New System.Drawing.Point(69, 57)
        Me.lblMuestraCarpeta.Name = "lblMuestraCarpeta"
        Me.lblMuestraCarpeta.Size = New System.Drawing.Size(100, 23)
        Me.lblMuestraCarpeta.TabIndex = 8
        Me.lblMuestraCarpeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VentanaOpciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 186)
        Me.Controls.Add(Me.lblMuestraCarpeta)
        Me.Controls.Add(Me.btnCambiaRutaDefecto)
        Me.Controls.Add(Me.btnAbreSelecFich)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.chkGenLogs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VentanaOpciones"
        Me.Text = "Opciones"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkGenLogs As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents btnAbreSelecFich As Button
    Friend WithEvents abreLocExes As SaveFileDialog
    Friend WithEvents btnCambiaRutaDefecto As Button
    Friend WithEvents abrCambiaRutaDefecto As SaveFileDialog
    Friend WithEvents lblMuestraCarpeta As Label
End Class
