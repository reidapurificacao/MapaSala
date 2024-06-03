
namespace MapaSala.Formularios
{
    partial class FrmDisciplinas
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
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.dtGridSalas = new System.Windows.Forms.DataGridView();
            this.btnSalvarDisci = new System.Windows.Forms.Button();
            this.chkAtivoDisci = new System.Windows.Forms.CheckBox();
            this.txtIdDisci = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeDisci = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(319, 46);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(100, 20);
            this.txtSigla.TabIndex = 37;
            this.txtSigla.TextChanged += new System.EventHandler(this.txtApelidopro_TextChanged);
            // 
            // dtGridSalas
            // 
            this.dtGridSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridSalas.Location = new System.Drawing.Point(65, 81);
            this.dtGridSalas.Name = "dtGridSalas";
            this.dtGridSalas.Size = new System.Drawing.Size(673, 352);
            this.dtGridSalas.TabIndex = 36;
            this.dtGridSalas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridSalas_CellContentClick);
            // 
            // btnSalvarDisci
            // 
            this.btnSalvarDisci.Location = new System.Drawing.Point(627, 34);
            this.btnSalvarDisci.Name = "btnSalvarDisci";
            this.btnSalvarDisci.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarDisci.TabIndex = 35;
            this.btnSalvarDisci.Text = "Salvar";
            this.btnSalvarDisci.UseVisualStyleBackColor = true;
            this.btnSalvarDisci.Click += new System.EventHandler(this.btnSalvarpro_Click);
            // 
            // chkAtivoDisci
            // 
            this.chkAtivoDisci.AutoSize = true;
            this.chkAtivoDisci.Location = new System.Drawing.Point(492, 46);
            this.chkAtivoDisci.Name = "chkAtivoDisci";
            this.chkAtivoDisci.Size = new System.Drawing.Size(50, 17);
            this.chkAtivoDisci.TabIndex = 34;
            this.chkAtivoDisci.Text = "Ativo";
            this.chkAtivoDisci.UseVisualStyleBackColor = true;
            this.chkAtivoDisci.CheckedChanged += new System.EventHandler(this.chkDisponivelpro_CheckedChanged);
            // 
            // txtIdDisci
            // 
            this.txtIdDisci.Location = new System.Drawing.Point(80, 46);
            this.txtIdDisci.Name = "txtIdDisci";
            this.txtIdDisci.Size = new System.Drawing.Size(44, 20);
            this.txtIdDisci.TabIndex = 33;
            this.txtIdDisci.TextChanged += new System.EventHandler(this.txtIdpro_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Id";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Disciplina";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNomeDisci
            // 
            this.txtNomeDisci.Location = new System.Drawing.Point(160, 46);
            this.txtNomeDisci.Name = "txtNomeDisci";
            this.txtNomeDisci.Size = new System.Drawing.Size(100, 20);
            this.txtNomeDisci.TabIndex = 28;
            this.txtNomeDisci.TextChanged += new System.EventHandler(this.txtNomepro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Sigla";
            // 
            // FrmDisciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.dtGridSalas);
            this.Controls.Add(this.btnSalvarDisci);
            this.Controls.Add(this.chkAtivoDisci);
            this.Controls.Add(this.txtIdDisci);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeDisci);
            this.Name = "FrmDisciplinas";
            this.Text = "FrmDisciplinas";
            this.Load += new System.EventHandler(this.FrmDisciplinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.DataGridView dtGridSalas;
        private System.Windows.Forms.Button btnSalvarDisci;
        private System.Windows.Forms.CheckBox chkAtivoDisci;
        private System.Windows.Forms.TextBox txtIdDisci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeDisci;
        private System.Windows.Forms.Label label1;
    }
}