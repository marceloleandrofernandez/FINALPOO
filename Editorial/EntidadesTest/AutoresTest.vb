Imports Entidades
Module Autores
    Sub Main()
        Dim aut As New Autor(111, "Ramon")
        Dim aut2 As New Autor(222, "Jose")
        Dim mat As New Libro(123123, "Menos Vendidos", 100.75)
        Dim mat2 As New Borrador("Unlibrocoso", 25.77)
        Dim mat3 As New Borrador("MASSSVENDIDOOO", 25.77)
        Try
            aut.Nombre = "a"
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try
        Try
            aut.Nombre = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try


        aut.AddMaterial(mat)
        aut.AddMaterial(mat2)
        aut.AddMaterial(mat3)
        aut.AddMaterial(mat2)

        For Each item In aut.getALLmaterial()
            Console.WriteLine("Titulo Material {0}", item.Titulo)
            Console.WriteLine("Monto Material {0}", item.MontoContrato)
        Next
        Console.ReadKey()

    End Sub
End Module
