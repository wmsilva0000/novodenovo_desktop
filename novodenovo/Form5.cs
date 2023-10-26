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
    public partial class Tela_registro : Form
    {
        public Tela_registro()
        {
            InitializeComponent();
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            Tela_pedido telaPedido = new Tela_pedido();
            telaPedido.Show();
            this.Visible = false;
        }
    }
}
