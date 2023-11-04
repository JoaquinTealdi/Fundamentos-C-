internal class Program
{
    private static void Main(string[] args)
    {

        Alumnos[] alum = {
            new Alumnos(5, "juan"),
            new Alumnos(9, "maria"),
            new Alumnos(1, "pedro"),
            new Alumnos(6, "martin"),
            new Alumnos(10, "maxi"),
            new Alumnos(8, "lorena"),
            new Alumnos(4, "paula")
        };

        var list = from i in alum
                   where i.Nota > 5
                   orderby i.Nota 
                   select i;


        Console.WriteLine("condicion");
        foreach (var d in list)
        {
            Console.WriteLine(d.Imprime());
        }   
    }

    class Alumnos
    {
        public int Nota { get; set; }
        public string Nombre{ get; set; }

        public Alumnos( int nota, string nombre)
        {
            Nota = nota;
            Nombre = nombre;    
        }

        public string Imprime() 
        {
            return Nota + " " + Nombre;
        }
    }
}