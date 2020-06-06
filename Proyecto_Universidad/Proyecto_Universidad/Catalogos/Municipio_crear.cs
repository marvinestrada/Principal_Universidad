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
        //Variable publica para asignar ID automaticamente a la base de datos
        public int id = 0;
        int Codigo = 0; //En esta variable se iran guardando todos los ID que se esten agregando
        public Municipio_crear( int codigo = 0, string municipio = "") //Con este metodo se llenan los campos de las tablas de BD
        {
            InitializeComponent();
            Codigo = codigo;                /*Reemplazo variables*/
            txtmunicipio.Text = municipio;
        }
        private void btn_aceptar_Click(object sender, System.EventArgs e) //Evento click boton Aceptar
        {
            //Este evento sirve para dos cosas, para insertar datos en la BD y para actualizar
            /*Cuando se inicia el codigo hay una condicional IF y esta se va encargar de revisar si lo que hay
             * en nuestra variable Codigo, si detectta que no es equivalente a cero (!=0) entonces se ejecutara el primer
             * bloque de codigo, que es Actualizar, entonces reemplazara los datos existentes*/
            if (Codigo != 0)

                //Se establece conexion con la BD y ejecuta proc almacenado CRUD 3
            {
                SqlCommand com = new SqlCommand();
                com = new SqlCommand("CRUD_Municipio", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 3);              
                com.Parameters.AddWithValue("Id_municipio", Codigo);
                com.Parameters.AddWithValue("Municipio", txtmunicipio.Text);
                Conn.sqlconeccion.Open();
                com.ExecuteNonQuery();
                Conn.sqlconeccion.Close();
            }

            /*Si resulta que Codigo es igual a cero, osea que no tiene datos, entonces se ejecuta este bloque de codigo
             * que vendria siendo el procedimiento almacenado CRUD 1 (Insert) agregará todos los datos que textiemos a la BD*/
            else
            {
                //Se establece conexion con la BD y se ejecuta proc almacenado CRUD 1

                SqlCommand com = new SqlCommand("CRUD_Municipio", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 1);
                com.Parameters.AddWithValue("Municipio", txtmunicipio.Text);
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

        private void txtmunicipio_TextChanged(object sender, EventArgs e)
        {

        }

        private void Municipio_crear_Load(object sender, EventArgs e)
        {

        }
    }
}
