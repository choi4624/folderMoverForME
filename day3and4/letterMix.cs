using System.Text;
using System.Linq;

namespace day3and4
{
    class letterMix
    {
        // this is normal way to Mixing 
        public string solution(string str1, string str2)
        {
            string answer = "";

            var builder = new StringBuilder();
            int j = 0;
            foreach (var item in str1)
            {
                builder.Append(item);
                j++;
                if(j <= str2.Length)
                builder.Append(str2[j]);
            }
            answer = builder.ToString();
            return answer;
        }
        public string LINQway(string str1, string str2)
        {
            string answer = string.Empty;
            var query = string.Concat(str1.Zip(str2, (first, second) => first.ToString() + second.ToString()));
            answer = query.ToString();
            return answer;
            /*
             *    non-lamda expression
             *    Func<char, char, string> combineChars = delegate(char first, char second)
    {
        return first.ToString() + second.ToString();
    };

    string answer = string.Empty;
    var query = string.Concat(str1.Zip(str2, combineChars));
    answer = query.ToString();
    return answer;
             */
        }
    }
}