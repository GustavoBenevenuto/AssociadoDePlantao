namespace AssociadoDePlantao
{
    partial class frmExcluirFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExcluirFunc));
            this.pnlEditarLoja = new System.Windows.Forms.Panel();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.lblCodFunc = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFunc = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pnlEditarLoja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEditarLoja
            // 
            this.pnlEditarLoja.Controls.Add(this.txtBuscaNome);
            this.pnlEditarLoja.Controls.Add(this.lblCodFunc);
            this.pnlEditarLoja.Controls.Add(this.label9);
            this.pnlEditarLoja.Controls.Add(this.label1);
            this.pnlEditarLoja.Controls.Add(this.dgvFunc);
            this.pnlEditarLoja.Controls.Add(this.btnExcluir);
            this.pnlEditarLoja.Location = new System.Drawing.Point(13, 24);
            this.pnlEditarLoja.Name = "pnlEditarLoja";
            this.pnlEditarLoja.Size = new System.Drawing.Size(800, 463);
            this.pnlEditarLoja.TabIndex = 20;
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaNome.Location = new System.Drawing.Point(174, 426);
            this.txtBuscaNome.MaxLength = 60;
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(269, 23);
            this.txtBuscaNome.TabIndex = 55;
            this.txtBuscaNome.TextChanged += new System.EventHandler(this.txtBuscaNome_TextChanged);
            // 
            // lblCodFunc
            // 
            this.lblCodFunc.AutoSize = true;
            this.lblCodFunc.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodFunc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCodFunc.Location = new System.Drawing.Point(718, 427);
            this.lblCodFunc.Name = "lblCodFunc";
            this.lblCodFunc.Size = new System.Drawing.Size(21, 23);
            this.lblCodFunc.TabIndex = 23;
            this.lblCodFunc.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(3, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 23);
            this.label9.TabIndex = 56;
            this.label9.Text = "Buscar por nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(458, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Funcionário a ser excluido: ";
            // 
            // dgvFunc
            // 
            this.dgvFunc.AllowUserToAddRows = false;
            this.dgvFunc.AllowUserToDeleteRows = false;
            this.dgvFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunc.Location = new System.Drawing.Point(3, 13);
            this.dgvFunc.Name = "dgvFunc";
            this.dgvFunc.ReadOnly = true;
            this.dgvFunc.Size = new System.Drawing.Size(794, 397);
            this.dgvFunc.TabIndex = 20;
            this.dgvFunc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFunc_CellClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluir.Image = global::AssociadoDePlantao.Properties.Resources.fechar;
            this.btnExcluir.Location = new System.Drawing.Point(745, 416);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(52, 44);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmExcluirFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(825, 499);
            this.Controls.Add(this.pnlEditarLoja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExcluirFunc";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExcluirFunc";
            this.Load += new System.EventHandler(this.frmExcluirFunc_Load);
            this.pnlEditarLoja.ResumeLayout(false);
            this.pnlEditarLoja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlEditarLoja;
        private System.Windows.Forms.Label lblCodFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFunc;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.Label label9;
    }
}