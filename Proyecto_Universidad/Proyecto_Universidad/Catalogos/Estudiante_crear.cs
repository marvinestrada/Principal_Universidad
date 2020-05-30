using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Universidad
{
    public partial class Estudiante_crear : Form
    {
        public int id = 0;
        int Codigo = 0;

        public Estudiante_crear(int codigo = 0, string Nombre = "", string Apellido = "", string Dirección = "", string Telefono = "")
        {
            InitializeComponent();
            Codigo = codigo;
            txtNom.Text = Nombre;
            txtapellido.Text = Apellido;
            txtdir.Text = Dirección;
            txtTel.Text = Telefono;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Codigo != 0)
            {
                SqlCommand com = new SqlCommand();
                com = new SqlCommand("CRUD_estudiante", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 3);
                com.Parameters.AddWithValue("Id_estudiente", Codigo);
                com.Parameters.AddWithValue("Nombres", txtNom.Text);
                com.Parameters.AddWithValue("Apellidos", txtapellido.Text);
                com.Parameters.AddWithValue("Direc", txtdir.Text);
                com.Parameters.AddWithValue("Tel", txtTel.Text);

                Conn.sqlconeccion.Open();
                com.ExecuteNonQuery();
                Conn.sqlconeccion.Close();
            }
            else
            {
                SqlCommand com = new SqlCommand("CRUD_estudiante", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 1);
                com.Parameters.AddWithValue("Id_estudiente", Codigo);
                com.Parameters.AddWithValue("Nombres", txtNom.Text);
                com.Parameters.AddWithValue("Apellidos", txtapellido.Text);
                com.Parameters.AddWithValue("Direc", txtdir.Text);
                com.Parameters.AddWithValue("Tel", txtTel.Text);
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

