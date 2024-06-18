
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSenhaUser = new System.Windows.Forms.TextBox();
            this.txtGmailUser = new System.Windows.Forms.TextBox();
            this.dtGridUser = new System.Windows.Forms.DataGridView();
            this.btnSalvarpro = new System.Windows.Forms.Button();
            this.chkAtivoUser = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeUser = new System.Windows.Forms.TextBox();
            this.NumUser = new System.Windows.Forms.NumericUpDown();
            this.BtnLimparUser = new System.Windows.Forms.Button();
            this.BtnExcluircursos = new System.Windows.Forms.Button();
            this.btmeditarcurso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSenhaUser
            // 
            this.txtSenhaUser.Location = new System.Drawing.Point(440, 35);
            this.txtSenhaUser.Name = "txtSenhaUser";
            this.txtSenhaUser.PasswordChar = '*';
            this.txtSenhaUser.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaUser.TabIndex = 38;
            // 
            // txtGmailUser
            // 
            this.txtGmailUser.Location = new System.Drawing.Point(322, 35);
            this.txtGmailUser.Name = "txtGmailUser";
            this.txtGmailUser.Size = new System.Drawing.Size(100, 20);
            this.txtGmailUser.TabIndex = 37;
            this.txtGmailUser.TextChanged += new System.EventHandler(this.txtGmailUser_TextChanged);
            // 
            // dtGridUser
            // 
            this.dtGridUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridUser.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtGridUser.Location = new System.Drawing.Point(65, 81);
            this.dtGridUser.Name = "dtGridUser";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtGridUser.Size = new System.Drawing.Size(673, 352);
            this.dtGridUser.TabIndex = 36;
            this.dtGridUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridUser_CellClick);
            // 
            // btnSalvarpro
            // 
            this.btnSalvarpro.Location = new System.Drawing.Point(625, 36);
            this.btnSalvarpro.Name = "btnSalvarpro";
            this.btnSalvarpro.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarpro.TabIndex = 35;
            this.btnSalvarpro.Text = "Salvar";
            this.btnSalvarpro.UseVisualStyleBackColor = true;
            this.btnSalvarpro.Click += new System.EventHandler(this.btnSalvarpro_Click);
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
            this.label2.Text = "Login";
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
            // NumUser
            // 
            this.NumUser.Location = new System.Drawing.Point(108, 39);
            this.NumUser.Name = "NumUser";
            this.NumUser.Size = new System.Drawing.Size(72, 20);
            this.NumUser.TabIndex = 39;
            this.NumUser.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // BtnLimparUser
            // 
            this.BtnLimparUser.Location = new System.Drawing.Point(709, 35);
            this.BtnLimparUser.Name = "BtnLimparUser";
            this.BtnLimparUser.Size = new System.Drawing.Size(79, 26);
            this.BtnLimparUser.TabIndex = 40;
            this.BtnLimparUser.Text = "Limpar";
            this.BtnLimparUser.UseVisualStyleBackColor = true;
            this.BtnLimparUser.Click += new System.EventHandler(this.BtnLimparUser_Click);
            // 
            // BtnExcluircursos
            // 
            this.BtnExcluircursos.Location = new System.Drawing.Point(632, 6);
            this.BtnExcluircursos.Name = "BtnExcluircursos";
            this.BtnExcluircursos.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluircursos.TabIndex = 59;
            this.BtnExcluircursos.Text = "Excluir";
            this.BtnExcluircursos.UseVisualStyleBackColor = true;
            this.BtnExcluircursos.Click += new System.EventHandler(this.BtnExcluircursos_Click);
            // 
            // btmeditarcurso
            // 
            this.btmeditarcurso.Location = new System.Drawing.Point(713, 6);
            this.btmeditarcurso.Name = "btmeditarcurso";
            this.btmeditarcurso.Size = new System.Drawing.Size(75, 23);
            this.btmeditarcurso.TabIndex = 58;
            this.btmeditarcurso.Text = "Editar";
            this.btmeditarcurso.UseVisualStyleBackColor = true;
            this.btmeditarcurso.Click += new System.EventHandler(this.btmeditarcurso_Click);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnExcluircursos);
            this.Controls.Add(this.btmeditarcurso);
            this.Controls.Add(this.BtnLimparUser);
            this.Controls.Add(this.NumUser);
            this.Controls.Add(this.txtSenhaUser);
            this.Controls.Add(this.txtGmailUser);
            this.Controls.Add(this.dtGridUser);
            this.Controls.Add(this.btnSalvarpro);
            this.Controls.Add(this.chkAtivoUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeUser);
            this.Name = "FrmUsuarios";
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenhaUser;
        private System.Windows.Forms.TextBox txtGmailUser;
        private System.Windows.Forms.DataGridView dtGridUser;
        private System.Windows.Forms.Button btnSalvarpro;
        private System.Windows.Forms.CheckBox chkAtivoUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeUser;
        private System.Windows.Forms.NumericUpDown NumUser;
        private System.Windows.Forms.Button BtnLimparUser;
        private System.Windows.Forms.Button BtnExcluircursos;
        private System.Windows.Forms.Button btmeditarcurso;
    }
}