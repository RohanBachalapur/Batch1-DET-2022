﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Max
    {
       public static void max()
        {
            int[] numbers = { 2, 8, 5, 6, 1 };

            var result = numbers.Max();

            Console.WriteLine("Highest number is:");
            Console.WriteLine(result);
        }
    }
}
