internal class Program
{
    private static void Main(string[] args)
    {
        DateTime fecha1 = new DateTime(); //creamos objeto fecha pero tiene una fecha por default
        DateTime fecha = DateTime.Now; //hora local


        Console.WriteLine(fecha.ToString()); //output 10/17/2022 12:19:58 PM
        Console.WriteLine(fecha.ToShortDateString()); //output 10/17/2022
        Console.WriteLine(fecha.ToShortTimeString()); //output 12:24 PM
        Console.WriteLine(fecha.ToLongDateString()); //output Monday, October 17, 2022
        Console.WriteLine(fecha.ToLongTimeString()); //output 12:25:00 PM
        

        //agregar
        Console.WriteLine(fecha.AddDays(3).ToLongTimeString());
        Console.WriteLine(fecha.AddMonths(8).ToLongTimeString());
        Console.WriteLine(fecha.AddYears(1).ToLongTimeString());

        //sustraer
        Console.WriteLine(fecha.AddDays(-3).ToLongTimeString());
        Console.WriteLine(fecha.AddMonths(-5).ToLongTimeString());
        Console.WriteLine(fecha.AddYears(-2).ToLongTimeString());


        DateTime myBirthday = DateTime.Parse("05/01/2000");
        TimeSpan myAge = DateTime.Now.Subtract(myBirthday);


        Console.ReadLine();
        
    }
}