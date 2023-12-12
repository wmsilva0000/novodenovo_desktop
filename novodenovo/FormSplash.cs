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
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        private void FormSplash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Carregar_barra.Value < 100)
            {
                Carregar_barra.Value = Carregar_barra.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;

                FormLogin telaLogin = new FormLogin();
                telaLogin.Show();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
