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
    public partial class Carrera_Cat : Form
    {
        public int id = 0;
        int Codigo = 0;
        public Carrera_Cat(int codigo = 0, string Carrera = "", string Catedra = "", string Profesor = "")
        {
            InitializeComponent();
            Codigo = codigo;
            text_carrera.Text = Carrera;
            text_catedra.Text = Catedra;
            text_prof.Text = Profesor;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (Codigo != 0)
            {
                SqlCommand com = new SqlCommand();
                com = new SqlCommand("CRUD_Carrera_catedra", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 3);
                com.Parameters.AddWithValue("Id_Carrera_catedra", Codigo);
                com.Parameters.AddWithValue("Id_Carrera", text_carrera.Text);
                com.Parameters.AddWithValue("Id_Catedra", text_catedra.Text);
                com.Parameters.AddWithValue("Id_profesor", text_prof.Text);
                

                Conn.sqlconeccion.Open();
                com.ExecuteNonQuery();
                Conn.sqlconeccion.Close();
                MessageBox.Show("El registro se ha actualizado con exito");
            }
            else
            {
                SqlCommand com = new SqlCommand("CRUD_Carrera_catedra", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 1);
                com.Parameters.AddWithValue("Id_Carrera_catedra", Codigo);
                com.Parameters.AddWithValue("Id_Carrera", text_carrera.Text);
                com.Parameters.AddWithValue("Id_Catedra", text_catedra.Text);
                com.Parameters.AddWithValue("Id_profesor", text_prof.Text);

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

        private void buscar_estud_Click(object sender, EventArgs e)
        {
            Carrera_lista cars = new Carrera_lista();
            /*Llamo al delegado que se encarga de ejecutar la accion*/
            cars.pasado += new Carrera_lista.pasar(ejecutar1);
            cars.ShowDialog();
        }
        public void ejecutar1(string datos)
        {
            //Indica que los datos que se encuntren en el parametro (El evento en el otro formulario) se igual al textbox
            text_carrera.Text = datos;

        }
        #endregion

        #region Busqueda Catedra
        private void button1_Click(object sender, EventArgs e)
        {
            Catedra_lista cate = new Catedra_lista();
            /*Llamo al delegado que se encarga de ejecutar la accion*/
            cate.pasado += new Catedra_lista.pasar(ejecutar2);
            cate.ShowDialog();

        }
        public void ejecutar2(string datos_)
        {
            //Indica que los datos que se encuntren en el parametro (El evento en el otro formulario) se igual al textbox
            text_catedra.Text = datos_;

        }



        #endregion

        #region Profesor
        private void button2_Click(object sender, EventArgs e)
        {
            Profesor_lista prof = new Profesor_lista();
            /*Llamo al delegado que se encarga de ejecutar la accion*/
            prof.pasado += new Profesor_lista.pasar(ejecutar3);
            prof.ShowDialog();

        }
        public void ejecutar3 (string datos_)
        {
            //Indica que los datos que se encuntren en el parametro (El evento en el otro formulario) se igual al textbox
            text_prof.Text = datos_;

        }
        #endregion
    }
        

    }

