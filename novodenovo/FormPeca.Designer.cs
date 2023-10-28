
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
            this.btn_novoPeca = new System.Windows.Forms.Button();
            this.btn_filtPeca = new System.Windows.Forms.Button();
            this.panel_cadPeca = new System.Windows.Forms.Panel();
            this.btn_cancPeca = new System.Windows.Forms.Button();
            this.btn_gravPeca = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nomePeca = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_genero = new System.Windows.Forms.ComboBox();
            this.panel_cadPeca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_editPeca
            // 
            this.btn_editPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editPeca.Location = new System.Drawing.Point(191, 231);
            this.btn_editPeca.Name = "btn_editPeca";
            this.btn_editPeca.Size = new System.Drawing.Size(95, 29);
            this.btn_editPeca.TabIndex = 35;
            this.btn_editPeca.Text = "Editar";
            this.btn_editPeca.UseVisualStyleBackColor = true;
            // 
            // btn_sairPeca
            // 
            this.btn_sairPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sairPeca.Location = new System.Drawing.Point(383, 231);
            this.btn_sairPeca.Name = "btn_sairPeca";
            this.btn_sairPeca.Size = new System.Drawing.Size(95, 29);
            this.btn_sairPeca.TabIndex = 34;
            this.btn_sairPeca.Text = "Sair";
            this.btn_sairPeca.UseVisualStyleBackColor = true;
            // 
            // btn_novoPeca
            // 
            this.btn_novoPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novoPeca.Location = new System.Drawing.Point(95, 231);
            this.btn_novoPeca.Name = "btn_novoPeca";
            this.btn_novoPeca.Size = new System.Drawing.Size(95, 29);
            this.btn_novoPeca.TabIndex = 33;
            this.btn_novoPeca.Text = "Novo";
            this.btn_novoPeca.UseVisualStyleBackColor = true;
            // 
            // btn_filtPeca
            // 
            this.btn_filtPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtPeca.Location = new System.Drawing.Point(287, 231);
            this.btn_filtPeca.Name = "btn_filtPeca";
            this.btn_filtPeca.Size = new System.Drawing.Size(95, 29);
            this.btn_filtPeca.TabIndex = 32;
            this.btn_filtPeca.Text = "Filtrar";
            this.btn_filtPeca.UseVisualStyleBackColor = true;
            // 
            // panel_cadPeca
            // 
            this.panel_cadPeca.Controls.Add(this.cb_genero);
            this.panel_cadPeca.Controls.Add(this.label2);
            this.panel_cadPeca.Controls.Add(this.btn_cancPeca);
            this.panel_cadPeca.Controls.Add(this.btn_gravPeca);
            this.panel_cadPeca.Controls.Add(this.label3);
            this.panel_cadPeca.Controls.Add(this.label1);
            this.panel_cadPeca.Controls.Add(this.tb_nomePeca);
            this.panel_cadPeca.Location = new System.Drawing.Point(95, 57);
            this.panel_cadPeca.Name = "panel_cadPeca";
            this.panel_cadPeca.Size = new System.Drawing.Size(310, 118);
            this.panel_cadPeca.TabIndex = 31;
            // 
            // btn_cancPeca
            // 
            this.btn_cancPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancPeca.Location = new System.Drawing.Point(208, 75);
            this.btn_cancPeca.Name = "btn_cancPeca";
            this.btn_cancPeca.Size = new System.Drawing.Size(88, 29);
            this.btn_cancPeca.TabIndex = 30;
            this.btn_cancPeca.Text = "Cancelar";
            this.btn_cancPeca.UseVisualStyleBackColor = true;
            // 
            // btn_gravPeca
            // 
            this.btn_gravPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gravPeca.Location = new System.Drawing.Point(125, 75);
            this.btn_gravPeca.Name = "btn_gravPeca";
            this.btn_gravPeca.Size = new System.Drawing.Size(77, 29);
            this.btn_gravPeca.TabIndex = 29;
            this.btn_gravPeca.Text = "Gravar";
            this.btn_gravPeca.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Peça";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tb_nomePeca
            // 
            this.tb_nomePeca.Location = new System.Drawing.Point(14, 49);
            this.tb_nomePeca.Name = "tb_nomePeca";
            this.tb_nomePeca.Size = new System.Drawing.Size(177, 20);
            this.tb_nomePeca.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(470, 215);
            this.dataGridView1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Gerêro";
            // 
            // cb_genero
            // 
            this.cb_genero.FormattingEnabled = true;
            this.cb_genero.Location = new System.Drawing.Point(202, 48);
            this.cb_genero.Name = "cb_genero";
            this.cb_genero.Size = new System.Drawing.Size(94, 21);
            this.cb_genero.TabIndex = 33;
            // 
            // FormPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 271);
            this.Controls.Add(this.btn_editPeca);
            this.Controls.Add(this.btn_sairPeca);
            this.Controls.Add(this.btn_novoPeca);
            this.Controls.Add(this.btn_filtPeca);
            this.Controls.Add(this.panel_cadPeca);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormPeca";
            this.Text = "FormPeca";
            this.panel_cadPeca.ResumeLayout(false);
            this.panel_cadPeca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_editPeca;
        private System.Windows.Forms.Button btn_sairPeca;
        private System.Windows.Forms.Button btn_novoPeca;
        private System.Windows.Forms.Button btn_filtPeca;
        private System.Windows.Forms.Panel panel_cadPeca;
        private System.Windows.Forms.Button btn_cancPeca;
        private System.Windows.Forms.Button btn_gravPeca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nomePeca;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_genero;
        private System.Windows.Forms.Label label2;
    }
}