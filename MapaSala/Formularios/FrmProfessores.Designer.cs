﻿
namespace MapaSala.Formularios
{
    partial class FrmProfessores
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
            this.dtGridPro = new System.Windows.Forms.DataGridView();
            this.btnSalvarpro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomepro = new System.Windows.Forms.TextBox();
            this.txtApelidopro = new System.Windows.Forms.TextBox();
            this.NumID = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnExcluirProf = new System.Windows.Forms.Button();
            this.btmeditarProf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumID)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridPro
            // 
            this.dtGridPro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridPro.Location = new System.Drawing.Point(65, 81);
            this.dtGridPro.Name = "dtGridPro";
            this.dtGridPro.Size = new System.Drawing.Size(673, 352);
            this.dtGridPro.TabIndex = 25;
            this.dtGridPro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridPro_CellClick);
            this.dtGridPro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridSalas_CellContentClick);
            // 
            // btnSalvarpro
            // 
            this.btnSalvarpro.Location = new System.Drawing.Point(582, 38);
            this.btnSalvarpro.Name = "btnSalvarpro";
            this.btnSalvarpro.Size = new System.Drawing.Size(75, 26);
            this.btnSalvarpro.TabIndex = 22;
            this.btnSalvarpro.Text = "Salvar";
            this.btnSalvarpro.UseVisualStyleBackColor = true;
            this.btnSalvarpro.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Apelido professor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome do professor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNomepro
            // 
            this.txtNomepro.Location = new System.Drawing.Point(175, 38);
            this.txtNomepro.Name = "txtNomepro";
            this.txtNomepro.Size = new System.Drawing.Size(100, 20);
            this.txtNomepro.TabIndex = 14;
            this.txtNomepro.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtApelidopro
            // 
            this.txtApelidopro.Location = new System.Drawing.Point(334, 39);
            this.txtApelidopro.Name = "txtApelidopro";
            this.txtApelidopro.Size = new System.Drawing.Size(100, 20);
            this.txtApelidopro.TabIndex = 26;
            this.txtApelidopro.TextChanged += new System.EventHandler(this.txtApelidopro_TextChanged);
            // 
            // NumID
            // 
            this.NumID.Location = new System.Drawing.Point(111, 40);
            this.NumID.Name = "NumID";
            this.NumID.Size = new System.Drawing.Size(47, 20);
            this.NumID.TabIndex = 28;
            this.NumID.ValueChanged += new System.EventHandler(this.NumID_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Id";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(680, 38);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(79, 26);
            this.BtnLimpar.TabIndex = 30;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnExcluirProf
            // 
            this.BtnExcluirProf.Location = new System.Drawing.Point(582, 9);
            this.BtnExcluirProf.Name = "BtnExcluirProf";
            this.BtnExcluirProf.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluirProf.TabIndex = 57;
            this.BtnExcluirProf.Text = "Excluir";
            this.BtnExcluirProf.UseVisualStyleBackColor = true;
            this.BtnExcluirProf.Click += new System.EventHandler(this.BtnExcluirProf_Click);
            // 
            // btmeditarProf
            // 
            this.btmeditarProf.Location = new System.Drawing.Point(663, 9);
            this.btmeditarProf.Name = "btmeditarProf";
            this.btmeditarProf.Size = new System.Drawing.Size(75, 23);
            this.btmeditarProf.TabIndex = 56;
            this.btmeditarProf.Text = "Editar";
            this.btmeditarProf.UseVisualStyleBackColor = true;
            this.btmeditarProf.Click += new System.EventHandler(this.btmeditarProf_Click);
            // 
            // FrmProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnExcluirProf);
            this.Controls.Add(this.btmeditarProf);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumID);
            this.Controls.Add(this.txtApelidopro);
            this.Controls.Add(this.dtGridPro);
            this.Controls.Add(this.btnSalvarpro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomepro);
            this.Name = "FrmProfessores";
            this.Text = "\'";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridPro;
        private System.Windows.Forms.Button btnSalvarpro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomepro;
        private System.Windows.Forms.TextBox txtApelidopro;
        private System.Windows.Forms.NumericUpDown NumID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnExcluirProf;
        private System.Windows.Forms.Button btmeditarProf;
    }
}