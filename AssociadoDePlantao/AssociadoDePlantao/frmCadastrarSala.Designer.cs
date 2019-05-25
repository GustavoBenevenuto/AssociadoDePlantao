namespace AssociadoDePlantao
{
    partial class frmCadastrarSala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarSala));
            this.pnlCadastrarLoja = new System.Windows.Forms.Panel();
            this.lblCod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodFunc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodLoja = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCadastrarLoja.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCadastrarLoja
            // 
            this.pnlCadastrarLoja.Controls.Add(this.lblCod);
            this.pnlCadastrarLoja.Controls.Add(this.label1);
            this.pnlCadastrarLoja.Controls.Add(this.txtCodFunc);
            this.pnlCadastrarLoja.Controls.Add(this.label5);
            this.pnlCadastrarLoja.Controls.Add(this.txtCodLoja);
            this.pnlCadastrarLoja.Controls.Add(this.label4);
            this.pnlCadastrarLoja.Controls.Add(this.btnSalvar);
            this.pnlCadastrarLoja.Controls.Add(this.txtDescricao);
            this.pnlCadastrarLoja.Controls.Add(this.label2);
            this.pnlCadastrarLoja.Location = new System.Drawing.Point(30, 24);
            this.pnlCadastrarLoja.Name = "pnlCadastrarLoja";
            this.pnlCadastrarLoja.Size = new System.Drawing.Size(783, 463);
            this.pnlCadastrarLoja.TabIndex = 18;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCod.Location = new System.Drawing.Point(598, 75);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(21, 23);
            this.lblCod.TabIndex = 25;
            this.lblCod.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(444, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Código da Sala:";
            // 
            // txtCodFunc
            // 
            this.txtCodFunc.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodFunc.Location = new System.Drawing.Point(24, 212);
            this.txtCodFunc.MaxLength = 60;
            this.txtCodFunc.Name = "txtCodFunc";
            this.txtCodFunc.Size = new System.Drawing.Size(269, 23);
            this.txtCodFunc.TabIndex = 3;
            this.txtCodFunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(20, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Código do Funcionário:";
            // 
            // txtCodLoja
            // 
            this.txtCodLoja.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodLoja.Location = new System.Drawing.Point(24, 160);
            this.txtCodLoja.MaxLength = 60;
            this.txtCodLoja.Name = "txtCodLoja";
            this.txtCodLoja.Size = new System.Drawing.Size(269, 23);
            this.txtCodLoja.TabIndex = 2;
            this.txtCodLoja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(20, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Codigo da Loja:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Image = global::AssociadoDePlantao.Properties.Resources.icons8_ok_48;
            this.btnSalvar.Location = new System.Drawing.Point(724, 408);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(52, 50);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(24, 57);
            this.txtDescricao.MaxLength = 60;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(269, 74);
            this.txtDescricao.TabIndex = 1;
            this.txtDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricao_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(20, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição: ";
            // 
            // frmCadastrarSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(825, 499);
            this.Controls.Add(this.pnlCadastrarLoja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastrarSala";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastrarSala";
            this.Load += new System.EventHandler(this.frmCadastrarSala_Load);
            this.pnlCadastrarLoja.ResumeLayout(false);
            this.pnlCadastrarLoja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCadastrarLoja;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodFunc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodLoja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label label1;
    }
}