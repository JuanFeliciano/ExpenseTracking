﻿using ExpenseTracking.managers;

namespace ExpenseTracking.services.utilities
{
    internal class ShowEachData

    {
        public static void ShowExpenseData()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Despesas: ");

            if (FinancialManager.expenseEntries.Count <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não existem despesas para mostrar!");
                return;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            FinancialManager.expenseEntries.ForEach(ee => Console.WriteLine($"ID: {ee._id} Data: {ee.Date} Valor: -{ee.Value} Descrição: {ee.Description} Categoria: {ee.Category}\n"));

        }
        public static void ShowRevenueData()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Receitas:");

            if (FinancialManager.revenueEntries.Count <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não existem receitas para mostrar!");
                return;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            FinancialManager.revenueEntries.ForEach(re => Console.WriteLine($"ID: {re._id} Data: {re.Date} Valor: {re.Value} Descrição: {re.Description} Categoria: {re.Category}\n"));

        }
    }
}
