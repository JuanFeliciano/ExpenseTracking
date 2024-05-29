using ExpenseTracking.managers;

namespace ExpenseTracking
{
    public class MenuDefault
    {
        public static void MenuOption()
        {
            FinancialManager financial = new();

            ShowMenu.ShowMenuDefault();
            Console.ForegroundColor = ConsoleColor.White;
            string option = Console.ReadLine()!.Trim();
                
                switch (option)
            {
                case "1":
                    financial.AddData();
                    break;
                case "2":
                    financial.EditData();
                    break;
                case "3":
                    financial.ShowData();
                    break;
                case "4":
                    financial.SearchData();
                    break;
                case "5":
                    Console.Clear();
                    financial.DeleteData();
                    break;
                case "6":
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Escolha uma opção válida!");
                    break;
            }
        }
    }
}
