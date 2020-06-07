using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Universidad.Catalogos
{
    public partial class Profesor_lista : Form
    {
        //Delegado para ejecutar un evento, pasar los datos del datagrid al formulario matricula con un parametro
        public delegate void pasar(string datos);
        //Evento que lo va ejecutar
        public event pasar pasado;
        public Profesor_lista()
        {
            InitializeComponent();
        }

        private void Profesor_lista_Load(object sender, EventArgs e)
        {
            try
            {
                /*Se abre conexion con BD y se ejecuta proc almacenado CRUD 2 
                 * Lo que hace es leer los datos que se encuentren a la tabla*/

                SqlCommand com = new SqlCommand("CRUD_Profesor", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 2);
                DataTable DT = new DataTable();
                Conn.sqlconeccion.Open();
                SqlDataAdapter DA = new SqlDataAdapter(com);
                DA.Fill(DT);
                Conn.sqlconeccion.Close();
                data_ListPro.DataSource = DT;
            }
            catch (Exception ee)
            {
                Conn.sqlconeccion.Close();
                MessageBox.Show("Ha ocurrido un error");
            }
        }
        private void btnRefrescarPro_Click(object sender, EventArgs e)
        {
            //Acutaliza la ventana si se hizo algun cambio
            Profesor_lista_Load(null, null);
        }
        private void btnEliminarPro_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand("CRUD_Profesor", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 4);
                com.Parameters.AddWithValue("Id_profesor", data_ListPro.CurrentRow.Cells[0].Value.ToString());
                Conn.sqlconeccion.Open();
                com.ExecuteNonQuery();
                Conn.sqlconeccion.Close();
            }
            catch (Exception ee)
            {
                Conn.sqlconeccion.Close();
                MessageBox.Show("Ha ocurrido un error");
            }
            Profesor_lista_Load(null, null);
        }
        private void bot_crear_Click(object sender, EventArgs e)
        {
            /*El evento del btnCrear, hace el llamado a nuestro form crear, donde tenemos actualizar y crear, se ejectua el codigo que tenemos en ese form*/
            Profesor_crear ventana = new Profesor_crear();
            ventana.ShowDialog();
            int cod = ventana.id;
            ventana.Dispose();
            if (cod != 0)
            {
                MessageBox.Show("Se ha creado un registro con Id: " + cod);
            }
            Profesor_lista_Load(null, null);
        }
        private void bot_actualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(data_ListPro.CurrentRow.Cells[1].Value.ToString());
            Profesor_crear ventana = new Profesor_crear(Convert.ToInt32(data_ListPro.CurrentRow.Cells[0].Value), data_ListPro.CurrentRow.Cells[1].Value.ToString(), data_ListPro.CurrentRow.Cells[2].Value.ToString());
            ventana.ShowDialog();
            ventana.Dispose();
            MessageBox.Show("El registro se ha actualizado con exito");
            Profesor_lista_Load(null, null);
        }


    }
}

