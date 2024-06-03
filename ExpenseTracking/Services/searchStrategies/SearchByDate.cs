

using ExpenseTracking.managers;
using ExpenseTracking.services.usecases;

namespace ExpenseTracking.services.searchStrategies
{
    internal class SearchByDate
    {
        public static void SearchDate()
        {
            string option = MainProgram.GetOption();

            if (option == "1" && FinancialManager.expenseEntries.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não existem dados para busca!");
                return;
            }

            if (option == "2" && FinancialManager.revenueEntries.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não existem dados para busca!");
                return;
            }

            while (true)
            {
                DateOnly initDate;
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Digite a data inicial (dd/MM/yyyy): ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    string initialDate = Console.ReadLine()!;

                    if (DateOnly.TryParse(initialDate, out initDate))
                    {
                        break;
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Formato digitado é inválido, por favor digite novamente (dd/MM/yyyy): ");
                }

                DateOnly finDate;
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Digite a data final (dd/MM/yyyy): ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    string finalDate = Console.ReadLine()!;

                    if (DateOnly.TryParse(finalDate, out finDate))
                    {
                        break;
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Formato digitado é inválido, por favor digite novamente (dd/MM/yyyy): ");

                }

                switch (option)
                {
                    case "1":
                        DateFilter.DateExpenseFilter(initDate, finDate);
                        return;
                    case "2":
                        DateFilter.DateRevenueFilter(initDate, finDate);
                        return;
                }
            }
        }
    }
}
