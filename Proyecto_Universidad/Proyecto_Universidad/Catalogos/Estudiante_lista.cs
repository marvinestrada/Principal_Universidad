using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Universidad
{
    public partial class CRUD_estudiante : Form
    {
        public CRUD_estudiante()
        {
            InitializeComponent();
        }

        private void CRUD_estudiante_Load(object sender, EventArgs e)
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
            CRUD_estudiante_Load(null, null);
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
            CRUD_estudiante_Load(null, null);
        }
        private void bot_crear_Click(object sender, EventArgs e)
        {
            Ciclos_form ventana = new Ciclos_form();
            ventana.ShowDialog();
            int cod = ventana.id;
            ventana.Dispose();
            if (cod != 0)
            {
                MessageBox.Show("Se ha creado un registro con Id: " + cod);
            }
            CRUD_estudiante_Load(null, null);
        }
        private void bot_actualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(data_ListEstu.CurrentRow.Cells[1].Value.ToString());
            Ciclos_form ventana = new Ciclos_form(Convert.ToInt32(data_ListEstu.CurrentRow.Cells[0].Value), data_ListEstu.CurrentRow.Cells[1].Value.ToString(), data_ListEstu.CurrentRow.Cells[2].Value.ToString());
            ventana.ShowDialog();
            ventana.Dispose();
            MessageBox.Show("El registro se ha actualizado con exito");
            CRUD_estudiante_Load(null, null);
        

    }
  }
}
