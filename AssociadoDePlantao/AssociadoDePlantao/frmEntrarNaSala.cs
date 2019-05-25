using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace AssociadoDePlantao
{
    public partial class frmEntrarNaSala : Form
    {
        ClassSala sala = new ClassSala();
        ClassRelatorioAcesso relatorio = new ClassRelatorioAcesso();
        QuemEstaLogado user = new QuemEstaLogado();
        ClassFuncionario func = new ClassFuncionario();


        int fkFunc;

        public frmEntrarNaSala()
        {
            InitializeComponent();
        }

        private void frmEntrarNaSala_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblUser.Text = user.RetQuemEstaLogado();
            fkFunc = user.RetFKQuemEstaLogado(lblUser.Text);
            dgvAcessoSala.DataSource = sala.RetAcessoSalaPorUsuario(lblUser.Text);

            if (user.RetQuemEstaLogado() == "ADMIN" || func.RetTipoFunc(user.RetQuemEstaLogado()) == 2)
            {
                pnlFecha.Visible = false;
            }
            else
            {
                pnlFecha.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtSala.Text != "")
            {
                relatorio.dataAcesso = lblData.Text;
                relatorio.horaAcesso = lblHora.Text;
                relatorio.FUNC_codFuncResp = fkFunc;
                relatorio.SALA_codSala = int.Parse(txtSala.Text);
                relatorio.Inserir(relatorio);
                MessageBox.Show("Você entrou na sala", "ENTROU");
            }
            else
            {
                MessageBox.Show("Você não tem acesso a nenhuma sala, ou você não selecionou nenhuma sala");
            }
        }

        private void txtSala_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar))
                && !(e.KeyChar == (char)Keys.Enter)
                && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void dgvAcessoSala_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtSala.Text = dgvAcessoSala.Rows[e.RowIndex].Cells["Id Sala"].Value.ToString();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmTelaLogin telaLogin = new frmTelaLogin();
            telaLogin.Show();
            this.Hide();
        }
    }
}
