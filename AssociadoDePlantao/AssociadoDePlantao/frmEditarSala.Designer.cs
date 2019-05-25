namespace AssociadoDePlantao
{
    partial class frmEditarSala
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
            this.dgvSala = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblQuemLogou = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSala)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSala
            // 
            this.dgvSala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSala.Location = new System.Drawing.Point(102, 12);
            this.dgvSala.Name = "dgvSala";
            this.dgvSala.Size = new System.Drawing.Size(587, 205);
            this.dgvSala.TabIndex = 0;
            this.dgvSala.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSala_CellClick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Image = global::AssociadoDePlantao.Properties.Resources.icons8_ok_48;
            this.btnSalvar.Location = new System.Drawing.Point(761, 437);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(52, 50);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(235, 295);
            this.txtDescricao.MaxLength = 60;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(313, 74);
            this.txtDescricao.TabIndex = 5;
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
            this.lblQuemLogou.Location = new System.Drawing.Point(327, 264);
            this.lblQuemLogou.Name = "lblQuemLogou";
            this.lblQuemLogou.Size = new System.Drawing.Size(134, 28);
            this.lblQuemLogou.TabIndex = 7;
            this.lblQuemLogou.Text = "Descrição: ";
            this.lblQuemLogou.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCod
            // 
            this.lblCod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCod.AutoSize = true;
            this.lblCod.BackColor = System.Drawing.Color.Transparent;
            this.lblCod.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.ForeColor = System.Drawing.Color.White;
            this.lblCod.Location = new System.Drawing.Point(383, 462);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(25, 28);
            this.lblCod.TabIndex = 8;
            this.lblCod.Text = "0";
            this.lblCod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmEditarSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(825, 499);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.lblQuemLogou);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.dgvSala);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarSala";
            this.ShowInTaskbar = false;
            this.Text = "frmEditarSala";
            this.Load += new System.EventHandler(this.frmEditarSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSala;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblQuemLogou;
        private System.Windows.Forms.Label lblCod;
    }
}