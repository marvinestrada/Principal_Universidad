using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Proyecto_Universidad.Catalogos
{
    public partial class CRUD_Cobros : Form
    {
        public int id = 0;
        int Codigo = 0;
        public CRUD_Cobros(int codigo = 0, string matricula = "", string fecha = "", string cobro = "")
        {
            InitializeComponent();
            Codigo = codigo;
            txtmatricula.Text = matricula;
            comboFecha.Text = fecha;
            txtCobro.Text = cobro;
        }
        private void btn_aceptar_Click(object sender, System.EventArgs e)
        {
            if (Codigo != 0)
            {
                SqlCommand com = new SqlCommand();
                com = new SqlCommand("CRUD_cobro", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 3);
                com.Parameters.AddWithValue("Id_cobro", Codigo);
                com.Parameters.AddWithValue("Id_matricula", txtmatricula.Text);
                com.Parameters.AddWithValue("Fecha_cobro", comboFecha.Text);
                com.Parameters.AddWithValue("Cobro", txtCobro.Text);
                Conn.sqlconeccion.Open();
                com.ExecuteNonQuery();
                Conn.sqlconeccion.Close();
            }
            else
            {
                SqlCommand com = new SqlCommand("CRUD_Ciclo", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 1);
                com.Parameters.AddWithValue("Id_matricula", txtmatricula.Text);
                com.Parameters.AddWithValue("Fecha_cobro", comboFecha.Text);
                com.Parameters.AddWithValue("Cobro", txtCobro.Text);
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

        #region Buscar Matricula

        /*Evento para abrir lista de matriculas*/
        private void buscar_matric_Click(object sender, EventArgs e)
        {

            //Se hace la llamado al formulario Estudiante_lista para buscar datos

            Matricula_list matricula = new Matricula_list();
            /*Llamo al delegado que se encarga de ejecutar la accion*/
            matricula.pasado += new Matricula_list.pasar(ejecutar);
            matricula.ShowDialog();

        }
            //Metodo con parametro de tipo string
        public void ejecutar(string datos)
        {
            //Indica que los datos que se encuntren en el parametro (El evento en el otro formulario) se igual al textbox
            txtmatricula.Text = datos;

        }
        #endregion
        
    }
}
