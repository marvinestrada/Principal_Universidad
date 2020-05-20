using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Universidad
{
    public partial class Datos_Estudiante : Form
    {
        public int id = 0;
        int Codigo = 0;

        public Datos_Estudiante(int codigo = 0, string Nombres = "", string Apellidos = "", string Dirección = "", string Telefono = "")
        {
            InitializeComponent();
            Codigo = codigo;
            txtNomEstu.Text = Nombres;
            txtapeEstu.Text = Apellidos;
            txtdirEstu.Text = Dirección;
            txttelEstu.Text = Telefono;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Codigo != 0)
            {
                SqlCommand com = new SqlCommand();
                com = new SqlCommand("CRUD_Estudiante", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 3);
                com.Parameters.AddWithValue("id_Estudiente", Codigo);
                com.Parameters.AddWithValue("Nombres", txtNomEstu.Text);
                com.Parameters.AddWithValue("Apellidos", txtapeEstu.Text);
                com.Parameters.AddWithValue("Dirección", txtdirEstu.Text);
                com.Parameters.AddWithValue("Telefono", txttelEstu.Text);

                Conn.sqlconeccion.Open();
                com.ExecuteNonQuery();
                Conn.sqlconeccion.Close();
            }
            else
            {
                SqlCommand com = new SqlCommand("CRUD_Estudiante", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 1);
                com.Parameters.AddWithValue("id_Estudiente", Codigo);
                com.Parameters.AddWithValue("Nombres", txtNomEstu.Text);
                com.Parameters.AddWithValue("Apellidos", txtapeEstu.Text);
                com.Parameters.AddWithValue("Dirección", txtdirEstu.Text);
                com.Parameters.AddWithValue("Telefono", txttelEstu.Text);
                Conn.sqlconeccion.Open();
                id = Convert.ToInt32(com.ExecuteScalar());
                Conn.sqlconeccion.Close();
            }
            this.Close();
        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

