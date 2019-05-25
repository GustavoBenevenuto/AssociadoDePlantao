using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace AssociadoDePlantao
{
    public class QuemEstaLogado
    {
        public string UsuarioLogado { get; set; }

        AcessoBD bd = new AcessoBD();

        public bool Editar(string usuario)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("UPDATE QuemEstaLogado SET usuario = '{0}'", usuario));
            return true;
        }


        public string RetQuemEstaLogado()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT usuario AS 'usuario' FROM QuemEstaLogado"));

            string usuario = dt.Rows[0]["usuario"].ToString();
            bd.Desconectar();
            return usuario;
        }

        public int RetFKQuemEstaLogado(string nome)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT codFuncionario AS 'FK' FROM Funcionario WHERE loginFunc = '{0}'", nome));

            int usuario = int.Parse(dt.Rows[0]["FK"].ToString());
            bd.Desconectar();
            return usuario;
        }
    }
}
