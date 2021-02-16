using System;

namespace _09Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "The \"use\" of quotations causes difficulties.";
            string b = @"The ""use"" ofquotations causes difficulties.";
            Console.WriteLine(a);
            Console.WriteLine(b);
            

        }
    }
}
