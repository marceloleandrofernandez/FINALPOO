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

        Console.ReadKey()
    End Sub
    

End Module
