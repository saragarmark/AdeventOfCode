﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AoC2020
{
    class Task1
    {
        public static void Part1()
        {
            string[] lines = File.ReadAllLines(@"../../../input/1.txt");
            foreach (string line in lines)
            {
                int entry1 = int.Parse(line);
                foreach (string line2 in lines)
                {
                    int entry2 = int.Parse(line2);
                    if (entry1 + entry2 == 2020)
                    {
                        Console.WriteLine(entry1 * entry2);
                        return;
                    }
                }
            }
        }
    }
}
