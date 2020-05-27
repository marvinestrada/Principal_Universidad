using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Universidad.Catalogos
{
    public partial class Tipo_lista : Form
    {
        Matricula_form padre2;
        public Tipo_lista(Matricula_form parametro)
        {
            InitializeComponent();
            padre2 = parametro;
        }
        private void Tipo_lista_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand("CRUD_tipo", Conn.sqlconeccion);
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
            Tipo_lista_Load(null, null);
        }
        private void bot_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand("CRUD_tipo", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 4);
                com.Parameters.AddWithValue("Id_tipo", grid_datos.CurrentRow.Cells[0].Value.ToString());
                Conn.sqlconeccion.Open();
                com.ExecuteNonQuery();
                Conn.sqlconeccion.Close();
            }
            catch (Exception ex)
            {
                Conn.sqlconeccion.Close();
                MessageBox.Show("Ha ocurrido un error");
            }
            Tipo_lista_Load(null, null);
        }
        //private void bot_crear_Click(object sender, EventArgs e)
        //{
        //    Tipo_crear ventana = new Tipo_crear();
        //    ventana.ShowDialog();
        //    int cod = ventana.id;
        //    ventana.Dispose();
        //    if (cod != 0)
        //    {
        //        MessageBox.Show("Se ha creado un registro con Id: " + cod);
        //    }
        //    Tipo_lista_Load(null, null);
        //}
        private void bot_actualizar_Click(object sender, EventArgs e)
        {

            
            Tipo_lista_Load(null, null);
        }

        /*Evento doble click, manda los datos que se encuentran a la fila seleccionada a el formulario padre Matricula_form*/
        private void grid_datos_DoubleClick(object sender, EventArgs e)
        {
            padre2.txtTipo.Text = grid_datos.CurrentRow.Cells[0].Value.ToString();
            this.Dispose();
        }
    }
}
