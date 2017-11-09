using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listStr = new List<string>();
            string name; //to add element to list
            int i = 0;// count the elements in list
            char Exit = ' ';
            do
            {
                Console.Clear();
                Console.WriteLine("input next name");
                name = Console.ReadLine();
                listStr.Add(name);
                i++;
                Console.Write("if you will exit then press y");
                Exit = Console.ReadKey(true).KeyChar;

            } while (Exit != 'y');

            Console.Clear();
            int n;
            for ( n = 0; n < i; n++)
            {
                Console.Write(n+1 + " :");
                Console.WriteLine(listStr[n]);
            }
            Console.WriteLine("Total names are : " + n );
            Console.ReadKey();
        }
    }
}