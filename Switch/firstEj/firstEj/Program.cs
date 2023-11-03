internal class Program
{
    private static void Main(string[] args)
    {


        Console.WriteLine("Elige el medio de transporte para saber su velocidad media: Coche, Tren, Avion, Bicileta");
        string transporte = Console.ReadLine();A

        switch (transporte)
        {
            case "Coche":
                Console.WriteLine("La velocidad media es de 100 Km/h");
                break;
            case "Tren":
                Console.WriteLine("La velocidad media es de 200 Km/h");
                break;
            case "Avion":
                Console.WriteLine("La velocidad media es de 400 Km/h");
                break;
            case "Bicicleta":
                Console.WriteLine("La velocidad media es de 15 Km/h");
                break;
            default:
                Console.WriteLine("El medio de transporte ingresado no es correcto");
                break;
        }
    }
}