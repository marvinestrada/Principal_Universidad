using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Universidad.Catalogos
{
    public partial class Matricula_form : Form
    {
        public int id = 0;
        int Codigo = 0;
        public Matricula_form(int codigo = 0, string estudiante = "", string establecimiento = "", string tipo = "", string ciclo = "")
        {
            InitializeComponent();
            Codigo = codigo;
            txtestud.Text = estudiante;
            txtestab.Text = establecimiento;
            txtTipo.Text = tipo;
            txtCiclo.Text = ciclo;
            
        }
        private void btn_aceptar_Click(object sender, System.EventArgs e)
        {
            if (Codigo != 0)
            {
                SqlCommand com = new SqlCommand();
                com = new SqlCommand("CRUD_Matricula", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 3);
                com.Parameters.AddWithValue("Id_matricula", Codigo);
                com.Parameters.AddWithValue("Fecha_matricula", fecha.Value);
                com.Parameters.AddWithValue("Id_estudiante", txtestud.Text);
                com.Parameters.AddWithValue("Id_establecimiento", txtestab.Text);
                com.Parameters.AddWithValue("Id_tipo", txtTipo.Text);
                com.Parameters.AddWithValue("Id_ciclo", txtCiclo.Text);
                
                Conn.sqlconeccion.Open();
                com.ExecuteNonQuery();
                Conn.sqlconeccion.Close();
                MessageBox.Show("El registro se ha actualizado con exito");
            }
            else
            {
                SqlCommand com = new SqlCommand("CRUD_Matricula", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 1);
                com.Parameters.AddWithValue("Id_matricula", Codigo);
                com.Parameters.AddWithValue("Fecha_matricula", fecha.Value);
                com.Parameters.AddWithValue("Id_estudiante", txtestud.Text);              
                com.Parameters.AddWithValue("Id_establecimiento", txtestab.Text);
                com.Parameters.AddWithValue("Id_tipo", txtTipo.Text);
                com.Parameters.AddWithValue("Id_ciclo", txtCiclo.Text);
                
                Conn.sqlconeccion.Open();
                id = Convert.ToInt32(com.ExecuteScalar());
                Conn.sqlconeccion.Close();
            }
            this.Close();
        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Busqueda
        /*Evento para que cuando se presione doble click sobre una celda del data grid, los datos se copien al textbox estudiante
         * del formulario matricula_form*/
        private void buscar_estud_Click(object sender, EventArgs e)
        {
            //Se hace la llamado al formulario Estudiante_lista para buscar datos

            Estudiante_lista estudiante = new Estudiante_lista(this);
            estudiante.ShowDialog();
            estudiante.Dispose();
        }

        /*Evento para que cuando se presione doble click sobre una celda del data grid, los datos se copien al textbox establecimiento
         * del formulario matricula_form*/
        private void buscar_estab_Click(object sender, EventArgs e)
        {
            Establecimiento_lista establecimiento = new Establecimiento_lista(this);
            establecimiento.ShowDialog();
            establecimiento.Dispose();
        }

        /*Evento para que cuando se presione doble click sobre una celda del data grid, los datos se copien al textbox Tipo
        * del formulario matricula_form*/
        private void buscar_tipo_Click(object sender, EventArgs e)
        {
            Tipo_lista tipo = new Tipo_lista(this);
            tipo.ShowDialog();
            tipo.Dispose();
        }

        private void buscar_ciclo_Click(object sender, EventArgs e)
        {
            Ciclos_lista ciclo = new Ciclos_lista(this);
            ciclo.ShowDialog();
            ciclo.Dispose();
        }
        #endregion


    }
}
