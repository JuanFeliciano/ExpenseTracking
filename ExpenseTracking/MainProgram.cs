using ExpenseTracking.services.utilities;
using System.Runtime.CompilerServices;

namespace ExpenseTracking
{
    internal static class MainProgram
    {
        private static string? option;
        private delegate void Menu();
        public static void Main()
        {
            
            while (true)
            {
                Menu showMenu = new Menu(ShowMenu.MenuMain);

                showMenu();

                Console.ForegroundColor = ConsoleColor.Blue;
                option = Console.ReadLine()!.Trim();

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        MenuDefault.MenuOption();
                        break;
                    case "2":
                        Console.Clear();
                        MenuDefault.MenuOption();
                        break;
                    case "3":
                        Console.Clear();
                        ShowEachData.ShowExpenseData();
                        ShowEachData.ShowRevenueData();
                        break;
                    case "4":
                        return;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
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