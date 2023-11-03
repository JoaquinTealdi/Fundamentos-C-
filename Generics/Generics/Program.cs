using Generics.models;
using Generics.Service;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

class Program
{
    private static async Task Main(string[] args)
    {

        var cerveza = new Cerveza()
        {
            Nombre = "IPA",
            Marca = "Patagonia",
            Alcohol = 5,
            Cantidad = 600
        };

        Generics.Service.SendRequest<Cerveza> service = new SendRequest<Cerveza>();
        var cervezaRta = await service.Send(cerveza);

        Console.WriteLine("Hello, World!");
    }


}