using ExpenseTracking.managers;
using ExpenseTracking.services.utilities;

namespace ExpenseTracking.services.searchStrategies
{
    internal class SearchByCategory
    {
        public static void SearchCategory()
        {
            string option = MainProgram.GetOption();

            switch (option)
            {
                case "1":
                    if (FinancialManager.expenseEntries.Any() == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Não existem itens na lista!");
                        return;
                    }
                    SearchEachCategory.SearchCategoryExpense();
                    return;
                case "2":
                    if (FinancialManager.revenueEntries.Any() == false )
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Não existem itens na lista!");
                        return;
                    }
                    SearchEachCategory.SearchCategoryRevenue();
                    return;
            }
        }
    }
}
