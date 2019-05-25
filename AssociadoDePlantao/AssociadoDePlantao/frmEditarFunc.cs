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
    public partial class frmEditarFunc : Form
    {
        ClassFuncionario func = new ClassFuncionario();
        QuemEstaLogado user = new QuemEstaLogado();
        int codFuncClicado;

        public frmEditarFunc()
        {
            InitializeComponent();
        }

        private void frmEditarFunc_Load(object sender, EventArgs e)
        {
            if(user.RetQuemEstaLogado() == "ADMIN")
            {
                dgvFunc.DataSource = func.RetTodosFunc();
            }
            else
            {
                dgvFunc.DataSource = func.RetTodosFuncGerente();
            }
        }

        private void dgvFunc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvFunc.Rows[e.RowIndex].Cells["codFuncionario"].Value.ToString() != "")
                {
                    codFuncClicado = int.Parse(dgvFunc.Rows[e.RowIndex].Cells["codFuncionario"].Value.ToString());
                }
                string cpfMSK, dataNascMSK;

                cpfMSK = dgvFunc.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
                cpfMSK.Replace(".", "");

                dataNascMSK = dgvFunc.Rows[e.RowIndex].Cells["dataNasc"].Value.ToString();
                dataNascMSK.Replace("/", "");

                txtNome.Text = dgvFunc.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                mskCPF.Text = cpfMSK;
                mskDataNascimento.Text = dataNascMSK;
                cboTipoFunc.Text = dgvFunc.Rows[e.RowIndex].Cells["tipoFuncionario"].Value.ToString();
                txtLogin.Text = dgvFunc.Rows[e.RowIndex].Cells["loginFunc"].Value.ToString();
                txtLogin.Enabled = false;
                txtSenha.Text = dgvFunc.Rows[e.RowIndex].Cells["senha"].Value.ToString();
                cboStatusFunc.Text = dgvFunc.Rows[e.RowIndex].Cells["statusFunc"].Value.ToString();
                txtCodContato.Text = dgvFunc.Rows[e.RowIndex].Cells["CONTATO_codContato"].Value.ToString();
                txtCodigoFuncResp.Text = dgvFunc.Rows[e.RowIndex].Cells["FUNC_codFuncResp"].Value.ToString();
                txtCodigoFuncResp.Enabled = false;
                txtCodContato.Enabled = false;
            }
            catch (Exception error)
            {
                //Da erro eu não sei pq, mas o try catch resolve
            }
            

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja mesmo editar?", "!Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                if (txtNome.Text != "" && mskCPF.Text != "" && mskDataNascimento.Text != "" && cboTipoFunc.Text != "" && txtLogin.Text != "" && txtSenha.Text != "" && cboStatusFunc.Text != "" && txtCodContato.Text != "" && txtCodigoFuncResp.Text != "")
                {
                    if(codFuncClicado != 1)
                    {
                        func.nome = txtNome.Text;
                        func.cpf = mskCPF.Text;
                        func.dataNasc = mskDataNascimento.Text;
                        if (cboTipoFunc.Text == "Gerente")
                        {
                            func.tipoFuncionario = 2;
                        }
                        else
                        {
                            func.tipoFuncionario = 3;
                        }
                        func.loginFunc = txtLogin.Text;
                        func.senha = txtSenha.Text;
                        func.statusFunc = int.Parse(cboStatusFunc.Text);
                        func.CONTATO_codContato = int.Parse(txtCodContato.Text);
                        func.FUNC_codFuncResp = int.Parse(txtCodigoFuncResp.Text);
                        if (func.Editar(codFuncClicado, func) == true)
                        {
                            MessageBox.Show("Edição realizada com sucesso!");
                            if (user.RetQuemEstaLogado() == "ADMIN")
                            {
                                dgvFunc.DataSource = func.RetTodosFunc();
                            }
                            else
                            {
                                dgvFunc.DataSource = func.RetTodosFuncGerente();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erro ao editar!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não é possivel editar o administrador!");
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

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar))
                && !(e.KeyChar == (char)Keys.Enter)
                && !(e.KeyChar == (char)Keys.Back)
                && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void txtBuscaNome_TextChanged(object sender, EventArgs e)
        {
            if (user.RetQuemEstaLogado() == "ADMIN")
            {
                dgvFunc.DataSource = func.RetFuncionarioPorNome(txtBuscaNome.Text);
            }
            else
            {
                dgvFunc.DataSource = func.RetFuncionarioPorNome(txtBuscaNome.Text);
            }
        }

        private void pnlEditarLoja_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
