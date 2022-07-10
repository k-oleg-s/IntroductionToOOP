using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    enum account_type { undefined, personal, company, federal };
    internal class BankAccountTask1
    {
        private  int _number;
        private decimal _balance;
        private account_type _type;





        public void  set_num(int num)
        {
            _number = num;
        }
        public int get_num()
        {
            return _number;
        }

        public void set_balance(int b)
        {
            _balance = b;
        }
        public decimal get_balance()
        {
            return _balance;
        }

        public void set_type(account_type t)
        {
            _type = t;
        }
        public string get_type()
        {
            return _type.ToString();
        }


    }
}
