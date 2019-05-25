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
    public partial class frmCadastrarFuncAdm : Form
    {
        ClassFuncionario func = new ClassFuncionario();
        ClassContato contato = new ClassContato();
        public frmCadastrarFuncAdm()
        {
            InitializeComponent();
        }


        private void frmCadastrarFuncAdm_Load(object sender, EventArgs e)
        {
            pnlCadastrarFunc.Visible = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
            txtPais.Enabled = false;
            txtEndereco.Enabled = false;
        }


        private void mskCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskCEP_Leave(object sender, EventArgs e)
        {
            
            string cep = "";
            cep = mskCEP.Text;
            //Cria objeto do tipo AtendeClienteClient, classe do WebService dos correios
            //O var é uma espécie de coringa, meio que adivinha qual o tipo de dados que receberá
            var ws = new ServiceCEP.AtendeClienteClient();

            //Chamada do método que consulta o cep.
            var resposta = ws.consultaCEP(cep);



            txtBairro.Text = resposta.bairro;
            txtCidade.Text = resposta.cidade;
            txtEstado.Text = resposta.uf;
            txtEndereco.Text = resposta.end;
            txtPais.Text = "Brasil";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrarLoja_Click(object sender, EventArgs e)
        {
            frmCadastrarLojaAdmin loja = new frmCadastrarLojaAdmin();
            loja.Show();
            this.Hide();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (txtEndereco.Text != "" && txtNumero.Text != "" && txtConplemento.Text != "" && txtBairro.Text != "" && txtCidade.Text != "" && txtEstado.Text != "" && txtPais.Text != "" && txtTel.Text != "" && txtCel.Text != "" && txtEmail.Text != "")
            {
                pnlCadastrarFunc.Visible = true;
                txtCodContato.Text = (contato.RetMaxCodContato() + 1).ToString();
                txtCodContato.Enabled = false;
            }
            else
            {
                MessageBox.Show("Preencha todos os dados! ");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text != "" && mskCPF.Text != "" && mskDataNascimento.Text != "" && cboTipoFunc.Text != "" && txtLogin.Text != "" && txtSenha.Text != "" && cboStatusFunc.Text != "" && txtCodContato.Text != "" && txtCodigoFuncResp.Text != "")
            {
                contato.endereco = txtEndereco.Text;
                contato.numero = int.Parse(txtNumero.Text);
                contato.conplemento = txtConplemento.Text;
                contato.bairro = txtBairro.Text;
                contato.cidade = txtCidade.Text;
                contato.estado = txtEstado.Text;
                contato.pais = txtPais.Text;
                contato.telFixo = txtTel.Text;
                contato.celular = txtCel.Text;
                contato.email = txtEmail.Text;

                
                if (func.VerificarLogin(txtLogin.Text) == false)
                {
                    if(func.RetCodFuncExiste(int.Parse(txtCodigoFuncResp.Text)) == true) // Verifica se o usuario que ele colocou como responsavel existe ou não
                    {
                        if(cboTipoFunc.Text == "Gerente")
                        {
                            func.tipoFuncionario = 2;
                        }
                        else
                        {
                            func.tipoFuncionario = 3;
                        }
                        
                        func.nome = txtNome.Text;
                        func.cpf = mskCPF.Text;
                        func.dataNasc = mskDataNascimento.Text;
                        func.loginFunc = txtLogin.Text;
                        func.senha = txtSenha.Text;
                        func.statusFunc = int.Parse(cboStatusFunc.Text);
                        func.CONTATO_codContato = int.Parse(txtCodContato.Text);
                        func.FUNC_codFuncResp = int.Parse(txtCodigoFuncResp.Text);

                        MessageBox.Show("Inserido com sucesso");
                        contato.Inserir(contato);
                        func.Inserir(func);
                        frmCadastrarFuncAdm cadastrarFunc = new frmCadastrarFuncAdm();
                        if (Application.OpenForms.OfType<frmCadastrarFuncAdm>().Count() > 0)
                        {
                            Application.OpenForms[cadastrarFunc.Name].Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("O funcionário responsavel não existe ou não tem permissão para ser responsavel", "ERRO");
                    }
                }
                else
                {
                    MessageBox.Show("O login de usuário já existe!", "ERRO");
                }

            }
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if(func.VerificarLogin(txtLogin.Text) == true)
            {
                txtLogin.BackColor = Color.Red;
                statusLogin.Text = "Login já existe!";
            }
            else
            {
                txtLogin.BackColor = Color.White;
                statusLogin.Text = "";
                txtLogin.Text = txtLogin.Text.ToUpper();
            }
        }

        private void btnVoltarAoContato_Click(object sender, EventArgs e)
        {
            pnlCadastrarFunc.Visible = false;
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar))
                 && !(e.KeyChar == (char)Keys.Enter)
                 && !(e.KeyChar == (char)Keys.Back)
                 && !(e.KeyChar == (char)Keys.CapsLock)
                 && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void txtCodigoFuncResp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar))
                && !(e.KeyChar == (char)Keys.Enter)
                && !(e.KeyChar == (char)Keys.Back)
                && !(e.KeyChar == (char)Keys.CapsLock)
                && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }
    }
}
