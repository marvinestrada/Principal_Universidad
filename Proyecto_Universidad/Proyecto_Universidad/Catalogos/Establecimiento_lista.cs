using Proyecto_Universidad.Catalogos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Universidad
{
    public partial class Establecimiento_lista : Form
    {
        //Variable que guardara el form
        public Matricula_form padre1;
        public Establecimiento_lista(Matricula_form parametro)
        {
            InitializeComponent();

            //Asigno el parametro de mi variable
            padre1 = parametro;
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

        /*Evento doble click, manda los datos que se encuentran a la fila seleccionada a el textbox del formulario padre Matricula_form*/
        private void grid_datos_DoubleClick(object sender, EventArgs e)
        {
            padre1.txtestab.Text = grid_datos.CurrentRow.Cells[0].Value.ToString();
            this.Dispose();
        }
    }
}
 