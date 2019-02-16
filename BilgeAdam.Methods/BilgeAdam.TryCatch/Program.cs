using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                var calculated = false;
                try
                {
                    Console.Write("Adınız......: ");
                    var name = Console.ReadLine();
                    Console.Write("Yaşınız.....: ");
                    var age = Convert.ToInt32(Console.ReadLine());
                    var year = DateTime.Now.Year - age;
                    Console.WriteLine("Doğum Yılınız....: {0}", year);
                    calculated = true;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    if (!calculated)
                    {
                        Console.WriteLine("\nUygulamada bir hatalı işlem olduğundan cevap alamadınız");
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
