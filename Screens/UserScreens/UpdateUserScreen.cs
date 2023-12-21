using Blog.Models;
using Blog.Repositories;

namespace Blog.Screen.UserScreen
{
    public class UpdateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.Write("Atualizar informações: ");
            Console.Write("--------------------------");
            Console.WriteLine("Para atualizar seu Perfil, infome os dados solicitados");
            Console.WriteLine("Id: ");
            var id = Console.ReadLine();
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

            Update(new User
            {
                Id = int.Parse(id),
                Name = name,
                Email = email,
                PasswordHash = passwordHash,
                Bio = bio,
                Image = image,
                Slug = slug
            });
        }
        public static void Update(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Update(user);
                Console.WriteLine("Usuário atualizado com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar usuário.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}