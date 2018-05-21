﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace br.edu.etec.zonaleste.consultoriomed
{
    public partial class frmCadEspecialidadeMed : Form
    {
        public frmCadEspecialidadeMed()
        {
            InitializeComponent();
        }

        private void frmCadEspecialidadeMed_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            else
            {
                e.Cancel = true;
            }
        }
    }
}
