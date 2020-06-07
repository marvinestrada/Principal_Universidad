using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Universidad.Catalogos
{
    public partial class CRUD_Cobros_Lista : Form
    {
        //Delegado para ejecutar un evento, pasar los datos del datagrid al formulario pagos con un parametro
        public delegate void pasar(string datos);
        //Evento que lo va ejecutar
        public event pasar pasado;

        public CRUD_Cobros_Lista()
        {
            InitializeComponent();
        }

        private void CRUD_Cobros_Lista_Load(object sender, EventArgs e)
        /*El evento load sirve para cuando se carge la ventana, arranque el siguiente bloque de codigo automaticamente*/

        {
            try
            {
                /*Se abre conexion con BD y se ejecuta proc almacenado CRUD 2 
                 * Lo que hace es leer los datos que se encuentren a la tabla*/

                SqlCommand com = new SqlCommand("CRUD_cobro", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 2);
                DataTable DT = new DataTable();
                Conn.sqlconeccion.Open();
                SqlDataAdapter DA = new SqlDataAdapter(com);
                DA.Fill(DT);
                Conn.sqlconeccion.Close();
                grid_datos.DataSource = DT;
            }
            catch (Exception)
            {
                Conn.sqlconeccion.Close();
                MessageBox.Show("Error de conexión");
            }
        }
        private void bot_refrescar_Click(object sender, EventArgs e)
        {
            //Acutaliza la ventana ventana por si se hizo algun cambio
            CRUD_Cobros_Lista_Load(null, null);
        }
        private void bot_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                /* Se abre conexion con la BD y se ejecuta proc almc CRUD 4 (eliminar) */
                SqlCommand com = new SqlCommand("CRUD_cobro", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 4);
                com.Parameters.AddWithValue("Id_cobro", grid_datos.CurrentRow.Cells[0].Value.ToString());
                Conn.sqlconeccion.Open();
                com.ExecuteNonQuery();
                Conn.sqlconeccion.Close();
            }
            catch (Exception)
            {
                Conn.sqlconeccion.Close();
                MessageBox.Show("Ha ocurrido un error");
            }
            CRUD_Cobros_Lista_Load(null, null);
        }
        private void bot_crear_Click(object sender, EventArgs e)
        {
            /*El evento del boton crear, hace el llamado a nuestro form crear, donde tenemos actualizar y crar, se ejectua el codigo que tenemos en ese form*/

            CRUD_Cobros ventana = new CRUD_Cobros();
            ventana.ShowDialog();
            int cod = ventana.id;
            ventana.Dispose();
            if (cod != 0)
            {
                MessageBox.Show("Se ha creado un registro con Id: " + cod);
            }
            CRUD_Cobros_Lista_Load(null, null);
        }
        private void bot_actualizar_Click(object sender, EventArgs e)
        {

            //Lo mismo en este evento, hace el llamado a nuestro form crear y se ejectua el codigo que tenemos ahi para actualziar los datos.

            try
            {
                CRUD_Cobros ventana = new CRUD_Cobros(Convert.ToInt32(grid_datos.CurrentRow.Cells[1].Value), grid_datos.CurrentRow.Cells[0].Value.ToString(), grid_datos.CurrentRow.Cells[2].Value.ToString(), grid_datos.CurrentRow.Cells[3].Value.ToString());
                ventana.ShowDialog();
                ventana.Dispose();
                CRUD_Cobros_Lista_Load(null, null);
            }
            catch (Exception) { }
        }

        //Evento doble click que esta delegado a que lo realize el formulario CRUD_cobros, lo que se encuentre dentro de este evento se envia para que se ejecute
        private void grid_datos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                pasado(grid_datos.CurrentRow.Cells[1].Value.ToString());
                this.Dispose();
            }
            catch (Exception) { }
        }
    }
}
