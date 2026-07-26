Option Strict On

Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms

''' <summary>
''' Formulario de registro con validación básica.
''' Proyecto unificado: un solo formulario para toda la práctica.
''' </summary>
Public Class Form1
    Inherits Form

    ' --- Controles ---
    ' Los controles a los que respondemos con "Handles" se declaran WithEvents.
    Private WithEvents txtNombre As TextBox
    Private WithEvents txtEdad As TextBox
    Private WithEvents txtCorreo As TextBox
    Private WithEvents rbMasculino As RadioButton
    Private WithEvents rbFemenino As RadioButton
    Private WithEvents chkTerminos As CheckBox
    Private WithEvents btnRegistrar As Button

    Private lblNombre As Label
    Private lblEdad As Label
    Private lblCorreo As Label
    Private grpSexo As GroupBox

    Public Sub New()
        InitializeComponent()

        ' Ejemplo de suscripción a un evento POR CÓDIGO con AddHandler,
        ' como alternativa al uso de "Handles" (equivalente a suscribirse
        ' desde el diseñador). Aprovechamos el ciclo de vida del formulario:
        ' FormClosing se dispara antes de que la ventana se cierre.
        AddHandler Me.FormClosing, AddressOf Form1_FormClosing
    End Sub

    ''' <summary>
    ''' Construye la interfaz manualmente (sin diseñador visual).
    ''' </summary>
    Private Sub InitializeComponent()
        Me.SuspendLayout()

        ' --- Configuración general del formulario ---
        Me.Text = "Formulario de Registro"
        Me.ClientSize = New Size(420, 300)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Font = New Font("Segoe UI", 9.0F)

        ' --- Nombre completo ---
        lblNombre = New Label()
        lblNombre.Text = "Nombre completo:"
        lblNombre.Location = New Point(20, 20)
        lblNombre.Size = New Size(120, 20)

        txtNombre = New TextBox()
        txtNombre.Location = New Point(150, 18)
        txtNombre.Size = New Size(230, 22)

        ' --- Edad ---
        lblEdad = New Label()
        lblEdad.Text = "Edad:"
        lblEdad.Location = New Point(20, 55)
        lblEdad.Size = New Size(120, 20)

        txtEdad = New TextBox()
        txtEdad.Location = New Point(150, 53)
        txtEdad.Size = New Size(80, 22)

        ' --- Correo electrónico ---
        lblCorreo = New Label()
        lblCorreo.Text = "Correo electrónico:"
        lblCorreo.Location = New Point(20, 90)
        lblCorreo.Size = New Size(120, 20)

        txtCorreo = New TextBox()
        txtCorreo.Location = New Point(150, 88)
        txtCorreo.Size = New Size(230, 22)

        ' --- Sexo (RadioButton agrupados en un GroupBox => opciones excluyentes) ---
        grpSexo = New GroupBox()
        grpSexo.Text = "Sexo"
        grpSexo.Location = New Point(20, 125)
        grpSexo.Size = New Size(360, 55)

        rbMasculino = New RadioButton()
        rbMasculino.Text = "Masculino"
        rbMasculino.Location = New Point(15, 22)
        rbMasculino.Size = New Size(100, 22)

        rbFemenino = New RadioButton()
        rbFemenino.Text = "Femenino"
        rbFemenino.Location = New Point(150, 22)
        rbFemenino.Size = New Size(100, 22)

        grpSexo.Controls.Add(rbMasculino)
        grpSexo.Controls.Add(rbFemenino)

        ' --- Términos y condiciones ---
        chkTerminos = New CheckBox()
        chkTerminos.Text = "Acepto los términos y condiciones"
        chkTerminos.Location = New Point(20, 195)
        chkTerminos.Size = New Size(300, 22)

        ' --- Botón Registrar ---
        btnRegistrar = New Button()
        btnRegistrar.Text = "Registrar"
        btnRegistrar.Location = New Point(20, 230)
        btnRegistrar.Size = New Size(120, 32)

        ' --- Agregar controles al formulario ---
        Me.Controls.Add(lblNombre)
        Me.Controls.Add(txtNombre)
        Me.Controls.Add(lblEdad)
        Me.Controls.Add(txtEdad)
        Me.Controls.Add(lblCorreo)
        Me.Controls.Add(txtCorreo)
        Me.Controls.Add(grpSexo)
        Me.Controls.Add(chkTerminos)
        Me.Controls.Add(btnRegistrar)

        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    ' ============================================================
    '  EVENTOS DEL CICLO DE VIDA DEL FORMULARIO
    ' ============================================================

    ''' <summary>
    ''' Load se dispara una sola vez, cuando el formulario se está
    ''' preparando para mostrarse por primera vez. Es el lugar ideal
    ''' para dejar el estado inicial de los controles, como dejar
    ''' "Registrar" deshabilitado hasta que se acepten los términos.
    ''' </summary>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnRegistrar.Enabled = False
    End Sub

    ''' <summary>
    ''' FormClosing se dispara ANTES de que la ventana se cierre realmente,
    ''' y permite cancelar el cierre (e.Cancel = True). Aquí se usa para
    ''' pedir una confirmación al usuario. Suscrito por código con AddHandler
    ''' en el constructor (alternativa al uso de "Handles").
    ''' </summary>
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs)
        Dim resultado As DialogResult = MessageBox.Show(
            "¿Seguro que deseas cerrar el formulario?",
            "Confirmar salida",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If resultado = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    ' ============================================================
    '  LÓGICA DE NEGOCIO
    ' ============================================================

    ''' <summary>
    ''' El botón "Registrar" solo se habilita cuando el CheckBox
    ''' de términos está marcado.
    ''' </summary>
    Private Sub chkTerminos_CheckedChanged(sender As Object, e As EventArgs) Handles chkTerminos.CheckedChanged
        btnRegistrar.Enabled = chkTerminos.Checked
    End Sub

    ''' <summary>
    ''' Valida todos los campos y, si son correctos, muestra el resumen
    ''' del registro.
    ''' </summary>
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim errores As New List(Of String)

        ' --- Nombre ---
        Dim nombre As String = txtNombre.Text.Trim()
        If nombre = "" Then
            errores.Add("- El nombre completo no puede estar vacío.")
        End If

        ' --- Edad (TryParse obligatorio, nunca conversión directa) ---
        Dim edadTexto As String = txtEdad.Text.Trim()
        Dim edad As Integer
        Dim edadEsNumero As Boolean = Integer.TryParse(edadTexto, edad)

        If (Not edadEsNumero) OrElse edad <= 0 Then
            errores.Add("- La edad debe ser un número entero mayor a cero.")
        End If

        ' --- Correo electrónico ---
        Dim correo As String = txtCorreo.Text.Trim()
        Dim correoValido As Boolean = correo.Contains("@") AndAlso correo.Contains(".")

        If Not correoValido Then
            errores.Add("- El correo electrónico debe contener un ""@"" y un ""."".")
        End If

        ' --- Sexo ---
        If (Not rbMasculino.Checked) AndAlso (Not rbFemenino.Checked) Then
            errores.Add("- Debes seleccionar una opción de sexo.")
        End If

        ' --- Si hay errores, se informa y NO se completa el registro ---
        If errores.Count > 0 Then
            Dim mensaje As String =
                "Corrige los siguientes datos antes de continuar:" & vbCrLf & vbCrLf &
                String.Join(vbCrLf, errores)

            MessageBox.Show(mensaje, "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- Todo válido: mostrar resumen de confirmación ---
        Dim sexo As String = If(rbMasculino.Checked, "Masculino", "Femenino")

        Dim resumen As String =
            "Registro completado con éxito:" & vbCrLf & vbCrLf &
            "Nombre: " & nombre & vbCrLf &
            "Edad: " & edad.ToString() & vbCrLf &
            "Correo: " & correo & vbCrLf &
            "Sexo: " & sexo & vbCrLf &
            "Términos aceptados: Sí"

        MessageBox.Show(resumen, "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
