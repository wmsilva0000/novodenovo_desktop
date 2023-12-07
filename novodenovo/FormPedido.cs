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
        private MySqlCommand command;
        private MySqlConnection connection;
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
            command = new MySqlCommand();
            command.Connection = connection;
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

            // Adicionar lógica para confirmar pedido
            // Exemplo: Inserir dados no banco de dados

            conexaoMYSQL.Open();

            // Inserir dados do pedido na tabela tb_pedido
            string queryPedido = "INSERT INTO tb_pedido (id, data_registro) VALUES (@idPedido, @data_registro);";
            command.CommandText = queryPedido;
        //    command.Parameters.AddWithValue("@id_cliente", Convert.ToInt32(txtClienteId.Text));
            command.Parameters.AddWithValue("@data_registro", DateTime.Now);
            command.ExecuteNonQuery();
            command.Parameters.Clear();

            // Obter o último ID de pedido inserido
            command.CommandText = "SELECT @@IDENTITY";
            int pedidoId = Convert.ToInt32(command.ExecuteScalar());

            // Inserir dados dos serviços na tabela tb_pedido_servico
            foreach (DataGridViewRow row in dgvPedido.Rows)
            {
                string queryServico = "INSERT INTO tb_pedido_itens (id_pedido, descricao, valor_servico, quantidade, data_entrega, cor) " +
                "VALUES (@idPedido, @descricao, @valor_servico, @quantidade, @data_entrega, @cor);";
                command.CommandText = queryServico;
                command.Parameters.AddWithValue("@id_pedido", pedidoId);
                command.Parameters.AddWithValue("@descricao", row.Cells["Descricao"].Value.ToString());
                command.Parameters.AddWithValue("@valor_servico", Convert.ToDecimal(row.Cells["Preco"].Value));
                command.Parameters.AddWithValue("@quantidade", Convert.ToDecimal(row.Cells["Quantidade"].Value));
                command.Parameters.AddWithValue("@ data_entrega", row.Cells["Data de Entrega"].Value.ToString());
                command.Parameters.AddWithValue("@cor", row.Cells["cor"].Value.ToString());
                command.ExecuteNonQuery();
                command.Parameters.Clear(); 
            }

            conexaoMYSQL.Close();

            MessageBox.Show("Pedido confirmado com sucesso!");
            LimparCamposPedido();
        }

        private void LimparCamposServico()
        {
            // Adicionar lógica para limpar campos de serviço
            // Exemplo: Limpar TextBoxes

            tbDescricao.Clear();
            tbValor.Clear();
        }

        private void LimparCamposPedido()
        {
            // Adicionar lógica para limpar campos do pedido
            // Exemplo: Limpar TextBoxes relacionados ao pedido

         //   txtClienteId.Clear();
            dgvPedido.Rows.Clear();
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


        private void btnNovoServ(object sender, EventArgs e)
        {
            dgvPedido.Rows.Add(masked_telefone.Text, TbNome.Text, qtd.Text, cbPeca.Text, cbCor.Text, cbServico.Text, tbValor.Text, tbValorFinal.Text,
            dtEntrega.Text, tbDescricao.Text);
            LimparCamposServico();
        }

        private void Tela_pedido_Load(object sender, EventArgs e)
        {


        }
    }
}