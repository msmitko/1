using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvertNumberToWords
{
    public static class Program
    {
        public static string ConvertNumberToCurrency(double Number)
        {
            var result = "";
            var totalValue = Math.Truncate(Number);
            var value = Program.ConvertNumberToWords((int)totalValue);
            // we can extend this formatting string value when specific type of currency need to print. 
            var totalString = string.Format("{0}", value);

            if (totalValue > 0)
                result = string.Format("{0}", totalString);

            return result;
        }

        public static string ConvertNumberToWords(int Number)
        {
            StringBuilder word = new StringBuilder();

            var ones = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tens = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            var units = new[] { "hundred" };

            if (Number < 0)
                word.Append(" "+ ConvertNumberToWords(Math.Abs(Number)));

            // zero - nineteen
            else if (Number < 20)
                word.Append(ones[Number]);

            else if (Number > 99)
            {
                int log = (int)Math.Log(Number, 1000);
                int pow = (int)Math.Pow(1000, log);

                if (pow > 1)
                    word.Append(ConvertNumberToWords(Number / pow) + " " + units[log]);
                else // hundreds
                {
                    pow = 100;
                    word.Append(ones[Number / 100] + " " + units[0]);
                }

                // handle the remainder
                if (Number % pow > 0)
                {
                    Number = Number % pow;
                    word.Append(Number < 1000 ? " " : " ");
                    word.Append(ConvertNumberToWords(Number));
                }
            }
            // twenty - ninety-nine
            else if (Number > 19)
            {
                word.Append(tens[Number / 10]);
                // handle the remainder
                if (Number % 10 > 0)
                    word.Append(" " + ConvertNumberToWords(Number % 10));
            }
            return word.ToString();
        }
    }
}
