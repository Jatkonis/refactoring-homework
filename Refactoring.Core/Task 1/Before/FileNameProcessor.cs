using System.Collections.Generic;
using System.Text;

namespace Refactoring.Core.Task_1.Before
{
    public static class FileNameProcessor
    {
        private static StringBuilder _sb = new StringBuilder();

        public static string BuildGoodString(IEnumerable<string> strings)
        {
            foreach (var s in strings)
            {
                _sb.AppendLine(s);
            }

            var temp = _sb.ToString();

            _sb = new StringBuilder();
            return temp;
        }
    }
}