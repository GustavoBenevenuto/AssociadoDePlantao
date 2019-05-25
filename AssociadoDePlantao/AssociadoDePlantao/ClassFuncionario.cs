using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace AssociadoDePlantao
{
    public class ClassFuncionario
    {
        public int condFuncionario { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string dataNasc { get; set; }
        public int tipoFuncionario { get; set; }
        public string loginFunc { get; set; }
        public string senha { get; set; }
        public int statusFunc { get; set; }
        public int CONTATO_codContato { get; set; }
        public int FUNC_codFuncResp { get; set; }

        AcessoBD bd = new AcessoBD();

        public bool Inserir(ClassFuncionario func)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("INSERT INTO Funcionario VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", func.nome, func.cpf, func.dataNasc, func.tipoFuncionario, func.loginFunc, func.senha, func.statusFunc, func.CONTATO_codContato, func.FUNC_codFuncResp));
            bd.Desconectar();
            return true;
        }

        public bool Editar(int codFuncClicado, ClassFuncionario func)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("UPDATE Funcionario SET nome = '{0}', cpf = '{1}', dataNasc = '{2}', tipoFuncionario = '{3}', loginFunc = '{4}', senha = '{5}', statusFunc = '{6}', CONTATO_codContato = '{7}', FUNC_codFuncResp = '{8}' WHERE codFuncionario = '{9}'", func.nome, func.cpf, func.dataNasc, func.tipoFuncionario, func.loginFunc, func.senha, func.statusFunc, func.CONTATO_codContato, func.FUNC_codFuncResp, codFuncClicado));
            bd.Desconectar();
            return true;

        }

        public bool Excluir(int codFuncClicado)
        {
            ClassFuncLoja_Trabalha_ funcLoja = new ClassFuncLoja_Trabalha_();
            ClassLoja loja = new ClassLoja();
            ClassSala sala = new ClassSala();
            ClassRelatorioAcesso relatorio = new ClassRelatorioAcesso();
            
            bd.Conectar();
            //Os se's servem para verificar se na há FK na tabela onde se desja excluir
            if (sala.RetAcessoSalaExiste(codFuncClicado) == true)
            {
                bd.ExecutarComandosSql(String.Format("DELETE FuncLoja WHERE FUNC_codFuncResp = '{0}'", codFuncClicado));
            }
            if (funcLoja.RetFuncExiste(codFuncClicado) == true)
            {
                bd.ExecutarComandosSql(String.Format("DELETE FuncLoja WHERE FUNC_codFuncResp = '{0}'", codFuncClicado));
            }
            if(loja.RetFKFuncExiste(codFuncClicado) == true)
            {
                bd.ExecutarComandosSql(String.Format("DELETE Loja WHERE FUNC_codFuncResp = '{0}'", codFuncClicado));
            }
            if(sala.RetFKFuncExiste(codFuncClicado) == true)
            {
                bd.ExecutarComandosSql(String.Format("DELETE Sala WHERE FUNC_codFuncResp = '{0}'", codFuncClicado));
            }
            if(relatorio.RetFKFuncExiste(codFuncClicado) == true)
            {
                bd.ExecutarComandosSql(String.Format("DELETE RelatorioAcesso WHERE FUNC_codFuncResp = '{0}'", codFuncClicado));
            }

            DataTable dt = bd.RetDataTable(String.Format("SELECT CONTATO_codContato FROM Funcionario WHERE codFuncionario = '{0}'", codFuncClicado));
            int codContato = int.Parse(dt.Rows[0]["CONTATO_codContato"].ToString());

            bd.ExecutarComandosSql(String.Format("DELETE Funcionario WHERE codFuncionario = '{0}'", codFuncClicado));
            bd.Desconectar();
            //bd.Conectar();
            //bd.ExecutarComandosSql(String.Format("DELETE Contato WHERE codContato = '{0}'", codContato));
            //bd.Desconectar();
            return true;
        }


        public bool VerificarLogin(string loginExisteOuNao)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT loginFunc FROM Funcionario WHERE loginFunc = '{0}'", loginExisteOuNao));
            bd.Desconectar();
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool BloqueandoFunc(string nome)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("UPDATE Funcionario SET statusFunc = '{0}' WHERE loginFunc = '{1}'", 0, nome));
            bd.Desconectar();
            return true;

        }

        public int RetSatusFunc(string nome)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT statusFunc FROM Funcionario WHERE loginFunc = '{0}'", nome));
            if (dt.Rows.Count > 0)
            {
                int statusFunc = int.Parse(dt.Rows[0]["statusFunc"].ToString());
                bd.Desconectar();
                return statusFunc;
            }
            else
            {
                bd.Desconectar();
                return 1;
            }

        }

        public int RetTipoFunc(string nome)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT tipoFuncionario FROM Funcionario WHERE loginFunc = '{0}'", nome));
            int tipoFuncionario = int.Parse(dt.Rows[0]["tipoFuncionario"].ToString());
            bd.Desconectar();
            return tipoFuncionario;
        }

        public bool Logar(ClassFuncionario func)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT loginFunc, senha FROM Funcionario WHERE loginFunc = '{0}' AND senha = '{1}'", func.loginFunc, func.senha));
            bd.Desconectar();
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable RetTodosFunc()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Funcionario"));
            bd.Desconectar();
            return dt;
        }

        public DataTable RetTodosFuncGerente()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Funcionario WHERE codFuncionario > 1"));
            bd.Desconectar();
            return dt;
        }

        public DataTable RetFuncionarioPorNome(string nomeBuscado)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Funcionario WHERE nome LIKE '%{0}%'", nomeBuscado));
            bd.Desconectar();
            return dt;
        }

        
        public int RetMaxCodFunc()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT MAX(codFuncionario) AS 'codFunc' FROM Funcionario"));
            int cod = int.Parse(dt.Rows[0]["codFunc"].ToString());
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

        public bool RetCodFuncExiste(int codFunc)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT codFuncionario FROM Funcionario WHERE codFuncionario = '{0}' AND tipoFuncionario <> 3", codFunc));
            bd.Desconectar();
            if(dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int RetTotalFunc()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT COUNT(codFuncionario) AS 'TotalFunc' FROM Funcionario"));
            bd.Desconectar();
            int totalFunc = int.Parse(dt.Rows[0]["TotalFunc"].ToString());
            return totalFunc;
        }

        public int RetTotalGerente()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT COUNT(codFuncionario) AS 'TotalGerente' FROM Funcionario WHERE tipoFuncionario = 2"));
            bd.Desconectar();
            int totalFunc = int.Parse(dt.Rows[0]["TotalGerente"].ToString());
            return totalFunc;
        }

        public int RetTotalBlock()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT COUNT(codFuncionario) AS 'TotalBlock' FROM Funcionario WHERE statusFunc = 0"));
            bd.Desconectar();
            int totalFunc = int.Parse(dt.Rows[0]["TotalBlock"].ToString());
            return totalFunc;
        }

        public DataTable RetCodNomeCpfPorNome(string nomeBuscado)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT codFuncionario, nome, cpf FROM Funcionario WHERE nome LIKE '%{0}%' AND codFuncionario <> 1", nomeBuscado));
            bd.Desconectar();
            return dt;
        }

        public DataTable RetCodFuncNome()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT codFuncionario AS 'codFuncionario', nome AS 'nome' FROM Funcionario"));
            bd.Desconectar();
            return dt;
        }

    }
}
