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
    public partial class FormPeca : Form
    {
        public FormPeca()
        {
            InitializeComponent();
        }

        private void FormPeca_Load(object sender, EventArgs e)
        {
            CarregarDadosBanco();
        }

        private void CarregarDadosBanco()
        {
            string conexao = "server=localhost;database=novodenovo;uid=root;pwd=etec";
            MySqlConnection conexaoMySql = new MySqlConnection(conexao);
            conexaoMySql.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from tb_peca", conexaoMySql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvPeca.DataSource = dt;
        }


        private void btn_gravPeca_Click(object sender, EventArgs e)
        {

            if (tb_nomePeca.Text == "")
            {

            }
            else
            {
                MySqlConnection meuSql = new MySqlConnection("server=localhost;database=novodenovo;uid=root;pwd=etec");
                meuSql.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO tb_peca(nomepeca) values(" + tb_nomePeca.Text + "');", meuSql);
                comando.ExecuteNonQuery();

                MessageBox.Show("Registro Inserido com sucesso!");
                tb_nomePeca.Text = "";
            }
        }

        private void btn_editPeca_Click(object sender, EventArgs e)
        {
            panel_cadPeca.Visible = true;

            string conexao = "server=localhost;database=novodenovo;uid=root;pwd=etec";
            MySqlConnection conexaoMySql = new MySqlConnection(conexao);
            conexaoMySql.Open();

            MySqlCommand command = new MySqlCommand("update tb_peca set nomepeca='" + tb_nomePeca.Text + "'where id_peca=" + tb_idpeca.Text, conexaoMySql);
            
            MessageBox.Show("Dados alterados");

            tb_idpeca.Text = "";
            tb_nomePeca.Text = "";
            
            CarregarDadosBanco();
        }

        private void dgvPeca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_idpeca.Text = dgvPeca.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_nomePeca.Text = dgvPeca.Rows[e.RowIndex].Cells[1].Value.ToString();

            panel_cadPeca.Visible = true;
        }

        private void btnExcluirPeca_Click(object sender, EventArgs e)
        {
            {
                DialogResult caixaMensagem = MessageBox.Show("Deseja realmente exluir essa peça?", "", MessageBoxButtons.YesNo);

                if (caixaMensagem == DialogResult.Yes)
                {
                    string conexao = "server=localhost;database=novodenovo;uid=root;pwd=etec";
                    MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);
                    conexaoMYSQL.Open();
                    MySqlCommand comando = new MySqlCommand("delete from tb_peca where id_peca=" + tb_idpeca.Text + ";", conexaoMYSQL);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Dado excluído com sucesso!");
                    tb_idpeca.Text = "";
                    tb_nomePeca.Text = "";
                    CarregarDadosBanco();
                }
            }
        }

        private void btnNovoPeca_Click(object sender, EventArgs e)
        {
            panel_cadPeca.Visible = true;
        }
    }
}
