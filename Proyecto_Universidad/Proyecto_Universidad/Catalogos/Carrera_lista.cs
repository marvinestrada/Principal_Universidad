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
    public partial class Carrera_lista : Form
    {
        public Carrera_lista()
        {
            InitializeComponent();
        }

        private void Carrera_crear_Load(object sender, EventArgs e)
        {
            try
            {
             
                SqlCommand com = new SqlCommand("CRUD_Carrera", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 2);
                DataTable DT = new DataTable();
                Conn.sqlconeccion.Open();
                SqlDataAdapter DA = new SqlDataAdapter(com);
                DA.Fill(DT);
                Conn.sqlconeccion.Close();
                datos_carrera.DataSource = DT;
            }
            catch (Exception ee)
            {
                Conn.sqlconeccion.Close();
                MessageBox.Show("Ha ocurrido un error");
            }
            boton_actualizar.Enabled = false;
        }

        private void boton_crear_Click(object sender, EventArgs e)
        {
            Carrera_crear ventana = new Carrera_crear();
            ventana.ShowDialog();
            int cod = ventana.id;
            ventana.Dispose();
            if (cod != 0)
            {
                MessageBox.Show("Se ha registrado: " + cod);
            }
            Carrera_crear_Load(null, null);
        }

        private void boton_refrescar_Click(object sender, EventArgs e)
        {
            Carrera_crear_Load(null, null);
        }

        private void boton_actualizar_Click(object sender, EventArgs e)
        {
            Carrera_crear ventana = new Carrera_crear(Convert.ToInt32(datos_carrera.CurrentRow.Cells[1].Value), datos_carrera.CurrentRow.Cells[0].Value.ToString());
            ventana.ShowDialog();
            ventana.Dispose();
            MessageBox.Show("El registro se ha actualizado con exito");
            Carrera_crear_Load(null, null);
        }

        private void boton_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand("CRUD_Carrera", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 4);
                com.Parameters.AddWithValue("Id_carrera", datos_carrera.CurrentRow.Cells[1].Value.ToString()); /*Se tiene que eliminar de la BD el id de la tabla, ya que si no se borra puede crear conflictos*/
                Conn.sqlconeccion.Open();
                com.ExecuteNonQuery();
                Conn.sqlconeccion.Close();
            }
            catch (Exception ee)
            {
                Conn.sqlconeccion.Close();
                MessageBox.Show("Ha ocurrido un error");
            }
            Carrera_crear_Load(null, null);
        }

        private void datos_carrera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            boton_actualizar.Enabled = true;
        }
    }
}
