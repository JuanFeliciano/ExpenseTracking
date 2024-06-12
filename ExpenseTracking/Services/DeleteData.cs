using ExpenseTracking.managers;

namespace ExpenseTracking.services
{
    internal class DeleteData
    {
        public static void DeleteDatas()
        {
            string option = MainProgram.GetOption();


            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Todos as despesas da lista serão removidas.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Você tem certeza desta ação? (s/n): ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string validation = Console.ReadLine()!.Trim().ToLower();



                if (validation == "s" && option == "1")
                {
                    if (FinancialManager.expenseEntries.Any() == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Não existem despesas para serem excluídas");
                        return;
                    }
                    FinancialManager.expenseEntries.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Todos as despesas removidas!");
                    return;
                }
                else if (validation == "n" && option == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Voltando ao menu principal!");
                    return;
                }
                else if (validation == "s" && option == "2")
                {
                    if (FinancialManager.revenueEntries.Any() == false)
                    {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Não existem receitas para serem excluídas");
                            return;
                    }
                    FinancialManager.revenueEntries.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Todos as receitas removidos!");
                    return;
                }
                else if (validation == "n" && option == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Voltando ao menu principal!");
                    return;
                }
            }
        }
    }
}
