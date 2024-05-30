﻿namespace ExpenseTracking.models
{
    public class ExpenseEntry : FinancialEntry
    {
        public ExpenseEntry(int id, DateOnly date, float value, string description, string category) : base(id,date,value,description,category)
        {}
    }
}
