using ExpenseTracking.managers;
using ExpenseTracking.models;

namespace ExpenseTracking.services.searchStrategies
{
    internal class SearchByValue
    {
        public static void SearchByMinValue()
        {
            string option = MainProgram.GetOption();


            if (option == "1" && FinancialManager.expenseEntries.Any() == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não existem despesas para busca!");
                return;
            }
            if (option == "2" && FinancialManager.revenueEntries.Any() == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não existem receitas para busca!");
                return;
            }


            switch (option)
            {
                case "1":
                    var minExpense = FinancialManager.expenseEntries.Min(i => i.Value);
                    var minExpenseItems = FinancialManager.expenseEntries.Where(i => i.Value.Equals(minExpense));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Despesas com menor valor:");
                    foreach (var itemMinExpense in minExpenseItems)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        FinancialEntry.PrintData(itemMinExpense);
                    }
                    return;
                case "2":
                    var minRevenue = FinancialManager.revenueEntries.Min(i => i.Value);
                    var minRevenueItems = FinancialManager.revenueEntries.Where(i => i.Value.Equals(minRevenue));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Receitas com menor valor:");
                    foreach (var itemMinRevenue in minRevenueItems)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        FinancialEntry.PrintData(itemMinRevenue);
                    }
                    return;
            }
        }
        public static void SearchByMaxValue()
        {
            string option = MainProgram.GetOption();

            if (option == "1" && FinancialManager.expenseEntries.Any() == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não existem despesas para busca!");
                return;
            }
            if (option == "2" && FinancialManager.revenueEntries.Any() == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não existem receitas para busca!");
                return;
            }


            switch (option)
            {
                case "1":
                    var maxExpense = FinancialManager.expenseEntries.Max(i => i.Value);
                    var maxExpenseItems = FinancialManager.expenseEntries.Where(i => i.Value.Equals(maxExpense));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Despesas com maior valor:");
                    foreach (var itemMaxExpense in maxExpenseItems)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        FinancialEntry.PrintData(itemMaxExpense);
                    }
                    return;
                case "2":
                    var maxRevenue = FinancialManager.revenueEntries.Max(i => i.Value);
                    var maxRevenueItems = FinancialManager.revenueEntries.Where(i => i.Value.Equals(maxRevenue));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Receitas com maior valor:");
                    foreach (var itemMaxRevenue in maxRevenueItems)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        FinancialEntry.PrintData(itemMaxRevenue);
                    }
                    return;

            }
        }
    }
}
