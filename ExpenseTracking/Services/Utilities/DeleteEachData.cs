using ExpenseTracking.managers;
using ExpenseTracking.models;

namespace ExpenseTracking.services.utilities
{
    internal class DeleteEachData
    {
        public static void DeleteExpenseData()
        {
            FinancialEntry itemQuery;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite por ID a despesa desejada para edição: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string id = Console.ReadLine()!.Trim();

            if(!int.TryParse(id, out int userId))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ID inválido!");
                return;
            }

            itemQuery = FinancialManager.expenseEntries.Find(pe => pe._id.Equals(userId))!;

            if (itemQuery is ExpenseEntry expenseEntry && itemQuery != null)
            {
                FinancialManager.expenseEntries.Remove(expenseEntry);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Despesa deletada com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ID inválido!");
                return;
            }
        }

        public static void DeleteRevenueData()
        {
            FinancialEntry itemQuery;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite por ID a receita desejada para edição: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string id = Console.ReadLine()!.Trim();

            if (!int.TryParse(id, out int userId))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ID inválido!");
                return;
            }

            itemQuery = FinancialManager.revenueEntries.Find(pe => pe._id.Equals(userId))!;

            if (itemQuery is RevenueEntry revenueEntry && itemQuery != null)
            {
                FinancialManager.revenueEntries.Remove(revenueEntry);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Receita deletada com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ID inválido!");
                return;
            }
        }
    }
}
