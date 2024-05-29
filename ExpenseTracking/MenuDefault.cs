using ExpenseTracking.Managers;
using ExpenseTracking.Services.Utilities;

namespace ExpenseTracking
{
    public class MenuDefault
    {
        public static void MenuOption()
        {
            FinancialManager financial = new();

            ShowMenu.ShowMenuDefault();
            string option = Console.ReadLine()!;
                
                switch (option)
            {
                case "1":
                    Console.Clear();
                    financial.AddData();
                    return;
                case "2":
                    Console.Clear();
                    financial.EditData();
                    return;
                case "3":
                    Console.Clear();
                    financial.ShowData();
                    return;
                case "4":
                    Console.Clear();
                    financial.DeleteData();
                    return;
                case "5":
                    return;
                default:
                    Console.WriteLine("Escolha uma opção válida!");
                    break;
            }
        }
    }
}
