Imports Entidades
Module LibroTest
    Sub Main()
        Dim libro As New Libro("3325sdfg", "PERON PERON", 154.77)
        Try
            libro.ISBN = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try

        ' agregado por incompleto
        Material.PorcentajeEditorPorLibro = 10
        Dim Editor1 = New Editor(12345678, "Glaciar")
        Editor1.AddMaterial(libro)
        Dim autor1 = New Autor(23456789, "Mou")
        autor1.AddMaterial(libro)
        Console.WriteLine("PorcentajeEditorPorLibro:" & Libro.PorcentajeEditorPorLibro)
        Console.WriteLine("Titulo:" & libro.Titulo)
        Console.WriteLine("ISBN:" & libro.ISBN)
        Console.WriteLine("MontoContrato:" & libro.MontoContrato)
        Console.WriteLine("GananciaEditor:" & libro.GananciaEditor())
        MostrarAutores(libro)
        AgregarAutor(libro, New Autor(34567891, "Larry"))
        AgregarAutor(libro, New Autor(45678912, "Curly"))
        AgregarAutor(libro, New Autor(56789123, "Joe"))
        Console.ReadKey()
    End Sub

    Private Sub AgregarAutor(libro As Libro, autor As Autor)
        Try
            Console.WriteLine("Agregar autor")
            autor.AddMaterial(libro)
            MostrarAutores(libro)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub MostrarAutores(libro As Libro)
        For Each autor In libro.getALLAutores
            Console.WriteLine("autor.ToString:" & autor.ToString)
        Next
        Console.WriteLine("GananciaPorcentajePorAutor:" & libro.GananciaPorcentajePorAutor)
    End Sub
End Module
