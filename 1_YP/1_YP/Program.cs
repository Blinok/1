using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_YP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------------------- ");
            Console.WriteLine("Введите информацию о фирме: ");
            Console.WriteLine("----------------------------------------------------------------------------- ");
            Firma st1 = new Firma();
            st1.Input();

            Console.Clear();

            Console.WriteLine("----------------------------------------------------------------------------- ");
            st1.Display();
            Console.WriteLine("----------------------------------------------------------------------------- ");

            Console.ReadKey();


        }
    }
}
