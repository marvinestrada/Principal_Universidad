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
    public partial class Carrera_Cat_List : Form
    {
        public delegate void pasar(string datos);
        //Evento que lo va ejecutar
        public event pasar pasado;

        public Carrera_Cat_List()
        {
            InitializeComponent();
        }

        private void Carrera_Cat_List_Load(object sender, EventArgs e)
        {

            try
            {
                SqlCommand com = new SqlCommand("CRUD_Carrera_catedra", Conn.sqlconeccion);
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

        private void boton_actualizar_Click(object sender, EventArgs e)
        {
            Carrera_Cat_List_Load(null, null);
        }

        private void boton_crear_Click(object sender, EventArgs e)
        {
            Carrera_Cat ventana = new Carrera_Cat();
            ventana.ShowDialog();
            int cod = ventana.id;
            ventana.Dispose();
            if (cod != 0)
            {
                MessageBox.Show("Se ha creado un registro con Id: " + cod);
            }
            Carrera_Cat_List_Load(null, null);
        }

        private void boton_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand("CRUD_Carrera_catedra", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 4);
                com.Parameters.AddWithValue("Id_carrera_cat", grid_datos.CurrentRow.Cells[0].Value.ToString());
                Conn.sqlconeccion.Open();
                com.ExecuteNonQuery();
                Conn.sqlconeccion.Close();
            }
            catch (Exception)
            {
                Conn.sqlconeccion.Close();
                MessageBox.Show("Ha ocurrido un error");
            }
            Carrera_Cat_List_Load(null, null);
        }

        private void grid_datos_DoubleClick(object sender, EventArgs e)
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
    }
}
