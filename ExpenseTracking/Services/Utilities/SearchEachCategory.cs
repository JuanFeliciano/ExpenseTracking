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
            ExitMethod.Exit(userCategory);
            var categoryExpense = FinancialManager.expenseEntries.Where(ee => ee.Category.Equals(userCategory));

            if (categoryExpense.Any())
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Despesas encontradas: ");
                foreach (var ee in categoryExpense)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ee);
                }
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não foram encontradas despesas com essa categoria!");
                return;
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
            ExitMethod.Exit(userCategory);
            var categoryRevenue = FinancialManager.revenueEntries.Where(ee => ee.Category.Equals(userCategory));

            if (categoryRevenue.Any())
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Receitas encontradas: ");
                foreach (var ee in categoryRevenue)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(ee);
                }
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não foram encontrados itens com esssa categoria!");
                return;
            }
        }

    }
}
