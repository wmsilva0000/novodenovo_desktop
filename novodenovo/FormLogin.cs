﻿using System;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if(tb_usuario.Text == "admin" && tb_senha.Text =="123")
            {
                MDIMenu telaMenu = new MDIMenu();
                telaMenu.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
