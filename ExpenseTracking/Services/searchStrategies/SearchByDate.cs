

using ExpenseTracking.managers;
using ExpenseTracking.services.usecases;
using System;

namespace ExpenseTracking.services.searchStrategies
{
    internal class SearchByDate
    {
        public static void SearchDate()
        {
            string option = MainProgram.GetOption();

            if (option == "1" && FinancialManager.expenseEntries.Any() == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não existem dados para busca!");
                return;
            }

            if (option == "2" && FinancialManager.revenueEntries.Any() == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não existem dados para busca!");
                return;
            }

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Digite ´sair´ a qualquer momento para fechar o programa!");
                DateOnly initDate;
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Digite a data inicial (dd/MM/yyyy): ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    string initialDate = Console.ReadLine()!;

                    ExitCommand.Check(initialDate);

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

                    ExitCommand.Check(finalDate);

                    if (!DateOnly.TryParse(finalDate, out finDate))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Formato digitado é inválido, por favor digite novamente (dd/MM/yyyy):");
                    }
                    if (finDate <= initDate)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Data final não pode ser menor que a inicial!");
                        continue;
                    }
                    break;
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
