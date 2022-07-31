using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07
{
    internal class ACoder : ICoder
    {
        public string Decode(string input)
        {
            char newChar;
            StringBuilder sb = new();

            foreach (char c in input)
            {
                newChar = (char)((short)c - 1);
                sb.Append(newChar);
            }

            return sb.ToString();
        }

        public string Encode(string input)
        {
            char newChar;
            StringBuilder sb = new();

            foreach (char c in input)
            {
                newChar = (char)((short)c + 1);
                sb.Append(newChar);
            }

            return sb.ToString();
        }
    }
}
