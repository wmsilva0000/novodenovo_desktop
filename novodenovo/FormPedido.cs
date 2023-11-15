using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace novodenovo
{
    public partial class Tela_pedido : Form
    {
        public Tela_pedido()
        {
            InitializeComponent();
            cboPeca();
        }
        MySqlConnection conexaoMYSQL = new MySqlConnection("server=localhost;database=novodenovo;uid=root;pwd=etec");

        void cboPeca()
        {
            try
            {
                string tb_peca = "select * from tb_peca";
                MySqlCommand cmdSalvar = new MySqlCommand(tb_peca, conexaoMYSQL);
                conexaoMYSQL.Open();
                DataSet ds = new DataSet();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSalvar);
                adapter.Fill(ds);
                cbPeca.DataSource = ds.Tables[0];
                cbPeca.DisplayMember = "nomepeca";
                cbPeca.ValueMember = "id";

                conexaoMYSQL.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string tb_servico = "select * from tb_servico";
                MySqlCommand cmdSalvarServ = new MySqlCommand(tb_servico, conexaoMYSQL);
                conexaoMYSQL.Open();
                DataSet dsServ = new DataSet();
                MySqlDataAdapter adapterServ = new MySqlDataAdapter(cmdSalvarServ);
                adapterServ.Fill(dsServ);
                cbServico.DataSource = dsServ.Tables[0];
                cbServico.DisplayMember = "nomeservico";
                cbServico.ValueMember = "id";

                conexaoMYSQL.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void CarregarDadosBanco()
        {
            string conexao = "server=localhost;database=novodenovo;uid=root;pwd=etec";
            MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);
            conexaoMYSQL.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter(
                "select nome, telefone from tb_cliente where telefone=" + masked_telefone, conexaoMYSQL);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvPedido.DataSource = dt;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

    

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido registrado com sucesso!");
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Tela_pedido_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}