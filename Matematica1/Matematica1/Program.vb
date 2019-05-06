Imports System.Math

Module Matematica1
    Sub Main(args As String())
        Dim Num, Num1, Absoluto As Decimal

        Console.Write("ingrese numero: ")
        Num1 = Console.ReadLine()
        Num = Num1
        Absoluto = Abs(Num1)
        Console.WriteLine("valor absoluto: " & Absoluto)
        Num1 ^= 10
        Console.WriteLine(" ^10: " & Num1)
        Num ^= (1 / 2)
        Console.WriteLine("raiz cuadrada: " & Num)
    End Sub
End Module
