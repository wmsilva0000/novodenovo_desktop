
namespace novodenovo
{
    partial class FormHistorico
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.dtpAte = new System.Windows.Forms.DateTimePicker();
            this.dgvHistorico = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFaturamento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(368, 42);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Periodo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "De:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Até:";
            // 
            // dtpDe
            // 
            this.dtpDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDe.Location = new System.Drawing.Point(60, 42);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(109, 22);
            this.dtpDe.TabIndex = 4;
            // 
            // dtpAte
            // 
            this.dtpAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAte.Location = new System.Drawing.Point(224, 42);
            this.dtpAte.Name = "dtpAte";
            this.dtpAte.Size = new System.Drawing.Size(109, 22);
            this.dtpAte.TabIndex = 5;
            // 
            // dgvHistorico
            // 
            this.dgvHistorico.AllowUserToAddRows = false;
            this.dgvHistorico.AllowUserToDeleteRows = false;
            this.dgvHistorico.AllowUserToOrderColumns = true;
            this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorico.Location = new System.Drawing.Point(15, 70);
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.ReadOnly = true;
            this.dgvHistorico.RowHeadersWidth = 51;
            this.dgvHistorico.RowTemplate.Height = 24;
            this.dgvHistorico.Size = new System.Drawing.Size(859, 445);
            this.dgvHistorico.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Faturamento";
            // 
            // tbFaturamento
            // 
            this.tbFaturamento.Enabled = false;
            this.tbFaturamento.Location = new System.Drawing.Point(499, 36);
            this.tbFaturamento.Name = "tbFaturamento";
            this.tbFaturamento.ReadOnly = true;
            this.tbFaturamento.Size = new System.Drawing.Size(100, 22);
            this.tbFaturamento.TabIndex = 8;
            // 
            // FormHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 527);
            this.Controls.Add(this.tbFaturamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvHistorico);
            this.Controls.Add(this.dtpAte);
            this.Controls.Add(this.dtpDe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Name = "FormHistorico";
            this.Text = "FormHisstorico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.DateTimePicker dtpAte;
        private System.Windows.Forms.DataGridView dgvHistorico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFaturamento;
    }
}