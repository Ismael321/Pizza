﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_eddy.orden
{
    public partial class ordenar : Form
    {
        public ordenar()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ordenar_Load(object sender, EventArgs e)
        {

        }

        private void ordenar_FormClosing(object sender, FormClosingEventArgs e)
        {
            new pizza().Show();
        }
    }
}
