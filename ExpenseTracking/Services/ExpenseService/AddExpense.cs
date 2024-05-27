using ExpenseTracking.Managers;
using ExpenseTracking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracking.Services.ExpenseService
{
    public class AddExpense
    {
        public void AddNewExpense()
        {
            string menuOption = MainProgram.Main();

            while (true)
            {
                Console.WriteLine("Digite os dados: ");
                Console.WriteLine("Data (DD/MM/AAAA): ");
                string dateTime = Console.ReadLine()!;
                Console.WriteLine("Valor: ");
                int value = Console.Read();
                Console.WriteLine("Descrição: ");
                string description = Console.Read().ToString();
                Console.WriteLine("Categoria: ");
                string category = Console.Read().ToString();

                if (DateTime.TryParse(dateTime, out DateTime date))
                {
                    Console.WriteLine("Data Concluída!");
                }
                else
                {
                    Console.WriteLine("Data inválida!");
                }

                switch (menuOption)
                {
                    case "1":
                        FinancialManager.expenseEntries.Add(new ExpenseEntry(date, value, description, category));
                        return;
                    case "2":
                        FinancialManager.revenueEntries.Add(new RevenueEntry(date, value, description, category));
                        return;

                }
            }
        }
    }
}

