﻿using System;
using Blog.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True";
        static void Main(string[] args)
        {
            var connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            //ReadUsers(connection);
            //ReadRoles(connection);
            //ReadTags(connection);
            //ReadCategories(connection);
            ReadUserWithRoles(connection);
            //CreateUsers(connection);
            connection.Close();
        }
        public static void ReadUsers(SqlConnection connection)

        {
            var repository = new Repository<User>(connection);
            var items = repository.Get();
            {

                foreach (var item in items)
                {
                    Console.WriteLine(item.Name);
                    foreach (var role in item.Roles)
                    {
                        Console.WriteLine($" -{role.Name}");
                    }
                }
            }
        }
        public static void ReadRoles(SqlConnection connection)

        {
            var repository = new Repository<Role>(connection);
            var items = repository.Get();

            foreach (var item in items)
                Console.WriteLine(item.Name);

        }
        public static void ReadTags(SqlConnection connection)

        {
            var repository = new Repository<Tag>(connection);
            var items = repository.Get();

            foreach (var item in items)
                Console.WriteLine(item.Name);

        }
        public static void ReadCategories(SqlConnection connection)

        {
            var repository = new Repository<Category>(connection);
            var items = repository.Get();

            foreach (var item in items)
                Console.WriteLine(item.Name);

        }
        public static void CreateUsers(SqlConnection connection)

        {
            var repository = new Repository<User>(connection);
            var user = new User()
            {
                Name = "Valéria Gomes",
                Email = "valeria@rio.com",
                PasswordHash = "HASH",
                Bio = "Dev - OPS",
                Slug = "valéria-gomes",
                Image = "https://"

            };
            repository.Create(user);
            Console.WriteLine();
        }
        public static void ReadUserWithRoles(SqlConnection connection)

        {
            var repository = new UserRepository(connection);
            var items = repository.ReadWithRole();

            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
                foreach (var role in item.Roles)
                {
                    Console.WriteLine($" -{role.Name}");
                }
            }
        }
    }
}


