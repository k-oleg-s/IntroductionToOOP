using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06
{
    public enum BType { personal, company };
    internal class BankAccount
    {
        private static int _number;
        public int Number { get; }

        private BType _type;

        private decimal _sum;
        public decimal Sum { get { return _sum; } set { _sum = value; } }

        internal BankAccount(BType type)
        {
            _number++;
            Number = _number;
            this._type = type;
        }

        public static bool operator ==(BankAccount a1, BankAccount a2)
        {
            return a1._sum == a2._sum && a1._type == a2._type;
        }

        public static bool operator !=(BankAccount a1, BankAccount a2)
        {
            return a1._sum != a2._sum || a1._type != a2._type;
        }
        public override bool Equals(Object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != typeof(BankAccount)) return false;
            var other = (BankAccount)obj;
            return this == other;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_number, _type);
        }

        public override string ToString()
        {
            return $" number:{Number} type:{_type} sum:{_sum}  ";
        }
    }
}
