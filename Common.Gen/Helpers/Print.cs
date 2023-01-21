using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public static class Print
    {
        public static void WriteLine(string format, params object[] args)
        {
            var separator = string.Empty;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(format, args);
        }

        public static void WriteWarningLine(string format, params object[] args)
        {
            var separator = string.Empty;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(format, args);
        }
    }
}
