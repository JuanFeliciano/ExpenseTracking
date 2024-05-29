using ExpenseTracking.managers;
using ExpenseTracking.models;
using System.Globalization;

namespace ExpenseTracking.services.utilities
{
    internal class UserInput
    {
        public static FinancialEntry CollectUserInput()
        {
            string menuOption = MainProgram.GetOption();
            int idExpense = FinancialManager.expenseEntries.Count;
            int idRevenue = FinancialManager.revenueEntries.Count;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite os dados: ");

            Console.WriteLine("Data (DD/MM/AAAA): ");
            Console.ForegroundColor = ConsoleColor.White;
            string dateTime = Console.ReadLine()!.Trim();

            if (!DateOnly.TryParseExact(dateTime, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateOnly date))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Data inválida!");
            }


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Valor: ");
            Console.ForegroundColor = ConsoleColor.White;
            string userValue = Console.ReadLine()!.Trim();

            if(!int.TryParse(userValue, out int value))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Valor inválido!");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Descrição: ");
            Console.ForegroundColor = ConsoleColor.White;
            string description = Console.ReadLine()!.Trim();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Categoria: ");
            Console.ForegroundColor = ConsoleColor.White;
            string category = Console.ReadLine()!.Trim();



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
