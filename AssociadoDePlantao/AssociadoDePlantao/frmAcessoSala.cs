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
    public partial class frmAcessoSala : Form
    {
        ClassFuncionario func = new ClassFuncionario();
        ClassSala sala = new ClassSala();
        QuemEstaLogado user = new QuemEstaLogado();

        int codFunc, codSala, codAcesso = 0;

        public frmAcessoSala()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmTelaAdmin telaAdmin = new frmTelaAdmin();
            telaAdmin.Show();
            this.Hide();
        }

        private void frmAcessoSala_Load(object sender, EventArgs e)
        {
            dgvSala.DataSource = sala.RetSalaDescricao();
            dgvFunc.DataSource = func.RetCodFuncNome();
            dgvAcessoSala.DataSource = sala.RetAcessoSala();
            
        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {            
            if(MessageBox.Show("Tem certeza?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(txtCodFunc.Text != "" && txtCodSala.Text != "")
                {
                    sala.LiberarAcesso(codFunc, codSala);
                    dgvAcessoSala.DataSource = sala.RetAcessoSala();
                }
                else
                {
                    MessageBox.Show("Escolha uma sala e um funcionário");
                }
                
            }
        }

        private void btnBloquear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(codAcesso != 0)
                {
                    sala.BloqueaAcesso(codAcesso);
                    dgvAcessoSala.DataSource = sala.RetAcessoSala();
                    codAcesso = 0;
                }
                else
                {
                    MessageBox.Show("Não existe linhas para excluir ou você não selecionou nada");
                }
            }
        }

        private void dgvFunc_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvFunc.Rows[e.RowIndex].Cells["codFuncionario"].Value.ToString() != "")
            {
                codFunc = int.Parse(dgvFunc.Rows[e.RowIndex].Cells["codFuncionario"].Value.ToString());
                txtCodFunc.Text = codFunc.ToString();
            }
        }



        private void dgvAcessoSala_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvAcessoSala.Rows[e.RowIndex].Cells["codAcesso"].Value.ToString() != "")
            {
                codAcesso = int.Parse(dgvAcessoSala.Rows[e.RowIndex].Cells["codAcesso"].Value.ToString());
                txtCodFuncBlock.Text = dgvAcessoSala.Rows[e.RowIndex].Cells["FUNC_codFuncResp"].Value.ToString();
                txtCodSalaBlock.Text = dgvAcessoSala.Rows[e.RowIndex].Cells["SALA_codSala"].Value.ToString();
            }
            
        }

        private void dgvSala_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSala.Rows[e.RowIndex].Cells["codSala"].Value.ToString() != "")
            {
                codSala = int.Parse(dgvSala.Rows[e.RowIndex].Cells["codSala"].Value.ToString());
                txtCodSala.Text = codSala.ToString();
            }
        }
    }
}
