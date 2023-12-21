using Blog.Models;
using Blog.Repositories;

namespace Blog.Screen.UserScreen
{
    public static class ListUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Usuários");
            Console.WriteLine("------------");
            List();
            Console.ReadKey();
            MenuUserScreen.Load();
        }
        private static void List()
        {
            var repository = new Repository<User>(Database.Connection);
            var tags = repository.Get();
            foreach (var item in tags)
                Console.WriteLine($"{item.Id} - {item.Name} ({item.Bio})");

        }
    }
}