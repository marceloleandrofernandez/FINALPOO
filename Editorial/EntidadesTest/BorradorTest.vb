Imports Entidades
Module BorradorTest

    Sub Main()
        Dim borr As New Borrador("Coso", 100.45)

        Console.WriteLine(borr.Titulo)
        Console.WriteLine(borr.MontoContrato)
        Console.WriteLine("************")
        borr.Titulo = "OTRO COSO"
        borr.MontoContrato = 45.77

        Console.WriteLine(borr.Titulo)
        Console.WriteLine(borr.MontoContrato)

        ' agregado por incompleto
        Material.PorcentajeEditorPorBorrador = 50
        Dim Editor1 = New Editor(12345678, "Glaciar")
        Editor1.AddMaterial(borr)
        Console.WriteLine("GananciaEditor:" & borr.GananciaEditor())

        Console.ReadKey()


    End Sub

End Module
