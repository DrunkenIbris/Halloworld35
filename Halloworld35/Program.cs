﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Halloworld35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo world!");
            // TODO: Lav en bedre udskrift!
            Console.WriteLine("Hallo world!");
            
            int x = 10;
            string query = "SELECT TOP " + x.ToString() + " FROM Table";

            
            Console.ReadLine();
        }
    }
}
