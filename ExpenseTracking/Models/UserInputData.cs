using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracking.Models
{
    internal class UserInputData
    {
        public DateOnly Date { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public UserInputData(DateOnly date, int value, string description, string category)
        {
            Date = date;
            Value = value;
            Description = description;
            Category = category;
        }
    }
}
