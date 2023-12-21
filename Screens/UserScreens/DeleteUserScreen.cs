using Blog.Models;
using Blog.Repositories;

namespace Blog.Screen.UserScreen
{
    public static class DeleteUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Informe o Id da conta para excluir usuário: ");
            Console.WriteLine("Id: ");
            var id = Console.ReadLine();
            Console.WriteLine("-------------");

            Delete(new User
            {
                Id = int.Parse(id)
            });
            Console.ReadKey();
            MenuUserScreen.Load();
        }
        public static void Delete(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Delete(user);
                Console.Write("Usuário excluido com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir usuário");
                Console.WriteLine(ex.Message);
            }
        }
    }
}