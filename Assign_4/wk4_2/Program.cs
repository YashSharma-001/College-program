﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk4_2
{
    internal class Program
    {
        public string name, model, year;
        public string Car
        {
            get
            {
                return (name + " " + model + " " + year);
            }
            set
            {
                name = value;
                model = value;
                year = value;
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.name = "Toyota";
            obj.model = "camry";
            obj.year = "2022";
            Console.WriteLine(obj.Car);
            Console.Read();

        }
    }

}
