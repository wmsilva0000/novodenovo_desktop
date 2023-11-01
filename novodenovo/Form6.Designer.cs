
namespace novodenovo
{
    partial class Tela_servico
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
            this.label10 = new System.Windows.Forms.Label();
            this.tb_cadServ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cadServ = new System.Windows.Forms.Button();
            this.btn_cancServ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(143, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 25);
            this.label10.TabIndex = 58;
            this.label10.Text = "Cadastro de Serviço";
            // 
            // tb_cadServ
            // 
            this.tb_cadServ.Location = new System.Drawing.Point(148, 139);
            this.tb_cadServ.Name = "tb_cadServ";
            this.tb_cadServ.Size = new System.Drawing.Size(171, 20);
            this.tb_cadServ.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nome";
            // 
            // btn_cadServ
            // 
            this.btn_cadServ.Location = new System.Drawing.Point(258, 214);
            this.btn_cadServ.Name = "btn_cadServ";
            this.btn_cadServ.Size = new System.Drawing.Size(75, 23);
            this.btn_cadServ.TabIndex = 59;
            this.btn_cadServ.Text = "Cadastrar";
            this.btn_cadServ.UseVisualStyleBackColor = true;
            this.btn_cadServ.Click += new System.EventHandler(this.btn_cadServ_Click);
            // 
            // btn_cancServ
            // 
            this.btn_cancServ.Location = new System.Drawing.Point(111, 214);
            this.btn_cancServ.Name = "btn_cancServ";
            this.btn_cancServ.Size = new System.Drawing.Size(75, 23);
            this.btn_cancServ.TabIndex = 65;
            this.btn_cancServ.Text = "Cancelar";
            this.btn_cancServ.UseVisualStyleBackColor = true;
            this.btn_cancServ.Click += new System.EventHandler(this.btn_cancServ_Click);
            // 
            // Tela_servico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 409);
            this.Controls.Add(this.btn_cancServ);
            this.Controls.Add(this.btn_cadServ);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_cadServ);
            this.Controls.Add(this.label1);
            this.Name = "Tela_servico";
            this.Text = "Serviço";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_cadServ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cadServ;
        private System.Windows.Forms.Button btn_cancServ;
    }
}