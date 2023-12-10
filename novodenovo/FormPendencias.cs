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
    public partial class FormPendencias : Form
    {
        public FormPendencias()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MDIMenu menu = new MDIMenu();
            menu.Show();
            this.Visible = false;
        }
    }
}
