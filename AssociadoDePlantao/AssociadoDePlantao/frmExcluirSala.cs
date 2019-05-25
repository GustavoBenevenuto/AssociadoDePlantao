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
    public partial class frmExcluirSala : Form
    {
        ClassSala sala = new ClassSala();
        QuemEstaLogado user = new QuemEstaLogado();

        int codSalaClicado;
        public frmExcluirSala()
        {
            InitializeComponent();
        }

        private void frmExcluirSala_Load(object sender, EventArgs e)
        {
            dvgSalas.DataSource = sala.RetTodasSala();
        }

        private void dvgSalas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgSalas.Rows[e.RowIndex].Cells["codSala"].Value.ToString() != "")
            {
                codSalaClicado = int.Parse(dvgSalas.Rows[e.RowIndex].Cells["codSala"].Value.ToString());
            }
            lblCodSala.Text = codSalaClicado.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja mesmo excluir?", "!Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                sala.Excluir(codSalaClicado);
                MessageBox.Show("Sala excluída com sucesso!");
                dvgSalas.DataSource = sala.RetTodasSala();
            }

        }
    }
}
