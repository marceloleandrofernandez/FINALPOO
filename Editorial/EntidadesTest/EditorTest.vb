Imports Entidades
Module EditorTest
    Sub Main()
        Dim edit As New Editor(333, "pepe")
        Dim edit2 As New Editor(111, "jose")

        Dim mat As New Libro(123123, "ashdahsdhasd", 100.75)
        Dim mat2 As New Borrador("Unlibrocoso", 25.77)
        Try
            edit.Nombre = "a"
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try
        Try
            edit.Nombre = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try


        edit.AddMaterial(mat)
        edit.AddMaterial(mat2)
        Material.PorcentajeEditorPorBorrador = 50
        Material.PorcentajeEditorPorLibro = 10

        For Each item In edit.getALLmaterial()
            Console.WriteLine("Titulo Material {0}", item.Titulo)
            ' corregido todo lo que  viene
            Console.WriteLine("Editor.Nombre {0}", item.Editor.Nombre)
            Console.WriteLine("MontoContrato {0}", item.MontoContrato)
            Console.WriteLine("GananciaEditor {0}", item.GananciaEditor)
        Next
        Console.WriteLine("CalcularGanancia {0}", edit.CalcularGanancia)
        Console.ReadKey()

    End Sub
    

End Module
