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

namespace Proyecto_Universidad.Catalogos
{
    public partial class Notas_form : Form
    {
        public int id = 0;
        int Codigo = 0; //En esta variable se iran guardando todos los ID que se esten agregando
        public Notas_form(int codigo = 0, string municipio = "")
        {
            InitializeComponent();
            Codigo = codigo;                /*Reemplazo variables*/
            txtcarrera.Text = municipio;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (Codigo != 0)

            //Se establece conexion con la BD y ejecuta proc almacenado CRUD 3
            {
                SqlCommand com = new SqlCommand();
                com = new SqlCommand("CRUD_Carrera", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 3);
                com.Parameters.AddWithValue("Id_carrera", Codigo);
                com.Parameters.AddWithValue("Carrera", txtcarrera.Text);
                Conn.sqlconeccion.Open();
                com.ExecuteNonQuery();
                Conn.sqlconeccion.Close();
            }

            /*Si resulta que Codigo es igual a cero, osea que no tiene datos, entonces se ejecuta este bloque de codigo
             * que vendria siendo el procedimiento almacenado CRUD 1 (Insert) agregará todos los datos que textiemos a la BD*/
            else
            {
                //Se establece conexion con la BD y se ejecuta proc almacenado CRUD 1

                SqlCommand com = new SqlCommand("CRUD_Carrera", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 1);
                com.Parameters.AddWithValue("Carrera", txtcarrera.Text);
                Conn.sqlconeccion.Open();
                id = Convert.ToInt32(com.ExecuteScalar());
                Conn.sqlconeccion.Close();
            }
            this.Close();
        }

        private void Carrera_crear_Load(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
