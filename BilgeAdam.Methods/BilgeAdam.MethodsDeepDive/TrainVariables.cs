using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.MethodsDeepDive
{
    class TrainVariables
    {
        public string Capitalize(ref string text)
        {
            text = text.Substring(2);
            return text.ToUpper();
        }
        /// <summary>
        /// Aldığı parametreye 3 ekleyerek 2 katını döner
        /// </summary>
        /// <param name="number">hesaplanacak değişken, ancak "referans type" gibi davranarak aynı ram adresinden veriyi çeker</param>
        /// <returns>number</returns>
        public int GetTwoTimes(ref int number)
        {
            number = number + 3;
            return number * 2;
        }

        public int GetArea(double edge1, double edge2, out int outedEdge1, out int outedEdge2)
        {
            outedEdge1 = Convert.ToInt32(edge1);
            outedEdge2 = Convert.ToInt32(edge2);
            return Convert.ToInt32(outedEdge1 * outedEdge2);
        }
    }
}

/*
 Referans Type : class
 Value Type    : struct
     */
