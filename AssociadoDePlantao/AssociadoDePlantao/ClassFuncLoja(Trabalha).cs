using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AssociadoDePlantao
{
    public class ClassFuncLoja_Trabalha_
    {
        AcessoBD bd = new AcessoBD();
        public int FUNC_codFuncResp { get; set; }
        public int LOJA_codLoja { get; set; }

        public DataTable RetTodasFuncLoja()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM FuncLoja"));
            bd.Desconectar();
            return dt;
        }

        public bool RetLojaExiste(int codLoja)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT LOJA_codLoja FROM FuncLoja WHERE LOJA_codLoja = '{0}'", codLoja));
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

        public bool RetFuncExiste(int codFunc)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT FUNC_codFuncResp FROM FuncLoja WHERE FUNC_codFuncResp = '{0}'", codFunc));
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
