Option Strict On
Option Explicit On

Imports System
Imports System.IO
Imports System.Windows.Forms
Imports System.Drawing

Namespace EditorEnriquecido

    Public Class Form1
        Inherits Form

        Private WithEvents rtbEditor As RichTextBox
        Private mnuMain As MenuStrip
        Private tsMain As ToolStrip
        Private ssMain As StatusStrip
        Private cmsEditor As ContextMenuStrip

        Private WithEvents mnuNuevo As ToolStripMenuItem
        Private WithEvents mnuAbrir As ToolStripMenuItem
        Private WithEvents mnuGuardar As ToolStripMenuItem
        Private WithEvents mnuSalir As ToolStripMenuItem

        Private WithEvents mnuFuente As ToolStripMenuItem
        Private WithEvents mnuColor As ToolStripMenuItem

        Private WithEvents mnuCortar As ToolStripMenuItem
        Private WithEvents mnuCopiar As ToolStripMenuItem
        Private WithEvents mnuPegar As ToolStripMenuItem

        Private WithEvents tsbAbrir As ToolStripButton
        Private WithEvents tsbGuardar As ToolStripButton

        Private lblCaracteres As ToolStripStatusLabel
        Private lblRuta As ToolStripStatusLabel

        Private currentFilePath As String = Nothing

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub InitializeComponent()

            Me.Text = "Editor de Texto Enriquecido"
            Me.Width = 900
            Me.Height = 650
            Me.StartPosition = FormStartPosition.CenterScreen

            rtbEditor = New RichTextBox()
            rtbEditor.Dock = DockStyle.Fill
            rtbEditor.Font = New Font("Segoe UI", 11)

            mnuMain = New MenuStrip()

            Dim mnuArchivo As New ToolStripMenuItem("Archivo")
            mnuNuevo = New ToolStripMenuItem("Nuevo")
            mnuNuevo.ShortcutKeys = Keys.Control Or Keys.N
            mnuAbrir = New ToolStripMenuItem("Abrir")
            mnuAbrir.ShortcutKeys = Keys.Control Or Keys.O
            mnuGuardar = New ToolStripMenuItem("Guardar")
            mnuGuardar.ShortcutKeys = Keys.Control Or Keys.S
            mnuSalir = New ToolStripMenuItem("Salir")

            mnuArchivo.DropDownItems.AddRange(New ToolStripItem() {
                mnuNuevo, mnuAbrir, mnuGuardar, New ToolStripSeparator(), mnuSalir
            })

            Dim mnuFormato As New ToolStripMenuItem("Formato")
            mnuFuente = New ToolStripMenuItem("Fuente...")
            mnuColor = New ToolStripMenuItem("Color...")
            mnuFormato.DropDownItems.AddRange(New ToolStripItem() {mnuFuente, mnuColor})

            mnuMain.Items.AddRange(New ToolStripItem() {mnuArchivo, mnuFormato})
            Me.MainMenuStrip = mnuMain

            tsMain = New ToolStrip()
            tsbAbrir = New ToolStripButton("Abrir")
            tsbGuardar = New ToolStripButton("Guardar")
            tsMain.Items.AddRange(New ToolStripItem() {tsbAbrir, tsbGuardar})

            ssMain = New StatusStrip()
            lblCaracteres = New ToolStripStatusLabel("Caracteres: 0")
            lblRuta = New ToolStripStatusLabel("Sin archivo")
            lblRuta.Spring = True
            lblRuta.TextAlign = ContentAlignment.MiddleRight
            ssMain.Items.AddRange(New ToolStripItem() {lblCaracteres, lblRuta})

            cmsEditor = New ContextMenuStrip()
            mnuCortar = New ToolStripMenuItem("Cortar")
            mnuCopiar = New ToolStripMenuItem("Copiar")
            mnuPegar = New ToolStripMenuItem("Pegar")
            cmsEditor.Items.AddRange(New ToolStripItem() {mnuCortar, mnuCopiar, mnuPegar})
            rtbEditor.ContextMenuStrip = cmsEditor

            Me.Controls.Add(rtbEditor)
            Me.Controls.Add(tsMain)
            Me.Controls.Add(ssMain)
            Me.Controls.Add(mnuMain)

        End Sub


        Private Sub mnuNuevo_Click(sender As Object, e As EventArgs) Handles mnuNuevo.Click
            If rtbEditor.TextLength > 0 Then
                Dim resultado As DialogResult = MessageBox.Show(
                    "¿Deseas descartar el contenido actual y empezar un documento nuevo?",
                    "Nuevo documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If resultado = DialogResult.No Then Return
            End If

            rtbEditor.Clear()
            currentFilePath = Nothing
            ActualizarBarraEstado()
        End Sub

        Private Sub mnuAbrir_Click(sender As Object, e As EventArgs) Handles mnuAbrir.Click, tsbAbrir.Click
            AbrirArchivo()
        End Sub

        Private Sub mnuGuardar_Click(sender As Object, e As EventArgs) Handles mnuGuardar.Click, tsbGuardar.Click
            GuardarArchivo()
        End Sub

        Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click
            Me.Close()
        End Sub

        Private Sub AbrirArchivo()
            Using ofd As New OpenFileDialog()
                ofd.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
                ofd.Title = "Abrir archivo"

                If ofd.ShowDialog() = DialogResult.OK Then
                    Try
                        rtbEditor.Text = File.ReadAllText(ofd.FileName)
                        currentFilePath = ofd.FileName
                        ActualizarBarraEstado()
                    Catch ex As Exception
                        MessageBox.Show("No se pudo abrir el archivo:" & Environment.NewLine & ex.Message,
                                        "Error al abrir", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End Using
        End Sub

        Private Sub GuardarArchivo()

            If String.IsNullOrEmpty(currentFilePath) Then
                Using sfd As New SaveFileDialog()
                    sfd.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
                    sfd.Title = "Guardar como"

                    If sfd.ShowDialog() = DialogResult.OK Then
                        currentFilePath = sfd.FileName
                    Else
                        Return
                    End If
                End Using
            End If

            Try
                File.WriteAllText(currentFilePath, rtbEditor.Text)
                ActualizarBarraEstado()
            Catch ex As Exception
                MessageBox.Show("No se pudo guardar el archivo:" & Environment.NewLine & ex.Message,
                                "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub


        Private Sub mnuFuente_Click(sender As Object, e As EventArgs) Handles mnuFuente.Click
            Using fd As New FontDialog()
                fd.Font = If(rtbEditor.SelectionLength > 0, rtbEditor.SelectionFont, rtbEditor.Font)

                If fd.ShowDialog() = DialogResult.OK Then
                    If rtbEditor.SelectionLength > 0 Then
                        rtbEditor.SelectionFont = fd.Font
                    Else
                        Dim inicio As Integer = rtbEditor.SelectionStart
                        rtbEditor.SelectAll()
                        rtbEditor.SelectionFont = fd.Font
                        rtbEditor.SelectionStart = inicio
                        rtbEditor.SelectionLength = 0
                    End If
                End If
            End Using
        End Sub

        Private Sub mnuColor_Click(sender As Object, e As EventArgs) Handles mnuColor.Click
            Using cd As New ColorDialog()
                cd.Color = If(rtbEditor.SelectionLength > 0, rtbEditor.SelectionColor, rtbEditor.ForeColor)

                If cd.ShowDialog() = DialogResult.OK Then
                    If rtbEditor.SelectionLength > 0 Then
                        rtbEditor.SelectionColor = cd.Color
                    Else
                        Dim inicio As Integer = rtbEditor.SelectionStart
                        rtbEditor.SelectAll()
                        rtbEditor.SelectionColor = cd.Color
                        rtbEditor.SelectionStart = inicio
                        rtbEditor.SelectionLength = 0
                    End If
                End If
            End Using
        End Sub


        Private Sub mnuCortar_Click(sender As Object, e As EventArgs) Handles mnuCortar.Click
            If rtbEditor.SelectionLength > 0 Then rtbEditor.Cut()
        End Sub

        Private Sub mnuCopiar_Click(sender As Object, e As EventArgs) Handles mnuCopiar.Click
            If rtbEditor.SelectionLength > 0 Then rtbEditor.Copy()
        End Sub

        Private Sub mnuPegar_Click(sender As Object, e As EventArgs) Handles mnuPegar.Click
            If Clipboard.ContainsText() Then rtbEditor.Paste()
        End Sub


        Private Sub rtbEditor_TextChanged(sender As Object, e As EventArgs) Handles rtbEditor.TextChanged
            ActualizarBarraEstado()
        End Sub

        Private Sub ActualizarBarraEstado()
            lblCaracteres.Text = "Caracteres: " & rtbEditor.TextLength.ToString()

            If String.IsNullOrEmpty(currentFilePath) OrElse Not File.Exists(currentFilePath) Then
                lblRuta.Text = "Sin archivo"
            Else
                lblRuta.Text = currentFilePath
            End If
        End Sub

    End Class

End Namespace
