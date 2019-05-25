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
    public partial class frmTelaLogin : Form
    {
        ClassFuncionario func = new ClassFuncionario();
        QuemEstaLogado user = new QuemEstaLogado();

        int clicks = 0, loginTentou = 0;

        public frmTelaLogin()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Logando()
        {
            if (txtLogin.Text != "" && txtSenha.Text != "")
            {
                func.loginFunc = txtLogin.Text;
                func.senha = txtSenha.Text;

                if (func.RetSatusFunc(txtLogin.Text) == 1)
                {
                    user.Editar(txtLogin.Text);
                    if (func.loginFunc == "ADMIN" && func.senha == "admin" && func.RetTipoFunc(txtLogin.Text) == 1)
                    {
                        frmTelaAdmin admin = new frmTelaAdmin();
                        admin.Show();                       
                        this.Hide();
                    }
                    else
                    {
                        if (func.Logar(func) == true && func.RetTipoFunc(txtLogin.Text) == 2)
                        {
                            frmTelaGerente gerente = new frmTelaGerente();
                            gerente.Show();                            
                            this.Hide();
                        }
                        else if (func.Logar(func) == true && func.RetTipoFunc(txtLogin.Text) == 3)
                        {
                            frmEntrarNaSala entrarNaSala = new frmEntrarNaSala();
                            entrarNaSala.Show();
                            this.Hide();
                        }
                        else
                        {
                            if (func.VerificarLogin(txtLogin.Text) == true)
                            {
                                loginTentou++;
                            }
                            if (loginTentou == 3 && txtLogin.Text != "ADMIN")
                            {
                                func.BloqueandoFunc(txtLogin.Text);
                            }
                            MessageBox.Show("Login ou senha não existe!");
                            txtLogin.Text = ""; txtSenha.Text = "";
                            txtLogin.Focus();
                            clicks++;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Você está bloqueado", "Erro");
                }

            }
            else
            {
                MessageBox.Show("Insira todos os dados", "Erro");
                clicks++;
            }
            if (clicks == 3)
            {
                pnlAguarde.Visible = true;
                timer1.Enabled = true;
                txtSenha.Enabled = false;

            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Logando();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pgrAguarde.Value < 550)
            {
                pgrAguarde.Value = pgrAguarde.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                pnlAguarde.Visible = false;
                pgrAguarde.Value = 0;
                clicks = 0;
                txtSenha.Enabled = true;
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Logando();
            }
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            txtLogin.Text = txtLogin.Text.ToUpper();
        }

        private void frmTelaLogin_Load(object sender, EventArgs e)
        {
            pnlAguarde.Visible = false;
        }
    }
}
