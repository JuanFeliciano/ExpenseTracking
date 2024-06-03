using ExpenseTracking.managers;

namespace ExpenseTracking.services.utilities
{
    internal class SearchEachCategory
    {
        public static void SearchCategoryExpense()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite a descrição da despesa que deseja buscar: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string userCategory = Console.ReadLine()!.ToLower().Trim();
            var categoryExpense = FinancialManager.expenseEntries.Where(ee => ee.Category.Equals(userCategory));

            if (categoryExpense.Any())
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Despesas encontradas: ");
                foreach (var ee in categoryExpense)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ee);
                }
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não foram encontradas despesas com essa categoria!");
                return;
            }
        }

        public static void SearchCategoryRevenue()
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite a descrição da receita que deseja buscar: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string userCategory = Console.ReadLine()!.ToLower().Trim();
            var categoryRevenue = FinancialManager.revenueEntries.Where(ee => ee.Category.Equals(userCategory));

            if (categoryRevenue.Any())
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Receitas encontradas: ");
                foreach (var ee in categoryRevenue)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(ee);
                }
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não foram encontrados itens com esssa categoria!");
                return;
            }
        }

    }
}
