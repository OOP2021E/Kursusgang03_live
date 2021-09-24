using System.Collections.Generic;

namespace FStreamSolution
{
    internal class LengthComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.Length.CompareTo(y)*-1;
        }
    }
}