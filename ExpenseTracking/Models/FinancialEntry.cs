using ExpenseTracking.managers;

namespace ExpenseTracking.models
{
    public abstract class FinancialEntry
    {
        public int Id { get; }
        public DateOnly Date{ get; set; }
        public float Value { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public FinancialEntry(int id, DateOnly date, float value, string description, string category)
        {
            Id = id;
            Date = date;
            Value = value;
            Description = description;
            Category = category;
        }
    }
}
