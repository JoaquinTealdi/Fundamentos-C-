using System.Numerics;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Please add some text...");
        string text =Console.ReadLine();

        string fileName = "newfile.txt";

        if (!File.Exists(fileName))
        {
            File.WriteAllText(fileName, text);
        }
        else
        {
            //Con SB leemos el contenido existente del archivo y lo concatenamos con el nuevo contenido.
            StringBuilder sb = new StringBuilder("This was the previous text: ");
            sb.AppendLine(File.ReadAllText(fileName)); 
            sb.AppendLine("This is the new text: " + text);
            
            //agregamos el contenido viejo junto con el nuevo
            File.WriteAllText(fileName, sb.ToString());

            //con Move() cambiamos el nombre de un archivo
            File.Move(fileName, "secondFileName.txt");          
        }
    }
}