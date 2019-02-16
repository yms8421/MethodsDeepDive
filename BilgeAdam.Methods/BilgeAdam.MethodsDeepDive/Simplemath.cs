using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.MethodsDeepDive
{
    /*  Methodlar aynı isimde olabilirler
     *  -> Methodların imzaları vardır
     *      -> Adı
     *      -> Parametre tipleri ve sırası
     *  İmzası farklı olan methodlar isimleri aynı ise birbirinin [overload]'ıdır!!
     */ 
    class SimpleMath
    {
        public double Sum(double number1, double number2)
        {
            return number1 + number2;
        }

        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        public double Sum(double number1, double number2, double number3)
        {
            return Sum(number1, number2) + number3;
        }

        public double Sum(double[] numbers)
        {
            var sum = 0D;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public double Sum(List<double> numbers)
        {
            var sum = 0D;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public double Sum(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}
