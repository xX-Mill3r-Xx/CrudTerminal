using System;
using CrudConsole.Conection;
using MySql.Data.MySqlClient;
using System.IO;

namespace CrudConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Definicoes do console
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Title = "Crud Console";
            Console.Clear();
            #endregion
            /**/
            string strConnection1 = "server=127.0.0.1;User Id=root;password=a123654b";
            bool databaseRead = false;
            string basedados = "teste_db";
            //string strConnection2 = "server=127.0.0.1;User Id=root; darabase=teste_db;password=a123654b";

            ConnectionDB db = new ConnectionDB();
            db.ConectionDataBase(strConnection1);
            Console.WriteLine();
            Inicio:
            Console.WriteLine("Opção 1: Crirar Tabela");
            Console.WriteLine("Opção 2: Inserir Registros");
            Console.WriteLine();
            Console.Write("Entre com a opção desejada: ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                #region Criar base de dados
                case 1:
                    Console.Write("Deseja criar uma base de dados? (s/n): ");
                    char resp = char.Parse(Console.ReadLine());
                    if (resp == 's' || resp == 'S')
                    {
                        if (databaseRead)
                        {
                            db.CreateDataBase(strConnection1, resp);
                            databaseRead = true;
                            Console.WriteLine($"Base dados ja criada!");
                        }
                        else
                        {
                            Console.WriteLine($"Conectado base de dados {basedados}");
                            goto Inicio;
                        }
                    }
                    else if (resp == 'n' || resp == 'N')
                    {
                        Console.WriteLine("Operação não realizada, base de dados não pode ser criada!");
                        databaseRead = false;
                    }
                    else
                    {
                        Console.WriteLine("Operação não realizada, base de dados não pode ser criada!");
                        databaseRead = false;
                    }
                    break;
                #endregion

                case 2:
                    Console.WriteLine("Inserir registros na tabela");
                    break;
            }

            Console.ReadLine();
        }
    }
}
