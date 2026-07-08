<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FromBanco
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
        components = New ComponentModel.Container()
        section1 = New GroupBox()
        btnRegistrarCliente = New Button()
        txtEdad = New TextBox()
        lblEdad = New Label()
        lblEstadoCliente = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ContextMenuStrip2 = New ContextMenuStrip(components)
        GroupBox1 = New GroupBox()
        litsMovimientos = New ListBox()
        btnRetirar = New Button()
        txtMontoRetiro = New TextBox()
        btnAbrirCuenta = New Button()
        txtSaldoInicial = New TextBox()
        Label4 = New Label()
        SaldoActual = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        txtMeses = New TextBox()
        Label8 = New Label()
        ListBox1 = New ListBox()
        btnCalcularPago = New Button()
        txtMontoPrestamo = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        section1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' section1
        ' 
        section1.Controls.Add(btnRegistrarCliente)
        section1.Controls.Add(txtEdad)
        section1.Controls.Add(lblEdad)
        section1.Controls.Add(lblEstadoCliente)
        section1.Location = New Point(12, 12)
        section1.Name = "section1"
        section1.Size = New Size(255, 426)
        section1.TabIndex = 0
        section1.TabStop = False
        ' 
        ' btnRegistrarCliente
        ' 
        btnRegistrarCliente.Location = New Point(54, 119)
        btnRegistrarCliente.Name = "btnRegistrarCliente"
        btnRegistrarCliente.Size = New Size(118, 23)
        btnRegistrarCliente.TabIndex = 3
        btnRegistrarCliente.Text = "Registrar Cliente"
        btnRegistrarCliente.UseVisualStyleBackColor = True
        ' 
        ' txtEdad
        ' 
        txtEdad.Location = New Point(107, 66)
        txtEdad.Name = "txtEdad"
        txtEdad.Size = New Size(100, 23)
        txtEdad.TabIndex = 1
        ' 
        ' lblEdad
        ' 
        lblEdad.AutoSize = True
        lblEdad.Location = New Point(6, 69)
        lblEdad.Name = "lblEdad"
        lblEdad.Size = New Size(73, 15)
        lblEdad.TabIndex = 2
        lblEdad.Text = "Edad Cliente"
        ' 
        ' lblEstadoCliente
        ' 
        lblEstadoCliente.AutoSize = True
        lblEstadoCliente.Location = New Point(18, 196)
        lblEstadoCliente.Name = "lblEstadoCliente"
        lblEstadoCliente.Size = New Size(0, 15)
        lblEstadoCliente.TabIndex = 1
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' ContextMenuStrip2
        ' 
        ContextMenuStrip2.Name = "ContextMenuStrip2"
        ContextMenuStrip2.Size = New Size(61, 4)
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(litsMovimientos)
        GroupBox1.Controls.Add(btnRetirar)
        GroupBox1.Controls.Add(txtMontoRetiro)
        GroupBox1.Controls.Add(btnAbrirCuenta)
        GroupBox1.Controls.Add(txtSaldoInicial)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(SaldoActual)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(300, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(255, 426)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        ' 
        ' litsMovimientos
        ' 
        litsMovimientos.FormattingEnabled = True
        litsMovimientos.ItemHeight = 15
        litsMovimientos.Location = New Point(6, 309)
        litsMovimientos.Name = "litsMovimientos"
        litsMovimientos.Size = New Size(243, 109)
        litsMovimientos.TabIndex = 10
        ' 
        ' btnRetirar
        ' 
        btnRetirar.Location = New Point(57, 247)
        btnRetirar.Name = "btnRetirar"
        btnRetirar.Size = New Size(147, 23)
        btnRetirar.TabIndex = 9
        btnRetirar.Text = "Retirar"
        btnRetirar.UseVisualStyleBackColor = True
        ' 
        ' txtMontoRetiro
        ' 
        txtMontoRetiro.Location = New Point(123, 208)
        txtMontoRetiro.Name = "txtMontoRetiro"
        txtMontoRetiro.Size = New Size(100, 23)
        txtMontoRetiro.TabIndex = 8
        ' 
        ' btnAbrirCuenta
        ' 
        btnAbrirCuenta.Location = New Point(57, 119)
        btnAbrirCuenta.Name = "btnAbrirCuenta"
        btnAbrirCuenta.Size = New Size(147, 23)
        btnAbrirCuenta.TabIndex = 7
        btnAbrirCuenta.Text = "Abrir Cuenta"
        btnAbrirCuenta.UseVisualStyleBackColor = True
        ' 
        ' txtSaldoInicial
        ' 
        txtSaldoInicial.Location = New Point(123, 63)
        txtSaldoInicial.Name = "txtSaldoInicial"
        txtSaldoInicial.Size = New Size(100, 23)
        txtSaldoInicial.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(16, 211)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 15)
        Label4.TabIndex = 5
        Label4.Text = "Monto a retirar"
        ' 
        ' SaldoActual
        ' 
        SaldoActual.AutoSize = True
        SaldoActual.Location = New Point(76, 168)
        SaldoActual.Name = "SaldoActual"
        SaldoActual.Size = New Size(104, 15)
        SaldoActual.TabIndex = 4
        SaldoActual.Text = "Saldo actual; $0.00"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(32, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 15)
        Label2.TabIndex = 3
        Label2.Text = "Saldo inicial"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 15)
        Label1.TabIndex = 2
        Label1.Text = "Seccion 2: Cuentas Bancarias"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtMeses)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(ListBox1)
        GroupBox2.Controls.Add(btnCalcularPago)
        GroupBox2.Controls.Add(txtMontoPrestamo)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Location = New Point(582, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(255, 426)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        ' 
        ' txtMeses
        ' 
        txtMeses.Location = New Point(124, 95)
        txtMeses.Name = "txtMeses"
        txtMeses.Size = New Size(100, 23)
        txtMeses.TabIndex = 12
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(6, 100)
        Label8.Name = "Label8"
        Label8.Size = New Size(103, 15)
        Label8.TabIndex = 11
        Label8.Text = "Numero de Meses"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(21, 309)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(202, 94)
        ListBox1.TabIndex = 10
        ' 
        ' btnCalcularPago
        ' 
        btnCalcularPago.Location = New Point(57, 145)
        btnCalcularPago.Name = "btnCalcularPago"
        btnCalcularPago.Size = New Size(147, 23)
        btnCalcularPago.TabIndex = 7
        btnCalcularPago.Text = "Calcular pago mensual"
        btnCalcularPago.UseVisualStyleBackColor = True
        ' 
        ' txtMontoPrestamo
        ' 
        txtMontoPrestamo.Location = New Point(124, 66)
        txtMontoPrestamo.Name = "txtMontoPrestamo"
        txtMontoPrestamo.Size = New Size(100, 23)
        txtMontoPrestamo.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 71)
        Label6.Name = "Label6"
        Label6.Size = New Size(112, 15)
        Label6.TabIndex = 3
        Label6.Text = "Monto de prestamo"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(21, 32)
        Label7.Name = "Label7"
        Label7.Size = New Size(186, 15)
        Label7.TabIndex = 2
        Label7.Text = "Seccion 3: Simulador de prestamo"
        ' 
        ' FromBanco
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(849, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(section1)
        Name = "FromBanco"
        Text = "Sistema Bancario"
        section1.ResumeLayout(False)
        section1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents section1 As GroupBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents lblEdad As Label
    Friend WithEvents lblEstadoCliente As Label
    Friend WithEvents btnRegistrarCliente As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMontoRetiro As TextBox
    Friend WithEvents btnAbrirCuenta As Button
    Friend WithEvents txtSaldoInicial As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SaldoActual As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents litsMovimientos As ListBox
    Friend WithEvents btnRetirar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtMeses As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnCalcularPago As Button
    Friend WithEvents txtMontoPrestamo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label

End Class
