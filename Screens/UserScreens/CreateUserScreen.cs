using Blog.Models;
using Blog.Repositories;

namespace Blog.Screen.UserScreen
{
    public static class CreateUserScreen
    {
        public static void Load()
        {
            Console.WriteLine("Criar novo usuário:");
            Console.WriteLine("-------------------");
            Console.WriteLine("Nome: ");
            var name = Console.ReadLine();
            Console.WriteLine("Email: ");
            var email = Console.ReadLine();
            Console.WriteLine("Password: ");
            var passwordHash = Console.ReadLine();
            Console.WriteLine("Bio: ");
            var bio = Console.ReadLine();
            Console.WriteLine("Image: ");
            var image = Console.ReadLine();
            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Create(new User
            {
                Name = name,
                Email = email,
                PasswordHash = passwordHash,
                Bio = bio,
                Image = image,
                Slug = slug
            });
            Console.ReadKey();
            MenuUserScreen.Load();
        }
        public static void Create(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Create(user);
                Console.WriteLine("Usuário cadastrado com sucesso.");
            }
            catch (Exception ex)
            {
                Console.Write("Não foi possível cadastrar usuário");
            }
        }
    }
}