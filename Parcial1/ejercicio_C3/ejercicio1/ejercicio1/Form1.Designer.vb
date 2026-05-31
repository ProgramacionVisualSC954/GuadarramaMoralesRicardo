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
        txtNombre = New TextBox()
        txtPrecio = New TextBox()
        lblCategoria = New Label()
        lblIva = New Label()
        lblPrecioFinal = New Label()
        btnClasificar = New Button()
        btnLimpiar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(88, 74)
        txtNombre.Multiline = True
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(617, 34)
        txtNombre.TabIndex = 0
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(88, 172)
        txtPrecio.Multiline = True
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(617, 34)
        txtPrecio.TabIndex = 1
        ' 
        ' lblCategoria
        ' 
        lblCategoria.AutoSize = True
        lblCategoria.Location = New Point(88, 353)
        lblCategoria.Name = "lblCategoria"
        lblCategoria.Size = New Size(0, 20)
        lblCategoria.TabIndex = 2
        ' 
        ' lblIva
        ' 
        lblIva.AutoSize = True
        lblIva.Location = New Point(88, 408)
        lblIva.Name = "lblIva"
        lblIva.Size = New Size(0, 20)
        lblIva.TabIndex = 3
        ' 
        ' lblPrecioFinal
        ' 
        lblPrecioFinal.AutoSize = True
        lblPrecioFinal.Location = New Point(88, 463)
        lblPrecioFinal.Name = "lblPrecioFinal"
        lblPrecioFinal.Size = New Size(0, 20)
        lblPrecioFinal.TabIndex = 4
        ' 
        ' btnClasificar
        ' 
        btnClasificar.Location = New Point(611, 353)
        btnClasificar.Name = "btnClasificar"
        btnClasificar.Size = New Size(94, 29)
        btnClasificar.TabIndex = 5
        btnClasificar.Text = "Clasificar"
        btnClasificar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(611, 454)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(94, 29)
        btnLimpiar.TabIndex = 6
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(88, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 20)
        Label1.TabIndex = 7
        Label1.Text = "Producto"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(88, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 20)
        Label2.TabIndex = 8
        Label2.Text = "Precio"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 587)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnLimpiar)
        Controls.Add(btnClasificar)
        Controls.Add(lblPrecioFinal)
        Controls.Add(lblIva)
        Controls.Add(lblCategoria)
        Controls.Add(txtPrecio)
        Controls.Add(txtNombre)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblCategoria As Label
    Friend WithEvents lblIva As Label
    Friend WithEvents lblPrecioFinal As Label
    Friend WithEvents btnClasificar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
