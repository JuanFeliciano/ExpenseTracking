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
            ExitMethod.Exit(id);

            if (!int.TryParse(id, out int userId))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ID inválido!");
                return;
            }

            itemQuery = FinancialManager.expenseEntries.Find(pe => pe.Id.Equals(userId))!;

            if (itemQuery != null)
            {
                FinancialManager.expenseEntries.Remove(itemQuery);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Despesa deletada com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ID inválido!");
                return;
            }
        }

        public static void DeleteRevenueData()
        {
            RevenueEntry itemQuery;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite por ID a receita desejada para exclusão: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string id = Console.ReadLine()!.Trim();
            ExitMethod.Exit(id);

            if (!int.TryParse(id, out int userId))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ID inválido!");
                return;
            }

            itemQuery = FinancialManager.revenueEntries.Find(pe => pe.Id.Equals(userId))!;

            if (itemQuery != null)
            {
                FinancialManager.revenueEntries.Remove(itemQuery);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Receita deletada com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ID inválido!");
                return;
            }
        }
    }
}
