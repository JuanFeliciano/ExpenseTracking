namespace ExpenseTracking.models
{
    public class FinancialEntry
    {
        public int _id;
        public DateOnly Date{ get; set; }
        public float Value { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public FinancialEntry(int id, DateOnly date, float value, string description, string category)
        {
            _id = id;
            Date = date;
            Value = value;
            Description = description;
            Category = category;
        }
    }
}
