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
    public partial class Tela_servico : Form
    {
        public Tela_servico()
        {
            InitializeComponent();
        }

        private void btn_cadServ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Serviço registrado com sucesso!");
            Tela_pedido telaPedido = new Tela_pedido();
            telaPedido.Show();
            this.Visible = false;
        }
    }
}
