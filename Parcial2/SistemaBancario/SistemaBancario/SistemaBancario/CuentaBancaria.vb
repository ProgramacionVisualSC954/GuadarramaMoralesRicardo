Public Class CuentaBancaria
    Private _saldo As Decimal

    Public Sub New(saldoInicial As Decimal)
        _saldo = saldoInicial
    End Sub

    Public ReadOnly Property Saldo As Decimal
        Get
            Return _saldo
        End Get
    End Property

    Public Sub Retirar(monto As Decimal)
        If monto > _saldo Then
            Throw New SaldoInsuficienteException(_saldo, monto)

        End If
        _saldo -= monto
    End Sub
End Class
