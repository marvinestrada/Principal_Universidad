using System;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace Proyecto_Universidad.Catalogos
{
    public partial class CRUD_pagos : Form
    {
        //Delegado para ejecutar un evento, pasar los datos del datagrid al formulario pagos con un parametro
        public delegate void pasar(string datos);
        //Evento que lo va ejecutar
        public event pasar pasado;

        public CRUD_pagos()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        private void CRUD_pagos_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand("CRUD_pagos", Conn.sqlconeccion);
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
            CRUD_pagos_Load(null, null);
        }
        private void bot_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand("CRUD_pagos", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 4);
                com.Parameters.AddWithValue("Id_pago", grid_datos.CurrentRow.Cells[0].Value.ToString());
                Conn.sqlconeccion.Open();
                com.ExecuteNonQuery();
                Conn.sqlconeccion.Close();
            }
            catch (Exception ee)
            {
                Conn.sqlconeccion.Close();
                MessageBox.Show("Error de conexión");
            }
            CRUD_pagos_Load(null, null);
        }
        private void bot_crear_Click(object sender, EventArgs e)
        {
            CRUD_pagos_crear ventana = new CRUD_pagos_crear();
            ventana.ShowDialog();
            int cod = ventana.id;
            ventana.Dispose();
            if (cod != 0)
            {
                MessageBox.Show("Se ha creado un registro con Id: " + cod);
            }
            CRUD_pagos_Load(null, null);
        }
        private void bot_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                CRUD_pagos_crear ventana = new CRUD_pagos_crear(Convert.ToInt32(grid_datos.CurrentRow.Cells[0].Value), grid_datos.CurrentRow.Cells[1].Value.ToString(), grid_datos.CurrentRow.Cells[3].Value.ToString());
                ventana.ShowDialog();
                ventana.Dispose();
                CRUD_pagos_Load(null, null);
            }
            catch (Exception) {/* MessageBox.Show("No ha seleccionado ningun registro para actualizar");*/ }
        }

        private void grid_datos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                pasado(grid_datos.CurrentRow.Cells[0].Value.ToString());
                this.Dispose();
            }
            catch (Exception) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
