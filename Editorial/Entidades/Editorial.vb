Public Class Editorial
    Public Shared _materiales As List(Of Material)
    Public Shared _materialesAutor As List(Of Material) ' no requiere
    Public Shared _autores As List(Of Autor) ' no requiere

    Shared Sub New()
        _autores = New List(Of Autor)
        _materialesAutor = New List(Of Material)
        _materiales = New List(Of Material)
    End Sub

    Public Shared Sub AddMaterial(material As Material)
        _materiales.Add(material)
    End Sub
    Public Shared Sub removeMaterial(material As Material)
        _materiales.Remove(material)
    End Sub
    Public Shared Function getAllMateriales() As List(Of Material)
        Return _materiales
    End Function
    'Public Shared Function getMateriales(nombre As String) As List(Of Material) corregido
    Public Shared Function getALLMateriales(autor As Autor) As List(Of Material)
        _materialesAutor = New List(Of Material)
        For Each item In _materiales
            'If item.Editor.Nombre.Equals(nombre) Then corregido
            If item.getALLAutores.Contains(autor) Then
                _materialesAutor.Add(item)
            End If
        Next
        Return _materialesAutor
    End Function
    Public Shared Function getAutor(dni As UInteger) As Autor
        'Return _personas.Find(Function(c) c.Dni = dni)
        'For Each Persona In _autores
        '    If Persona.Dni.Equals(dni) Then
        '        Return Persona
        '    End If
        'Next corregido
        For Each material In _materiales
            If material.getALLAutores.Exists(Function(a) a.Dni = dni) Then
                Return material.getALLAutores.Find(Function(a) a.Dni = dni)
            End If
        Next
        Throw New Exception("Dni " & dni & " no pertenece a ningún autor")
    End Function

    'PRoxima función sin hacer nada
    Public Shared Function GetAllEmpleados() As List(Of Empleado)
        Dim empleados As New List(Of Empleado)
        For Each material In _materiales
            For Each empleado In material.getALLAutores
                If Not empleados.Contains(empleado) Then
                    empleados.Add(empleado)
                End If
            Next
            If Not empleados.Contains(material.Editor) Then
                empleados.Add(material.Editor)
            End If
        Next
        Return empleados
    End Function

End Class
