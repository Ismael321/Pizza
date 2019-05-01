using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pizzaria_eddy
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }
        // se crea la coneccion de base de datos
        SqlConnection coneccion = new SqlConnection("Data Source=DESKTOP-0296OVT;Initial Catalog=Pizza;Integrated Security=True");
        
        // se crea el metodo para logear y recive por parametros el usuario y la contrasena 
        public void logeo( string usuario, string contrasena)
        {
            /*manejo de errores*/
            try
            {
                coneccion.Open();
                /*comando consulta y parametrizando los datos*/                                                                /* pasando la coneccion */
                SqlCommand comando = new SqlCommand(" SELECT nombre , t_usuario FROM usuarios WHERE nombre = @name AND contrasena = @contra", coneccion);
                comando.Parameters.AddWithValue("name", usuario);
                comando.Parameters.AddWithValue("contra", contrasena);
                SqlDataAdapter SDA = new SqlDataAdapter(comando);
                DataTable Dt = new DataTable();
                SDA.Fill(Dt);
                /*si nuestra consulta nos devuelve filas entonces si hay datos*/
                if (Dt.Rows.Count == 1)
                {
                    this.Hide();
                    /*ocultamos el formulario del logeo*/
                    if (Dt.Rows[0][1].ToString() == "administrador")
                    {
                        new Admin().Show();
                    }
                    else if (Dt.Rows[0][1].ToString() == "usuario")
                    {
                        new pizza().Show();
                    }
                }
                else
                { /* de lo contrario no hay datos */
                    MessageBox.Show("Usuario y/o contraseña erroneos");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {

            }
        }
        private void inicio_Load(object sender, EventArgs e)
        {

        }

        private void Logeo_Click(object sender, EventArgs e)
        {
            logeo(this.textBox1.Text, this.textBox2.Text);
        }

        private void inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
