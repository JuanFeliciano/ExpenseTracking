

using ExpenseTracking.managers;

namespace ExpenseTracking.services.searchStrategies
{
    internal class SearchByValue
    {
        public static void SearchByMinValue()
        {
            string option = MainProgram.GetOption();


            switch (option)
            {
                case "1":
                    var minExpense = FinancialManager.expenseEntries.Min(ee => ee.Value);
                    Console.WriteLine($"O menor valor da lista é {minExpense}");
                    return;
                case "2":
                    var minRevenue = FinancialManager.revenueEntries.Min(re => re.Value);
                    Console.WriteLine($"O menor valor da lista é {minRevenue}");
                    return;

            }
        }

        public static void SearchByMaxValue()
        {
            string option = MainProgram.GetOption();

            switch (option)
            {
                case "1":
                    var maxExpense = FinancialManager.expenseEntries.Max(ee => ee.Value);
                    Console.WriteLine($"O maior valor da lista é {maxExpense}");
                    return;
                case "2":
                    var maxRevenue = FinancialManager.expenseEntries.Max(ee => ee.Value);
                    Console.WriteLine($"O maior valor da lista é {maxRevenue}");
                    return;

            }
        }
    }
}
