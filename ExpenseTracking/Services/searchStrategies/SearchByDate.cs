

using ExpenseTracking.managers;
using ExpenseTracking.models;
using System.ComponentModel;

namespace ExpenseTracking.services.searchStrategies
{
    internal class SearchByDate
    {
        public static void SearchDate()
        {
            string option = MainProgram.GetOption();

            while (true)
            {
                DateOnly initDate;
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite a data inicial (dd/MM/yyyy): ");
                    Console.ForegroundColor = ConsoleColor.White;
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite a data final (dd/MM/yyyy): ");
                    Console.ForegroundColor = ConsoleColor.White;
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
                        IEnumerable<ExpenseEntry> matchingExpenses = FinancialManager.expenseEntries.Where(ee => ee.Date >= initDate && ee.Date <= finDate);

                        if (matchingExpenses.Any())
                        {
                            foreach (var ee in matchingExpenses)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"ID: {ee._id} Data: {ee.Date} Valor: {ee.Value} Descrição: {ee.Description} Categoria: {ee.Category}\n");
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Não existem dados para busca!");
                        }
                        return;
                    case "2":
                        IEnumerable<RevenueEntry> matchingRevenues = FinancialManager.revenueEntries.Where(ee => ee.Date >= initDate && ee.Date <= finDate);

                        if (matchingRevenues.Any())
                        {
                            foreach (var re in matchingRevenues)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"ID: {re._id} Data: {re.Date} Valor: {re.Value} Descrição: {re.Description} Categoria: {re.Category}\n");
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Não existem dados para busca!");
                        }
                        return;
                }
            }
        }
    }
}
