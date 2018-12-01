using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvertNumberToWords
{
    class ProgramIntro
    {
        public static void Main()
        {
            Console.WriteLine("Enter digit value. Eg : 368");
            string value = Console.ReadLine();           
            Console.WriteLine(Program.ConvertNumberToCurrency(double.Parse(value)));
            Console.ReadLine();
        }
    }
}
