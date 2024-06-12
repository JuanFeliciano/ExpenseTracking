using ExpenseTracking.managers;
using ExpenseTracking.models;

namespace ExpenseTracking.services.utilities
{
    internal class ShowEachData

    {
        public static void ShowExpenseData()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Despesas: ");

            if (FinancialManager.expenseEntries.Any() == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não existem despesas para mostrar!");
                return;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            FinancialManager.expenseEntries.ForEach(i => FinancialEntry.PrintData(i));

        }
        public static void ShowRevenueData()
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Receitas:");

            if (FinancialManager.revenueEntries.Any() == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não existem receitas para mostrar!");
                return;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            FinancialManager.revenueEntries.ForEach(i => FinancialEntry.PrintData(i));

        }
    }
}
