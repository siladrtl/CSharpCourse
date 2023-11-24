using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)

        {
            //string ile metinsel veri tiplerini kullanırız,referans veri tipidir.
            //ARRAY : Aynı tipteki değerleri ,değişkenleri tek bir noktada yönetip tek bir değişkenle yönetebiliriz.
            //Ona hızlıca ulaşmayı da sağlar.
            //Hangi değişken veri tipiyle çalışıyorsan onunla çalışmanı ister.(stringse string gibi)
            //Eğer veri tipi uygun olmazsa:compile time error

            string[] students = new string[3]; //Array tanımlama 1
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            //string[] students2 = new[] { "Engin", "Derin", "Salih" }; //Array tanımlama 2
            //students2 [3] = "Ahmet";    // Böyle yaparsan arraylerin sınırını aşmış olursun.
            //Burada 4.elemanı sormuş oluyor.
            //string[] students3 = { "Engin", "Derin", "Salih" }; //Array tanımlama 3
            //for each döngüsü bir arrrayi gezmek için kullanılır.
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            //Console.Writeline(); yaza da bilirsin yazmadan da çalıştı.
            Console.ReadLine();
            //multidimensional array : çok boyutlu dizi
            //Şimdi Türkiyenin bölgeleri ve bu bölgelerdeki 3 büyük şehri tutan diziyi oluşturalım.
            //İki boyutlu bir dizi oluşturalım.
            /*string[,] regions = new string[5,3];/5 satır 3 kolondan oluşuyor.
                 regions[0, 0] = "İstanbul";//0.bölgenin 0.şehri İstanbul.*/  //Tanımlama--->1

            string[,] regions = new string[4,2] 
            {
               { "İstanbul","İzmit"},
               {"Ankara","Konya"},
               {"Rize","Trabzon" },
               {"İzmir","Muğla" },
            };
            for (int i = 0; i <=regions.GetUpperBound(0);i++) //Get.Upper.Bound da 0 satırı temsil eder.
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++) //1 sütunu temsil eder.
                {
                    Console.WriteLine(regions[i, j]);

                }
                Console.WriteLine("******");

                
            }
            Console.ReadLine();
        }
        
    }
}
