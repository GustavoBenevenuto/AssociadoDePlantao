using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AssociadoDePlantao
{
    public class ClassRelatorioAcesso
    {
        public int codRelatorio { get; set; }
        public string dataAcesso { get; set; }
        public string horaAcesso { get; set; }
        public int FUNC_codFuncResp { get; set; }
        public int SALA_codSala { get; set; }

        AcessoBD bd = new AcessoBD();

        public bool Inserir(ClassRelatorioAcesso relatorio)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("INSERT INTO RelatorioAcesso VALUES ('{0}','{1}','{2}','{3}')", relatorio.dataAcesso, relatorio.horaAcesso, relatorio.FUNC_codFuncResp, relatorio.SALA_codSala));
            return true;
        }

        public bool Editar(int codRelatorioClicado, ClassRelatorioAcesso relatorio)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("UPDATE RelatorioAcesso SET dataAcesso = '{0}', horaAcesso = '{1}', FUNC_codFuncResp = '{2}', SALA_codSala = '{3}',  WHERE codRelatorio = '{4}'", relatorio.dataAcesso, relatorio.horaAcesso, relatorio.FUNC_codFuncResp, relatorio.SALA_codSala, codRelatorioClicado));
            bd.Desconectar();
            return true;

        }

        public bool Excluir(int codRelatorioClicado)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("DELETE RelatorioAcesso WHERE codRelatorio = '{0}'", codRelatorioClicado));
            bd.Desconectar();
            return true;
        }

        public DataTable RetTodosRelatorios()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM RelatorioAcesso"));
            bd.Desconectar();
            return dt;
        }


        public DataTable RetRelatorioPorData(string data)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM RelatorioAcesso WHERE dataAcesso = '%{0}%'", data));
            bd.Desconectar();
            return dt;
        }

        public bool RetFKFuncExiste(int codFunc)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT FUNC_codFuncResp FROM RelatorioAcesso WHERE FUNC_codFuncResp = '{0}'", codFunc));
            if (dt.Rows.Count > 0)
            {
                bd.Desconectar();
                return true;
            }
            else
            {
                bd.Desconectar();
                return false;
            }
        }

        public bool RetFKSalaExiste(int codSala)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT SALA_codSala FROM RelatorioAcesso WHERE SALA_codSala = '{0}'", codSala));
            if (dt.Rows.Count > 0)
            {
                bd.Desconectar();
                return true;
            }
            else
            {
                bd.Desconectar();
                return false;
            }

        }

    }
}
