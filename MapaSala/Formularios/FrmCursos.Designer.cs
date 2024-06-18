
namespace MapaSala.Formularios
{
    partial class FrmCursos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.dtGridCursos = new System.Windows.Forms.DataGridView();
            this.btnSalvarTurno = new System.Windows.Forms.Button();
            this.chkAtivoTurno = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeCurso = new System.Windows.Forms.TextBox();
            this.NumCurso = new System.Windows.Forms.NumericUpDown();
            this.BtnLimparCurso = new System.Windows.Forms.Button();
            this.btmeditarcurso = new System.Windows.Forms.Button();
            this.BtnExcluircursos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Turno";
            // 
            // txtTurno
            // 
            this.txtTurno.Location = new System.Drawing.Point(318, 40);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(100, 20);
            this.txtTurno.TabIndex = 47;
            // 
            // dtGridCursos
            // 
            this.dtGridCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCursos.Location = new System.Drawing.Point(64, 75);
            this.dtGridCursos.Name = "dtGridCursos";
            this.dtGridCursos.Size = new System.Drawing.Size(673, 352);
            this.dtGridCursos.TabIndex = 46;
            this.dtGridCursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridCursos_CellClick);
            this.dtGridCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridCursos_CellContentClick);
            // 
            // btnSalvarTurno
            // 
            this.btnSalvarTurno.Location = new System.Drawing.Point(593, 38);
            this.btnSalvarTurno.Name = "btnSalvarTurno";
            this.btnSalvarTurno.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarTurno.TabIndex = 45;
            this.btnSalvarTurno.Text = "Salvar";
            this.btnSalvarTurno.UseVisualStyleBackColor = true;
            this.btnSalvarTurno.Click += new System.EventHandler(this.btnSalvarTurno_Click);
            // 
            // chkAtivoTurno
            // 
            this.chkAtivoTurno.AutoSize = true;
            this.chkAtivoTurno.Location = new System.Drawing.Point(491, 40);
            this.chkAtivoTurno.Name = "chkAtivoTurno";
            this.chkAtivoTurno.Size = new System.Drawing.Size(50, 17);
            this.chkAtivoTurno.TabIndex = 44;
            this.chkAtivoTurno.Text = "Ativo";
            this.chkAtivoTurno.UseVisualStyleBackColor = true;
            this.chkAtivoTurno.CheckedChanged += new System.EventHandler(this.chkAtivoTurno_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nome do Curso";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNomeCurso
            // 
            this.txtNomeCurso.Location = new System.Drawing.Point(159, 40);
            this.txtNomeCurso.Name = "txtNomeCurso";
            this.txtNomeCurso.Size = new System.Drawing.Size(100, 20);
            this.txtNomeCurso.TabIndex = 40;
            // 
            // NumCurso
            // 
            this.NumCurso.Location = new System.Drawing.Point(64, 41);
            this.NumCurso.Name = "NumCurso";
            this.NumCurso.Size = new System.Drawing.Size(71, 20);
            this.NumCurso.TabIndex = 49;
            this.NumCurso.ValueChanged += new System.EventHandler(this.NumCurso_ValueChanged);
            // 
            // BtnLimparCurso
            // 
            this.BtnLimparCurso.Location = new System.Drawing.Point(674, 38);
            this.BtnLimparCurso.Name = "BtnLimparCurso";
            this.BtnLimparCurso.Size = new System.Drawing.Size(75, 23);
            this.BtnLimparCurso.TabIndex = 50;
            this.BtnLimparCurso.Text = "Limpar";
            this.BtnLimparCurso.UseVisualStyleBackColor = true;
            this.BtnLimparCurso.Click += new System.EventHandler(this.BtnLimparCurso_Click);
            // 
            // btmeditarcurso
            // 
            this.btmeditarcurso.Location = new System.Drawing.Point(674, 9);
            this.btmeditarcurso.Name = "btmeditarcurso";
            this.btmeditarcurso.Size = new System.Drawing.Size(75, 23);
            this.btmeditarcurso.TabIndex = 54;
            this.btmeditarcurso.Text = "Editar";
            this.btmeditarcurso.UseVisualStyleBackColor = true;
            this.btmeditarcurso.Click += new System.EventHandler(this.btmeditarcurso_Click);
            // 
            // BtnExcluircursos
            // 
            this.BtnExcluircursos.Location = new System.Drawing.Point(593, 9);
            this.BtnExcluircursos.Name = "BtnExcluircursos";
            this.BtnExcluircursos.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluircursos.TabIndex = 55;
            this.BtnExcluircursos.Text = "Excluir";
            this.BtnExcluircursos.UseVisualStyleBackColor = true;
            this.BtnExcluircursos.Click += new System.EventHandler(this.BtnExcluircursos_Click);
            // 
            // FrmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnExcluircursos);
            this.Controls.Add(this.btmeditarcurso);
            this.Controls.Add(this.BtnLimparCurso);
            this.Controls.Add(this.NumCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTurno);
            this.Controls.Add(this.dtGridCursos);
            this.Controls.Add(this.btnSalvarTurno);
            this.Controls.Add(this.chkAtivoTurno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeCurso);
            this.Name = "FrmCursos";
            this.Text = "FrmCursos";
            this.Load += new System.EventHandler(this.FrmCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.DataGridView dtGridCursos;
        private System.Windows.Forms.Button btnSalvarTurno;
        private System.Windows.Forms.CheckBox chkAtivoTurno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeCurso;
        private System.Windows.Forms.NumericUpDown NumCurso;
        private System.Windows.Forms.Button BtnLimparCurso;
        private System.Windows.Forms.Button btmeditarcurso;
        private System.Windows.Forms.Button BtnExcluircursos;
    }
}