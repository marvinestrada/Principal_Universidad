using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Universidad.Catalogos
{
    
    public partial class CRUD_pagos_crear : Form
    {
        public int id = 0;
        int Codigo = 0;
        public CRUD_pagos_crear(int codigo = 0, string cobro = "", string abono = "")
        {
            InitializeComponent();
            Codigo = codigo;
            txtcobro.Text = cobro;
            txtAbono.Text = abono;
        }
        private void btn_aceptar_Click(object sender, System.EventArgs e)
        {
            if (Codigo != 0)
            {
                SqlCommand com = new SqlCommand();
                com = new SqlCommand("CRUD_pagos", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 3);
                com.Parameters.AddWithValue("Id_pago", Codigo);
                com.Parameters.AddWithValue("Id_cobro", txtcobro.Text);
                com.Parameters.AddWithValue("Fecha_pago", fechaPago.Value);
                com.Parameters.AddWithValue("Abono", txtAbono.Text);
                Conn.sqlconeccion.Open();
                com.ExecuteNonQuery();
                Conn.sqlconeccion.Close();
                MessageBox.Show("El registro se ha actualizado con exito");
            }
            else
            {
                SqlCommand com = new SqlCommand("CRUD_pagos", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 1);
                com.Parameters.AddWithValue("Id_cobro", txtcobro.Text);
                com.Parameters.AddWithValue("Fecha_pago", fechaPago.Value);
                com.Parameters.AddWithValue("Abono", txtAbono.Text);
                Conn.sqlconeccion.Open();
                id = Convert.ToInt32(com.ExecuteScalar());
                Conn.sqlconeccion.Close();
            }
            this.Close();
        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region buscar cobro
        /*Evento para abrir lista de cobros*/
        private void buscar_cobros_Click(object sender, EventArgs e)
        {

            //Se hace la llamado al formulario CRUD_cobros para buscar datos

            CRUD_Cobros_Lista cobro = new CRUD_Cobros_Lista();
            /*Llamo al delegado que se encarga de ejecutar la accion*/
            cobro.pasado += new CRUD_Cobros_Lista.pasar(ejecutar);
            cobro.ShowDialog();
        }

        //Metodo con parametro de tipo string
        public void ejecutar(string datos)
        {
            //Indica que los datos que se encuntren en el parametro (El evento en el otro formulario) se igual al textbox
           txtcobro.Text = datos;

        }
#endregion
    }
}
