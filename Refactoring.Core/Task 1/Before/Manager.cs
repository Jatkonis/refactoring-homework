using System;

namespace Refactoring.Core.Task_1.Before
{
    public static class Manager
    {
        public static void Start()
        {
            var path = Console.ReadLine();
            var work = FileReader.DoWork(path);

            Console.WriteLine(work);
            Console.ReadKey();
        }
    }
}