// See https://aka.ms/new-console-template for more information
using ClasesObjetosyConstructores;

internal class Program
{
    private static void Main(string[] args)
    {
        //declaro lista
        List<Bebida> bebidas = new List<Bebida>();



        var patero = new Vino("Vino Patero", 1000);
        var ipa = new Cerveza("IPA", 600, "Andes");

        
      
        //muestro elementos con foreach
        foreach (Bebida bebida in bebidas)
        {
            Console.WriteLine(bebida);
        }

        
    }


}