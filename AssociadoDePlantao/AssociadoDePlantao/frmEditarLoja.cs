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
    public partial class frmEditarLoja : Form
    {
        ClassLoja loja = new ClassLoja();
        int codLojaClicado;
        public frmEditarLoja()
        {
            InitializeComponent();
        }

     

        private void frmEditarLoja_Load(object sender, EventArgs e)
        {
            dgvLojas.DataSource = loja.RetTodasLoja();
        }

        private void dgvLojas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvLojas.Rows[e.RowIndex].Cells["codLoja"].Value.ToString() != "")
            {
                codLojaClicado = int.Parse(dgvLojas.Rows[e.RowIndex].Cells["codLoja"].Value.ToString());
            }

            string cpnjMascara = dgvLojas.Rows[e.RowIndex].Cells["cpnj"].Value.ToString();
            cpnjMascara.Replace("-", "");

            string inauguracaoMascara = dgvLojas.Rows[e.RowIndex].Cells["inauguracao"].Value.ToString();
            inauguracaoMascara.Replace("/", "");

            txtRazaoSocial.Text = dgvLojas.Rows[e.RowIndex].Cells["razaoSocial"].Value.ToString();
            txtNomeFantasia.Text = dgvLojas.Rows[e.RowIndex].Cells["nomeFantasia"].Value.ToString();
            txtCpnj.Text = cpnjMascara;
            txtSite.Text = dgvLojas.Rows[e.RowIndex].Cells["siteLoja"].Value.ToString();
            txtInauguracao.Text = inauguracaoMascara;
            cboTipoLoja.Text = dgvLojas.Rows[e.RowIndex].Cells["tipoLoja"].Value.ToString();
            txtCodContato.Text = dgvLojas.Rows[e.RowIndex].Cells["CONTATO_codContato"].Value.ToString();
            txtFuncResp.Text = dgvLojas.Rows[e.RowIndex].Cells["FUNC_codFuncResp"].Value.ToString();
            txtCodContato.Enabled = false;
            txtFuncResp.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja mesmo editar?", "!Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(resultado == DialogResult.Yes)
            {
                if(txtRazaoSocial.Text != "" && txtNomeFantasia.Text != "" && txtCpnj.Text != "" && txtSite.Text != "" && txtInauguracao.Text != "" && cboTipoLoja.Text != "" && txtCodContato.Text != "" && txtFuncResp.Text != "")
                {
                    loja.razaoSocial = txtRazaoSocial.Text;
                    loja.nomeFantasia = txtNomeFantasia.Text;
                    loja.cpnj = txtCpnj.Text;
                    loja.siteLoja = txtSite.Text;
                    loja.inauguracao = txtInauguracao.Text;
                    loja.tipoLoja = cboTipoLoja.Text;
                    loja.CONTATO_codContato = int.Parse(txtCodContato.Text);
                    loja.FUNC_codFuncResp = int.Parse(txtFuncResp.Text);

                    if (loja.Editar(codLojaClicado,loja) == true)
                    {
                        MessageBox.Show("Edição realizada com sucesso!");
                        dgvLojas.DataSource = loja.RetTodasLoja();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao editar!");
                    }

                }
                else
                {
                    MessageBox.Show("Preencha todos os dados!");
                }
            }
            else
            {
                MessageBox.Show("Edição cancelada!");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtRazaoSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar))
                && !(e.KeyChar == (char)Keys.Enter)
                && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtBuscaNome_TextChanged(object sender, EventArgs e)
        {
            dgvLojas.DataSource = loja.RetLojaPorNome(txtBuscaNome.Text);
        }

        private void pnlEditarLoja_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
