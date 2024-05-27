using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracking.Models
{
    public class ExpenseEntry : FinancialEntry
    {
        public ExpenseEntry(DateTime date, int value, string description, string category) : base(date,value,description,category)
        {}
    }
}
