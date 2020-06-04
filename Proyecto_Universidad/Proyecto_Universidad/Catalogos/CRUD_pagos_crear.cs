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
                com = new SqlCommand("CRUD_Ciclo", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 3);
                com.Parameters.AddWithValue("Id_pago", Codigo);
                com.Parameters.AddWithValue("Id_cobro", txtcobro.Text);
                com.Parameters.AddWithValue("Abono", txtAbono.Text);
                Conn.sqlconeccion.Open();
                com.ExecuteNonQuery();
                Conn.sqlconeccion.Close();
                MessageBox.Show("El registro se ha actualizado con exito");
            }
            else
            {
                SqlCommand com = new SqlCommand("CRUD_Ciclo", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 1);
                com.Parameters.AddWithValue("Id_cobro", txtcobro.Text);
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
    }
}
