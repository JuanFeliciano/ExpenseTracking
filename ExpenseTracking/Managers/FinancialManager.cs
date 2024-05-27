using ExpenseTracking.Models;
using ExpenseTracking.Services.ExpenseService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracking.Managers
{
    public class FinancialManager
    {
        AddExpense addexpense = new();


        public static List<ExpenseEntry> expenseEntries = new List<ExpenseEntry>();
        public static List<RevenueEntry> revenueEntries = new List<RevenueEntry>();
        public void AddExpense()
        {
            addexpense.AddNewExpense();
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
