using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Ders
{
    class Program
    {
        static void Main(string[] args)
        {
            #region yazdırma işlemleri
            //Console.WriteLine("hello world");
            //Console.Write("hello");

            //Console.WriteLine("********yemek menüsü********");
            //Console.WriteLine("1. çorbalar");
            //Console.WriteLine("2. ana yemekler");
            //Console.WriteLine();
            //Console.WriteLine("*****yemek menüsü******");
            //yazarken değişkenleri yerleştimek için $ kullanılır
            //Console.Write($"birinci sınav notu: {değişken1}\nikinci sınav notu: {değişken2}\nüçüncü sınav notu: {değişken3}\nortlama: {değişken4}");
            #endregion

            #region String Değişkenler

            //string
            //değişken türü   değişken adı;
            // string değişkenAdı;
            string name;
            name = "hasan";
            Console.WriteLine(name);

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail;

            customerName = "hasan";
            customerSurname = "çelenk";
            customerPhone = "09053939393";
            customerEmail = "hasan@gmail.com";

            Console.WriteLine("müşteri adı: " + customerName + " " + "müşteri soyadı: " + customerSurname + " " + "müşteri telefon: " + customerPhone + " " + "müşteri email:  "+customerEmail);

            #endregion

            #region İnt Değişkenler
            //int değişkenAdı;
            int money;
            int height;
            int age;
            int point;
            money = 100;
            height = 187;
            age = 34;
            point = 45;
            Console.WriteLine(age+height+point+money);
            int total= age + point;
            Console.WriteLine(total);
            #endregion


            Console.Read();
        }
    }
}
