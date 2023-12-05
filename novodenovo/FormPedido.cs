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
        /*
        private void CarregarDadoBanco()
        {
            string conexao = "server=localhost;database=novodenovo;uid=root;pwd=etec";
            MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);
            conexaoMYSQL.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from tb_cliente", conexaoMYSQL);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvPedido.DataSource = dt;
        }
        */
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
            string tel = masked_telefone.Text;

            // Cria a conexão com o banco de dados
            using (MySqlConnection conexao = new MySqlConnection(Program.conexaoBD))
            {
                try
                {
                    // Abre a conexão
                    conexao.Open();

                    // Cria um comando SQL para buscar o nome do cliente associado ao CPF
                    string consulta = "SELECT nome FROM tb_cliente WHERE telefone = @tel";

                    // Cria um comando com a consulta SQL e a conexão
                    MySqlCommand comando = new MySqlCommand(consulta, conexao);

                    // Adiciona o parâmetro @cpf com o valor do texto inserido na textBox
                    comando.Parameters.AddWithValue("@tel", tel);

                    // Executa o comando e obtém o resultado
                    object resultado = comando.ExecuteScalar();

                    // Verifica se encontrou um resultado
                    if (resultado != null)
                    {
                        // Exibe o resultado na outra textBox
                        TbNome.Text = resultado.ToString();
                    }
                    else
                    {
                        // Caso não encontre, exibe uma mensagem
                        MessageBox.Show("telefone não encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    // Em caso de erro, exibe a mensagem de erro
                    MessageBox.Show("Erro ao consultar o banco de dados: " + ex.Message);
                }
            }
           
         
        }

        private void Tela_pedido_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}