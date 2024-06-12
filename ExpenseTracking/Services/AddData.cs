using ExpenseTracking.managers;
using ExpenseTracking.models;
using ExpenseTracking.services.utilities;

namespace ExpenseTracking.services
{
    public class AddData
    {
        public static void AddDatas()
        {
            string menuOption = MainProgram.GetOption();
            FinancialEntry userInput = UserInput.CollectUserInput();


            switch (menuOption)
            {
                case "1":
                    FinancialManager.expenseEntries.Add(new ExpenseEntry(userInput.Id, userInput.Date, userInput.Value, userInput.Description, userInput.Category));
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    FinancialEntry.PrintData(userInput); return;
                case "2":
                    FinancialManager.revenueEntries.Add(new RevenueEntry(userInput.Id, userInput.Date, userInput.Value, userInput.Description, userInput.Category));
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    FinancialEntry.PrintData(userInput);
                    return;
            }
        }
    }
}



