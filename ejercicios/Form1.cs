﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios
{
    public partial class Form1 : Form
    {
        String[][] TipoDeConversores = new String [][]{
          new String[]{ "Manzana", "Tareas", "Metro cuadrado", "Vara cuadrada", "Yarda cuadrada", "Pie cuadrado", "Hectareas" },
          new String[]{ "Manzana", "Tareas", "Metro cuadrado", "Vara cuadrada", "Yarda cuadrada", "Pie cuadrado", "Hectareas" },
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertirConversores_Click(object sender, EventArgs e)
        {
            int de, a;
            double cantidad, respuesta;

            de = cboDeConversores.SelectedIndex;
            a = cboAConversores.SelectedIndex;

            cantidad = double.Parse(txtCantidadConversores.Text);

            double[][] monedas = {
                new double[]{1, 16, 7000, 10000, 8371.93, 75.207, 0.70},
                new double[]{1, 16, 7000, 10000, 8371.93, 75.207, 0.70},
                };

            respuesta = monedas[cboTipoConversor.SelectedIndex][a] / monedas[cboTipoConversor.SelectedIndex][de] * cantidad;
            lblRespuestaConversores.Text = "Respuesta: " + Math.Round(respuesta, 6);

        }

        private void cboTipoConversor_TextChanged(object sender, EventArgs e)
        {
            cboDeConversores.Items.Clear();
            cboDeConversores.Items.AddRange(TipoDeConversores[cboTipoConversor.SelectedIndex]);

            cboAConversores.Items.Clear();
            cboAConversores.Items.AddRange(TipoDeConversores[cboTipoConversor.SelectedIndex]);
        }
    }
}
