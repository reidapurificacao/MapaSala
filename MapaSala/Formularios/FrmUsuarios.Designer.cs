﻿
namespace MapaSala.Formularios
{
    partial class FrmUsuarios
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
            this.txtSenhaUser = new System.Windows.Forms.TextBox();
            this.txtGmailUser = new System.Windows.Forms.TextBox();
            this.dtGridSalas = new System.Windows.Forms.DataGridView();
            this.btnSalvarpro = new System.Windows.Forms.Button();
            this.chkAtivoUser = new System.Windows.Forms.CheckBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSenhaUser
            // 
            this.txtSenhaUser.Location = new System.Drawing.Point(440, 35);
            this.txtSenhaUser.Name = "txtSenhaUser";
            this.txtSenhaUser.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaUser.TabIndex = 38;
            // 
            // txtGmailUser
            // 
            this.txtGmailUser.Location = new System.Drawing.Point(322, 35);
            this.txtGmailUser.Name = "txtGmailUser";
            this.txtGmailUser.Size = new System.Drawing.Size(100, 20);
            this.txtGmailUser.TabIndex = 37;
            // 
            // dtGridSalas
            // 
            this.dtGridSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridSalas.Location = new System.Drawing.Point(65, 81);
            this.dtGridSalas.Name = "dtGridSalas";
            this.dtGridSalas.Size = new System.Drawing.Size(673, 352);
            this.dtGridSalas.TabIndex = 36;
            // 
            // btnSalvarpro
            // 
            this.btnSalvarpro.Location = new System.Drawing.Point(663, 35);
            this.btnSalvarpro.Name = "btnSalvarpro";
            this.btnSalvarpro.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarpro.TabIndex = 35;
            this.btnSalvarpro.Text = "Salvar";
            this.btnSalvarpro.UseVisualStyleBackColor = true;
            // 
            // chkAtivoUser
            // 
            this.chkAtivoUser.AutoSize = true;
            this.chkAtivoUser.Location = new System.Drawing.Point(569, 39);
            this.chkAtivoUser.Name = "chkAtivoUser";
            this.chkAtivoUser.Size = new System.Drawing.Size(50, 17);
            this.chkAtivoUser.TabIndex = 34;
            this.chkAtivoUser.Text = "Ativo";
            this.chkAtivoUser.UseVisualStyleBackColor = true;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(130, 35);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(44, 20);
            this.txtUser.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Gmail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nome";
            // 
            // txtNomeUser
            // 
            this.txtNomeUser.Location = new System.Drawing.Point(198, 35);
            this.txtNomeUser.Name = "txtNomeUser";
            this.txtNomeUser.Size = new System.Drawing.Size(100, 20);
            this.txtNomeUser.TabIndex = 28;
            this.txtNomeUser.TextChanged += new System.EventHandler(this.txtNomepro_TextChanged);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSenhaUser);
            this.Controls.Add(this.txtGmailUser);
            this.Controls.Add(this.dtGridSalas);
            this.Controls.Add(this.btnSalvarpro);
            this.Controls.Add(this.chkAtivoUser);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeUser);
            this.Name = "FrmUsuarios";
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenhaUser;
        private System.Windows.Forms.TextBox txtGmailUser;
        private System.Windows.Forms.DataGridView dtGridSalas;
        private System.Windows.Forms.Button btnSalvarpro;
        private System.Windows.Forms.CheckBox chkAtivoUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeUser;
    }
}