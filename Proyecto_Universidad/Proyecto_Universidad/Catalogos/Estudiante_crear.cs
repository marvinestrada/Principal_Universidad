using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Universidad
{
    public partial class Estudiante_crear : Form
    {
        public int id = 0;//esta Variable publica sirve para asignar ID automaticamente la BD

        int Codigo = 0;//esta variable guardara los ID que se esten agregando

        public Estudiante_crear(int codigo = 0, string Nombre = "", string Apellido = "", string Dirección = "", string Telefono = "")//este metodo asignara las variables para los textbox que almacenara los datos de la BD
        {
            /*Asigno variables a los textbox, seran igual a lo que contenga las variables*/
            InitializeComponent();
            Codigo = codigo;
            txtNom.Text = Nombre;
            txtapellido.Text = Apellido;
            txtdir.Text = Dirección;
            txtTel.Text = Telefono;
        }

        private void btnAceptar_Click(object sender, EventArgs e)//Evento click boton Aceptar
        {
            //el evento tiene dos funciones, para insertar los datos en la BD y para actualizar
            /*Cuando se inicia el codigo hay una condicional IF y esta se va encargar de revisar si lo que hay
             * en nuestra variable Codigo, si detectta que no es equivalente a cero (!=0) entonces se ejecutara el primer
             * bloque de codigo, que es Actualizar, entonces reemplazara los datos existentes*/

            if (Codigo != 0)
            //Se establece conexion con la BD y ejecuta proc almacenado CRUD 3

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
                //Se establece conexion con la BD y se ejecuta proc almacenado CRUD 1

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

