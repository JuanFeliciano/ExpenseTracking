

namespace ExpenseTracking.models
{
    public class RevenueEntry : FinancialEntry
    {
        public RevenueEntry(int id,DateOnly date, float value, string description, string category) : base(id,date, value, description, category)
        { }
    }
}
