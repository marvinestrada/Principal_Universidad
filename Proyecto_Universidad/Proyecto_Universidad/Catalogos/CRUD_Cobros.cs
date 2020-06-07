using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Proyecto_Universidad.Catalogos
{
    public partial class CRUD_Cobros : Form
    {
        //Variable publica para asignar ID automaticamente a la base de datos

        public int id = 0;
        int Codigo = 0;  //En esta variable se iran guardando todos los ID que se esten agregando
        public CRUD_Cobros(int codigo = 0, string matricula = "", string fecha = "", string cobro = "") //Con este metodo se asignan las variables para los textbox que contendran los datos de la BD
        {
            InitializeComponent();
            Codigo = codigo;      /*Asigno variables a los textbox, seran igual a lo que contenga las variables*/
            txtmatricula.Text = matricula;
            comboFecha.Text = fecha;
            txtCobro.Text = cobro;
        }
        private void btn_aceptar_Click(object sender, System.EventArgs e) //Evento click boton Aceptar
        {
            //Este evento sirve para dos cosas, para insertar datos en la BD y para actualizar
            /*Cuando se inicia el codigo hay una condicional IF y esta se va encargar de revisar si lo que hay
             * en nuestra variable Codigo, si detectta que no es equivalente a cero (!=0) entonces se ejecutara el primer
             * bloque de codigo, que es Actualizar, entonces reemplazara los datos existentes*/

            if (Codigo != 0)
            {

                //Se establece conexion con la BD y ejecuta proc almacenado CRUD 3

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
                /*Si resulta que Codigo es igual a cero, osea que no tiene datos, entonces se ejecuta este bloque de codigo
            * que vendria siendo el procedimiento almacenado CRUD 1 (Insert) agregará todos los datos que textiemos a la BD*/

                //Se establece conexion con la BD y se ejecuta proc almacenado CRUD 1
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
