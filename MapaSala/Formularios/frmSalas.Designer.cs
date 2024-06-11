
namespace MapaSala.Formularios
{
    partial class frmSalas
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkIsLab = new System.Windows.Forms.CheckBox();
            this.chkDisponivel = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNumPc = new System.Windows.Forms.NumericUpDown();
            this.txtNumCadeira = new System.Windows.Forms.NumericUpDown();
            this.dtGridSalas = new System.Windows.Forms.DataGridView();
            this.BtnLimparSalas = new System.Windows.Forms.Button();
            this.NumSalas = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumPc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumCadeira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSalas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome da sala";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número de computadores";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número de Cadeiras";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Id";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // chkIsLab
            // 
            this.chkIsLab.AutoSize = true;
            this.chkIsLab.Location = new System.Drawing.Point(436, 33);
            this.chkIsLab.Name = "chkIsLab";
            this.chkIsLab.Size = new System.Drawing.Size(85, 17);
            this.chkIsLab.TabIndex = 8;
            this.chkIsLab.Text = "É laboratório";
            this.chkIsLab.UseVisualStyleBackColor = true;
            this.chkIsLab.CheckedChanged += new System.EventHandler(this.chkIsLab_CheckedChanged);
            // 
            // chkDisponivel
            // 
            this.chkDisponivel.AutoSize = true;
            this.chkDisponivel.Location = new System.Drawing.Point(527, 33);
            this.chkDisponivel.Name = "chkDisponivel";
            this.chkDisponivel.Size = new System.Drawing.Size(77, 17);
            this.chkDisponivel.TabIndex = 9;
            this.chkDisponivel.Text = "Disponível";
            this.chkDisponivel.UseVisualStyleBackColor = true;
            this.chkDisponivel.CheckedChanged += new System.EventHandler(this.chkDisponivel_CheckedChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(610, 16);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNumPc
            // 
            this.txtNumPc.Location = new System.Drawing.Point(168, 32);
            this.txtNumPc.Name = "txtNumPc";
            this.txtNumPc.Size = new System.Drawing.Size(120, 20);
            this.txtNumPc.TabIndex = 11;
            this.txtNumPc.ValueChanged += new System.EventHandler(this.txtNumPc_ValueChanged);
            // 
            // txtNumCadeira
            // 
            this.txtNumCadeira.Location = new System.Drawing.Point(318, 32);
            this.txtNumCadeira.Name = "txtNumCadeira";
            this.txtNumCadeira.Size = new System.Drawing.Size(112, 20);
            this.txtNumCadeira.TabIndex = 12;
            this.txtNumCadeira.ValueChanged += new System.EventHandler(this.txtNumCadeira_ValueChanged);
            // 
            // dtGridSalas
            // 
            this.dtGridSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridSalas.Location = new System.Drawing.Point(12, 77);
            this.dtGridSalas.Name = "dtGridSalas";
            this.dtGridSalas.Size = new System.Drawing.Size(673, 352);
            this.dtGridSalas.TabIndex = 13;
            this.dtGridSalas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridSalas_CellContentClick);
            // 
            // BtnLimparSalas
            // 
            this.BtnLimparSalas.Location = new System.Drawing.Point(610, 45);
            this.BtnLimparSalas.Name = "BtnLimparSalas";
            this.BtnLimparSalas.Size = new System.Drawing.Size(79, 26);
            this.BtnLimparSalas.TabIndex = 31;
            this.BtnLimparSalas.Text = "Limpar";
            this.BtnLimparSalas.UseVisualStyleBackColor = true;
            this.BtnLimparSalas.Click += new System.EventHandler(this.BtnLimparSalas_Click);
            // 
            // NumSalas
            // 
            this.NumSalas.Location = new System.Drawing.Point(0, 34);
            this.NumSalas.Name = "NumSalas";
            this.NumSalas.Size = new System.Drawing.Size(56, 20);
            this.NumSalas.TabIndex = 32;
            this.NumSalas.ValueChanged += new System.EventHandler(this.NumSalas_ValueChanged);
            // 
            // frmSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.NumSalas);
            this.Controls.Add(this.BtnLimparSalas);
            this.Controls.Add(this.dtGridSalas);
            this.Controls.Add(this.txtNumCadeira);
            this.Controls.Add(this.txtNumPc);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.chkDisponivel);
            this.Controls.Add(this.chkIsLab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "frmSalas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSalas";
            this.Load += new System.EventHandler(this.frmSalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumPc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumCadeira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSalas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkIsLab;
        private System.Windows.Forms.CheckBox chkDisponivel;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.NumericUpDown txtNumPc;
        private System.Windows.Forms.NumericUpDown txtNumCadeira;
        private System.Windows.Forms.DataGridView dtGridSalas;
        private System.Windows.Forms.Button BtnLimparSalas;
        private System.Windows.Forms.NumericUpDown NumSalas;
    }
}