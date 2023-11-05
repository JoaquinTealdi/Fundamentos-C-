using Microsoft.Data.SqlClient;
using models;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBD.models
{
    class CervezaDB
    {
        private string connectionString = @"Data Source=(local)\sqlexpress; Initial Catalog=FundamentosCSharp; Trusted_Connection=True; Trust Server Certificate=True;";


        public List<Cerveza> GetCervezas() 
        {
            List<Cerveza> cervezas = new List<Cerveza>();

            string query = "select Id, Nombre, Tipo, Cantidad from Cerveza";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string tipo = reader.GetString(2); //es el numero de parámetro definido en 'query'. Id es el nro 0
                    int cantidad = reader.GetInt32(3);
                    Cerveza cerveza = new Cerveza(tipo, cantidad);
                    //atributos no recibidos por el contructor, pero se pueden agregar de la siguiente manera
                    cerveza.Nombre = reader.GetString(1);
                    cervezas.Add(cerveza);
                }

                connection.Close();
            }

            return cervezas;
        }

        public void AddCerveza(Cerveza cerveza) 
        {
            try
            {
                string query = "insert into Cerveza(Nombre, Tipo, Cantidad) " +
                "values(@Nombre, @Tipo, @Cantidad)";

                using (var connection = new SqlConnection(connectionString))
                {
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombre", cerveza.Nombre);
                    command.Parameters.AddWithValue("@Tipo", cerveza.Tipo);
                    command.Parameters.AddWithValue("@Cantidad", cerveza.Cantidad);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                Console.WriteLine($"Cerveza {cerveza.Nombre} insertada con exito :)");
            }
            catch (Exception e)
            {
                Console.WriteLine("Hubo un error: " + e.Message);
            }

        }
    }
}
