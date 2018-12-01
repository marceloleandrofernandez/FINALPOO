Public Class Borrador
    Inherits Material
    ' override the following inherited 'MustOverride' member(s): 
    'Material: Public MustOverride Function GananciaPorcentajePorAutor() As Byte.

    Sub New(titulo As String, montoContrato As Decimal)
        MyBase.New(titulo, montoContrato)
    End Sub
    Public Overrides Function ToString() As String
        Return Titulo & MontoContrato ' falta editor
    End Function

    Public Overrides Function GananciaPorcentajePorAutor() As Byte
        'Throw New NotImplementedException()
        ' sin implementar funcionalidad, agregado
        Return (100 - PorcentajeEditorPorBorrador) / getALLAutores.Count
    End Function
End Class
