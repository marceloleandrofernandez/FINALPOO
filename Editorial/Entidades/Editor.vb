Public Class Editor
    Implements Empleado
    Private _dni As UInteger
    Private _nombre As String
    Private _materiales As New List(Of Material)


    Public Function CalcularGanancia() As Decimal Implements Empleado.CalcularGanancia
        Dim total As Decimal        ' agregado
        For Each item In _materiales
            'Console.WriteLine(item.MontoContrato)
            total += item.GananciaEditor() ' agregado
        Next
        'Return False
        Return total ' agregado
    End Function

    Public Property Dni As UInteger Implements Empleado.Dni
        Get
            Return _dni
        End Get
        Set(value As UInteger)
            If value < 0 Then 'redundante pues el tipo de datos ya no adminte negativos
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
            Else
                _nombre = value
            End If

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
        material.Editor = Me
        _materiales.Add(material)
    End Sub
    Public Sub removeMaterial(material As Material)
        material.Editor = Nothing
        _materiales.Remove(material)
    End Sub
    Public Function getALLmaterial() As List(Of Material)
        Return _materiales
    End Function
End Class
