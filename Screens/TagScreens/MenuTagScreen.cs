using Blog.Screen.TagScreens;

namespace Blog.Screen.TagScreens
{
    public static class MenuTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("1- Listar Tag");
            Console.WriteLine("2- Cadastrar Tags");
            Console.WriteLine("3- Atualizar Tag");
            Console.WriteLine("4- Excluir Tag");
            Console.WriteLine("--------------------");


            var option = short.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ListTagScreen.Load();
                    break;
                case 2:
                    CreateTagScreen.Load();
                    break;
                case 3:
                    UpdateTagsScreen.Load();
                    break;
                case 4:
                    DeleteTagsScreen.Load();
                    break;
                default: break;
            }
        }
    }
}