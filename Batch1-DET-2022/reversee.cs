﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class reversee
    {
        public static void Main()
        {
            string[] words = { "blueberry", "blackberry", "abacus" };
           var result =  words.OrderBy(x=>x);
            foreach (string item in result)
                Console.WriteLine(item.Reverse().ToArray());
                


        }

    
	


	}
	}
    
    

