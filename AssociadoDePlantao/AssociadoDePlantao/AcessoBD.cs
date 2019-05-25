using System;
using System.Data; //1º Passo: Importar bibliotecas 
using System.Data.SqlClient; //de banco de dados


namespace AssociadoDePlantao
{
    public class AcessoBD
    {
        //2º Passo: Criação dos Objetos
        private SqlConnection con; //Responsável pela conexão com o bd
        private SqlDataAdapter da; //Responsável pela execução do comando select       
        private SqlCommand cmd; //Responsável pela execução do SELECT/INSERT/UPDATE/DELETE
        private DataTable dt; //Reponsável por retornar o resultado de um select

        //3º Passo: Definindo os parâmetros para criar string de conexão 
        private string server = @"GUSTAVO-PC";// nome do servidor sqlServer
        private string database = "BdAssociadosPlantao"; //nome do bd

        //private string server = @"LAB603-20";// nome do servidor sqlServer
        //private string database = "BdAssociadosPlantao"; //nome do bd

        //4º Método: CONECTAR
        public void Conectar()
        {
            if (con != null) //Verifica se conexão já está aberta
                con.Close(); //fecha a conexão

            //Define a string de conexão
            string conStr = String.Format("server={0}; Initial Catalog={1};Integrated Security=SSPI", server, database);

            try
            {
                con = new SqlConnection(conStr); //Recebe a string de conexão para conectar ao banco
                con.Open(); // abre a conexão
            }
            catch (Exception ex)
            {
                //Retorna mensagem ao usuário
                throw new Exception(ex.Message); // Retorna mensagem de erro ao usuário
            }

        }

        //5º Passo: Criando o Método para executar comandos INSERT/UPDATE/DELETE
        public void ExecutarComandosSql(string comandoSql)
        {
            try
            {
                cmd = new SqlCommand(comandoSql, con); //Informa qual comando executar em qual conexão
                cmd.ExecuteNonQuery(); //Executa o comando acima no bd
                con.Close();
            }
            catch (Exception ex)
            {
                //Retorna mensagem ao usuário
                throw new Exception(ex.Message); // Retorna mensagem de erro ao usuário
            }

        }

        //6º Passo: Criando o Método para executar comandos SELECT
        public DataTable RetDataTable(string sql)
        {
            try
            {
                dt = new DataTable();
                da = new SqlDataAdapter(sql, con); //Preenche o adapter com comando sql
                da.Fill(dt); //Preenche o objeto dt com os dados retornados do select
                return dt; //Retorna o dataTable   
            }
            catch (Exception ex)
            {
                //Retorna mensagem ao usuário
                throw new Exception(ex.Message); // Retorna mensagem de erro ao usuário
            }

        }

        public void Desconectar()
        {
            //Define a string de conexão
            string conStr = String.Format("server={0}; Initial Catalog={1};Integrated Security=SSPI", server, database);

            try
            {
                con = new SqlConnection(conStr); //Recebe a string de conexão para conectar ao banco
                con.Close(); // fecha a conexão
            }
            catch (Exception ex)
            {
                //Retorna mensagem ao usuário
                throw new Exception(ex.Message); // Retorna mensagem de erro ao usuário
            }
        }

    }

}
