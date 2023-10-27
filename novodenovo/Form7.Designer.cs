
namespace novodenovo
{
    partial class Tela_peca
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
            this.btn_cadPeca = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_cadPeca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancPeca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cadPeca
            // 
            this.btn_cadPeca.Location = new System.Drawing.Point(254, 234);
            this.btn_cadPeca.Name = "btn_cadPeca";
            this.btn_cadPeca.Size = new System.Drawing.Size(75, 23);
            this.btn_cadPeca.TabIndex = 63;
            this.btn_cadPeca.Text = "Cadastrar";
            this.btn_cadPeca.UseVisualStyleBackColor = true;
            this.btn_cadPeca.Click += new System.EventHandler(this.btn_cadPeca_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(139, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 25);
            this.label10.TabIndex = 62;
            this.label10.Text = "Cadastro de Peça";
            // 
            // tb_cadPeca
            // 
            this.tb_cadPeca.Location = new System.Drawing.Point(158, 156);
            this.tb_cadPeca.Name = "tb_cadPeca";
            this.tb_cadPeca.Size = new System.Drawing.Size(171, 20);
            this.tb_cadPeca.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Nome";
            // 
            // btn_cancPeca
            // 
            this.btn_cancPeca.Location = new System.Drawing.Point(115, 234);
            this.btn_cancPeca.Name = "btn_cancPeca";
            this.btn_cancPeca.Size = new System.Drawing.Size(75, 23);
            this.btn_cancPeca.TabIndex = 64;
            this.btn_cancPeca.Text = "Cancelar";
            this.btn_cancPeca.UseVisualStyleBackColor = true;
            this.btn_cancPeca.Click += new System.EventHandler(this.btn_cancPeca_Click);
            // 
            // Tela_peca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 391);
            this.Controls.Add(this.btn_cancPeca);
            this.Controls.Add(this.btn_cadPeca);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_cadPeca);
            this.Controls.Add(this.label1);
            this.Name = "Tela_peca";
            this.Text = "Peça";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadPeca;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_cadPeca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancPeca;
    }
}