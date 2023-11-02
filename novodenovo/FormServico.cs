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
    public partial class FormServico : Form
    {
        public FormServico()
        {
            InitializeComponent();
        }

        private void FormServiço_Load(object sender, EventArgs e)
        {

        }

        private void btn_gravServ_Click(object sender, EventArgs e)
        {
            if (tb_nomeServ.Text == "")
            {

            }
            else 
            {
                MessageBox.Show("Serviço cadastrado com sucesso");
                panel_cadServ.Visible = false;
            }
        }

        private void btn_cancServ_Click(object sender, EventArgs e)
        {
            panel_cadServ.Visible = false;
        }

        private void FormServiço_Load_1(object sender, EventArgs e)
        {
            CarregarDadosBanco();
        }

        private void CarregarDadosBanco()
        {
            string conexao = "server=localhost;database=novodenovo;uid=root;pwd=etec";
            MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);
            conexaoMYSQL.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from tb_servico", conexaoMYSQL);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvServico.DataSource = dt;
        }

        private void btn_novoServ_Click(object sender, EventArgs e)
        {
            panel_cadServ.Visible = true;
        }

        private void btn_editServ_Click(object sender, EventArgs e)
        {
            string conexao = "server=localhost;database=novodenovo;uid=root;pwd=etec";
            MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);
            conexaoMYSQL.Open();
            MySqlCommand comando = new MySqlCommand("update tb_servico set nomeservico='" + dgvServico.Columns["nomeservico"] + "' where id=" + dgvServico.Columns["id"], conexaoMYSQL);
            MessageBox.Show("Dados alterados!!!");
            CarregarDadosBanco();
        }

        private void dgvServico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvServico.Columns["id"].ReadOnly = true;
        }
    }
}
