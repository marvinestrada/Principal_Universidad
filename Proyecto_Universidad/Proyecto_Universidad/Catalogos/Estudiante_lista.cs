﻿using Proyecto_Universidad.Catalogos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Universidad
{
    public partial class Estudiante_lista : Form
    {
        //Delegado para ejecutar un evento, pasar los datos del datagrid al formulario matricula con un parametro
        public delegate void pasar (string datos);
        //Evento que lo va ejecutar
        public event pasar pasado;
       
        public Estudiante_lista()
        {
            InitializeComponent();
        }

        public void Estudiante_lista_Load(object sender, EventArgs e)
        {
            try
            {
                /*Se abre conexion con BD y se ejecuta proc almacenado CRUD 2 
                 * Lo que hace es leer los datos que se encuentren a la tabla*/

                SqlCommand com = new SqlCommand("CRUD_estudiante", Conn.sqlconeccion);
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
            //Acutaliza la ventana si se hizo algun cambio

            Estudiante_lista_Load(null, null);
        }
        private void bot_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand("CRUD_estudiante", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 4);
                com.Parameters.AddWithValue("Id_estudiante", grid_datos.CurrentRow.Cells[0].Value.ToString());
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
        private void bot_crear_Click(object sender, EventArgs e)
        {
            /*El evento del btnCrear, hace el llamado a nuestro form crear, donde tenemos actualizar y crear, se ejectua el codigo que tenemos en ese form*/

            Estudiante_crear ventana = new Estudiante_crear();
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
            MessageBox.Show(grid_datos.CurrentRow.Cells[1].Value.ToString());
            Estudiante_crear ventana = new Estudiante_crear(Convert.ToInt32(grid_datos.CurrentRow.Cells[0].Value), grid_datos.CurrentRow.Cells[1].Value.ToString(), grid_datos.CurrentRow.Cells[2].Value.ToString(), grid_datos.CurrentRow.Cells[3].Value.ToString());
            ventana.ShowDialog();
            ventana.Dispose();
            MessageBox.Show("El registro se ha actualizado con exito");
            Estudiante_lista_Load(null, null);
     

        }

        //Evento doble click para que los datos que se encuentra en la fila del datagrid se envien al formulario cobro
        public void data_ListEstu_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                pasado(grid_datos.CurrentRow.Cells[0].Value.ToString());
                this.Dispose();
            }
            catch(Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
