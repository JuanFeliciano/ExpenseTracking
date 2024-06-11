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
                    Console.WriteLine($"ID: {userInput.Id} Data: {userInput!.Date} Valor: -{userInput.Value} Descrição: {userInput.Description} Categoria: {userInput.Category}");
                    return;
                case "2":
                    FinancialManager.revenueEntries.Add(new RevenueEntry(userInput.Id, userInput.Date, userInput.Value, userInput.Description, userInput.Category));
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"ID: {userInput.Id} Data: {userInput!.Date} Valor: {userInput.Value} Descrição: {userInput.Description} Categoria: {userInput.Category}");
                    return;
            }
        }
    }
}



