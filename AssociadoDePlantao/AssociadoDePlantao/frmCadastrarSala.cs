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
    public partial class frmCadastrarSala : Form
    {
        ClassLoja loja = new ClassLoja();
        ClassFuncionario func = new ClassFuncionario();
        ClassSala sala = new ClassSala();
        QuemEstaLogado user = new QuemEstaLogado();

        public frmCadastrarSala()
        {
            InitializeComponent();
        }

        private void btnMenuSala_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Só números
            if (!(char.IsNumber(e.KeyChar))
                && !(e.KeyChar == (char)Keys.Enter)
                && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar))
                && !(e.KeyChar == (char)Keys.Enter)
                && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCodFunc.Text != "" && txtCodLoja.Text != "" && txtDescricao.Text != "")
            {
                if (loja.RetCodLojaExiste(int.Parse(txtCodLoja.Text)) == true && func.RetCodFuncExiste(int.Parse(txtCodFunc.Text)) == true)
                {
                    sala.descricao = txtDescricao.Text;
                    sala.LOJA_codLoja = int.Parse(txtCodLoja.Text);
                    sala.FUNC_codFuncResp = int.Parse(txtCodFunc.Text);

                    if (sala.Inserir(sala) == true)
                    {
                        MessageBox.Show("Sala cadastrada com sucesso!");
                    }
                }
                else
                {
                    MessageBox.Show("Loja ou funcionário não existem!");
                }
            }
            else
            {
                MessageBox.Show("Preencha os dados!");
            }
        }

        private void frmCadastrarSala_Load(object sender, EventArgs e)
        {
            lblCod.Text = (sala.RetMaxCodSala() + 1).ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar))
                && !(e.KeyChar == (char)Keys.Enter)
                && !(e.KeyChar == (char)Keys.Back)
                && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

 
    }
}
