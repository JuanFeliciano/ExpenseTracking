using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracking.services.usecases
{
    internal class ExitMethod
    {
        public static void Exit(string value)
        {
            if (value == "sair")
            {
                Console.Clear();
                MainProgram.Main();
            }
        }
    }
}
