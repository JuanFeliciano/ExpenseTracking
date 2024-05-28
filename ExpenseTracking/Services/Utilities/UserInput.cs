using ExpenseTracking.Managers;
using ExpenseTracking.Models;
using System.Globalization;

namespace ExpenseTracking.Services.Utilities
{
    internal class UserInput
    {
        public static FinancialEntry CollectUserInput()
        {
            string menuOption = MainProgram.GetOption();
            int idExpense = FinancialManager.expenseEntries.Count;
            int idRevenue = FinancialManager.revenueEntries.Count;


            Console.WriteLine("Digite os dados: ");

            Console.WriteLine("Data (DD/MM/AAAA): ");
            string dateTime = Console.ReadLine()!;
            Console.WriteLine("Valor: ");
            string userValue = Console.ReadLine()!;

            if(!int.TryParse(userValue, out int value))
            {
                Console.WriteLine("Valor inválido!");
            }

            Console.WriteLine("Descrição: ");
            string description = Console.ReadLine()!;
            Console.WriteLine("Categoria: ");
            string category = Console.ReadLine()!;


            if (!DateOnly.TryParseExact(dateTime, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateOnly date))
            {
                Console.WriteLine("Data inválida!");
            }

            switch (menuOption)
            {
                case "1":
                    idExpense++;
                return new FinancialEntry(idExpense,date, value, description, category);
                case "2":
                    idRevenue++;
                    return new FinancialEntry(idRevenue, date, value, description, category);
                default:
                    return null!;

            }

        }
    }
}
