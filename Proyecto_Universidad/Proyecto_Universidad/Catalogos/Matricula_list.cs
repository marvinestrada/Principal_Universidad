using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Universidad.Catalogos
{
    public partial class Matricula_list : Form
    {
        //Delegado para ejecutar un evento, pasar los datos del datagrid al formulario matricula con un parametro
        public delegate void pasar(string datos);
        //Evento que lo va ejecutar
        public event pasar pasado;

        public Matricula_list()
        {
            InitializeComponent();
        }
        private void Matricula_lista_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand("CRUD_Matricula", Conn.sqlconeccion);
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
                MessageBox.Show("Ha ocurrido un error");
            }

        }
        private void bot_refrescar_Click(object sender, EventArgs e)
        {
            Matricula_lista_Load(null, null);
        }
        private void bot_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand("CRUD_Matricula", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 4);
                com.Parameters.AddWithValue("Id_matricula", grid_datos.CurrentRow.Cells[0].Value.ToString());
                Conn.sqlconeccion.Open();
                com.ExecuteNonQuery();
                Conn.sqlconeccion.Close();
            }
            catch (Exception)
            {
                Conn.sqlconeccion.Close();
                MessageBox.Show("Ha ocurrido un error");
            }
            Matricula_lista_Load(null, null);
        }
        private void bot_crear_Click(object sender, EventArgs e)
        {
            Matricula_form ventana = new Matricula_form();
            ventana.ShowDialog();
            int cod = ventana.id;
            ventana.Dispose();
            if (cod != 0)
            {
                MessageBox.Show("Se ha creado un registro con Id: " + cod);
            }
            Matricula_lista_Load(null, null);
        }
        private void bot_actualizar_Click(object sender, EventArgs e)
        {

            Matricula_form ventana = new Matricula_form(Convert.ToInt32(
            grid_datos.CurrentRow.Cells[0].Value), grid_datos.CurrentRow.Cells[1].Value.ToString(),
            grid_datos.CurrentRow.Cells[2].Value.ToString(), grid_datos.CurrentRow.Cells[3].Value.ToString(), grid_datos.CurrentRow.Cells[4].Value.ToString());
            ventana.ShowDialog();
            ventana.Dispose();
            Matricula_lista_Load(null, null);
        }

        //Evento doble click para que los datos que se encuentra en la fila del datagrid se envien al formulario matricula
        public void grid__DoubleClick(object sender, EventArgs e)
        {
            try
            {
                pasado(grid_datos.CurrentRow.Cells[0].Value.ToString());
                this.Dispose();
            }
            catch (Exception)
            {

            }

        }

        private void grid_datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

