using MySql.Data.MySqlClient;
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
    public partial class FormCliente : Form
    {
        bool blEditar = false;
        private void MostraDados()
        {
            //instrucao para abrir a conexao com o banco de dados
            string mSTrConn = "";
            MySqlConnection mysql = new MySqlConnection(mSTrConn);

            try
            {
                mysql.Open();

                string mSql = "select id,nome,telefone from tb_cliente ";

                using (MySqlCommand cmd = new MySqlCommand(mSql,mysql))
                {
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataTable mDt = new DataTable();

                    mda.Fill(mDt);

                    dataGridView1.DataSource = mDt;
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
            finally
            {
                if (mysql.State == ConnectionState.Open)
                {
                    mysql.Close();
                }
            }

        }
        public FormCliente()
        {
            InitializeComponent();
        }
        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            MostraDados();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            panelCadastro.Hide();
            MostraDados();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            
            panelCadastro.Show();
            blEditar = false;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            panelCadastro.Show();
            blEditar = true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            panelCadastro.Hide();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text==string.Empty)
            {
                MessageBox.Show("Digite o nome do cliente");
                textBoxNome.Select();
                return;
            }

            if (maskedTextBoxTelefone.Text.Length<8)
            {
                MessageBox.Show("Digite o telefone do cliente");
                maskedTextBoxTelefone.Select();
                return;

            }

            if (blEditar)
            {
                //CODIGO PARA UPDATE

                //ATUALIZA A DATAGRID
                panelCadastro.Hide();
            }
            else
            {
                //CODIGO PARA INSERT
                string mSql = "insert into tb_cliente(nome,telefone)values(@nome,@telefone)";
                string mStrConn = "";//string de conexao com o banco de dados
                MySqlConnection mySql = new MySqlConnection(mStrConn);

                try
                {
                    mySql.Open();
                    using (MySqlCommand cmd = new MySqlCommand(mSql,mySql))
                    {
                        cmd.Parameters.AddWithValue("@nome", textBoxNome.Text);
                        cmd.Parameters.AddWithValue("@telefone", maskedTextBoxTelefone.Text);
                        cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                finally
                {
                    if(mySql.State == ConnectionState.Open)
                    {
                        mySql.Close();
                    }
                }
                
                textBoxNome.Text = "";
                maskedTextBoxTelefone.Text = "";
                maskedTextBoxTelefone.Mask = "(##) # ####-####";
                textBoxNome.Select();
            }
            MostraDados();

            //MENSAGEM DE CONFIRMACAO


        }
    }
}
