using ExpenseTracking.managers;

namespace ExpenseTracking.services.utilities
{
    internal class SearchEachDescription
    {
        public static void SearchDescriptionExpense()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite a descrição da despesa que deseja buscar: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string userDescription = Console.ReadLine()!.ToLower().Trim();
            var descriptionExpense = FinancialManager.expenseEntries.Where(ee => ee.Description.Equals(userDescription));

            if (descriptionExpense.Any())
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Despesas encontradas: ");
                foreach (var ee in descriptionExpense)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ee);
                }
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não foram encontradas despesas com essa descrição!");
                return;
            }

        }

        public static void SearchDescriptionRevenue()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite a descrição da receita que deseja buscar: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string userDescription = Console.ReadLine()!.ToLower().Trim();
            var descriptionRevenue = FinancialManager.revenueEntries.Where(ee => ee.Description.Equals(userDescription));

            if (descriptionRevenue.Any())
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Receitas encontradas: ");
                foreach (var ee in descriptionRevenue)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(ee);
                }
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não foram encontradas receitas com essa descrição!");
                return;
            }
        }
    }
}


