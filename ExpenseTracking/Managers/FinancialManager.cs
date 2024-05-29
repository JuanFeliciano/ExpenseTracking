using ExpenseTracking.Models;
using ExpenseTracking.Services;

namespace ExpenseTracking.Managers
{
    public class FinancialManager
    {
        public static List<ExpenseEntry> expenseEntries = new List<ExpenseEntry>();
        public static List<RevenueEntry> revenueEntries = new List<RevenueEntry>();
        public void AddData()
        {
            Services.AddData.AddDatas();
        }

        public void EditData()
        {
            Services.EditData.EditDatas();
        }

        public void DeleteData()
        {
            Services.DeleteData.DeleteDatas();
        }

        public void ShowData()
        {
            Services.ShowData.ShowDatas();
        }
    }
}
