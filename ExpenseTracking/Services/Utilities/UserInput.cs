using ExpenseTracking.Models;
using System.Globalization;

namespace ExpenseTracking.Services.Utilities
{
    internal class UserInput
    {
        public static UserInputData CollectUserInput()
        {
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

            return new UserInputData
            {
                Date = date,
                Value = value,
                Description = description,
                Category = category,
            };
        }
    }
}
