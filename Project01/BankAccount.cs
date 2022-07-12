using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03
{
    enum AccountType { undefined, personal, company, federal };
    internal class BankAccount
    {
        private static int _number_counter = 100;


        private int _number;
        public int Number { get { return _number; } } // set нету, только в конструкторе


        private decimal _balance;
        public decimal Balance { get { return _balance; } set { _balance = value; } }


        private AccountType _type;
        public AccountType Type { get => _type; set => _type = value; }





        public BankAccount()
        {
            _number_counter++;
            _number = _number_counter;
            _balance = 0;
            _type = AccountType.undefined;
        }
        public BankAccount(decimal balance)
        {
            _number_counter++;
            _number = _number_counter;
            _balance = balance;
            _type = AccountType.undefined;
        }
        public BankAccount(AccountType type)
        {
            _number_counter++;
            _number = _number_counter;
            _balance = 0;
            _type = type;
        }
        public BankAccount(decimal balance, int type)
        {
            _number_counter++;
            _number = _number_counter;
            _balance = balance;
            _type = (AccountType)type;
        }


        public bool TransferToThisAccount(ref BankAccount fromAccount, int sum)
        {
            if (fromAccount.Balance < sum) return false;
                    else
            {
                fromAccount.Balance = fromAccount.Balance - sum;
                _balance = _balance + sum;
                return true;
            }
        }


    }
}
