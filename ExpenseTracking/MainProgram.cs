using ExpenseTracking.Managers;

namespace ExpenseTracking
{
    internal static class MainProgram
    {
        private static string? option;
        public static void Main()
        {

            while (true)
            {

            Console.WriteLine("Digite o que deseja manipular: ");
            Console.WriteLine("1 - Despesas");
            Console.WriteLine("2 - Receitas");
            Console.WriteLine("3 - Listar todos os dados");
            Console.WriteLine("4 - Sair");

            option = Console.ReadLine()!;



                switch (option)
                {
                    case "1":
                        Console.Clear();
                        MenuDefault.MenuOption();
                        break;
                    case "2":
                        MenuDefault.MenuOption();
                        break;
                    case "3":
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Digite uma opção válida!");
                        break;
                }
            }
        }

        public static string GetOption()
        {
            return option!;
        }
    }
}