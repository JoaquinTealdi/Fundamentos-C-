internal class Program
{
    private static void Main(string[] args)
    {


        List<Viajes> listaViajes = new List<Viajes>()
        {

            new Viajes{ Descripcion = "Viaje 1", horaEstimada = 3, status = Status.Completado},
            new Viajes{ Descripcion = "Viaje 2", horaEstimada = 13, status = Status.Finalizando},
            new Viajes{ Descripcion = "Viaje 3", horaEstimada = 5, status = Status.EnProgreso},
            new Viajes{ Descripcion = "Viaje 4", horaEstimada = 1, status = Status.Cancelado},
            new Viajes{ Descripcion = "Viaje 5", horaEstimada = 6, status = Status.Completado},
            new Viajes{ Descripcion = "Viaje 6", horaEstimada = 8, status = Status.NoEmpezado}

        };

      
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("El estado de los viajes es: ");
        foreach (var viaje in listaViajes)
        {
            switch (viaje.status)
            {
                case Status.NoEmpezado:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El viaje no ha empezado aun");
                    break;

                case Status.EnProgreso:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("El viaje está en progreso");
                    break;

                case Status.Finalizando:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("El viaje está finalizando");
                    break;

                case Status.Completado:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("El viaje ha sido completado");
                    break;

                case Status.Cancelado:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("El viaje ha sido cancelado");
                    break;

            }
            Console.ForegroundColor = ConsoleColor.White;


        }






        
    }

    class Viajes
    {

        public string Descripcion { get; set; }
        public int horaEstimada{ get; set; }
        public Status status{ get; set; }

    }

    enum Status
    {
        NoEmpezado,
        EnProgreso,
        Finalizando,
        Completado,
        Cancelado
    }
}