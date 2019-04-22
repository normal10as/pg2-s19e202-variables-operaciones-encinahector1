Imports System

Module Variables
    Sub Main()
        Dim NombreyApe As String
        Dim FechaNacimiento As Date
        Console.Write("Ingrese nombre y apellido:")
        NombreyApe = Console.ReadLine()
        Console.Write("Ingrese fecha de nacimiento dia/mes/ano:")
        FechaNacimiento = Console.ReadLine()
        Console.WriteLine(NombreyApe & " nacio el " & FechaNacimiento)
    End Sub
End Module
