using System;
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
    public partial class MDIMenu : Form
    {
        private int childFormNumber = 0;

        public MDIMenu()
        {
            InitializeComponent();
        }

        private void MDIMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_pedido frm = new Tela_pedido();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente frm = new FormCliente();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void btn_servico_Click(object sender, EventArgs e)
        {
            FormServico telaServico = new FormServico();
            telaServico.Show();
            this.Visible = false;
        }

        private void btn_peca_Click(object sender, EventArgs e)
        {
            FormPeca telaPeca = new FormPeca();
            telaPeca.Show();
            this.Visible = false;
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            FormCliente telaCliente = new FormCliente();
            telaCliente.Show();
            this.Visible = false;
        }

        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistorico telaHistorico = new FormHistorico();
            telaHistorico.Show();
            this.Visible = false;
        }

        private void pendênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPendencias telaPendencias = new FormPendencias();
            telaPendencias.Show();
            this.Visible = false;
        }
    }
}
