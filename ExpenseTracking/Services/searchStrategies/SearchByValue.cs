using ExpenseTracking.managers;

namespace ExpenseTracking.services.searchStrategies
{
    internal class SearchByValue
    {
        public static void SearchByMinValue()
        {
            string option = MainProgram.GetOption();


            if (option == "1" && !FinancialManager.expenseEntries.Any())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não existem despesas para busca!");
                return;
            }
            if (option == "2" && !FinancialManager.revenueEntries.Any())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não existem receitas para busca!");
                return;
            }


            switch (option)
            {
                case "1":
                    var minExpense = FinancialManager.expenseEntries.Min(ee => ee.Value);
                    var minExpenseItems = FinancialManager.expenseEntries.Where(ee => ee.Value.Equals(minExpense));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Despesas com menor valor:");
                    foreach (var itemMinExpense in minExpenseItems)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"ID: {itemMinExpense!.Id} Data: {itemMinExpense.Date} Valor: -{itemMinExpense.Value} Descrição: {itemMinExpense.Description} Categoria: {itemMinExpense.Category}");
                    }
                    return;
                case "2":
                    var minRevenue = FinancialManager.revenueEntries.Min(re => re.Value);
                    var minRevenueItems = FinancialManager.revenueEntries.Where(re => re.Value.Equals(minRevenue));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Receitas com menor valor:");
                    foreach (var itemMinRevenue in minRevenueItems)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"ID: {itemMinRevenue!.Id} Data: {itemMinRevenue.Date} Valor: {itemMinRevenue.Value} Descrição: {itemMinRevenue.Description} Categoria: {itemMinRevenue.Category}");

                    }
                    return;
            }
        }
        public static void SearchByMaxValue()
        {
            string option = MainProgram.GetOption();

            if (option == "1" && !FinancialManager.expenseEntries.Any())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não existem despesas para busca!");
                return;
            }
            if (option == "2" && !FinancialManager.revenueEntries.Any())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não existem receitas para busca!");
                return;
            }


            switch (option)
            {
                case "1":
                    var maxExpense = FinancialManager.expenseEntries.Max(ee => ee.Value);
                    var maxExpenseItems = FinancialManager.expenseEntries.Where(ee => ee.Value.Equals(maxExpense));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Despesas com maior valor:");
                    foreach (var itemMaxExpense in maxExpenseItems)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"ID: {itemMaxExpense!.Id} Data: {itemMaxExpense.Date} Valor: {itemMaxExpense.Value} Descrição: {itemMaxExpense.Description} Categoria: {itemMaxExpense.Category}");

                    }
                    return;
                case "2":
                    var maxRevenue = FinancialManager.revenueEntries.Max(re => re.Value);
                    var maxRevenueItems = FinancialManager.revenueEntries.Where(re => re.Value.Equals(maxRevenue));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Receitas com maior valor:");
                    foreach (var itemMaxRevenue in maxRevenueItems)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"ID: {itemMaxRevenue!.Id} Data: {itemMaxRevenue.Date} Valor: {itemMaxRevenue.Value} Descrição: {itemMaxRevenue.Description} Categoria: {itemMaxRevenue.Category}");

                    }
                    return;

            }
        }
    }
}
