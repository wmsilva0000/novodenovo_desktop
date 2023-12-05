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

        private void btn_gravServ_Click(object sender, EventArgs e)
        {
            if (tb_nomeServ.Text == "")
            {

            }
            else 
            {
                MySqlConnection conexaoMYSQL = new MySqlConnection("server=localhost;database=novodenovo;uid=root;pwd=etec");
                conexaoMYSQL.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO tb_servico(nomeservico) values('" + tb_nomeServ.Text +"');", conexaoMYSQL);
                comando.ExecuteNonQuery();
                MessageBox.Show("Serviço cadastrado com sucesso!");
                CarregarDadosBanco();
                tb_nomeServ.Text = "";
            }
        }

        private void btn_cancServ_Click(object sender, EventArgs e)
        {
            panel_cadServ.Visible = false;
        }

        private void FormServiço_Load_1(object sender, EventArgs e)
        {
            CarregarDadosBanco();
            panel_cadServ.Visible = false;
            panel_edit.Visible = false;
        }

        private void CarregarDadosBanco()
        {
            MySqlConnection conexaoMYSQL = new MySqlConnection(Program.conexaoBD);
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            MySqlConnection conexaoMYSQL = new MySqlConnection(Program.conexaoBD);
            conexaoMYSQL.Open();
            MySqlCommand comando = new MySqlCommand("update tb_servico set nomeservico='" + tb_nomeEdit.Text + "' where id=" + tb_id.Text, conexaoMYSQL);
            comando.ExecuteNonQuery();
            MessageBox.Show("Dados alterados!!!");
            CarregarDadosBanco();
            panel_edit.Visible = false;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            panel_edit.Visible = false;
        }

        private void btn_sairServ_Click(object sender, EventArgs e)
        {
            MDIMenu menu = new MDIMenu();
            menu.Show();
            this.Visible = false;
        }
        private void dgvServico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panel_edit.Visible = true;
            tb_id.Text = dgvServico.Rows[e.RowIndex].Cells[0].Value.ToString(); ;
        }
    }
}
