﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class CountString
    {
        public static void Main()
        {
            string[] words = { "believe", "relief", "reciept", "field" };
            foreach (string Word in words)
                Console.WriteLine($"{Word} -- {Word.Length}");
        }
    }
}
