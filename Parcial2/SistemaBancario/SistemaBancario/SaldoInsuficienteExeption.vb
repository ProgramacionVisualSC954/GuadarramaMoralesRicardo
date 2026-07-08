Public Class SaldoInsuficienteException
    Inherits Exception

    Public Property SaldoActual As Decimal

    Public Property MontoSolicitado As Decimal

    Public Sub New(saldoActual As Decimal, montoSolicitado As Decimal)
        MyBase.New($"Saldo insuficiente. Disponible: {saldoActual:C}, montoSolicitado ")
        Me.SaldoActual = saldoActual
        Me.MontoSolicitado = montoSolicitado
    End Sub


End Class