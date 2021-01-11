<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincDescargas
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
        Me.matrizDatos01 = New System.Windows.Forms.DataGridView()
        Me.btnDescarga = New System.Windows.Forms.Button()
        Me.cuadroDialogoCarpetaDescarga = New System.Windows.Forms.SaveFileDialog()
        Me.btnAbrirCarpeta = New System.Windows.Forms.Button()
        Me.grupoBtnOpcs = New System.Windows.Forms.GroupBox()
        Me.opcSelecVideo = New System.Windows.Forms.RadioButton()
        Me.opcSelecAudio = New System.Windows.Forms.RadioButton()
        Me.barraProgresoDescarga = New System.Windows.Forms.ProgressBar()
        Me.btnEliminaRegistros = New System.Windows.Forms.Button()
        Me.btnCancelarProceso = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualDeUsoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.matrizDatos01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoBtnOpcs.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'matrizDatos01
        '
        Me.matrizDatos01.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.matrizDatos01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.matrizDatos01.Location = New System.Drawing.Point(12, 27)
        Me.matrizDatos01.Name = "matrizDatos01"
        Me.matrizDatos01.Size = New System.Drawing.Size(430, 150)
        Me.matrizDatos01.TabIndex = 0
        '
        'btnDescarga
        '
        Me.btnDescarga.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDescarga.Location = New System.Drawing.Point(141, 241)
        Me.btnDescarga.Name = "btnDescarga"
        Me.btnDescarga.Size = New System.Drawing.Size(75, 23)
        Me.btnDescarga.TabIndex = 1
        Me.btnDescarga.Text = "Descargar"
        Me.btnDescarga.UseVisualStyleBackColor = True
        '
        'btnAbrirCarpeta
        '
        Me.btnAbrirCarpeta.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAbrirCarpeta.Location = New System.Drawing.Point(187, 183)
        Me.btnAbrirCarpeta.Name = "btnAbrirCarpeta"
        Me.btnAbrirCarpeta.Size = New System.Drawing.Size(75, 23)
        Me.btnAbrirCarpeta.TabIndex = 4
        Me.btnAbrirCarpeta.Text = "Carpeta"
        Me.btnAbrirCarpeta.UseVisualStyleBackColor = True
        '
        'grupoBtnOpcs
        '
        Me.grupoBtnOpcs.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.grupoBtnOpcs.Controls.Add(Me.opcSelecVideo)
        Me.grupoBtnOpcs.Controls.Add(Me.opcSelecAudio)
        Me.grupoBtnOpcs.Location = New System.Drawing.Point(12, 183)
        Me.grupoBtnOpcs.Name = "grupoBtnOpcs"
        Me.grupoBtnOpcs.Size = New System.Drawing.Size(76, 65)
        Me.grupoBtnOpcs.TabIndex = 5
        Me.grupoBtnOpcs.TabStop = False
        '
        'opcSelecVideo
        '
        Me.opcSelecVideo.AutoSize = True
        Me.opcSelecVideo.Location = New System.Drawing.Point(6, 42)
        Me.opcSelecVideo.Name = "opcSelecVideo"
        Me.opcSelecVideo.Size = New System.Drawing.Size(54, 17)
        Me.opcSelecVideo.TabIndex = 1
        Me.opcSelecVideo.Text = "Vídeo"
        Me.opcSelecVideo.UseVisualStyleBackColor = True
        '
        'opcSelecAudio
        '
        Me.opcSelecAudio.AutoSize = True
        Me.opcSelecAudio.Checked = True
        Me.opcSelecAudio.Location = New System.Drawing.Point(6, 19)
        Me.opcSelecAudio.Name = "opcSelecAudio"
        Me.opcSelecAudio.Size = New System.Drawing.Size(52, 17)
        Me.opcSelecAudio.TabIndex = 0
        Me.opcSelecAudio.TabStop = True
        Me.opcSelecAudio.Text = "Audio"
        Me.opcSelecAudio.UseVisualStyleBackColor = True
        '
        'barraProgresoDescarga
        '
        Me.barraProgresoDescarga.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.barraProgresoDescarga.Location = New System.Drawing.Point(94, 212)
        Me.barraProgresoDescarga.Name = "barraProgresoDescarga"
        Me.barraProgresoDescarga.Size = New System.Drawing.Size(348, 23)
        Me.barraProgresoDescarga.TabIndex = 6
        Me.barraProgresoDescarga.Visible = False
        '
        'btnEliminaRegistros
        '
        Me.btnEliminaRegistros.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEliminaRegistros.Location = New System.Drawing.Point(222, 241)
        Me.btnEliminaRegistros.Name = "btnEliminaRegistros"
        Me.btnEliminaRegistros.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminaRegistros.TabIndex = 7
        Me.btnEliminaRegistros.Text = "Eliminar"
        Me.btnEliminaRegistros.UseVisualStyleBackColor = True
        '
        'btnCancelarProceso
        '
        Me.btnCancelarProceso.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancelarProceso.Location = New System.Drawing.Point(187, 183)
        Me.btnCancelarProceso.Name = "btnCancelarProceso"
        Me.btnCancelarProceso.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarProceso.TabIndex = 8
        Me.btnCancelarProceso.Text = "Cancelar"
        Me.btnCancelarProceso.UseVisualStyleBackColor = True
        Me.btnCancelarProceso.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(454, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguracionToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ConfiguracionToolStripMenuItem.Text = "Configuracion"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualDeUsoToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'ManualDeUsoToolStripMenuItem
        '
        Me.ManualDeUsoToolStripMenuItem.Name = "ManualDeUsoToolStripMenuItem"
        Me.ManualDeUsoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ManualDeUsoToolStripMenuItem.Text = "Manual de uso"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'frmPrincDescargas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 271)
        Me.Controls.Add(Me.btnCancelarProceso)
        Me.Controls.Add(Me.btnEliminaRegistros)
        Me.Controls.Add(Me.barraProgresoDescarga)
        Me.Controls.Add(Me.grupoBtnOpcs)
        Me.Controls.Add(Me.btnAbrirCarpeta)
        Me.Controls.Add(Me.btnDescarga)
        Me.Controls.Add(Me.matrizDatos01)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(470, 310)
        Me.MinimumSize = New System.Drawing.Size(470, 310)
        Me.Name = "frmPrincDescargas"
        Me.Text = "Descarga"
        CType(Me.matrizDatos01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoBtnOpcs.ResumeLayout(False)
        Me.grupoBtnOpcs.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents matrizDatos01 As DataGridView
    Friend WithEvents btnDescarga As Button
    Friend WithEvents cuadroDialogoCarpetaDescarga As SaveFileDialog
    Friend WithEvents btnAbrirCarpeta As Button
    Friend WithEvents grupoBtnOpcs As GroupBox
    Friend WithEvents opcSelecVideo As RadioButton
    Friend WithEvents opcSelecAudio As RadioButton
    Friend WithEvents barraProgresoDescarga As ProgressBar
    Friend WithEvents btnEliminaRegistros As Button
    Friend WithEvents btnCancelarProceso As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguracionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManualDeUsoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
End Class
