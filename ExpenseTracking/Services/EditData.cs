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
            int idUser;
            
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite por ID o item desejado para editar: ");
                Console.ForegroundColor = ConsoleColor.White;
                string id = Console.ReadLine()!.Trim();

                if (int.TryParse(id, out idUser))
                {
                    break;  
                }

            }

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
                    var userInput = UserInput.CollectUserInput();
                    FinancialManager.expenseEntries.Add(new ExpenseEntry(idUser, userInput.Date, userInput.Value, userInput.Description, userInput.Category));
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Item editado com sucesso!\nID: {idUser} Data: {userInput!.Date} Valor: {userInput.Value} Descrição: {userInput.Description} Categoria: {userInput.Category}");
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
                    var userOutput = UserInput.CollectUserInput();
                    FinancialManager.revenueEntries.Add(new RevenueEntry(idUser, userOutput.Date, userOutput.Value, userOutput.Description, userOutput.Category));
                    Console.WriteLine($"Item editado com sucesso!\nID: {idUser} Data: {userOutput!.Date} Valor: {userOutput.Value} Descrição: {userOutput.Description} Categoria: {userOutput.Category}");
                    return;
            }
        }
    }
}
