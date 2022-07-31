using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07
{
    internal class BCoder : ICoder
    {
        public string Decode(string input)
        {
            int first = 1040;
            int last = 1103;
            char newChar;
            StringBuilder sb = new();

            foreach (char c in input)
            {
                newChar = (char)(first + (last - (short)c));
                sb.Append(newChar);
            }

            return sb.ToString();
        }
        public string Encode(string input)
        {
            int first = 1040;
            int last = 1103;
            char newChar;
            StringBuilder sb = new();

            foreach (char c in input)
            {
                newChar = (char)(last - ((short)c - first));
                sb.Append(newChar);
            }

            return sb.ToString();
        }
    }
}
