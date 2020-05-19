using System;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace Proyecto_Universidad.Catalogos
{
    public partial class CRUD_pagos : Form
    {
        public CRUD_pagos()
        {
            InitializeComponent();
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
                datosgrid.DataSource = DT;
            }
            catch (Exception ee)
            {
                Conn.sqlconeccion.Close();
                MessageBox.Show("Ha ocurrido un error");


            }
        }

        private void bot_crear_Click(object sender, EventArgs e)
        {
            Crear_Pagos ventana = new Crear_Pagos();
            ventana.ShowDialog();
            int cod = ventana.id;
            ventana.Dispose();
            if (cod != 0)
            {
                MessageBox.Show("Se ha creado un pago con Id: " + cod);
            }
            CRUD_pagos_Load(null, null);
        }

        private void boton_refrescar_Click(object sender, EventArgs e)
        {
            CRUD_pagos_Load(null, null);
        }

        private void bot_actualizar_Click(object sender, EventArgs e)
        {
            Crear_Pagos ventana = new Crear_Pagos(Convert.ToInt32(datosgrid.CurrentRow.Cells[1].Value), datosgrid.CurrentRow.Cells[0].Value.ToString());
            ventana.ShowDialog();
            ventana.Dispose();
            MessageBox.Show("El registro se ha actualizado con exito");
            Crear_Pagos(null, null);
        }

        private void Crear_Pagos(object p1, object p2)
        {
            throw new NotImplementedException();
        }

        private void bot_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand("CRUD_pagos", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 4);
                com.Parameters.AddWithValue("Id_cobro",datosgrid.CurrentRow.Cells[0].Value.ToString());
                Conn.sqlconeccion.Open();
                com.ExecuteNonQuery();
                Conn.sqlconeccion.Close();
            }
            catch (Exception ee)
            {
                Conn.sqlconeccion.Close();
                MessageBox.Show("Ha ocurrido un error");
            }
            CRUD_pagos_Load(null, null);
        }
    }
}
