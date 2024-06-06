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
            string idUser = Console.ReadLine()!.Trim();
            ExitMethod.Exit(idUser);
            int id = int.Parse(idUser);

            itemQuery = FinancialManager.expenseEntries.Find(pe => pe.Id.Equals(id))!;

            if (itemQuery != null)
            {
                FinancialManager.expenseEntries.Remove(itemQuery);
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Despesa editada com sucesso!\nID: {id} Data: {userInput!.Date} Valor: -{userInput.Value} Descrição: {userInput.Description} Categoria: {userInput.Category}");
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
            string idUser = Console.ReadLine()!.Trim();
            ExitMethod.Exit(idUser);
            int id = int.Parse(idUser);

            itemQuery = FinancialManager.revenueEntries.Find(pe => pe.Id.Equals(id))!;
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
            FinancialManager.revenueEntries.Add(new RevenueEntry(id, userInput.Date, userInput.Value, userInput.Description, userInput.Category));
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Receita editada com sucesso!\nID: {id} Data: {userInput!.Date} Valor: {userInput.Value} Descrição: {userInput.Description} Categoria: {userInput.Category}");
            return;
        }
    }
}
