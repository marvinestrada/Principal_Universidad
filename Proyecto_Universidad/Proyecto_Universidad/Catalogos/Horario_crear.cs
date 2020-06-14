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
    public partial class Horario_crear : Form
    {
        public int id = 0;
        int Codigo = 0;

        public Horario_crear(int codigo = 0, string Horario = "", string cat_prof = "", string Dia = "", string Hora = "")
        {
            InitializeComponent();
            Codigo = codigo;
            txtHorario.Text = Horario;
            txtCatProf.Text = cat_prof;
            txtDia.Text = Dia;
            txtHora.Text = Hora;

        }

        private void btnAceptarH_Click(object sender, EventArgs e)
        {
            if (Codigo != 0)
            {
                SqlCommand com = new SqlCommand();
                com = new SqlCommand("CRUD_Horarios", Conn.sqlconeccion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CRUD", 3);
                com.Parameters.AddWithValue("Id_Horario", Codigo);
                com.Parameters.AddWithValue("Id_cat_prof", txtCatProf);
                com.Parameters.AddWithValue("Dia", txtDia.Text);
                com.Parameters.AddWithValue("Hora", txtHora.Text);

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
                com.Parameters.AddWithValue("Id_Horario", Codigo);
                com.Parameters.AddWithValue("Id_cat_prof", txtCatProf);
                com.Parameters.AddWithValue("Dia", txtDia.Text);
                com.Parameters.AddWithValue("Hora", txtHora.Text);

                Conn.sqlconeccion.Open();
                id = Convert.ToInt32(com.ExecuteScalar());
                Conn.sqlconeccion.Close();
            }
            this.Close();

        }

        private void btnIdcat_prof_Click(object sender, EventArgs e)
        {
            Carrera_Cat cat_prof  = new Carrera_Cat();
            /*Llamo al delegado que se encarga de ejecutar la accion*/
            cat_prof.pasar += new Carrera_Cat.pasar(ejecutar2);
            cat_prof.ShowDialog();

        }
        public void ejecutar2(string datos_)
        {
            //Indica que los datos que se encuntren en el parametro (El evento en el otro formulario) se igual al textbox
            text_catedra.Text = datos_;
        }
    }
}
