using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Guia
{
        class LlenadoDatos
        {
            SqlConnection Conexion = new SqlConnection("server= localhost; database=Guia2Eval4; Integrated security= true;TrustServerCertificate=True");

            private string nombre;
            private string apellido;
            private string correo;
            private string telefono;
            private string carrera;
            private int Carrera;
            public LlenadoDatos(string nombre, string apellido, string correo, string telefono, string carrera)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.correo = correo;
                this.telefono = telefono;
                this.carrera = carrera;

                if (carrera == "Ingenieria en Sistemas y Computacion")
                {
                    this.Carrera = 1;
                }
                if (carrera == "Licenciatura en idiomas")
                {
                    this.Carrera = 2;
                }
                if (carrera == "Ingenieria Industrial")
                {
                    this.Carrera = 3;
                }
                if (carrera == "Piloto Aviador")
                {
                    this.Carrera = 4;
                }

            }

            public int AgregarAlumno()
            {
                Conexion.Open();
                SqlCommand query = new SqlCommand("Insert into DatosAlumno Values (@nombre,@apellido,@telefono,@correo,@carrera)", Conexion);

                query.Parameters.AddWithValue("nombre", nombre);
                query.Parameters.AddWithValue("apellido", apellido);
                query.Parameters.AddWithValue("correo", correo);
                query.Parameters.AddWithValue("telefono", telefono);
                query.Parameters.AddWithValue("carrera", Carrera);

                int FilasAfectadas = query.ExecuteNonQuery();
                Conexion.Close();
                return FilasAfectadas;
            }
        }
}
