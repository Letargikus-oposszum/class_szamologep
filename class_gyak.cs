﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassWork0921
{
    public class szamologep
    {
        public void összeg()
        {
            Console.WriteLine("Adj meg egy számot: ");
            string a = Console.ReadLine();
            int szam1 = int.Parse(a);

            Console.WriteLine("Adj meg egy újabb számot: ");
            string b = Console.ReadLine();
            int szam2 = int.Parse(b);

            Console.WriteLine(szam1 + szam2);
        }
        public void kivonas()
        {
            Console.WriteLine("Adj meg egy számot: ");
            string a = Console.ReadLine();
            int szam1 = int.Parse(a);

            Console.WriteLine("Adj meg egy újabb számot: ");
            string b = Console.ReadLine();
            int szam2 = int.Parse(b);

            Console.WriteLine(szam1 - szam2);

        }
    }
}
