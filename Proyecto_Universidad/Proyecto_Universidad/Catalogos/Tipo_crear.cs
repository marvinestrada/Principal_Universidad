using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Universidad.Catalogos
{
    public partial class Tipo_crear : Form
    {
        public int id = 0;//esta Variable publica sirve para asignar ID automaticamente la BD
        int Codigo = 0;//esta variable guardara los ID que se esten agregando

        public Tipo_crear(int codigo = 0, string tipo = "")/*Asigno variables a los textbox, seran igual a lo que contenga las variables*/

        {
            InitializeComponent();
            Codigo = codigo;
           comboBox1.Text = tipo;
        }
        private void btn_aceptar_Click(object sender, System.EventArgs e)
        {
            //el evento tiene dos funciones, para insertar los datos en la BD y para actualizar
            /*Cuando se inicia el codigo hay una condicional IF y esta se va encargar de revisar si lo que hay
             * en nuestra variable Codigo, si detectta que no es equivalente a cero (!=0) entonces se ejecutara el primer
             * bloque de codigo, que es Actualizar, entonces reemplazara los datos existentes*/

            if (Codigo != 0)
            {
                //Se establece conexion con la BD y ejecuta proc almacenado CRUD 3

                SqlCommand com = new SqlCommand();
                com = new SqlCommand("CRUD_tipo", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 3);
                com.Parameters.AddWithValue("Id_tipo", Codigo);
                com.Parameters.AddWithValue("Tipo", comboBox1.Text);
                Conn.sqlconeccion.Open();
                com.ExecuteNonQuery();
                Conn.sqlconeccion.Close();
            }
            else
            {
                //Se establece conexion con la BD y se ejecuta proc almacenado CRUD 1

                SqlCommand com = new SqlCommand("CRUD_tipo", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 1);
                com.Parameters.AddWithValue("Tipo", comboBox1.Text);
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
