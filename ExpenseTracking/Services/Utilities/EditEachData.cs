using ExpenseTracking.managers;
using ExpenseTracking.models;
using ExpenseTracking.services.usecases;
using System;

namespace ExpenseTracking.services.utilities
{
    internal class EditEachData
    {
        public static void EditExpenseData()
        {

            ExpenseEntry itemQuery;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Digite ´sair´ a qualquer momento para fechar o programa!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite por ID o item desejado para editar: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string id = Console.ReadLine()!.Trim();
            ExitCommand.Check(id);
            int parseId;

            if (int.TryParse(id, out parseId) == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ID fornecido é inválido ou inexistente!");
                return;
            }

            itemQuery = FinancialManager.expenseEntries.Find(i => i.Id.Equals(parseId))!;

            if (itemQuery is null)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ID inválido ou inexistente!");
                return;
            }
                

            var userInput = UserInput.CollectUserInput();
            FinancialManager.expenseEntries.Remove(itemQuery);
            FinancialManager.expenseEntries.Add(new ExpenseEntry(parseId, userInput.Date, userInput.Value, userInput.Description, userInput.Category));
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Despesa editada com sucesso!");
            FinancialEntry.PrintData(userInput);
            return;
        }

        public static void EditRevenueData()
        {

            RevenueEntry itemQuery;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Digite ´sair a qualquer momento para fechar o programa!´");
            Console.ForegroundColor = ConsoleColor.White; 
            Console.WriteLine("Digite por ID o item desejado para editar: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string id = Console.ReadLine()!.Trim();
            ExitCommand.Check(id);
            int parseId;

            if (int.TryParse(id, out parseId) == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ID fornecido é inválido ou inexistente!");
                return;
            }

            itemQuery = FinancialManager.revenueEntries.Find(i => i.Id.Equals(parseId))!;
            if (itemQuery != null)
            {
                FinancialManager.revenueEntries.Remove(itemQuery);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ID inválido!");
                return;
            }
            var userInput = UserInput.CollectUserInput();
            FinancialManager.revenueEntries.Add(new RevenueEntry(parseId, userInput.Date, userInput.Value, userInput.Description, userInput.Category));
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Receita editada com sucesso");
            FinancialEntry.PrintData(userInput);
            return;
        }
    }
}
