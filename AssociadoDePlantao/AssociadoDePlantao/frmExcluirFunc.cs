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
    public partial class frmExcluirFunc : Form
    {
        ClassFuncionario func = new ClassFuncionario();
        QuemEstaLogado user = new QuemEstaLogado();

        int codFuncClicado;
        public frmExcluirFunc()
        {
            InitializeComponent();
        }

        private void frmExcluirFunc_Load(object sender, EventArgs e)
        {
            if (user.RetQuemEstaLogado() == "ADMIN")
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
            if (dgvFunc.Rows[e.RowIndex].Cells["codFuncionario"].Value.ToString() != "")
            {
                codFuncClicado = int.Parse(dgvFunc.Rows[e.RowIndex].Cells["codFuncionario"].Value.ToString());
            }
            lblCodFunc.Text = codFuncClicado.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja mesmo excluir?", "!Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resultado == DialogResult.Yes)
            {
                if(codFuncClicado != 1)
                {
                    func.Excluir(codFuncClicado);
                    MessageBox.Show("Cliente excluído com sucesso!");
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
                    MessageBox.Show("Não pode excluir o administrador");
                }            
            }
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
