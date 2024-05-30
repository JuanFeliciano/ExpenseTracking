using ExpenseTracking.services.utilities;

namespace ExpenseTracking
{
    internal static class MainProgram
    {
        private static string? option;
        public static void Main()
        {
            while (true)
            {
                ShowMenu.MenuMain();
                Console.ForegroundColor = ConsoleColor.White;
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