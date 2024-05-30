using ExpenseTracking.managers;

namespace ExpenseTracking.services.utilities
{
    internal class SearchEachDescription
    {
        public static void SearchDescriptionExpense()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite a descrição do item que deseja buscar: ");
            Console.ForegroundColor = ConsoleColor.White;
            string userDescription = Console.ReadLine()!.ToLower().Trim();
            var descriptionExpense = FinancialManager.expenseEntries.Where(ee => ee.Description.Equals(userDescription));

            if (descriptionExpense.Any())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Itens encontrados: ");
                foreach (var ee in descriptionExpense)
                {
                    Console.WriteLine(ee);
                }
                return;
            }
            else
            {
                Console.WriteLine("Não foram encontrados itens com tal descrição!");
                return;
            }

        }

        public static void SearchDescriptionRevenue()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite a descrição do item que deseja buscar: ");
            Console.ForegroundColor = ConsoleColor.White;
            string userDescription = Console.ReadLine()!.ToLower().Trim();
            var descriptionRevenue = FinancialManager.revenueEntries.Where(ee => ee.Description.Equals(userDescription));

            if (descriptionRevenue.Any())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Itens encontrados: ");
                foreach (var ee in descriptionRevenue)
                {
                    Console.WriteLine(ee);
                }
                return;
            }
            else
            {
                Console.WriteLine("Não foram encontrados itens com tal descrição!");
                return;
            }
        }
    }
}


