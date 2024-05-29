using ExpenseTracking.managers;
using ExpenseTracking.models;
using ExpenseTracking.services.utilities;

namespace ExpenseTracking.services
{
    public class AddData
    {
        public static void AddDatas()
        {
            FinancialEntry searchItem;
            string menuOption = MainProgram.GetOption();
            var userInput = UserInput.CollectUserInput();

            switch (menuOption)
            {
                case "1":
                    FinancialManager.expenseEntries.Add(new ExpenseEntry(userInput._id, userInput.Date, userInput.Value, userInput.Description, userInput.Category));
                    searchItem = FinancialManager.expenseEntries.Find(pe => pe._id.Equals(userInput._id))!;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"ID: {searchItem._id} Data: {searchItem!.Date} Valor: {searchItem.Value} Descrição: {searchItem.Description} Categoria: {searchItem.Category}");
                    return;
                case "2":
                    FinancialManager.revenueEntries.Add(new RevenueEntry(userInput._id, userInput.Date, userInput.Value, userInput.Description, userInput.Category));
                    searchItem = FinancialManager.revenueEntries.Find(pe => pe._id.Equals(userInput._id))!;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"ID: {searchItem._id} Data: {searchItem!.Date} Valor: {searchItem.Value} Descrição: {searchItem.Description} Categoria: {searchItem.Category}");
                    return;
            }
        }
    }
}



