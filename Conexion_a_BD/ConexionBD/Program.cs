using ConexionBD.models;
using models;

public class Program
{
    private static void Main(string[] args)
    {
        CervezaDB cervezaDB = new CervezaDB();

        // insertar cerveza
        {
            var cerveza = new Cerveza("blanca", 17);
            cerveza.Nombre = "Blue Moon";
            cervezaDB.AddCerveza(cerveza);

            var cerveza1 = new Cerveza("Negra", 10);
            cerveza1.Nombre = "Guinness";
            cervezaDB.AddCerveza(cerveza1);

            var cerveza2 = new Cerveza("negra", 5);
            cerveza2.Nombre = "Amber";
            cervezaDB.AddCerveza(cerveza2);

            var cerveza3 = new Cerveza("rubia", 11);
            cerveza3.Nombre = "Lager";
            cervezaDB.AddCerveza(cerveza3);
        }


        // obtener cerveza
        var cervezas = cervezaDB.GetCervezas();

        foreach (var cerveza in cervezas)
        {
            Console.WriteLine(cerveza.Nombre);
        }

    }
}