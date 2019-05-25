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
    public partial class frmExcluirLoja : Form
    {
        ClassLoja loja = new ClassLoja();
        int codLojaClicado = 0;

        public frmExcluirLoja()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja mesmo excluir?", "!Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(resultado == DialogResult.Yes)
            {
                if(codLojaClicado != 0)
                {
                    loja.Excluir(codLojaClicado);
                    MessageBox.Show("Cliente excluído com sucesso!");
                    dgvLojas.DataSource = loja.RetTodasLoja();

                }
                else
                {
                    MessageBox.Show("Escolha alguma loja para excluir!");
                }
            }
        }



        private void frmExcluirLoja_Load(object sender, EventArgs e)
        {
            dgvLojas.DataSource = loja.RetTodasLoja();
        }

        private void dgvLojas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLojas.Rows[e.RowIndex].Cells["codLoja"].Value.ToString() != "")
            {
                codLojaClicado = int.Parse(dgvLojas.Rows[e.RowIndex].Cells["codLoja"].Value.ToString());
            }
            lblCodLoja.Text = codLojaClicado.ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtBuscaNome_TextChanged(object sender, EventArgs e)
        {
            dgvLojas.DataSource = loja.RetLojaPorNome(txtBuscaNome.Text);
        }
    }
}
