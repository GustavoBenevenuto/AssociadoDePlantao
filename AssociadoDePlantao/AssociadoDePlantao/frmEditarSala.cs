using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssociadoDePlantao
{
    public partial class frmEditarSala : Form
    {
        ClassSala sala = new ClassSala();

        int codSalaClicado;
        public frmEditarSala()
        {
            InitializeComponent();
        }

        private void frmEditarSala_Load(object sender, EventArgs e)
        {
            dgvSala.DataSource = sala.RetTodasSala();
        }

        private void dgvSala_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSala.Rows[e.RowIndex].Cells["codSala"].Value.ToString() != "")
            {
                codSalaClicado = int.Parse(dgvSala.Rows[e.RowIndex].Cells["codSala"].Value.ToString());
                lblCod.Text = codSalaClicado.ToString();
                txtDescricao.Text = dgvSala.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtDescricao.Text != "")
            {
                sala.Editar(txtDescricao.Text, codSalaClicado);
                dgvSala.DataSource = sala.RetTodasSala();
                MessageBox.Show("Edição concluida");
            }
        }
    }
}
