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
    public partial class Tela_peca : Form
    {
        public Tela_peca()
        {
            InitializeComponent();
        }

        private void btn_cadPeca_Click(object sender, EventArgs e)
        {
            if (tb_cadPeca.Text == "")
            {
                
            }
            else
            {
                MessageBox.Show("Peça registrada com sucesso!");
                Tela_pedido telaPedido = new Tela_pedido();
                telaPedido.Show();
                this.Visible = false;
            }
        }

        private void btn_cancPeca_Click(object sender, EventArgs e)
        {
            Tela_pedido telaPedido = new Tela_pedido();
            telaPedido.Show();
            this.Visible = false;
        }

        
    }
}
