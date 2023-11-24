using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types(Değer Tipleri)
            // Console.WriteLine("Hello World!");
            //Console.Readline() ekranda okunmasını sağlıyor.Ekranda bir şeye basmamızı istiyor.
            // int : veri tipi , number1 : değişken adı.
            //{0} : Parametredir,virgülden sonraki ilk değeri yaz. 

            decimal number6 = 10.4m; //Hassas değerleri saklamak için kullanılır.Ondalık için
            //kullancaksan sayıdan sonra m koy küçük büyük olabilir,normal sayı ise direkt atayabilirsin.
            //Virgülden sonra 28-29 karakter tutabilir.
            double number5 = 10.4;//Ondalık sayıları tutar,int de tutabilir.64 bitlik yer kaplar.
            //Virgülden sonra 15-16 karakter tutabilir.
            char character = 'A';//Atama yapmak için tek tırnak kullanılır.Karakter veri tipi (int) character
            //yazılarak int olarak da sayı değeri bulabiliriz ,int e çevirmiş oluruz.
            string city = "Ankara";//6 tane karakterden oluşan bir dizidir.
            bool condition = true; //Mantıksal veri tipi.İf gibi karşılaştırma bloklarında kullanılır.1 Byte.Condition=Şart
            byte number4 = 0; // 8 bit. 0|255
            short number3 = -32768; // 16 bit. -32768|32767
            int number1 = 2147483647;//Sınırları vardır.-2147483648|2147483647.Bellekte 32 bitlik yer kaplar.
            long number2 = 9223372036854775807;//64 bit.İntı kapsar.-9223372036854775808 |9223372036854775807
            var number7 = 10;//Yaptığımızda var'ın tuttuğu number7 nin veri tipi int olur.
            //Var keyword.Değişken değildir.Değişken tutmak için kullanılır.
            number7 = 'A';// 65 yazacak.Başta int atadığımız için bundan sonraki her şey int olarak kabul edilir.
            // number7="A"; yapamazsın.Biz başta int tanımladık.Çünkü A bir string değişken.
            
            Console.WriteLine("Number1 is  {0} ", number1);
            Console.WriteLine("Number2 is  {0} ", number2);
            Console.WriteLine("Number3 is  {0} ", number3);
            Console.WriteLine("Number4 is  {0} ", number4);
            Console.WriteLine("Number5 is  {0} ", number5);
            Console.WriteLine("Number6 is  {0} ", number6);
            Console.WriteLine("Number7 is  {0} ", number7);
            Console.WriteLine("Condition is {0} ", condition);
            Console.WriteLine("Character is {0}", (int)character);
      

            Console.WriteLine(Days.Friday);//Bunda character de yaptığın gibi tip dönüşümü yapabilirsin.Başa int() koyarak.
            //Sonuçta da 4 olur.Çünkü 0 dan başladığında Friday 4 e denk geliyor.
            //Enum'ın içine Monday=10 yazarsan değerler 10'dan başlayarak artar.
            //Yanındakine farklı değer verirsen 20 gibi bu sefer 21'den itibaren artarak ilerler.
            Console.ReadLine();
                }
        
    }
    //Sen İf(Days. ...) yazdığında sana gün seçeneği çıkacak.
    //İf("Friday")= Magic string : Gün değerini her yerde değiştirmemek için bu şekilde kullanmamalıyız.
    enum Days //Tab a 2 kere bastığında gelir.Bu günleri bu şekilde yazmak string="Monday"; gibi tek tek yazmayı engelliyor.
    
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

}


