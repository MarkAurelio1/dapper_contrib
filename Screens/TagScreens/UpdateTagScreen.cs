using System.Data.Common;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screen.TagScreens
{
    public static class UpdateTagsScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizar Tag");
            Console.WriteLine("-----------");
            Console.WriteLine("Informe os dados solicitados para atualizar a tag");
            Console.WriteLine("Id: ");
            var id = Console.ReadLine();

            Console.WriteLine("Nome: ");
            var name = Console.ReadLine();

            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Update(new Tag
            {
                Id = int.Parse(id),
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuTagScreen.Load();
        }
        private static void Update(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Update(tag);
                Console.WriteLine("Tag atualizada com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}