using primera_clase_y_metodoToString;
public class Program
{
    public static void Main(string[] args)
    {
        Persona[] personas = new Persona[3];
        Console.WriteLine("Creador de personas");
        string entrada;

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Ingrese el nombre de la persona " + (i + 1));
            entrada = Console.ReadLine();
            Persona p = new(entrada);
            personas[i] = p;
        }

        Console.WriteLine("\n");


        for (int i = 0; i < personas.Length; i++)
        {
            personas[i].ToString();
        }
    }
}