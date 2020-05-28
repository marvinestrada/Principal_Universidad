using Proyecto_Universidad.Catalogos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Universidad
{
    public partial class Estudiante_lista : Form
    {
        public  Matricula_form padre;
        public Estudiante_lista(Matricula_form parametro)
        {
            InitializeComponent();
            padre = parametro;
        }

        public void Estudiante_lista_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand("CRUD_Estudiante", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 2);
                DataTable DT = new DataTable();
                Conn.sqlconeccion.Open();
                SqlDataAdapter DA = new SqlDataAdapter(com);
                DA.Fill(DT);
                Conn.sqlconeccion.Close();
                data_ListEstu.DataSource = DT;
            }
            catch (Exception ee)
            {
                Conn.sqlconeccion.Close();
                MessageBox.Show("Ha ocurrido un error");
            }
        }
        private void bot_refrescar_Click(object sender, EventArgs e)
        {
            Estudiante_lista_Load(null, null);
        }
        private void bot_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand("CRUD_Estudiante", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 4);
                com.Parameters.AddWithValue("Id_Estudiante", data_ListEstu.CurrentRow.Cells[0].Value.ToString());
                Conn.sqlconeccion.Open();
                com.ExecuteNonQuery();
                Conn.sqlconeccion.Close();
            }
            catch (Exception ee)
            {
                Conn.sqlconeccion.Close();
                MessageBox.Show("Ha ocurrido un error");
            }
            Estudiante_lista_Load(null, null);
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            Datos_Estudiante ventana = new Datos_Estudiante();
            ventana.ShowDialog();
            int cod = ventana.id;
            ventana.Dispose();
            if (cod != 0)
            {
                MessageBox.Show("Se ha creado un registro con Id: " + cod);
            }
            Estudiante_lista_Load(null, null);
        }
        public void bot_actualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(data_ListEstu.CurrentRow.Cells[1].Value.ToString());
            Datos_Estudiante ventana = new Datos_Estudiante(Convert.ToInt32(data_ListEstu.CurrentRow.Cells[0].Value), data_ListEstu.CurrentRow.Cells[1].Value.ToString(), data_ListEstu.CurrentRow.Cells[2].Value.ToString());
            ventana.ShowDialog();
            ventana.Dispose();
            MessageBox.Show("El registro se ha actualizado con exito");
            Estudiante_lista_Load(null, null);
     

        }

        /*Evento doble click, manda los datos que se encuentran a la fila seleccionada a el textbox del formulario padre Matricula_form*/
        public void data_ListEstu_DoubleClick(object sender, EventArgs e)
        {
            padre.txtestud.Text = data_ListEstu.CurrentRow.Cells[0].Value.ToString();
            this.Dispose();
        }
    }
}
