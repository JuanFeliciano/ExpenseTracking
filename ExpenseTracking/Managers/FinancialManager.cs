using ExpenseTracking.models;

namespace ExpenseTracking.managers
{
    public class FinancialManager
    {
        public static List<ExpenseEntry> expenseEntries = new List<ExpenseEntry>();
        public static List<RevenueEntry> revenueEntries = new List<RevenueEntry>();
        public void AddData()
        {
            services.AddData.AddDatas();
        }

        public void EditData()
        {
            services.EditData.EditDatas();
        }

        public void DeleteData()
        {
            services.DeleteData.DeleteDatas();
        }

        public void ShowData()
        {
            services.ShowData.ShowDatas();
        }

        public void SearchData()
        {
            services.SearchData.SearchDatas();
        }
    }
}
