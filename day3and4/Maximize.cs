using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3and4
{
    internal class Maximize
    {
        public int solution(int a, int b)
        {
            int answer = 0;
            int a1 = int.Parse(string.Concat(a,b));
            int a2 = int.Parse(string.Concat(b,a));
            answer = a1>a2 ? a1 : a2;
            return answer;
        }

        public int compare(int a, int b)
        {
            int answer = 0;
            int a1 = int.Parse(string.Concat(a, b));
            int a2 = 2 * a * b;
            answer = a1 > a2 ? a1 : a2;
            return answer;
        }
        public int Number(int n)
        {
            int answer = 0; 
            if(n%2 == 0)
            {
                for (int i = 2; i <= n; i = i+2)
                {
                    answer = answer + i*i;

                }
            }
            else if(n%2 == 1)
            {
                for(int i = 1;i <= n; i = i + 2)
                {
                    answer = answer + i;
                }
            }

            return answer;
        }
    }
}
