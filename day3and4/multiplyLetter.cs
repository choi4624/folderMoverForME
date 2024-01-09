using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3and4
{
    internal class multiplyLetter
    {
        public string solution(string my_string, int k)
        {
            string answer = "";
            for (int i = 0; i < k; i++)
            {
                answer += my_string;
            }
            return answer;
        }
    }
}
