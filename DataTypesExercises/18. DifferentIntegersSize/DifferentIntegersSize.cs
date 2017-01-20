using System;
using System.Collections.Generic;

class DifferentIntegersSize
{
    static void Main()
    {
        string number = Console.ReadLine();
        List<string> numbers = new List<string>();

        try
        {
            sbyte s = sbyte.Parse(number.ToString());
            numbers.Add("* sbyte");
        }
        catch (Exception)
        {
        }
        try
        {
            byte s = byte.Parse(number.ToString());
            numbers.Add("* byte");
        }
        catch (Exception)
        {
        }
        try
        {
            short s = short.Parse(number.ToString());
            numbers.Add("* short");
        }
        catch (Exception)
        {
        }
        try
        {
            ushort s = ushort.Parse(number.ToString());
            numbers.Add("* ushort");
        }
        catch (Exception)
        {
        }
        try
        {
            int s = int.Parse(number.ToString());
            numbers.Add("* int");
        }
        catch (Exception)
        {
        }
        try
        {
            uint s = uint.Parse(number.ToString());
            numbers.Add("* uint");
        }
        catch (Exception)
        {
        }
        try
        {
            long s = long.Parse(number.ToString());
            numbers.Add("* long");
        }
        catch (Exception)
        {
        }
        if (numbers.Count > 0)
        {
            Console.WriteLine("{0} can fit in:", number);
            Console.WriteLine(string.Join("\n", numbers));
        }
        else
        {
            Console.WriteLine($"{number} can't fit in any type");
        }

        //string input = Console.ReadLine();

        //try
        //{
        //    long number = long.Parse(input);
        //    Console.WriteLine("{0} can fit in:", number);
        //}
        //catch (OverflowException)
        //{

        //}
        //try
        //{
        //    sbyte number = sbyte.Parse(input);
        //    Console.WriteLine("* sbyte");
        //}
        //catch (OverflowException)
        //{

        //}
        //try
        //{
        //    byte number = byte.Parse(input);
        //    Console.WriteLine("* byte");
        //}
        //catch (OverflowException)
        //{

        //}
        //try
        //{
        //    short number = short.Parse(input);
        //    Console.WriteLine("* short");
        //}
        //catch (OverflowException)
        //{

        //}
        //try
        //{
        //    ushort number = ushort.Parse(input);
        //    Console.WriteLine("* ushort");
        //}
        //catch (OverflowException)
        //{

        //}
        //try
        //{
        //    int number = int.Parse(input);
        //    Console.WriteLine("* int");
        //}
        //catch (OverflowException)
        //{

        //}
        //try
        //{
        //    uint number = uint.Parse(input);
        //    Console.WriteLine("* uint");
        //}
        //catch (OverflowException)
        //{

        //}
        //try
        //{
        //    long number = long.Parse(input);
        //    Console.WriteLine("* long");
        //}
        //catch (OverflowException)
        //{
        //    Console.WriteLine("{0} can't fit in any type", input);
        //}
    }
}






