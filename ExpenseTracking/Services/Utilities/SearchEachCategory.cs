using ExpenseTracking.managers;

namespace ExpenseTracking.services.utilities
{
    internal class SearchEachCategory
    {
        public static void SearchCategoryExpense()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite a descrição do item que deseja buscar: ");
            Console.ForegroundColor = ConsoleColor.White;
            string userCategory = Console.ReadLine()!.ToLower().Trim();
            var categoryExpense = FinancialManager.expenseEntries.Where(ee => ee.Category.Equals(userCategory));

            if (categoryExpense.Any())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Itens encontrados: ");
                foreach (var ee in categoryExpense)
                {
                    Console.WriteLine(ee);
                }
                return;
            }
            else
            {
                Console.WriteLine("Não foram encontrados itens com tal categoria!");
                return;
            }
        }

        public static void SearchCategoryRevenue()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite a descrição do item que deseja buscar: ");
            Console.ForegroundColor = ConsoleColor.White;
            string userCategory = Console.ReadLine()!.ToLower().Trim();
            var categoryRevenue = FinancialManager.revenueEntries.Where(ee => ee.Category.Equals(userCategory));

            if (categoryRevenue.Any())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Itens encontrados: ");
                foreach (var ee in categoryRevenue)
                {
                    Console.WriteLine(ee);
                }
                return;
            }
            else
            {
                Console.WriteLine("Não foram encontrados itens com tal categoria!");
                return;
            }
        }

    }
}
