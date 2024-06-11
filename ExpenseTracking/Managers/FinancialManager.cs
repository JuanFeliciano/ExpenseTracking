using ExpenseTracking.models;

namespace ExpenseTracking.managers
{
    public class FinancialManager
    {
        public static readonly List<ExpenseEntry> expenseEntries = new();
        public static readonly List<RevenueEntry> revenueEntries = new();

        public static void AddData()
        {
            services.AddData.AddDatas();
        }

        public static void EditData()
        {
            services.EditData.EditDatas();
        }

        public static void DeleteOneData()
        {
            services.DeleteOneData.DeleteOneDatas();
        }
        public static void DeleteData()
        {
            services.DeleteData.DeleteDatas();
        }

        public static void ShowData()
        {
            services.ShowData.ShowDatas();
        }

        public static void SearchData()
        {
            services.SearchData.SearchDatas();
        }
    }
}
