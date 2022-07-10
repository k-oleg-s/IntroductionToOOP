using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class BankAccountTask2    {

        private static int _number_counter=100;


        private int _number;
        public int Number { get { return _number; }  } // set нету, только в конструкторе


        private decimal _balance;
        public decimal Balance { get { return _balance; } set { _balance = value; } }


        private account_type _type;
        public account_type Type { get => _type; set => _type = value; }



        public BankAccountTask2()
        {
            _number_counter++;
            _number = _number_counter;
            _balance = 0;
            _type = account_type.undefined;
        }
        public BankAccountTask2(decimal balance)
        {
            _number_counter++;
            _number = _number_counter;
            _balance = balance;
            _type = account_type.undefined;
        }
        public BankAccountTask2(account_type type)
        {
            _number_counter++;
            _number = _number_counter;
            _balance = 0;
            _type = type;
        }
        public BankAccountTask2(decimal balance, int type)
        {
            _number_counter++;
            _number = _number_counter;
            _balance = balance;
            _type = (account_type)type;
        }

        
        public string  PutOnAccount(int x)
        {
            _balance = _balance + x;
            return "Остаток на счёте: " + _balance.ToString();
        }

        public string TakeFromAccount(int x)
        {
            if (_balance >= x)
            {
                _balance = _balance - x;
                return "Остаток на счёте: " + _balance.ToString();
            }
            else
                return "Недостаточно средств";
        }




    }
}
