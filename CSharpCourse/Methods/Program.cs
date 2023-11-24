using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        // Metotlar neden yazılır : Diyelim ki sizin veri tabanına bir kullanıcının bilgilerini kaydetme işleminiz var.
        //Sen kaydetme işlemini her yaptığında sürekli yazarsan bir şey eklediğinde onlarca yeri değiştirmek gerekir
        //Metot sayesinde tek merkezde kontrol sağlayabiliyoruz o metot üzerinde değişiklik yapmak yeterli.
        static void Main(string[] args)
        {
            Add();//Metodun çağrımını gerçekleştirdik.
            Add();
            // Add2(20, 30); bu şekilde yazarsan ekranda 50 değerini görmezsin.
            var result = Add2(20, 30);//Elimizdeki resultın metodun çalışmasıyla ortaya çıkan integerdır.
            Console.WriteLine(result);
            var toplama = Add3(20);
            Console.WriteLine(toplama);
            var toplamaX = Add4(4);//Buradaki değeri x e verdik.
            Console.WriteLine(toplamaX);


            Console.ReadLine();

        }
        static void Add() //Metodu yazdık.
        {
            Console.WriteLine("Added !");
        }
        static int Add2(int number1, int number2)// void yerine int yazdık (hangi tipte döndürüyorsa o yazılır)
                                                 //  void git işlemi yap, git şunu yap  anlamına geliyor.


        {
            var result = number1 + number2; // var yerine int de diyebiliriz.
            return result; // her şey int result da int olmalı. 
        }
        static int Add3(int number1, int number2 = 30)// int number2=default parametre 
                                                      //number1 e  default değer verip number2 e değer vermemezlik yapamazsın.
                                                      //hem number1 e hem de number 2 ye değer verebilirsin.

        //Default değerler her zaman metodun en sonunda olmalıdır.
        //Yani birden fazla default değer verebilirsin ama bunların metodun en sonunda olması gerekir

        {
            var toplama = number1 + number2;

            return toplama;
        }
        static int Add4(int x, int number1 = 30, int number2= 40)
        {


            var toplamaX = x + number1 + number2;

            return toplamaX;
        }
    }
}
