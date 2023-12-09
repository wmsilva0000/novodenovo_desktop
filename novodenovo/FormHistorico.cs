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
    public partial class FormHistorico : Form
    {
        public FormHistorico()
        {
            InitializeComponent();
        }

        private void CarregarDadosBanco()
        {
            MySqlConnection conexaoMYSQL = new MySqlConnection(Program.conexaoBD);
            conexaoMYSQL.Open();
            //EDITAR O SELECT
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from tb_servico", conexaoMYSQL);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvHistorico.DataSource = dt;
        }
    }
}
