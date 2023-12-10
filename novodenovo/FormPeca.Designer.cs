
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
            this.btn_sairPeca = new System.Windows.Forms.Button();
            this.btn_filtPeca = new System.Windows.Forms.Button();
            this.panel_cadPeca = new System.Windows.Forms.Panel();
            this.btnCancelarPeca = new System.Windows.Forms.Button();
            this.btn_gravPeca = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nomePeca = new System.Windows.Forms.TextBox();
            this.dgvPeca = new System.Windows.Forms.DataGridView();
            this.btnNovoPeca = new System.Windows.Forms.Button();
            this.panel_edit = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_idpeca = new System.Windows.Forms.TextBox();
            this.btn_canc = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_nomepecaEdit = new System.Windows.Forms.TextBox();
            this.panel_cadPeca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeca)).BeginInit();
            this.panel_edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sairPeca
            // 
            this.btn_sairPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sairPeca.Location = new System.Drawing.Point(531, 283);
            this.btn_sairPeca.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sairPeca.Name = "btn_sairPeca";
            this.btn_sairPeca.Size = new System.Drawing.Size(127, 36);
            this.btn_sairPeca.TabIndex = 34;
            this.btn_sairPeca.Text = "Sair";
            this.btn_sairPeca.UseVisualStyleBackColor = true;
            this.btn_sairPeca.Click += new System.EventHandler(this.btn_sairPeca_Click);
            // 
            // btn_filtPeca
            // 
            this.btn_filtPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtPeca.Location = new System.Drawing.Point(396, 283);
            this.btn_filtPeca.Margin = new System.Windows.Forms.Padding(4);
            this.btn_filtPeca.Name = "btn_filtPeca";
            this.btn_filtPeca.Size = new System.Drawing.Size(127, 36);
            this.btn_filtPeca.TabIndex = 32;
            this.btn_filtPeca.Text = "Filtrar";
            this.btn_filtPeca.UseVisualStyleBackColor = true;
            // 
            // panel_cadPeca
            // 
            this.panel_cadPeca.Controls.Add(this.btnCancelarPeca);
            this.panel_cadPeca.Controls.Add(this.btn_gravPeca);
            this.panel_cadPeca.Controls.Add(this.label3);
            this.panel_cadPeca.Controls.Add(this.label1);
            this.panel_cadPeca.Controls.Add(this.tb_nomePeca);
            this.panel_cadPeca.Location = new System.Drawing.Point(197, 66);
            this.panel_cadPeca.Margin = new System.Windows.Forms.Padding(4);
            this.panel_cadPeca.Name = "panel_cadPeca";
            this.panel_cadPeca.Size = new System.Drawing.Size(304, 145);
            this.panel_cadPeca.TabIndex = 31;
            // 
            // btnCancelarPeca
            // 
            this.btnCancelarPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPeca.Location = new System.Drawing.Point(171, 91);
            this.btnCancelarPeca.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarPeca.Name = "btnCancelarPeca";
            this.btnCancelarPeca.Size = new System.Drawing.Size(117, 36);
            this.btnCancelarPeca.TabIndex = 36;
            this.btnCancelarPeca.Text = "Cancelar";
            this.btnCancelarPeca.UseVisualStyleBackColor = true;
            this.btnCancelarPeca.Click += new System.EventHandler(this.btnCancelarPeca_Click);
            // 
            // btn_gravPeca
            // 
            this.btn_gravPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gravPeca.Location = new System.Drawing.Point(60, 91);
            this.btn_gravPeca.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gravPeca.Name = "btn_gravPeca";
            this.btn_gravPeca.Size = new System.Drawing.Size(103, 36);
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
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Peça";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tb_nomePeca
            // 
            this.tb_nomePeca.Location = new System.Drawing.Point(20, 59);
            this.tb_nomePeca.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nomePeca.Name = "tb_nomePeca";
            this.tb_nomePeca.Size = new System.Drawing.Size(267, 22);
            this.tb_nomePeca.TabIndex = 1;
            // 
            // dgvPeca
            // 
            this.dgvPeca.AllowUserToAddRows = false;
            this.dgvPeca.AllowUserToDeleteRows = false;
            this.dgvPeca.AllowUserToOrderColumns = true;
            this.dgvPeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeca.Location = new System.Drawing.Point(24, 14);
            this.dgvPeca.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPeca.Name = "dgvPeca";
            this.dgvPeca.ReadOnly = true;
            this.dgvPeca.RowHeadersWidth = 51;
            this.dgvPeca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeca.Size = new System.Drawing.Size(627, 265);
            this.dgvPeca.TabIndex = 30;
            this.dgvPeca.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeca_CellDoubleClick);
            // 
            // btnNovoPeca
            // 
            this.btnNovoPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoPeca.Location = new System.Drawing.Point(261, 283);
            this.btnNovoPeca.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovoPeca.Name = "btnNovoPeca";
            this.btnNovoPeca.Size = new System.Drawing.Size(127, 36);
            this.btnNovoPeca.TabIndex = 36;
            this.btnNovoPeca.Text = "Novo";
            this.btnNovoPeca.UseVisualStyleBackColor = true;
            this.btnNovoPeca.Click += new System.EventHandler(this.btnNovoPeca_Click);
            // 
            // panel_edit
            // 
            this.panel_edit.Controls.Add(this.label5);
            this.panel_edit.Controls.Add(this.tb_idpeca);
            this.panel_edit.Controls.Add(this.btn_canc);
            this.panel_edit.Controls.Add(this.btn_Edit);
            this.panel_edit.Controls.Add(this.label2);
            this.panel_edit.Controls.Add(this.label4);
            this.panel_edit.Controls.Add(this.tb_nomepecaEdit);
            this.panel_edit.Location = new System.Drawing.Point(197, 42);
            this.panel_edit.Margin = new System.Windows.Forms.Padding(4);
            this.panel_edit.Name = "panel_edit";
            this.panel_edit.Size = new System.Drawing.Size(304, 194);
            this.panel_edit.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "ID";
            // 
            // tb_idpeca
            // 
            this.tb_idpeca.Enabled = false;
            this.tb_idpeca.Location = new System.Drawing.Point(21, 54);
            this.tb_idpeca.Margin = new System.Windows.Forms.Padding(4);
            this.tb_idpeca.Name = "tb_idpeca";
            this.tb_idpeca.ReadOnly = true;
            this.tb_idpeca.Size = new System.Drawing.Size(267, 22);
            this.tb_idpeca.TabIndex = 37;
            // 
            // btn_canc
            // 
            this.btn_canc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_canc.Location = new System.Drawing.Point(172, 137);
            this.btn_canc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_canc.Name = "btn_canc";
            this.btn_canc.Size = new System.Drawing.Size(117, 36);
            this.btn_canc.TabIndex = 36;
            this.btn_canc.Text = "Cancelar";
            this.btn_canc.UseVisualStyleBackColor = true;
            this.btn_canc.Click += new System.EventHandler(this.btn_canc_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(61, 137);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(103, 36);
            this.btn_Edit.TabIndex = 29;
            this.btn_Edit.Text = "Editar";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Peça";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome";
            // 
            // tb_nomepecaEdit
            // 
            this.tb_nomepecaEdit.Location = new System.Drawing.Point(21, 105);
            this.tb_nomepecaEdit.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nomepecaEdit.Name = "tb_nomepecaEdit";
            this.tb_nomepecaEdit.Size = new System.Drawing.Size(267, 22);
            this.tb_nomepecaEdit.TabIndex = 1;
            // 
            // FormPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 334);
            this.Controls.Add(this.panel_edit);
            this.Controls.Add(this.btnNovoPeca);
            this.Controls.Add(this.btn_sairPeca);
            this.Controls.Add(this.btn_filtPeca);
            this.Controls.Add(this.panel_cadPeca);
            this.Controls.Add(this.dgvPeca);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPeca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peças Cadastradas";
            this.Load += new System.EventHandler(this.FormPeca_Load);
            this.panel_cadPeca.ResumeLayout(false);
            this.panel_cadPeca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeca)).EndInit();
            this.panel_edit.ResumeLayout(false);
            this.panel_edit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_sairPeca;
        private System.Windows.Forms.Button btn_filtPeca;
        private System.Windows.Forms.Panel panel_cadPeca;
        private System.Windows.Forms.Button btn_gravPeca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nomePeca;
        private System.Windows.Forms.DataGridView dgvPeca;
        private System.Windows.Forms.Button btnNovoPeca;
        private System.Windows.Forms.Button btnCancelarPeca;
        private System.Windows.Forms.Panel panel_edit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_idpeca;
        private System.Windows.Forms.Button btn_canc;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_nomepecaEdit;
    }
}