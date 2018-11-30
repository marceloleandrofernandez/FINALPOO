Public Class Borrador
    Inherits Material
    Sub New(titulo As String, montoContrato As Decimal)
        MyBase.New(titulo, montoContrato)
    End Sub
    Public Overrides Function ToString() As String
        Return Titulo & MontoContrato
    End Function
End Class
