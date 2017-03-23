using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class StrUtil
    {
        public static string ReverseString(string data)
        {
            string[] words = data.Split(' ');
            StringBuilder text = new StringBuilder();
            for(int cnt=words.Length-1; cnt >=0; cnt--)
            {
                text.Append(words[cnt]);
                text.Append(" ");
            }

            return text.ToString();
        }
    }
}
