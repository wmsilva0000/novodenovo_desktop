﻿
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
            this.btn_cancServ = new System.Windows.Forms.Button();
            this.btn_gravServ = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nomeServ = new System.Windows.Forms.TextBox();
            this.dgvServico = new System.Windows.Forms.DataGridView();
            this.panel_edit = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_nomeEdit = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_cadServ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).BeginInit();
            this.panel_edit.SuspendLayout();
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
            this.btn_sairServ.Click += new System.EventHandler(this.btn_sairServ_Click);
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
            this.panel_cadServ.Controls.Add(this.btn_cancServ);
            this.panel_cadServ.Controls.Add(this.btn_gravServ);
            this.panel_cadServ.Controls.Add(this.label3);
            this.panel_cadServ.Controls.Add(this.label1);
            this.panel_cadServ.Controls.Add(this.tb_nomeServ);
            this.panel_cadServ.Location = new System.Drawing.Point(100, 54);
            this.panel_cadServ.Name = "panel_cadServ";
            this.panel_cadServ.Size = new System.Drawing.Size(270, 120);
            this.panel_cadServ.TabIndex = 37;
            // 
            // btn_cancServ
            // 
            this.btn_cancServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancServ.Location = new System.Drawing.Point(171, 76);
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
            this.btn_gravServ.Location = new System.Drawing.Point(88, 76);
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
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tb_nomeServ
            // 
            this.tb_nomeServ.Location = new System.Drawing.Point(13, 50);
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
            this.dgvServico.ReadOnly = true;
            this.dgvServico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvServico.Size = new System.Drawing.Size(470, 215);
            this.dgvServico.TabIndex = 36;
            // 
            // panel_edit
            // 
            this.panel_edit.Controls.Add(this.label5);
            this.panel_edit.Controls.Add(this.tb_id);
            this.panel_edit.Controls.Add(this.btn_cancelar);
            this.panel_edit.Controls.Add(this.btn_edit);
            this.panel_edit.Controls.Add(this.label2);
            this.panel_edit.Controls.Add(this.label4);
            this.panel_edit.Controls.Add(this.tb_nomeEdit);
            this.panel_edit.Location = new System.Drawing.Point(100, 40);
            this.panel_edit.Name = "panel_edit";
            this.panel_edit.Size = new System.Drawing.Size(270, 162);
            this.panel_edit.TabIndex = 42;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(167, 113);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(88, 29);
            this.btn_cancelar.TabIndex = 30;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(88, 113);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(77, 29);
            this.btn_edit.TabIndex = 29;
            this.btn_edit.Text = "Editar";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Serviço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome";
            // 
            // tb_nomeEdit
            // 
            this.tb_nomeEdit.Location = new System.Drawing.Point(13, 87);
            this.tb_nomeEdit.Name = "tb_nomeEdit";
            this.tb_nomeEdit.Size = new System.Drawing.Size(242, 20);
            this.tb_nomeEdit.TabIndex = 1;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(13, 46);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(242, 20);
            this.tb_id.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "ID";
            // 
            // FormServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 271);
            this.Controls.Add(this.panel_edit);
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
            this.panel_edit.ResumeLayout(false);
            this.panel_edit.PerformLayout();
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
        private System.Windows.Forms.Panel panel_edit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_nomeEdit;
    }
}