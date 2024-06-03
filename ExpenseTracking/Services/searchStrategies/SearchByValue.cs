using ExpenseTracking.managers;
using ExpenseTracking.services.utilities;

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
                    if(FinancialManager.expenseEntries.Count == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Não existem despesas para busca!");
                        return;
                    }
                    break;
                case "2":
                    if (FinancialManager.revenueEntries.Count == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Não existem receitas para busca!");
                        return;
                    }
                    break;
            }

            switch (option)
            {
                case "1":
                    var minExpense = FinancialManager.expenseEntries.Min(ee => ee.Value);
                    var itemMinExp = FinancialManager.expenseEntries.Find(ee => ee.Value.Equals(minExpense));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Despesa com menos valor:");
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine($"ID: {itemMinExp!._id} Data: {itemMinExp.Date} Valor: -{itemMinExp.Value} Descrição: {itemMinExp.Description} Categoria: {itemMinExp.Category}");
                    return;
                case "2":
                    var minRevenue = FinancialManager.revenueEntries.Min(re => re.Value);
                    var itemMinRev = FinancialManager.revenueEntries.Find(re => re.Value.Equals(minRevenue));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Receita com menos valor:");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"ID: {itemMinRev!._id} Data: {itemMinRev.Date} Valor: {itemMinRev.Value} Descrição: {itemMinRev.Description} Categoria: {itemMinRev.Category}");
                    return;
            }
        }
        public static void SearchByMaxValue()
        {
            string option = MainProgram.GetOption();

            switch (option)
            {
                case "1":
                    if (FinancialManager.expenseEntries.Count == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Não existem despesas para busca!");
                        return;
                    }
                    break;
                case "2":
                    if (FinancialManager.revenueEntries.Count == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Não existem receitas para busca!");
                        return;
                    }
                    break;
            }


            switch (option)
            {
                case "1":
                    var maxExpense = FinancialManager.expenseEntries.Max(ee => ee.Value);
                    var itemMaxExp = FinancialManager.expenseEntries.Find(ee => ee.Value.Equals(maxExpense));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Item com mais valor:");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"ID: {itemMaxExp!._id} Data: {itemMaxExp.Date} Valor: -{itemMaxExp.Value} Descrição: {itemMaxExp.Description} Categoria: {itemMaxExp.Category}");

                    return;
                case "2":
                    var maxRevenue = FinancialManager.revenueEntries.Max(re => re.Value);
                    var itemMaxRev = FinancialManager.revenueEntries.Find(re => re.Value.Equals(maxRevenue));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Item com mais valor:");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"ID: {itemMaxRev!._id} Data: {itemMaxRev.Date} Valor: {itemMaxRev.Value} Descrição: {itemMaxRev.Description} Categoria: {itemMaxRev.Category}");
                    return;

            }
        }
    }
}
