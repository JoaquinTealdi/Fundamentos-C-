internal class Program
{
    private static void Main(string[] args)
    {
        //creamos arreglo
        int [] arreglosEnteros = { 1, 40, 6, 3, 55, 23, 100, 12, 2 };

        //ordenamos el arreglo con LINQ
        IEnumerable<int> List = from i in arreglosEnteros
                                orderby i
                                select i;


        //mostramos los arreglos
        Console.WriteLine("Arreglo oriinal");
        foreach (var g in arreglosEnteros)
        {
            Console.Write(String.Format("- ")+ g);
        }      

        Console.WriteLine("\nArreglo ordenado");
        foreach (var e in List)
        {
            Console.Write(String.Format("- ")+ e);
        }
    }
}