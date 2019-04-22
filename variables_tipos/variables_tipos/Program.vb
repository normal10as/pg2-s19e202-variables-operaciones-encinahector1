Imports System

Module variables_tipos
    Sub Main(args As String())
        Dim NombreDeUnaPersona, LugarDeNacimiento, NombreCalle As String
        Dim NumeroDeDocumento, DistanciaEntreCiudades, CantidadDeHabitantes, ProfundidadDelMar, AlturaDeCalle As UInteger
        Dim FechaDeNacimiento As Date
        Dim AlturaCorporal, TemperaturaAmbiente, PesoDeProducto, MontoDeArticulo As Single
        Dim SiEsArgentino As Boolean
        NombreDeUnaPersona = "Hector"
        LugarDeNacimiento = "Posadas, Misiones"
        NombreCalle = "Santa Catalina"
        NumeroDeDocumento = "30.001.100"
        DistanciaEntreCiudades = "1.000"
        CantidadDeHabitantes = "44.270.000"
        ProfundidadDelMar = "3.900"
        AlturaDeCalle = "3.300"
        FechaDeNacimiento = "10/05/93"
        AlturaCorporal = "174,20"
        TemperaturaAmbiente = "24,8"
        PesoDeProducto = "1,5"
        MontoDeArticulo = "470,50"
        SiEsArgentino = "True"
        Console.Write("nombre: " & NombreDeUnaPersona + vbCrLf)
        Console.Write(" D.N.I: " & NumeroDeDocumento)
        Console.Write(" lugar de nacimiento: " & LugarDeNacimiento + vbCrLf)
        Console.Write(" fecha de nacimiento: " & FechaDeNacimiento & " D.C ")
        Console.Write(" altura corporal: " & AlturaCorporal & "(cms)")
        Console.Write(" sos Argentino: " & SiEsArgentino)
        Console.Write(" temperatura ambiente: " & TemperaturaAmbiente)
        Console.Write(" nombre de calle: " & NombreCalle + vbCrLf)
        Console.Write(" altura de la calle: " & AlturaDeCalle)
        Console.Write(" distancia entre ciudades: " & DistanciaEntreCiudades)
        Console.Write(" profundidad del mar: " & ProfundidadDelMar)
        Console.Write(" cantidad de habitantes del territorio nacioneal: " & CantidadDeHabitantes)
        Console.Write(" peso de un producto en kg : " & PesoDeProducto)
        Console.Write(" monto de articulo : " & MontoDeArticulo)

    End Sub
End Module
