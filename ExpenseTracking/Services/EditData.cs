using ExpenseTracking.managers;
using ExpenseTracking.models;
using ExpenseTracking.services.utilities;

namespace ExpenseTracking.services
{
    internal class EditData
    {
        public static void EditDatas()
        {
            string option = MainProgram.GetOption();
            FinancialEntry itemQuery;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite por ID o item desejado para editar: ");
            Console.ForegroundColor = ConsoleColor.White;
            int idUser = int.Parse(Console.ReadLine()!.Trim());
            
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
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("ID inválido!");
                        return;
                    }
                    FinancialManager.expenseEntries.Add(new ExpenseEntry(idUser, userInput.Date,userInput.Value, userInput.Description, userInput.Category));
                    Console.WriteLine($"ID: {userInput._id} Data: {userInput!.Date} Valor: {userInput.Value} Descrição: {userInput.Description} Categoria: {userInput.Category}");
                    return;
                case "2":
                    itemQuery = FinancialManager.revenueEntries.Find(pe => pe._id.Equals(idUser))!;
                    if (itemQuery is RevenueEntry revenueEntry && itemQuery != null)
                    {
                        FinancialManager.revenueEntries.Remove(revenueEntry);
                    } 
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("ID inválido!");
                        return;
                    }
                    FinancialManager.revenueEntries.Add(new RevenueEntry(idUser, userInput.Date, userInput.Value, userInput.Description, userInput.Category));
                    return;
            }



        }

    }
}
