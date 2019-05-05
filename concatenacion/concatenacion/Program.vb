Imports System

Module concatenacion
    Sub Main(args As String())

        Dim NombreDeLaEmpresa, NombreDeLaCalle As String
        Dim AlturaDeCalle As UInteger
        Dim FechaDeInicio As Date
        NombreDeLaEmpresa = "Hola Mundo s.a"
        NombreDeLaCalle = "Siempre Viva"
        FechaDeInicio = "10-10-2029"
        AlturaDeCalle = 1234
        Console.Write("empresa: " & NombreDeLaEmpresa & " calle: " & NombreDeLaCalle & "  altura: " & AlturaDeCalle & "  fecha inicio: " & FechaDeInicio)
        Convert.ToString({AlturaDeCalle})
        Convert.ToString({FechaDeInicio})
        Console.Write("empresa: " & NombreDeLaEmpresa & " calle: " & NombreDeLaCalle & "  altura: " & AlturaDeCalle & "  fecha inicio: " & FechaDeInicio)

    End Sub
End Module
