internal class Program
{
    private static void Main(string[] args)
    {
        //creo el empleado y muestro su salario con GetSalario();
        Empleado Juan = new(Bonus.extra, 15600);

        Juan.GetSalario();
        
        
    }


    class Empleado
    {
        public double Salario, Bonus;
        //constructor que recibe el tipo de bonus y el salario
        public Empleado(Bonus bonusEmpleado, double salario)
        {
            Bonus = (double)bonusEmpleado;
            Salario = salario;
        }
        public double GetSalario ()
        {
            return Salario + Bonus;
        }

    }
    //creo el enum para los diferentes bonus 
    enum Bonus
    {
        bajo = 2000,
        medio = 4000,
        alto = 6000,
        extra = 8000 
    }
}