using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex_and_Binary
{
    class IntegerHexBinary
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string toHex = Convert.ToString(number, 16).ToUpper();
            string toBin = Convert.ToString(number, 2).ToString();

            Console.WriteLine("{0}\n{1}", toHex, toBin);
        }
    }
}
