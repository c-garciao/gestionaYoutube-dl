<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ayuda
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
        Me.navAyuda = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'navAyuda
        '
        Me.navAyuda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.navAyuda.Location = New System.Drawing.Point(0, 0)
        Me.navAyuda.MinimumSize = New System.Drawing.Size(20, 20)
        Me.navAyuda.Name = "navAyuda"
        Me.navAyuda.Size = New System.Drawing.Size(800, 450)
        Me.navAyuda.TabIndex = 0
        '
        'ayuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.navAyuda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ayuda"
        Me.Text = "ayuda"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents navAyuda As WebBrowser
End Class
