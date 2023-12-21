using System;
using Blog.Screen.TagScreens;
using Blog.Screen.UserScreen;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True";
        static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();

            Load();

            Console.ReadKey();
            Database.Connection.Close();
        }
        private static void Load()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo Ao Meu Blog *-*");
            Console.WriteLine("------------------------");
            Console.WriteLine("O que deseja fazer ?");
            Console.WriteLine("1 - Gestão de Usuário");
            Console.WriteLine("2 - Gestão de Perfil");
            Console.WriteLine("3 - Gestão de Post");
            Console.WriteLine("4 - Gestão de Tag");
            Console.WriteLine("5 - Vincular Usuário ao Perfil");
            Console.WriteLine("6- Para sair");


            Console.WriteLine("-------------------------");
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    MenuUserScreen.Load();
                    break;
                case 4:
                    MenuTagScreen.Load();
                    break;
                default: Load(); break;
                case 6:
                    Console.WriteLine("Obrigado por usar nosso Blog.");
                    Environment.Exit(0);
                    break;
            }
        }

    }
}



