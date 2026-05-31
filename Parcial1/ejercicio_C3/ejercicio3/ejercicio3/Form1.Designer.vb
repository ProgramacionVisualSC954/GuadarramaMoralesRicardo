<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblBuscar = New Label()
        txtBusqueda1 = New TextBox()
        btnBuscar = New Button()
        lblResultado = New Label()
        SuspendLayout()
        ' 
        ' lblBuscar
        ' 
        lblBuscar.AutoSize = True
        lblBuscar.Location = New Point(76, 65)
        lblBuscar.Name = "lblBuscar"
        lblBuscar.Size = New Size(154, 20)
        lblBuscar.TabIndex = 0
        lblBuscar.Text = "Nombre del producto"
        ' 
        ' txtBusqueda1
        ' 
        txtBusqueda1.Location = New Point(76, 108)
        txtBusqueda1.Multiline = True
        txtBusqueda1.Name = "txtBusqueda1"
        txtBusqueda1.Size = New Size(648, 34)
        txtBusqueda1.TabIndex = 1
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(76, 188)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(94, 29)
        btnBuscar.TabIndex = 2
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Location = New Point(76, 264)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(75, 20)
        lblResultado.TabIndex = 3
        lblResultado.Text = "Resultado"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblResultado)
        Controls.Add(btnBuscar)
        Controls.Add(txtBusqueda1)
        Controls.Add(lblBuscar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBusqueda1 As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblResultado As Label

End Class
