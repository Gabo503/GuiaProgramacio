using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client.NativeInterop;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Guia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
            cbxCarrera.Text = "Selecione Carrera";
            CargaCarreras();
        }
        int numero;
        private void ActualizarDataGridView()
        {
            using (var connection = new SqlConnection("server= localhost; database=Guia2Eval4; Integrated security= true;TrustServerCertificate=True"))
            {
                var command = new SqlCommand("select  dt.IdAlumno,dt.Nombre Nombre,dt.Apellido Apellido,dt.Telefono Telefono,dt.Correo Correo,c.Nombre Carrera from DatosAlumno dt inner join Carreras c on dt.IdCarrera = c.IdCarrera", connection);
                var adapter = new SqlDataAdapter(command);
                var dt = new DataTable();
                adapter.Fill(dt);
                dgvDatos.DataSource = dt;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;
            string carrera = cbxCarrera.Text;

            if (nombre == "" || apellido == "" || correo == "" || telefono == "" || carrera == "")
            {
                MessageBox.Show("Complete la información");
            }
            else
            {
                LlenadoDatos Nuevo = new LlenadoDatos(nombre, apellido, correo, telefono, carrera);
                int fila = Nuevo.AgregarAlumno();

                if (fila == 1)
                {
                    MessageBox.Show("Alumno ingresado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtCorreo.Text = "";
                    txtTelefono.Text = "";
                    cbxCarrera.Text = "Selecione Carrera";
                }
                else
                {
                    MessageBox.Show("Error al agregar un Alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            ActualizarDataGridView();
 
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargaEntidad(numero);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection("server= localhost; database=Guia2Eval4; Integrated security= true;TrustServerCertificate=True"))
            {
                var command = new SqlCommand("DELETE FROM DatosAlumno WHERE IdAlumno = @IdAlumno", connection);
                command.Parameters.AddWithValue("@IdAlumno", numero);
                connection.Open();
                command.ExecuteNonQuery();
            }
            ActualizarDataGridView();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                numero = Convert.ToInt32(dgvDatos.Rows[e.RowIndex].Cells["IdAlumno"].Value);
                MessageBox.Show($"ID seleccionado: {numero}");
            }
        }

        private void CargaEntidad(int numero)
        {
            using (var connection = new SqlConnection("server= localhost; database=Guia2Eval4; Integrated security= true;TrustServerCertificate=True"))
            {
                var command = new SqlCommand("select dt.IdAlumno,dt.Nombre Nombre,dt.Apellido Apellido,dt.Telefono Telefono,dt.Correo Correo,c.Nombre IdCarrera from DatosAlumno dt inner join Carreras c on dt.IdCarrera = c.IdCarrera where IdAlumno = @numero", connection);
                command.Parameters.AddWithValue("@numero", numero);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtIdAlumno.Text = reader["IdAlumno"].ToString();
                        txtNombre.Text = reader["Nombre"].ToString();
                        txtApellido.Text = reader["Apellido"].ToString();
                        txtCorreo.Text = reader["Correo"].ToString();
                        txtTelefono.Text = reader["Telefono"].ToString();
                        cbxCarrera.Text = reader["IdCarrera"].ToString();
                    }
                }
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int IdCarrera;
            using (var connection = new SqlConnection("server=localhost; database=Guia2Eval4; Integrated security=true; TrustServerCertificate=True"))
            {
                var command = new SqlCommand("UPDATE DatosAlumno SET Nombre = @Nombre, Apellido = @Apellido, Correo = @Correo, Telefono = @Telefono, IdCarrera = @IdCarrera WHERE IdAlumno = @IdAlumno", connection);
                command.Parameters.AddWithValue("@IdAlumno", txtIdAlumno.Text);
                command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                command.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                command.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                command.Parameters.AddWithValue("@Telefono", txtTelefono.Text);

                if (cbxCarrera.Text == "Ingenieria en Sistemas y Computacion")
                {
                    IdCarrera = 1;
                }
                else if (cbxCarrera.Text == "Licenciatura en idiomas")
                {
                    IdCarrera = 2;
                }
                else if (cbxCarrera.Text == "Ingenieria Industrial")
                {
                    IdCarrera = 3;
                }
                else if (cbxCarrera.Text == "Piloto Aviador")
                {
                    IdCarrera = 4;
                }
                else
                {
                    throw new InvalidOperationException("Carrera no válida seleccionada.");
                }

                command.Parameters.AddWithValue("@IdCarrera", IdCarrera);
                connection.Open();
                command.ExecuteNonQuery();
            }
            ActualizarDataGridView();
            MessageBox.Show("Alumno Actualizado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtIdAlumno.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            cbxCarrera.Text = "Selecione Carrera";
        }
        private void CargaCarreras()
        {
            using (var connection = new SqlConnection("server= localhost; database=Guia2Eval4; Integrated security= true;TrustServerCertificate=True"))
            {
                connection.Open();
                var command = new SqlCommand("SELECT Nombre FROM Carreras", connection);
                command.Parameters.AddWithValue("@IdAlumno", numero);
                SqlDataReader lector = command.ExecuteReader();
                while (lector.Read())
                {
                    cbxCarrera.Items.Add(lector.GetString(0));
                }
            }
        }
    }
}
