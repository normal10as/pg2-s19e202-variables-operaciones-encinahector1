Imports System

Module Program
    Sub Main(args As String())
        Dim Nota1, Nota2, Nota3, Nota4, Suma As UInteger
        Dim Media As Single
        Console.Write("Ingrese primer nota:")
        Nota1 = Console.ReadLine()
        Console.Write("Ingrese segunda nota:")
        Nota2 = Console.ReadLine()
        Console.Write("Ingrese tercer nota:")
        Nota3 = Console.ReadLine()
        Console.Write("Ingrese cuarta nota:")
        Nota4 = Console.ReadLine()
        Suma = Nota1 + Nota2 + Nota3 + Nota4
        Media = (Nota1 + Nota2 + Nota3 + Nota4) / 4
        Console.Write("suma de todos los num.: " & Suma & "  media: " & Media)


    End Sub
End Module
