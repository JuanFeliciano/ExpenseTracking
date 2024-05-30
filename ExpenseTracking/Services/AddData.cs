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
            var userInput = UserInput.CollectUserInput();

            switch (menuOption)
            {
                case "1":
                    FinancialManager.expenseEntries.Add(new ExpenseEntry(userInput._id, userInput.Date, userInput.Value, userInput.Description, userInput.Category));
                    userInput = FinancialManager.expenseEntries.Find(pe => pe._id.Equals(userInput._id))!;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"ID: {userInput._id} Data: {userInput!.Date} Valor: {userInput.Value} Descrição: {userInput.Description} Categoria: {userInput.Category}");
                    return;
                case "2":
                    FinancialManager.revenueEntries.Add(new RevenueEntry(userInput._id, userInput.Date, userInput.Value, userInput.Description, userInput.Category));
                    userInput = FinancialManager.revenueEntries.Find(pe => pe._id.Equals(userInput._id))!;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"ID: {userInput._id} Data: {userInput!.Date} Valor: {userInput.Value} Descrição: {userInput.Description} Categoria: {userInput.Category}");
                    return;
            }
        }
    }
}



