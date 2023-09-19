﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk_4_5
{
    class customlist<T>
    {
        private T[] arr = new T[100];
        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }

    class mca
    {
        int id;
        string name;
        public object this[int index]
        {
            get
            {
                if (index == 1)
                    return name;
                else
                    return id;
            }
            set
            {
                if (index == 1)
                    name = value.ToString();
                else
                    id = (int)value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var list = new customlist<string>();
            list[2] = "Hello Guru!";
            list[5] = "I am From Mathura";

            Console.WriteLine(list[2]);
            Console.WriteLine(list[5]);
            Console.Read();
        }
    }
}
