using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction_calculator
{
    class Fraction
    {
        //поля класса
        private int Numerator; //числитель
        private int Denominator; //знаменатель

        //конструкторы
        public Fraction(int num, int denum)
        {
            Numerator = num;
            Denominator = denum;
        }       

        //метод нахождения наибольшего общего делителя 
        private static int NOD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public Fraction Normalization()
        {
            var n = Math.Abs(Numerator);
             var d = Math.Abs(Denominator);
            var nod = NOD(n, d);
            var sign = Math.Sign(Numerator * Denominator);
            return new Fraction(sign * n / nod, d / nod);
        }
        //метод сложения дробей
        public static Fraction Sum(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Denominator + b.Numerator * a.Denominator, a.Denominator * b.Denominator).Normalization();
        }

        //метод вычитания дробей
        public static Fraction Sub(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Denominator - b.Numerator * a.Denominator, a.Denominator * b.Denominator).Normalization();
        }

        //метод умножения дробей
        public static Fraction Mul(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator).Normalization();
        }

        //метод деления дробей
        public static Fraction Div(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Denominator, a.Denominator * b.Numerator).Normalization();
        }

        //метод вывода ответа (строковое представление)
        public override string ToString()
        {
            return Numerator.ToString() + "/" + Denominator.ToString();
        }

        public string getNumerator()
        {
            return Numerator.ToString();
        }
        public string getDenominator()
        {
            return Denominator.ToString();
        }


    }
}
