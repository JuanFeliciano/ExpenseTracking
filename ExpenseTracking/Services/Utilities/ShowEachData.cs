using ExpenseTracking.Managers;
using ExpenseTracking.Models;
using System.Reflection.Metadata.Ecma335;

namespace ExpenseTracking.Services.Utilities
{
    internal class ShowEachData

    {
        public static void ShowExpenseData()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Despesas: ");
            if (FinancialManager.expenseEntries.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                FinancialManager.expenseEntries.ForEach(ee => Console.WriteLine($"ID: {ee._id} Data: {ee.Date} Valor: {ee.Value} Descrição: {ee.Description} Categoria: {ee.Category}\n"));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não existem dados a consultar!");
            }
        }
        public static void ShowRevenueData()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Receitas:");
            if (FinancialManager.revenueEntries.Count > 0)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                FinancialManager.revenueEntries.ForEach(re => Console.WriteLine($"ID: {re._id} Data: {re.Date} Valor: {re.Value} Descrição: {re.Description} Categoria: {re.Category}\n"));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não existem dados a consultar!");
            }
        }
    }
}
