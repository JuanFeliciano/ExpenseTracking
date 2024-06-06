using ExpenseTracking.managers;
using ExpenseTracking.models;

namespace ExpenseTracking.services.usecases
{
    internal class DateFilter
    {
        public static void DateExpenseFilter(DateOnly initDate, DateOnly finDate)
        {
            IEnumerable<ExpenseEntry> matchingExpenses = FinancialManager.expenseEntries.Where(ee => ee.Date >= initDate && ee.Date <= finDate);

            if (matchingExpenses.Any())
            {
                foreach (var ee in matchingExpenses)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"ID: {ee.Id} Data: {ee.Date} Valor: -{ee.Value} Descrição: {ee.Description} Categoria: {ee.Category}\n");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não existem despesas para busca!");
            }
        }

        public static void DateRevenueFilter(DateOnly initDate, DateOnly finDate)
        {
            IEnumerable<RevenueEntry> matchingRevenues = FinancialManager.revenueEntries.Where(ee => ee.Date >= initDate && ee.Date <= finDate);

            if (matchingRevenues.Any())
            {
                foreach (var ee in matchingRevenues)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"ID: {ee.Id} Data: {ee.Date} Valor: {ee.Value} Descrição: {ee.Description} Categoria: {ee.Category}\n");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não existem receitas para busca!");
            }
        }
    }
}
