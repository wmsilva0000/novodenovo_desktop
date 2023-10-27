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
    }
}
