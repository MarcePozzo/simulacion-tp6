﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacion_TP6.InterfacesUsuario
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Form tablero = new FormTablero();
            tablero.ShowDialog();
            this.Dispose();
        }

        private void btnMetodosNumericos_Click(object sender, EventArgs e)
        {
            Form tablero = new FormMetodos();
            tablero.ShowDialog();
            this.Dispose();
        }
    }
}
