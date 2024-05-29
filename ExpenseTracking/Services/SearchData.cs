

using ExpenseTracking.services.searchStrategies;

namespace ExpenseTracking.services
{
    internal class SearchData
    {
        public static void SearchDatas()
        {
            ShowMenu.ShowSearchMenu();
            string optionSearch = Console.ReadLine()!;

            switch (optionSearch)
            {
                case "1":
                    Console.Clear();
                    SearchByDate.SearchDate();
                    break;
                case "2":
                    return;
                case "3":
                    return;
                case "4":
                    return;
                case "5":
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Digite uma opção válida!");
                    break;
            }

        }
    }
}
