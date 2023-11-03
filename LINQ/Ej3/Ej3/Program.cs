internal class Program
{
    private static void Main(string[] args)
    {

        List<Persona> personas = new List<Persona>
        {
            new Persona(){ Edad = 30, Nombre = "joaquin" },
            new Persona(){ Edad = 42, Nombre = "Pedro" },
            new Persona(){ Edad = 20, Nombre = "Martin" },
            new Persona(){ Edad = 22, Nombre = "Paula" },
            new Persona(){ Edad = 21, Nombre = "Ginette" },
            new Persona(){ Edad = 15, Nombre = "Ana" },
        };

        //solicito que me ordene por nombres pero muestro tmb la edad con un espacio en medio
        //se puede hacer d.Edad + " " + d.Nombre, simplemente creamos un metodo y en SELECT usamos el metodo por practicidad.
        List<string> lstNombresOrdenados = (from d in personas
                                           orderby d.Nombre
                                           select d.edadYNombre).Skip(1).Take(3).ToList(); 

        //listo los resultados
        foreach ( var i in lstNombresOrdenados)
        {
            Console.WriteLine(i);

        }


        Console.WriteLine("acá termina el ejercicio");
        Console.ReadLine();

    }



    class Persona
    {
        public int Edad{ get; set; }
        public string Nombre { get; set; }


        public string edadYNombre
        {
            get {
                return Edad + " -- " + Nombre;

            }

        }

    }




}