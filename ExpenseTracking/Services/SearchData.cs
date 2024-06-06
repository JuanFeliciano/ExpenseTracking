using ExpenseTracking.services.searchStrategies;

namespace ExpenseTracking.services
{
    internal class SearchData
    {
        public static void SearchDatas()
        {
            ShowMenu.SearchMenu();
            Console.ForegroundColor = ConsoleColor.Blue;
            string optionSearch = Console.ReadLine()!.Trim();

            switch (optionSearch)
            {
                case "1":
                    Console.Clear();
                    SearchByDate.SearchDate();
                    break;
                case "2":
                    Console.Clear();
                    SearchByValue.SearchByMinValue();
                    return;
                case "3":
                    SearchByValue.SearchByMaxValue();
                    return;
                case "4":
                    SearchByDescription.SearchDescription();
                    return;
                case "5":
                    SearchByCategory.SearchCategory();
                    return;
                case "6":
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Digite uma opção válida!");
                    break;
            }

        }
    }
}
