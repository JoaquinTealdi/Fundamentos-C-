﻿using Interfaz;

internal class Program
{
    private static void Main(string[] args)
    {
        //declaro lista
        List<Bebida> bebidas = new List<Bebida>();



        var patero = new Vino("Vino Patero", 1000);
        var ipa = new Cerveza("IPA", 600, "Andes");

        MostrarRecomendacion(patero);
        MostrarRecomendacion(ipa);
        //muestro elementos con foreach
        foreach (Bebida bebida in bebidas)
        {
            Console.WriteLine(bebida);
        }


    }


    //creamos metodo que unicamente sirva para objetos que implementen la interfaz " IBebidaAlcoholica"
    static void MostrarRecomendacion(IBebidaAlcoholica bebida)
    {
        bebida.MaximoRecomendado();
    }

}
