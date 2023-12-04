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
            panel_cadPeca.Visible = false;
            panel_edit.Visible = false;
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
                MySqlCommand comando = new MySqlCommand("INSERT INTO tb_peca(nomepeca) values('" + tb_nomePeca.Text + "');", meuSql);
                comando.ExecuteNonQuery();

                MessageBox.Show("Registro Inserido com sucesso!");
                CarregarDadosBanco();
                tb_nomePeca.Text = "";

            }
        }
        private void btnNovoPeca_Click(object sender, EventArgs e)
        {
            panel_cadPeca.Visible = true;
        }

        private void btnCancelarPeca_Click(object sender, EventArgs e)
        {
            panel_cadPeca.Visible = false;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
        

            string conexao = "server=localhost;database=novodenovo;uid=root;pwd=etec";
            MySqlConnection conexaoMySql = new MySqlConnection(conexao);
            conexaoMySql.Open();

            MySqlCommand comando = new MySqlCommand("update tb_peca set nomepeca='" + tb_nomepecaEdit.Text + "' where id=" + tb_idpeca.Text, conexaoMySql);
            comando.ExecuteNonQuery();
            MessageBox.Show("Dados alterados!!!");
            CarregarDadosBanco();
            panel_edit.Visible = false;
        }

        private void btn_canc_Click(object sender, EventArgs e)
        {
            panel_edit.Visible = false;
        }

        private void btn_sairPeca_Click(object sender, EventArgs e)
        {
            MDIMenu menu = new MDIMenu();
            menu.Show();
            this.Visible = false;
        }

        private void dgvPeca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panel_edit.Visible = true;
            tb_idpeca.Text = dgvPeca.Rows[e.RowIndex].Cells[0].Value.ToString(); ;
        }
    }
}
