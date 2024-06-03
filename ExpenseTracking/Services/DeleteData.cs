using ExpenseTracking.managers;

namespace ExpenseTracking.services
{
    internal class DeleteData
    {
        public static void DeleteDatas()
        {
            string option = MainProgram.GetOption();
            var lenghtExpense = FinancialManager.expenseEntries.Count;
            var lenghtRevenue = FinancialManager.revenueEntries.Count;


            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Todos as despesas da lista serão removidas.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Você tem certeza desta ação? (s/n): ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string sure = Console.ReadLine()!.Trim().ToLower();



                if (sure == "s" && option == "1")
                {
                    switch (lenghtExpense)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Não existem despesas para serem excluídas");
                            return;
                    }

                    FinancialManager.expenseEntries.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Todos as despesas removidas!");
                    return;
                }
                else if (sure == "n" && option == "1")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Voltando ao menu principal!");
                    return;
                }
                else if (sure == "s" && option == "2")
                {
                    switch (lenghtRevenue)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Não existem receitas para serem excluídas");
                            return;
                    }
                    FinancialManager.revenueEntries.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Todos as receitas removidos!");
                    return;
                }
                else if (sure == "n" && option == "2")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Voltando ao menu principal!");
                    return;
                }
            }
        }
    }
}
