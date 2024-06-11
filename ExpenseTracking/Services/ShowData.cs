using ExpenseTracking.managers;
using ExpenseTracking.services.utilities;

namespace ExpenseTracking.services
{
    internal class ShowData
    {
        public static void ShowDatas()
        {
            string option = MainProgram.GetOption();

            switch (option)
            {
                case "1":
                    if (!FinancialManager.expenseEntries.Any())
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Não existem despesas na lista!");
                        return;
                    }
                    ShowEachData.ShowExpenseData();
                    return;
                case "2":
                    if (!FinancialManager.revenueEntries.Any())
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Não existem receitas na lista!");
                        return;
                    }
                    ShowEachData.ShowRevenueData();
                    return;
            }
        }
    }
}
