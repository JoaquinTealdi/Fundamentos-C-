internal class Program
{
    private static void Main(string[] args)
    {
        
        List<Persona> personas = new List<Persona>() 
        {

            new Persona () { Edad = 20, Nombre =  "Juan" },
            new Persona () { Edad = 40, Nombre =  "Martin" },
            new Persona () { Edad = 25, Nombre =  "Ginette" },
            new Persona () { Edad = 13, Nombre =  "Paula" },

        };


        List<string> listaSoloTexto = new List<string>()
        {
             "30 - Maxi", "44 - Ana", "32 - Diego"

        };


        
        List<string> listaNombres = (from e in personas
                                     orderby e.Nombre
                                     select e.EdadYNombre)
                                     .Union(listaSoloTexto)
                                     .OrderBy(e=>e) // como la lista que uno es un string, me ordenará por el primer caracter, es decir el numeros
                                     .ToList(); 
        /*
        List<string> listaNombres = (from e in personas
                                     select e)
                                     .Union(listaSoloTexto)
                                     .OrderBy(e => e.EdadYNombre) 
                                     .Select(e => e.EdadYNombre)
                                     .ToList();

        esta forma funciona si ambas listas son del mismo tipo, por ej "Persona"
        */



        foreach (var f in listaNombres) 
        {
            Console.WriteLine(f);
        }
        
        
        Console.WriteLine("\nTermina");
        Console.ReadLine();
    }




    class Persona
    {
        public int Edad { get; set; }
        public string Nombre{ get; set; }
        
        public string EdadYNombre 
        {
            get 
            { 
                return Edad + " - " + Nombre; 
            }
        }

    }


}