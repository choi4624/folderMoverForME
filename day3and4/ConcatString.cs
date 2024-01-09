using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3and4
{
    internal class ConcatString
    {
        public string solution(string[] arr)
        {
            string answer = "";
            answer = string.Concat(arr);
            return answer;
        }
    }
}
