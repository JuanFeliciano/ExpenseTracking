using ExpenseTracking.managers;
using ExpenseTracking.services.usecases;

namespace ExpenseTracking.services.utilities
{
    internal class SearchEachDescription
    {
        public static void SearchDescriptionExpense()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Digite ´sair´ a qualquer momento para fechar o programa!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite a descrição da despesa que deseja buscar: ");
            Console.ForegroundColor = ConsoleColor.Blue;

            string description = Console.ReadLine()!.ToLower().Trim();

            ExitCommand.Check(description);

            var descriptionExpense = FinancialManager.expenseEntries.Where(i => i.Description.Equals(description));

            if (descriptionExpense.Any() == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não foram encontradas despesas com essa descrição!");
                return;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Despesas encontradas: ");
            foreach (var i in descriptionExpense)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(i);
            }

        }

        public static void SearchDescriptionRevenue()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Digite ´sair´ a qualquer momento para fechar o programa!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite a descrição da receita que deseja buscar: ");
            Console.ForegroundColor = ConsoleColor.Blue;

            string userDescription = Console.ReadLine()!.ToLower().Trim();

            ExitCommand.Check(userDescription);

            var descriptionRevenue = FinancialManager.revenueEntries.Where(i => i.Description.Equals(userDescription));

            if (descriptionRevenue.Any() == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não foram encontradas receitas com essa descrição!");
                return;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Receitas encontradas: ");
            foreach (var i in descriptionRevenue)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(i);
            }
        }
    }
}


