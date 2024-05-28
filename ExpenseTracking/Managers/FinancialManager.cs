using ExpenseTracking.Models;
using ExpenseTracking.Services;

namespace ExpenseTracking.Managers
{
    public class FinancialManager
    {
        public static List<ExpenseEntry> expenseEntries = new List<ExpenseEntry>();
        public static List<RevenueEntry> revenueEntries = new List<RevenueEntry>();
        public void AddExpense()
        {
            AddData.AddDatas();
        }

        public string EditExpense()
        {
            return "";
        }

        public string DeleteExpense()
        {
            return "";
        }

        public string ShowExpenses()
        {
            return "";
        }
    }
}
