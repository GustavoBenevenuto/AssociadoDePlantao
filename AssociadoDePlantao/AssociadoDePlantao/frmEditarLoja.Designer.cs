namespace AssociadoDePlantao
{
    partial class frmEditarLoja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarLoja));
            this.pnlEditarLoja = new System.Windows.Forms.Panel();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInauguracao = new System.Windows.Forms.MaskedTextBox();
            this.cboTipoLoja = new System.Windows.Forms.ComboBox();
            this.txtFuncResp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCpnj = new System.Windows.Forms.MaskedTextBox();
            this.txtCodContato = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLojas = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlEditarLoja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLojas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEditarLoja
            // 
            this.pnlEditarLoja.Controls.Add(this.txtBuscaNome);
            this.pnlEditarLoja.Controls.Add(this.label9);
            this.pnlEditarLoja.Controls.Add(this.txtInauguracao);
            this.pnlEditarLoja.Controls.Add(this.cboTipoLoja);
            this.pnlEditarLoja.Controls.Add(this.txtFuncResp);
            this.pnlEditarLoja.Controls.Add(this.label8);
            this.pnlEditarLoja.Controls.Add(this.txtCpnj);
            this.pnlEditarLoja.Controls.Add(this.txtCodContato);
            this.pnlEditarLoja.Controls.Add(this.label7);
            this.pnlEditarLoja.Controls.Add(this.label6);
            this.pnlEditarLoja.Controls.Add(this.label5);
            this.pnlEditarLoja.Controls.Add(this.txtSite);
            this.pnlEditarLoja.Controls.Add(this.label4);
            this.pnlEditarLoja.Controls.Add(this.label3);
            this.pnlEditarLoja.Controls.Add(this.txtNomeFantasia);
            this.pnlEditarLoja.Controls.Add(this.label2);
            this.pnlEditarLoja.Controls.Add(this.txtRazaoSocial);
            this.pnlEditarLoja.Controls.Add(this.label1);
            this.pnlEditarLoja.Controls.Add(this.dgvLojas);
            this.pnlEditarLoja.Controls.Add(this.btnSalvar);
            this.pnlEditarLoja.Location = new System.Drawing.Point(12, 24);
            this.pnlEditarLoja.Name = "pnlEditarLoja";
            this.pnlEditarLoja.Size = new System.Drawing.Size(800, 463);
            this.pnlEditarLoja.TabIndex = 18;
            this.pnlEditarLoja.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEditarLoja_Paint);
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaNome.Location = new System.Drawing.Point(333, 363);
            this.txtBuscaNome.MaxLength = 60;
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(269, 23);
            this.txtBuscaNome.TabIndex = 53;
            this.txtBuscaNome.TextChanged += new System.EventHandler(this.txtBuscaNome_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(329, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 23);
            this.label9.TabIndex = 54;
            this.label9.Text = "Buscar por nome:";
            this.label9.TextChanged += new System.EventHandler(this.txtBuscaNome_TextChanged);
            // 
            // txtInauguracao
            // 
            this.txtInauguracao.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInauguracao.Location = new System.Drawing.Point(17, 433);
            this.txtInauguracao.Mask = "00/00/0000";
            this.txtInauguracao.Name = "txtInauguracao";
            this.txtInauguracao.Size = new System.Drawing.Size(269, 23);
            this.txtInauguracao.TabIndex = 5;
            // 
            // cboTipoLoja
            // 
            this.cboTipoLoja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoLoja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoLoja.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoLoja.FormattingEnabled = true;
            this.cboTipoLoja.Items.AddRange(new object[] {
            "Matriz",
            "Filial"});
            this.cboTipoLoja.Location = new System.Drawing.Point(333, 207);
            this.cboTipoLoja.Name = "cboTipoLoja";
            this.cboTipoLoja.Size = new System.Drawing.Size(269, 24);
            this.cboTipoLoja.TabIndex = 6;
            // 
            // txtFuncResp
            // 
            this.txtFuncResp.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncResp.Location = new System.Drawing.Point(333, 312);
            this.txtFuncResp.MaxLength = 10;
            this.txtFuncResp.Name = "txtFuncResp";
            this.txtFuncResp.Size = new System.Drawing.Size(269, 23);
            this.txtFuncResp.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(329, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(306, 23);
            this.label8.TabIndex = 36;
            this.label8.Text = "Codigo Funcionário Responsável:";
            // 
            // txtCpnj
            // 
            this.txtCpnj.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpnj.Location = new System.Drawing.Point(17, 331);
            this.txtCpnj.Mask = "000-0";
            this.txtCpnj.Name = "txtCpnj";
            this.txtCpnj.Size = new System.Drawing.Size(269, 23);
            this.txtCpnj.TabIndex = 3;
            // 
            // txtCodContato
            // 
            this.txtCodContato.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodContato.Location = new System.Drawing.Point(333, 257);
            this.txtCodContato.Name = "txtCodContato";
            this.txtCodContato.Size = new System.Drawing.Size(269, 23);
            this.txtCodContato.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(329, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 23);
            this.label7.TabIndex = 35;
            this.label7.Text = "Codigo Contato:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(329, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tipo Loja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(13, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "Inauguração:";
            // 
            // txtSite
            // 
            this.txtSite.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSite.Location = new System.Drawing.Point(17, 381);
            this.txtSite.MaxLength = 40;
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(269, 23);
            this.txtSite.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(13, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Site:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(13, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "CPNJ:";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantasia.Location = new System.Drawing.Point(17, 277);
            this.txtNomeFantasia.MaxLength = 60;
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(269, 23);
            this.txtNomeFantasia.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(13, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nome Fantasia:";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocial.Location = new System.Drawing.Point(17, 206);
            this.txtRazaoSocial.MaxLength = 70;
            this.txtRazaoSocial.Multiline = true;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(269, 42);
            this.txtRazaoSocial.TabIndex = 1;
            this.txtRazaoSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Razao Social: ";
            // 
            // dgvLojas
            // 
            this.dgvLojas.AllowUserToAddRows = false;
            this.dgvLojas.AllowUserToDeleteRows = false;
            this.dgvLojas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLojas.Location = new System.Drawing.Point(3, 13);
            this.dgvLojas.Name = "dgvLojas";
            this.dgvLojas.ReadOnly = true;
            this.dgvLojas.Size = new System.Drawing.Size(794, 164);
            this.dgvLojas.TabIndex = 20;
            this.dgvLojas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLojas_CellClick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Image = global::AssociadoDePlantao.Properties.Resources.icons8_ok_48;
            this.btnSalvar.Location = new System.Drawing.Point(745, 410);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(52, 50);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmEditarLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(825, 499);
            this.Controls.Add(this.pnlEditarLoja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditarLoja";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarLoja";
            this.Load += new System.EventHandler(this.frmEditarLoja_Load);
            this.pnlEditarLoja.ResumeLayout(false);
            this.pnlEditarLoja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLojas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlEditarLoja;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvLojas;
        private System.Windows.Forms.MaskedTextBox txtInauguracao;
        private System.Windows.Forms.ComboBox cboTipoLoja;
        private System.Windows.Forms.TextBox txtFuncResp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtCpnj;
        private System.Windows.Forms.TextBox txtCodContato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.Label label9;
    }
}