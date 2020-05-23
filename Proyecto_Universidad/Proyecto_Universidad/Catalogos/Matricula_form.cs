using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Universidad.Catalogos
{
    public partial class Matricula_form : Form
    {
        public int id = 0;
        int Codigo = 0;
        public Matricula_form(int codigo = 0, string fecha = "", string estudiante = "", string establecimiento = "", string tipo = "", string ciclo = "")
        {
            InitializeComponent();
            Codigo = codigo;
            txtFecha.Text = fecha;
            txtestud.Text = estudiante;
            txtestab.Text = establecimiento;
            txtTipo.Text = tipo;
            txtCiclo.Text = ciclo;
        }
        private void btn_aceptar_Click(object sender, System.EventArgs e)
        {
            if (Codigo != 0)
            {
                SqlCommand com = new SqlCommand();
                com = new SqlCommand("CRUD_Matricula", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 3);
                com.Parameters.AddWithValue("Id_matricula", Codigo);
                com.Parameters.AddWithValue("Fecha_matricula", txtFecha.Text);
                com.Parameters.AddWithValue("Id_estudiante", txtestud.Text);
                com.Parameters.AddWithValue("Id_establecimiento", txtestab.Text);
                com.Parameters.AddWithValue("Id_tipo", txtTipo.Text);
                com.Parameters.AddWithValue("Id_ciclo", txtCiclo.Text);
                
                Conn.sqlconeccion.Open();
                com.ExecuteNonQuery();
                Conn.sqlconeccion.Close();
            }
            else
            {
                SqlCommand com = new SqlCommand("CRUD_Matricula", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 1);
                com.Parameters.AddWithValue("Id_matricula", Codigo);
                com.Parameters.AddWithValue("Fecha_matricula", txtFecha.Text);
                com.Parameters.AddWithValue("Id_estudiante", txtestud.Text);              
                com.Parameters.AddWithValue("Id_establecimiento", txtestab.Text);
                com.Parameters.AddWithValue("Id_tipo", txtTipo.Text);
                com.Parameters.AddWithValue("Id_ciclo", txtCiclo.Text);
                
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
