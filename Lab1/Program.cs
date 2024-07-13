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
            Console.WriteLine("Введите предложение слов разделеных запятыми");
            string str = Console.ReadLine();
            string[] strArray = str.Split(',');
            string max = strArray[0];
            foreach (string s in strArray) 
            {
                if (max.Length < s.Length) 
                {
                    max = s;
                }
                
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
