using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace arraying
{
    class Program
    {


        public static int[] Capitals(string word)
        {
            char[] chars = word.ToCharArray(); // 'S','p','o','T',.. chars[]

            List<int> someList = new List<int>();



            for (int i = 0; i < chars.Length; i++)
            {
                bool result = Char.IsUpper(word, i);
                if (result is true)
                {
                    someList.Add(i);
                }
            }


            int[] capitals = someList.ToArray();



            return capitals;

        }

        static void Main(string[] args)
        {
            string word = "SpoTifY";
            Capitals(word);


        }
    }
}