using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3and4
{
    internal class StringToOperator
    {
        public int solution(string ineq, string eq, int n, int m)
        {
            int answer = 0;
            string op = string.Concat(ineq, eq);
            switch (op)
            {
                case "<=":
                    answer = (n <= m ? 1 : 0); break;
                case ">=":
                    answer = (n >= m ? 0 : 1); break;
                case ">!":
                    answer = (n > m ? 1 : 0); break;
                case "<!":
                    answer = (n < m ? 0 : 1); break;
                default: throw new ArgumentException("op");
            }
            return answer;
        }
        public int flags(int a, int b, bool flag)
        {
            int answer = 0;
            if (flag)
            {
                answer = a + b;
            }
            else
            {
                answer = a - b;
            }
            return answer;
        }
    }
}
