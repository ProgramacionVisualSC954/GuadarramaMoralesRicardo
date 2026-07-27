Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1
    Inherits Form

    Private tabControlPrincipal As TabControl
    Private tabDatosAlumno As TabPage
    Private tabMateriasHorario As TabPage

    Private grpDatosAlumno As GroupBox
    Private tlpDatos As TableLayoutPanel
    Private lblNombre As Label
    Private txtNombre As TextBox
    Private lblFechaNacimiento As Label
    Private dtpFechaNacimiento As DateTimePicker
    Private lblSemestre As Label
    Private nudSemestre As NumericUpDown

    Private flpTurno As FlowLayoutPanel
    Private lblTurno As Label
    Private cmbTurno As ComboBox
    Private splitMaterias As SplitContainer
    Private lblMateriasDisponibles As Label
    Private clbMaterias As CheckedListBox
    Private lblResumen As Label
    Private lstResumen As ListBox

    Private btnInscribir As Button
    Private errorProvider1 As ErrorProvider
    Private toolTip1 As ToolTip

    Public Sub New()
        InitializeComponent()
        AddHandler Me.Load, AddressOf Form1_Load
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)
        splitMaterias.SplitterDistance = 330
    End Sub

    Private Sub InitializeComponent()

        Me.tabControlPrincipal = New TabControl()
        Me.tabDatosAlumno = New TabPage()
        Me.tabMateriasHorario = New TabPage()

        Me.grpDatosAlumno = New GroupBox()
        Me.tlpDatos = New TableLayoutPanel()
        Me.lblNombre = New Label()
        Me.txtNombre = New TextBox()
        Me.lblFechaNacimiento = New Label()
        Me.dtpFechaNacimiento = New DateTimePicker()
        Me.lblSemestre = New Label()
        Me.nudSemestre = New NumericUpDown()

        Me.flpTurno = New FlowLayoutPanel()
        Me.lblTurno = New Label()
        Me.cmbTurno = New ComboBox()
        Me.splitMaterias = New SplitContainer()
        Me.lblMateriasDisponibles = New Label()
        Me.clbMaterias = New CheckedListBox()
        Me.lblResumen = New Label()
        Me.lstResumen = New ListBox()

        Me.btnInscribir = New Button()
        Me.errorProvider1 = New ErrorProvider()
        Me.toolTip1 = New ToolTip()

        Me.Text = "Inscripción a Curso"
        Me.ClientSize = New Size(820, 600)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimumSize = New Size(650, 500)

        Me.errorProvider1.ContainerControl = Me
        Me.errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink

        Me.tabControlPrincipal.Dock = DockStyle.Fill
        Me.tabControlPrincipal.TabPages.Add(Me.tabDatosAlumno)
        Me.tabControlPrincipal.TabPages.Add(Me.tabMateriasHorario)

        Me.tabDatosAlumno.Text = "Datos del alumno"
        Me.tabDatosAlumno.Padding = New Padding(10)

        Me.tabMateriasHorario.Text = "Materias y horario"
        Me.tabMateriasHorario.Padding = New Padding(10)

        Me.grpDatosAlumno.Text = "Datos del alumno"
        Me.grpDatosAlumno.Dock = DockStyle.Top
        Me.grpDatosAlumno.Height = 190
        Me.grpDatosAlumno.Padding = New Padding(10)


        Me.tlpDatos.Dock = DockStyle.Fill
        Me.tlpDatos.ColumnCount = 2
        Me.tlpDatos.RowCount = 3
        Me.tlpDatos.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35.0F))
        Me.tlpDatos.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 65.0F))
        Me.tlpDatos.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3F))
        Me.tlpDatos.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3F))
        Me.tlpDatos.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3F))

        Me.lblNombre.Text = "Nombre completo:"
        Me.lblNombre.Anchor = AnchorStyles.Left
        Me.lblNombre.AutoSize = True

        Me.txtNombre.Dock = DockStyle.Fill
        Me.txtNombre.Margin = New Padding(3, 6, 3, 6)

        Me.lblFechaNacimiento.Text = "Fecha de nacimiento:"
        Me.lblFechaNacimiento.Anchor = AnchorStyles.Left
        Me.lblFechaNacimiento.AutoSize = True

        Me.dtpFechaNacimiento.Dock = DockStyle.Fill
        Me.dtpFechaNacimiento.Format = DateTimePickerFormat.Short
        Me.dtpFechaNacimiento.Margin = New Padding(3, 6, 3, 6)
        Me.dtpFechaNacimiento.MaxDate = DateTime.Now.Date

        Me.lblSemestre.Text = "Semestre:"
        Me.lblSemestre.Anchor = AnchorStyles.Left
        Me.lblSemestre.AutoSize = True

        Me.nudSemestre.Dock = DockStyle.Fill
        Me.nudSemestre.Margin = New Padding(3, 6, 3, 6)
        Me.nudSemestre.Minimum = 1
        Me.nudSemestre.Maximum = 12
        Me.nudSemestre.Value = 1

        Me.tlpDatos.Controls.Add(Me.lblNombre, 0, 0)
        Me.tlpDatos.Controls.Add(Me.txtNombre, 1, 0)
        Me.tlpDatos.Controls.Add(Me.lblFechaNacimiento, 0, 1)
        Me.tlpDatos.Controls.Add(Me.dtpFechaNacimiento, 1, 1)
        Me.tlpDatos.Controls.Add(Me.lblSemestre, 0, 2)
        Me.tlpDatos.Controls.Add(Me.nudSemestre, 1, 2)

        Me.grpDatosAlumno.Controls.Add(Me.tlpDatos)
        Me.tabDatosAlumno.Controls.Add(Me.grpDatosAlumno)


        Me.toolTip1.SetToolTip(Me.nudSemestre, "Selecciona el semestre que cursas actualmente (1 a 12).")


        Me.flpTurno.Dock = DockStyle.Top
        Me.flpTurno.Height = 45
        Me.flpTurno.FlowDirection = FlowDirection.LeftToRight
        Me.flpTurno.WrapContents = False

        Me.lblTurno.Text = "Turno:"
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Margin = New Padding(3, 10, 6, 3)

        Me.cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmbTurno.Width = 160
        Me.cmbTurno.Margin = New Padding(3, 6, 3, 3)
        Me.cmbTurno.Items.AddRange(New Object() {"Matutino", "Vespertino"})
        AddHandler Me.cmbTurno.SelectedIndexChanged, AddressOf CmbTurno_SelectedIndexChanged

        Me.flpTurno.Controls.Add(Me.lblTurno)
        Me.flpTurno.Controls.Add(Me.cmbTurno)

        Me.splitMaterias.Size = New Size(600, 400)
        Me.splitMaterias.Panel1MinSize = 200
        Me.splitMaterias.Panel2MinSize = 200
        Me.splitMaterias.SplitterDistance = 250
        Me.splitMaterias.Dock = DockStyle.Fill
        Me.lblMateriasDisponibles.Text = "Materias disponibles:"
        Me.lblMateriasDisponibles.Dock = DockStyle.Top
        Me.lblMateriasDisponibles.AutoSize = False
        Me.lblMateriasDisponibles.Height = 22
        Me.lblMateriasDisponibles.Padding = New Padding(3, 4, 0, 0)

        Me.clbMaterias.Dock = DockStyle.Fill
        Me.clbMaterias.CheckOnClick = True
        Me.clbMaterias.Items.AddRange(New Object() {
            "Matemáticas",
            "Programación Visual",
            "Bases de Datos",
            "Redes",
            "Inglés",
            "Gestión Empresarial"
        })
        AddHandler Me.clbMaterias.ItemCheck, AddressOf ClbMaterias_ItemCheck

        Me.splitMaterias.Panel1.Controls.Add(Me.clbMaterias)
        Me.splitMaterias.Panel1.Controls.Add(Me.lblMateriasDisponibles)

        Me.lblResumen.Text = "Resumen de materias seleccionadas:"
        Me.lblResumen.Dock = DockStyle.Top
        Me.lblResumen.AutoSize = False
        Me.lblResumen.Height = 22
        Me.lblResumen.Padding = New Padding(3, 4, 0, 0)

        Me.lstResumen.Dock = DockStyle.Fill
        Me.lstResumen.IntegralHeight = False

        Me.splitMaterias.Panel2.Controls.Add(Me.lstResumen)
        Me.splitMaterias.Panel2.Controls.Add(Me.lblResumen)

        Me.toolTip1.SetToolTip(Me.clbMaterias, "Marca al menos una materia. Máximo recomendado: 6 materias por semestre.")

        Me.tabMateriasHorario.Controls.Add(Me.splitMaterias)
        Me.tabMateriasHorario.Controls.Add(Me.flpTurno)


        Me.btnInscribir.Text = "Inscribir"
        Me.btnInscribir.Dock = DockStyle.Bottom
        Me.btnInscribir.Height = 42
        Me.btnInscribir.Font = New Font(Me.btnInscribir.Font.FontFamily, 10, FontStyle.Bold)
        AddHandler Me.btnInscribir.Click, AddressOf BtnInscribir_Click

        Me.Controls.Add(Me.tabControlPrincipal)
        Me.Controls.Add(Me.btnInscribir)

    End Sub

    Private Sub ClbMaterias_ItemCheck(sender As Object, e As ItemCheckEventArgs)
        Me.BeginInvoke(New MethodInvoker(AddressOf ActualizarResumen))
    End Sub

    Private Sub CmbTurno_SelectedIndexChanged(sender As Object, e As EventArgs)
        ActualizarResumen()
    End Sub

    Private Sub ActualizarResumen()
        lstResumen.Items.Clear()

        For Each materiaSeleccionada As Object In clbMaterias.CheckedItems
            lstResumen.Items.Add(materiaSeleccionada.ToString())
        Next

        If clbMaterias.CheckedItems.Count = 0 Then
            lstResumen.Items.Add("(Sin materias seleccionadas)")
        End If

        lstResumen.Items.Add("-----------------------")

        If cmbTurno.SelectedIndex <> -1 Then
            lstResumen.Items.Add("Turno: " & cmbTurno.SelectedItem.ToString())
        Else
            lstResumen.Items.Add("Turno: (sin seleccionar)")
        End If
    End Sub

    Private Sub BtnInscribir_Click(sender As Object, e As EventArgs)
        If ValidarFormulario() Then
            Dim materiasSeleccionadas As New List(Of String)
            For Each materia As Object In clbMaterias.CheckedItems
                materiasSeleccionadas.Add(materia.ToString())
            Next

            Dim mensaje As String =
                "Inscripción realizada con éxito." & Environment.NewLine & Environment.NewLine &
                "Alumno: " & txtNombre.Text.Trim() & Environment.NewLine &
                "Semestre: " & nudSemestre.Value.ToString() & Environment.NewLine &
                "Turno: " & cmbTurno.SelectedItem.ToString() & Environment.NewLine &
                "Materias: " & String.Join(", ", materiasSeleccionadas)

            MessageBox.Show(mensaje, "Inscripción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(
                "Revisa los campos marcados con el ícono de error antes de continuar.",
                "Datos inválidos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function ValidarFormulario() As Boolean
        Dim esValido As Boolean = True

        errorProvider1.Clear()

        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            errorProvider1.SetError(txtNombre, "El nombre no puede estar vacío.")
            esValido = False
        End If

        If dtpFechaNacimiento.Value.Date > DateTime.Now.Date Then
            errorProvider1.SetError(dtpFechaNacimiento, "La fecha de nacimiento no puede ser posterior a la fecha actual.")
            esValido = False
        End If

        If cmbTurno.SelectedIndex = -1 Then
            errorProvider1.SetError(cmbTurno, "Debes seleccionar un turno.")
            esValido = False
        End If

        If clbMaterias.CheckedItems.Count = 0 Then
            errorProvider1.SetError(clbMaterias, "Selecciona al menos una materia.")
            esValido = False
        End If

        Dim semestreValor As Integer
        Dim semestreEsNumerico As Boolean = Integer.TryParse(nudSemestre.Value.ToString(), semestreValor)

        If Not semestreEsNumerico OrElse semestreValor < 1 OrElse semestreValor > 12 Then
            errorProvider1.SetError(nudSemestre, "El semestre debe ser un número entero entre 1 y 12.")
            esValido = False
        End If

        Return esValido
    End Function

End Class
