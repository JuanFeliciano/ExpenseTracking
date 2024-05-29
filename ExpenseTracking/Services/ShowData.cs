using ExpenseTracking.Services.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracking.Services
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
