using CocheInterfaz;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Ingrese la cantidad de gasolina a repostar");
        int cantidad = int.Parse(Console.ReadLine());
        Coche coche1 = new Coche(cantidad);
        coche1.Conducir();
        coche1.GetGasolina();
    }
}