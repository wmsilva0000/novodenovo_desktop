﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace novodenovo
{
    public partial class Tela_pedido : Form
    {
        public Tela_pedido()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido registrado com sucesso!");
        }

        private void btn_servico_Click(object sender, EventArgs e)
        {
            Tela_servico telaServico = new Tela_servico();
            telaServico.Show();
            this.Visible = false;
        }

        private void btn_peca_Click(object sender, EventArgs e)
        {
            Tela_peca telaPeca = new Tela_peca();
            telaPeca.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}