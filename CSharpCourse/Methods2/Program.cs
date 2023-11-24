using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
         int number7 = 20; //Buradalardaki tanımlamalarla number7 ve number8 e değer atadık Add6 20 ve 100 ile gidiyor.(Değer tipleri)
         int number8 = 100; //number7 nin burayla ilişkisi 20 değerini verip devreye girmemektir.
            var result2 = Add6(number7, number8); //
            Console.WriteLine(result2);  //Bunun sonucu 130
            Console.WriteLine(number7); //Burada yazdırılan değer ise 20 

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));
            Console.WriteLine(Add4(1,2,3,4,5,6));//Params'ı gördük,istediğin kadar parametre yolla.
            Console.ReadLine();
        }

        static int Multiply(int number9, int number10)
        {
            return number9 * number10;
        }
        static int Multiply(int number9,int number10, int number11)
        {
            return number9 * number10 * number11;
        }
        static int Add6(int number7, int number8)
        {
            number7 = 30;
            return number7 + number8;
            // Eğer 20 değişsin 30 olsun istiyorsan metodu çağırırken number7 önüne ve metodu oluştururken de number7 önüne ref koy
            //REF KEYWORD : Değer tiplerinin referans tipleri gibi kullanılmasını sağlar.
            // OUT KEYWORD : Ref yerine kullanılabilir.Farkı int number7= 20 ; yapmııştın ya  bunu ref de yapmak zorundasın ama 
            // out da yapmak zorunda değilsin.
            //Direkt int number7; de yapabilirsin.
            //out da şöyle bir durum var sen diyelim 20 e eşitledin metodun içinde ise 30 a eşitlemedin o zaman sıkıntı olur
            //yani önceden 20 ye eşitlemenin hiçbir anlamı yok,önemli olan metodun içinde 30 a eşitlemek.
        }
        //METHOD OVERLOADİNG
        //Diyelim ki sen 3 sayıyı çarpmak istiyorsun.Bunu Multiply2(...) metodu oluşturarak yapabilirsin
        //Ya da metodun imzasını kullanarak da yapabilirsin.
        //     int Multiply(int number9, int number10)  ------> Metodun İmzası 


        //PARAMS KEYWORD : 50-100 tane sayıyı çarpmak için overloading mi yapacaksın 
        //Bunun için params keywordü var.
        //Params , metodumuza aynı tipte istediğimiz kadar parametre gönderebileceğimiz anlamına geliyor.

        static int Add4 (int number1 ,params int [] numbers ) //int number1 parametresi ilk yollanan 1'e eşittir.
            // Toplama işlemine dahil olmaz.
            //Params ile belirtilen parametre metodun parametrelerinin en sonuncusu olmalı !
        {
            return numbers.Sum ();//params  ile yollana parametreleri toplayan fonksiyon.
        }

    }
}








