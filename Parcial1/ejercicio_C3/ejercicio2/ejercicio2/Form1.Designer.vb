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
        lblNombreProducto = New Label()
        txtNombreProducto = New TextBox()
        lblPrecioProducto = New Label()
        txtPrecioProducto = New TextBox()
        btnAgregar = New Button()
        lstProductos = New ListBox()
        lblTextoSubtotal = New Label()
        lblSubtotal = New Label()
        lblTextoIva = New Label()
        lblIva = New Label()
        lblTextoTotal = New Label()
        lblTotal = New Label()
        btnGenerarTicket = New Button()
        btnLimpiar = New Button()
        SuspendLayout()
        ' 
        ' lblNombreProducto
        ' 
        lblNombreProducto.AutoSize = True
        lblNombreProducto.Location = New Point(94, 28)
        lblNombreProducto.Name = "lblNombreProducto"
        lblNombreProducto.Size = New Size(153, 20)
        lblNombreProducto.TabIndex = 0
        lblNombreProducto.Text = "Nombre del Producto"
        ' 
        ' txtNombreProducto
        ' 
        txtNombreProducto.Location = New Point(94, 71)
        txtNombreProducto.Multiline = True
        txtNombreProducto.Name = "txtNombreProducto"
        txtNombreProducto.Size = New Size(634, 34)
        txtNombreProducto.TabIndex = 1
        ' 
        ' lblPrecioProducto
        ' 
        lblPrecioProducto.AutoSize = True
        lblPrecioProducto.Location = New Point(94, 138)
        lblPrecioProducto.Name = "lblPrecioProducto"
        lblPrecioProducto.Size = New Size(50, 20)
        lblPrecioProducto.TabIndex = 2
        lblPrecioProducto.Text = "Precio"
        ' 
        ' txtPrecioProducto
        ' 
        txtPrecioProducto.Location = New Point(94, 188)
        txtPrecioProducto.Multiline = True
        txtPrecioProducto.Name = "txtPrecioProducto"
        txtPrecioProducto.Size = New Size(634, 34)
        txtPrecioProducto.TabIndex = 3
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(94, 267)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(94, 29)
        btnAgregar.TabIndex = 4
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' lstProductos
        ' 
        lstProductos.FormattingEnabled = True
        lstProductos.Location = New Point(263, 267)
        lstProductos.Name = "lstProductos"
        lstProductos.Size = New Size(150, 104)
        lstProductos.TabIndex = 5
        ' 
        ' lblTextoSubtotal
        ' 
        lblTextoSubtotal.AutoSize = True
        lblTextoSubtotal.Location = New Point(94, 414)
        lblTextoSubtotal.Name = "lblTextoSubtotal"
        lblTextoSubtotal.Size = New Size(65, 20)
        lblTextoSubtotal.TabIndex = 6
        lblTextoSubtotal.Text = "Subtotal"
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.AutoSize = True
        lblSubtotal.Location = New Point(94, 470)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(44, 20)
        lblSubtotal.TabIndex = 7
        lblSubtotal.Text = "$0.00"
        ' 
        ' lblTextoIva
        ' 
        lblTextoIva.AutoSize = True
        lblTextoIva.Location = New Point(94, 526)
        lblTextoIva.Name = "lblTextoIva"
        lblTextoIva.Size = New Size(73, 20)
        lblTextoIva.TabIndex = 8
        lblTextoIva.Text = "IVA (16%)"
        ' 
        ' lblIva
        ' 
        lblIva.AutoSize = True
        lblIva.Location = New Point(428, 414)
        lblIva.Name = "lblIva"
        lblIva.Size = New Size(44, 20)
        lblIva.TabIndex = 9
        lblIva.Text = "$0.00"
        ' 
        ' lblTextoTotal
        ' 
        lblTextoTotal.AutoSize = True
        lblTextoTotal.Location = New Point(428, 470)
        lblTextoTotal.Name = "lblTextoTotal"
        lblTextoTotal.Size = New Size(42, 20)
        lblTextoTotal.TabIndex = 10
        lblTextoTotal.Text = "Total"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(428, 526)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(44, 20)
        lblTotal.TabIndex = 11
        lblTotal.Text = "$0.00"
        ' 
        ' btnGenerarTicket
        ' 
        btnGenerarTicket.Location = New Point(94, 592)
        btnGenerarTicket.Name = "btnGenerarTicket"
        btnGenerarTicket.Size = New Size(153, 29)
        btnGenerarTicket.TabIndex = 12
        btnGenerarTicket.Text = "Generar Ticket"
        btnGenerarTicket.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(428, 592)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(94, 29)
        btnLimpiar.TabIndex = 13
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 656)
        Controls.Add(btnLimpiar)
        Controls.Add(btnGenerarTicket)
        Controls.Add(lblTotal)
        Controls.Add(lblTextoTotal)
        Controls.Add(lblIva)
        Controls.Add(lblTextoIva)
        Controls.Add(lblSubtotal)
        Controls.Add(lblTextoSubtotal)
        Controls.Add(lstProductos)
        Controls.Add(btnAgregar)
        Controls.Add(txtPrecioProducto)
        Controls.Add(lblPrecioProducto)
        Controls.Add(txtNombreProducto)
        Controls.Add(lblNombreProducto)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNombreProducto As Label
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents lblPrecioProducto As Label
    Friend WithEvents txtPrecioProducto As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lstProductos As ListBox
    Friend WithEvents lblTextoSubtotal As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTextoIva As Label
    Friend WithEvents lblIva As Label
    Friend WithEvents lblTextoTotal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnGenerarTicket As Button
    Friend WithEvents btnLimpiar As Button

End Class
