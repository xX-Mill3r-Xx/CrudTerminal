using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudConsole.Conection
{
    public class ConnectionDB
    {
        public string ConectionDataBase(string connection)
        {
            MySqlConnection str = new MySqlConnection(connection);
            try
            {
                str.Open();
                Console.WriteLine("Conectado - Base de dados - MySql");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel estabelecer uma conexão!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                
                str.Close();
            }
            return connection;
        }

        public string CreateDataBase(string connection, char resp)
        {
            MySqlConnection str = new MySqlConnection(connection);
            try
            {
                str.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = str;
                command.CommandText = "CREATE DATABASE IF NOT EXISTS teste_db";
                command.ExecuteNonQuery();
                Console.WriteLine("Base de dados criada com sucesso!");
                command.Dispose();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                str.Close();
                str.Dispose();
            }
            return connection;
        }
    }
}
