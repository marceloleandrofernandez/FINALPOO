Public Class Editorial
    Public Shared _material As List(Of Material)
    Public Shared _materialesAutor As List(Of Material)
    Public Shared _autores As List(Of Autor)

    Shared Sub New()
        _autores = New List(Of Autor)
        _materialesAutor = New List(Of Material)
        _material = New List(Of Material)
    End Sub

    Public Shared Sub AddMaterial(material As Material)
        _material.Add(material)
    End Sub
    Public Shared Sub removeMaterial(material As Material)
        _material.Remove(material)
    End Sub
    Public Shared Function getAllMateriales() As List(Of Material)
        Return _material
    End Function
    Public Shared Function getMateriales(nombre As String) As List(Of Material)
        _materialesAutor = New List(Of Material)
        For Each item In _material
            If item.Editor.Nombre.Equals(nombre) Then
                _materialesAutor.Add(item)
            End If
        Next
        Return _materialesAutor
    End Function
    Public Shared Function getAutor(dni As UInteger)
        'Return _personas.Find(Function(c) c.Dni = dni)
        For Each Persona In _autores
            If Persona.Dni.Equals(dni) Then
                Return Persona
            End If
        Next
    End Function

End Class
