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
    public partial class frmTelaAdmin : Form
    {
        ClassLoja loja = new ClassLoja();
        ClassFuncionario func = new ClassFuncionario();
        QuemEstaLogado user = new QuemEstaLogado();

        public frmTelaAdmin()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmTelaAdmin_Load(object sender, EventArgs e)
        {
            lblQuemLogou.Text = user.RetQuemEstaLogado();
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblTotalFunc.Text = func.RetTotalFunc().ToString();
            lblTotalBlock.Text = func.RetTotalBlock().ToString();
            lblTotalGerentes.Text = func.RetTotalGerente().ToString();
            pnlForm.Visible = false;

            // ----------------------------- LOJA -------------------------------- //
            btnCadastrarLoja.Visible = false;
            btnEditarLoja.Visible = false;
            btnExcluirloja.Visible = false;

            // ----------------------------- FUNC -------------------------------- //
            btnCadastrarFunc.Visible = false;
            btnEditarFunc.Visible = false;
            btnExcluirFunc.Visible = false;

            // ----------------------------- SALA -------------------------------- //
            btnCadastrarSala.Visible = false;
            btnEditarSala.Visible = false;
            btnExcluirSala.Visible = false;
            btnEntrarnaSala.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        int clicLoja = 0;
        private void btnMenuLoja_Click_1(object sender, EventArgs e)
        {
            pnlForm.Visible = false;
            if (clicLoja == 0)
            {
                btnCadastrarLoja.Visible = true;
                btnEditarLoja.Visible = true;
                btnExcluirloja.Visible = true;
                clicLoja++;
            }
            else
            {
                btnCadastrarLoja.Visible = false;
                btnEditarLoja.Visible = false;
                btnExcluirloja.Visible = false;
                clicLoja = 0;
            }
        }

        int clickFunc = 0;
        private void btnMenuFuncionario_Click_1(object sender, EventArgs e)
        {
            pnlForm.Visible = false;
            if (clickFunc == 0)
            {
                btnCadastrarFunc.Visible = true;
                btnEditarFunc.Visible = true;
                btnExcluirFunc.Visible = true;
                clickFunc++;
            }
            else
            {
                btnCadastrarFunc.Visible = false;
                btnEditarFunc.Visible = false;
                btnExcluirFunc.Visible = false;
                clickFunc = 0;
            }
        }

        int clickSala = 0;
        private void btnMenuSala_Click_1(object sender, EventArgs e)
        {
            pnlForm.Visible = false;
            if (clickSala == 0)
            {
                btnCadastrarSala.Visible = true;
                btnEditarSala.Visible = true;
                btnExcluirSala.Visible = true;
                btnEntrarnaSala.Visible = true;
                clickSala++;
            }
            else
            {
                btnCadastrarSala.Visible = false;
                btnEditarSala.Visible = false;
                btnExcluirSala.Visible = false;
                btnEntrarnaSala.Visible = false;
                clickSala = 0;
            }
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            VerificaFormAberto();
            frmTelaLogin telaLogin = new frmTelaLogin();
            telaLogin.Show();
            this.Hide();
        }


        private void btnAcessoSala_Click_1(object sender, EventArgs e)
        {
            pnlForm.Visible = false;
            frmAcessoSala acessoSala = new frmAcessoSala();
            acessoSala.Show();
            this.Hide();
        }


        private void btnCadastrarLoja_Click(object sender, EventArgs e)
        {
            VerificaFormAberto();
            pnlForm.Visible = true;
            frmCadastrarLojaAdmin cadastrarLojaAdmin = new frmCadastrarLojaAdmin();
            cadastrarLojaAdmin.TopLevel = false;
            pnlForm.Controls.Add(cadastrarLojaAdmin);
            cadastrarLojaAdmin.Show();
        }

        private void btnEditarLoja_Click(object sender, EventArgs e)
        {
            VerificaFormAberto();
            pnlForm.Visible = true;
            frmEditarLoja editarLoja = new frmEditarLoja();
            editarLoja.TopLevel = false;
            pnlForm.Controls.Add(editarLoja);
            editarLoja.Show();
        }



        private void btnExcluirloja_Click(object sender, EventArgs e)
        {
            VerificaFormAberto();
            pnlForm.Visible = true;
            frmExcluirLoja excluirLoja = new frmExcluirLoja();
            excluirLoja.TopLevel = false;
            pnlForm.Controls.Add(excluirLoja);
            excluirLoja.Show();
        }

        private void btnCadastrarFunc_Click(object sender, EventArgs e)
        {
            VerificaFormAberto();
            pnlForm.Visible = true;
            frmCadastrarFuncAdm cadastrarFunc = new frmCadastrarFuncAdm();
            cadastrarFunc.TopLevel = false;
            pnlForm.Controls.Add(cadastrarFunc);
            cadastrarFunc.Show();
        }

        private void btnEditarFunc_Click(object sender, EventArgs e)
        {
            VerificaFormAberto();
            pnlForm.Visible = true;
            frmEditarFunc editarFunc = new frmEditarFunc();
            editarFunc.TopLevel = false;
            pnlForm.Controls.Add(editarFunc);
            editarFunc.Show();
        }

        private void btnExcluirFunc_Click(object sender, EventArgs e)
        {
            VerificaFormAberto();
            pnlForm.Visible = true;
            frmExcluirFunc excluirFunc = new frmExcluirFunc();
            excluirFunc.TopLevel = false;
            pnlForm.Controls.Add(excluirFunc);
            excluirFunc.Show();
        }

        private void btnCadastrarSala_Click(object sender, EventArgs e)
        {
            VerificaFormAberto();
            pnlForm.Visible = true;
            frmCadastrarSala cadastrarSala = new frmCadastrarSala();
            cadastrarSala.TopLevel = false;
            pnlForm.Controls.Add(cadastrarSala);
            cadastrarSala.Show();
        }

        private void btnEditarSala_Click(object sender, EventArgs e)
        {
            VerificaFormAberto();
            pnlForm.Visible = true;
            frmEditarSala editarSala = new frmEditarSala();
            editarSala.TopLevel = false;
            pnlForm.Controls.Add(editarSala);
            editarSala.Show();
        }

        private void btnExcluirSala_Click(object sender, EventArgs e)
        {
            VerificaFormAberto();
            pnlForm.Visible = true;
            frmExcluirSala excluirSala = new frmExcluirSala();
            excluirSala.TopLevel = false;
            pnlForm.Controls.Add(excluirSala);
            excluirSala.Show();
        }

        private void btnEntrarnaSala_Click(object sender, EventArgs e)
        {
            VerificaFormAberto();
            pnlForm.Visible = true;
            frmEntrarNaSala entrarNaSala = new frmEntrarNaSala();
            entrarNaSala.TopLevel = false;
            pnlForm.Controls.Add(entrarNaSala);
            entrarNaSala.Show();
        }

        private void btnAcessoSala_Click(object sender, EventArgs e)
        {
            VerificaFormAberto();
            pnlForm.Visible = true;
            frmAcessoSala acessoSala = new frmAcessoSala();
            acessoSala.TopLevel = false;
            pnlForm.Controls.Add(acessoSala);
            acessoSala.Show();
        }

        private void VerificaFormAberto()
        {
            // Fechar Cadastro Loja
            frmCadastrarLojaAdmin cadastrarLojaAdmin = new frmCadastrarLojaAdmin();
            if (Application.OpenForms.OfType<frmCadastrarLojaAdmin>().Count() > 0)
            {
                Application.OpenForms[cadastrarLojaAdmin.Name].Close();
            }

            // Fecha Edição Loja
            frmEditarLoja editarLoja = new frmEditarLoja();
            if (Application.OpenForms.OfType<frmEditarLoja>().Count() > 0)
            {
                Application.OpenForms[editarLoja.Name].Close();
            }

            // Fecha Exclusão Loja
            frmExcluirLoja excluirLoja = new frmExcluirLoja();
            if (Application.OpenForms.OfType<frmExcluirLoja>().Count() > 0)
            {
                Application.OpenForms[excluirLoja.Name].Close();
            }

            //-------------------------------------------------------------------------------//

            // Fecha Cadastro Func
            frmCadastrarFuncAdm cadastrarFunc = new frmCadastrarFuncAdm();
            if (Application.OpenForms.OfType<frmCadastrarFuncAdm>().Count() > 0)
            {
                Application.OpenForms[cadastrarFunc.Name].Close();
            }

            // Fecha Edição Func
            frmEditarFunc editarFunc = new frmEditarFunc();
            if (Application.OpenForms.OfType<frmEditarFunc>().Count() > 0)
            {
                Application.OpenForms[editarFunc.Name].Close();
            }

            // Fecha Exclusão Func
            frmExcluirFunc excluirFunc = new frmExcluirFunc();
            if (Application.OpenForms.OfType<frmExcluirFunc>().Count() > 0)
            {
                Application.OpenForms[excluirFunc.Name].Close();
            }

            //-------------------------------------------------------------------------------//

            // Fecha Cadastro Sala
            frmCadastrarSala cadastrarSala = new frmCadastrarSala();
            if (Application.OpenForms.OfType<frmCadastrarSala>().Count() > 0)
            {
                Application.OpenForms[cadastrarSala.Name].Close();
            }

            // Fecha Edição Sala
            frmEditarSala editarSala = new frmEditarSala();
            if (Application.OpenForms.OfType<frmEditarSala>().Count() > 0)
            {
                Application.OpenForms[editarSala.Name].Close();
            }

            // Fecha Exclusão Sala
            frmExcluirSala excluirSala = new frmExcluirSala();
            if (Application.OpenForms.OfType<frmExcluirSala>().Count() > 0)
            {
                Application.OpenForms[excluirSala.Name].Close();
            }

            // Fecha Entrar na Sala
            frmEntrarNaSala entrarNaSala = new frmEntrarNaSala();
            if (Application.OpenForms.OfType<frmEntrarNaSala>().Count() > 0)
            {
                Application.OpenForms[entrarNaSala.Name].Close();
            }

            //-------------------------------------------------------------------------------//

            // Fecha Acesso a Sala
            frmAcessoSala acessoSala = new frmAcessoSala();
            if (Application.OpenForms.OfType<frmAcessoSala>().Count() > 0)
            {
                Application.OpenForms[acessoSala.Name].Close();
            }
        }

        
    }
}
