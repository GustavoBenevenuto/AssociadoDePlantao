namespace AssociadoDePlantao
{
    partial class frmCadastrarFuncAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarFuncAdm));
            this.pnlContato = new System.Windows.Forms.Panel();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtConplemento = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pnlCadastrarFunc = new System.Windows.Forms.Panel();
            this.txtCodContato = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cboStatusFunc = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.cboTipoFunc = new System.Windows.Forms.ComboBox();
            this.txtCodigoFuncResp = new System.Windows.Forms.TextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltarAoContato = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContato.SuspendLayout();
            this.pnlCadastrarFunc.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContato
            // 
            this.pnlContato.Controls.Add(this.mskCEP);
            this.pnlContato.Controls.Add(this.label19);
            this.pnlContato.Controls.Add(this.btnProximo);
            this.pnlContato.Controls.Add(this.txtEmail);
            this.pnlContato.Controls.Add(this.label17);
            this.pnlContato.Controls.Add(this.txtConplemento);
            this.pnlContato.Controls.Add(this.txtCel);
            this.pnlContato.Controls.Add(this.label16);
            this.pnlContato.Controls.Add(this.txtTel);
            this.pnlContato.Controls.Add(this.label15);
            this.pnlContato.Controls.Add(this.txtEndereco);
            this.pnlContato.Controls.Add(this.txtPais);
            this.pnlContato.Controls.Add(this.label9);
            this.pnlContato.Controls.Add(this.txtEstado);
            this.pnlContato.Controls.Add(this.label10);
            this.pnlContato.Controls.Add(this.txtCidade);
            this.pnlContato.Controls.Add(this.label11);
            this.pnlContato.Controls.Add(this.txtBairro);
            this.pnlContato.Controls.Add(this.label12);
            this.pnlContato.Controls.Add(this.label13);
            this.pnlContato.Controls.Add(this.txtNumero);
            this.pnlContato.Controls.Add(this.label14);
            this.pnlContato.Controls.Add(this.label18);
            this.pnlContato.Location = new System.Drawing.Point(30, 24);
            this.pnlContato.Name = "pnlContato";
            this.pnlContato.Size = new System.Drawing.Size(783, 463);
            this.pnlContato.TabIndex = 17;
            // 
            // mskCEP
            // 
            this.mskCEP.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCEP.Location = new System.Drawing.Point(18, 37);
            this.mskCEP.Mask = "00-000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(269, 23);
            this.mskCEP.TabIndex = 1;
            this.mskCEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCEP_MaskInputRejected);
            this.mskCEP.Leave += new System.EventHandler(this.mskCEP_Leave);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(14, 11);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 23);
            this.label19.TabIndex = 23;
            this.label19.Text = "CEP: ";
            // 
            // btnProximo
            // 
            this.btnProximo.FlatAppearance.BorderSize = 0;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProximo.Image = global::AssociadoDePlantao.Properties.Resources.Proximo;
            this.btnProximo.Location = new System.Drawing.Point(707, 408);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(59, 52);
            this.btnProximo.TabIndex = 12;
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(393, 248);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(269, 23);
            this.txtEmail.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(389, 222);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 23);
            this.label17.TabIndex = 21;
            this.label17.Text = "Email:";
            // 
            // txtConplemento
            // 
            this.txtConplemento.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConplemento.Location = new System.Drawing.Point(18, 137);
            this.txtConplemento.MaxLength = 50;
            this.txtConplemento.Name = "txtConplemento";
            this.txtConplemento.Size = new System.Drawing.Size(269, 23);
            this.txtConplemento.TabIndex = 3;
            // 
            // txtCel
            // 
            this.txtCel.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCel.Location = new System.Drawing.Point(393, 196);
            this.txtCel.Mask = "000 0-00000000";
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(269, 23);
            this.txtCel.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(389, 168);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 23);
            this.label16.TabIndex = 18;
            this.label16.Text = "Celular:";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(393, 142);
            this.txtTel.Mask = "000-00000000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(269, 23);
            this.txtTel.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(389, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 23);
            this.label15.TabIndex = 16;
            this.label15.Text = "Telefone Fixo:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(18, 189);
            this.txtEndereco.MaxLength = 80;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(269, 23);
            this.txtEndereco.TabIndex = 4;
            // 
            // txtPais
            // 
            this.txtPais.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais.Location = new System.Drawing.Point(393, 88);
            this.txtPais.MaxLength = 20;
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(269, 23);
            this.txtPais.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(389, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Pais";
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(393, 37);
            this.txtEstado.MaxLength = 2;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(269, 23);
            this.txtEstado.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(389, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "Estado";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(18, 291);
            this.txtCidade.MaxLength = 30;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(269, 23);
            this.txtCidade.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(14, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 23);
            this.label11.TabIndex = 8;
            this.label11.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(18, 239);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(269, 23);
            this.txtBairro.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(14, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 23);
            this.label12.TabIndex = 6;
            this.label12.Text = "Bairro:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(14, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 23);
            this.label13.TabIndex = 4;
            this.label13.Text = "Complemento:";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(18, 89);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(269, 23);
            this.txtNumero.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(14, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 23);
            this.label14.TabIndex = 2;
            this.label14.Text = "Numero:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(14, 163);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 23);
            this.label18.TabIndex = 0;
            this.label18.Text = "Endereço:";
            // 
            // pnlCadastrarFunc
            // 
            this.pnlCadastrarFunc.Controls.Add(this.txtCodContato);
            this.pnlCadastrarFunc.Controls.Add(this.label20);
            this.pnlCadastrarFunc.Controls.Add(this.cboStatusFunc);
            this.pnlCadastrarFunc.Controls.Add(this.statusStrip1);
            this.pnlCadastrarFunc.Controls.Add(this.cboTipoFunc);
            this.pnlCadastrarFunc.Controls.Add(this.txtCodigoFuncResp);
            this.pnlCadastrarFunc.Controls.Add(this.mskCPF);
            this.pnlCadastrarFunc.Controls.Add(this.txtSenha);
            this.pnlCadastrarFunc.Controls.Add(this.txtLogin);
            this.pnlCadastrarFunc.Controls.Add(this.label5);
            this.pnlCadastrarFunc.Controls.Add(this.mskDataNascimento);
            this.pnlCadastrarFunc.Controls.Add(this.txtNome);
            this.pnlCadastrarFunc.Controls.Add(this.btnSalvar);
            this.pnlCadastrarFunc.Controls.Add(this.btnVoltarAoContato);
            this.pnlCadastrarFunc.Controls.Add(this.label8);
            this.pnlCadastrarFunc.Controls.Add(this.label7);
            this.pnlCadastrarFunc.Controls.Add(this.label6);
            this.pnlCadastrarFunc.Controls.Add(this.label4);
            this.pnlCadastrarFunc.Controls.Add(this.label3);
            this.pnlCadastrarFunc.Controls.Add(this.label2);
            this.pnlCadastrarFunc.Controls.Add(this.label1);
            this.pnlCadastrarFunc.Location = new System.Drawing.Point(30, 24);
            this.pnlCadastrarFunc.Name = "pnlCadastrarFunc";
            this.pnlCadastrarFunc.Size = new System.Drawing.Size(783, 463);
            this.pnlCadastrarFunc.TabIndex = 24;
            // 
            // txtCodContato
            // 
            this.txtCodContato.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodContato.Location = new System.Drawing.Point(389, 161);
            this.txtCodContato.MaxLength = 60;
            this.txtCodContato.Name = "txtCodContato";
            this.txtCodContato.Size = new System.Drawing.Size(269, 23);
            this.txtCodContato.TabIndex = 10;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(385, 135);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(157, 23);
            this.label20.TabIndex = 32;
            this.label20.Text = "Codigo Contato: ";
            // 
            // cboStatusFunc
            // 
            this.cboStatusFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatusFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStatusFunc.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatusFunc.FormattingEnabled = true;
            this.cboStatusFunc.Items.AddRange(new object[] {
            "1"});
            this.cboStatusFunc.Location = new System.Drawing.Point(389, 59);
            this.cboStatusFunc.Name = "cboStatusFunc";
            this.cboStatusFunc.Size = new System.Drawing.Size(269, 24);
            this.cboStatusFunc.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLogin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 441);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(783, 22);
            this.statusStrip1.TabIndex = 30;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLogin
            // 
            this.statusLogin.Name = "statusLogin";
            this.statusLogin.Size = new System.Drawing.Size(0, 17);
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
            this.cboTipoFunc.Location = new System.Drawing.Point(18, 209);
            this.cboTipoFunc.Name = "cboTipoFunc";
            this.cboTipoFunc.Size = new System.Drawing.Size(269, 24);
            this.cboTipoFunc.TabIndex = 4;
            // 
            // txtCodigoFuncResp
            // 
            this.txtCodigoFuncResp.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoFuncResp.Location = new System.Drawing.Point(389, 109);
            this.txtCodigoFuncResp.MaxLength = 60;
            this.txtCodigoFuncResp.Name = "txtCodigoFuncResp";
            this.txtCodigoFuncResp.Size = new System.Drawing.Size(269, 23);
            this.txtCodigoFuncResp.TabIndex = 8;
            this.txtCodigoFuncResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoFuncResp_KeyPress);
            // 
            // mskCPF
            // 
            this.mskCPF.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCPF.Location = new System.Drawing.Point(18, 106);
            this.mskCPF.Mask = "000\\.000\\.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(269, 23);
            this.mskCPF.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(18, 311);
            this.txtSenha.MaxLength = 60;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(269, 23);
            this.txtSenha.TabIndex = 6;
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(18, 265);
            this.txtLogin.MaxLength = 60;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(269, 23);
            this.txtLogin.TabIndex = 5;
            this.txtLogin.Leave += new System.EventHandler(this.txtLogin_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(14, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Login:";
            // 
            // mskDataNascimento
            // 
            this.mskDataNascimento.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataNascimento.Location = new System.Drawing.Point(18, 160);
            this.mskDataNascimento.Mask = "00/00/0000";
            this.mskDataNascimento.Name = "mskDataNascimento";
            this.mskDataNascimento.Size = new System.Drawing.Size(269, 23);
            this.mskDataNascimento.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(18, 60);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(269, 23);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Image = global::AssociadoDePlantao.Properties.Resources.icons8_ok_48;
            this.btnSalvar.Location = new System.Drawing.Point(728, 388);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(52, 50);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltarAoContato
            // 
            this.btnVoltarAoContato.FlatAppearance.BorderSize = 0;
            this.btnVoltarAoContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarAoContato.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarAoContato.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVoltarAoContato.Image = global::AssociadoDePlantao.Properties.Resources.Voltar;
            this.btnVoltarAoContato.Location = new System.Drawing.Point(3, 388);
            this.btnVoltarAoContato.Name = "btnVoltarAoContato";
            this.btnVoltarAoContato.Size = new System.Drawing.Size(59, 52);
            this.btnVoltarAoContato.TabIndex = 12;
            this.btnVoltarAoContato.UseVisualStyleBackColor = true;
            this.btnVoltarAoContato.Click += new System.EventHandler(this.btnVoltarAoContato_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(385, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(306, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Codigo Funcionário Responsável:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(385, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(14, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(14, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo Funcionário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(14, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Nascimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(14, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // frmCadastrarFuncAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(825, 499);
            this.Controls.Add(this.pnlCadastrarFunc);
            this.Controls.Add(this.pnlContato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastrarFuncAdm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCadastrarFuncAdm";
            this.Load += new System.EventHandler(this.frmCadastrarFuncAdm_Load);
            this.pnlContato.ResumeLayout(false);
            this.pnlContato.PerformLayout();
            this.pnlCadastrarFunc.ResumeLayout(false);
            this.pnlCadastrarFunc.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlContato;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtConplemento;
        private System.Windows.Forms.MaskedTextBox txtCel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel pnlCadastrarFunc;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltarAoContato;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskDataNascimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.TextBox txtCodigoFuncResp;
        private System.Windows.Forms.ComboBox cboTipoFunc;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLogin;
        private System.Windows.Forms.ComboBox cboStatusFunc;
        private System.Windows.Forms.TextBox txtCodContato;
        private System.Windows.Forms.Label label20;
    }
}