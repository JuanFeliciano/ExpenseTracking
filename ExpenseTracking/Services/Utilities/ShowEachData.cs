using ExpenseTracking.managers;

namespace ExpenseTracking.services.utilities
{
    internal class ShowEachData

    {
        public static void ShowExpenseData()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Despesas: ");

            if (FinancialManager.expenseEntries.Count <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não existem dados para amostra!");
                return;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            FinancialManager.expenseEntries.ForEach(ee => Console.WriteLine($"ID: {ee._id} Data: {ee.Date} Valor: {ee.Value} Descrição: {ee.Description} Categoria: {ee.Category}\n"));

        }
        public static void ShowRevenueData()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Receitas:");

            if (FinancialManager.revenueEntries.Count <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não existem dados para amostra!");
                return;
            }

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            FinancialManager.revenueEntries.ForEach(re => Console.WriteLine($"ID: {re._id} Data: {re.Date} Valor: {re.Value} Descrição: {re.Description} Categoria: {re.Category}\n"));

        }
    }
}
