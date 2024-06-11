using ExpenseTracking.managers;
using ExpenseTracking.models;
using ExpenseTracking.services.usecases;
using System;
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

                    ExitMethod.Exit(dateTime);

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

                    ExitMethod.Exit(userValue);

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

                ExitMethod.Exit(description);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Categoria: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string category = Console.ReadLine()!.Trim();

                ExitMethod.Exit(category);



                switch (menuOption)
                {
                    case "1":
                        return new ExpenseEntry(idExpense, date, value, description, category);
                    case "2":
                        return new RevenueEntry(idRevenue, date, value, description, category);
                }
            }
        }
    }
}
