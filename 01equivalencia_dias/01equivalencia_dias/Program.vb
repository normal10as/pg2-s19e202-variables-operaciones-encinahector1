Imports System

Module Program
    Sub Main(args As String())
        Dim DiaPorSemana As Single
        Dim DiasPorHora, MinutosPorHora As UInteger
        Console.Write("ingrese la cantidad de dias: ")
        DiaPorSemana = Console.ReadLine()
        DiasPorHora = DiaPorSemana * 24
        MinutosPorHora = DiaPorSemana * 1440
        DiaPorSemana = DiaPorSemana / 7
        Console.Write("|numero de semanas: " & DiaPorSemana & "  |  numero de horas: " & DiasPorHora & " | numero de minutos: " & MinutosPorHora)

    End Sub
End Module
