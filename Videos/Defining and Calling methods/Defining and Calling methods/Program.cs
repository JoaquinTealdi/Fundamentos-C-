using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese su nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Ingrese su apellido: ");
        string apellido = Console.ReadLine();
        Console.WriteLine("Ingrese su localidad: ");
        string localidad = Console.ReadLine();

        
        Console.WriteLine("resultados: ");    
        string Reversenombre = ReseverseString(nombre);
        string Reverseapellido = ReseverseString(apellido);
        string Reverselocalidad = ReseverseString(localidad);
        //Console.Write(Reversenombre + " " + Reverseapellido + " " + Reverselocalidad);
       
        Console.Write(String.Format("{0} - {1} - {2} ", ReseverseString(nombre), ReseverseString(apellido), ReseverseString(localidad)));
        /* string format es necesario siempre o es por una cuestion de prolijidad y buena sintaxis */

        Console.WriteLine(String.Concat(nombre, apellido, localidad));
        Console.ReadLine(); 
    }


    private static string ReseverseString(string message) 
    {
        char[] messageArray = message.ToCharArray();
        Array.Reverse(messageArray);
        return string.Concat(messageArray); /* realizar de esta forma o usar un Console.WriteLine para asi dentro de la main "ahorrar" lineas de codigo y 
        creacion de variables*/

    }

    //metodo para mostrar los arrays invertidos
    private static void DisplayResult(
        string Reversenombre,
        string Reverseapellido,
        string Reverselocalidad) 
    {
        Console.Write("Results: ");
        Console.Write(String.Format("{0} - {1} - {2} ", Reversenombre, Reverseapellido, Reverselocalidad));

    }


}