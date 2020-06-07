using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Universidad.Catalogos
{
    public partial class Profesor_crear : Form
    {
        public int id = 0;//esta Variable publica sirve para asignar ID automaticamente la BD
        int Codigo = 0;//esta variable guardara los ID que se esten agregando

        public Profesor_crear(int codigo = 0, string Nombres = "", string Apellidos = "", string Dirección = "", string Telefono = "")
        {
            /*Asigno variables a los textbox, seran igual a lo que contenga las variables*/

            InitializeComponent();
            Codigo = codigo;
            txtNomPro.Text = Nombres;
            txtapePro.Text = Apellidos;
            txtdirPro.Text = Dirección;
            txttelPro.Text = Telefono;
        }

        private void btnAceptar_Click(object sender, EventArgs e)//Evento click boton Aceptar
        {
            //el evento tiene dos funciones, para insertar los datos en la BD y para actualizar
            /*Cuando se inicia el codigo hay una condicional IF y esta se va encargar de revisar si lo que hay
             * en nuestra variable Codigo, si detectta que no es equivalente a cero (!=0) entonces se ejecutara el primer
             * bloque de codigo, que es Actualizar, entonces reemplazara los datos existentes*/

            if (Codigo != 0)
            {
                //Se establece conexion con la BD y ejecuta proc almacenado CRUD 3

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
                //Se establece conexion con la BD y se ejecuta proc almacenado CRUD 1

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
