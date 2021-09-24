using System;
using System.Collections.Generic;
using System.IO;

namespace FStreamSolution
{


    class Solution
    {
        Stream GetStream() => new FStream();

        public void Run()
        {
            using (var s = GetStream())

            using (StreamReader sr = new StreamReader(s))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

        }
    }
}
