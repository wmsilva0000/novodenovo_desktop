
namespace novodenovo
{
    partial class FormServico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_editServ = new System.Windows.Forms.Button();
            this.btn_sairServ = new System.Windows.Forms.Button();
            this.btn_novoServ = new System.Windows.Forms.Button();
            this.btn_filtServ = new System.Windows.Forms.Button();
            this.panel_cadServ = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_idServ = new System.Windows.Forms.TextBox();
            this.btn_cancServ = new System.Windows.Forms.Button();
            this.btn_gravServ = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nomeServ = new System.Windows.Forms.TextBox();
            this.dgvServico = new System.Windows.Forms.DataGridView();
            this.panel_cadServ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_editServ
            // 
            this.btn_editServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editServ.Location = new System.Drawing.Point(193, 230);
            this.btn_editServ.Name = "btn_editServ";
            this.btn_editServ.Size = new System.Drawing.Size(95, 29);
            this.btn_editServ.TabIndex = 41;
            this.btn_editServ.Text = "Editar";
            this.btn_editServ.UseVisualStyleBackColor = true;
            this.btn_editServ.Click += new System.EventHandler(this.btn_editServ_Click);
            // 
            // btn_sairServ
            // 
            this.btn_sairServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sairServ.Location = new System.Drawing.Point(385, 230);
            this.btn_sairServ.Name = "btn_sairServ";
            this.btn_sairServ.Size = new System.Drawing.Size(95, 29);
            this.btn_sairServ.TabIndex = 40;
            this.btn_sairServ.Text = "Sair";
            this.btn_sairServ.UseVisualStyleBackColor = true;
            // 
            // btn_novoServ
            // 
            this.btn_novoServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novoServ.Location = new System.Drawing.Point(97, 230);
            this.btn_novoServ.Name = "btn_novoServ";
            this.btn_novoServ.Size = new System.Drawing.Size(95, 29);
            this.btn_novoServ.TabIndex = 39;
            this.btn_novoServ.Text = "Novo";
            this.btn_novoServ.UseVisualStyleBackColor = true;
            this.btn_novoServ.Click += new System.EventHandler(this.btn_novoServ_Click);
            // 
            // btn_filtServ
            // 
            this.btn_filtServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtServ.Location = new System.Drawing.Point(289, 230);
            this.btn_filtServ.Name = "btn_filtServ";
            this.btn_filtServ.Size = new System.Drawing.Size(95, 29);
            this.btn_filtServ.TabIndex = 38;
            this.btn_filtServ.Text = "Filtrar";
            this.btn_filtServ.UseVisualStyleBackColor = true;
            // 
            // panel_cadServ
            // 
            this.panel_cadServ.Controls.Add(this.label2);
            this.panel_cadServ.Controls.Add(this.btn_cancServ);
            this.panel_cadServ.Controls.Add(this.btn_gravServ);
            this.panel_cadServ.Controls.Add(this.tb_idServ);
            this.panel_cadServ.Controls.Add(this.label3);
            this.panel_cadServ.Controls.Add(this.label1);
            this.panel_cadServ.Controls.Add(this.tb_nomeServ);
            this.panel_cadServ.Location = new System.Drawing.Point(100, 12);
            this.panel_cadServ.Name = "panel_cadServ";
            this.panel_cadServ.Size = new System.Drawing.Size(270, 162);
            this.panel_cadServ.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "ID";
            // 
            // tb_idServ
            // 
            this.tb_idServ.Location = new System.Drawing.Point(10, 50);
            this.tb_idServ.Name = "tb_idServ";
            this.tb_idServ.Size = new System.Drawing.Size(242, 20);
            this.tb_idServ.TabIndex = 32;
            // 
            // btn_cancServ
            // 
            this.btn_cancServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancServ.Location = new System.Drawing.Point(168, 117);
            this.btn_cancServ.Name = "btn_cancServ";
            this.btn_cancServ.Size = new System.Drawing.Size(88, 29);
            this.btn_cancServ.TabIndex = 30;
            this.btn_cancServ.Text = "Cancelar";
            this.btn_cancServ.UseVisualStyleBackColor = true;
            this.btn_cancServ.Click += new System.EventHandler(this.btn_cancServ_Click);
            // 
            // btn_gravServ
            // 
            this.btn_gravServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gravServ.Location = new System.Drawing.Point(85, 117);
            this.btn_gravServ.Name = "btn_gravServ";
            this.btn_gravServ.Size = new System.Drawing.Size(77, 29);
            this.btn_gravServ.TabIndex = 29;
            this.btn_gravServ.Text = "Gravar";
            this.btn_gravServ.UseVisualStyleBackColor = true;
            this.btn_gravServ.Click += new System.EventHandler(this.btn_gravServ_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Serviço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tb_nomeServ
            // 
            this.tb_nomeServ.Location = new System.Drawing.Point(10, 91);
            this.tb_nomeServ.Name = "tb_nomeServ";
            this.tb_nomeServ.Size = new System.Drawing.Size(242, 20);
            this.tb_nomeServ.TabIndex = 1;
            // 
            // dgvServico
            // 
            this.dgvServico.AllowUserToAddRows = false;
            this.dgvServico.AllowUserToDeleteRows = false;
            this.dgvServico.AllowUserToOrderColumns = true;
            this.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServico.Location = new System.Drawing.Point(10, 11);
            this.dgvServico.Name = "dgvServico";
            this.dgvServico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvServico.Size = new System.Drawing.Size(470, 215);
            this.dgvServico.TabIndex = 36;
            this.dgvServico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServico_CellContentClick);
            // 
            // FormServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 271);
            this.Controls.Add(this.btn_editServ);
            this.Controls.Add(this.btn_sairServ);
            this.Controls.Add(this.btn_novoServ);
            this.Controls.Add(this.btn_filtServ);
            this.Controls.Add(this.panel_cadServ);
            this.Controls.Add(this.dgvServico);
            this.Name = "FormServico";
            this.Text = "FormServiço";
            this.Load += new System.EventHandler(this.FormServiço_Load_1);
            this.panel_cadServ.ResumeLayout(false);
            this.panel_cadServ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_editServ;
        private System.Windows.Forms.Button btn_sairServ;
        private System.Windows.Forms.Button btn_novoServ;
        private System.Windows.Forms.Button btn_filtServ;
        private System.Windows.Forms.Panel panel_cadServ;
        private System.Windows.Forms.Button btn_cancServ;
        private System.Windows.Forms.Button btn_gravServ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nomeServ;
        private System.Windows.Forms.DataGridView dgvServico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_idServ;
    }
}