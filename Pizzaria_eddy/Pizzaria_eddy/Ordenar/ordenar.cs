using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_eddy.Ordenar
{
    public partial class ordenar : Form
    {
        public ordenar()
        {
            InitializeComponent();
        }

        private void ordenar_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            CBSabor.Enabled = false;
            CBTamano.Enabled = false;
            CBCantidad.Enabled = false;
            B_ingrediente_1.Enabled = false;
            B_ingrediente_2.Enabled = false;
            B_Ingrediente_3.Enabled = false;
        }

        private void ordenar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            new pizza().Show();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {

        }
        #region Button Validation
        private void radioButtonSi_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonSi.AutoCheck == true)
            {
                CBSabor.Enabled = true;
                CBTamano.Enabled = true;
                CBCantidad.Enabled = true;
            }
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNo.AutoCheck == true)
            {
                CBSabor.Enabled = false;
                CBTamano.Enabled = false;
                CBCantidad.Enabled = false;
            }
        }

        private void CBIngredientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBIngredientes.SelectedItem.ToString() == "1")
            {
                B_ingrediente_1.Enabled = true;
                B_ingrediente_2.Enabled = false;
                B_Ingrediente_3.Enabled = false;
            }
            else if (CBIngredientes.SelectedItem.ToString() == "2")
            {
                B_ingrediente_2.Enabled = true;
                B_ingrediente_1.Enabled = true;
                B_Ingrediente_3.Enabled = false;
            }
            else if (CBIngredientes.SelectedItem.ToString() == "3")
            {
                B_ingrediente_1.Enabled = true;
                B_ingrediente_2.Enabled = true;
                B_Ingrediente_3.Enabled = true;
            }
            else
            {
                B_ingrediente_1.Enabled = false;
                B_ingrediente_2.Enabled = false;
                B_Ingrediente_3.Enabled = false;
            }
        }
        #endregion

    }
}
