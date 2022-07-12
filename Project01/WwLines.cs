using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03
{
    internal class WwLines
    {
        public async void ReadAndCreateFile(string readfile, string writefile)
        {

            // асинхронное чтение
            using (StreamReader reader = new StreamReader(readfile))
            {
                using (StreamWriter writer = new StreamWriter(writefile, false))
                {
                    string? tmp;
                    while ((tmp = reader.ReadLine()) != null)
                    {
                        SearchMail(ref tmp);
                        if (tmp.Contains("@")) writer.WriteLine(tmp);
                    }
                }
            }
        }
        public void SearchMail(ref string s)
        {
            var s_splits = s.Split('&');
            var email = s_splits[1].Trim();
            if (email.Contains("@")) s = email;
            else s = "";
        }
    }
}
