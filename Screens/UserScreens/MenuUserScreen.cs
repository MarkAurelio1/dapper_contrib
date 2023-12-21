namespace Blog.Screen.UserScreen
{
    public static class MenuUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("1- Listar Usuários");
            Console.WriteLine("2- Cadastrar novo Usuário");
            Console.WriteLine("3- Atualizar Usuário");
            Console.WriteLine("4- Excluir Usuário");
            Console.WriteLine("---------------------");

            var option = short.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ListUserScreen.Load();
                    break;
                case 2:
                    CreateUserScreen.Load();
                    break;
                case 3:
                    UpdateUserScreen.Load();
                    break;
                case 4:
                    DeleteUserScreen.Load();
                    break;
                default: break;
            }
            Console.ReadKey();
            Load();
        }
    }
}