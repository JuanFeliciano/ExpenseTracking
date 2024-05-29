using ExpenseTracking.managers;

namespace ExpenseTracking.services
{
    internal class DeleteData
    {
        public static void DeleteDatas()
        {
            string option = MainProgram.GetOption();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Você tem certeza desta ação? (s/n): ");
            Console.ForegroundColor = ConsoleColor.White;
            string sure = Console.ReadLine()!.Trim().ToLower();

            if(sure == "s" && option == "1")
            {
                FinancialManager.expenseEntries.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Todos os itens removidos!");
                return;
            }else if (sure == "n" && option == "1")
            {
                Console.WriteLine("Voltando ao menu principal...");
            }
            else if (sure == "s" && option == "2")
            {
                    FinancialManager.revenueEntries.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Todos os itens removidos!");
                    return;
            }else if (sure == "n" && option == "2")
            {
                Console.WriteLine("Voltando ao menu principal...");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Voltando ao menu principal...");
                return;
            }

        }
    }
}
