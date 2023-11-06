using models;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        //var bebida = new Cerveza("rubia", 15, "Heineken");
        //string miJoson = JsonSerializer.Serialize(bebida);
        //File.WriteAllText("nombreArchivo.txt", miJoson); //se guarda en carpeta 'Debug'

        string miJson1 = File.ReadAllText("nombreArchivo.txt"); 
        var cerveza = JsonSerializer.Deserialize<Cerveza>(miJson1);

        Console.WriteLine($"Objeto deserializado! \n{cerveza}");
    }
}