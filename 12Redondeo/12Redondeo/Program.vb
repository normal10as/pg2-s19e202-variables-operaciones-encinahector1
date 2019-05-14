Imports System.Math

Module Redondeo
    Sub Main(args As String())
        Dim ValorExceso, ValorAprox, ValorRedondeado, Num As Decimal
        Console.Write("ingrese numero: ")
        Num = Console.ReadLine()
        ValorExceso = Ceiling(Num)
        Console.WriteLine("valor aproximado por exceso: " & ValorExceso)
        ValorAprox = Floor(Num)
        Console.WriteLine("valor aproximado: " & ValorAprox)
        ValorRedondeado = Round(Num)
        Console.WriteLine("valor redondeado: " & ValorRedondeado)

    End Sub
End Module
