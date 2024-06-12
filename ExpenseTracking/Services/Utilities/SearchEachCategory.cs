using ExpenseTracking.managers;
using ExpenseTracking.services.usecases;
using System;

namespace ExpenseTracking.services.utilities
{
    internal class SearchEachCategory
    {
        public static void SearchCategoryExpense()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Digite ´sair´ a qualquer momento para fechar o programa!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite a categoria da despesa que deseja buscar: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string userCategory = Console.ReadLine()!.ToLower().Trim();
            ExitCommand.Check(userCategory);
            var categoryExpense = FinancialManager.expenseEntries.Where(i => i.Category.Equals(userCategory));

            if (categoryExpense.Any() == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não foram encontradas despesas com essa categoria!");
                return;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Despesas encontradas: ");
            foreach (var i in categoryExpense)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(i);
            }
        }

        public static void SearchCategoryRevenue()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Digite ´sair´ a qualquer momento para fechar o programa!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite a categoria da receita que deseja buscar: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string userCategory = Console.ReadLine()!.ToLower().Trim();
            ExitCommand.Check(userCategory);
            var categoryRevenue = FinancialManager.revenueEntries.Where(i => i.Category.Equals(userCategory));

            if (categoryRevenue.Any() == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não foram encontrados itens com esssa categoria!");
                return;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Receitas encontradas: ");
            foreach (var i in categoryRevenue)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(i);
            }
        }

    }
}
