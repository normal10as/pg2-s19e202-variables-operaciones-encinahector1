Imports System

Module variables_tipos
    Sub Main(args As String())
        Dim NombreDeUnaPersona, LugarDeNacimiento, NombreCalle As String
        Dim NumeroDeDocumento, DistanciaEntreCiudades, CantidadDeHabitantes, ProfundidadDelMar, AlturaDeCalle As UInteger
        Dim FechaDeNacimiento As Date
        Dim AlturaCorporal, TemperaturaAmbiente, PesoDeProducto, MontoDeArticulo As Decimal
        Dim SiEsArgentino As Boolean

        Console.Write("nombre: ")
        NombreDeUnaPersona = Console.ReadLine()
        Console.Write(" D.N.I: ")
        NumeroDeDocumento = Console.ReadLine()
        Console.Write(" lugar de nacimiento: ")
        LugarDeNacimiento = Console.ReadLine()
        Console.Write(" fecha de nacimiento: ")
        FechaDeNacimiento = Console.ReadLine()
        Console.Write(" altura corporal (cms): ")
        AlturaCorporal = Console.ReadLine()
        Console.Write(" sos Argentino(true and false): ")
        SiEsArgentino = Console.ReadLine()
        Console.Write(" temperatura ambiente: ")
        TemperaturaAmbiente = Console.ReadLine()
        Console.Write(" nombre de calle: ")
        NombreCalle = Console.ReadLine()
        Console.Write(" altura de la calle: ")
        AlturaDeCalle = Console.ReadLine()
        Console.Write(" distancia entre ciudades: ")
        DistanciaEntreCiudades = Console.ReadLine()
        Console.Write(" profundidad del mar: ")
        ProfundidadDelMar = Console.ReadLine()
        Console.Write(" cantidad de habitantes del territorio nacioneal: ")
        CantidadDeHabitantes = Console.ReadLine()
        Console.Write(" peso de un producto en kg : ")
        PesoDeProducto = Console.ReadLine
        Console.Write(" monto de articulo : ")
        MontoDeArticulo = Console.ReadLine()

        Console.Write("nombre: " & NombreDeUnaPersona & " D.N.I: " & NumeroDeDocumento & " lugar de nac.: " & LugarDeNacimiento & " fecha de nac.: " & FechaDeNacimiento )
        Console.Write(" altura corporal : " & AlturaCorporal & " es argentino?? : " & SiEsArgentino & " temp. ambiente: " & TemperaturaAmbiente)
        Console.Write(" nombre de calle: " & NombreCalle & " altura de calle: " & AlturaDeCalle & " distancia entre ciudades: " & DistanciaEntreCiudades)
        Console.Write(" profundidad del mar: " & ProfundidadDelMar & " cantidad de habitantes: " & CantidadDeHabitantes & " peso de un producto en kg: " & PesoDeProducto)
        Console.Write(" monto de articulo: " & MontoDeArticulo)

    End Sub
End Module
