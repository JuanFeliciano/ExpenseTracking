using ExpenseTracking.managers;
using ExpenseTracking.models;
using ExpenseTracking.services.usecases;
using System;

namespace ExpenseTracking.services.utilities
{
    internal class DeleteEachData
    {
        public static void DeleteExpenseData()
        {

            ExpenseEntry itemQuery;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Digite ´sair´ para fechar o programa!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite por ID a despesa desejada para exclusão: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string id = Console.ReadLine()!.Trim();
            ExitCommand.Check(id);

            int parseId;
            if (int.TryParse(id, out parseId) == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ID inválido!");
                return;
            }

            itemQuery = FinancialManager.expenseEntries.Find(i => i.Id.Equals(parseId))!;

            if (itemQuery is null)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ID inválido!");
                return;
            }

            FinancialManager.expenseEntries.Remove(itemQuery);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Despesa deletada com sucesso!");
        }

        public static void DeleteRevenueData()
        {
            ;

            RevenueEntry itemQuery;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite por ID a receita desejada para exclusão: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string id = Console.ReadLine()!.Trim();
            ExitCommand.Check(id);

            int parseId;
            if (int.TryParse(id, out parseId) == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ID inválido!");
                return;
            }

            itemQuery = FinancialManager.revenueEntries.Find(i => i.Id.Equals(parseId))!;

            if (itemQuery is null)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ID inválido!");
                return;
            }
            FinancialManager.revenueEntries.Remove(itemQuery);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Receita deletada com sucesso!");
        }
    }
}
