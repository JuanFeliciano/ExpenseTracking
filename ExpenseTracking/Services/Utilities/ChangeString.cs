namespace ExpenseTracking.services.utilities
{
    public class ChangeString
    {
        public string PluralReturn()
        {
            string option = MainProgram.GetOption();
            string plural = "";

            if (option == "1")
            {
                plural = "despesas";
            }
            else if (option == "2")
            {
                plural = "receitas";
            }

            return plural;
        }

        public string SingularReturn()
        {
            string option = MainProgram.GetOption();
            string singular = "";

            if (option == "1")
            {
                singular = "despesa";
            }
            else if (option == "2")
            {
                singular = "receita";
            }

            return singular;
        }
    }
}
