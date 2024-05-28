using ExpenseTracking.Managers;
using ExpenseTracking.Models;

namespace ExpenseTracking.Services
{
    internal class EditData
    {
        public static void EditDatas()
        {
            string option = MainProgram.GetOption();
            FinancialEntry itemQuery;

            Console.WriteLine("Digite por ID o item desejado para remover: ");
            int idUser = int.Parse(Console.ReadLine()!);

            switch (option)
            {
                case "1":
                    itemQuery = FinancialManager.expenseEntries.Find(pe => pe._id.Equals(idUser))!;
                    break;
                case "2":
                    itemQuery = FinancialManager.revenueEntries.Find(pe => pe._id.Equals(idUser))!;
                    break;
            }
        }

    }
}
