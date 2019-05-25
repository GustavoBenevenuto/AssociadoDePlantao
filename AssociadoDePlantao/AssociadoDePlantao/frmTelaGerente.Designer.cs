namespace AssociadoDePlantao
{
    partial class frmTelaGerente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaGerente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMarca = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnExcluirSala = new System.Windows.Forms.Button();
            this.btnEditarSala = new System.Windows.Forms.Button();
            this.btnCadastrarSala = new System.Windows.Forms.Button();
            this.btnMenuSala = new System.Windows.Forms.Button();
            this.btnExcluirFunc = new System.Windows.Forms.Button();
            this.btnEditarFunc = new System.Windows.Forms.Button();
            this.btnCadastrarFunc = new System.Windows.Forms.Button();
            this.btnMenuFuncionario = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblQuemLogou = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvFunc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 33);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(107)))));
            this.panel3.Controls.Add(this.lblMarca);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 33);
            this.panel3.TabIndex = 2;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(43, 10);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(119, 15);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Associados de Plantão";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AssociadoDePlantao.Properties.Resources.associado;
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.Black;
            this.btnFechar.Location = new System.Drawing.Point(975, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(22, 23);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.btnEntrar);
            this.panel2.Controls.Add(this.btnExcluirSala);
            this.panel2.Controls.Add(this.btnEditarSala);
            this.panel2.Controls.Add(this.btnCadastrarSala);
            this.panel2.Controls.Add(this.btnMenuSala);
            this.panel2.Controls.Add(this.btnExcluirFunc);
            this.panel2.Controls.Add(this.btnEditarFunc);
            this.panel2.Controls.Add(this.btnCadastrarFunc);
            this.panel2.Controls.Add(this.btnMenuFuncionario);
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 508);
            this.panel2.TabIndex = 3;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEntrar.Location = new System.Drawing.Point(0, 238);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(160, 29);
            this.btnEntrar.TabIndex = 40;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnExcluirSala
            // 
            this.btnExcluirSala.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExcluirSala.FlatAppearance.BorderSize = 0;
            this.btnExcluirSala.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnExcluirSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirSala.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirSala.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluirSala.Location = new System.Drawing.Point(0, 209);
            this.btnExcluirSala.Name = "btnExcluirSala";
            this.btnExcluirSala.Size = new System.Drawing.Size(160, 29);
            this.btnExcluirSala.TabIndex = 39;
            this.btnExcluirSala.Text = "Excluir";
            this.btnExcluirSala.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirSala.UseVisualStyleBackColor = true;
            this.btnExcluirSala.Click += new System.EventHandler(this.btnExcluirSala_Click);
            // 
            // btnEditarSala
            // 
            this.btnEditarSala.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditarSala.FlatAppearance.BorderSize = 0;
            this.btnEditarSala.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnEditarSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarSala.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarSala.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarSala.Location = new System.Drawing.Point(0, 180);
            this.btnEditarSala.Name = "btnEditarSala";
            this.btnEditarSala.Size = new System.Drawing.Size(160, 29);
            this.btnEditarSala.TabIndex = 38;
            this.btnEditarSala.Text = "Editar";
            this.btnEditarSala.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarSala.UseVisualStyleBackColor = true;
            this.btnEditarSala.Click += new System.EventHandler(this.btnEditarSala_Click);
            // 
            // btnCadastrarSala
            // 
            this.btnCadastrarSala.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastrarSala.FlatAppearance.BorderSize = 0;
            this.btnCadastrarSala.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnCadastrarSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarSala.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarSala.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrarSala.Location = new System.Drawing.Point(0, 151);
            this.btnCadastrarSala.Name = "btnCadastrarSala";
            this.btnCadastrarSala.Size = new System.Drawing.Size(160, 29);
            this.btnCadastrarSala.TabIndex = 37;
            this.btnCadastrarSala.Text = "Cadastrar";
            this.btnCadastrarSala.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarSala.UseVisualStyleBackColor = true;
            this.btnCadastrarSala.Click += new System.EventHandler(this.btnCadastrarSala_Click);
            // 
            // btnMenuSala
            // 
            this.btnMenuSala.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuSala.FlatAppearance.BorderSize = 0;
            this.btnMenuSala.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnMenuSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSala.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSala.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenuSala.Image = global::AssociadoDePlantao.Properties.Resources.canto_botão;
            this.btnMenuSala.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSala.Location = new System.Drawing.Point(0, 122);
            this.btnMenuSala.Name = "btnMenuSala";
            this.btnMenuSala.Size = new System.Drawing.Size(160, 29);
            this.btnMenuSala.TabIndex = 36;
            this.btnMenuSala.Text = " Sala";
            this.btnMenuSala.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSala.UseVisualStyleBackColor = true;
            this.btnMenuSala.Click += new System.EventHandler(this.btnMenuSala_Click_1);
            // 
            // btnExcluirFunc
            // 
            this.btnExcluirFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExcluirFunc.FlatAppearance.BorderSize = 0;
            this.btnExcluirFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnExcluirFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirFunc.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirFunc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluirFunc.Location = new System.Drawing.Point(0, 93);
            this.btnExcluirFunc.Name = "btnExcluirFunc";
            this.btnExcluirFunc.Size = new System.Drawing.Size(160, 29);
            this.btnExcluirFunc.TabIndex = 35;
            this.btnExcluirFunc.Text = "Excluir";
            this.btnExcluirFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirFunc.UseVisualStyleBackColor = true;
            this.btnExcluirFunc.Click += new System.EventHandler(this.btnExcluirFunc_Click);
            // 
            // btnEditarFunc
            // 
            this.btnEditarFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditarFunc.FlatAppearance.BorderSize = 0;
            this.btnEditarFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnEditarFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarFunc.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarFunc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarFunc.Location = new System.Drawing.Point(0, 64);
            this.btnEditarFunc.Name = "btnEditarFunc";
            this.btnEditarFunc.Size = new System.Drawing.Size(160, 29);
            this.btnEditarFunc.TabIndex = 34;
            this.btnEditarFunc.Text = "Editar";
            this.btnEditarFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarFunc.UseVisualStyleBackColor = true;
            this.btnEditarFunc.Click += new System.EventHandler(this.btnEditarFunc_Click);
            // 
            // btnCadastrarFunc
            // 
            this.btnCadastrarFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastrarFunc.FlatAppearance.BorderSize = 0;
            this.btnCadastrarFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnCadastrarFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFunc.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFunc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrarFunc.Location = new System.Drawing.Point(0, 35);
            this.btnCadastrarFunc.Name = "btnCadastrarFunc";
            this.btnCadastrarFunc.Size = new System.Drawing.Size(160, 29);
            this.btnCadastrarFunc.TabIndex = 33;
            this.btnCadastrarFunc.Text = "Cadastrar";
            this.btnCadastrarFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarFunc.UseVisualStyleBackColor = true;
            this.btnCadastrarFunc.Click += new System.EventHandler(this.btnCadastrarFunc_Click);
            // 
            // btnMenuFuncionario
            // 
            this.btnMenuFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuFuncionario.FlatAppearance.BorderSize = 0;
            this.btnMenuFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnMenuFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuFuncionario.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuFuncionario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenuFuncionario.Image = global::AssociadoDePlantao.Properties.Resources.canto_botão;
            this.btnMenuFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuFuncionario.Location = new System.Drawing.Point(0, 0);
            this.btnMenuFuncionario.Name = "btnMenuFuncionario";
            this.btnMenuFuncionario.Size = new System.Drawing.Size(160, 35);
            this.btnMenuFuncionario.TabIndex = 32;
            this.btnMenuFuncionario.Text = " Funcionario";
            this.btnMenuFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuFuncionario.UseVisualStyleBackColor = true;
            this.btnMenuFuncionario.Click += new System.EventHandler(this.btnMenuFuncionario_Click_1);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Image = global::AssociadoDePlantao.Properties.Resources.volte;
            this.btnSair.Location = new System.Drawing.Point(3, 468);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(36, 37);
            this.btnSair.TabIndex = 22;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Consolas", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(168)))));
            this.lblHora.Location = new System.Drawing.Point(498, 395);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(471, 112);
            this.lblHora.TabIndex = 14;
            this.lblHora.Text = "00:00:00";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Consolas", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(438, 283);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(577, 112);
            this.lblData.TabIndex = 11;
            this.lblData.Text = "00/00/0000";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(171)))), ((int)(((byte)(68)))));
            this.panel11.Controls.Add(this.lblQuemLogou);
            this.panel11.Controls.Add(this.pictureBox2);
            this.panel11.Location = new System.Drawing.Point(747, 56);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(222, 111);
            this.panel11.TabIndex = 13;
            // 
            // lblQuemLogou
            // 
            this.lblQuemLogou.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuemLogou.AutoSize = true;
            this.lblQuemLogou.BackColor = System.Drawing.Color.Transparent;
            this.lblQuemLogou.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuemLogou.ForeColor = System.Drawing.Color.White;
            this.lblQuemLogou.Location = new System.Drawing.Point(74, 77);
            this.lblQuemLogou.Name = "lblQuemLogou";
            this.lblQuemLogou.Size = new System.Drawing.Size(101, 28);
            this.lblQuemLogou.TabIndex = 4;
            this.lblQuemLogou.Text = "ADMIN";
            this.lblQuemLogou.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AssociadoDePlantao.Properties.Resources.dois_gerente;
            this.pictureBox2.Location = new System.Drawing.Point(57, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(166, 243);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(824, 1);
            this.panel10.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Controls.Add(this.dgvFunc);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtNome);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(166, 289);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(266, 243);
            this.panel4.TabIndex = 8;
            // 
            // dgvFunc
            // 
            this.dgvFunc.AllowUserToAddRows = false;
            this.dgvFunc.AllowUserToDeleteRows = false;
            this.dgvFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunc.Location = new System.Drawing.Point(10, 44);
            this.dgvFunc.Name = "dgvFunc";
            this.dgvFunc.ReadOnly = true;
            this.dgvFunc.Size = new System.Drawing.Size(247, 157);
            this.dgvFunc.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(68, 212);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(186, 20);
            this.txtNome.TabIndex = 6;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(266, 39);
            this.panel5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pesquisar por funcionário: ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AssociadoDePlantao.Properties.Resources.icons8_administrador_masculino_80;
            this.pictureBox3.Location = new System.Drawing.Point(213, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AssociadoDePlantao.Properties.Resources.associado;
            this.pictureBox4.Location = new System.Drawing.Point(166, 39);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(282, 198);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmTelaGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1000, 541);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTelaGerente";
            this.Load += new System.EventHandler(this.frmTelaGerente_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lblQuemLogou;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgvFunc;
        private System.Windows.Forms.Button btnExcluirSala;
        private System.Windows.Forms.Button btnEditarSala;
        private System.Windows.Forms.Button btnCadastrarSala;
        private System.Windows.Forms.Button btnMenuSala;
        private System.Windows.Forms.Button btnExcluirFunc;
        private System.Windows.Forms.Button btnEditarFunc;
        private System.Windows.Forms.Button btnCadastrarFunc;
        private System.Windows.Forms.Button btnMenuFuncionario;
        private System.Windows.Forms.Button btnEntrar;
    }
}