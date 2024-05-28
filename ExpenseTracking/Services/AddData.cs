using ExpenseTracking.Managers;
using ExpenseTracking.Models;
using ExpenseTracking.Services.Utilities;

namespace ExpenseTracking.Services
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
                    Console.WriteLine($"ID: {searchItem._id}\nData: {searchItem!.Date}\nValor: {searchItem.Value}\nDescrição: {searchItem.Description}\nCategoria: {searchItem.Category}");
                    return;
                case "2":
                    FinancialManager.revenueEntries.Add(new RevenueEntry(userInput._id, userInput.Date, userInput.Value, userInput.Description, userInput.Category));
                    searchItem = FinancialManager.expenseEntries.Find(pe => pe._id.Equals(userInput._id))!;
                    Console.WriteLine($"ID: {searchItem._id}\nData: {searchItem!.Date}\nValor: {searchItem.Value}\nDescrição: {searchItem.Description}\nCategoria: {searchItem.Category}");
                    return;
                default:
                    return;
            }
        }
    }
}



