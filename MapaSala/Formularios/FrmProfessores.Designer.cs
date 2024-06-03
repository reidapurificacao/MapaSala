
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
            this.dtGridSalas = new System.Windows.Forms.DataGridView();
            this.btnSalvarpro = new System.Windows.Forms.Button();
            this.chkDisponivelpro = new System.Windows.Forms.CheckBox();
            this.txtIdpro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomepro = new System.Windows.Forms.TextBox();
            this.txtApelidopro = new System.Windows.Forms.TextBox();
            this.txtDisciplina = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridSalas
            // 
            this.dtGridSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridSalas.Location = new System.Drawing.Point(65, 81);
            this.dtGridSalas.Name = "dtGridSalas";
            this.dtGridSalas.Size = new System.Drawing.Size(673, 352);
            this.dtGridSalas.TabIndex = 25;
            this.dtGridSalas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridSalas_CellContentClick);
            // 
            // btnSalvarpro
            // 
            this.btnSalvarpro.Location = new System.Drawing.Point(627, 34);
            this.btnSalvarpro.Name = "btnSalvarpro";
            this.btnSalvarpro.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarpro.TabIndex = 22;
            this.btnSalvarpro.Text = "Salvar";
            this.btnSalvarpro.UseVisualStyleBackColor = true;
            this.btnSalvarpro.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // chkDisponivelpro
            // 
            this.chkDisponivelpro.AutoSize = true;
            this.chkDisponivelpro.Location = new System.Drawing.Point(501, 40);
            this.chkDisponivelpro.Name = "chkDisponivelpro";
            this.chkDisponivelpro.Size = new System.Drawing.Size(75, 17);
            this.chkDisponivelpro.TabIndex = 21;
            this.chkDisponivelpro.Text = "Disponivel";
            this.chkDisponivelpro.UseVisualStyleBackColor = true;
            this.chkDisponivelpro.CheckedChanged += new System.EventHandler(this.chkDisponivel_CheckedChanged);
            // 
            // txtIdpro
            // 
            this.txtIdpro.Location = new System.Drawing.Point(65, 37);
            this.txtIdpro.Name = "txtIdpro";
            this.txtIdpro.Size = new System.Drawing.Size(44, 20);
            this.txtIdpro.TabIndex = 19;
            this.txtIdpro.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Id";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Disciplina";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Apelido professor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome do professor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNomepro
            // 
            this.txtNomepro.Location = new System.Drawing.Point(115, 37);
            this.txtNomepro.Name = "txtNomepro";
            this.txtNomepro.Size = new System.Drawing.Size(100, 20);
            this.txtNomepro.TabIndex = 14;
            this.txtNomepro.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtApelidopro
            // 
            this.txtApelidopro.Location = new System.Drawing.Point(239, 37);
            this.txtApelidopro.Name = "txtApelidopro";
            this.txtApelidopro.Size = new System.Drawing.Size(100, 20);
            this.txtApelidopro.TabIndex = 26;
            this.txtApelidopro.TextChanged += new System.EventHandler(this.txtApelidopro_TextChanged);
            // 
            // txtDisciplina
            // 
            this.txtDisciplina.Location = new System.Drawing.Point(357, 37);
            this.txtDisciplina.Name = "txtDisciplina";
            this.txtDisciplina.Size = new System.Drawing.Size(100, 20);
            this.txtDisciplina.TabIndex = 27;
            this.txtDisciplina.TextChanged += new System.EventHandler(this.txtDisciplina_TextChanged);
            // 
            // FrmProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDisciplina);
            this.Controls.Add(this.txtApelidopro);
            this.Controls.Add(this.dtGridSalas);
            this.Controls.Add(this.btnSalvarpro);
            this.Controls.Add(this.chkDisponivelpro);
            this.Controls.Add(this.txtIdpro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomepro);
            this.Name = "FrmProfessores";
            this.Text = "FrmProfessores";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridSalas;
        private System.Windows.Forms.Button btnSalvarpro;
        private System.Windows.Forms.CheckBox chkDisponivelpro;
        private System.Windows.Forms.TextBox txtIdpro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomepro;
        private System.Windows.Forms.TextBox txtApelidopro;
        private System.Windows.Forms.TextBox txtDisciplina;
    }
}