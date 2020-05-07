using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Universidad
{
    public partial class Municipio_crear : Form
    {
        public int id = 0;
        int Codigo = 0;
        public Municipio_crear(int codigo = 0, string municipio = "")
        {
            InitializeComponent();
            Codigo = codigo;
            txtmunicipio.Text = municipio;
        }
        private void btn_aceptar_Click(object sender, System.EventArgs e)
        {
            if (Codigo != 0)
            {
                SqlCommand com = new SqlCommand();
                com = new SqlCommand("CRUD_Ciclo", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 3);
                com.Parameters.AddWithValue("id_municipio", Codigo);
                com.Parameters.AddWithValue("municipio", txtmunicipio.Text);
                Conn.sqlconeccion.Open();
                com.ExecuteNonQuery();
                Conn.sqlconeccion.Close();
            }
            else
            {
                SqlCommand com = new SqlCommand("CRUD_Ciclo", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 1);
                com.Parameters.AddWithValue("municipio", txtmunicipio.Text);
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
