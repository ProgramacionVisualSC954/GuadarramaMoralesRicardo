Public Class Persona
    Private _edad As Integer

    Public Property Edad As Integer
        Get
            Return _edad
        End Get
        Set(value As Integer)
            If value < 18 OrElse value > 100 Then
                Throw New ArgumentOutOfRangeException(NameOf(Edad), $"La edad {value} está fuera del rango permitido entre 18 y 100 años")
            End If
            _edad = value
        End Set
    End Property
End Class
