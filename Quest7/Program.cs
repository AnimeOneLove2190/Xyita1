﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest7
{
    class Program
    {
        static void Main(string[] args)
        {
            int time1 = int.Parse(Console.ReadLine());
            time1 = time1 / 60;
            Console.WriteLine(time1);
            Console.WriteLine("Программа завершена. Нажмите Enter для выхода.");
            Console.ReadLine();
            // изменение названия
        }
    }
}
