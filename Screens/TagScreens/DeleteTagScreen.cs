using Blog.Models;
using Blog.Repositories;

namespace Blog.Screen.TagScreens
{
    public static class DeleteTagsScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Informe o Número da Tag que deseja excluir: ");
            Console.WriteLine("Id: ");
            var id = Console.ReadLine();
            Console.WriteLine("-------------");

            Delete(new Tag
            {
                Id = int.Parse(id)
            });
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Delete(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Delete(tag);
                Console.WriteLine("Tag excluída com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluír a tag");
            }
        }
    }
}