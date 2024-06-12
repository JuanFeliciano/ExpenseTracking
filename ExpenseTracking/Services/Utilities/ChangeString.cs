namespace ExpenseTracking.services.utilities
{
    public class ChangeString
    {
        public string PluralReturn()
        {
            string option = MainProgram.GetOption();
            string plural = option == "1" ? "despesas" : "receitas";

            return plural;
        }

        public string SingularReturn()
        {
            string option = MainProgram.GetOption();
            string singular = option == "1" ? "despesa" : "receita";

            return singular;
        }
    }
}
