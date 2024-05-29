using ExpenseTracking.Managers;

namespace ExpenseTracking.Services
{
    internal class DeleteData
    {
        public static void DeleteDatas()
        {
            string option = MainProgram.GetOption();

            Console.WriteLine("Você tem certeza desta ação? (s/n): ");
            bool sure = Console.ReadLine()!.ToLower() == "s";

            if(sure && option == "1")
            {
                    FinancialManager.expenseEntries.Clear();
                    Console.WriteLine("Todos os itens removidos!");
                    return;
            }
            else if (sure && option == "2")
            {
                    FinancialManager.revenueEntries.Clear();
                    Console.WriteLine("Todos os itens removidos!");
                    return;
            }
            else
            {
                Console.WriteLine("Voltando ao menu principal...");
                return;
            }

        }
    }
}
