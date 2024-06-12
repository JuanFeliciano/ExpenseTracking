using ExpenseTracking.managers;

namespace ExpenseTracking.models
{
    public abstract class FinancialEntry
    {
        public int Id { get; set; }
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

        public static void PrintData(FinancialEntry item)
        {
            Console.WriteLine($"ID: {item.Id} Data: {item.Date} Valor: {item.Value} Descrição: {item.Description} Categoria: {item.Category}\n");
        }
    }
}
