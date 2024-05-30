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
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Todos os itens da lista serão removidos.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você tem certeza desta ação? (s/n): ");
                Console.ForegroundColor = ConsoleColor.White;
                string sure = Console.ReadLine()!.Trim().ToLower();



                if (sure == "s" && option == "1")
                {
                    switch (lenghtExpense)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Não existem itens para serem excluídos");
                            return;
                    }

                    FinancialManager.expenseEntries.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Todos os itens removidos!");
                    return;
                }
                else if (sure == "n" && option == "1")
                {
                    Console.WriteLine("Voltando ao menu principal!");
                    return;
                }
                else if (sure == "s" && option == "2")
                {
                    switch (lenghtRevenue)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Não existem itens para serem excluídos");
                            return;
                    }
                    FinancialManager.revenueEntries.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Todos os itens removidos!");
                    return;
                }
                else if (sure == "n" && option == "2")
                {
                    Console.WriteLine("Voltando ao menu principal!");
                    return;
                }
            }
        }
    }
}
