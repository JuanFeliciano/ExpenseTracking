using ExpenseTracking.managers;
using ExpenseTracking.services.utilities;

namespace ExpenseTracking.services
{
    internal class EditData
    {
        public static void EditDatas()
        {
            string option = MainProgram.GetOption();

            switch (option)
            {
                case "1":
                    if (FinancialManager.expenseEntries.Any() == false) 
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Não existem despesas para edição!");
                        return;
                    }
                    EditEachData.EditExpenseData();
                    return;
                case "2":
                    if (FinancialManager.revenueEntries.Any() == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Não existem receitas para edição!");
                        return;
                    }
                    EditEachData.EditRevenueData();
                    return;
            }

        }
    }
}
