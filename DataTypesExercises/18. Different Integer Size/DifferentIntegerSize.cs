using System;
using System.Numerics;
class DifferentIntegerSize
{
    static void Main()
    {
        PrintTypesWhichCatFit();
    }

    static void PrintTypesWhichCatFit()
    {
        BigInteger inputNum = BigInteger.Parse(Console.ReadLine());

        if (inputNum <= long.MaxValue)
        {
            Console.WriteLine($"{inputNum} can fit in:");

            if (inputNum >= sbyte.MinValue && inputNum <= sbyte.MaxValue)
                Console.WriteLine("* sbyte");
            if (inputNum >= byte.MinValue && inputNum <= byte.MaxValue)           
                Console.WriteLine("* byte");
            if (inputNum >= short.MinValue && inputNum <= short.MaxValue)           
                Console.WriteLine("* short");
            if (inputNum >= ushort.MinValue && inputNum <= ushort.MaxValue)          
                Console.WriteLine("* ushort");
            if (inputNum >= int.MinValue && inputNum <= int.MaxValue)            
                Console.WriteLine("* int");
            if (inputNum >= uint.MinValue && inputNum <= uint.MaxValue)        
                Console.WriteLine("* uint");
            if (inputNum >= long.MinValue && inputNum <= long.MaxValue)            
                Console.WriteLine("* long");             
        }
        else
            Console.WriteLine($"{inputNum} can't fit in any type");
    }
}

