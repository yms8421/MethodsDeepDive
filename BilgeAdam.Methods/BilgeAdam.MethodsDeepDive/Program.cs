using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.MethodsDeepDive
{
    class Program
    {
        static void Main(string[] args)
        {
            //--Ders 1 - method overloading
            var sm = new SimpleMath();
            var b = sm.Sum(5, 6.4);

            var a = sm.Sum(10, sm.Sum(5, 6.4));
            var c = sm.Sum(10, b);
            var d = sm.Sum(4, 10, 5);
            var e = sm.Sum(new double[11] { 3, 5, 6, 2.3, 45, 0.76, 4, 12, 45, 7, 4 });
            var f = sm.Sum(new List<double> { 3, 5, 6, 2.3, 45, 0.76, 4 });

            var customNumber = new List<double> { 6, 22, 6, 20.135, 45, 0.76, 41 };
            var g = sm.Sum(customNumber.ToArray()[0], customNumber[3]);
            var h = sm.Sum(3, 4, 8, 5, 7, 2, 4, 7, 9, 12, 34, 56, 78, 12, 78, 34, 67, 4, 3, 8, 9, 2, 5, 7, 1);
            //h ile e nin tanımı neredeyse aynı ancak h için çağırılan 
            //method için diziyi haricen tanımlamaya gerek yok

            //--Ders 2 - Variables & Method parameters
            var tv = new TrainVariables();
            var lastName = "Perk";
            var upperLastName = tv.Capitalize(ref lastName);
            var number = 5;
            var oldNumber = number;
            var area = 17;
            var twoTimesOf5plus3 = tv.GetTwoTimes(ref number);
            var twoTimesOf17plus3 = tv.GetTwoTimes(ref area);
            //---
            var e1 = 5.6;
            var e2 = 8.3;
            int me1, me2;
            var areaOfPolygon = tv.GetArea(e1, e2, out me1, out me2);


            var numberArray = customNumber.ToArray();
            var length = numberArray.Length;
            Array.Resize(ref numberArray, length + 1);
            Console.Write("Press any key to exit");
            Console.ReadKey();
        }
    }
}

/*
 method: void
 function : return type
*/
