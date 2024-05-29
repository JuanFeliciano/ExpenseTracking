using ExpenseTracking.services.utilities;

namespace ExpenseTracking.services
{
    internal class ShowData
    {
        public static void ShowDatas()
        {
            string option = MainProgram.GetOption();

            switch (option)
            {
                case "1":
                    ShowEachData.ShowExpenseData();
                    return;
                case "2":
                    ShowEachData.ShowRevenueData();
                    return;
            }
        }
    }
}
