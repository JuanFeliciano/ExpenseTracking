using ExpenseTracking.Managers;
using ExpenseTracking.Models;
using System.Globalization;

namespace ExpenseTracking.Services
{
    public class AddData
    {
        public static void AddDatas()
        {
            string menuOption = MainProgram.GetOption();
            int idExpense = FinancialManager.expenseEntries.Count;
            int idRevenue = FinancialManager.revenueEntries.Count;
            Console.WriteLine("Digite os dados: ");

            Console.WriteLine("Data (DD/MM/AAAA): ");
            string dateTime = Console.ReadLine()!;
            Console.WriteLine("Valor: ");
            int value = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Descrição: ");
            string description = Console.ReadLine()!;
            Console.WriteLine("Categoria: ");
            string category = Console.ReadLine()!;


            if (!DateOnly.TryParseExact(dateTime, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateOnly date))
            {
                Console.WriteLine("Data inválida!");
                return;
            }


            switch (menuOption)
            {
                case "1":
                    idExpense++;
                    FinancialManager.expenseEntries.Add(new ExpenseEntry(idExpense, date, value, description, category));
                    return;
                case "2":
                    idRevenue++;
                    FinancialManager.revenueEntries.Add(new RevenueEntry(idRevenue, date, value, description, category));
                    return;
                default:
                    return;
            }
        }
    }
}



