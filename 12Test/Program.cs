using System;

namespace _12Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Put your name : ");
            string Name = Console.ReadLine();
            Console.Write("Put your age : ");
            int Age = int.Parse(Console.ReadLine());
            Console.Write("Your sex is : ");
            string Sex = Console.ReadLine();
            Console.Write("Write your ID number : ");
            string ID = Console.ReadLine();
            Console.WriteLine($"Your name is: {Name}. \nYour age is: {Age}. \nYour sex is: {Sex}. \nYour ID \"Individual Indificate Number\" is: {ID}. ");
            


        }
    }
}
