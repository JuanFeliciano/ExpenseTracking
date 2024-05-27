using ExpenseTracking.Managers;

namespace ExpenseTracking
{
    internal class MainProgram
    {
        public static string Main()
        {
            FinancialManager expensemanager = new();


            Console.WriteLine("Digite o que deseja manipular: ");
            Console.WriteLine("1 - Despesas");
            Console.WriteLine("2 - Receitas");
            Console.WriteLine("3 - Listar todos os dados");
            Console.WriteLine("4 - Sair");

            string option = Console.ReadLine()!;

            while (true)
            {
                switch (option)
                {
                    case "1":
                        expensemanager.AddExpense();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida!");
                        break;
                }
            return option;
            }

        }
    }
}