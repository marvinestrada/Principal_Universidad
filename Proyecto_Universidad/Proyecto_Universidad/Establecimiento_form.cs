using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Universidad
{
    public partial class Establecimiento_form : Form
    {
        public int id = 0;
        int Codigo = 0;
        public Establecimiento_form(int codigo = 0, string Establecimiento = "", string Id_municipio = "")
        {
            InitializeComponent();
            Codigo = codigo;
            txtestablecimiento.Text = Establecimiento;
            txtmunicipio.Text = Id_municipio;
        }
        private void btn_aceptar_Click(object sender, System.EventArgs e)
        {
            if (Codigo != 0)
            {
                SqlCommand com = new SqlCommand();
                com = new SqlCommand("CRUD_Establecimiento", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 3);
                com.Parameters.AddWithValue("Id_establecimiento", Codigo);
                com.Parameters.AddWithValue("Establecimiento", txtestablecimiento.Text);
                com.Parameters.AddWithValue("Id_municipio", txtmunicipio.Text);
                Conn.sqlconeccion.Open();
                com.ExecuteNonQuery();
                Conn.sqlconeccion.Close();
            }
            else
            {
                SqlCommand com = new SqlCommand("CRUD_Establecimiento", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 1);
                com.Parameters.AddWithValue("Establecimiento", txtestablecimiento.Text);
                com.Parameters.AddWithValue("Id_municipio", txtmunicipio.Text);
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
