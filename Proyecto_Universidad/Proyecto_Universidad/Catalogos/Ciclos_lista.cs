using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Universidad
{
    public partial class Ciclos_lista : Form
    {
        public Ciclos_lista()
        {
            InitializeComponent();
        }
        private void Ciclos_lista_Load(object sender, EventArgs e)
        {
            try
            {
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
            Ciclos_lista_Load(null, null);
        }
        private void bot_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand("CRUD_Ciclo", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 4);
                com.Parameters.AddWithValue("Id_ciclo", grid_datos.CurrentRow.Cells[0].Value.ToString());
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
           // MessageBox.Show(grid_datos.CurrentRow.Cells[1].Value.ToString());
            Ciclos_form ventana = new Ciclos_form(Convert.ToInt32(grid_datos.CurrentRow.Cells[0].Value), grid_datos.CurrentRow.Cells[1].Value.ToString(), grid_datos.CurrentRow.Cells[2].Value.ToString());
            ventana.ShowDialog();
            ventana.Dispose();
            MessageBox.Show("El registro se ha actualizado con exito");
            Ciclos_lista_Load(null, null);
        }
    }
}
