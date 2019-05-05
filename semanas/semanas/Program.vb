Imports System

Module Program
    Sub Main(args As String())
        Dim DiasDelAnio, DiasLaborables, DiasDeLaSemana As UShort
        Dim SemanasDelAnio, SemanasLaborables As Single
        DiasDelAnio = 365
        DiasDeLaSemana = 7
        DiasLaborables = 5
        SemanasDelAnio = 365 / 7
        SemanasLaborables = (DiasDelAnio / DiasLaborables) - SemanasDelAnio
        Console.Write("semanas del anio: " & SemanasDelAnio & "    semanas laborables: " & SemanasLaborables)

    End Sub
End Module
