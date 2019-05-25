namespace AssociadoDePlantao
{
    partial class frmEditarFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarFunc));
            this.pnlEditarLoja = new System.Windows.Forms.Panel();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodContato = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cboStatusFunc = new System.Windows.Forms.ComboBox();
            this.cboTipoFunc = new System.Windows.Forms.ComboBox();
            this.txtCodigoFuncResp = new System.Windows.Forms.TextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFunc = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlEditarLoja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEditarLoja
            // 
            this.pnlEditarLoja.Controls.Add(this.txtBuscaNome);
            this.pnlEditarLoja.Controls.Add(this.label9);
            this.pnlEditarLoja.Controls.Add(this.txtCodContato);
            this.pnlEditarLoja.Controls.Add(this.label20);
            this.pnlEditarLoja.Controls.Add(this.cboStatusFunc);
            this.pnlEditarLoja.Controls.Add(this.cboTipoFunc);
            this.pnlEditarLoja.Controls.Add(this.txtCodigoFuncResp);
            this.pnlEditarLoja.Controls.Add(this.mskCPF);
            this.pnlEditarLoja.Controls.Add(this.txtSenha);
            this.pnlEditarLoja.Controls.Add(this.txtLogin);
            this.pnlEditarLoja.Controls.Add(this.label5);
            this.pnlEditarLoja.Controls.Add(this.mskDataNascimento);
            this.pnlEditarLoja.Controls.Add(this.txtNome);
            this.pnlEditarLoja.Controls.Add(this.label8);
            this.pnlEditarLoja.Controls.Add(this.label7);
            this.pnlEditarLoja.Controls.Add(this.label6);
            this.pnlEditarLoja.Controls.Add(this.label4);
            this.pnlEditarLoja.Controls.Add(this.label3);
            this.pnlEditarLoja.Controls.Add(this.label2);
            this.pnlEditarLoja.Controls.Add(this.label1);
            this.pnlEditarLoja.Controls.Add(this.dgvFunc);
            this.pnlEditarLoja.Controls.Add(this.btnSalvar);
            this.pnlEditarLoja.Location = new System.Drawing.Point(13, 12);
            this.pnlEditarLoja.Name = "pnlEditarLoja";
            this.pnlEditarLoja.Size = new System.Drawing.Size(800, 479);
            this.pnlEditarLoja.TabIndex = 19;
            this.pnlEditarLoja.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEditarLoja_Paint);
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaNome.Location = new System.Drawing.Point(371, 418);
            this.txtBuscaNome.MaxLength = 60;
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(269, 23);
            this.txtBuscaNome.TabIndex = 10;
            this.txtBuscaNome.TextChanged += new System.EventHandler(this.txtBuscaNome_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(367, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 23);
            this.label9.TabIndex = 52;
            this.label9.Text = "Buscar por nome:";
            // 
            // txtCodContato
            // 
            this.txtCodContato.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodContato.Location = new System.Drawing.Point(371, 266);
            this.txtCodContato.MaxLength = 60;
            this.txtCodContato.Name = "txtCodContato";
            this.txtCodContato.Size = new System.Drawing.Size(269, 23);
            this.txtCodContato.TabIndex = 7;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(367, 240);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(157, 23);
            this.label20.TabIndex = 50;
            this.label20.Text = "Codigo Contato: ";
            // 
            // cboStatusFunc
            // 
            this.cboStatusFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatusFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStatusFunc.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatusFunc.FormattingEnabled = true;
            this.cboStatusFunc.ItemHeight = 16;
            this.cboStatusFunc.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cboStatusFunc.Location = new System.Drawing.Point(10, 418);
            this.cboStatusFunc.Name = "cboStatusFunc";
            this.cboStatusFunc.Size = new System.Drawing.Size(269, 24);
            this.cboStatusFunc.TabIndex = 43;
            // 
            // cboTipoFunc
            // 
            this.cboTipoFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoFunc.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoFunc.FormattingEnabled = true;
            this.cboTipoFunc.Items.AddRange(new object[] {
            "Gerente",
            "Funcionário"});
            this.cboTipoFunc.Location = new System.Drawing.Point(10, 366);
            this.cboTipoFunc.Name = "cboTipoFunc";
            this.cboTipoFunc.Size = new System.Drawing.Size(269, 24);
            this.cboTipoFunc.TabIndex = 4;
            // 
            // txtCodigoFuncResp
            // 
            this.txtCodigoFuncResp.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoFuncResp.Location = new System.Drawing.Point(371, 214);
            this.txtCodigoFuncResp.MaxLength = 60;
            this.txtCodigoFuncResp.Name = "txtCodigoFuncResp";
            this.txtCodigoFuncResp.Size = new System.Drawing.Size(269, 23);
            this.txtCodigoFuncResp.TabIndex = 6;
            // 
            // mskCPF
            // 
            this.mskCPF.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCPF.Location = new System.Drawing.Point(10, 263);
            this.mskCPF.Mask = "000\\.000\\.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(269, 23);
            this.mskCPF.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(371, 367);
            this.txtSenha.MaxLength = 60;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(269, 23);
            this.txtSenha.TabIndex = 9;
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(371, 317);
            this.txtLogin.MaxLength = 60;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(269, 23);
            this.txtLogin.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(367, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 49;
            this.label5.Text = "Login:";
            // 
            // mskDataNascimento
            // 
            this.mskDataNascimento.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataNascimento.Location = new System.Drawing.Point(10, 317);
            this.mskDataNascimento.Mask = "00/00/0000";
            this.mskDataNascimento.Name = "mskDataNascimento";
            this.mskDataNascimento.Size = new System.Drawing.Size(269, 23);
            this.mskDataNascimento.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(10, 217);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(269, 23);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(367, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(306, 23);
            this.label8.TabIndex = 48;
            this.label8.Text = "Codigo Funcionário Responsável:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(6, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 47;
            this.label7.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(367, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 45;
            this.label6.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(6, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 23);
            this.label4.TabIndex = 42;
            this.label4.Text = "Tipo Funcionário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(6, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Data Nascimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(6, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nome:";
            // 
            // dgvFunc
            // 
            this.dgvFunc.AllowUserToAddRows = false;
            this.dgvFunc.AllowUserToDeleteRows = false;
            this.dgvFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunc.Location = new System.Drawing.Point(3, 19);
            this.dgvFunc.Name = "dgvFunc";
            this.dgvFunc.ReadOnly = true;
            this.dgvFunc.Size = new System.Drawing.Size(794, 166);
            this.dgvFunc.TabIndex = 20;
            this.dgvFunc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFunc_CellClick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Image = global::AssociadoDePlantao.Properties.Resources.icons8_ok_48;
            this.btnSalvar.Location = new System.Drawing.Point(745, 418);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(52, 50);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmEditarFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(825, 499);
            this.Controls.Add(this.pnlEditarLoja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditarFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarFunc";
            this.Load += new System.EventHandler(this.frmEditarFunc_Load);
            this.pnlEditarLoja.ResumeLayout(false);
            this.pnlEditarLoja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlEditarLoja;
        private System.Windows.Forms.DataGridView dgvFunc;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCodContato;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cboStatusFunc;
        private System.Windows.Forms.ComboBox cboTipoFunc;
        private System.Windows.Forms.TextBox txtCodigoFuncResp;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskDataNascimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.Label label9;
    }
}