using ExpenseTracking.managers;
using ExpenseTracking.models;

namespace ExpenseTracking.services.usecases
{
    internal class DateFilter
    {
        public static void DateExpenseFilter(DateOnly initDate, DateOnly finDate)
        {

            IEnumerable<ExpenseEntry> matchingExpenses = FinancialManager.expenseEntries.Where(i => i.Date >= initDate && i.Date <= finDate);

            if (matchingExpenses.Any() == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não existem despesas para busca!");
            }
            foreach (var matchExpense in matchingExpenses)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                FinancialEntry.PrintData(matchExpense);
            }
        }

        public static void DateRevenueFilter(DateOnly initDate, DateOnly finDate)
        {

            IEnumerable<RevenueEntry> matchingRevenues = FinancialManager.revenueEntries.Where(i => i.Date >= initDate && i.Date <= finDate);

            if (matchingRevenues.Any() == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não existem receitas para busca!");
            }
            foreach (var matchRevenue in matchingRevenues)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                FinancialEntry.PrintData(matchRevenue);
            }
        }
    }
}
