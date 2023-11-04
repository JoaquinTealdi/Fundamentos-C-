internal class Program
{
    private static void Main(string[] args)
    {


        List<int> numeros = new () {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};

        var impares = (from i in numeros
                       where i % 2 != 0
                       select i);

        var pares = (from i in numeros
                       where i % 2 == 0
                       select i);

        var imparesDesc = (from i in numeros
                           where i % 2 != 0
                           select i).OrderByDescending(i => i);

        var paresDesc = (from i in numeros
                           where i % 2 == 0
                           select i).OrderByDescending(i => i);
        /*
        => otra forma de DESC a partir de la lista con datos obtenidos con LINQ
        var imparesDesc = impares.OrderByDescending(i => i);
        var paresDesc = pares.OrderByDescending(i => i);
        
         */

        Console.WriteLine("Los numeros impares del 0 al 20 son: ");
        foreach (var i in impares)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Los numeros pares del 0 al 20 son: ");
        foreach (var i in pares)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Los numeros impares del 0 al 20 ordenados de manera descendente son: ");
        foreach (var i in imparesDesc)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Los numeros pares del 0 al 20 ordenados de manera descendente son: ");
        foreach (var i in paresDesc)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("gracias :=)");
    }
}