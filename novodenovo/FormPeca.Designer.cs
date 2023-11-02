
namespace novodenovo
{
    partial class FormPeca
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
            this.btn_editPeca = new System.Windows.Forms.Button();
            this.btn_sairPeca = new System.Windows.Forms.Button();
            this.btn_filtPeca = new System.Windows.Forms.Button();
            this.panel_cadPeca = new System.Windows.Forms.Panel();
            this.btn_cancPeca = new System.Windows.Forms.Button();
            this.btn_gravPeca = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nomePeca = new System.Windows.Forms.TextBox();
            this.dgvPeca = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.Label();
            this.tb_idpeca = new System.Windows.Forms.TextBox();
            this.btnExcluirPeca = new System.Windows.Forms.Button();
            this.btnNovoPeca = new System.Windows.Forms.Button();
            this.panel_cadPeca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeca)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_editPeca
            // 
            this.btn_editPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editPeca.Location = new System.Drawing.Point(206, 230);
            this.btn_editPeca.Name = "btn_editPeca";
            this.btn_editPeca.Size = new System.Drawing.Size(95, 29);
            this.btn_editPeca.TabIndex = 35;
            this.btn_editPeca.Text = "Editar";
            this.btn_editPeca.UseVisualStyleBackColor = true;
            this.btn_editPeca.Click += new System.EventHandler(this.btn_editPeca_Click);
            // 
            // btn_sairPeca
            // 
            this.btn_sairPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sairPeca.Location = new System.Drawing.Point(398, 230);
            this.btn_sairPeca.Name = "btn_sairPeca";
            this.btn_sairPeca.Size = new System.Drawing.Size(95, 29);
            this.btn_sairPeca.TabIndex = 34;
            this.btn_sairPeca.Text = "Sair";
            this.btn_sairPeca.UseVisualStyleBackColor = true;
            // 
            // btn_filtPeca
            // 
            this.btn_filtPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtPeca.Location = new System.Drawing.Point(302, 230);
            this.btn_filtPeca.Name = "btn_filtPeca";
            this.btn_filtPeca.Size = new System.Drawing.Size(95, 29);
            this.btn_filtPeca.TabIndex = 32;
            this.btn_filtPeca.Text = "Filtrar";
            this.btn_filtPeca.UseVisualStyleBackColor = true;
            // 
            // panel_cadPeca
            // 
            this.panel_cadPeca.Controls.Add(this.tb_idpeca);
            this.panel_cadPeca.Controls.Add(this.Id);
            this.panel_cadPeca.Controls.Add(this.btn_cancPeca);
            this.panel_cadPeca.Controls.Add(this.btn_gravPeca);
            this.panel_cadPeca.Controls.Add(this.label3);
            this.panel_cadPeca.Controls.Add(this.label1);
            this.panel_cadPeca.Controls.Add(this.tb_nomePeca);
            this.panel_cadPeca.Location = new System.Drawing.Point(70, 57);
            this.panel_cadPeca.Name = "panel_cadPeca";
            this.panel_cadPeca.Size = new System.Drawing.Size(369, 118);
            this.panel_cadPeca.TabIndex = 31;
            // 
            // btn_cancPeca
            // 
            this.btn_cancPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancPeca.Location = new System.Drawing.Point(156, 75);
            this.btn_cancPeca.Name = "btn_cancPeca";
            this.btn_cancPeca.Size = new System.Drawing.Size(88, 29);
            this.btn_cancPeca.TabIndex = 30;
            this.btn_cancPeca.Text = "Cancelar";
            this.btn_cancPeca.UseVisualStyleBackColor = true;
            // 
            // btn_gravPeca
            // 
            this.btn_gravPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gravPeca.Location = new System.Drawing.Point(73, 75);
            this.btn_gravPeca.Name = "btn_gravPeca";
            this.btn_gravPeca.Size = new System.Drawing.Size(77, 29);
            this.btn_gravPeca.TabIndex = 29;
            this.btn_gravPeca.Text = "Gravar";
            this.btn_gravPeca.UseVisualStyleBackColor = true;
            this.btn_gravPeca.Click += new System.EventHandler(this.btn_gravPeca_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Peça";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tb_nomePeca
            // 
            this.tb_nomePeca.Location = new System.Drawing.Point(127, 49);
            this.tb_nomePeca.Name = "tb_nomePeca";
            this.tb_nomePeca.Size = new System.Drawing.Size(214, 20);
            this.tb_nomePeca.TabIndex = 1;
            // 
            // dgvPeca
            // 
            this.dgvPeca.AllowUserToAddRows = false;
            this.dgvPeca.AllowUserToDeleteRows = false;
            this.dgvPeca.AllowUserToOrderColumns = true;
            this.dgvPeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeca.Location = new System.Drawing.Point(18, 11);
            this.dgvPeca.Name = "dgvPeca";
            this.dgvPeca.ReadOnly = true;
            this.dgvPeca.Size = new System.Drawing.Size(470, 215);
            this.dgvPeca.TabIndex = 30;
            this.dgvPeca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeca_CellContentClick);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(70, 31);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(19, 15);
            this.Id.TabIndex = 34;
            this.Id.Text = "Id";
            // 
            // tb_idpeca
            // 
            this.tb_idpeca.Location = new System.Drawing.Point(73, 49);
            this.tb_idpeca.Name = "tb_idpeca";
            this.tb_idpeca.Size = new System.Drawing.Size(48, 20);
            this.tb_idpeca.TabIndex = 35;
            // 
            // btnExcluirPeca
            // 
            this.btnExcluirPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirPeca.Location = new System.Drawing.Point(109, 230);
            this.btnExcluirPeca.Name = "btnExcluirPeca";
            this.btnExcluirPeca.Size = new System.Drawing.Size(95, 29);
            this.btnExcluirPeca.TabIndex = 37;
            this.btnExcluirPeca.Text = "Excluir";
            this.btnExcluirPeca.UseVisualStyleBackColor = true;
            this.btnExcluirPeca.Click += new System.EventHandler(this.btnExcluirPeca_Click);
            // 
            // btnNovoPeca
            // 
            this.btnNovoPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoPeca.Location = new System.Drawing.Point(13, 230);
            this.btnNovoPeca.Name = "btnNovoPeca";
            this.btnNovoPeca.Size = new System.Drawing.Size(95, 29);
            this.btnNovoPeca.TabIndex = 36;
            this.btnNovoPeca.Text = "Novo";
            this.btnNovoPeca.UseVisualStyleBackColor = true;
            this.btnNovoPeca.Click += new System.EventHandler(this.btnNovoPeca_Click);
            // 
            // FormPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 271);
            this.Controls.Add(this.btnExcluirPeca);
            this.Controls.Add(this.btnNovoPeca);
            this.Controls.Add(this.btn_editPeca);
            this.Controls.Add(this.btn_sairPeca);
            this.Controls.Add(this.btn_filtPeca);
            this.Controls.Add(this.panel_cadPeca);
            this.Controls.Add(this.dgvPeca);
            this.Name = "FormPeca";
            this.Text = "FormPeca";
            this.Load += new System.EventHandler(this.FormPeca_Load);
            this.panel_cadPeca.ResumeLayout(false);
            this.panel_cadPeca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_editPeca;
        private System.Windows.Forms.Button btn_sairPeca;
        private System.Windows.Forms.Button btn_filtPeca;
        private System.Windows.Forms.Panel panel_cadPeca;
        private System.Windows.Forms.Button btn_cancPeca;
        private System.Windows.Forms.Button btn_gravPeca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nomePeca;
        private System.Windows.Forms.DataGridView dgvPeca;
        private System.Windows.Forms.TextBox tb_idpeca;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Button btnExcluirPeca;
        private System.Windows.Forms.Button btnNovoPeca;
    }
}