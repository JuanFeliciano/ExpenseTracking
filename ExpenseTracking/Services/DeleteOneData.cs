using ExpenseTracking.services.utilities;

namespace ExpenseTracking.services
{
    internal class DeleteOneData
    {
        public static void DeleteOneDatas()
        {
            string option = MainProgram.GetOption();

            switch (option)
            {
                case "1":
                    DeleteEachData.DeleteExpenseData();
                    return;
                case "2":
                    DeleteEachData.DeleteRevenueData();
                    return;
            }
        }
    }
}
