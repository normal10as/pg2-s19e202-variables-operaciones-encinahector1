Imports System

Module Program
    Sub Main(args As String())
        Dim m, r, i As Decimal
        Dim t As Integer
        Console.Write("ingrese monto: ")
        m = Console.ReadLine()
        Console.Write("ingresar interes anual: ")
        r = Console.ReadLine()
        Console.Write("ingrese dias: ")
        t = Console.ReadLine()
        i = (m * r * t) / (360 * 100)
        Console.Write("interes anual: " & i)

    End Sub
End Module
