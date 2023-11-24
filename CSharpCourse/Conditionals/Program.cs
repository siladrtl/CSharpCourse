using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 10;
            //if (number == 11)  // Eğer sayı 10 ise demek .if'den sonraki parantezin içi şart bloğuna karşılık gelir.
            //                   //sayı 10 ise { } içi çalışır.

            //{
            //    Console.WriteLine("Number is 11.");
            //}

            //else if (number == 20)
            //{
            //    Console.WriteLine("Number is 20.");
            //}

            //else
            //{
            //    Console.WriteLine("Number is not 11 or 20.");//Else bu iki şartın sağlanmadığı durumda çalışır.
            //}

            //switch (number)
            //{
            //    case 11:
            //        Console.WriteLine("Number is 10.");
            //        break;
            //    case 20:
            //        Console.WriteLine("Number is 20.");
            //        break;
            //    default:
            //        Console.WriteLine("Number is not 11 or 20 .");
            //        break;

            //}


            //Single Line İf :
            //Console.Writeline(number == 10 ? "Number is 10." : "Number is not 10."); yazarak da farklı şekilde çalıştırabilirsin.

            //if (number >= 0 && number <= 100)
            //{
            //    Console.WriteLine("Number is betweeen 0-100");
            //}
            //else if (number > 100 && number <= 200)
            //{
            //    Console.WriteLine("Number is between 101-200");
            //}
            //else if (number < 0 || number > 200)
            //{
            //    Console.WriteLine("Number is less than 0 or greater than 200");
            //}


            if (number < 100)
            {
                if (number >= 90 && number < 95) //Arasında if , else if , else blokları da olabilir.x
                {

                }
            }
            Console.ReadLine();
        }
    }
}




