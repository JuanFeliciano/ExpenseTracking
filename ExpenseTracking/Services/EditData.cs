using ExpenseTracking.Managers;
using ExpenseTracking.Models;
using ExpenseTracking.Services.Utilities;

namespace ExpenseTracking.Services
{
    internal class EditData
    {
        public static void EditDatas()
        {
            string option = MainProgram.GetOption();
            FinancialEntry itemQuery;

            Console.WriteLine("Digite por ID o item desejado para remover: ");
            int idUser = int.Parse(Console.ReadLine()!);
            
            var userInput = UserInput.CollectUserInput();

            switch (option)
            {
                case "1":
                    itemQuery = FinancialManager.expenseEntries.Find(pe => pe._id.Equals(idUser))!;
                    if (itemQuery is ExpenseEntry expenseEntry && itemQuery != null)
                    {
                        FinancialManager.expenseEntries.Remove(expenseEntry);
                    }
                    else
                    {
                        Console.WriteLine("ID inválido!");
                        return;
                    }
                    FinancialManager.expenseEntries.Add(new ExpenseEntry(idUser, userInput.Date,userInput.Value, userInput.Description, userInput.Category));
                    return;
                case "2":
                    itemQuery = FinancialManager.revenueEntries.Find(pe => pe._id.Equals(idUser))!;
                    if (itemQuery is RevenueEntry revenueEntry && itemQuery != null)
                    {
                        FinancialManager.revenueEntries.Remove(revenueEntry);
                    } 
                    else
                    {
                        Console.WriteLine("ID inválido!");
                        return;
                    }
                    FinancialManager.revenueEntries.Add(new RevenueEntry(idUser, userInput.Date, userInput.Value, userInput.Description, userInput.Category));
                    return;
            }



        }

    }
}
