internal class Program
{
    private static void Main(string[] args)
    {
        string[] nombres = new string[5] { "pedro", "ana", "juan", "maxi", "lola" };



        for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine("El nombre " + (i+1) + " es: " + nombres[i]);
        }

        Console.WriteLine("************************************");
        Console.WriteLine("FOREACH");

        int p = 1;
        foreach (var posicion in nombres)
        {
            Console.WriteLine("El nombre " + p++ + " es: " + posicion);
        }
    }
}