using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Universidad.Catalogos
{
    public partial class Profesor_crear : Form
    {
        public int id = 0;
        int Codigo = 0;

        public Profesor_crear(int codigo = 0, string Nombres = "", string Apellidos = "", string Dirección = "", string Telefono = "")
        {
            InitializeComponent();
            Codigo = codigo;
            txtNomPro.Text = Nombres;
            txtapePro.Text = Apellidos;
            txtdirPro.Text = Dirección;
            txttelPro.Text = Telefono;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Codigo != 0)
            {
                SqlCommand com = new SqlCommand();
                com = new SqlCommand("CRUD_Profeseor", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 3);
                com.Parameters.AddWithValue("Id_Estudiente", Codigo);
                com.Parameters.AddWithValue("Nombres", txtNomPro.Text);
                com.Parameters.AddWithValue("Apellidos", txtapePro.Text);
                com.Parameters.AddWithValue("Dirección", txtdirPro.Text);
                com.Parameters.AddWithValue("Telefono", txttelPro.Text);

                Conn.sqlconeccion.Open();
                com.ExecuteNonQuery();
                Conn.sqlconeccion.Close();
            }
            else
            {
                SqlCommand com = new SqlCommand("CRUD_Profesor", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 1);
                com.Parameters.AddWithValue("Id_Estudiente", Codigo);
                com.Parameters.AddWithValue("Nombres", txtNomPro.Text);
                com.Parameters.AddWithValue("Apellidos", txtapePro.Text);
                com.Parameters.AddWithValue("Dirección", txtdirPro.Text);
                com.Parameters.AddWithValue("Telefono", txttelPro.Text);
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
