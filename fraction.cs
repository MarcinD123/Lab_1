using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class fraction : IComparable<fraction>
    {
        
        public int CompareTo(fraction other)
        {
            if (other == null) return 0;
            else return 1;
        }

        
        private int numerator;
        private int denominator;
        
        //constructors
        public fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public fraction(int a)
        {
            numerator = a;
            denominator = a;
        }



        //operator overriding
        public static fraction operator +(fraction a, fraction b)
        {


            return new fraction(a.numerator * b.denominator + b.numerator * a.denominator, a.denominator * b.denominator);

        }

        public static fraction operator -(fraction a, fraction b)
        {


            return new fraction((a.numerator * b.denominator - b.numerator * a.denominator) / (a.denominator * b.denominator));
            
        }
        public static fraction operator *(fraction a, fraction b)
        {


            return new fraction(a.numerator * b.numerator, a.denominator * b.denominator);

        }
        public static fraction operator /(fraction a, fraction b)
        {


            return new fraction(a.numerator * b.denominator,  b.numerator * a.denominator);
        }
        //to string
        public override string ToString()
        {
            return this.numerator + "/" + this.denominator;
        }
    }
}
