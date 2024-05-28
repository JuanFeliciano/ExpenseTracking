using ExpenseTracking.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracking
{
    public class MenuDefault
    {
        public static void MenuOption()
        {
            FinancialManager financial = new();

            Console.WriteLine("Escolha a opção que deseja:");
            Console.WriteLine("1 - Adicionar");
            Console.WriteLine("2 - Editar");
            Console.WriteLine("3 - Listar todos os dados");
            Console.WriteLine("4 - Sair");

            string option = Console.ReadLine()!;
                
                switch (option)
            {
                case "1":
                    financial.AddExpense();
                    return;
                case "2":
                    financial.EditExpense();
                    return;
                case "3":
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Escolha uma opção válida!");
                    break;
            }
        }
    }
}
