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
    public partial class frmTelaGerente : Form
    {
        QuemEstaLogado user = new QuemEstaLogado();
        ClassFuncionario func = new ClassFuncionario();

        public frmTelaGerente()
        {
            InitializeComponent();
        }

        private void frmTelaGerente_Load(object sender, EventArgs e)
        {
            lblQuemLogou.Text = user.RetQuemEstaLogado();
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");

            // ----------------------------- FUNC -------------------------------- //
            btnCadastrarFunc.Visible = false;
            btnEditarFunc.Visible = false;
            btnExcluirFunc.Visible = false;

            // ----------------------------- SALA -------------------------------- //
            btnCadastrarSala.Visible = false;
            btnEditarSala.Visible = false;
            btnExcluirSala.Visible = false;
            btnEntrar.Visible = false;
        }

        int clickFunc = 0;
        private void btnMenuFuncionario_Click_1(object sender, EventArgs e)
        {
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
            if (clickSala == 0)
            {
                btnCadastrarSala.Visible = true;
                btnEditarSala.Visible = true;
                btnExcluirSala.Visible = true;
                btnEntrar.Visible = true;
                clickSala++;
            }
            else
            {
                btnCadastrarSala.Visible = false;
                btnEditarSala.Visible = false;
                btnExcluirSala.Visible = false;
                btnEntrar.Visible = false;
                clickSala = 0;
            }
        }

        private void btnCadastrarFunc_Click(object sender, EventArgs e)
        {
            VerificaFormAberto();
            frmCadastrarFuncAdm cadastrarFunc = new frmCadastrarFuncAdm();
            if (Application.OpenForms.OfType<frmCadastrarFuncAdm>().Count() > 0)
            {
                Application.OpenForms[cadastrarFunc.Name].Focus();
            }
            else
            {
                cadastrarFunc.Show();
                cadastrarFunc.DesktopLocation = new Point(629, 288);
            }
        }

        private void btnEditarFunc_Click(object sender, EventArgs e)
        {
            VerificaFormAberto();
            frmEditarFunc editarFunc = new frmEditarFunc();
            if (Application.OpenForms.OfType<frmEditarFunc>().Count() > 0)
            {
                Application.OpenForms[editarFunc.Name].Focus();
            }
            else
            {
                editarFunc.Show();
                editarFunc.DesktopLocation = new Point(629, 288);
            }
        }

        private void btnExcluirFunc_Click(object sender, EventArgs e)
        {
            VerificaFormAberto();
            frmExcluirFunc excluirFunc = new frmExcluirFunc();
            if (Application.OpenForms.OfType<frmExcluirFunc>().Count() > 0)
            {
                Application.OpenForms[excluirFunc.Name].Focus();
            }
            else
            {
                excluirFunc.Show();
                excluirFunc.DesktopLocation = new Point(629, 288);
            }
        }

        private void btnCadastrarSala_Click(object sender, EventArgs e)
        {
            VerificaFormAberto();
            frmCadastrarSala cadastrarSala = new frmCadastrarSala();
            if (Application.OpenForms.OfType<frmCadastrarSala>().Count() > 0)
            {
                Application.OpenForms[cadastrarSala.Name].Focus();
            }
            else
            {
                cadastrarSala.Show();
                cadastrarSala.DesktopLocation = new Point(629, 288);
            }
        }

        private void btnEditarSala_Click(object sender, EventArgs e)
        {
            VerificaFormAberto();
            frmEditarSala editarSala = new frmEditarSala();
            if (Application.OpenForms.OfType<frmEditarSala>().Count() > 0)
            {
                Application.OpenForms[editarSala.Name].Focus();
            }
            else
            {
                editarSala.Show();
                editarSala.DesktopLocation = new Point(629, 288);
            }
        }

        private void btnExcluirSala_Click(object sender, EventArgs e)
        {
            VerificaFormAberto();
            frmExcluirSala excluirSala = new frmExcluirSala();
            if (Application.OpenForms.OfType<frmExcluirSala>().Count() > 0)
            {
                Application.OpenForms[excluirSala.Name].Focus();
            }
            else
            {
                excluirSala.Show();
                excluirSala.DesktopLocation = new Point(629, 288);
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            VerificaFormAberto();
            frmEntrarNaSala entrarNaSala = new frmEntrarNaSala();
            if (Application.OpenForms.OfType<frmEntrarNaSala>().Count() > 0)
            {
                Application.OpenForms[entrarNaSala.Name].Focus();
            }
            else
            {
                entrarNaSala.Show();
                entrarNaSala.DesktopLocation = new Point(629, 288);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            VerificaFormAberto();
            frmTelaLogin telaLogin = new frmTelaLogin();
            telaLogin.Show();
            this.Hide();
        } 

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            dgvFunc.DataSource = func.RetCodNomeCpfPorNome(txtNome.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void VerificaFormAberto()
        {
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
        }
    }
}
