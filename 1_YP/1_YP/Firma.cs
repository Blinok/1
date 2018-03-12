using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_YP
{
    class Firma
    {
        private string name;
        private string adres;
        private int year;
        public string Name { get; set; }
        public string Adres { get; set; }
        public int Year { get; set; }
        public Firma()
        {
            Name = null;
            Adres = null;
            Year = 0;
        }
        public Firma(string name, string adres, int year)
        {
            Name = name;
            Adres = adres;
            Year = year;
        }
        public virtual void Display()
        {
            Console.WriteLine("Название фирмы: " + Name);
            Console.WriteLine("Адрес фирмы: " + Adres);
            Console.WriteLine("Год основания: " + Year);
        }
        public virtual void Input()
        {
            Console.WriteLine("Название фирмы:  ");
            Name = Console.ReadLine();
            Console.WriteLine("Адрес фирмы: ");
            Adres = Console.ReadLine();
            Console.WriteLine("Год основания: ");
            Year = Convert.ToInt32(Console.ReadLine());
        }
    }
}
