using ExpenseTracking.managers;
using ExpenseTracking.models;

namespace ExpenseTracking.services.utilities
{
    internal class EditEachData
    {
        public static void EditExpenseData()
        {
            FinancialEntry itemQuery;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite por ID o item desejado para editar: ");
            Console.ForegroundColor = ConsoleColor.White;
            int id = int.Parse(Console.ReadLine()!.Trim());

            itemQuery = FinancialManager.expenseEntries.Find(pe => pe._id.Equals(id))!;

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
            FinancialManager.expenseEntries.Add(new ExpenseEntry(id, userInput.Date, userInput.Value, userInput.Description, userInput.Category));
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Item editado com sucesso!\nID: {id} Data: {userInput!.Date} Valor: {userInput.Value} Descrição: {userInput.Description} Categoria: {userInput.Category}");
            return;
        }

        public static void EditRevenueData()
        {
            FinancialEntry itemQuery;

            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine("Digite por ID o item desejado para editar: ");
            Console.ForegroundColor = ConsoleColor.White;
            int id = int.Parse(Console.ReadLine()!.Trim());

            itemQuery = FinancialManager.expenseEntries.Find(pe => pe._id.Equals(id))!;
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
            FinancialManager.expenseEntries.Add(new ExpenseEntry(id, userInput.Date, userInput.Value, userInput.Description, userInput.Category));
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Item editado com sucesso!\nID: {id} Data: {userInput!.Date} Valor: {userInput.Value} Descrição: {userInput.Description} Categoria: {userInput.Category}");
            return;
        }
    }
}
