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
        MySqlConnection conexaoMYSQL = new MySqlConnection(Program.conexaoBD);

        private void CarregarDadosBanco()
        {
            MySqlConnection conexaoMYSQL = new MySqlConnection(Program.conexaoBD);
            conexaoMYSQL.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from tb_servico", conexaoMYSQL);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvPedido.DataSource = dt;
        }
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

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido registrado com sucesso!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tel = masked_telefone.Text;

            using (MySqlConnection conexao = new MySqlConnection(Program.conexaoBD))
            {
                try
                {
                    conexao.Open();

                    string consulta = "SELECT nome FROM tb_cliente WHERE telefone = @tel";

                    MySqlCommand comando = new MySqlCommand(consulta, conexao);

                    comando.Parameters.AddWithValue("@tel", tel);

                    // Executa o comando e obtém o resultado
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        //Exibe o resultado na outre textbox
                        TbNome.Text = resultado.ToString();
                    }
                    else
                    {
                        MessageBox.Show("telefone não encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar o banco de dados: " + ex.Message);
                }
            }
        }

        private void btnNovoServico_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void Tela_pedido_Load(object sender, EventArgs e)
        {

        }
    }
}