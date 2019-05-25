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
    public partial class frmCadastrarLojaAdmin : Form
    {
        ClassContato contato = new ClassContato();
        ClassLoja loja = new ClassLoja();
        QuemEstaLogado user = new QuemEstaLogado();

        public frmCadastrarLojaAdmin()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void frmCadastrarLojaAdmin_Load(object sender, EventArgs e)
        {
            
            pnlCadastrarLoja.Visible = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
            txtPais.Enabled = false;
            txtEndereco.Enabled = false;
        }

        private void btnVoltarAoContato_Click(object sender, EventArgs e)
        {
            pnlCadastrarLoja.Visible = false;
        }


        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (txtEndereco.Text != "" && txtNumero.Text != "" && txtConplemento.Text != "" && txtBairro.Text != "" && txtCidade.Text != "" && txtEstado.Text != "" && txtPais.Text != "" && txtTel.Text != "" && txtCel.Text != "" && txtEmail.Text != "")
            {
                pnlCadastrarLoja.Visible = true;
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
            if (txtRazaoSocial.Text != "" && txtNomeFantasia.Text != "" && txtCpnj.Text != "" && txtSite.Text != "" && txtInauguracao.Text != "" && cboTipoLoja.Text != "" && txtCodContato.Text != "" && txtFuncResp.Text != "")
            {

                if (loja.RetFuncRespExiste(int.Parse(txtFuncResp.Text)) == true)
                {
                    if(user.RetQuemEstaLogado() == "ADMIN")
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

                        loja.razaoSocial = txtRazaoSocial.Text;
                        loja.nomeFantasia = txtNomeFantasia.Text;
                        loja.cpnj = txtCpnj.Text;
                        loja.siteLoja = txtSite.Text;
                        loja.inauguracao = txtInauguracao.Text;
                        loja.tipoLoja = cboTipoLoja.Text;
                        loja.CONTATO_codContato = int.Parse(txtCodContato.Text);
                        loja.FUNC_codFuncResp = int.Parse(txtFuncResp.Text);

                        if (contato.Inserir(contato) == true && loja.Inserir(loja) == true)
                        {
                            MessageBox.Show("Cadastro realizado com sucesso!");
                            frmCadastrarLojaAdmin cadastrarLojaAdmin = new frmCadastrarLojaAdmin();
                            if (Application.OpenForms.OfType<frmCadastrarLojaAdmin>().Count() > 0)
                            {
                                Application.OpenForms[cadastrarLojaAdmin.Name].Close();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Erro ao cadastrar!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Você não pode cadastrar lojas!");
                    }
                    

                }
                else
                {
                    MessageBox.Show("Funcionario responsavel não existe!");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os dados!");
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }

        }

        private void mskCEP_Leave(object sender, EventArgs e)
        {
            string cep = mskCEP.Text;
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastrarFuncAdm func = new frmCadastrarFuncAdm();
            func.Show();
            this.Hide();
        }

        private void txtRazaoSocial_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
