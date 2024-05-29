

using ExpenseTracking.managers;
using System.ComponentModel;

namespace ExpenseTracking.services.searchStrategies
{
    internal class SearchByDate
    {
        public static void SearchDate()
        {
            string option = MainProgram.GetOption();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite a data inicial (dd/MM/yyyy): ");
            Console.ForegroundColor = ConsoleColor.White;
            string initialDate = Console.ReadLine()!;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite a data final (dd/MM/yyyy): ");
            Console.ForegroundColor = ConsoleColor.White;
            string finalDate = Console.ReadLine()!;

            if (!DateOnly.TryParse(initialDate, out DateOnly initDate) || !DateOnly.TryParse(finalDate, out DateOnly finDate))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Formato digitado é inválido, por favor digite novamente (dd/MM/yyyy): ");
            }

            switch (option)
            {
                case "1":
                    var matchingExpenses = FinancialManager.expenseEntries.Where(ee => ee.Date >= initDate && ee.Date <= finDate);

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
                    var matchingRevenues = FinancialManager.revenueEntries.Where(ee => ee.Date >= initDate && ee.Date <= finDate);

                    if (matchingRevenues.Any())
                    {
                        foreach (var ee in matchingRevenues)
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
            }
        }
    }
}
