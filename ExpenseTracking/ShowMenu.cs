using ExpenseTracking.services.utilities;

namespace ExpenseTracking
{
    internal class ShowMenu
    {   public static void MenuDefault()
        {
            ChangeString singularPlural = new();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Escolha a opção que deseja:");
            Console.WriteLine($"1 - Adicionar {singularPlural.SingularReturn()}");
            Console.WriteLine($"2 - Editar {singularPlural.SingularReturn()}");
            Console.WriteLine($"3 - Listar todos as {singularPlural.PluralReturn()}");
            Console.WriteLine($"4 - Buscar {singularPlural.SingularReturn()} única");
            Console.WriteLine($"5 - Remover todos as {singularPlural.PluralReturn()}");
            Console.WriteLine("6 - Sair");
        }

        public static void MenuMain()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite o que deseja manipular: ");
            Console.WriteLine("1 - Despesas");
            Console.WriteLine("2 - Receitas");
            Console.WriteLine("3 - Listar todos os dados");
            Console.WriteLine("4 - Sair");
        }

        public static void SearchMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite o número de acordo com a opção desejada de busca");
            Console.WriteLine("1 - Range de data (data-inicial > data-final)");
            Console.WriteLine("2 - Valor mínimo");
            Console.WriteLine("3 - Valor máximo");
            Console.WriteLine("4 - Descrição");
            Console.WriteLine("5 - Categoria");
        }
    }
}
