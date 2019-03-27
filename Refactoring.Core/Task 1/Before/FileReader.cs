using System.IO;
using System.Linq;

namespace Refactoring.Core.Task_1.Before
{
    public static class FileReader
    {
        public static string DoWork(string path)
        {
            // read file list from root folder
            var fileList = Directory.GetFiles(path, "*" , SearchOption.AllDirectories);

            // filter needed files
            var needed = fileList.Where(f => f.Contains(".cs"));


            // build string
            var str = FileNameProcessor.BuildGoodString(needed);

            // store the names in temp storage
            var temp = Path.GetTempFileName();
            File.WriteAllText(temp, str);

            // print to console
            Printer.PrintToConsole(str);

            // return the temp file name
            return temp;
        }
    }
}