Public Class Libro
    Inherits Material
    ' override the following inherited 'MustOverride' member(s): 
    'Material: Public MustOverride Function GananciaPorcentajePorAutor() As Byte.

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
        'Return ISBN corregido
        Dim cadena As String = Titulo
        For Each autor In getALLAutores()
            cadena += autor.Nombre & ", "
        Next
        Return cadena.Substring(0, cadena.Length - 2) & "(" & ISBN & ")"
    End Function

    Public Overrides Function GananciaPorcentajePorAutor() As Byte
        'Throw New NotImplementedException()
        ' sin implementar funcionalidad, agregado
        Return (100 - PorcentajeEditorPorLibro) / getALLAutores.Count
    End Function
End Class
