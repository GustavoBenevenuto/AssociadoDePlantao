namespace AssociadoDePlantao
{
    partial class frmAcessoSala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcessoSala));
            this.dgvSala = new System.Windows.Forms.DataGridView();
            this.dgvFunc = new System.Windows.Forms.DataGridView();
            this.txtCodSala = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodFunc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLiberar = new System.Windows.Forms.Button();
            this.btnBloquear = new System.Windows.Forms.Button();
            this.dgvAcessoSala = new System.Windows.Forms.DataGridView();
            this.txtCodFuncBlock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodSalaBlock = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcessoSala)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSala
            // 
            this.dgvSala.AllowUserToAddRows = false;
            this.dgvSala.AllowUserToDeleteRows = false;
            this.dgvSala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSala.Location = new System.Drawing.Point(51, 39);
            this.dgvSala.Name = "dgvSala";
            this.dgvSala.ReadOnly = true;
            this.dgvSala.Size = new System.Drawing.Size(244, 147);
            this.dgvSala.TabIndex = 4;
            this.dgvSala.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSala_CellClick);
            // 
            // dgvFunc
            // 
            this.dgvFunc.AllowUserToAddRows = false;
            this.dgvFunc.AllowUserToDeleteRows = false;
            this.dgvFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunc.Location = new System.Drawing.Point(376, 39);
            this.dgvFunc.Name = "dgvFunc";
            this.dgvFunc.ReadOnly = true;
            this.dgvFunc.Size = new System.Drawing.Size(244, 147);
            this.dgvFunc.TabIndex = 5;
            this.dgvFunc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFunc_CellClick);
            // 
            // txtCodSala
            // 
            this.txtCodSala.Enabled = false;
            this.txtCodSala.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodSala.Location = new System.Drawing.Point(51, 215);
            this.txtCodSala.MaxLength = 60;
            this.txtCodSala.Name = "txtCodSala";
            this.txtCodSala.Size = new System.Drawing.Size(176, 23);
            this.txtCodSala.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(47, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Codigo da Sala:";
            // 
            // txtCodFunc
            // 
            this.txtCodFunc.Enabled = false;
            this.txtCodFunc.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodFunc.Location = new System.Drawing.Point(376, 215);
            this.txtCodFunc.MaxLength = 60;
            this.txtCodFunc.Name = "txtCodFunc";
            this.txtCodFunc.Size = new System.Drawing.Size(176, 23);
            this.txtCodFunc.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(372, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Codigo dao Funcionário:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(689, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Liberar Acesso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(689, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Bloquear Acesso";
            // 
            // btnLiberar
            // 
            this.btnLiberar.FlatAppearance.BorderSize = 0;
            this.btnLiberar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLiberar.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiberar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLiberar.Image = global::AssociadoDePlantao.Properties.Resources.icons8_ok_48;
            this.btnLiberar.Location = new System.Drawing.Point(728, 162);
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.Size = new System.Drawing.Size(46, 41);
            this.btnLiberar.TabIndex = 24;
            this.btnLiberar.UseVisualStyleBackColor = true;
            this.btnLiberar.Click += new System.EventHandler(this.btnLiberar_Click);
            // 
            // btnBloquear
            // 
            this.btnBloquear.FlatAppearance.BorderSize = 0;
            this.btnBloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloquear.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloquear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBloquear.Image = global::AssociadoDePlantao.Properties.Resources.fechar;
            this.btnBloquear.Location = new System.Drawing.Point(728, 415);
            this.btnBloquear.Name = "btnBloquear";
            this.btnBloquear.Size = new System.Drawing.Size(46, 41);
            this.btnBloquear.TabIndex = 34;
            this.btnBloquear.UseVisualStyleBackColor = true;
            this.btnBloquear.Click += new System.EventHandler(this.btnBloquear_Click);
            // 
            // dgvAcessoSala
            // 
            this.dgvAcessoSala.AllowUserToAddRows = false;
            this.dgvAcessoSala.AllowUserToDeleteRows = false;
            this.dgvAcessoSala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcessoSala.Location = new System.Drawing.Point(52, 332);
            this.dgvAcessoSala.Name = "dgvAcessoSala";
            this.dgvAcessoSala.ReadOnly = true;
            this.dgvAcessoSala.Size = new System.Drawing.Size(278, 147);
            this.dgvAcessoSala.TabIndex = 35;
            this.dgvAcessoSala.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAcessoSala_CellClick);
            // 
            // txtCodFuncBlock
            // 
            this.txtCodFuncBlock.Enabled = false;
            this.txtCodFuncBlock.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodFuncBlock.Location = new System.Drawing.Point(336, 371);
            this.txtCodFuncBlock.MaxLength = 60;
            this.txtCodFuncBlock.Name = "txtCodFuncBlock";
            this.txtCodFuncBlock.Size = new System.Drawing.Size(176, 23);
            this.txtCodFuncBlock.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(332, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "Codigo dao Funcionário:";
            // 
            // txtCodSalaBlock
            // 
            this.txtCodSalaBlock.Enabled = false;
            this.txtCodSalaBlock.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodSalaBlock.Location = new System.Drawing.Point(336, 453);
            this.txtCodSalaBlock.MaxLength = 60;
            this.txtCodSalaBlock.Name = "txtCodSalaBlock";
            this.txtCodSalaBlock.Size = new System.Drawing.Size(176, 23);
            this.txtCodSalaBlock.TabIndex = 36;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl.Location = new System.Drawing.Point(332, 427);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(148, 23);
            this.lbl.TabIndex = 37;
            this.lbl.Text = "Codigo da Sala:";
            // 
            // frmAcessoSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(825, 499);
            this.Controls.Add(this.txtCodFuncBlock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodSalaBlock);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.dgvAcessoSala);
            this.Controls.Add(this.btnBloquear);
            this.Controls.Add(this.btnLiberar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodFunc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodSala);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvFunc);
            this.Controls.Add(this.dgvSala);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAcessoSala";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAcessoSala";
            this.Load += new System.EventHandler(this.frmAcessoSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcessoSala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSala;
        private System.Windows.Forms.DataGridView dgvFunc;
        private System.Windows.Forms.TextBox txtCodSala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLiberar;
        private System.Windows.Forms.Button btnBloquear;
        private System.Windows.Forms.DataGridView dgvAcessoSala;
        private System.Windows.Forms.TextBox txtCodFuncBlock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodSalaBlock;
        private System.Windows.Forms.Label lbl;
    }
}