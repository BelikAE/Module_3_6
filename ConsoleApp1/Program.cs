using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string str1 = Console.ReadLine().Replace(" ", "").ToLower();
            
            string str2 = "";
            foreach (char s in str1)
            {
                str2 = s + str2;

            }
            if (str1 == str2)
            {
                Console.WriteLine("Предложение палиндром");

            }
            else
            {
                Console.WriteLine("Предложение не палиндром");
            }
            Console.ReadKey();

        }
    }
}
