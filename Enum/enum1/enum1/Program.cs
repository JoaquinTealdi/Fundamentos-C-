internal class Program
{
    public static void Main(string[] args)
    {
        Empleado Juan = new(Bonus.extra, 15600);

        Juan.GetSalario();
    }

    class Empleado
    {
        public double Salario, Bonus;

        public Empleado(Bonus bonusEmpleado, double salario)
        {
            Bonus = (double)bonusEmpleado;
            Salario = salario;
        }
        public double GetSalario()
        {
            return Salario + Bonus;
        }

    } 
    enum Bonus
    {
        bajo = 2000,
        medio = 4000,
        alto = 6000,
        extra = 8000
    }
}