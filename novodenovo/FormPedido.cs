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
        //variaveis de controle com seus valores iniciais.
        int idCliente = -1;
        int mIDPedido = -1;
        MySqlConnection conn = null;
        bool Edicao = false;
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

        private bool Conecta()
        {
            string mConn = "server=localhost;database=novodenovo;uid=root;pwd=mjbezerra";
            
            try
            {
                conn = new MySqlConnection(mConn);
                conn.Open();
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;   
            }
        }

        void MostraDados(int IDPedido)
        {
            if (Conecta())
            {
                try
                {
                    MySqlDataAdapter mDA = null;
                    string mSql = "select tb_pedido.id, tb_cliente.nome, tb_peca.nomepeca, tb_pedido_itens.cor, tb_pedido_itens.quantidade, tb_servico.nomeservico, tb_pedido_itens.descricao, tb_pedido_itens.valor_servico, tb_pedido.data_registro, tb_pedido_itens.data_entrega from tb_pedido inner join tb_cliente on tb_pedido.id_cliente = tb_cliente.id inner join tb_pedido_itens on tb_pedido.id = tb_pedido_itens.id_pedido inner join tb_peca on tb_pedido_itens.id_peca = tb_peca.id inner join tb_servico on tb_pedido_itens.id_servico = tb_servico.id; where id_pedido=@id_pedido order by a.id desc";
                    using (MySqlCommand cmd = new MySqlCommand(mSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_pedido", IDPedido);

                        dgvPedido.DataSource = null;//limpo a referencia do data grid para que seja possivel atualizar os dados e remontar as colunas
                        dgvPedido.Columns.Clear();
                        dgvPedido.Rows.Clear();

                        mDA = new MySqlDataAdapter(cmd);
                        DataTable mDt = new DataTable();
                        mDA.Fill(mDt);

                        dgvPedido.DataSource = mDt;//carrego os dados no datagrid

                        //remonto o cabecado das colunas.
                        dgvPedido.Columns[0].HeaderText = "ID Produto";
                        dgvPedido.Columns[1].HeaderText = "Nome Cliente";
                        dgvPedido.Columns[2].HeaderText = "Nome Peça";
                        dgvPedido.Columns[3].HeaderText = "Cor";
                        dgvPedido.Columns[4].HeaderText = "Qtde";
                        dgvPedido.Columns[5].HeaderText = "Nome Serviço";
                        dgvPedido.Columns[6].HeaderText = "Descrição";
                        dgvPedido.Columns[7].HeaderText = "Valor";
                        dgvPedido.Columns[8].HeaderText = "Data Registro";
                        dgvPedido.Columns[9].HeaderText = "Data Entrega";
                        
                        dgvPedido.Columns[0].Visible = false;
                        dgvPedido.Columns[6].Width = 300;
                        /*
                        comboProduto.SelectedIndex = -1;
                        textQtde.Text = "";
                        comboProduto.Select();
                        */
                    }

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {

        }

        private void btnNovoServ(object sender, EventArgs e)
        {
            string msql = "";
            if (TbNome == null)
            {
                MessageBox.Show("selecione um cliente antes");
                return;
            }
            /*
            if (comboProduto.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o produto");
                return;
            }
            */
            int Qtde = 0;
            //Aqui, valido se foi digitado um dados numerico
            if (!int.TryParse(qtd.Text, out Qtde))
            {
                MessageBox.Show("Informe a quentidade");
                return;
            }

            if (Edicao)
            {
                msql = "update tb_pedido_itens(id_produto=@id_produto,qtde=@qtde where @id)";//a atualização deve acontecer conforme o id do item cadastrado
                if (Conecta())
                {
                    using (MySqlCommand cmd = new MySqlCommand(msql, conn))
                    {

                        cmd.Parameters.AddWithValue("@id_produto", cbPeca.SelectedValue);
                        cmd.Parameters.AddWithValue("@qtde", Qtde);

                        cmd.Parameters.AddWithValue("@id", dgvPedido.CurrentRow.Cells[0].Value);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                //caso nenhum item tenha sido selecionado, crio um pedido novo...
                if (dgvPedido.Rows.Count == 0)
                {
                    msql = "insert into tb_pedido(id_cliente)values(@id_cliente)";
                    if (Conecta())
                    {


                        using (MySqlCommand cmd = new MySqlCommand(msql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                            cmd.ExecuteNonQuery();
                        }

                        //aqui, executo a instrucao para selecionar o ultimo ID gerado
                        msql = "select LAST_INSERT_ID()";
                        MySqlDataReader mDR = null;
                        using (MySqlCommand cmd = new MySqlCommand(msql, conn))
                        {
                            try
                            {
                                cmd.ExecuteNonQuery();
                                mDR = cmd.ExecuteReader();//executo a consulta
                                if (mDR.Read())
                                {
                                    //se existe retorno (dados) na consulta
                                    mIDPedido = int.Parse(mDR[0].ToString());
                                }

                            }
                            catch (Exception err)
                            {
                                MessageBox.Show(err.Message);
                            }
                            finally
                            {
                                if (!mDR.IsClosed)
                                {
                                    mDR.Close();
                                }
                            }
                        }

                        button1.Enabled = false;  //desabilito o botao para selecao de um novo cliente até que o pedido seja finalizado
                    }
                }

                //crio os itens do pedido
                msql = "insert into tb_pedido_detalhe(id_pedido,id_produto,qtde)values(@id_pedido,@id_produto,@qtde)";
                if (Conecta())
                {
                    using (MySqlCommand cmd = new MySqlCommand(msql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_pedido", mIDPedido);
                        cmd.Parameters.AddWithValue("@id_produto", cbPeca.SelectedValue);//pego o valor (id) do produto selecionado na combpo
                        cmd.Parameters.AddWithValue("@qtde", Qtde);
                        cmd.ExecuteNonQuery();
                    }
                }
            }//fim se edicao

            cbPeca.SelectedIndex = -1;
            qtd.Text = "";
            Edicao = false;

            //Carrego os dados na grade
            MostraDados(mIDPedido);
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


        

        private void Tela_pedido_Load(object sender, EventArgs e)
        {


        }
    }
}