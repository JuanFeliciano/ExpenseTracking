using ExpenseTracking.managers;
using ExpenseTracking.models;
using ExpenseTracking.services.usecases;
using System;
using System.Globalization;
using System.Security;

namespace ExpenseTracking.services.utilities
{
    internal class UserInput
    {
        public static int idExpense = 0;
        public static int idRevenue = 0;
        public static FinancialEntry CollectUserInput()
        {
            string menuOption = MainProgram.GetOption();

            while (true)
            {
                DateOnly date;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Digite ´sair´ a qualquer momento para fechar o programa!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Digite os dados: ");

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Data (DD/MM/AAAA): ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    string dateTime = Console.ReadLine()!.Trim();

                    ExitCommand.Check(dateTime);

                    if (DateOnly.TryParseExact(dateTime, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                    {
                        break;
                    }
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Data inválida!");
                }

                float value;
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Valor (xx,x): ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    string userValue = Console.ReadLine()!.Trim();

                    ExitCommand.Check(userValue);

                    if (userValue[0] == '-')
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Não é possivel adicionar valores negativos!");
                        continue;
                    }
                    if (float.TryParse(userValue, out value))
                    {
                        break;
                    }
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Valor inválido!");

                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Descrição: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string description = Console.ReadLine()!.Trim();

                ExitCommand.Check(description);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Categoria: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string category = Console.ReadLine()!.Trim();

                ExitCommand.Check(category);

                switch (menuOption)
                {
                    case "1":
                        idExpense++;
                        return new ExpenseEntry(idExpense, date, value, description, category);
                    case "2":
                        idRevenue++;
                        return new RevenueEntry(idRevenue, date, value, description, category);
                }
            }
        }
    }
}
