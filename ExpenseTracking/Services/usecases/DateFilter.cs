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
                foreach (var matchExpense in matchingExpenses)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"ID: {matchExpense.Id} Data: {matchExpense.Date} Valor: -{matchExpense.Value} Descrição: {matchExpense.Description} Categoria: {matchExpense.Category}\n");
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
                foreach (var matchRevenue in matchingRevenues)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"ID: {matchRevenue.Id} Data: {matchRevenue.Date} Valor: {matchRevenue.Value} Descrição: {matchRevenue.Description} Categoria: {matchRevenue.Category}\n");
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
