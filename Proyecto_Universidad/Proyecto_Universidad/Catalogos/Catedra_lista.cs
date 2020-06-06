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

namespace Proyecto_Universidad.Catalogos
{
    public partial class Catedra_lista : Form
    {
        public delegate void pasar(string datos);
        //Evento que lo va ejecutar
        public event pasar pasado;

        public Catedra_lista()
        {
            InitializeComponent();
        }

        private void button_crear_Click(object sender, EventArgs e)
        {
            Catedra_crear ventana = new Catedra_crear();
            ventana.ShowDialog();
            int cod = ventana.id;
            ventana.Dispose();
            if (cod != 0)
            {
                MessageBox.Show("Se ha registrado: " + cod);
            }
            Catedra_lista_Load(null, null);
        }

        private void button_refrescar_Click(object sender, EventArgs e)
        {
            Catedra_lista_Load(null, null);
        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            Catedra_crear ventana = new Catedra_crear(Convert.ToInt32(datos_catedra.CurrentRow.Cells[1].Value), datos_catedra.CurrentRow.Cells[0].Value.ToString());
            ventana.ShowDialog();
            ventana.Dispose();
            MessageBox.Show("El registro se ha actualizado con exito");
            Catedra_lista_Load(null, null);
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand("CRUD_Catedra", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 4);
                com.Parameters.AddWithValue("Id_catedra", datos_catedra.CurrentRow.Cells[1].Value.ToString()); /*Se tiene que eliminar de la BD el id de la tabla, ya que si no se borra puede crear conflictos*/
                Conn.sqlconeccion.Open();
                com.ExecuteNonQuery();
                Conn.sqlconeccion.Close();
            }
            catch (Exception ee)
            {
                Conn.sqlconeccion.Close();
                MessageBox.Show("Ha ocurrido un error");
            }
            Catedra_lista_Load(null, null);
        }

        private void datos_catedra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button_actualizar.Enabled = true;
        }

        private void Catedra_lista_Load(object sender, EventArgs e)
        {
            try
            {

                SqlCommand com = new SqlCommand("CRUD_Catedra", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 2);
                DataTable DT = new DataTable();
                Conn.sqlconeccion.Open();
                SqlDataAdapter DA = new SqlDataAdapter(com);
                DA.Fill(DT);
                Conn.sqlconeccion.Close();
                datos_catedra.DataSource = DT;
            }
            catch (Exception ee)
            {
                Conn.sqlconeccion.Close();
                MessageBox.Show("Ha ocurrido un error");
            }
            button_actualizar.Enabled = false;
        }

        private void datos_catedra_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
