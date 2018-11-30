Public Class Libro
    Inherits Material

    Private _ISBN As String

    Public Property ISBN As String
        Get
            Return _ISBN
        End Get
        Set(value As String)
            If value.Length < 3 Or value.Length > 20 Then
                Throw New ArgumentException("Mayor a 3 y menor a 20 Caracteres")
            Else
                _ISBN = value
            End If

        End Set
    End Property
    Sub New(isbn As String, titulo As String, montoContrato As Decimal)
        MyBase.New(titulo, montoContrato)
        Me.ISBN = isbn
    End Sub
    Public Overrides Function ToString() As String
        Return ISBN
    End Function
End Class
