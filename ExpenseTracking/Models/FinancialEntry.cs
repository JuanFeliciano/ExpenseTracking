using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracking.Models
{
    public abstract class FinancialEntry
    {
        public DateTime Date { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public FinancialEntry(DateTime date, int value, string description, string category)
        {
            Date = date;
            Value = value;
            Description = description;
            Category = category;
        }
    }
}
