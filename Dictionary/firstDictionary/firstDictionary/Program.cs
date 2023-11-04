internal class Program
{
    public static void Main(string[] args)
    {

        //inicialización y crear valores
        Dictionary<string, string> ciudades = new Dictionary<string, string>() 
        {
            {"Argentina", "Resistencia"},
            {"Brasil", "rio"}
        };

        //añadir valores
        ciudades.Add("chile", "santiago");

        //añadir valores 2
        ciudades.TryAdd("chile", "santiago"); //devuelve un booleano 



        //acceder a valores
        Console.WriteLine(ciudades["Argentina"]); //output Resistencia

        KeyValuePair<string, string> resultado = ciudades.ElementAt(0);
        Console.WriteLine(resultado.Value); //output Resistencia




        //acceder CORRECTAMENTE(recomendado/comun) a los valores
        if (ciudades.TryGetValue("Argentina", out string resultadoCiudad))
        {
            Console.WriteLine(resultadoCiudad);  //output Resistencia
        }
        else 
        {
            Console.WriteLine("El elemento no existe");
        }

        

        //actualizar un elemento
        if (ciudades.ContainsKey("Argentina"))
        {
            ciudades["Argentina"] = "Tandil";
        }
       

        Console.WriteLine("Hello, World!");
    }
}