Imports Entidades

Module EditorialTest
    Sub main()
        Dim aut As New Autor(111, "Ramon")
        Dim aut2 As New Autor(222, "Jose")
        Dim edit As New Editor(333, "pepe")
        Dim edit2 As New Editor(444, "Nino")
        Dim mat As New Libro(123123, "Menos Vendidos", 100.75)
        Dim mat2 As New Borrador("Unlibrocoso", 25.77)
        Dim mat3 As New Borrador("MASSSVENDIDOOO", 25.77)
        aut.AddMaterial(mat)
        aut.AddMaterial(mat2)
        aut.AddMaterial(mat3)
        aut2.AddMaterial(mat2)
        edit.AddMaterial(mat)
        edit2.AddMaterial(mat2)
        edit2.AddMaterial(mat3)
        Editorial.AddMaterial(mat)
        Editorial.AddMaterial(mat2)
        Editorial.AddMaterial(mat3)
        Console.WriteLine("Todos")
        For Each material In Editorial.getAllMateriales
            Console.WriteLine("material.ToString: " & material.ToString)
        Next

        MostrarAutorMateriales(aut)
        MostrarAutorMateriales(aut2)

        BuscarAutorPorDNI(222)
        BuscarAutorPorDNI(333)

        Console.WriteLine("Lista de empleados")
        For Each empleado In Editorial.GetAllEmpleados
            Console.WriteLine(empleado)
        Next
    End Sub

    Private Sub BuscarAutorPorDNI(dni As UInteger)
        Try
            Console.WriteLine("Buscando autor  por dni " & dni)
            Console.WriteLine("material.ToString: " & Editorial.getAutor(dni).ToString)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub MostrarAutorMateriales(aut As Autor)
        Console.WriteLine(aut)
        For Each material In Editorial.getALLMateriales(aut)
            Console.WriteLine("material.ToString: " & material.ToString)
        Next
    End Sub
End Module
