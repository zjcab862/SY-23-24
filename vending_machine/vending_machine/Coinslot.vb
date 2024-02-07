Public Class Coinslot
    Public Property quarters As Integer
    Public Property nickles As Integer
    Public Property dimes As Integer
    Public Property dollars As Integer
    Public ReadOnly Property total As Decimal
        Get
            Return dollars + quarters * 0.25 + dimes * 0.1 + nickles * 0.05
        End Get
    End Property

    Public Sub instertQuarter()
        quarters = quarters + 1
    End Sub
    Public Sub insertNickle()
        nickles = nickles + 1
    End Sub
    Public Sub insertDime()
        dimes = dimes + 1
    End Sub
    Public Sub insertDollar()
        dollars = dollars + 1
    End Sub
End Class
