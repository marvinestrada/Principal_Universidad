using Proyecto_Universidad.Catalogos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Universidad
{
    public partial class Ciclos_lista : Form
    {
        //Delegado para ejecutar un evento, pasar los datos del datagrid al formulario matricula con un parametro
        public delegate void pasar(string datos);
        //Evento que lo va ejecutar
        public event pasar pasado;

        public Ciclos_lista()
        {
            InitializeComponent();
        }
        
        private void Ciclos_lista_Load(object sender, EventArgs e)
        {
            /*El evento load sirve para cuando se carge la ventana, arranque el siguiente bloque de codigo automaticamente*/

            try
            {
                /*Se abre conexion con BD y se ejecuta proc almacenado CRUD 2 
                * Lo que hace es leer los datos que se encuentren a la tabla*/
                SqlCommand com = new SqlCommand("CRUD_Ciclo", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 2);
                DataTable DT = new DataTable();
                Conn.sqlconeccion.Open();
                SqlDataAdapter DA = new SqlDataAdapter(com);
                DA.Fill(DT);
                Conn.sqlconeccion.Close();
                grid_datos.DataSource = DT;
            }
            catch (Exception ee)
            {
                Conn.sqlconeccion.Close();
                MessageBox.Show("Ha ocurrido un error");
            }
        }
        private void bot_refrescar_Click(object sender, EventArgs e)
        {
            //Acutaliza la ventana ventana por si se hizo algun cambio

            Ciclos_lista_Load(null, null);
        }
        private void bot_eliminar_Click(object sender, EventArgs e)
        {
            /* Se abre conexion con la BD y se ejecuta proc almc CRUD 4 (eliminar) */

            try
            {
                SqlCommand com = new SqlCommand("CRUD_Ciclo", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 4);
                com.Parameters.AddWithValue("Id_ciclo", grid_datos.CurrentRow.Cells[0].Value.ToString());  /*Se tiene que eliminar de la BD el id de la tabla, ya que si no se borra puede crear conflictos*/
                Conn.sqlconeccion.Open();
                com.ExecuteNonQuery();
                Conn.sqlconeccion.Close();
            }
            catch (Exception ee)
            {
                Conn.sqlconeccion.Close();
                MessageBox.Show("Ha ocurrido un error");
            }
            Ciclos_lista_Load(null, null);
        }
        private void bot_crear_Click(object sender, EventArgs e)
        {
            /*El evento del boton crear, hace el llamado a nuestro form crear, donde tenemos actualizar y crar, se ejectua el codigo que tenemos en ese form*/
            Ciclos_form ventana = new Ciclos_form();
            ventana.ShowDialog();
            int cod = ventana.id;
            ventana.Dispose();
            if (cod != 0)
            {
                MessageBox.Show("Se ha creado un registro con Id: " + cod);
            }
            Ciclos_lista_Load(null, null);
        }
        private void bot_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //Lo mismo en este evento, hace el llamado a nuestro form crear y se ejectua el codigo que tenemos ahi para actualziar los datos.

                Ciclos_form ventana = new Ciclos_form(Convert.ToInt32(grid_datos.CurrentRow.Cells[0].Value), grid_datos.CurrentRow.Cells[1].Value.ToString(), grid_datos.CurrentRow.Cells[2].Value.ToString());
                ventana.ShowDialog();
                ventana.Dispose();
                Ciclos_lista_Load(null, null);
            }
            catch (Exception) { }
        }

        private void grid_datos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                pasado(grid_datos.CurrentRow.Cells[0].Value.ToString());
                this.Dispose();
            }
            catch (Exception) { }
        }
    }
}
