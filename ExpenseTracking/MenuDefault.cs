using ExpenseTracking.managers;
using ExpenseTracking.services;

namespace ExpenseTracking
{
    public class MenuDefault
    {
        public static void MenuOption()
        {

            ShowMenu.MenuDefault();
            Console.ForegroundColor = ConsoleColor.Blue;
            string option = Console.ReadLine()!.Trim();

            switch (option)
            {
                case "1":
                    FinancialManager.AddData();
                    break;
                case "2":
                    FinancialManager.EditData();
                    break;
                case "3":
                    FinancialManager.ShowData();
                    break;
                case "4":
                    FinancialManager.SearchData();
                    break;
                case "5":
                    FinancialManager.DeleteOneData();
                    break;
                case "6":
                    Console.Clear();
                    FinancialManager.DeleteData();
                    break;
                case "7":
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Escolha uma opção válida!");
                    break;
            }
        }
    }
}
