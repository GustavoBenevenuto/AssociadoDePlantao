using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AssociadoDePlantao
{
    public class ClassLoja
    {
        public int codLoja { get; set; }
        public string razaoSocial { get; set; }
        public string nomeFantasia { get; set; }
        public string cpnj { get; set; }
        public string siteLoja{ get; set; }
        public string inauguracao { get; set; }
        public string tipoLoja { get; set; }
        public int CONTATO_codContato { get; set; }
        public int FUNC_codFuncResp { get; set; }

        AcessoBD bd = new AcessoBD();
        ClassFuncLoja_Trabalha_ FuncLoja = new ClassFuncLoja_Trabalha_();
        ClassSala sala = new ClassSala();


        public bool Inserir(ClassLoja loja)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("INSERT INTO Loja VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", loja.razaoSocial, loja.nomeFantasia, loja.cpnj, loja.siteLoja, loja.inauguracao, loja.tipoLoja, loja.CONTATO_codContato, loja.FUNC_codFuncResp));
            return true;
        }

        public bool Editar(int codLojaClicado, ClassLoja loja)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("UPDATE Loja SET razaoSocial = '{0}', nomeFantasia = '{1}', cpnj = '{2}', siteLoja = '{3}', inauguracao = '{4}', tipoLoja = '{5}', CONTATO_codContato = '{6}', FUNC_codFuncResp = '{7}' WHERE codLoja = '{8}'", loja.razaoSocial, loja.nomeFantasia, loja.cpnj, loja.siteLoja, loja.inauguracao, loja.tipoLoja, loja.CONTATO_codContato, loja.FUNC_codFuncResp, codLojaClicado));
            bd.Desconectar();
            return true;

        }

        public bool Excluir(int codLojaClicado)
        {
            bd.Conectar();
            if(FuncLoja.RetLojaExiste(codLojaClicado) == true)
            {
                bd.ExecutarComandosSql(String.Format("DELETE FuncLoja WHERE LOJA_codLoja = '{0}'", codLojaClicado));
            }

            if(sala.RetFKLojaExiste(codLojaClicado) == true)
            {
                bd.ExecutarComandosSql(String.Format("DELETE Sala WHERE LOJA_codLoja = '{0}'", codLojaClicado));
            }
            //bd.ExecutarComandosSql(String.Format("DELETE Contato WHERE codContato = (SELECT CONTATO_codContato FROM Funcionario WHERE codFuncionario = '{0}')", codLojaClicado));
            bd.ExecutarComandosSql(String.Format("DELETE Loja WHERE codLoja = '{0}'", codLojaClicado));
            bd.Desconectar();
            return true;
        }

        public DataTable RetTodasLoja()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Loja"));
            bd.Desconectar();
            return dt;
        }


        public DataTable RetLojaPorNome(string nomeBuscado)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Loja WHERE nomeFantasia LIKE '%{0}%'", nomeBuscado));
            bd.Desconectar();
            return dt;
        }

        public bool RetFuncRespExiste(int codFuncResp)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT codFuncionario FROM Funcionario WHERE codFuncionario = '{0}'", codFuncResp));
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

        public bool RetCodLojaExiste(int codLoja)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT codLoja FROM Loja WHERE codLoja = '{0}'", codLoja));
            bd.Desconectar();
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool RetFKFuncExiste(int codFunc)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT FUNC_codFuncResp FROM Loja WHERE FUNC_codFuncResp = '{0}'", codFunc));
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

        public int RetTotalLojas()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT COUNT(codLoja) AS 'TotalLoja' FROM Loja"));
            bd.Desconectar();
            int total = int.Parse(dt.Rows[0]["TotalLoja"].ToString());
            return total;
        }

        public int RetTotalLojasMatriz()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT COUNT(codLoja) AS 'TotalLoja' FROM Loja WHERE tipoLoja = 'Matriz'"));
            bd.Desconectar();
            int total = int.Parse(dt.Rows[0]["TotalLoja"].ToString());
            return total;
        }

    }
}
