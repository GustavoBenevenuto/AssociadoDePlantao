namespace AssociadoDePlantao
{
    partial class frmExcluirSala
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
            this.lblCodSala = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgSalas = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodSala
            // 
            this.lblCodSala.AutoSize = true;
            this.lblCodSala.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodSala.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCodSala.Location = new System.Drawing.Point(709, 459);
            this.lblCodSala.Name = "lblCodSala";
            this.lblCodSala.Size = new System.Drawing.Size(21, 23);
            this.lblCodSala.TabIndex = 27;
            this.lblCodSala.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(516, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Loja a ser excluida: ";
            // 
            // dvgSalas
            // 
            this.dvgSalas.AllowUserToAddRows = false;
            this.dvgSalas.AllowUserToDeleteRows = false;
            this.dvgSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgSalas.Location = new System.Drawing.Point(19, 45);
            this.dvgSalas.Name = "dvgSalas";
            this.dvgSalas.ReadOnly = true;
            this.dvgSalas.Size = new System.Drawing.Size(794, 397);
            this.dvgSalas.TabIndex = 25;
            this.dvgSalas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgSalas_CellClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluir.Image = global::AssociadoDePlantao.Properties.Resources.fechar;
            this.btnExcluir.Location = new System.Drawing.Point(761, 448);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(52, 44);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmExcluirSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(825, 499);
            this.Controls.Add(this.lblCodSala);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgSalas);
            this.Controls.Add(this.btnExcluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExcluirSala";
            this.Text = "frmExcluirSala";
            this.Load += new System.EventHandler(this.frmExcluirSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgSalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodSala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgSalas;
        private System.Windows.Forms.Button btnExcluir;
    }
}