using ExpenseTracking.managers;
using ExpenseTracking.services.utilities;

namespace ExpenseTracking.services.searchStrategies
{
    internal class SearchByDescription
    {
        public static void SearchDescription()
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
                    SearchEachDescription.SearchDescriptionExpense();
                    return;
                case "2":
                    if (FinancialManager.revenueEntries.Any() == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Não existem itens na lista!");
                        return;
                    }
                    SearchEachDescription.SearchDescriptionRevenue();
                    return;
            }
            
            


        }
    }
}
