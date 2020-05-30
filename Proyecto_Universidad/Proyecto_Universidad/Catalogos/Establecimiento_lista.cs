using Proyecto_Universidad.Catalogos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Universidad
{
    public partial class Establecimiento_lista : Form
    {
        //Delegado para ejecutar un evento, pasar los datos del datagrid al formulario matricula con un parametro
        public delegate void pasar_(string datos_);
        //Evento que lo va ejecutar
        public event pasar_ pasado_;

        public Establecimiento_lista()
        {
            InitializeComponent();
        }
        
        private void Establecimiento_lista_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand("CRUD_Establecimiento", Conn.sqlconeccion);
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
            Establecimiento_lista_Load(null, null);
        }
        private void bot_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand("CRUD_Establecimiento", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 4);
                com.Parameters.AddWithValue("Id_establecimiento", grid_datos.CurrentRow.Cells[0].Value.ToString());
                Conn.sqlconeccion.Open();
                com.ExecuteNonQuery();
                Conn.sqlconeccion.Close();
            }
            catch (Exception ee)
            {
                Conn.sqlconeccion.Close();
                MessageBox.Show("Ha ocurrido un error");
            }
            Establecimiento_lista_Load(null, null);
        }
        private void bot_crear_Click(object sender, EventArgs e)
        {
            Establecimiento_form ventana = new Establecimiento_form();
            ventana.ShowDialog();
            int cod = ventana.id;
            ventana.Dispose();
            if (cod != 0)
            {
                MessageBox.Show("Se ha creado un registro con Id: " + cod);
            }
            Establecimiento_lista_Load(null, null);
        }
        private void bot_actualizar_Click(object sender, EventArgs e)
        {
            Establecimiento_form ventana = new Establecimiento_form(Convert.ToInt32(grid_datos.CurrentRow.Cells[0].Value), grid_datos.CurrentRow.Cells[1].Value.ToString(), grid_datos.CurrentRow.Cells[2].Value.ToString());
            ventana.ShowDialog();
            ventana.Dispose();
            Establecimiento_lista_Load(null, null);
        }

        //Evento doble click para que los datos que se encuentra en la fila del datagrid se envien al formulario matricula
        private void grid_datos_DoubleClick(object sender, EventArgs e)
        {
            pasado_(grid_datos.CurrentRow.Cells[0].Value.ToString());
            this.Dispose();
        }
    }
}
 