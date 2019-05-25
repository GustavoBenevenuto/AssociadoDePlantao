using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AssociadoDePlantao
{
    public class ClassContato
    {
        public int codContato { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string conplemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string pais { get; set; }
        public string telFixo { get; set; }
        public string celular { get; set; }
        public string email { get; set; }

        AcessoBD bd = new AcessoBD();

        public bool Inserir(ClassContato contato)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("INSERT INTO Contato VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", contato.endereco, contato.numero, contato.conplemento, contato.bairro, contato.cidade, contato.estado, contato.pais, contato.telFixo, contato.celular, contato.email));
            bd.Desconectar();
            return true;
        }

        public bool Editar(int codContatoClicado, ClassContato contato)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("UPDATE Contato SET endereco = '{0}', numero = '{1}', complemento = '{2}', bairro = '{3}', cidade = '{4}', estado = '{5}', pais = '{6}', telFixo = '{7}', celular = '{8}', email = '{9}' WHERE codContato = '{10}'", contato.endereco, contato.numero, contato.conplemento, contato.bairro, contato.cidade, contato.estado, contato.pais, contato.telFixo, contato.celular, contato.email, codContatoClicado));
            bd.Desconectar();
            return true;
        }

        public bool Excluir(int codContatoClicado)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("DELETE Contato WHERE codContato = '{0}'", codContatoClicado));
            bd.Desconectar();
            return true;
        }

        public DataTable RetTodosContatos()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Contato"));
            bd.Desconectar();
            return dt;
        }


        public DataTable RetContatoPorNome(string estadoBuscado)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Contato WHERE estado LIKE '%{0}%'", estadoBuscado));
            bd.Desconectar();
            return dt;
        }

        public int RetMaxCodContato()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT MAX(codContato) AS 'codContato' FROM Contato"));
            int cod = int.Parse(dt.Rows[0]["codContato"].ToString());
            if(dt.Rows.Count == 0)
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
    }
}
