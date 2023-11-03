
internal class Program
{
    private static void Main(string[] args)
    {
        //llamada al metodo
        sumaNumeros(3, 8);
        
    }

    public static void sumaNumeros(int num1, int num2) 
    {
        int resultado = num1 + num2;
        Console.WriteLine(resultado);       
    }



}