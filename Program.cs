//Write a program that requests the reading of a series of individual characters and count 
//howmany times the letter 'a' is entered. The user ends by entering the "$" symbol

using System;
namespace CountChar_a
{
    class Program
    {
        static void Main(string[] args)
        {
            int count=0;
            while (true)
            {
                Console.WriteLine("Enter the alphabet");
                char C= Convert.ToChar(Console.ReadLine());
                if (C== 'a')
               {
                count++;
               }
               else if (C=='$')
               break;
            }
            Console.WriteLine(" the total number of charcter 'a' is " +count);
        }
    }
}
