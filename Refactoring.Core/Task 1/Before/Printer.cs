using System;

namespace Refactoring.Core.Task_1.Before
{
    public static class Printer
    {
        public static void PrintToConsole(string text)
        {
            var date = DateTime.Now;

            Console.WriteLine($"{date:t}: {text}");
        }
    }
}
