Imports System

Module Program
    Sub Main(args As String())
        Dim a, b As UInteger
        Dim c, d, x As Double
        a = 4
        b = 6
        c = 2.5
        d = 3.8
        x = a + b
        Console.Write("suma de entero con entero: 4 + 6 = " & x & vbCrLf)
        x = a * b
        Console.Write("producto de entero con entero: 4 * 6 = " & x & vbCrLf)
        x = a / c
        Console.Write("division de entero con punto flotante: 4 / 2.5 = " & x & vbCrLf)
        x = c - d
        Console.Write("resta de punto flotante con punto flotante: 2.5 - 3.8 = " & x & vbCrLf)



        Console.ReadKey()
    End Sub
End Module
