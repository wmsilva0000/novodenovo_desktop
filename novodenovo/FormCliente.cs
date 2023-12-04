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
 
        private void MostraDados()
        {
            string conexao = "server=localhost;database=novodenovo;uid=root;pwd=mjbezerra";
            MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);
            conexaoMYSQL.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from tb_cliente", conexaoMYSQL);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvCliente.DataSource = dt;



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
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            panelCadastro.Hide();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            if (tb_nome.Text == "" && masked_tb_telefone.Text == "")
            {

            }
            else
            {
                MySqlConnection conexaoMYSQL = new MySqlConnection("server=localhost;database=novodenovo;uid=root;pwd=mjbezerra");
                conexaoMYSQL.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO tb_cliente(nome, telefone) values('" + tb_nome.Text + "','" + masked_tb_telefone.Text + "');", conexaoMYSQL);
                comando.ExecuteNonQuery();
                MessageBox.Show("Serviço cadastrado com sucesso!");
                MostraDados();
                tb_nome.Text = "";
                masked_tb_telefone.Text = "";
            }

           

            //MENSAGEM DE CONFIRMACAO


        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
