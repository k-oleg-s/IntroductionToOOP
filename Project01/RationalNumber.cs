using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05
{
    internal  class RationalNumber
    {

        private int _c;
        private int _z;

        public RationalNumber(int c, int z)
        {
            _c = c;
            if (z > 0) _z = z; else throw new Exception("знаменатель должен быть >0");
        }

        public override string ToString()
        {
            return $"числитель:{_c}, знаменатель:{_z}";
        }

        //Определить операторы ==, != (метод Equals()), <, >, <=, >=, +, – , ++, --.

        public static RationalNumber operator + (RationalNumber r1, RationalNumber r2)
        {
             RationalNumber r3 = new RationalNumber(1, 1);
            int c3 = (r1._c * r2._z + r2._c*r1._z);
            int z3=  (r1._z*r2._z);
            r3._c=c3;
            r3._z=z3;
            return r3;
        }

        public static RationalNumber operator - (RationalNumber r1, RationalNumber r2)
        {
            RationalNumber r3 = new RationalNumber(1, 1);
            int c3 = (r1._c * r2._z - r2._c * r1._z);
            int z3 = (r1._z * r2._z);
            r3._c = c3;
            r3._z = z3;
            return r3;
        }

        public static RationalNumber operator ++(RationalNumber r1)
        {
            RationalNumber r3 = new RationalNumber(1, 1);
            int c3 = (r1._c  + 1);
            int z3 = r1._z;
            r3._c = c3;
            r3._z = z3;
            return r3;
        }

        public static bool operator == (RationalNumber r1, RationalNumber r2)
        {
            if (r1._c==r2._c && r1._z==r2._z)
            return true ;
            else return false ;
        }

        public static bool operator !=(RationalNumber r1, RationalNumber r2)
        {
            if (r1._c != r2._c || r1._z != r2._z)
                return true;
            else return false;
        }




        //        операторы преобразования типов между типом дробь, float, int.

        public static implicit operator float(RationalNumber x)
        {
            return (float) x._c / x._z;
        }

        public static implicit operator int(RationalNumber x)
        {
            return (int)(x._c / x._z);
        }

        public static explicit operator RationalNumber(int x)
        {
            return new(x, 1);
        }

        //Определить операторы *, /, %.

        public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
        {
            RationalNumber r3 = new RationalNumber(1, 1);
            int c3 = (r1._c * r2._c);
            int z3 = r1._z * r2._z;
            r3._c = c3;
            r3._z = z3;
            return r3;
        }

        public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
        {
            RationalNumber r3 = new RationalNumber(1, 1);
            int c3 = (r1._c * r2._z);
            int z3 = r1._z * r2._c;
            r3._c = c3;
            r3._z = z3;
            return r3;
        }

    }
}
