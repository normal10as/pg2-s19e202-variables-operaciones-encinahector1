Imports System

Module Program
    Sub Main(args As String())
        Dim a, b, c As Byte
        Dim x As Single
        a = 1
        b = 5
        c = 2
        x = ((b ^ 2) - (4 * a * c)) / (2 * a)
        Console.Write("((b ^ 2) - (4 * a * c)) / (2 * a)= " & x)

    End Sub
End Module
