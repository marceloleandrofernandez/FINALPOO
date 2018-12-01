Public NotInheritable Class Autor
    Implements Empleado
    Private _dni As UInteger
    Private _nombre As String
    Private _materiales As New List(Of Material)

    Public Property Dni As UInteger Implements Empleado.Dni
        Get
            Return _dni
        End Get
        Set(value As UInteger)
            If value < 0 Then
                Throw New ArgumentException("no se admiten Valores Negativos")
            Else
                _dni = value
            End If
        End Set
    End Property
    Public Property Nombre As String Implements Empleado.Nombre
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Length < 3 Or value.Length > 30 Then
                Throw New ArgumentException("Mayor a 3 y menor a 30 Caracteres")
            End If
            _nombre = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Nombre & " " & Dni
    End Function
    Sub New(dni As UInteger, nombre As String)
        Me.Dni = dni
        Me.Nombre = nombre
        _materiales = New List(Of Material)

    End Sub
    Public Sub AddMaterial(material As Material)
        If material.getALLAutores().Count() >= 3 Then
            ' debe lanzar excepción si se pasa la regla de cardinalidad
            Throw New Exception("Solo se pueden agregar 3 autores")
        Else
            material.AddAutor(Me)
            _materiales.Add(material)
        End If
        
    End Sub
    Public Sub removeMaterial(material As Material)
        'material.AddAutor(Nothing) 'corregido
        material.removeAutor(Me)
        _materiales.Remove(material)
    End Sub
    Public Function getALLmaterial() As List(Of Material)
        Return _materiales
    End Function
    Public Function CalcularGanancia() As Decimal Implements Empleado.CalcularGanancia
        'Return False
        ' falta implementar la solución. corregido
        Dim total As Decimal
        For Each item In _materiales
            total += item.MontoContrato * item.GananciaPorcentajePorAutor / 100
        Next
        Return total
    End Function
End Class
