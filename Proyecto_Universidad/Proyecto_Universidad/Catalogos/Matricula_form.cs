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

        #region Buscar estudiante
        /*Evento para abrir lista de estudiantes*/
        private void buscar_estud_Click(object sender, EventArgs e)
        {
            //Se hace la llamado al formulario Estudiante_lista para buscar datos

            Estudiante_lista estudiante = new Estudiante_lista();
            /*Llamo al delegado que se encarga de ejecutar la accion*/
            estudiante.pasado += new Estudiante_lista.pasar(ejecutar);
            estudiante.ShowDialog();       
        }

        //Metodo con parametro de tipo string
        public void ejecutar (string datos)
        {
            //Indica que los datos que se encuntren en el parametro (El evento en el otro formulario) se igual al textbox
            txtestud.Text = datos;
            
        }
        #endregion


        #region Buscar establecimiento
        /*Evento para abrir lista de establecimiento*/
        private void buscar_estab_Click(object sender, EventArgs e)
        {
            //Se hace la llamado al formulario Estudiante_lista para buscar datos

            Establecimiento_lista establecimiento = new Establecimiento_lista();
            /*Llamo al delegado que se encarga de ejecutar la accion*/
            establecimiento.pasado_ += new Establecimiento_lista.pasar_(ejecutar_);
            establecimiento.ShowDialog();

        }
        public void ejecutar_(string datos_)
        {
            //Indica que los datos que se encuntren en el parametro (El evento en el otro formulario) se igual al textbox
            txtestab.Text = datos_;

        }


        #endregion

        #region Buscar tipo
        /*Evento para abrir lista de tipos de estudiantes*/
        private void buscar_tipo_Click(object sender, EventArgs e)
        {
            Tipo_lista tipo = new Tipo_lista();
            tipo.pasado += new Tipo_lista.pasar(Ejecutar);
            tipo.ShowDialog();
            
        }

        public void Ejecutar(string datos)
        {
            //Indica que los datos que se encuntren en el parametro (El evento en el otro formulario) se igual al textbox
            txtTipo.Text = datos;

        }

        #endregion

        #region Buscar ciclo
        /*Evento para abrir lista de ciclos*/
        private void buscar_ciclo_Click(object sender, EventArgs e)
        {
            Ciclos_lista ciclo = new Ciclos_lista();
            ciclo.pasado += new Ciclos_lista.pasar(execute);
            ciclo.ShowDialog();
        }

        public void execute(string datos)
        {
            //Indica que los datos que se encuntren en el parametro (El evento en el otro formulario) se igual al textbox
            txtCiclo.Text = datos;

        }

        #endregion

        #endregion

     
    }
}
