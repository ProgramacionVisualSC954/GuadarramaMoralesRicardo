Public Class Form1

    Dim primerNumero As Double
    Dim segundoNumero As Double
    Dim operacion As String
    Dim resultado As Double
    Dim escribiendoSegundo As Boolean = False

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox2.Text = TextBox2.Text & "1"
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox2.Text = TextBox2.Text & "2"
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox2.Text = TextBox2.Text & "3"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox2.Text = TextBox2.Text & "4"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox2.Text = TextBox2.Text & "5"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox2.Text = TextBox2.Text & "6"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox2.Text = TextBox2.Text & "7"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox2.Text = TextBox2.Text & "8"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox2.Text = TextBox2.Text & "9"
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If TextBox2.Text <> "" Then
            TextBox2.Text = TextBox2.Text & "0"
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If Not TextBox2.Text.Contains(".") Then
            If TextBox2.Text = "" Then
                TextBox2.Text = "0."
            Else
                TextBox2.Text = TextBox2.Text & "."
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox2.Text = "" Then Exit Sub
        primerNumero = CDbl(TextBox2.Text)
        operacion = "÷"
        TextBox1.Text = primerNumero & " ÷"
        TextBox2.Text = ""
        escribiendoSegundo = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = "" Then Exit Sub
        primerNumero = CDbl(TextBox2.Text)
        operacion = "*"
        TextBox1.Text = primerNumero & " ×"
        TextBox2.Text = ""
        escribiendoSegundo = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox2.Text = "" Then Exit Sub
        primerNumero = CDbl(TextBox2.Text)
        operacion = "-"
        TextBox1.Text = primerNumero & " −"
        TextBox2.Text = ""
        escribiendoSegundo = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox2.Text = "" Then Exit Sub
        primerNumero = CDbl(TextBox2.Text)
        operacion = "+"
        TextBox1.Text = primerNumero & " +"
        TextBox2.Text = ""
        escribiendoSegundo = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox2.Text = "" Then Exit Sub
        If operacion = "" Then Exit Sub

        segundoNumero = CDbl(TextBox2.Text)
        TextBox1.Text = primerNumero & " " & operacion & " " & segundoNumero & " ="

        If operacion = "+" Then
            resultado = primerNumero + segundoNumero
        ElseIf operacion = "-" Then
            resultado = primerNumero - segundoNumero
        ElseIf operacion = "*" Then
            resultado = primerNumero * segundoNumero
        ElseIf operacion = "÷" Then
            If segundoNumero = 0 Then
                MessageBox.Show("No se puede dividir entre cero!")
                TextBox2.Text = ""
                Exit Sub
            End If
            resultado = primerNumero / segundoNumero
        End If

        TextBox2.Text = resultado.ToString()
        operacion = ""
        escribiendoSegundo = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        primerNumero = 0
        segundoNumero = 0
        resultado = 0
        operacion = ""
        escribiendoSegundo = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox2.Text.Length > 0 Then
            TextBox2.Text = TextBox2.Text.Substring(0, TextBox2.Text.Length - 1)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox2.Text <> "" Then
            resultado = CDbl(TextBox2.Text) / 100
            TextBox1.Text = TextBox2.Text & " %"
            TextBox2.Text = resultado.ToString()
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If TextBox2.Text <> "" Then
            resultado = CDbl(TextBox2.Text) * -1
            TextBox2.Text = resultado.ToString()
        End If
    End Sub

End Class
