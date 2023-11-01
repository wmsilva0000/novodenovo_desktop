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
            MySqlConnection meuSQL = new MySqlConnection("server=localhost;database=Aula1909;uid=root;pwd=");
            meuSQL.Open();

            if (tb_cadServ.Text == "")
            {

            }
            else
            {
                MessageBox.Show("Serviço registrado com sucesso!");
                Tela_pedido telaPedido = new Tela_pedido();
                telaPedido.Show();
                this.Visible = false;
            }
        }

        private void btn_cancServ_Click(object sender, EventArgs e)
        {
            Tela_pedido telaPedido = new Tela_pedido();
            telaPedido.Show();
            this.Visible = false;
        }
    }
}
