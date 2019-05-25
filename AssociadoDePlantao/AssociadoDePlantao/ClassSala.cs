using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AssociadoDePlantao
{
    public class ClassSala
    {
        public int codSala { get; set; }
        public string descricao { get; set; }
        public int LOJA_codLoja { get; set; }
        public int FUNC_codFuncResp { get; set; }

        AcessoBD bd = new AcessoBD();

        public bool Inserir(ClassSala sala)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("INSERT INTO Sala VALUES ('{0}', '{1}', '{2}')", sala.descricao, sala.LOJA_codLoja, sala.FUNC_codFuncResp));
            bd.Desconectar();
            return true;
        }

        public bool Editar(string desc, int codSalaClicada)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("UPDATE Sala SET descricao = '{0}' WHERE codSala = '{1}'", desc, codSalaClicada));
            bd.Desconectar();
            return true;

        }

        public bool Excluir(int codSalaClicado)
        {
            ClassRelatorioAcesso relatorio = new ClassRelatorioAcesso();

            bd.Conectar();
            if (relatorio.RetFKSalaExiste(codSalaClicado) == true)
            {
                bd.ExecutarComandosSql(String.Format("DELETE RelatorioAcesso WHERE SALA_codSala = '{0}'", codSalaClicado));
            }
            bd.Desconectar();

            bd.Conectar();
            if (RetFKSalaExisteAcessoSala(codSala) == true)
            {
                bd.ExecutarComandosSql(String.Format("DELETE AcessoSala WHERE SALA_codSala = '{0}'", codSalaClicado));
            }
            bd.Desconectar();

            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("DELETE Sala WHERE codSala = '{0}'", codSalaClicado));
            bd.Desconectar();
            return true;
        }

        public bool RetFKSalaExisteAcessoSala(int codSala)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT SALA_codSala FROM AcessoSala WHERE SALA_codSala = '{0}'", codSala));
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

        public DataTable RetTodasSala()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Sala"));
            bd.Desconectar();
            return dt;
        }

        public DataTable RetSalaPorNome(int codSalaClicado)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Sala WHERE codSala = '%{0}%'", codSalaClicado));
            bd.Desconectar();
            return dt;
        }

        public string RetMaxCodSala()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT MAX(codSala) AS 'codSala' FROM Sala"));
            string cod = dt.Rows[0]["codSala"].ToString();
            if (dt.Rows.Count > 0)
            {
                bd.Desconectar();
                return cod;
            }
            else
            {
                bd.Desconectar();
                return "0";
            }
        }

        public bool RetFKLojaExiste(int codLoja)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT LOJA_codLoja FROM Sala WHERE LOJA_codLoja = '{0}'", codLoja));
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


        public bool RetFKFuncExiste(int codFunc)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT FUNC_codFuncResp FROM Sala WHERE FUNC_codFuncResp = '{0}'", codFunc));
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

        public bool RetSalaExiste(int codSala)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT codSala AS 'codSala' FROM Sala WHERE codSala = '{0}'", codSala));
            if (dt.Rows.Count == 0)
            {
                bd.Desconectar();
                return false;
            }
            else
            {
                bd.Desconectar();
                return true;
            }
        }

        public int RetTotalSala()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT COUNT(codSala) AS 'codSala' FROM Sala"));
            int cod = int.Parse(dt.Rows[0]["codSala"].ToString());
            if (dt.Rows.Count == 0)
            {
                bd.Desconectar();
                return 0;
            }
            else
            {
                bd.Desconectar();
                return cod;
            }
        }

        public DataTable RetSalaDescricao()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT codSala AS 'codSala', descricao AS 'descricao' FROM Sala"));
            bd.Desconectar();
            return dt;
        }

        public DataTable RetAcessoSala()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM AcessoSala"));
            bd.Desconectar();
            return dt;
        }

        public DataTable RetAcessoSalaPorUsuario(string user)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT FUNC_codFuncResp AS 'Id Funcionário', SALA_codSala AS 'Id Sala' FROM AcessoSala WHERE FUNC_codFuncResp = (SELECT codFuncionario FROM Funcionario WHERE loginFunc = '{0}')", user));
            bd.Desconectar();
            return dt;
        }

        public bool LiberarAcesso(int codFunc, int codSala) //Libera Acesso A SALAS
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("INSERT INTO AcessoSala VALUES ('{0}', '{1}')", codFunc, codSala));
            bd.Desconectar();
            return true;
        }

        public bool BloqueaAcesso(int codAcessoSala) //Libera Acesso A SALAS
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("DELETE FROM AcessoSala WHERE codAcesso = '{0}'", codAcessoSala));
            bd.Desconectar();
            return true;
        }

        public bool RetAcessoSalaExiste(int codFunc)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT FUNC_codFuncResp FROM AcessoSala WHERE FUNC_codFuncResp = '{0}'", codFunc));
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
